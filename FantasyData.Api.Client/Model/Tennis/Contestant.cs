using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Contestant")]
    [Serializable]
    public partial class Contestant
    {
        /// <summary>
        /// Unique ID of Contestant.
        /// </summary>
        [Description("Unique ID of Contestant.")]
        [DataMember(Name = "ContestantId", Order = 1)]
        public int ContestantId { get; set; }

        /// <summary>
        /// ID of Season in which the Contestant is participating.
        /// </summary>
        [Description("ID of Season in which the Contestant is participating.")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// ID of associated Discipline.
        /// </summary>
        [Description("ID of associated Discipline.")]
        [DataMember(Name = "DisciplineId", Order = 3)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// Associated Discipline (Singles, Doubles, Mixed Doubles).
        /// </summary>
        [Description("Associated Discipline (Singles, Doubles, Mixed Doubles).")]
        [DataMember(Name = "DisciplineType", Order = 4)]
        public string DisciplineType { get; set; }

        /// <summary>
        /// ID of Player
        /// </summary>
        [Description("ID of Player")]
        [DataMember(Name = "PlayerAId", Order = 5)]
        public int PlayerAId { get; set; }

        /// <summary>
        /// ID of Player B (if Doubles).
        /// </summary>
        [Description("ID of Player B (if Doubles).")]
        [DataMember(Name = "PlayerBId", Order = 6)]
        public int? PlayerBId { get; set; }

        /// <summary>
        /// Name of Player
        /// </summary>
        [Description("Name of Player")]
        [DataMember(Name = "PlayerAName", Order = 7)]
        public string PlayerAName { get; set; }

        /// <summary>
        /// Name of Player B (if Doubles).
        /// </summary>
        [Description("Name of Player B (if Doubles).")]
        [DataMember(Name = "PlayerBName", Order = 8)]
        public string PlayerBName { get; set; }

        /// <summary>
        /// Contestant seeding within relevant Season.
        /// </summary>
        [Description("Contestant seeding within relevant Season.")]
        [DataMember(Name = "Seeding", Order = 9)]
        public string Seeding { get; set; }

        /// <summary>
        /// Contestant draw position within relevant Season
        /// </summary>
        [Description("Contestant draw position within relevant Season")]
        [DataMember(Name = "DrawPosition", Order = 10)]
        public int? DrawPosition { get; set; }

        /// <summary>
        /// Prize money won by Contestant.
        /// </summary>
        [Description("Prize money won by Contestant.")]
        [DataMember(Name = "PrizeMoney", Order = 11)]
        public int? PrizeMoney { get; set; }

        /// <summary>
        /// Currency of prize money.
        /// </summary>
        [Description("Currency of prize money.")]
        [DataMember(Name = "Currency", Order = 12)]
        public string Currency { get; set; }

        /// <summary>
        /// Indicates if Contestant was the winner of the Season.
        /// </summary>
        [Description("Indicates if Contestant was the winner of the Season.")]
        [DataMember(Name = "Winner", Order = 13)]
        public bool? Winner { get; set; }

    }
}

