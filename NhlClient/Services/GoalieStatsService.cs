// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using NhlClient.Http;
using NhlClient.Http.Exceptions;
using NhlClient.Http.Extensions;
using NhlClient.Http.Serialization;

namespace NhlClient.Services;

public class GoalieStatsService : BaseService
{
    internal GoalieStatsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Retrieve current goalie stats leaders.</summary>
    /// <param name="categories">Categories to filter by</param>
    /// <param name="limit">Limit results (Note: a limit of -1 will return all results)</param>
    public async Task<object> GetCurrentGoalieStatsLeadersAsync(
        string? categories = null,
        long? limit = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "v1/goalie-stats-leaders/current")
            .SetOptionalQueryParameter("categories", categories)
            .SetOptionalQueryParameter("limit", limit)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve goalie stats leaders for a specific season and game type.</summary>
    /// <param name="season">Season in YYYYYYYY format</param>
    /// <param name="gameType">Game type (2 for regular season, 3 for playoffs)</param>
    /// <param name="categories">Categories to filter by</param>
    /// <param name="limit">Limit results (Note: a limit of -1 will return all results)</param>
    public async Task<object> GetGoalieStatsLeadersAsync(
        long season,
        long gameType,
        string? categories = null,
        long? limit = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(
            HttpMethod.Get,
            "v1/goalie-stats-leaders/{season}/{game-type}"
        )
            .SetPathParameter("season", season)
            .SetPathParameter("game-type", gameType)
            .SetOptionalQueryParameter("categories", categories)
            .SetOptionalQueryParameter("limit", limit)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
