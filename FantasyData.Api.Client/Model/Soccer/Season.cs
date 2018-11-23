using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The unique ID of the season
        /// </summary>
        [Description("The unique ID of the season")]
        [DataMember(Name = "SeasonId", Order = 1)]
        public int SeasonId { get; set; }

        /// <summary>
        /// The unique ID of the competition
        /// </summary>
        [Description("The unique ID of the competition")]
        [DataMember(Name = "CompetitionId", Order = 2)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// The soccer regular season for which these totals apply
        /// </summary>
        [Description("The soccer regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 3)]
        public int Year { get; set; }

        /// <summary>
        /// The display name of the season (example: 2017/2018, 2018-19, etc)
        /// </summary>
        [Description("The display name of the season (example: 2017/2018, 2018-19, etc)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The display name of the competition associated with this season
        /// </summary>
        [Description("The display name of the competition associated with this season")]
        [DataMember(Name = "CompetitionName", Order = 5)]
        public string CompetitionName { get; set; }

        /// <summary>
        /// The start date of the season (UTC)
        /// </summary>
        [Description("The start date of the season (UTC)")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the season (UTC)
        /// </summary>
        [Description("The end date of the season (UTC)")]
        [DataMember(Name = "EndDate", Order = 7)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates whether or not this season is the current season of the competition
        /// </summary>
        [Description("Indicates whether or not this season is the current season of the competition")]
        [DataMember(Name = "CurrentSeason", Order = 8)]
        public bool CurrentSeason { get; set; }

        /// <summary>
        /// The rounds associated with this season
        /// </summary>
        [Description("The rounds associated with this season")]
        [DataMember(Name = "Rounds", Order = 20009)]
        public Round[] Rounds { get; set; }

    }
}

