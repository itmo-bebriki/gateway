using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

[SwaggerSchema("Request model for rejecting agreements.")]
public sealed class RejectAgreementRequest
{
    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "agreement_id")]
    [property: SwaggerSchema("An id of agreement to be rejected.")]
    [property: SwaggerSchemaExample("10")]
    public long AgreementId { get; set; }
}
