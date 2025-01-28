using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

[SwaggerSchema("Request model for approving an agreement.")]
public sealed class ApproveAgreementRequest
{
    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "agreement_id")]
    [property: SwaggerSchema("An id of agreement to be approved.")]
    public long AgreementId { get; set; }
}
