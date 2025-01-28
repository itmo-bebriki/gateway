namespace Itmo.Bebriki.Gateway.Presentation.Http.Swagger;

[AttributeUsage(
    AttributeTargets.Parameter |
    AttributeTargets.Struct |
    AttributeTargets.Class |
    AttributeTargets.Method |
    AttributeTargets.Property |
    AttributeTargets.Enum)]
public sealed class SwaggerSchemaExampleAttribute : Attribute
{
    public string Example { get; }

    public SwaggerSchemaExampleAttribute(string example)
    {
        Example = example;
    }
}
