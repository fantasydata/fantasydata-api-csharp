using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="PlayerGame")]
    [Serializable]
    public partial class PlayerGame
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The WNBA season of the game
        /// </summary>
        [Description("The WNBA season of the game")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: PG; SG; SF; PF; C
        /// </summary>
        [Description("The player's primary position. Possible values: PG; SG; SF; PF; C")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// Whether the player started in the game
        /// </summary>
        [Description("Whether the player started in the game")]
        [DataMember(Name = "Started", Order = 9)]
        public int? Started { get; set; }

        /// <summary>
        /// Injury status used to project availability. Statuses: Probable; Questionable; Doubtful; Out. If a player has a NULL injury status, they are healthy/available to play.
        /// </summary>
        [Description("Injury status used to project availability. Statuses: Probable; Questionable; Doubtful; Out. If a player has a NULL injury status, they are healthy/available to play.")]
        [DataMember(Name = "InjuryStatus", Order = 10)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// "The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.)  Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle"
        /// </summary>
        [Description("\"The player's body part(s) that are injured (e.g. Knee; Groin; Calf; Hamstring; etc.)  Note: if a player has multiple injured body parts they will appear as such - Hamstring/Ankle\"")]
        [DataMember(Name = "InjuryBodyPart", Order = 11)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The date that the injury occurred, was first discovered, or was freshly updated
        /// </summary>
        [Description("The date that the injury occurred, was first discovered, or was freshly updated")]
        [DataMember(Name = "InjuryStartDate", Order = 12)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique.
        /// </summary>
        [Description("Short description of injury involving injured body part(s), game status, player name, team name, and other extra news necessary. Notes are custom and can be unique.")]
        [DataMember(Name = "InjuryNotes", Order = 13)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 14)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 15)]
        public int? GameID { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 16)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 17)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 18)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 19)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 20)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 21)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 22)]
        public int? Games { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 23)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 24)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of field goals made
        /// </summary>
        [Description("Total number of field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 25)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total number of field goals attempted
        /// </summary>
        [Description("Total number of field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 26)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalsPercentage", Order = 27)]
        public decimal? FieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total effective field goals percentage
        /// </summary>
        [Description("Total effective field goals percentage")]
        [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 28)]
        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total two pointers made
        /// </summary>
        [Description("Total two pointers made")]
        [DataMember(Name = "TwoPointersMade", Order = 29)]
        public decimal? TwoPointersMade { get; set; }

        /// <summary>
        /// Total two pointers attempted
        /// </summary>
        [Description("Total two pointers attempted")]
        [DataMember(Name = "TwoPointersAttempted", Order = 30)]
        public decimal? TwoPointersAttempted { get; set; }

        /// <summary>
        /// Total two pointers percentage
        /// </summary>
        [Description("Total two pointers percentage")]
        [DataMember(Name = "TwoPointersPercentage", Order = 31)]
        public decimal? TwoPointersPercentage { get; set; }

        /// <summary>
        /// Total three pointers made
        /// </summary>
        [Description("Total three pointers made")]
        [DataMember(Name = "ThreePointersMade", Order = 32)]
        public decimal? ThreePointersMade { get; set; }

        /// <summary>
        /// Total three pointers attempted
        /// </summary>
        [Description("Total three pointers attempted")]
        [DataMember(Name = "ThreePointersAttempted", Order = 33)]
        public decimal? ThreePointersAttempted { get; set; }

        /// <summary>
        /// Total three pointers percentage
        /// </summary>
        [Description("Total three pointers percentage")]
        [DataMember(Name = "ThreePointersPercentage", Order = 34)]
        public decimal? ThreePointersPercentage { get; set; }

        /// <summary>
        /// Total free throws made
        /// </summary>
        [Description("Total free throws made")]
        [DataMember(Name = "FreeThrowsMade", Order = 35)]
        public decimal? FreeThrowsMade { get; set; }

        /// <summary>
        /// Total free throws attempted
        /// </summary>
        [Description("Total free throws attempted")]
        [DataMember(Name = "FreeThrowsAttempted", Order = 36)]
        public decimal? FreeThrowsAttempted { get; set; }

        /// <summary>
        /// Total free throws percentage
        /// </summary>
        [Description("Total free throws percentage")]
        [DataMember(Name = "FreeThrowsPercentage", Order = 37)]
        public decimal? FreeThrowsPercentage { get; set; }

        /// <summary>
        /// Total offensive rebounds
        /// </summary>
        [Description("Total offensive rebounds")]
        [DataMember(Name = "OffensiveRebounds", Order = 38)]
        public decimal? OffensiveRebounds { get; set; }

        /// <summary>
        /// Total defensive rebounds
        /// </summary>
        [Description("Total defensive rebounds")]
        [DataMember(Name = "DefensiveRebounds", Order = 39)]
        public decimal? DefensiveRebounds { get; set; }

        /// <summary>
        /// Total rebounds
        /// </summary>
        [Description("Total rebounds")]
        [DataMember(Name = "Rebounds", Order = 40)]
        public decimal? Rebounds { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 41)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total steals
        /// </summary>
        [Description("Total steals")]
        [DataMember(Name = "Steals", Order = 42)]
        public decimal? Steals { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 43)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total turnovers
        /// </summary>
        [Description("Total turnovers")]
        [DataMember(Name = "Turnovers", Order = 44)]
        public decimal? Turnovers { get; set; }

        /// <summary>
        /// Total personal fouls
        /// </summary>
        [Description("Total personal fouls")]
        [DataMember(Name = "PersonalFouls", Order = 45)]
        public decimal? PersonalFouls { get; set; }

        /// <summary>
        /// Total points scored
        /// </summary>
        [Description("Total points scored")]
        [DataMember(Name = "Points", Order = 46)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingAttempts", Order = 47)]
        public decimal? TrueShootingAttempts { get; set; }

        /// <summary>
        /// The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingPercentage", Order = 48)]
        public decimal? TrueShootingPercentage { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 49)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total double-doubles scored
        /// </summary>
        [Description("Total double-doubles scored")]
        [DataMember(Name = "DoubleDoubles", Order = 50)]
        public decimal? DoubleDoubles { get; set; }

        /// <summary>
        /// Total triple-doubles scored
        /// </summary>
        [Description("Total triple-doubles scored")]
        [DataMember(Name = "TripleDoubles", Order = 51)]
        public decimal? TripleDoubles { get; set; }

    }
}

