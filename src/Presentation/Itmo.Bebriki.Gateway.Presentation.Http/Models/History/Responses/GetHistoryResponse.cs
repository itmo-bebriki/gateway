using Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.History.Responses;

public sealed record GetHistoryResponse(long Cursor, PayloadDto[] Payloads);
