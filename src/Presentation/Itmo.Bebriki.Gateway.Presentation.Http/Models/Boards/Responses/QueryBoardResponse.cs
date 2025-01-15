using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

public sealed record QueryBoardResponse(long? Cursor, BoardDto[] Boards);
