using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Dtos;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Reponses;

internal static class QueryAgreementResponseMapper
{
    internal static QueryAgreementResponse ToInternal(Agreement.Contracts.QueryAgreementResponse response)
    {
        return new QueryAgreementResponse(
            Cursor: response.Cursor,
            Agreements: response.Agreements.Select(AgreementDtoMapper.ToInternal).ToArray());
    }
}