using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;

[SwaggerSchema("Request model for updating board topics.")]
public class SetBoardTopicsRequest
{
    [MinLength(1)]
    [BindProperty(Name = "topic_ids")]
    [property: SwaggerSchema("Ids of topics to update.")]
    public long[] TopicIds { get; set; } = [];
}
