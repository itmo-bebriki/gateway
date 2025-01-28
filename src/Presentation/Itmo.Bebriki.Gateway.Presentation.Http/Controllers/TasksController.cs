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

    /// <summary>
    /// Query for fetching job task information.
    /// </summary>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Fetched info about provided job tasks.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
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

    /// <summary>
    /// Query for creating a new job task.
    /// </summary>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Job task was successfully created.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="500">Server error.</response>
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

    /// <summary>
    /// Query for updating an existing job task.
    /// </summary>
    /// <param name="id">An id of the job task to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Job task was successfully updated or the request for approval was sent.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
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

    /// <summary>
    /// Query for adding new dependencies to an existing job task.
    /// </summary>
    /// <param name="id">An id of the job task to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Job task was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPost("{id}/deps")]
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

    /// <summary>
    /// Query for removing dependencies from an existing job task.
    /// </summary>
    /// <param name="id">An id of the job task to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Job task was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
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
