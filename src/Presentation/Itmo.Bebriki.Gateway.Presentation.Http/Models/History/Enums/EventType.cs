using Swashbuckle.AspNetCore.Annotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums;

[SwaggerSchema(Description = "Represents an event type.")]
public enum EventType
{
    Unspecified,
    Creation,
    Update,
    NewDependency,
    PruneDependency,
}
