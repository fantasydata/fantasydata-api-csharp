using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The game score/status associated with this box score
        /// </summary>
        [Description("The game score/status associated with this box score")]
        [DataMember(Name = "Score", Order = 10001)]
        public Score Score { get; set; }

        /// <summary>
        /// The game stats associated with this box score
        /// </summary>
        [Description("The game stats associated with this box score")]
        [DataMember(Name = "Game", Order = 10002)]
        public Game Game { get; set; }

        /// <summary>
        /// The scoring plays associated with this box score
        /// </summary>
        [Description("The scoring plays associated with this box score")]
        [DataMember(Name = "ScoringPlays", Order = 20003)]
        public ScoringPlay[] ScoringPlays { get; set; }

        /// <summary>
        /// The scoring details associated with this box score
        /// </summary>
        [Description("The scoring details associated with this box score")]
        [DataMember(Name = "ScoringDetails", Order = 20004)]
        public ScoringDetail[] ScoringDetails { get; set; }

        /// <summary>
        /// The away fantasy defense stats associated with this box score
        /// </summary>
        [Description("The away fantasy defense stats associated with this box score")]
        [DataMember(Name = "AwayFantasyDefense", Order = 10005)]
        public FantasyDefenseGame AwayFantasyDefense { get; set; }

        /// <summary>
        /// The home fantasy defense stats associated with this box score
        /// </summary>
        [Description("The home fantasy defense stats associated with this box score")]
        [DataMember(Name = "HomeFantasyDefense", Order = 10006)]
        public FantasyDefenseGame HomeFantasyDefense { get; set; }

        /// <summary>
        /// The away passing stats associated with this box score
        /// </summary>
        [Description("The away passing stats associated with this box score")]
        [DataMember(Name = "AwayPassing", Order = 20007)]
        public PlayerPassing[] AwayPassing { get; set; }

        /// <summary>
        /// The away rushing stats associated with this box score
        /// </summary>
        [Description("The away rushing stats associated with this box score")]
        [DataMember(Name = "AwayRushing", Order = 20008)]
        public PlayerRushing[] AwayRushing { get; set; }

        /// <summary>
        /// The away receiving stats associated with this box score
        /// </summary>
        [Description("The away receiving stats associated with this box score")]
        [DataMember(Name = "AwayReceiving", Order = 20009)]
        public PlayerReceiving[] AwayReceiving { get; set; }

        /// <summary>
        /// The away kicking stats associated with this box score
        /// </summary>
        [Description("The away kicking stats associated with this box score")]
        [DataMember(Name = "AwayKicking", Order = 20010)]
        public PlayerKicking[] AwayKicking { get; set; }

        /// <summary>
        /// The away punting stats associated with this box score
        /// </summary>
        [Description("The away punting stats associated with this box score")]
        [DataMember(Name = "AwayPunting", Order = 20011)]
        public PlayerPunting[] AwayPunting { get; set; }

        /// <summary>
        /// The away kick punt returns stats associated with this box score
        /// </summary>
        [Description("The away kick punt returns stats associated with this box score")]
        [DataMember(Name = "AwayKickPuntReturns", Order = 20012)]
        public PlayerKickPuntReturns[] AwayKickPuntReturns { get; set; }

        /// <summary>
        /// The away defense stats associated with this box score
        /// </summary>
        [Description("The away defense stats associated with this box score")]
        [DataMember(Name = "AwayDefense", Order = 20013)]
        public PlayerDefense[] AwayDefense { get; set; }

        /// <summary>
        /// The home passing stats associated with this box score
        /// </summary>
        [Description("The home passing stats associated with this box score")]
        [DataMember(Name = "HomePassing", Order = 20014)]
        public PlayerPassing[] HomePassing { get; set; }

        /// <summary>
        /// The home rushing stats associated with this box score
        /// </summary>
        [Description("The home rushing stats associated with this box score")]
        [DataMember(Name = "HomeRushing", Order = 20015)]
        public PlayerRushing[] HomeRushing { get; set; }

        /// <summary>
        /// The home receiving stats associated with this box score
        /// </summary>
        [Description("The home receiving stats associated with this box score")]
        [DataMember(Name = "HomeReceiving", Order = 20016)]
        public PlayerReceiving[] HomeReceiving { get; set; }

        /// <summary>
        /// The home kicking stats associated with this box score
        /// </summary>
        [Description("The home kicking stats associated with this box score")]
        [DataMember(Name = "HomeKicking", Order = 20017)]
        public PlayerKicking[] HomeKicking { get; set; }

        /// <summary>
        /// The home punting stats associated with this box score
        /// </summary>
        [Description("The home punting stats associated with this box score")]
        [DataMember(Name = "HomePunting", Order = 20018)]
        public PlayerPunting[] HomePunting { get; set; }

        /// <summary>
        /// The home kick punt returns stats associated with this box score
        /// </summary>
        [Description("The home kick punt returns stats associated with this box score")]
        [DataMember(Name = "HomeKickPuntReturns", Order = 20019)]
        public PlayerKickPuntReturns[] HomeKickPuntReturns { get; set; }

        /// <summary>
        /// The home defense stats associated with this box score
        /// </summary>
        [Description("The home defense stats associated with this box score")]
        [DataMember(Name = "HomeDefense", Order = 20020)]
        public PlayerDefense[] HomeDefense { get; set; }

    }
}

