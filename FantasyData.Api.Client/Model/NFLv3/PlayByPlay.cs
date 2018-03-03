using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayByPlay")]
    [Serializable]
    public partial class PlayByPlay
    {
        /// <summary>
        /// The latest regular season stats for this player
        /// </summary>
        [Description("The latest regular season stats for this player")]
        [DataMember(Name = "Score", Order = 10001)]
        public Score Score { get; set; }

        /// <summary>
        /// The latest regular season stats for this player
        /// </summary>
        [Description("The latest regular season stats for this player")]
        [DataMember(Name = "Quarters", Order = 20002)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The latest regular season stats for this player
        /// </summary>
        [Description("The latest regular season stats for this player")]
        [DataMember(Name = "Plays", Order = 20003)]
        public Play[] Plays { get; set; }

    }
}

