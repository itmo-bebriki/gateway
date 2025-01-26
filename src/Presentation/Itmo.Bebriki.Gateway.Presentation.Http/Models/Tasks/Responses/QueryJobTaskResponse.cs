using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

public sealed record QueryJobTaskResponse(long? Cursor, JobTaskDto[] JobTasks);
