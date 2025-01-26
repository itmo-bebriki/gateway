using System.Text.Json.Serialization;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;

[JsonDerivedType(typeof(CreatePayload), typeDiscriminator: "create")]
[JsonDerivedType(typeof(UpdatePayload), typeDiscriminator: "update")]
[JsonDerivedType(typeof(DependencyPayload), typeDiscriminator: "dependency")]
public abstract record BasePayload(long JobTaskId);
