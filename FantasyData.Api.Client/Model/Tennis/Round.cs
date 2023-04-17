using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Round")]
    [Serializable]
    public partial class Round
    {
        /// <summary>
        /// Unique ID of Round.
        /// </summary>
        [Description("Unique ID of Round.")]
        [DataMember(Name = "RoundId", Order = 1)]
        public int RoundId { get; set; }

        /// <summary>
        /// ID of associated Season
        /// </summary>
        [Description("ID of associated Season")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// ID of associated Discipline.
        /// </summary>
        [Description("ID of associated Discipline.")]
        [DataMember(Name = "DisciplineId", Order = 3)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// Name of associated Season.
        /// </summary>
        [Description("Name of associated Season.")]
        [DataMember(Name = "SeasonName", Order = 4)]
        public string SeasonName { get; set; }

        /// <summary>
        /// Name of associated Discipline.
        /// </summary>
        [Description("Name of associated Discipline.")]
        [DataMember(Name = "DisciplineType", Order = 5)]
        public string DisciplineType { get; set; }

        /// <summary>
        /// Gender of Round.
        /// </summary>
        [Description("Gender of Round.")]
        [DataMember(Name = "Gender", Order = 6)]
        public string Gender { get; set; }

        /// <summary>
        /// Name of Round (eg. Round of 128, Semi Finals, etc.)
        /// </summary>
        [Description("Name of Round (eg. Round of 128, Semi Finals, etc.)")]
        [DataMember(Name = "Name", Order = 7)]
        public string Name { get; set; }

        /// <summary>
        /// Start Date of Round.
        /// </summary>
        [Description("Start Date of Round.")]
        [DataMember(Name = "StartDate", Order = 8)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date of Round.
        /// </summary>
        [Description("End Date of Round.")]
        [DataMember(Name = "EndDate", Order = 9)]
        public DateTime? EndDate { get; set; }

    }
}

