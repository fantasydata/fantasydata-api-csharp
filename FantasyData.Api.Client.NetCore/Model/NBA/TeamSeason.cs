﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NBA
{
    [DataContract(Namespace="", Name="TeamSeason")]
    [Serializable]
    public partial class TeamSeason
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NBA regular season for which these totals apply
        /// </summary>
        [Description("The NBA regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [Description("Team name")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Total number of wins
        /// </summary>
        [Description("Total number of wins")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total number of losses
        /// </summary>
        [Description("Total number of losses")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// Indicates which position is included in opponent stats that are aggregated together
        /// </summary>
        [Description("Indicates which position is included in opponent stats that are aggregated together")]
        [DataMember(Name = "OpponentPosition", Order = 9)]
        public string OpponentPosition { get; set; }

        /// <summary>
        /// The team's estimated number of possessions as defined by the formula here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The team's estimated number of possessions as defined by the formula here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "Possessions", Order = 10)]
        public decimal? Possessions { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 11)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The aggregated season stats for this team's opponents
        /// </summary>
        [Description("The aggregated season stats for this team's opponents")]
        [DataMember(Name = "OpponentStat", Order = 10012)]
        public OpponentSeason OpponentStat { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 14)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 15)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 16)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 17)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of field goals made
        /// </summary>
        [Description("Total number of field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 18)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total number of field goals attempted
        /// </summary>
        [Description("Total number of field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 19)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalsPercentage", Order = 20)]
        public decimal? FieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total effective field goals percentage
        /// </summary>
        [Description("Total effective field goals percentage")]
        [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 21)]
        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total two pointers made
        /// </summary>
        [Description("Total two pointers made")]
        [DataMember(Name = "TwoPointersMade", Order = 22)]
        public decimal? TwoPointersMade { get; set; }

        /// <summary>
        /// Total two pointers attempted
        /// </summary>
        [Description("Total two pointers attempted")]
        [DataMember(Name = "TwoPointersAttempted", Order = 23)]
        public decimal? TwoPointersAttempted { get; set; }

        /// <summary>
        /// Total two pointers percentage
        /// </summary>
        [Description("Total two pointers percentage")]
        [DataMember(Name = "TwoPointersPercentage", Order = 24)]
        public decimal? TwoPointersPercentage { get; set; }

        /// <summary>
        /// Total three pointers made
        /// </summary>
        [Description("Total three pointers made")]
        [DataMember(Name = "ThreePointersMade", Order = 25)]
        public decimal? ThreePointersMade { get; set; }

        /// <summary>
        /// Total three pointers attempted
        /// </summary>
        [Description("Total three pointers attempted")]
        [DataMember(Name = "ThreePointersAttempted", Order = 26)]
        public decimal? ThreePointersAttempted { get; set; }

        /// <summary>
        /// Total three pointers percentage
        /// </summary>
        [Description("Total three pointers percentage")]
        [DataMember(Name = "ThreePointersPercentage", Order = 27)]
        public decimal? ThreePointersPercentage { get; set; }

        /// <summary>
        /// Total free throws made
        /// </summary>
        [Description("Total free throws made")]
        [DataMember(Name = "FreeThrowsMade", Order = 28)]
        public decimal? FreeThrowsMade { get; set; }

        /// <summary>
        /// Total free throws attempted
        /// </summary>
        [Description("Total free throws attempted")]
        [DataMember(Name = "FreeThrowsAttempted", Order = 29)]
        public decimal? FreeThrowsAttempted { get; set; }

        /// <summary>
        /// Total free throws percentage
        /// </summary>
        [Description("Total free throws percentage")]
        [DataMember(Name = "FreeThrowsPercentage", Order = 30)]
        public decimal? FreeThrowsPercentage { get; set; }

        /// <summary>
        /// Total offensive rebounds
        /// </summary>
        [Description("Total offensive rebounds")]
        [DataMember(Name = "OffensiveRebounds", Order = 31)]
        public decimal? OffensiveRebounds { get; set; }

        /// <summary>
        /// Total defensive rebounds
        /// </summary>
        [Description("Total defensive rebounds")]
        [DataMember(Name = "DefensiveRebounds", Order = 32)]
        public decimal? DefensiveRebounds { get; set; }

        /// <summary>
        /// Total rebounds
        /// </summary>
        [Description("Total rebounds")]
        [DataMember(Name = "Rebounds", Order = 33)]
        public decimal? Rebounds { get; set; }

        /// <summary>
        /// Total offensive rebounds percentage
        /// </summary>
        [Description("Total offensive rebounds percentage")]
        [DataMember(Name = "OffensiveReboundsPercentage", Order = 34)]
        public decimal? OffensiveReboundsPercentage { get; set; }

        /// <summary>
        /// Total defensive rebounds percentage
        /// </summary>
        [Description("Total defensive rebounds percentage")]
        [DataMember(Name = "DefensiveReboundsPercentage", Order = 35)]
        public decimal? DefensiveReboundsPercentage { get; set; }

        /// <summary>
        /// The player/team total rebounds percentage
        /// </summary>
        [Description("The player/team total rebounds percentage")]
        [DataMember(Name = "TotalReboundsPercentage", Order = 36)]
        public decimal? TotalReboundsPercentage { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 37)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total steals
        /// </summary>
        [Description("Total steals")]
        [DataMember(Name = "Steals", Order = 38)]
        public decimal? Steals { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 39)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total turnovers
        /// </summary>
        [Description("Total turnovers")]
        [DataMember(Name = "Turnovers", Order = 40)]
        public decimal? Turnovers { get; set; }

        /// <summary>
        /// Total personal fouls
        /// </summary>
        [Description("Total personal fouls")]
        [DataMember(Name = "PersonalFouls", Order = 41)]
        public decimal? PersonalFouls { get; set; }

        /// <summary>
        /// Total points scored
        /// </summary>
        [Description("Total points scored")]
        [DataMember(Name = "Points", Order = 42)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingAttempts", Order = 43)]
        public decimal? TrueShootingAttempts { get; set; }

        /// <summary>
        /// The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingPercentage", Order = 44)]
        public decimal? TrueShootingPercentage { get; set; }

        /// <summary>
        /// The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess
        /// </summary>
        [Description("The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess")]
        [DataMember(Name = "PlayerEfficiencyRating", Order = 45)]
        public decimal? PlayerEfficiencyRating { get; set; }

        /// <summary>
        /// The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "AssistsPercentage", Order = 46)]
        public decimal? AssistsPercentage { get; set; }

        /// <summary>
        /// The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "StealsPercentage", Order = 47)]
        public decimal? StealsPercentage { get; set; }

        /// <summary>
        /// The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "BlocksPercentage", Order = 48)]
        public decimal? BlocksPercentage { get; set; }

        /// <summary>
        /// The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TurnOversPercentage", Order = 49)]
        public decimal? TurnOversPercentage { get; set; }

        /// <summary>
        /// The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "UsageRatePercentage", Order = 50)]
        public decimal? UsageRatePercentage { get; set; }

        /// <summary>
        /// Total FanDuel daily fantasy points scored
        /// </summary>
        [Description("Total FanDuel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 51)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 52)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 53)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 54)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total double-doubles scored
        /// </summary>
        [Description("Total double-doubles scored")]
        [DataMember(Name = "DoubleDoubles", Order = 55)]
        public decimal? DoubleDoubles { get; set; }

        /// <summary>
        /// Total triple-doubles scored
        /// </summary>
        [Description("Total triple-doubles scored")]
        [DataMember(Name = "TripleDoubles", Order = 56)]
        public decimal? TripleDoubles { get; set; }

        /// <summary>
        /// Total FantasyDraft daily fantasy points scored
        /// </summary>
        [Description("Total FantasyDraft daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 57)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the stats for this player have been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the stats for this player have been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 58)]
        public bool IsClosed { get; set; }

    }
}

