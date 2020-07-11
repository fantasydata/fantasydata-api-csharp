using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CFB
{
    [DataContract(Namespace="", Name="Period")]
    [Serializable]
    public partial class Period
    {
        /// <summary>
        /// Unique identifier for each period.
        /// </summary>
        [Description("Unique identifier for each period.")]
        [DataMember(Name = "PeriodID", Order = 1)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The unique ID for this game.
        /// </summary>
        [Description("The unique ID for this game.")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The Number (Order) of the Period in the scope of the Game.
        /// </summary>
        [Description("The Number (Order) of the Period in the scope of the Game.")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The Name of the Period (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)
        /// </summary>
        [Description("The Name of the Period (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The total points scored by the away team in this Period.
        /// </summary>
        [Description("The total points scored by the away team in this Period.")]
        [DataMember(Name = "AwayScore", Order = 5)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The total points scored by the home team in this Period.
        /// </summary>
        [Description("The total points scored by the home team in this Period.")]
        [DataMember(Name = "HomeScore", Order = 6)]
        public int? HomeScore { get; set; }

    }
}

