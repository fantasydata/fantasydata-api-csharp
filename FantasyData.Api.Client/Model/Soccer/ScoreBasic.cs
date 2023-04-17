﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="ScoreBasic")]
    [Serializable]
    public partial class ScoreBasic
    {
        /// <summary>
        /// The final period of the game. Possible values: Regular = Game ended in 90 minutes of regular time, ExtraTime = Game ended in extra time / overtime, PenaltyShootout = Game finished in penalty shootout time
        /// </summary>
        [Description("The final period of the game. Possible values: Regular = Game ended in 90 minutes of regular time, ExtraTime = Game ended in extra time / overtime, PenaltyShootout = Game finished in penalty shootout time")]
        [DataMember(Name = "Period", Order = 1)]
        public string Period { get; set; }

        /// <summary>
        /// The clock for the game if it is in progress. If the games hasn't started or the game is over, then this will be NULL.
        /// </summary>
        [Description("The clock for the game if it is in progress. If the games hasn't started or the game is over, then this will be NULL.")]
        [DataMember(Name = "Clock", Order = 2)]
        public int? Clock { get; set; }

        /// <summary>
        /// The unique ID of the game.
        /// </summary>
        [Description("The unique ID of the game.")]
        [DataMember(Name = "GameId", Order = 3)]
        public int GameId { get; set; }

        /// <summary>
        /// The RoundId of the round that this game is associated with.
        /// </summary>
        [Description("The RoundId of the round that this game is associated with.")]
        [DataMember(Name = "RoundId", Order = 4)]
        public int RoundId { get; set; }

        /// <summary>
        /// The calendar year of the season during which this game occurs.
        /// </summary>
        [Description("The calendar year of the season during which this game occurs.")]
        [DataMember(Name = "Season", Order = 5)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 6)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The name of the group in which this game occurs. This is used in tournaments / cups.
        /// </summary>
        [Description("The name of the group in which this game occurs. This is used in tournaments / cups.")]
        [DataMember(Name = "Group", Order = 7)]
        public string Group { get; set; }

        /// <summary>
        /// The TeamId of the away team.
        /// </summary>
        [Description("The TeamId of the away team.")]
        [DataMember(Name = "AwayTeamId", Order = 8)]
        public int? AwayTeamId { get; set; }

        /// <summary>
        /// The TeamId of the home team.
        /// </summary>
        [Description("The TeamId of the home team.")]
        [DataMember(Name = "HomeTeamId", Order = 9)]
        public int? HomeTeamId { get; set; }

        /// <summary>
        /// The VenueId of the venue.
        /// </summary>
        [Description("The VenueId of the venue.")]
        [DataMember(Name = "VenueId", Order = 10)]
        public int? VenueId { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in UTC.
        /// </summary>
        [Description("The day that the game is scheduled to be played in UTC.")]
        [DataMember(Name = "Day", Order = 11)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time that the game is scheduled to be played in UTC.
        /// </summary>
        [Description("The date/time that the game is scheduled to be played in UTC.")]
        [DataMember(Name = "DateTime", Order = 12)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called "green table." That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called \"green table.\" That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.")]
        [DataMember(Name = "Status", Order = 13)]
        public string Status { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs.
        /// </summary>
        [Description("The week during the season/round in which this game occurs.")]
        [DataMember(Name = "Week", Order = 14)]
        public int? Week { get; set; }

        /// <summary>
        /// The winner of the game. Possible values include: AwayTeam, HomeTeam, Draw
        /// </summary>
        [Description("The winner of the game. Possible values include: AwayTeam, HomeTeam, Draw")]
        [DataMember(Name = "Winner", Order = 15)]
        public string Winner { get; set; }

        /// <summary>
        /// Indicates home field advantage. Possible values include: Home Away, Neutral
        /// </summary>
        [Description("Indicates home field advantage. Possible values include: Home Away, Neutral")]
        [DataMember(Name = "VenueType", Order = 16)]
        public string VenueType { get; set; }

        /// <summary>
        /// The abbreviation of the away team.
        /// </summary>
        [Description("The abbreviation of the away team.")]
        [DataMember(Name = "AwayTeamKey", Order = 17)]
        public string AwayTeamKey { get; set; }

        /// <summary>
        /// The name of the away team.
        /// </summary>
        [Description("The name of the away team.")]
        [DataMember(Name = "AwayTeamName", Order = 18)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The country code of the away team.
        /// </summary>
        [Description("The country code of the away team.")]
        [DataMember(Name = "AwayTeamCountryCode", Order = 19)]
        public string AwayTeamCountryCode { get; set; }

        /// <summary>
        /// The final score of the away team.
        /// </summary>
        [Description("The final score of the away team.")]
        [DataMember(Name = "AwayTeamScore", Order = 20)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The first period score of the away team.
        /// </summary>
        [Description("The first period score of the away team.")]
        [DataMember(Name = "AwayTeamScorePeriod1", Order = 21)]
        public int? AwayTeamScorePeriod1 { get; set; }

        /// <summary>
        /// The second period score of the away team.
        /// </summary>
        [Description("The second period score of the away team.")]
        [DataMember(Name = "AwayTeamScorePeriod2", Order = 22)]
        public int? AwayTeamScorePeriod2 { get; set; }

        /// <summary>
        /// The extra time (overtime) score of the away team (if applicable).
        /// </summary>
        [Description("The extra time (overtime) score of the away team (if applicable).")]
        [DataMember(Name = "AwayTeamScoreExtraTime", Order = 23)]
        public int? AwayTeamScoreExtraTime { get; set; }

        /// <summary>
        /// The penalty shootout score of the away team (if applicable).
        /// </summary>
        [Description("The penalty shootout score of the away team (if applicable).")]
        [DataMember(Name = "AwayTeamScorePenalty", Order = 24)]
        public int? AwayTeamScorePenalty { get; set; }

        /// <summary>
        /// The abbreviation of the home team.
        /// </summary>
        [Description("The abbreviation of the home team.")]
        [DataMember(Name = "HomeTeamKey", Order = 25)]
        public string HomeTeamKey { get; set; }

        /// <summary>
        /// The name of the home team.
        /// </summary>
        [Description("The name of the home team.")]
        [DataMember(Name = "HomeTeamName", Order = 26)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// The country code of the home team.
        /// </summary>
        [Description("The country code of the home team.")]
        [DataMember(Name = "HomeTeamCountryCode", Order = 27)]
        public string HomeTeamCountryCode { get; set; }

        /// <summary>
        /// The final score of the home team.
        /// </summary>
        [Description("The final score of the home team.")]
        [DataMember(Name = "HomeTeamScore", Order = 28)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The first period score of the home team.
        /// </summary>
        [Description("The first period score of the home team.")]
        [DataMember(Name = "HomeTeamScorePeriod1", Order = 29)]
        public int? HomeTeamScorePeriod1 { get; set; }

        /// <summary>
        /// The second period score of the home team.
        /// </summary>
        [Description("The second period score of the home team.")]
        [DataMember(Name = "HomeTeamScorePeriod2", Order = 30)]
        public int? HomeTeamScorePeriod2 { get; set; }

        /// <summary>
        /// The extra time (overtime) score of the home team (if applicable).
        /// </summary>
        [Description("The extra time (overtime) score of the home team (if applicable).")]
        [DataMember(Name = "HomeTeamScoreExtraTime", Order = 31)]
        public int? HomeTeamScoreExtraTime { get; set; }

        /// <summary>
        /// The penalty shootout score of the home team (if applicable).
        /// </summary>
        [Description("The penalty shootout score of the home team (if applicable).")]
        [DataMember(Name = "HomeTeamScorePenalty", Order = 32)]
        public int? HomeTeamScorePenalty { get; set; }

        /// <summary>
        /// The timestamp of when this record was updated, based on US Eatern Time (EST/EDT).
        /// </summary>
        [Description("The timestamp of when this record was updated, based on US Eatern Time (EST/EDT).")]
        [DataMember(Name = "Updated", Order = 33)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when this record was updated, based on Universal Coordinated Time (UTC).
        /// </summary>
        [Description("The timestamp of when this record was updated, based on Universal Coordinated Time (UTC).")]
        [DataMember(Name = "UpdatedUtc", Order = 34)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 35)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamId", Order = 36)]
        public int? GlobalAwayTeamId { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamId", Order = 37)]
        public int? GlobalHomeTeamId { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score and stats have been verified and closed out
        /// </summary>
        [Description("Indicates whether the game is over and the final score and stats have been verified and closed out")]
        [DataMember(Name = "IsClosed", Order = 38)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// Aggregate scoring information for 2-leg/home-and-home games (i.e. Champions League Round of 16).  Team A is determined by the first leg’s home team.
        /// </summary>
        [Description("Aggregate scoring information for 2-leg/home-and-home games (i.e. Champions League Round of 16).  Team A is determined by the first leg’s home team.")]
        [DataMember(Name = "PlayoffAggregateScore", Order = 10039)]
        public PlayoffAggregateScore PlayoffAggregateScore { get; set; }

    }
}

