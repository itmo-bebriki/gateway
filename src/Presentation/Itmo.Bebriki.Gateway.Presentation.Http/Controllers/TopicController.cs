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

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryTopicResponse>> QueryTopic(
        [FromQuery] QueryTopicRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryTopicAsync(request, cancellationToken));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateTopicResponse>> CreateTopic(
        [FromQuery] CreateTopicRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.CreateTopicAsync(request, cancellationToken));
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
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

    [HttpPut("{id}/tasks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
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

    [HttpDelete("{id}/tasks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
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
