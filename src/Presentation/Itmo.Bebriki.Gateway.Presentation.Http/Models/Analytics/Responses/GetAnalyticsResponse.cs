using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses;

public sealed record GetAnalyticsResponse(
    DateTimeOffset? CreatedAt,
    DateTimeOffset? LastUpdate,
    DateTimeOffset? StartedAt,
    long TimeSpent, // using TimeSpan with OneOfForPolymorphism setting breaks Swagger, unfortunately.
    JobTaskPriority HighestPriority,
    JobTaskState CurrentState,
    int AmountOfAgreements,
    int TotalUpdates,
    int AmountOfUniqueAssignees,
    int AmountOfUniqueDependencies);
