﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="CompetitionDetail")]
    [Serializable]
    public partial class CompetitionDetail
    {
        /// <summary>
        /// The current active season for this competition/league
        /// </summary>
        [Description("The current active season for this competition/league")]
        [DataMember(Name = "CurrentSeason", Order = 10001)]
        public Season CurrentSeason { get; set; }

        /// <summary>
        /// The list of active teams associated with this competition
        /// </summary>
        [Description("The list of active teams associated with this competition")]
        [DataMember(Name = "Teams", Order = 20002)]
        public TeamDetail[] Teams { get; set; }

        /// <summary>
        /// The complete schedule for the current season of this competition/league
        /// </summary>
        [Description("The complete schedule for the current season of this competition/league")]
        [DataMember(Name = "Games", Order = 20003)]
        public Game[] Games { get; set; }

        /// <summary>
        /// The unique ID of the competition/league
        /// </summary>
        [Description("The unique ID of the competition/league")]
        [DataMember(Name = "CompetitionId", Order = 4)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// The unique ID of the area where this competition/league is played
        /// </summary>
        [Description("The unique ID of the area where this competition/league is played")]
        [DataMember(Name = "AreaId", Order = 5)]
        public int AreaId { get; set; }

        /// <summary>
        /// The display name of the area where this competition/league is played
        /// </summary>
        [Description("The display name of the area where this competition/league is played")]
        [DataMember(Name = "AreaName", Order = 6)]
        public string AreaName { get; set; }

        /// <summary>
        /// The display name of the competition/league
        /// </summary>
        [Description("The display name of the competition/league")]
        [DataMember(Name = "Name", Order = 7)]
        public string Name { get; set; }

        /// <summary>
        /// The gender of the players on the team Possible Values: Male; Female
        /// </summary>
        [Description("The gender of the players on the team Possible Values: Male; Female")]
        [DataMember(Name = "Gender", Order = 8)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this competition/league Possible values: Club; International
        /// </summary>
        [Description("The type of this competition/league Possible values: Club; International")]
        [DataMember(Name = "Type", Order = 9)]
        public string Type { get; set; }

        /// <summary>
        /// The format of the competition/league.  Possible values: Domestic League; International Cup
        /// </summary>
        [Description("The format of the competition/league.  Possible values: Domestic League; International Cup")]
        [DataMember(Name = "Format", Order = 10)]
        public string Format { get; set; }

        /// <summary>
        /// The seasons associated with this competition/league
        /// </summary>
        [Description("The seasons associated with this competition/league")]
        [DataMember(Name = "Seasons", Order = 20011)]
        public Season[] Seasons { get; set; }

        /// <summary>
        /// The unique string key of the competition/league
        /// </summary>
        [Description("The unique string key of the competition/league")]
        [DataMember(Name = "Key", Order = 12)]
        public string Key { get; set; }

    }
}

