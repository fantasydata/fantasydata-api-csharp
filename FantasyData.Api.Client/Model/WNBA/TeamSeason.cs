using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
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
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The WNBA season for which these totals apply
        /// </summary>
        [Description("The WNBA season for which these totals apply")]
        [DataMember(Name = "Season", Order = 4)]
        public int? Season { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sparks; Suns; Dream; etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sparks; Suns; Dream; etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The total number of wins by the team in the season
        /// </summary>
        [Description("The total number of wins by the team in the season")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total number of team losses
        /// </summary>
        [Description("Total number of team losses")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// A globally unique ID for the team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 9)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 11)]
        public int? Games { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 12)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 13)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of field goals made
        /// </summary>
        [Description("Total number of field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 14)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total number of field goals attempted
        /// </summary>
        [Description("Total number of field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 15)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalsPercentage", Order = 16)]
        public decimal? FieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total effective field goals percentage
        /// </summary>
        [Description("Total effective field goals percentage")]
        [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 17)]
        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total two pointers made
        /// </summary>
        [Description("Total two pointers made")]
        [DataMember(Name = "TwoPointersMade", Order = 18)]
        public decimal? TwoPointersMade { get; set; }

        /// <summary>
        /// Total two pointers attempted
        /// </summary>
        [Description("Total two pointers attempted")]
        [DataMember(Name = "TwoPointersAttempted", Order = 19)]
        public decimal? TwoPointersAttempted { get; set; }

        /// <summary>
        /// Total two pointers percentage
        /// </summary>
        [Description("Total two pointers percentage")]
        [DataMember(Name = "TwoPointersPercentage", Order = 20)]
        public decimal? TwoPointersPercentage { get; set; }

        /// <summary>
        /// Total three pointers made
        /// </summary>
        [Description("Total three pointers made")]
        [DataMember(Name = "ThreePointersMade", Order = 21)]
        public decimal? ThreePointersMade { get; set; }

        /// <summary>
        /// Total three pointers attempted
        /// </summary>
        [Description("Total three pointers attempted")]
        [DataMember(Name = "ThreePointersAttempted", Order = 22)]
        public decimal? ThreePointersAttempted { get; set; }

        /// <summary>
        /// Total three pointers percentage
        /// </summary>
        [Description("Total three pointers percentage")]
        [DataMember(Name = "ThreePointersPercentage", Order = 23)]
        public decimal? ThreePointersPercentage { get; set; }

        /// <summary>
        /// Total free throws made
        /// </summary>
        [Description("Total free throws made")]
        [DataMember(Name = "FreeThrowsMade", Order = 24)]
        public decimal? FreeThrowsMade { get; set; }

        /// <summary>
        /// Total free throws attempted
        /// </summary>
        [Description("Total free throws attempted")]
        [DataMember(Name = "FreeThrowsAttempted", Order = 25)]
        public decimal? FreeThrowsAttempted { get; set; }

        /// <summary>
        /// Total free throws percentage
        /// </summary>
        [Description("Total free throws percentage")]
        [DataMember(Name = "FreeThrowsPercentage", Order = 26)]
        public decimal? FreeThrowsPercentage { get; set; }

        /// <summary>
        /// Total offensive rebounds
        /// </summary>
        [Description("Total offensive rebounds")]
        [DataMember(Name = "OffensiveRebounds", Order = 27)]
        public decimal? OffensiveRebounds { get; set; }

        /// <summary>
        /// Total defensive rebounds
        /// </summary>
        [Description("Total defensive rebounds")]
        [DataMember(Name = "DefensiveRebounds", Order = 28)]
        public decimal? DefensiveRebounds { get; set; }

        /// <summary>
        /// Total rebounds
        /// </summary>
        [Description("Total rebounds")]
        [DataMember(Name = "Rebounds", Order = 29)]
        public decimal? Rebounds { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 30)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total steals
        /// </summary>
        [Description("Total steals")]
        [DataMember(Name = "Steals", Order = 31)]
        public decimal? Steals { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 32)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total turnovers
        /// </summary>
        [Description("Total turnovers")]
        [DataMember(Name = "Turnovers", Order = 33)]
        public decimal? Turnovers { get; set; }

        /// <summary>
        /// Total personal fouls
        /// </summary>
        [Description("Total personal fouls")]
        [DataMember(Name = "PersonalFouls", Order = 34)]
        public decimal? PersonalFouls { get; set; }

        /// <summary>
        /// Total points scored
        /// </summary>
        [Description("Total points scored")]
        [DataMember(Name = "Points", Order = 35)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingAttempts", Order = 36)]
        public decimal? TrueShootingAttempts { get; set; }

        /// <summary>
        /// The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingPercentage", Order = 37)]
        public decimal? TrueShootingPercentage { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 38)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total double-doubles scored
        /// </summary>
        [Description("Total double-doubles scored")]
        [DataMember(Name = "DoubleDoubles", Order = 39)]
        public decimal? DoubleDoubles { get; set; }

        /// <summary>
        /// Total triple-doubles scored
        /// </summary>
        [Description("Total triple-doubles scored")]
        [DataMember(Name = "TripleDoubles", Order = 40)]
        public decimal? TripleDoubles { get; set; }

    }
}

