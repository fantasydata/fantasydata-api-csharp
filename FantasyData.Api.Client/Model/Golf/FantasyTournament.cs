using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="FantasyTournament")]
    [Serializable]
    public partial class FantasyTournament
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The unique ID of the golfer
        /// </summary>
        [Description("The unique ID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The PGA season for which this record applies
        /// </summary>
        [Description("The PGA season for which this record applies")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The time that this golfer tees off for the upcoming round (in US Eastern Time)
        /// </summary>
        [Description("The time that this golfer tees off for the upcoming round (in US Eastern Time)")]
        [DataMember(Name = "TeeTime", Order = 4)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// The name of the golfer
        /// </summary>
        [Description("The name of the golfer")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The rank of this golfer in the tournament
        /// </summary>
        [Description("The rank of this golfer in the tournament")]
        [DataMember(Name = "Rank", Order = 6)]
        public int? Rank { get; set; }

        /// <summary>
        /// Indicates whether a golfer is not playing in this tournament. Note: If golfer is not playing; this will be out
        /// </summary>
        [Description("Indicates whether a golfer is not playing in this tournament. Note: If golfer is not playing; this will be out")]
        [DataMember(Name = "TournamentStatus", Order = 7)]
        public string TournamentStatus { get; set; }

        /// <summary>
        /// Total fantasy points scored by the golfer in the tournament using FanDuel's scoring system
        /// </summary>
        [Description("Total fantasy points scored by the golfer in the tournament using FanDuel's scoring system")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 8)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total fantasy points scored by the golfer in the tournament using Yahoo's scoring system
        /// </summary>
        [Description("Total fantasy points scored by the golfer in the tournament using Yahoo's scoring system")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 9)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The date and time when this record was updated.
        /// </summary>
        [Description("The date and time when this record was updated.")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Total fantasy points scored by the golfer in the tournament using the default SportsDataIO scoring system
        /// </summary>
        [Description("Total fantasy points scored by the golfer in the tournament using the default SportsDataIO scoring system")]
        [DataMember(Name = "FantasyPoints", Order = 11)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total fantasy points scored by the golfer in the tournament using DraftKings' scoring system
        /// </summary>
        [Description("Total fantasy points scored by the golfer in the tournament using DraftKings' scoring system")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 12)]
        public decimal? FantasyPointsDraftKings { get; set; }

    }
}

