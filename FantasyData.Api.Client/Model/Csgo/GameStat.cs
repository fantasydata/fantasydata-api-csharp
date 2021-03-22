using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Csgo
{
    [DataContract(Namespace="", Name="GameStat")]
    [Serializable]
    public partial class GameStat
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 2)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 3)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (UTC)
        /// </summary>
        [Description("The date and time of the game (UTC)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 6)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 7)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 8)]
        public int? Games { get; set; }

        /// <summary>
        /// The number of maps played
        /// </summary>
        [Description("The number of maps played")]
        [DataMember(Name = "Maps", Order = 9)]
        public decimal? Maps { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 10)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total kills
        /// </summary>
        [Description("Total kills")]
        [DataMember(Name = "Kills", Order = 11)]
        public decimal? Kills { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 12)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total deaths
        /// </summary>
        [Description("Total deaths")]
        [DataMember(Name = "Deaths", Order = 13)]
        public decimal? Deaths { get; set; }

        /// <summary>
        /// Total headshots
        /// </summary>
        [Description("Total headshots")]
        [DataMember(Name = "Headshots", Order = 14)]
        public decimal? Headshots { get; set; }

        /// <summary>
        /// Average damage per round
        /// </summary>
        [Description("Average damage per round")]
        [DataMember(Name = "AverageDamagePerRound", Order = 15)]
        public decimal? AverageDamagePerRound { get; set; }

        /// <summary>
        /// Percentage of rounds in which the player either had a kill, assist, survived or was traded
        /// </summary>
        [Description("Percentage of rounds in which the player either had a kill, assist, survived or was traded")]
        [DataMember(Name = "Kast", Order = 16)]
        public decimal? Kast { get; set; }

        /// <summary>
        /// A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)
        /// </summary>
        [Description("A rating of the player's total effectiveness, based on Rating 2.0 (https://www.hltv.org/news/20695/introducing-rating-20)")]
        [DataMember(Name = "Rating", Order = 17)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// The number of times the player got the first kill of the round
        /// </summary>
        [Description("The number of times the player got the first kill of the round")]
        [DataMember(Name = "EntryKills", Order = 18)]
        public decimal? EntryKills { get; set; }

        /// <summary>
        /// The number of times a player got a quad kill (4 kills in a round)
        /// </summary>
        [Description("The number of times a player got a quad kill (4 kills in a round)")]
        [DataMember(Name = "QuadKills", Order = 19)]
        public decimal? QuadKills { get; set; }

        /// <summary>
        /// The number of times the player killed the entire enemy squad in a round
        /// </summary>
        [Description("The number of times the player killed the entire enemy squad in a round")]
        [DataMember(Name = "Aces", Order = 20)]
        public decimal? Aces { get; set; }

        /// <summary>
        /// The number of rounds won while being the last surviving member of the team against 2 opponents
        /// </summary>
        [Description("The number of rounds won while being the last surviving member of the team against 2 opponents")]
        [DataMember(Name = "Clutch1v2s", Order = 21)]
        public decimal? Clutch1v2s { get; set; }

        /// <summary>
        /// The number of rounds won while being the last surviving member of the team against 3 opponents
        /// </summary>
        [Description("The number of rounds won while being the last surviving member of the team against 3 opponents")]
        [DataMember(Name = "Clutch1v3s", Order = 22)]
        public decimal? Clutch1v3s { get; set; }

        /// <summary>
        /// The number of rounds won while being the last surviving member of the team against 4 opponents
        /// </summary>
        [Description("The number of rounds won while being the last surviving member of the team against 4 opponents")]
        [DataMember(Name = "Clutch1v4s", Order = 23)]
        public decimal? Clutch1v4s { get; set; }

        /// <summary>
        /// The number of rounds won while being the last surviving member of the team against all 5 opponents
        /// </summary>
        [Description("The number of rounds won while being the last surviving member of the team against all 5 opponents")]
        [DataMember(Name = "Clutch1v5s", Order = 24)]
        public decimal? Clutch1v5s { get; set; }

    }
}

