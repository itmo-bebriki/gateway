using Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Agreements.Responses;

public sealed record QueryAgreementResponse(long? Cursor, IReadOnlyCollection<AgreementDto> Agreements);
