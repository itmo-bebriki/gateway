using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses;

[SwaggerSchema(Description = "Response model for fetching analytics.")]
public sealed record GetAnalyticsResponse(
    [property: SwaggerSchema("A datetime of creation.")]
    DateTimeOffset? CreatedAt,

    [property: SwaggerSchema("A datetime of last update.")]
    DateTimeOffset? LastUpdate,

    [property: SwaggerSchema("A datetime of starting this task.")]
    DateTimeOffset? StartedAt,

    [property: SwaggerSchema("A time spent in seconds for reaching the first agreement for this task.")]
    long? TimeSpent, // using TimeSpan with OneOfForPolymorphism setting breaks Swagger, unfortunately.

    [property: SwaggerSchema("The highest priority of the task.")]
    JobTaskPriority HighestPriority,

    [property: SwaggerSchema("The current state of the task.")]
    JobTaskState CurrentState,

    [property: SwaggerSchema("Amount of agreements this task received ever.")]
    int AmountOfAgreements,

    [property: SwaggerSchema("Amount of total times this task was updated.")]
    int TotalUpdates,

    [property: SwaggerSchema("Amount of unique assignees of this task ever.")]
    int AmountOfUniqueAssignees,

    [property: SwaggerSchema("Amount of unique dependencies of this task ever.")]
    int AmountOfUniqueDependencies);
