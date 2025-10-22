﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Quarter")]
    [Serializable]
    public partial class Quarter
    {
        /// <summary>
        /// The unique ID of the quarter
        /// </summary>
        [Description("The unique ID of the quarter")]
        [DataMember(Name = "QuarterID", Order = 1)]
        public int QuarterID { get; set; }

        /// <summary>
        /// The unique ID of the score this quarter belongs to
        /// </summary>
        [Description("The unique ID of the score this quarter belongs to")]
        [DataMember(Name = "ScoreID", Order = 2)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The Number (Order) of the Quarter in the scope of the Game.
        /// </summary>
        [Description("The Number (Order) of the Quarter in the scope of the Game.")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)
        /// </summary>
        [Description("The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The long description of the quarter
        /// </summary>
        [Description("The long description of the quarter")]
        [DataMember(Name = "Description", Order = 5)]
        public string Description { get; set; }

        /// <summary>
        /// The total points scored by the away team in this Quarter.
        /// </summary>
        [Description("The total points scored by the away team in this Quarter.")]
        [DataMember(Name = "AwayTeamScore", Order = 6)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The total points scored by the home team in this Quarter.
        /// </summary>
        [Description("The total points scored by the home team in this Quarter.")]
        [DataMember(Name = "HomeTeamScore", Order = 7)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Quarter was last updated (in US Eastern time)
        /// </summary>
        [Description("The database generated timestamp of when this Quarter was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The database generated timestamp of when this Quarter was first created (in US Eastern Time)
        /// </summary>
        [Description("The database generated timestamp of when this Quarter was first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 9)]
        public DateTime? Created { get; set; }

    }
}

