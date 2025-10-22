using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="StartingLineups")]
    [Serializable]
    public partial class StartingLineups
    {
        /// <summary>
        /// The unique ID of the game tied to the StartingLineups
        /// </summary>
        [Description("The unique ID of the game tied to the StartingLineups")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; Suspended; Delayed; Postponed; Canceled; Forfeit; NotNecessary.
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; Suspended; Delayed; Postponed; Canceled; Forfeit; NotNecessary.")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to these StartingLineups
        /// </summary>
        [Description("The unique ID of the home team tied to these StartingLineups")]
        [DataMember(Name = "HomeTeamID", Order = 7)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the Home Team
        /// </summary>
        [Description("The abbreviation [Key] of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique TeamID of the away team
        /// </summary>
        [Description("The unique TeamID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 10)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Home team starting pitcher. Note: this is a probable pitcher until confirmed field = TRUE.
        /// </summary>
        [Description("Home team starting pitcher. Note: this is a probable pitcher until confirmed field = TRUE.")]
        [DataMember(Name = "HomeStartingPitcher", Order = 10011)]
        public Lineup HomeStartingPitcher { get; set; }

        /// <summary>
        /// The batting lineup of the home team
        /// </summary>
        [Description("The batting lineup of the home team")]
        [DataMember(Name = "HomeBattingLineup", Order = 20012)]
        public Lineup[] HomeBattingLineup { get; set; }

        /// <summary>
        /// Away team starting pitcher. Note: this is a probable pitcher until confirmed field = TRUE.
        /// </summary>
        [Description("Away team starting pitcher. Note: this is a probable pitcher until confirmed field = TRUE.")]
        [DataMember(Name = "AwayStartingPitcher", Order = 10013)]
        public Lineup AwayStartingPitcher { get; set; }

        /// <summary>
        /// Away team batting lineup for the game
        /// </summary>
        [Description("Away team batting lineup for the game")]
        [DataMember(Name = "AwayBattingLineup", Order = 20014)]
        public Lineup[] AwayBattingLineup { get; set; }

        /// <summary>
        /// Indicates whether the home team will use an Opener as the starting pitcher. NOTE: An opener is a pitcher (typically a relief pitcher) that is only scheduled to pitch the first 1-3 innings of the game.
        /// </summary>
        [Description("Indicates whether the home team will use an Opener as the starting pitcher. NOTE: An opener is a pitcher (typically a relief pitcher) that is only scheduled to pitch the first 1-3 innings of the game.")]
        [DataMember(Name = "HomeTeamOpener", Order = 15)]
        public bool? HomeTeamOpener { get; set; }

        /// <summary>
        /// Indicates whether the away team will use an Opener as the starting pitcher. NOTE: An opener is a pitcher (typically a relief pitcher) that is only scheduled to pitch the first 1-3 innings of the game.
        /// </summary>
        [Description("Indicates whether the away team will use an Opener as the starting pitcher. NOTE: An opener is a pitcher (typically a relief pitcher) that is only scheduled to pitch the first 1-3 innings of the game.")]
        [DataMember(Name = "AwayTeamOpener", Order = 16)]
        public bool? AwayTeamOpener { get; set; }

    }
}

