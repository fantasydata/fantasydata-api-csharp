using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="BoxScoreV3")]
    [Serializable]
    public partial class BoxScoreV3
    {
        /// <summary>
        /// The Score object related to this game
        /// </summary>
        [Description("The Score object related to this game")]
        [DataMember(Name = "Score", Order = 10001)]
        public Score Score { get; set; }

        /// <summary>
        /// The Quarters objects related to this game
        /// </summary>
        [Description("The Quarters objects related to this game")]
        [DataMember(Name = "Quarters", Order = 20002)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The TeamGame objects related to this game
        /// </summary>
        [Description("The TeamGame objects related to this game")]
        [DataMember(Name = "TeamGames", Order = 20003)]
        public TeamGame[] TeamGames { get; set; }

        /// <summary>
        /// The PlayerGame objects related to this game
        /// </summary>
        [Description("The PlayerGame objects related to this game")]
        [DataMember(Name = "PlayerGames", Order = 20004)]
        public PlayerGame[] PlayerGames { get; set; }

        /// <summary>
        /// The FantasyDefenseGame objects related to this game
        /// </summary>
        [Description("The FantasyDefenseGame objects related to this game")]
        [DataMember(Name = "FantasyDefenseGames", Order = 20005)]
        public FantasyDefenseGame[] FantasyDefenseGames { get; set; }

        /// <summary>
        /// The ScoringPlay objects related to this game
        /// </summary>
        [Description("The ScoringPlay objects related to this game")]
        [DataMember(Name = "ScoringPlays", Order = 20006)]
        public ScoringPlay[] ScoringPlays { get; set; }

        /// <summary>
        /// The ScoringDetail objects related to this game
        /// </summary>
        [Description("The ScoringDetail objects related to this game")]
        [DataMember(Name = "ScoringDetails", Order = 20007)]
        public ScoringDetail[] ScoringDetails { get; set; }

    }
}

