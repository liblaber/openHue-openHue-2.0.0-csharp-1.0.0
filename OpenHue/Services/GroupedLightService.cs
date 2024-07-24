// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using OpenHue.Http;
using OpenHue.Http.Serialization;
using OpenHue.Models;

namespace OpenHue.Services;

public class GroupedLightService : BaseService
{
    internal GroupedLightService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>List all grouped lights</summary>
    public async Task<GetGroupedLightsOkResponse> GetGroupedLightsAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "clip/v2/resource/grouped_light").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetGroupedLightsOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get details of a single grouped light from its given `{groupedLightId}`.</summary>
    /// <param name="groupedLightId">ID of the grouped light</param>
    public async Task<GetGroupedLightOkResponse> GetGroupedLightAsync(
        string groupedLightId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(groupedLightId, nameof(groupedLightId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "clip/v2/resource/grouped_light/{groupedLightId}"
        )
            .SetPathParameter("groupedLightId", groupedLightId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetGroupedLightOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Update a single grouped light from its given `{groupedLightId}`.</summary>
    /// <param name="groupedLightId">ID of the light</param>
    public async Task<UpdateGroupedLightOkResponse> UpdateGroupedLightAsync(
        GroupedLightPut input,
        string groupedLightId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(groupedLightId, nameof(groupedLightId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "clip/v2/resource/grouped_light/{groupedLightId}"
        )
            .SetPathParameter("groupedLightId", groupedLightId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<UpdateGroupedLightOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
