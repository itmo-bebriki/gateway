using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Tasks.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly TaskClient _client;

    public TasksController(TaskClient client)
    {
        _client = client;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryJobTaskResponse>> QueryJobTasks(
        [FromQuery] QueryJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryJobTasksAsync(request, cancellationToken));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateJobTaskResponse>> CreateJobTask(
        [FromQuery] CreateJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.CreateJobTaskAsync(request, cancellationToken));
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UpdateJobTask(
        [FromRoute] long id,
        [FromQuery] UpdateJobTaskRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateJobTaskAsync(id, request, cancellationToken);

        return Ok();
    }

    [HttpPut("{id}/deps")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> AddJobTaskDependencies(
        [FromRoute] long id,
        [FromQuery] SetJobTaskDependenciesRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddJobTaskDependenciesAsync(id, request, cancellationToken);

        return Ok();
    }

    [HttpDelete("{id}/deps")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RemoveJobTaskDependencies(
        [FromRoute] long id,
        [FromQuery] SetJobTaskDependenciesRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveJobTaskDependenciesAsync(id, request, cancellationToken);

        return Ok();
    }
}
