// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using OpenHue.Http;
using OpenHue.Http.Exceptions;
using OpenHue.Http.Extensions;
using OpenHue.Http.Serialization;
using OpenHue.Models;

namespace OpenHue.Services;

public class ResourceService : BaseService
{
    internal ResourceService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>API to retrieve all API resources</summary>
    public async Task<GetResourcesOkResponse> GetResourcesAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "clip/v2/resource").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GetResourcesOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
