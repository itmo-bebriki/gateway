using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

[JsonDerivedType(typeof(CreatePayload), typeDiscriminator: "create")]
[JsonDerivedType(typeof(UpdatePayload), typeDiscriminator: "update")]
[JsonDerivedType(typeof(DependencyPayload), typeDiscriminator: "dependency")]
[SwaggerSchema(Description = "Represents the base payload for a history event.")]
[SwaggerSubType(typeof(CreatePayload))]
[SwaggerSubType(typeof(UpdatePayload))]
[SwaggerSubType(typeof(DependencyPayload))]
public abstract record BasePayload(long JobTaskId);
