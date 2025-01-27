using Grpc.Core;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Errors.Responses;
using System.Net;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Middlewares;

public sealed class GrpcExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger<GrpcExceptionHandlingMiddleware> _logger;

    public GrpcExceptionHandlingMiddleware(ILogger<GrpcExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (RpcException rpcException)
        {
            _logger.LogError("gRPC error encountered: {Message}", rpcException.Status.Detail);
            await HandleGrpcExceptionAsync(context, rpcException);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occurred.");
            await HandleInternalExceptionAsync(context);
        }
    }

    private static Task HandleGrpcExceptionAsync(HttpContext context, RpcException rpcException)
    {
        HttpStatusCode httpStatus = MapGrpcStatusToHttpStatus(rpcException.Status.StatusCode);

        var response = new ErrorResponse(
            (int)httpStatus,
            httpStatus.ToString(),
            rpcException.Status.Detail);

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = response.StatusCode;

        return context.Response.WriteAsJsonAsync(response);
    }

    private static HttpStatusCode MapGrpcStatusToHttpStatus(StatusCode statusCode)
    {
        return statusCode switch
        {
            StatusCode.OK => HttpStatusCode.OK,
            StatusCode.Cancelled => HttpStatusCode.RequestTimeout,
            StatusCode.Unknown => HttpStatusCode.InternalServerError,
            StatusCode.InvalidArgument => HttpStatusCode.BadRequest,
            StatusCode.DeadlineExceeded => HttpStatusCode.GatewayTimeout,
            StatusCode.NotFound => HttpStatusCode.NotFound,
            StatusCode.AlreadyExists => HttpStatusCode.Conflict,
            StatusCode.PermissionDenied => HttpStatusCode.Forbidden,
            StatusCode.Unauthenticated => HttpStatusCode.Unauthorized,
            StatusCode.ResourceExhausted => HttpStatusCode.TooManyRequests,
            StatusCode.FailedPrecondition => HttpStatusCode.BadRequest,
            StatusCode.Aborted => HttpStatusCode.Conflict,
            StatusCode.OutOfRange => HttpStatusCode.BadRequest,
            StatusCode.Unimplemented => HttpStatusCode.NotImplemented,
            StatusCode.Internal => HttpStatusCode.InternalServerError,
            StatusCode.Unavailable => HttpStatusCode.ServiceUnavailable,
            StatusCode.DataLoss => HttpStatusCode.InternalServerError,
            _ => HttpStatusCode.InternalServerError,
        };
    }

    private static async Task HandleInternalExceptionAsync(HttpContext context)
    {
        var response = new ErrorResponse(
            (int)HttpStatusCode.InternalServerError,
            HttpStatusCode.InternalServerError.ToString(),
            "An unexpected error occurred.");

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        await context.Response.WriteAsJsonAsync(response);
    }
}
