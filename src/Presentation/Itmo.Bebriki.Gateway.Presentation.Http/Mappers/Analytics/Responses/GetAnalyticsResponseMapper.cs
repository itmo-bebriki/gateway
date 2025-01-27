using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Analytics.Responses;

internal static class GetAnalyticsResponseMapper
{
    internal static GetAnalyticsResponse ToInternal(Itmo.Bebriki.Analytics.Contracts.GetAnalyticsResponse response)
    {
        return new GetAnalyticsResponse(
            CreatedAt: response.CreatedAt?.ToDateTimeOffset(),
            LastUpdate: response.LastUpdate?.ToDateTimeOffset(),
            StartedAt: response.StartedAt?.ToDateTimeOffset(),
            TimeSpent: (long?)response.TimeSpent?.ToTimeSpan().TotalSeconds,
            HighestPriority: JobTaskPriorityMapper.ToInternal(response.HighestPriority),
            CurrentState: JobTaskStateMapper.ToInternal(response.CurrentState),
            AmountOfAgreements: response.AmountOfAgreements,
            TotalUpdates: response.TotalUpdates,
            AmountOfUniqueAssignees: response.AmountOfUniqueAssignees,
            AmountOfUniqueDependencies: response.AmountOfUniqueDependencies);
    }
}
