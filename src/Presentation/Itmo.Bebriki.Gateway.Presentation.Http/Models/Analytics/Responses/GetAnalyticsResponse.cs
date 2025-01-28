using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Analytics.Responses;

[SwaggerSchema(Description = "Response model for fetching analytics.")]
public sealed record GetAnalyticsResponse(
    [property: SwaggerSchema("A datetime of creation.")]
    [property: SwaggerSchemaExample("2026-01-01T00:00:00.0000000Z")]
    DateTimeOffset? CreatedAt,

    [property: SwaggerSchema("A datetime of last update.")]
    [property: SwaggerSchemaExample("2026-01-01T00:00:00.0000000Z")]
    DateTimeOffset? LastUpdate,

    [property: SwaggerSchema("A datetime of starting this task.")]
    [property: SwaggerSchemaExample("2026-01-01T00:00:00.0000000Z")]
    DateTimeOffset? StartedAt,

    [property: SwaggerSchema("A time spent in seconds for reaching the first agreement for this task.")]
    [property: SwaggerSchemaExample("12345")]
    long? TimeSpent, // using TimeSpan with OneOfForPolymorphism setting breaks Swagger, unfortunately.

    [property: SwaggerSchema("The highest priority of the task.")]
    [property: SwaggerSchemaExample("Critical")]
    JobTaskPriority HighestPriority,

    [property: SwaggerSchema("The current state of the task.")]
    [property: SwaggerSchemaExample("Approved")]
    JobTaskState CurrentState,

    [property: SwaggerSchema("Amount of agreements this task received ever.")]
    [property: SwaggerSchemaExample("10")]
    int AmountOfAgreements,

    [property: SwaggerSchema("Amount of total times this task was updated.")]
    [property: SwaggerSchemaExample("15")]
    int TotalUpdates,

    [property: SwaggerSchema("Amount of unique assignees of this task ever.")]
    [property: SwaggerSchemaExample("2")]
    int AmountOfUniqueAssignees,

    [property: SwaggerSchema("Amount of unique dependencies of this task ever.")]
    [property: SwaggerSchemaExample("3")]
    int AmountOfUniqueDependencies);
