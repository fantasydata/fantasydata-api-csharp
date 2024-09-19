
rem TODO: use msbuild to rebuild the solution (or for now, just manually build the solution in Visual Studio in RELEASE mode)

rem Generating Nuget Package
nuget pack "FantasyData.Api.Client\FantasyData.Api.Client.csproj.nuspec"

rem TODO: Upload Nuget Package

