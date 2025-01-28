using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Enums;

[SwaggerSchema(Description = "A model that represents a job task state.")]
public enum JobTaskState
{
    None = 0,
    PendingApproval = 1,
    Approved = 2,
    Rejected = 3,
}
