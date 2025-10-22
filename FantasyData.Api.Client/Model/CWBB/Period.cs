﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CWBB
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
        /// The unique ID of the game relating to this period
        /// </summary>
        [Description("The unique ID of the game relating to this period")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The number (order) of the period within the scope of the game
        /// </summary>
        [Description("The number (order) of the period within the scope of the game")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)
        /// </summary>
        [Description("The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether this period is a regulation quarter or overtime (possible values: Quarter, Overtime)
        /// </summary>
        [Description("Indicates whether this period is a regulation quarter or overtime (possible values: Quarter, Overtime)")]
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

