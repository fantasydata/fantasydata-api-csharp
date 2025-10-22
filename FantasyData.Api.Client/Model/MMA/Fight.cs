using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="Fight")]
    [Serializable]
    public partial class Fight
    {
        /// <summary>
        /// The unique ID of this fight
        /// </summary>
        [Description("The unique ID of this fight")]
        [DataMember(Name = "FightId", Order = 1)]
        public int FightId { get; set; }

        /// <summary>
        /// The order of this fight on the fight card
        /// </summary>
        [Description("The order of this fight on the fight card")]
        [DataMember(Name = "Order", Order = 2)]
        public int? Order { get; set; }

        /// <summary>
        /// Indicates the event's status. Possible values include: Scheduled; In Progress; Final; Suspended; Postponed; Canceled; NULL
        /// </summary>
        [Description("Indicates the event's status. Possible values include: Scheduled; In Progress; Final; Suspended; Postponed; Canceled; NULL")]
        [DataMember(Name = "Status", Order = 3)]
        public string Status { get; set; }

        /// <summary>
        /// The weight class this fight is taking place at
        /// </summary>
        [Description("The weight class this fight is taking place at")]
        [DataMember(Name = "WeightClass", Order = 4)]
        public string WeightClass { get; set; }

        /// <summary>
        /// What segment of the card this fight is on (Main Card, Prelims, Early Prelims)
        /// </summary>
        [Description("What segment of the card this fight is on (Main Card, Prelims, Early Prelims)")]
        [DataMember(Name = "CardSegment", Order = 5)]
        public string CardSegment { get; set; }

        /// <summary>
        /// The number of referee for this fight
        /// </summary>
        [Description("The number of referee for this fight")]
        [DataMember(Name = "Referee", Order = 6)]
        public string Referee { get; set; }

        /// <summary>
        /// The number of rounds for this fight
        /// </summary>
        [Description("The number of rounds for this fight")]
        [DataMember(Name = "Rounds", Order = 7)]
        public int? Rounds { get; set; }

        /// <summary>
        /// The time on the clock in seconds when the fight ended
        /// </summary>
        [Description("The time on the clock in seconds when the fight ended")]
        [DataMember(Name = "ResultClock", Order = 8)]
        public int? ResultClock { get; set; }

        /// <summary>
        /// The round when the fight ended
        /// </summary>
        [Description("The round when the fight ended")]
        [DataMember(Name = "ResultRound", Order = 9)]
        public int? ResultRound { get; set; }

        /// <summary>
        /// The way in which this fight ended
        /// </summary>
        [Description("The way in which this fight ended")]
        [DataMember(Name = "ResultType", Order = 10)]
        public string ResultType { get; set; }

        /// <summary>
        /// The unique ID of the fighter who won the fight
        /// </summary>
        [Description("The unique ID of the fighter who won the fight")]
        [DataMember(Name = "WinnerId", Order = 11)]
        public int? WinnerId { get; set; }

        /// <summary>
        /// The fighters competing in this fight and their info (FIghterID, FirstName, LastName, PreFightWins, PreFightLosses, PreFightDraws, PreFightNoContests, Winner, Moneyline)
        /// </summary>
        [Description("The fighters competing in this fight and their info (FIghterID, FirstName, LastName, PreFightWins, PreFightLosses, PreFightDraws, PreFightNoContests, Winner, Moneyline)")]
        [DataMember(Name = "Fighters", Order = 20012)]
        public FighterInfo[] Fighters { get; set; }

        /// <summary>
        /// Indicates the fight is still active
        /// </summary>
        [Description("Indicates the fight is still active")]
        [DataMember(Name = "Active", Order = 13)]
        public bool? Active { get; set; }

    }
}

