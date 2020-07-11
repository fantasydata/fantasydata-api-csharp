using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.MMA
{
    [DataContract(Namespace="", Name="FightDetail")]
    [Serializable]
    public partial class FightDetail
    {
        /// <summary>
        /// Stats for each fighter in this fight
        /// </summary>
        [Description("Stats for each fighter in this fight")]
        [DataMember(Name = "FightStats", Order = 20001)]
        public FightStat[] FightStats { get; set; }

        /// <summary>
        /// The unique ID of this fight
        /// </summary>
        [Description("The unique ID of this fight")]
        [DataMember(Name = "FightId", Order = 2)]
        public int FightId { get; set; }

        /// <summary>
        /// The order of this fight on the fight card
        /// </summary>
        [Description("The order of this fight on the fight card")]
        [DataMember(Name = "Order", Order = 3)]
        public int? Order { get; set; }

        /// <summary>
        /// Indicates the fight's status. Possible values include: Scheduled, InProgress, Final, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the fight's status. Possible values include: Scheduled, InProgress, Final, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The weight class for this fight
        /// </summary>
        [Description("The weight class for this fight")]
        [DataMember(Name = "WeightClass", Order = 5)]
        public string WeightClass { get; set; }

        /// <summary>
        /// The card segment for this fight
        /// </summary>
        [Description("The card segment for this fight")]
        [DataMember(Name = "CardSegment", Order = 6)]
        public string CardSegment { get; set; }

        /// <summary>
        /// The number of referee for this fight
        /// </summary>
        [Description("The number of referee for this fight")]
        [DataMember(Name = "Referee", Order = 7)]
        public string Referee { get; set; }

        /// <summary>
        /// The number of rounds for this fight
        /// </summary>
        [Description("The number of rounds for this fight")]
        [DataMember(Name = "Rounds", Order = 8)]
        public int? Rounds { get; set; }

        /// <summary>
        /// The time on the clock in seconds when the fight ended
        /// </summary>
        [Description("The time on the clock in seconds when the fight ended")]
        [DataMember(Name = "ResultClock", Order = 9)]
        public int? ResultClock { get; set; }

        /// <summary>
        /// The round when the fight ended
        /// </summary>
        [Description("The round when the fight ended")]
        [DataMember(Name = "ResultRound", Order = 10)]
        public int? ResultRound { get; set; }

        /// <summary>
        /// The way in which this fight ended
        /// </summary>
        [Description("The way in which this fight ended")]
        [DataMember(Name = "ResultType", Order = 11)]
        public string ResultType { get; set; }

        /// <summary>
        /// The unique ID of the winning fighter
        /// </summary>
        [Description("The unique ID of the winning fighter")]
        [DataMember(Name = "WinnerId", Order = 12)]
        public int? WinnerId { get; set; }

        /// <summary>
        /// The fighters competing in this fight
        /// </summary>
        [Description("The fighters competing in this fight")]
        [DataMember(Name = "Fighters", Order = 20013)]
        public FighterInfo[] Fighters { get; set; }

    }
}

