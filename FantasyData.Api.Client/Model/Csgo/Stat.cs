using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Csgo
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 2)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 3)]
        public int? Games { get; set; }

        /// <summary>
        /// The number of maps played
        /// </summary>
        [Description("The number of maps played")]
        [DataMember(Name = "Maps", Order = 4)]
        public decimal? Maps { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 5)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total kills
        /// </summary>
        [Description("Total kills")]
        [DataMember(Name = "Kills", Order = 6)]
        public decimal? Kills { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 7)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total deaths
        /// </summary>
        [Description("Total deaths")]
        [DataMember(Name = "Deaths", Order = 8)]
        public decimal? Deaths { get; set; }

        /// <summary>
        /// Total headshots
        /// </summary>
        [Description("Total headshots")]
        [DataMember(Name = "Headshots", Order = 9)]
        public decimal? Headshots { get; set; }

        /// <summary>
        /// Average damage per round
        /// </summary>
        [Description("Average damage per round")]
        [DataMember(Name = "AverageDamagePerRound", Order = 10)]
        public decimal? AverageDamagePerRound { get; set; }

        /// <summary>
        /// Percentage of rounds in which the player either had a kill, assist, survived or was traded
        /// </summary>
        [Description("Percentage of rounds in which the player either had a kill, assist, survived or was traded")]
        [DataMember(Name = "Kast", Order = 11)]
        public decimal? Kast { get; set; }

        /// <summary>
        /// A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)
        /// </summary>
        [Description("A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)")]
        [DataMember(Name = "Rating", Order = 12)]
        public decimal? Rating { get; set; }

    }
}

