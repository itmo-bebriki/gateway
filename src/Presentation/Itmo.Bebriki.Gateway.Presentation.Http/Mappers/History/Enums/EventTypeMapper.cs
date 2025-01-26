using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Enums;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Enums;

internal static class EventTypeMapper
{
    internal static EventType ToInternal(Itmo.Bebriki.Analytics.Grpc.Contracts.EventType eventType)
    {
        return eventType switch {
            Bebriki.Analytics.Grpc.Contracts.EventType.Unspecified => EventType.Unspecified,
            Bebriki.Analytics.Grpc.Contracts.EventType.Creation => EventType.Creation,
            Bebriki.Analytics.Grpc.Contracts.EventType.Update => EventType.Update,
            Bebriki.Analytics.Grpc.Contracts.EventType.NewDeps => EventType.NewDependency,
            Bebriki.Analytics.Grpc.Contracts.EventType.PruneDeps => EventType.PruneDependency,
            _ => throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null),
        };
    }

    internal static Itmo.Bebriki.Analytics.Grpc.Contracts.EventType FromInternal(EventType eventType)
    {
        return eventType switch {
            EventType.Unspecified => Bebriki.Analytics.Grpc.Contracts.EventType.Unspecified,
            EventType.Creation => Bebriki.Analytics.Grpc.Contracts.EventType.Creation,
            EventType.Update => Bebriki.Analytics.Grpc.Contracts.EventType.Update,
            EventType.NewDependency => Bebriki.Analytics.Grpc.Contracts.EventType.NewDeps,
            EventType.PruneDependency => Bebriki.Analytics.Grpc.Contracts.EventType.PruneDeps,
            _ => throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null),
        };
    }
}
