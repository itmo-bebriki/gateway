using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;

[SwaggerSchema(Description = "Request model for querying topics.")]
public class QueryTopicRequest
{
    [BindProperty(Name = "topic_ids")]
    [property: SwaggerSchema("Topic IDs to fetch.")]
    [property: SwaggerSchemaExample("1,2,3")]
    public long[] TopicIds { get; set; } = [];

    [BindProperty(Name = "from_updated_at")]
    [property: SwaggerSchema("A lower bound for timestamp of last update.", Nullable = true)]
    [property: SwaggerSchemaExample("2025-01-01T00:00:00Z")]
    public DateTimeOffset? FromUpdatedAt { get; set; }

    [BindProperty(Name = "to_updated_at")]
    [property: SwaggerSchema("An upper bound for timestamp of last update.", Nullable = true)]
    [property: SwaggerSchemaExample("2025-01-01T00:00:00Z")]
    public DateTimeOffset? ToUpdatedAt { get; set; }

    [BindProperty(Name = "cursor")]
    [property: SwaggerSchema("A topic id to query from.", Nullable = true)]
    [property: SwaggerSchemaExample("1")]
    public long? Cursor { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    [BindProperty(Name = "page_size")]
    [property: SwaggerSchema("A page size for paged query.")]
    [property: SwaggerSchemaExample("5")]
    public int PageSize { get; set; }
}
