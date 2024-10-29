# fantasydata-api-csharp
[SportsDataIO](https://sportsdata.io) API client (formerly branded as FantasyData) library wrapper for C# (.NET 4.5). For more information on the SportsDataIO API check the [SportsDataIO Developer Portal](https://sportsdata.io/developers).

## Installation
This library is distributed on `Nuget`. In order to add to your visual studio project, open the nuget package manager console and use the command:
```
PM> Install-Package FantasyData.Api.Client
```

## Authentication
You can find your API keys in the [SportsDataIO API Documentation](https://sportsdata.io/developers/api-documentation/nfl). See [Usage](#Usage) for implementation details.

## Usage
In this simple example we authenticate the and `MLBv3Projections` client with its respective key. We then pull projections for `2018-03-29` and just output some information to the console. Be sure to replace `<license key>` with your API key for this client.
``` cs
// Connect to client and get data
var client = new MLBv3ProjectionsClient("<license key>");
var projections = client.GetPlayerGameProjectionStatsByDate("2018-03-29").OrderByDescending(p => p.DraftKingsSalary).Take(20).ToList();
// Write data to console
foreach(var projection in projections)
{
    Console.WriteLine($"{projection.PlayerID} - {projection.Name} ({projection.DraftKingsPosition}) DraftKings Salary: {projection.DraftKingsSalary}");
}
```

## Documentation
* [SportsDataIO Developer Portal](https://sportsdata.io/developers)
* [Odds API](https://sportsdata.io/live-odds-api)
* [Data Dictionary](https://sportsdata.io/developers/data-dictionary/nfl)

| API Documentation                                                                 |
|----------------------------------------------------------------------------------------|
| [NFL API](https://sportsdata.io/developers/api-documentation/nfl)                      |
| [MLB API](https://sportsdata.io/developers/api-documentation/mlb)                      |
| [NBA API](https://sportsdata.io/developers/api-documentation/nba)                      |
| [NHL API](https://sportsdata.io/developers/api-documentation/nhl)                      |
| [NCAA Football API](https://sportsdata.io/developers/api-documentation/ncaa-football)  |
| [NCAA Basketball API](https://sportsdata.io/developers/api-documentation/ncaa-basketball) |
| [PGA / Golf API](https://sportsdata.io/developers/api-documentation/golf)                |
| [NASCAR API](https://sportsdata.io/developers/api-documentation/nascar)                |
| [Soccer API](https://sportsdata.io/developers/api-documentation/soccer)                |
| [UFC / MMA API](https://sportsdata.io/developers/api-documentation/mma)                      |
| [WNBA API](https://sportsdata.io/developers/api-documentation/wnba)                    |
| [NCAA Women's Basketball API](https://sportsdata.io/developers/api-documentation/ncaa-womens-basketball) |
| [Tennis API](https://sportsdata.io/developers/api-documentation/tennis)                |
| [LoL API](https://sportsdata.io/developers/api-documentation/lol)                      |
| [CS:GO API](https://sportsdata.io/developers/api-documentation/csgo)                   |