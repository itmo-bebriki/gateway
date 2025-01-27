using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Requests;

internal static class ApproveAgreementRequestMapper
{
    internal static Agreement.Contracts.ApproveAgreementRequest FromInternal(ApproveAgreementRequest internalRequest)
    {
        return new Agreement.Contracts.ApproveAgreementRequest
        {
            AgreementId = internalRequest.AgreementId,
        };
    }
}