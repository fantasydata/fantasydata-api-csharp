using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Csgo
{
    [DataContract(Namespace="", Name="Map")]
    [Serializable]
    public partial class Map
    {
        /// <summary>
        /// The number of this map in the order it was played
        /// </summary>
        [Description("The number of this map in the order it was played")]
        [DataMember(Name = "Number", Order = 1)]
        public int? Number { get; set; }

        /// <summary>
        /// The name of this map
        /// </summary>
        [Description("The name of this map")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The current status of the round being played on this map. Possible values include: Scheduled, InProgress, Final
        /// </summary>
        [Description("The current status of the round being played on this map. Possible values include: Scheduled, InProgress, Final")]
        [DataMember(Name = "Status", Order = 3)]
        public string Status { get; set; }

        /// <summary>
        /// The current round of this map
        /// </summary>
        [Description("The current round of this map")]
        [DataMember(Name = "CurrentRound", Order = 4)]
        public int? CurrentRound { get; set; }

        /// <summary>
        /// The score of team A for this map
        /// </summary>
        [Description("The score of team A for this map")]
        [DataMember(Name = "TeamAScore", Order = 5)]
        public int? TeamAScore { get; set; }

        /// <summary>
        /// The score of team B for this map
        /// </summary>
        [Description("The score of team B for this map")]
        [DataMember(Name = "TeamBScore", Order = 6)]
        public int? TeamBScore { get; set; }

        /// <summary>
        /// The leaderboard for this map
        /// </summary>
        [Description("The leaderboard for this map")]
        [DataMember(Name = "Leaderboards", Order = 20007)]
        public Leaderboard[] Leaderboards { get; set; }

    }
}

