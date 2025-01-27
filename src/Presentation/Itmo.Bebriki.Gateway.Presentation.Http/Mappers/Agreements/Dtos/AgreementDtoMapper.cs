using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Enums;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Agreements.Dtos;

internal static class AgreementDtoMapper
{
    internal static AgreementDto ToInternal(Agreement.Contracts.AgreementDto agreement)
    {
        return new AgreementDto(
            AgreementId: agreement.AgreementId,
            JobTaskId: agreement.JobTaskId,
            State: JobTaskStateMapper.ToInternal(agreement.State),
            AssigneeId: agreement.AssigneeId,
            Deadline: agreement.Deadline?.ToDateTimeOffset(),
            CreatedAt: agreement.CreatedAt.ToDateTimeOffset());
    }
}