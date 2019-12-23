using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="DailyFantasyScoring")]
    [Serializable]
    public partial class DailyFantasyScoring
    {
        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the team of this player
        /// </summary>
        [Description("The abbreviation of the team of this player")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The player's daily fantasy position
        /// </summary>
        [Description("The player's daily fantasy position")]
        [DataMember(Name = "Position", Order = 4)]
        public string Position { get; set; }

        /// <summary>
        /// The player's current fantasy points scored
        /// </summary>
        [Description("The player's current fantasy points scored")]
        [DataMember(Name = "FantasyPoints", Order = 5)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The player's current fantasy points scored in PPR scoring systems
        /// </summary>
        [Description("The player's current fantasy points scored in PPR scoring systems")]
        [DataMember(Name = "FantasyPointsPPR", Order = 6)]
        public decimal? FantasyPointsPPR { get; set; }

        /// <summary>
        /// The player's current fantasy points scored in FanDuel's daily fantasy scoring system
        /// </summary>
        [Description("The player's current fantasy points scored in FanDuel's daily fantasy scoring system")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 7)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// The player's current fantasy points scored in DraftKings' daily fantasy scoring system
        /// </summary>
        [Description("The player's current fantasy points scored in DraftKings' daily fantasy scoring system")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 8)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's current fantasy points scored in Yahoo's daily fantasy scoring system
        /// </summary>
        [Description("The player's current fantasy points scored in Yahoo's daily fantasy scoring system")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 9)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Whether this player's game has started
        /// </summary>
        [Description("Whether this player's game has started")]
        [DataMember(Name = "HasStarted", Order = 10)]
        public bool HasStarted { get; set; }

        /// <summary>
        /// Whether this player's game is in progress
        /// </summary>
        [Description("Whether this player's game is in progress")]
        [DataMember(Name = "IsInProgress", Order = 11)]
        public bool IsInProgress { get; set; }

        /// <summary>
        /// Whether this player's game is over
        /// </summary>
        [Description("Whether this player's game is over")]
        [DataMember(Name = "IsOver", Order = 12)]
        public bool IsOver { get; set; }

        /// <summary>
        /// The date/time that this player's game started
        /// </summary>
        [Description("The date/time that this player's game started")]
        [DataMember(Name = "Date", Order = 13)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The player's current fantasy points scored in FantasyDraft's daily fantasy scoring system
        /// </summary>
        [Description("The player's current fantasy points scored in FantasyDraft's daily fantasy scoring system")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 14)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

