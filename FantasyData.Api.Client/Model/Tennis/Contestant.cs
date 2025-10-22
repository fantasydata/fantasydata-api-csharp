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
        /// The unique ID of the contestant
        /// </summary>
        [Description("The unique ID of the contestant")]
        [DataMember(Name = "ContestantId", Order = 1)]
        public int ContestantId { get; set; }

        /// <summary>
        /// The unique ID of the season in which the contestant is participating
        /// </summary>
        [Description("The unique ID of the season in which the contestant is participating")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// The ID of associated discipline
        /// </summary>
        [Description("The ID of associated discipline")]
        [DataMember(Name = "DisciplineId", Order = 3)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// Name of the associated discipline (Singles; Doubles; Mixed Doubles)
        /// </summary>
        [Description("Name of the associated discipline (Singles; Doubles; Mixed Doubles)")]
        [DataMember(Name = "DisciplineType", Order = 4)]
        public string DisciplineType { get; set; }

        /// <summary>
        /// The unique ID of player A
        /// </summary>
        [Description("The unique ID of player A")]
        [DataMember(Name = "PlayerAId", Order = 5)]
        public int PlayerAId { get; set; }

        /// <summary>
        /// The unique ID of player B (if doubles)
        /// </summary>
        [Description("The unique ID of player B (if doubles)")]
        [DataMember(Name = "PlayerBId", Order = 6)]
        public int? PlayerBId { get; set; }

        /// <summary>
        /// The name of the player A
        /// </summary>
        [Description("The name of the player A")]
        [DataMember(Name = "PlayerAName", Order = 7)]
        public string PlayerAName { get; set; }

        /// <summary>
        /// The name of the player B (if doubles)
        /// </summary>
        [Description("The name of the player B (if doubles)")]
        [DataMember(Name = "PlayerBName", Order = 8)]
        public string PlayerBName { get; set; }

        /// <summary>
        /// The contestant seeding within relevant season
        /// </summary>
        [Description("The contestant seeding within relevant season")]
        [DataMember(Name = "Seeding", Order = 9)]
        public string Seeding { get; set; }

        /// <summary>
        /// The contestant draw position within relevant season
        /// </summary>
        [Description("The contestant draw position within relevant season")]
        [DataMember(Name = "DrawPosition", Order = 10)]
        public int? DrawPosition { get; set; }

        /// <summary>
        /// Total prize money won by contestant
        /// </summary>
        [Description("Total prize money won by contestant")]
        [DataMember(Name = "PrizeMoney", Order = 11)]
        public int? PrizeMoney { get; set; }

        /// <summary>
        /// Currency of prize money
        /// </summary>
        [Description("Currency of prize money")]
        [DataMember(Name = "Currency", Order = 12)]
        public string Currency { get; set; }

        /// <summary>
        /// Indicates if contestant was the winner of the season
        /// </summary>
        [Description("Indicates if contestant was the winner of the season")]
        [DataMember(Name = "Winner", Order = 13)]
        public bool? Winner { get; set; }

    }
}

