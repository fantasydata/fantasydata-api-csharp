using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Game")]
    [Serializable]
    public partial class Game
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team 
        /// </summary>
        [Description("The unique ID of the home team ")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.
        /// </summary>
        [Description("The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.")]
        [DataMember(Name = "RescheduledGameID", Order = 11)]
        public int? RescheduledGameID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 12)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 13)]
        public string Channel { get; set; }

        /// <summary>
        /// The inning that the game is currently in, or the inning in which the game ended. Possible values include: NULL, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, etc)
        /// </summary>
        [Description("The inning that the game is currently in, or the inning in which the game ended. Possible values include: NULL, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, etc)")]
        [DataMember(Name = "Inning", Order = 14)]
        public int? Inning { get; set; }

        /// <summary>
        /// The inning half that the game is currently in, or the inning half in which the game ended (possible values: T, B, NULL)
        /// </summary>
        [Description("The inning half that the game is currently in, or the inning half in which the game ended (possible values: T, B, NULL)")]
        [DataMember(Name = "InningHalf", Order = 15)]
        public string InningHalf { get; set; }

        /// <summary>
        /// Number of runs the away team scored in this game
        /// </summary>
        [Description("Number of runs the away team scored in this game")]
        [DataMember(Name = "AwayTeamRuns", Order = 16)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// Number of runs the home team scored in this game
        /// </summary>
        [Description("Number of runs the home team scored in this game")]
        [DataMember(Name = "HomeTeamRuns", Order = 17)]
        public int? HomeTeamRuns { get; set; }

        /// <summary>
        /// Total away team hits in this game
        /// </summary>
        [Description("Total away team hits in this game")]
        [DataMember(Name = "AwayTeamHits", Order = 18)]
        public int? AwayTeamHits { get; set; }

        /// <summary>
        /// Total home team hits in this game
        /// </summary>
        [Description("Total home team hits in this game")]
        [DataMember(Name = "HomeTeamHits", Order = 19)]
        public int? HomeTeamHits { get; set; }

        /// <summary>
        /// Total away team errors committed in this game
        /// </summary>
        [Description("Total away team errors committed in this game")]
        [DataMember(Name = "AwayTeamErrors", Order = 20)]
        public int? AwayTeamErrors { get; set; }

        /// <summary>
        /// Total home team errors committed in this game
        /// </summary>
        [Description("Total home team errors committed in this game")]
        [DataMember(Name = "HomeTeamErrors", Order = 21)]
        public int? HomeTeamErrors { get; set; }

        /// <summary>
        /// The PlayerID of the winning pitcher
        /// </summary>
        [Description("The PlayerID of the winning pitcher")]
        [DataMember(Name = "WinningPitcherID", Order = 22)]
        public int? WinningPitcherID { get; set; }

        /// <summary>
        /// The PlayerID of the losing pitcher
        /// </summary>
        [Description("The PlayerID of the losing pitcher")]
        [DataMember(Name = "LosingPitcherID", Order = 23)]
        public int? LosingPitcherID { get; set; }

        /// <summary>
        /// The PlayerID of the saving pitcher
        /// </summary>
        [Description("The PlayerID of the saving pitcher")]
        [DataMember(Name = "SavingPitcherID", Order = 24)]
        public int? SavingPitcherID { get; set; }

        /// <summary>
        /// Total number of people who attended the game
        /// </summary>
        [Description("Total number of people who attended the game")]
        [DataMember(Name = "Attendance", Order = 25)]
        public int? Attendance { get; set; }

        /// <summary>
        /// The PlayerID of the away team's probable pitcher
        /// </summary>
        [Description("The PlayerID of the away team's probable pitcher")]
        [DataMember(Name = "AwayTeamProbablePitcherID", Order = 26)]
        public int? AwayTeamProbablePitcherID { get; set; }

        /// <summary>
        /// The PlayerID of the home team's probable pitcher
        /// </summary>
        [Description("The PlayerID of the home team's probable pitcher")]
        [DataMember(Name = "HomeTeamProbablePitcherID", Order = 27)]
        public int? HomeTeamProbablePitcherID { get; set; }

        /// <summary>
        /// The number of outs recorded in the current inning
        /// </summary>
        [Description("The number of outs recorded in the current inning")]
        [DataMember(Name = "Outs", Order = 28)]
        public int? Outs { get; set; }

        /// <summary>
        /// The number of balls thrown for the current at bat
        /// </summary>
        [Description("The number of balls thrown for the current at bat")]
        [DataMember(Name = "Balls", Order = 29)]
        public int? Balls { get; set; }

        /// <summary>
        /// The number of strikes thrown for the current at bat
        /// </summary>
        [Description("The number of strikes thrown for the current at bat")]
        [DataMember(Name = "Strikes", Order = 30)]
        public int? Strikes { get; set; }

        /// <summary>
        /// The PlayerID of the current pitcher
        /// </summary>
        [Description("The PlayerID of the current pitcher")]
        [DataMember(Name = "CurrentPitcherID", Order = 31)]
        public int? CurrentPitcherID { get; set; }

        /// <summary>
        /// The PlayerID of the current hitter
        /// </summary>
        [Description("The PlayerID of the current hitter")]
        [DataMember(Name = "CurrentHitterID", Order = 32)]
        public int? CurrentHitterID { get; set; }

        /// <summary>
        /// The PlayerID of the away team's starting pitcher
        /// </summary>
        [Description("The PlayerID of the away team's starting pitcher")]
        [DataMember(Name = "AwayTeamStartingPitcherID", Order = 33)]
        public int? AwayTeamStartingPitcherID { get; set; }

        /// <summary>
        /// The PlayerID of the home team's starting pitcher
        /// </summary>
        [Description("The PlayerID of the home team's starting pitcher")]
        [DataMember(Name = "HomeTeamStartingPitcherID", Order = 34)]
        public int? HomeTeamStartingPitcherID { get; set; }

        /// <summary>
        /// The TeamID of the current pitcher's team
        /// </summary>
        [Description("The TeamID of the current pitcher's team")]
        [DataMember(Name = "CurrentPitchingTeamID", Order = 35)]
        public int? CurrentPitchingTeamID { get; set; }

        /// <summary>
        /// The TeamID of the current hitter's team
        /// </summary>
        [Description("The TeamID of the current hitter's team")]
        [DataMember(Name = "CurrentHittingTeamID", Order = 36)]
        public int? CurrentHittingTeamID { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 37)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 38)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team.
        /// </summary>
        [Description("Money line from the perspective of the away team.")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 39)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team.
        /// </summary>
        [Description("Money line from the perspective of the home team.")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 40)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The forecasted low temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted low temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempLow", Order = 41)]
        public int? ForecastTempLow { get; set; }

        /// <summary>
        /// The forecasted high temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted high temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempHigh", Order = 42)]
        public int? ForecastTempHigh { get; set; }

        /// <summary>
        /// The description of the weather forecast. Posible values include: Broken Clouds, Clear Sky, Few Clouds, Heavy Intensity Rain, Light Rain, Moderate Rain, Mostly Cloudy, Mostly Sunny, Overcast Clouds, Partly Cloudy, Scattered Clouds, Showers, Thunderstorms
        /// </summary>
        [Description("The description of the weather forecast. Posible values include: Broken Clouds, Clear Sky, Few Clouds, Heavy Intensity Rain, Light Rain, Moderate Rain, Mostly Cloudy, Mostly Sunny, Overcast Clouds, Partly Cloudy, Scattered Clouds, Showers, Thunderstorms")]
        [DataMember(Name = "ForecastDescription", Order = 43)]
        public string ForecastDescription { get; set; }

        /// <summary>
        /// The forecasted wind chill on game day at this venue.
        /// </summary>
        [Description("The forecasted wind chill on game day at this venue.")]
        [DataMember(Name = "ForecastWindChill", Order = 44)]
        public int? ForecastWindChill { get; set; }

        /// <summary>
        /// The forecasted wind speed on game day at this venue.
        /// </summary>
        [Description("The forecasted wind speed on game day at this venue.")]
        [DataMember(Name = "ForecastWindSpeed", Order = 45)]
        public int? ForecastWindSpeed { get; set; }

        /// <summary>
        /// The wind direction isn't baseball specific.  It refers to the direction that the wind is coming from.  90 would be wind coming from the east.  180 is wind from the south.  270 is a wind from the west ... and so on.
        /// </summary>
        [Description("The wind direction isn't baseball specific.  It refers to the direction that the wind is coming from.  90 would be wind coming from the east.  180 is wind from the south.  270 is a wind from the west ... and so on.")]
        [DataMember(Name = "ForecastWindDirection", Order = 46)]
        public int? ForecastWindDirection { get; set; }

        /// <summary>
        /// The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as "make up" games.
        /// </summary>
        [Description("The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as \"make up\" games.")]
        [DataMember(Name = "RescheduledFromGameID", Order = 47)]
        public int? RescheduledFromGameID { get; set; }

        /// <summary>
        /// Indicates if there is a runner on first
        /// </summary>
        [Description("Indicates if there is a runner on first")]
        [DataMember(Name = "RunnerOnFirst", Order = 48)]
        public bool? RunnerOnFirst { get; set; }

        /// <summary>
        /// Indicates if there is a runner on second
        /// </summary>
        [Description("Indicates if there is a runner on second")]
        [DataMember(Name = "RunnerOnSecond", Order = 49)]
        public bool? RunnerOnSecond { get; set; }

        /// <summary>
        /// Indicates if there is a runner on third
        /// </summary>
        [Description("Indicates if there is a runner on third")]
        [DataMember(Name = "RunnerOnThird", Order = 50)]
        public bool? RunnerOnThird { get; set; }

        /// <summary>
        /// Indicates the away team starting pitcher's name
        /// </summary>
        [Description("Indicates the away team starting pitcher's name")]
        [DataMember(Name = "AwayTeamStartingPitcher", Order = 51)]
        public string AwayTeamStartingPitcher { get; set; }

        /// <summary>
        /// Indicates the home team starting pitcher's name
        /// </summary>
        [Description("Indicates the home team starting pitcher's name")]
        [DataMember(Name = "HomeTeamStartingPitcher", Order = 52)]
        public string HomeTeamStartingPitcher { get; set; }

        /// <summary>
        /// Indicates the current pitcher's name
        /// </summary>
        [Description("Indicates the current pitcher's name")]
        [DataMember(Name = "CurrentPitcher", Order = 53)]
        public string CurrentPitcher { get; set; }

        /// <summary>
        /// Indicates the current hitter's name
        /// </summary>
        [Description("Indicates the current hitter's name")]
        [DataMember(Name = "CurrentHitter", Order = 54)]
        public string CurrentHitter { get; set; }

        /// <summary>
        /// Indicates the winning pitcher's name
        /// </summary>
        [Description("Indicates the winning pitcher's name")]
        [DataMember(Name = "WinningPitcher", Order = 55)]
        public string WinningPitcher { get; set; }

        /// <summary>
        /// Indicates the losing pitcher's name
        /// </summary>
        [Description("Indicates the losing pitcher's name")]
        [DataMember(Name = "LosingPitcher", Order = 56)]
        public string LosingPitcher { get; set; }

        /// <summary>
        /// Indicates the saving pitcher's name
        /// </summary>
        [Description("Indicates the saving pitcher's name")]
        [DataMember(Name = "SavingPitcher", Order = 57)]
        public string SavingPitcher { get; set; }

        /// <summary>
        /// Indicates the hitter due up first
        /// </summary>
        [Description("Indicates the hitter due up first")]
        [DataMember(Name = "DueUpHitterID1", Order = 58)]
        public int? DueUpHitterID1 { get; set; }

        /// <summary>
        /// Indicates the hitter due up second
        /// </summary>
        [Description("Indicates the hitter due up second")]
        [DataMember(Name = "DueUpHitterID2", Order = 59)]
        public int? DueUpHitterID2 { get; set; }

        /// <summary>
        /// Indicates the hitter due up third
        /// </summary>
        [Description("Indicates the hitter due up third")]
        [DataMember(Name = "DueUpHitterID3", Order = 60)]
        public int? DueUpHitterID3 { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 61)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 62)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 63)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the away team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 64)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the home team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the home team with the point spread")]
        [DataMember(Name = "PointSpreadHomeTeamMoneyLine", Order = 65)]
        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.
        /// </summary>
        [Description("The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.")]
        [DataMember(Name = "LastPlay", Order = 66)]
        public string LastPlay { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 67)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 68)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The details of the innings associated with this game
        /// </summary>
        [Description("The details of the innings associated with this game")]
        [DataMember(Name = "Innings", Order = 20069)]
        public Inning[] Innings { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 70)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

