using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="GameInfoResult")]
    [Serializable]
    public partial class GameInfoResult
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played
        /// </summary>
        [Description("The day that the game is scheduled to be played")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 7)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 8)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The name of the away team
        /// </summary>
        [Description("The name of the away team")]
        [DataMember(Name = "AwayTeamName", Order = 9)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team
        /// </summary>
        [Description("The name of the home team")]
        [DataMember(Name = "HomeTeamName", Order = 10)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 11)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 12)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamHomeTeamID", Order = 13)]
        public int? GlobalTeamHomeTeamID { get; set; }

        /// <summary>
        /// List of Pregame GameOdds from different sportsbooks with results
        /// </summary>
        [Description("List of Pregame GameOdds from different sportsbooks with results")]
        [DataMember(Name = "PregameOdds", Order = 20014)]
        public GameOddResult[] PregameOdds { get; set; }

        /// <summary>
        /// Total number of goals the home team scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of goals the home team scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Total number of goals the away team scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of goals the away team scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total goals scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total goals scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 17)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The rotation number of the home team for this game
        /// </summary>
        [Description("The rotation number of the home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 18)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The rotation number of the away team for this game
        /// </summary>
        [Description("The rotation number of the away team for this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 19)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// A list of Alternate Market Pregame GameOdds from different sportsbooks (e.g. 1st Period; 2nd Period; etc.)
        /// </summary>
        [Description("A list of Alternate Market Pregame GameOdds from different sportsbooks (e.g. 1st Period; 2nd Period; etc.)")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20020)]
        public GameOddResult[] AlternateMarketPregameOdds { get; set; }

        /// <summary>
        /// Indicates the current period of the game. Possible values include: 1; 2; 3; OT; SO; NULL
        /// </summary>
        [Description("Indicates the current period of the game. Possible values include: 1; 2; 3; OT; SO; NULL")]
        [DataMember(Name = "Period", Order = 21)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock minutes which are the number of minutes that have already passed in the period.
        /// </summary>
        [Description("Number of minutes that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock minutes which are the number of minutes that have already passed in the period.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 22)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock sconds which are the number of minutes that have already passed in the period.
        /// </summary>
        [Description("Number of seconds that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock sconds which are the number of minutes that have already passed in the period.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 23)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The details of the periods (including overtime if applicable) for this game
        /// </summary>
        [Description("The details of the periods (including overtime if applicable) for this game")]
        [DataMember(Name = "Periods", Order = 20024)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 25)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// List of Live Odds from different sportsbooks with results
        /// </summary>
        [Description("List of Live Odds from different sportsbooks with results")]
        [DataMember(Name = "LiveOdds", Order = 20026)]
        public GameOddResult[] LiveOdds { get; set; }

    }
}

