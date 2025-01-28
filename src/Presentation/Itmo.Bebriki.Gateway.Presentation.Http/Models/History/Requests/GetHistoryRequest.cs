using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Swagger;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Requests;

[SwaggerSchema(Description = "Request model for fetching event history.")]
public class GetHistoryRequest
{
    [BindProperty(Name = "ids")]
    [property: SwaggerSchema("Job task ids to fetch the related history.")]
    [property: SwaggerSchemaExample("1,2,3")]
    public long[] Ids { get; set; } = [];

    [BindProperty(Name = "event_types")]
    [property: SwaggerSchema("Event types to be fetched.")]
    [property: SwaggerSchemaExample("Creation,Update")]
    public EventType[] EventTypes { get; set; } = [];

    [BindProperty(Name = "from_timestamp")]
    [property: SwaggerSchema("A lower bound of event occurrence.", Nullable = true)]
    [property: SwaggerSchemaExample("2025-01-01T00:00:00Z")]
    public DateTimeOffset? FromTimestamp { get; set; } = DateTimeOffset.MinValue;

    [BindProperty(Name = "to_timestamp")]
    [property: SwaggerSchema("An upper bound of event occurrence.", Nullable = true)]
    [property: SwaggerSchemaExample("2025-01-01T00:00:00Z")]
    public DateTimeOffset? ToTimestamp { get; set; } = DateTimeOffset.MaxValue;

    [BindProperty(Name = "cursor")]
    [property: SwaggerSchema("An id of event to fetch from.", Nullable = true)]
    [property: SwaggerSchemaExample("-1")]
    public long Cursor { get; set; } = -1;

    [Required]
    [BindProperty(Name = "page_size")]
    [Range(1, int.MaxValue)]
    [property: SwaggerSchema("A page size for paged query.", Nullable = false)]
    [property: SwaggerSchemaExample("5")]
    public int PageSize { get; set; } = 1;
}
