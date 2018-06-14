# fantasydata-api-csharp
[FantasyData](https://fantasydata.com) API client library wrapper for C# (.NET 4.5). For more information on the FantasyData API check the [Fantasy Data Developer Portal](developer.fantasydata.com/?developer-portal). 

## Installation
This library is distributed on `Nuget`. In order to add to your visual studio project, open the nuget package manager console and use the command:

```
PM> Install-Package FantasyData.Api.Client
```

## Authentication
You can find your api keys in the [Fantasy Data Developer Portal](https://developer.fantasydata.com/developer). See [Usage](#Usage) for implementation details.

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
* [Fantasy Data Developer Portal](developer.fantasydata.com/?developer-portal)
* [Implementation Guide](https://fantasydata.com/resources/implementation-guide.aspx)
* [Data Dictionary](https://fantasydata.com/resources/data-dictionary.aspx)
* [Find your license keys](https://developer.fantasydata.com/developer)
