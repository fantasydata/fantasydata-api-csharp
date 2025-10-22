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
        /// The unique ID of the round
        /// </summary>
        [Description("The unique ID of the round")]
        [DataMember(Name = "RoundId", Order = 1)]
        public int RoundId { get; set; }

        /// <summary>
        /// The unique ID of the season associated with this round
        /// </summary>
        [Description("The unique ID of the season associated with this round")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// The ID of associated discipline
        /// </summary>
        [Description("The ID of associated discipline")]
        [DataMember(Name = "DisciplineId", Order = 3)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// The name of the season associated with this round
        /// </summary>
        [Description("The name of the season associated with this round")]
        [DataMember(Name = "SeasonName", Order = 4)]
        public string SeasonName { get; set; }

        /// <summary>
        /// Name of the associated discipline (Singles; Doubles; Mixed Doubles)
        /// </summary>
        [Description("Name of the associated discipline (Singles; Doubles; Mixed Doubles)")]
        [DataMember(Name = "DisciplineType", Order = 5)]
        public string DisciplineType { get; set; }

        /// <summary>
        /// Gender of players associated with this round
        /// </summary>
        [Description("Gender of players associated with this round")]
        [DataMember(Name = "Gender", Order = 6)]
        public string Gender { get; set; }

        /// <summary>
        /// The name of round (e.g. Round of 128; Semi Finals; etc.)
        /// </summary>
        [Description("The name of round (e.g. Round of 128; Semi Finals; etc.)")]
        [DataMember(Name = "Name", Order = 7)]
        public string Name { get; set; }

        /// <summary>
        /// Start date of round
        /// </summary>
        [Description("Start date of round")]
        [DataMember(Name = "StartDate", Order = 8)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of round (last day of matches)
        /// </summary>
        [Description("End date of round (last day of matches)")]
        [DataMember(Name = "EndDate", Order = 9)]
        public DateTime? EndDate { get; set; }

    }
}

