using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Requests;

public sealed class RejectAgreementRequest
{
    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "agreement_id")]
    public long AgreementId { get; set; }
}