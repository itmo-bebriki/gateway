using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Controllers;

[ApiController]
[Route("api/boards")]
public class BoardsController : ControllerBase
{
    private readonly BoardClient _client;

    public BoardsController(BoardClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an information about boards.
    /// </summary>
    /// <param name="request">Query params of the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">An information about queried boards.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If nothing was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<QueryBoardResponse>> QueryBoards(
        [FromQuery] QueryBoardRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.QueryBoardAsync(request, cancellationToken));
    }

    /// <summary>
    /// Query for creating a new board.
    /// </summary>
    /// <param name="request">Query params of the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">An id of the created board.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="500">Server error.</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CreateBoardResponse>> CreateBoard(
        [FromQuery] CreateBoardRequest request,
        CancellationToken cancellationToken)
    {
        return Ok(await _client.CreateBoardAsync(request, cancellationToken));
    }

    /// <summary>
    /// Query for updating an existing board.
    /// </summary>
    /// <param name="id">An id of the board to be updated.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Board was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the board was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UpdateBoard(
        [FromRoute] long id,
        [FromQuery] UpdateBoardRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateBoardAsync(id, request, cancellationToken);

        return Ok();
    }

    /// <summary>
    /// Query for adding topics to an existing board.
    /// </summary>
    /// <param name="id">An id of the board to add topics to.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Board was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the board was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpPost("{id}/topics")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> AddBoardTopics(
        [FromRoute] long id,
        [FromQuery] SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddBoardTopicsAsync(id, request, cancellationToken);

        return Ok();
    }

    /// <summary>
    /// Query for deleting topics from an existing board.
    /// </summary>
    /// <param name="id">An id of the board to remove topics from.</param>
    /// <param name="request">Query params for the request.</param>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <response code="200">Board was successfully updated.</response>
    /// <response code="400">If the request was ill-formed.</response>
    /// <response code="404">If the board was not found.</response>
    /// <response code="500">Server error.</response>
    [HttpDelete("{id}/topics")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RemoveBoardTopics(
        [FromRoute] long id,
        [FromQuery] SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveBoardTopicsAsync(id, request, cancellationToken);

        return Ok();
    }
}
