using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Requests;

internal static class RejectAgreementRequestMapper
{
    internal static Agreement.Contracts.RejectAgreementRequest FromInternal(RejectAgreementRequest request)
    {
        return new Agreement.Contracts.RejectAgreementRequest
        {
            AgreementId = request.AgreementId,
        };
    }
}