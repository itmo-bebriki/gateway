using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Mappers.Boards.Responses;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Requests;
using Itmo.Bebriki.Gateway.Presentation.Http.Models.Boards.Responses;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Clients;

public class BoardClient
{
    private readonly Boards.Contracts.BoardService.BoardServiceClient _client;

    public BoardClient(Boards.Contracts.BoardService.BoardServiceClient client)
    {
        _client = client;
    }

    public async Task<QueryBoardResponse> QueryBoardAsync(
        QueryBoardRequest request,
        CancellationToken cancellationToken)
    {
        Boards.Contracts.QueryBoardResponse response = await _client.QueryBoardAsync(
            QueryBoardRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return QueryBoardResponseMapper.ToInternal(response);
    }

    public async Task<CreateBoardResponse> CreateBoardAsync(
        CreateBoardRequest request,
        CancellationToken cancellationToken)
    {
        Boards.Contracts.CreateBoardResponse response = await _client.CreateBoardAsync(
            CreateBoardRequestMapper.FromInternal(request),
            cancellationToken: cancellationToken);

        return CreateBoardResponseMapper.ToInternal(response);
    }

    public async Task UpdateBoardAsync(
        long id,
        UpdateBoardRequest request,
        CancellationToken cancellationToken)
    {
        await _client.UpdateBoardAsync(
            UpdateBoardRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task AddBoardTopicsAsync(
        long id,
        SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.AddBoardTopicsAsync(
            SetBoardTopicsRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }

    public async Task RemoveBoardTopicsAsync(
        long id,
        SetBoardTopicsRequest request,
        CancellationToken cancellationToken)
    {
        await _client.RemoveBoardTopicsAsync(
            SetBoardTopicsRequestMapper.FromInternal(id, request),
            cancellationToken: cancellationToken);
    }
}
