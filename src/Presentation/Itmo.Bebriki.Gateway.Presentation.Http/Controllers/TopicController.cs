using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Topics.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/topics")]
public class TopicController : ControllerBase
{
    private readonly TopicClient _client;

    public TopicController(TopicClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Query for fetching topic information.
    /// </summary>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Information about topics.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryTopicResponse>> QueryTopic(
        [FromQuery] QueryTopicRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryTopicAsync(request, cancellationToken));
    }

    /// <summary>
    /// Query for creating a new topic.
    /// </summary>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">An id of the new topic.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="500">Server error.</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateTopicResponse>> CreateTopic(
        [FromQuery] CreateTopicRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.CreateTopicAsync(request, cancellationToken));
    }

    /// <summary>
    /// Query for updating an existing topic.
    /// </summary>
    /// <param name="id">An id of the topic to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">If the topic was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UpdateTopic(
        [FromRoute] long id,
        [FromQuery] UpdateTopicRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateTopicAsync(id, request, cancellationToken);

        return Ok();
    }

    /// <summary>
    /// Query for adding new tasks to an existing topic.
    /// </summary>
    /// <param name="id">An id of the topic to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">If the topic was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPost("{id}/tasks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> AddTopicTasks(
        [FromRoute] long id,
        [FromQuery] SetTopicTasksRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddTopicTasksAsync(id, request, cancellationToken);

        return Ok();
    }

    /// <summary>
    /// Query for removing existing tasks from an existing topic.
    /// </summary>
    /// <param name="id">An id of the topic to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">If the topic was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpDelete("{id}/tasks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RemoveTopicTasks(
        [FromRoute] long id,
        [FromQuery] SetTopicTasksRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveTopicTasksAsync(id, request, cancellationToken);

        return Ok();
    }
}
