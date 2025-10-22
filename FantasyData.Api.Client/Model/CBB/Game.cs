using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
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
        /// The season that the game occurs in. Note: season is a single year that the majority of the season occurs in
        /// </summary>
        [Description("The season that the game occurs in. Note: season is a single year that the majority of the season occurs in")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in
        /// </summary>
        [Description("The day that the game is scheduled to be played in")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 11)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 12)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The current period of the game (Possible Values: 1; 2; Half; OT; NULL)
        /// </summary>
        [Description("The current period of the game (Possible Values: 1; 2; Half; OT; NULL)")]
        [DataMember(Name = "Period", Order = 14)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes remaining in the half (from 0 to 20). Note: if game is scheduled or final this field is NULL
        /// </summary>
        [Description("Number of minutes remaining in the half (from 0 to 20). Note: if game is scheduled or final this field is NULL")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 15)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds remaining in the half (from 0 to 59). Note: if game is scheduled or final this field is NULL
        /// </summary>
        [Description("Number of seconds remaining in the half (from 0 to 59). Note: if game is scheduled or final this field is NULL")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 16)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The consensus Point Spread at game start from the perspective of the HomeTeam (in the Game table, the PointSpread field's negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored. Note that this rule does not hold in betting-related tables, where the spread is contingent on the bet line.)
        /// </summary>
        [Description("The consensus Point Spread at game start from the perspective of the HomeTeam (in the Game table, the PointSpread field's negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored. Note that this rule does not hold in betting-related tables, where the spread is contingent on the bet line.)")]
        [DataMember(Name = "PointSpread", Order = 17)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The total points line (over/under) as given by the sportsbook
        /// </summary>
        [Description("The total points line (over/under) as given by the sportsbook")]
        [DataMember(Name = "OverUnder", Order = 18)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 19)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 20)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 21)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 22)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 23)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the tournament. Note: this field is specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The unique ID of the tournament. Note: this field is specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "TournamentID", Order = 24)]
        public int? TournamentID { get; set; }

        /// <summary>
        /// The specific bracket of the tournament (e.g. East; West; Midwest; South). Note: this is specific to the NCAA tournament
        /// </summary>
        [Description("The specific bracket of the tournament (e.g. East; West; Midwest; South). Note: this is specific to the NCAA tournament")]
        [DataMember(Name = "Bracket", Order = 25)]
        public string Bracket { get; set; }

        /// <summary>
        /// The current round of the NCAA tournament. Rounds: 1 = Round of 64, 2 = Round of 32, 3 = Sweet Sixteen, 4 = Elite Eight, 5 = Final Four, 6 = Championship Note: First Four games Round = NULL
        /// </summary>
        [Description("The current round of the NCAA tournament. Rounds: 1 = Round of 64, 2 = Round of 32, 3 = Sweet Sixteen, 4 = Elite Eight, 5 = Final Four, 6 = Championship Note: First Four games Round = NULL")]
        [DataMember(Name = "Round", Order = 26)]
        public int? Round { get; set; }

        /// <summary>
        /// The seed of the away team (1-16). Note: this is specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The seed of the away team (1-16). Note: this is specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "AwayTeamSeed", Order = 27)]
        public int? AwayTeamSeed { get; set; }

        /// <summary>
        /// The seed of the home team (1-16). Note: this is specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The seed of the home team (1-16). Note: this is specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "HomeTeamSeed", Order = 28)]
        public int? HomeTeamSeed { get; set; }

        /// <summary>
        /// The Id of one of the NCAA tournament games which feeds this game.  This gameid will be inaccurate/invalid in free trial as it is scrambled.  Null for some Round 1 and all play-in games.  Used for rendering.  Does not change after tournament records have been created.
        /// </summary>
        [Description("The Id of one of the NCAA tournament games which feeds this game.  This gameid will be inaccurate/invalid in free trial as it is scrambled.  Null for some Round 1 and all play-in games.  Used for rendering.  Does not change after tournament records have been created.")]
        [DataMember(Name = "AwayTeamPreviousGameID", Order = 29)]
        public int? AwayTeamPreviousGameID { get; set; }

        /// <summary>
        /// The Id of one of the NCAA tournament games which feeds this game.  This gameid will be inaccurate/invalid in free trial as it is scrambled.  Null for some Round 1 and all play-in games.  Used for rendering.  Does not change after tournament records have been created.
        /// </summary>
        [Description("The Id of one of the NCAA tournament games which feeds this game.  This gameid will be inaccurate/invalid in free trial as it is scrambled.  Null for some Round 1 and all play-in games.  Used for rendering.  Does not change after tournament records have been created.")]
        [DataMember(Name = "HomeTeamPreviousGameID", Order = 30)]
        public int? HomeTeamPreviousGameID { get; set; }

        /// <summary>
        /// The unique global ID of the away team's previous game (This gameid will be inaccurate/invalid in free trial as it is scrambled)
        /// </summary>
        [Description("The unique global ID of the away team's previous game (This gameid will be inaccurate/invalid in free trial as it is scrambled)")]
        [DataMember(Name = "AwayTeamPreviousGlobalGameID", Order = 31)]
        public int? AwayTeamPreviousGlobalGameID { get; set; }

        /// <summary>
        /// The unique global ID of the away team's previous game (This gameid will be inaccurate/invalid in free trial as it is scrambled)
        /// </summary>
        [Description("The unique global ID of the away team's previous game (This gameid will be inaccurate/invalid in free trial as it is scrambled)")]
        [DataMember(Name = "HomeTeamPreviousGlobalGameID", Order = 32)]
        public int? HomeTeamPreviousGlobalGameID { get; set; }

        /// <summary>
        /// The display order of this game. This is used for rendering NCAA Tournament bracket.
        /// </summary>
        [Description("The display order of this game. This is used for rendering NCAA Tournament bracket.")]
        [DataMember(Name = "TournamentDisplayOrder", Order = 33)]
        public int? TournamentDisplayOrder { get; set; }

        /// <summary>
        /// The display order of the home team for this game. This is used for rendering the NCAA Tournament bracket, and it indicates whether the home team should be displayed at the top or bottom of the game card. Possible values: Top, Bottom
        /// </summary>
        [Description("The display order of the home team for this game. This is used for rendering the NCAA Tournament bracket, and it indicates whether the home team should be displayed at the top or bottom of the game card. Possible values: Top, Bottom")]
        [DataMember(Name = "TournamentDisplayOrderForHomeTeam", Order = 34)]
        public string TournamentDisplayOrderForHomeTeam { get; set; }

        /// <summary>
        /// The details of the periods (halves & overtime) for this game. Note: the scores are for that half/period only, not total score of game at that point
        /// </summary>
        [Description("The details of the periods (halves & overtime) for this game. Note: the scores are for that half/period only, not total score of game at that point")]
        [DataMember(Name = "Periods", Order = 20035)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 36)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended (in US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (in US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 37)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The stadium details of where this game was played
        /// </summary>
        [Description("The stadium details of where this game was played")]
        [DataMember(Name = "Stadium", Order = 10038)]
        public Stadium Stadium { get; set; }

        /// <summary>
        /// Rotation number of home team for this game
        /// </summary>
        [Description("Rotation number of home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 39)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of away team for this game.
        /// </summary>
        [Description("Rotation number of away team for this game.")]
        [DataMember(Name = "AwayRotationNumber", Order = 40)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Previous game id of the team in the top slot of an NCAA tournament game.  Used for rendering.
        /// </summary>
        [Description("Previous game id of the team in the top slot of an NCAA tournament game.  Used for rendering.")]
        [DataMember(Name = "TopTeamPreviousGameId", Order = 41)]
        public int? TopTeamPreviousGameId { get; set; }

        /// <summary>
        /// Previous game id of the team in the bottom slot of an NCAA tournament game.  Used for rendering.
        /// </summary>
        [Description("Previous game id of the team in the bottom slot of an NCAA tournament game.  Used for rendering.")]
        [DataMember(Name = "BottomTeamPreviousGameId", Order = 42)]
        public int? BottomTeamPreviousGameId { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 43)]
        public string Channel { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue. Note: Neutral = True, Not Neutral = False
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue. Note: Neutral = True, Not Neutral = False")]
        [DataMember(Name = "NeutralVenue", Order = 44)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the away team. Note: this line is a consensus
        /// </summary>
        [Description("The sportsbook's point spread payout for the away team. Note: this line is a consensus")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 45)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the home team
        /// </summary>
        [Description("The sportsbook's point spread payout for the home team")]
        [DataMember(Name = "HomePointSpreadPayout", Order = 46)]
        public int? HomePointSpreadPayout { get; set; }

        /// <summary>
        /// The odds at which the sportsbook will pay out winning over bets at
        /// </summary>
        [Description("The odds at which the sportsbook will pay out winning over bets at")]
        [DataMember(Name = "OverPayout", Order = 47)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The payout when betting the Under of the Over/Under
        /// </summary>
        [Description("The payout when betting the Under of the Over/Under")]
        [DataMember(Name = "UnderPayout", Order = 48)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// The date and time of the game in UTC
        /// </summary>
        [Description("The date and time of the game in UTC")]
        [DataMember(Name = "DateTimeUTC", Order = 49)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// The attendance of the game when available
        /// </summary>
        [Description("The attendance of the game when available")]
        [DataMember(Name = "Attendance", Order = 50)]
        public int? Attendance { get; set; }

    }
}

