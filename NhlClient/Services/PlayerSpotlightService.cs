// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using NhlClient.Http;
using NhlClient.Http.Exceptions;
using NhlClient.Http.Extensions;
using NhlClient.Http.Serialization;

namespace NhlClient.Services;

public class PlayerSpotlightService : BaseService
{
    internal PlayerSpotlightService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Retrieve information about players in the "spotlight".</summary>
    public async Task<object> GetPlayerSpotlightAsync(CancellationToken cancellationToken = default)
    {
        var request = new RequestBuilder(HttpMethod.Get, "v1/player-spotlight").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
