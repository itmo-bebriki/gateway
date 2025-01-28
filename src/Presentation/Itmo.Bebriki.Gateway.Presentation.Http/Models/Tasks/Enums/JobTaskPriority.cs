using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

[SwaggerSchema(Description = "A model that represents a job task priority.")]
public enum JobTaskPriority
{
    None = 0,
    Low = 1,
    Medium = 2,
    High = 3,
    Critical = 4,
}
