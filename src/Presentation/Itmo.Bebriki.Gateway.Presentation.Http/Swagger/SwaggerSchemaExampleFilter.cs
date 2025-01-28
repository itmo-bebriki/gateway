using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Swagger;

public class SwaggerSchemaExampleFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        SwaggerSchemaExampleAttribute? schemaAttribute = context.MemberInfo
            ?.GetCustomAttributes<SwaggerSchemaExampleAttribute>()
            .FirstOrDefault();

        if (schemaAttribute is not null)
        {
            schema.Example = new Microsoft.OpenApi.Any.OpenApiString(schemaAttribute.Example);
        }
    }
}
