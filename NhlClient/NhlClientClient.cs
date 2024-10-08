// This file was generated by liblab | https://liblab.com/

using NhlClient.Config;
using NhlClient.Http.Handlers;
using NhlClient.Services;
using Environment = NhlClient.Http.Environment;

namespace NhlClient;

public class NhlClientClient : IDisposable
{
    private readonly HttpClient _httpClient;

    public PlayerService Player { get; private set; }
    public SkaterStatsService SkaterStats { get; private set; }
    public GoalieStatsService GoalieStats { get; private set; }
    public PlayerSpotlightService PlayerSpotlight { get; private set; }
    public StandingsService Standings { get; private set; }
    public ClubStatsService ClubStats { get; private set; }
    public ScoreboardService Scoreboard { get; private set; }
    public RosterService Roster { get; private set; }
    public ScheduleService Schedule { get; private set; }

    public NhlClientClient(NhlClientConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _httpClient = new HttpClient(retryHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        Player = new PlayerService(_httpClient);
        SkaterStats = new SkaterStatsService(_httpClient);
        GoalieStats = new GoalieStatsService(_httpClient);
        PlayerSpotlight = new PlayerSpotlightService(_httpClient);
        Standings = new StandingsService(_httpClient);
        ClubStats = new ClubStatsService(_httpClient);
        Scoreboard = new ScoreboardService(_httpClient);
        Roster = new RosterService(_httpClient);
        Schedule = new ScheduleService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
