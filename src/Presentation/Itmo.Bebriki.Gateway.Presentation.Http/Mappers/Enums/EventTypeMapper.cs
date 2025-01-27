using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;

internal static class EventTypeMapper
{
    internal static EventType ToInternal(Itmo.Bebriki.Enums.EventType eventType)
    {
        return eventType switch {
            Itmo.Bebriki.Enums.EventType.Unspecified => EventType.Unspecified,
            Itmo.Bebriki.Enums.EventType.Creation => EventType.Creation,
            Itmo.Bebriki.Enums.EventType.Update => EventType.Update,
            Itmo.Bebriki.Enums.EventType.NewDeps => EventType.NewDependency,
            Itmo.Bebriki.Enums.EventType.PruneDeps => EventType.PruneDependency,
            _ => throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null),
        };
    }

    internal static Itmo.Bebriki.Enums.EventType FromInternal(EventType eventType)
    {
        return eventType switch {
            EventType.Unspecified => Itmo.Bebriki.Enums.EventType.Unspecified,
            EventType.Creation => Itmo.Bebriki.Enums.EventType.Creation,
            EventType.Update => Itmo.Bebriki.Enums.EventType.Update,
            EventType.NewDependency => Itmo.Bebriki.Enums.EventType.NewDeps,
            EventType.PruneDependency => Itmo.Bebriki.Enums.EventType.PruneDeps,
            _ => throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null),
        };
    }
}
