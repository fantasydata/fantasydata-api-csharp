using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
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
        /// The College Football season of the game
        /// </summary>
        [Description("The College Football season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The CFB week of the game (e.g. 1, 2, 3, etc.)
        /// </summary>
        [Description("The CFB week of the game (e.g. 1, 2, 3, etc.)")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 5)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 6)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 8)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 9)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 10)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 11)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The name of the away team
        /// </summary>
        [Description("The name of the away team")]
        [DataMember(Name = "AwayTeamName", Order = 12)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team
        /// </summary>
        [Description("The name of the home team")]
        [DataMember(Name = "HomeTeamName", Order = 13)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// Total number of points the away team scored in this game
        /// </summary>
        [Description("Total number of points the away team scored in this game")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The current quarter in the game (Possible Values: 1, 2, 3, 4, Half, OT, F, F/OT, NULL)
        /// </summary>
        [Description("The current quarter in the game (Possible Values: 1, 2, 3, 4, Half, OT, F, F/OT, NULL)")]
        [DataMember(Name = "Period", Order = 16)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes remaining in the quarter
        /// </summary>
        [Description("Number of minutes remaining in the quarter")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 17)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds remaining in the quarter
        /// </summary>
        [Description("Number of seconds remaining in the quarter")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 18)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 19)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 20)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 21)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 22)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 23)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when this game was first created (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was first created (US Eastern Time)")]
        [DataMember(Name = "Created", Order = 24)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 25)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 26)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 27)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium/venue where this game was played.
        /// </summary>
        [Description("The unique ID of the stadium/venue where this game was played.")]
        [DataMember(Name = "StadiumID", Order = 28)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The details of the stadium where this game is played
        /// </summary>
        [Description("The details of the stadium where this game is played")]
        [DataMember(Name = "Stadium", Order = 10029)]
        public Stadium Stadium { get; set; }

        /// <summary>
        /// The yard line the ball is on
        /// </summary>
        [Description("The yard line the ball is on")]
        [DataMember(Name = "YardLine", Order = 30)]
        public int? YardLine { get; set; }

        /// <summary>
        /// Which team's side of the field the ball is on
        /// </summary>
        [Description("Which team's side of the field the ball is on")]
        [DataMember(Name = "YardLineTerritory", Order = 31)]
        public string YardLineTerritory { get; set; }

        /// <summary>
        /// The current down
        /// </summary>
        [Description("The current down")]
        [DataMember(Name = "Down", Order = 32)]
        public int? Down { get; set; }

        /// <summary>
        /// The current distance to a first down
        /// </summary>
        [Description("The current distance to a first down")]
        [DataMember(Name = "Distance", Order = 33)]
        public int? Distance { get; set; }

        /// <summary>
        /// Which team currently has possession of the ball
        /// </summary>
        [Description("Which team currently has possession of the ball")]
        [DataMember(Name = "Possession", Order = 34)]
        public string Possession { get; set; }

        /// <summary>
        /// The details of the periods (quarters & overtime) for this game
        /// </summary>
        [Description("The details of the periods (quarters & overtime) for this game")]
        [DataMember(Name = "Periods", Order = 20035)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out")]
        [DataMember(Name = "IsClosed", Order = 36)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 37)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The title of the game (e.g. Rose Bowl, Citrus Bowl, etc)
        /// </summary>
        [Description("The title of the game (e.g. Rose Bowl, Citrus Bowl, etc)")]
        [DataMember(Name = "Title", Order = 38)]
        public string Title { get; set; }

    }
}

