using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
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
        /// The unique ID of the season this round is associated with
        /// </summary>
        [Description("The unique ID of the season this round is associated with")]
        [DataMember(Name = "SeasonId", Order = 2)]
        public int SeasonId { get; set; }

        /// <summary>
        /// The soccer season for which these totals apply
        /// </summary>
        [Description("The soccer season for which these totals apply")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The display name of the round (examples: Regular Season, Semi-finals, Final, etc)
        /// </summary>
        [Description("The display name of the round (examples: Regular Season, Semi-finals, Final, etc)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The type of this round. Possible values include: Cup, Table
        /// </summary>
        [Description("The type of this round. Possible values include: Cup, Table")]
        [DataMember(Name = "Type", Order = 6)]
        public string Type { get; set; }

        /// <summary>
        /// The start date of the round (UTC)
        /// </summary>
        [Description("The start date of the round (UTC)")]
        [DataMember(Name = "StartDate", Order = 7)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the round (UTC)
        /// </summary>
        [Description("The end date of the round (UTC)")]
        [DataMember(Name = "EndDate", Order = 8)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The current week that this round is in
        /// </summary>
        [Description("The current week that this round is in")]
        [DataMember(Name = "CurrentWeek", Order = 9)]
        public int? CurrentWeek { get; set; }

        /// <summary>
        /// Indicates whether or not this round is the current round of the competition/season
        /// </summary>
        [Description("Indicates whether or not this round is the current round of the competition/season")]
        [DataMember(Name = "CurrentRound", Order = 10)]
        public bool CurrentRound { get; set; }

    }
}

