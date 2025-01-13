using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Dtos;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;

public record QueryJobTaskResponse(long? Cursor, JobTaskDto[] JobTasks);
