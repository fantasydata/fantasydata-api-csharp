using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="MatchBan")]
    [Serializable]
    public partial class MatchBan
    {
        /// <summary>
        /// The unique id of the match
        /// </summary>
        [Description("The unique id of the match")]
        [DataMember(Name = "MatchId", Order = 1)]
        public int MatchId { get; set; }

        /// <summary>
        /// The unique id of the team doing the banning
        /// </summary>
        [Description("The unique id of the team doing the banning")]
        [DataMember(Name = "TeamId", Order = 2)]
        public int TeamId { get; set; }

        /// <summary>
        /// The unique id of the champion who is banned
        /// </summary>
        [Description("The unique id of the champion who is banned")]
        [DataMember(Name = "ChampionId", Order = 3)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// The basic info of the champion who is banned
        /// </summary>
        [Description("The basic info of the champion who is banned")]
        [DataMember(Name = "Champion", Order = 10004)]
        public ChampionInfo Champion { get; set; }

    }
}

