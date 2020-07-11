using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Csgo
{
    [DataContract(Namespace="", Name="PlayerGameProjection")]
    [Serializable]
    public partial class PlayerGameProjection
    {
        /// <summary>
        /// The unique ID of this player
        /// </summary>
        [Description("The unique ID of this player")]
        [DataMember(Name = "PlayerId", Order = 1)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// The unique ID of this player's team
        /// </summary>
        [Description("The unique ID of this player's team")]
        [DataMember(Name = "TeamId", Order = 2)]
        public int? TeamId { get; set; }

        /// <summary>
        /// The name of this player
        /// </summary>
        [Description("The name of this player")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The match name of this player
        /// </summary>
        [Description("The match name of this player")]
        [DataMember(Name = "MatchName", Order = 4)]
        public string MatchName { get; set; }

        /// <summary>
        /// The team name of this player
        /// </summary>
        [Description("The team name of this player")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 6)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 7)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 8)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 9)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (UTC)
        /// </summary>
        [Description("The date and time of the game (UTC)")]
        [DataMember(Name = "DateTime", Order = 10)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 12)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 13)]
        public int? Games { get; set; }

        /// <summary>
        /// The number of maps played
        /// </summary>
        [Description("The number of maps played")]
        [DataMember(Name = "Maps", Order = 14)]
        public decimal? Maps { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 15)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total kills
        /// </summary>
        [Description("Total kills")]
        [DataMember(Name = "Kills", Order = 16)]
        public decimal? Kills { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 17)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total deaths
        /// </summary>
        [Description("Total deaths")]
        [DataMember(Name = "Deaths", Order = 18)]
        public decimal? Deaths { get; set; }

        /// <summary>
        /// Total headshots
        /// </summary>
        [Description("Total headshots")]
        [DataMember(Name = "Headshots", Order = 19)]
        public decimal? Headshots { get; set; }

        /// <summary>
        /// Average damage per round
        /// </summary>
        [Description("Average damage per round")]
        [DataMember(Name = "AverageDamagePerRound", Order = 20)]
        public decimal? AverageDamagePerRound { get; set; }

        /// <summary>
        /// Percentage of rounds in which the player either had a kill, assist, survived or was traded
        /// </summary>
        [Description("Percentage of rounds in which the player either had a kill, assist, survived or was traded")]
        [DataMember(Name = "Kast", Order = 21)]
        public decimal? Kast { get; set; }

        /// <summary>
        /// A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)
        /// </summary>
        [Description("A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)")]
        [DataMember(Name = "Rating", Order = 22)]
        public decimal? Rating { get; set; }

    }
}

