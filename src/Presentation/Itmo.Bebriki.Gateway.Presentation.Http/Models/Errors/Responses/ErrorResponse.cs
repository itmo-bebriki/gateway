namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Errors.Responses;

public sealed record ErrorResponse(
    int StatusCode,
    string HttpStatusDescription,
    string Message);
