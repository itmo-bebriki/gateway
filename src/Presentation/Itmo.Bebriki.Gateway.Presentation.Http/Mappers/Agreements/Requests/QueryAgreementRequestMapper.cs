using Google.Protobuf.WellKnownTypes;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Requests;

internal static class QueryAgreementRequestMapper
{
    internal static Agreement.Contracts.QueryAgreementRequest FromInternal(QueryAgreementRequest request)
    {
        return new Agreement.Contracts.QueryAgreementRequest
        {
            AgreementIds = { request.AgreementIds },
            JobTaskIds = { request.JobTaskIds },
            AssigneeIds = { request.AssigneeIds },
            States = { request.States.Select(JobTaskStateMapper.FromInternal).ToArray() },
            FromDeadline = request.FromDeadline?.ToTimestamp(),
            ToDeadline = request.ToDeadline?.ToTimestamp(),
            FromCreatedAt = request.FromCreatedAt?.ToTimestamp(),
            ToCreatedAt = request.ToCreatedAt?.ToTimestamp(),
            Cursor = request.Cursor,
            PageSize = request.PageSize,
        };
    }
}