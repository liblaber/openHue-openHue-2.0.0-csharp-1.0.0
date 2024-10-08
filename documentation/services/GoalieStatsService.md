# GoalieStatsService

A list of all methods in the `GoalieStatsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                 | Description                                                        |
| :---------------------------------------------------------------------- | :----------------------------------------------------------------- |
| [GetCurrentGoalieStatsLeadersAsync](#getcurrentgoaliestatsleadersasync) | Retrieve current goalie stats leaders.                             |
| [GetGoalieStatsLeadersAsync](#getgoaliestatsleadersasync)               | Retrieve goalie stats leaders for a specific season and game type. |

## GetCurrentGoalieStatsLeadersAsync

Retrieve current goalie stats leaders.

- HTTP Method: `GET`
- Endpoint: `/v1/goalie-stats-leaders/current`

**Parameters**

| Name       | Type   | Required | Description                                                 |
| :--------- | :----- | :------- | :---------------------------------------------------------- |
| categories | string | ❌       | Categories to filter by                                     |
| limit      | long   | ❌       | Limit results (Note: a limit of -1 will return all results) |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlClient;

var client = new NhlClientClient();

var response = await client.GoalieStats.GetCurrentGoalieStatsLeadersAsync("categories", 2);

Console.WriteLine(response);
```

## GetGoalieStatsLeadersAsync

Retrieve goalie stats leaders for a specific season and game type.

- HTTP Method: `GET`
- Endpoint: `/v1/goalie-stats-leaders/{season}/{game-type}`

**Parameters**

| Name       | Type   | Required | Description                                                 |
| :--------- | :----- | :------- | :---------------------------------------------------------- |
| season     | long   | ✅       | Season in YYYYYYYY format                                   |
| gameType   | long   | ✅       | Game type (2 for regular season, 3 for playoffs)            |
| categories | string | ❌       | Categories to filter by                                     |
| limit      | long   | ❌       | Limit results (Note: a limit of -1 will return all results) |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlClient;

var client = new NhlClientClient();

var response = await client.GoalieStats.GetGoalieStatsLeadersAsync(8, 1, "categories", 3);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
