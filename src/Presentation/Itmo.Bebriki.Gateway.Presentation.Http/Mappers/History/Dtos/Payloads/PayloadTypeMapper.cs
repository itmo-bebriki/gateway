using Itmo.Bebriki.Analytics.Contracts;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos.Payloads;
using System.ComponentModel;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.History.Dtos.Payloads;

internal static class PayloadTypeMapper
{
    internal static BasePayload ToInternal(Payload payload)
    {
        if (payload.PayloadTypeCase == Payload.PayloadTypeOneofCase.Create)
        {
            return new CreatePayload(
                JobTaskId: payload.Create.JobTaskId,
                Title: payload.Create.Title,
                Description: payload.Create.Description,
                AssigneeId: payload.Create.AssigneeId,
                Priority: JobTaskPriorityMapper.ToInternal(payload.Create.Priority),
                DependsOnIds: payload.Create.DependsOnIds.ToArray(),
                Deadline: payload.Create.Deadline?.ToDateTimeOffset(),
                CreatedAt: payload.Create.CreatedAt.ToDateTimeOffset());
        }

        if (payload.PayloadTypeCase == Payload.PayloadTypeOneofCase.Update)
        {
            return new UpdatePayload(
                JobTaskId: payload.Update.JobTaskId,
                Title: payload.Update.Title,
                Description: payload.Update.Description,
                AssigneeId: payload.Update.AssigneeId,
                State: JobTaskStateMapper.ToInternal(payload.Update.State),
                Priority: JobTaskPriorityMapper.ToInternal(payload.Update.Priority),
                Deadline: payload.Update.DeadLine?.ToDateTimeOffset(),
                IsAgreed: payload.Update.IsAgreed,
                UpdatedAt: payload.Update.UpdatedAt.ToDateTimeOffset());
        }

        if (payload.PayloadTypeCase == Payload.PayloadTypeOneofCase.Dependency)
        {
            return new DependencyPayload(
                JobTaskId: payload.Dependency.JobTaskId,
                ChangedDependencies: payload.Dependency.ChangedDependencies.ToArray());
        }

        throw new InvalidEnumArgumentException("incorrect payload type");
    }
}
