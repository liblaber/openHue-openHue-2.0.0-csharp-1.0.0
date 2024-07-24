// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using OpenHue.Http;
using OpenHue.Http.Serialization;
using OpenHue.Models;

namespace OpenHue.Services;

public class RoomService : BaseService
{
    internal RoomService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>List all available rooms</summary>
    public async Task<GetRoomsOkResponse> GetRoomsAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "clip/v2/resource/room").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetRoomsOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Create a new room</summary>
    public async Task<CreateRoomOkResponse> CreateRoomAsync(
        RoomPut input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "clip/v2/resource/room")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<CreateRoomOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get details of a single room from its given `{roomId}`</summary>
    /// <param name="roomId">ID of the room</param>
    public async Task<GetRoomOkResponse> GetRoomAsync(
        string roomId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(roomId, nameof(roomId));

        var request = new RequestBuilder(HttpMethod.Get, "clip/v2/resource/room/{roomId}")
            .SetPathParameter("roomId", roomId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetRoomOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Update a single room from its given `{roomId}`</summary>
    /// <param name="roomId">ID of the room</param>
    public async Task<UpdateRoomOkResponse> UpdateRoomAsync(
        RoomPut input,
        string roomId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(roomId, nameof(roomId));

        var request = new RequestBuilder(HttpMethod.Put, "clip/v2/resource/room/{roomId}")
            .SetPathParameter("roomId", roomId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<UpdateRoomOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete a single room from its given `{roomId}`</summary>
    /// <param name="roomId">ID of the room</param>
    public async Task<DeleteRoomOkResponse> DeleteRoomAsync(
        string roomId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(roomId, nameof(roomId));

        var request = new RequestBuilder(HttpMethod.Delete, "clip/v2/resource/room/{roomId}")
            .SetPathParameter("roomId", roomId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<DeleteRoomOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
