using Itmo.Bebriki.Agreement.Contracts;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Reponses;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Requests;
using ApproveAgreementRequest =
    Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests.ApproveAgreementRequest;
using QueryAgreementRequest = Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests.QueryAgreementRequest;
using QueryAgreementResponse =
    Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Responses.QueryAgreementResponse;
using RejectAgreementRequest = Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests.RejectAgreementRequest;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public sealed class AgreementClient
{
    private readonly AgreementService.AgreementServiceClient _client;

    public AgreementClient(AgreementService.AgreementServiceClient client)
    {
        _client = client;
    }

    public async Task<QueryAgreementResponse> QueryAgreementAsync(
        QueryAgreementRequest request,
        CancellationToken cancellationToken)
    {
        Agreement.Contracts.QueryAgreementRequest grpcRequest =
            QueryAgreementRequestMapper.FromInternal(request);
        Agreement.Contracts.QueryAgreementResponse grpcResponse =
            await _client.QueryAgreementsAsync(grpcRequest, cancellationToken: cancellationToken);

        QueryAgreementResponse response = QueryAgreementResponseMapper.ToInternal(grpcResponse);

        return response;
    }

    public async Task ApproveAgreementAsync(
        ApproveAgreementRequest request,
        CancellationToken cancellationToken)
    {
        Agreement.Contracts.ApproveAgreementRequest grpcRequest = ApproveAgreementRequestMapper.FromInternal(request);

        await _client.ApproveAgreementAsync(grpcRequest, cancellationToken: cancellationToken);
    }

    public async Task RejectAgreementAsync(
        RejectAgreementRequest request,
        CancellationToken cancellationToken)
    {
        Agreement.Contracts.RejectAgreementRequest grpcRequest = RejectAgreementRequestMapper.FromInternal(request);

        await _client.RejectAgreementAsync(grpcRequest, cancellationToken: cancellationToken);
    }
}