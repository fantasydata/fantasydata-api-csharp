using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Period")]
    [Serializable]
    public partial class Period
    {
        /// <summary>
        /// The unique ID for the period
        /// </summary>
        [Description("The unique ID for the period")]
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
        /// The name of the period in the game (e.g. 1, 2, OT, OT2, etc.)
        /// </summary>
        [Description("The name of the period in the game (e.g. 1, 2, OT, OT2, etc.)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this period is the first/second half or overtime (possible values: Half, Overtime)
        /// </summary>
        [Description("Indicates whether this period is the first/second half or overtime (possible values: Half, Overtime)")]
        [DataMember(Name = "Type", Order = 5)]
        public string Type { get; set; }

        /// <summary>
        /// The total points scored by the away team in this period only
        /// </summary>
        [Description("The total points scored by the away team in this period only")]
        [DataMember(Name = "AwayScore", Order = 6)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The total points scored by the home team in this period only
        /// </summary>
        [Description("The total points scored by the home team in this period only")]
        [DataMember(Name = "HomeScore", Order = 7)]
        public int? HomeScore { get; set; }

    }
}

