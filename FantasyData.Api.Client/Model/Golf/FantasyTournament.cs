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
        /// The TournamentID of the tournament
        /// </summary>
        [Description("The TournamentID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The PlayerID of the golfer
        /// </summary>
        [Description("The PlayerID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The season of this tournament
        /// </summary>
        [Description("The season of this tournament")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// Indicates the Player's Tee Time this round (from 2020)
        /// </summary>
        [Description("Indicates the Player's Tee Time this round (from 2020)")]
        [DataMember(Name = "TeeTime", Order = 4)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// The player's name
        /// </summary>
        [Description("The player's name")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The rank of this golfer in the tournament
        /// </summary>
        [Description("The rank of this golfer in the tournament")]
        [DataMember(Name = "Rank", Order = 6)]
        public int? Rank { get; set; }

        /// <summary>
        /// Indicates whether a golfer is not playing in this tournament (if golfer is not playing, this will be Out)
        /// </summary>
        [Description("Indicates whether a golfer is not playing in this tournament (if golfer is not playing, this will be Out)")]
        [DataMember(Name = "TournamentStatus", Order = 7)]
        public string TournamentStatus { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the FanDuel scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the FanDuel scoring system")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 8)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the Yahoo scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the Yahoo scoring system")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 9)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The date and time when this record was updated.
        /// </summary>
        [Description("The date and time when this record was updated.")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

    }
}

