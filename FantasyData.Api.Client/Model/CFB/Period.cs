using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Period")]
    [Serializable]
    public partial class Period
    {
        /// <summary>
        /// Unique ID for each period
        /// </summary>
        [Description("Unique ID for each period")]
        [DataMember(Name = "PeriodID", Order = 1)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The Number (Order) of the Period in the scope of the Game.
        /// </summary>
        [Description("The Number (Order) of the Period in the scope of the Game.")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the period (possible values: 1; 2; 3; 4; OT; Final, F/OT)
        /// </summary>
        [Description("The name of the period (possible values: 1; 2; 3; 4; OT; Final, F/OT)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The total points scored by the away team in this period
        /// </summary>
        [Description("The total points scored by the away team in this period")]
        [DataMember(Name = "AwayScore", Order = 5)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The total points scored by the home team in this period
        /// </summary>
        [Description("The total points scored by the home team in this period")]
        [DataMember(Name = "HomeScore", Order = 6)]
        public int? HomeScore { get; set; }

    }
}

