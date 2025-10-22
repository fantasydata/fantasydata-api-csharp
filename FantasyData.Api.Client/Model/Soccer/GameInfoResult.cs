using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="GameInfoResult")]
    [Serializable]
    public partial class GameInfoResult
    {
        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The soccer regular season for which these totals apply
        /// </summary>
        [Description("The soccer regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in UTC)
        /// </summary>
        [Description("The date and time of the game (in UTC)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called "green table." That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called \"green table.\" That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.")]
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
        [DataMember(Name = "GlobalHomeTeamID", Order = 13)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// List of Pregame GameOdds from different sportsbooks with results
        /// </summary>
        [Description("List of Pregame GameOdds from different sportsbooks with results")]
        [DataMember(Name = "PregameOdds", Order = 20014)]
        public GameOddResult[] PregameOdds { get; set; }

        /// <summary>
        /// Score of the home team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the home team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Score of the away team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the away team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The total combined score of both teams in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The total combined score of both teams in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 17)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The unique ID of the round that this game is associated with
        /// </summary>
        [Description("The unique ID of the round that this game is associated with")]
        [DataMember(Name = "RoundID", Order = 18)]
        public int RoundID { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs
        /// </summary>
        [Description("The week during the season/round in which this game occurs")]
        [DataMember(Name = "Week", Order = 19)]
        public int? Week { get; set; }

        /// <summary>
        /// List of Alternate Market GameOdds from different sportsbooks (such as 1st-half; 1st-qtr; etc)
        /// </summary>
        [Description("List of Alternate Market GameOdds from different sportsbooks (such as 1st-half; 1st-qtr; etc)")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20020)]
        public GameOddResult[] AlternateMarketPregameOdds { get; set; }

        /// <summary>
        /// The final period of the game. Possible values: Regular = Game ended in 90 minutes of regular time; ExtraTime = Game ended in extra time / overtime; PenaltyShootout = Game finished in penalty shootout time
        /// </summary>
        [Description("The final period of the game. Possible values: Regular = Game ended in 90 minutes of regular time; ExtraTime = Game ended in extra time / overtime; PenaltyShootout = Game finished in penalty shootout time")]
        [DataMember(Name = "Period", Order = 21)]
        public string Period { get; set; }

        /// <summary>
        /// The clock for the game if it is in progress. Note: if the game hasn't started or the game is over; then this will be NULL
        /// </summary>
        [Description("The clock for the game if it is in progress. Note: if the game hasn't started or the game is over; then this will be NULL")]
        [DataMember(Name = "Clock", Order = 22)]
        public int? Clock { get; set; }

        /// <summary>
        /// The winner of the game. Possible values: AwayTeam; HomeTeam; Draw
        /// </summary>
        [Description("The winner of the game. Possible values: AwayTeam; HomeTeam; Draw")]
        [DataMember(Name = "Winner", Order = 23)]
        public string Winner { get; set; }

        /// <summary>
        /// The first period score of the away team.
        /// </summary>
        [Description("The first period score of the away team.")]
        [DataMember(Name = "AwayTeamScorePeriod1", Order = 24)]
        public int? AwayTeamScorePeriod1 { get; set; }

        /// <summary>
        /// The second period score of the away team.
        /// </summary>
        [Description("The second period score of the away team.")]
        [DataMember(Name = "AwayTeamScorePeriod2", Order = 25)]
        public int? AwayTeamScorePeriod2 { get; set; }

        /// <summary>
        /// The extra time (overtime) score of the away team (if applicable).
        /// </summary>
        [Description("The extra time (overtime) score of the away team (if applicable).")]
        [DataMember(Name = "AwayTeamScoreExtraTime", Order = 26)]
        public int? AwayTeamScoreExtraTime { get; set; }

        /// <summary>
        /// The penalty shootout score of the away team (if applicable).
        /// </summary>
        [Description("The penalty shootout score of the away team (if applicable).")]
        [DataMember(Name = "AwayTeamScorePenalty", Order = 27)]
        public int? AwayTeamScorePenalty { get; set; }

        /// <summary>
        /// The first period score of the home team
        /// </summary>
        [Description("The first period score of the home team")]
        [DataMember(Name = "HomeTeamScorePeriod1", Order = 28)]
        public int? HomeTeamScorePeriod1 { get; set; }

        /// <summary>
        /// The second period score of the home team
        /// </summary>
        [Description("The second period score of the home team")]
        [DataMember(Name = "HomeTeamScorePeriod2", Order = 29)]
        public int? HomeTeamScorePeriod2 { get; set; }

        /// <summary>
        /// The extra time (overtime) score of the home team (if applicable)
        /// </summary>
        [Description("The extra time (overtime) score of the home team (if applicable)")]
        [DataMember(Name = "HomeTeamScoreExtraTime", Order = 30)]
        public int? HomeTeamScoreExtraTime { get; set; }

        /// <summary>
        /// The penalty shootout score of the home team (if applicable)
        /// </summary>
        [Description("The penalty shootout score of the home team (if applicable)")]
        [DataMember(Name = "HomeTeamScorePenalty", Order = 31)]
        public int? HomeTeamScorePenalty { get; set; }

        /// <summary>
        /// The added stoppage time minute the game is currently in. Note: will be null when game is not in stoppage time
        /// </summary>
        [Description("The added stoppage time minute the game is currently in. Note: will be null when game is not in stoppage time")]
        [DataMember(Name = "ClockExtra", Order = 32)]
        public int? ClockExtra { get; set; }

        /// <summary>
        /// A convenient string display of the current clock with format Clock+ClockExtra (ex 90+3)
        /// </summary>
        [Description("A convenient string display of the current clock with format Clock+ClockExtra (ex 90+3)")]
        [DataMember(Name = "ClockDisplay", Order = 33)]
        public string ClockDisplay { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score and stats have been verified and closed out
        /// </summary>
        [Description("Indicates whether the game is over and the final score and stats have been verified and closed out")]
        [DataMember(Name = "IsClosed", Order = 34)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// List of Live Odds from different sportsbooks with results
        /// </summary>
        [Description("List of Live Odds from different sportsbooks with results")]
        [DataMember(Name = "LiveOdds", Order = 20035)]
        public GameOddResult[] LiveOdds { get; set; }

    }
}

