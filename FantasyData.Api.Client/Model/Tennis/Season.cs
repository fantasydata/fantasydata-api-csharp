using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
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
        /// The ID of the associated competition
        /// </summary>
        [Description("The ID of the associated competition")]
        [DataMember(Name = "CompetitionId", Order = 2)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// The year in which the season takes place
        /// </summary>
        [Description("The year in which the season takes place")]
        [DataMember(Name = "Year", Order = 3)]
        public int Year { get; set; }

        /// <summary>
        /// The name of the season
        /// </summary>
        [Description("The name of the season")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the competition
        /// </summary>
        [Description("The name of the competition")]
        [DataMember(Name = "CompetitionName", Order = 5)]
        public string CompetitionName { get; set; }

        /// <summary>
        /// Type of playing surface (e.g. Clay; Grass; Hard)
        /// </summary>
        [Description("Type of playing surface (e.g. Clay; Grass; Hard)")]
        [DataMember(Name = "Surface", Order = 6)]
        public string Surface { get; set; }

        /// <summary>
        /// Start date of season (first day of matches)
        /// </summary>
        [Description("Start date of season (first day of matches)")]
        [DataMember(Name = "StartDate", Order = 7)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of season (last day of matches)
        /// </summary>
        [Description("End date of season (last day of matches)")]
        [DataMember(Name = "EndDate", Order = 8)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Status of Tournament (Eg. Scheduled, InProgress, Final)
        /// </summary>
        [Description("Status of Tournament (Eg. Scheduled, InProgress, Final)")]
        [DataMember(Name = "Status", Order = 9)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the associated ATP Tour Season
        /// </summary>
        [Description("The ID of the associated ATP Tour Season")]
        [DataMember(Name = "ATPTourSeasonId", Order = 10)]
        public int? ATPTourSeasonId { get; set; }

        /// <summary>
        /// The ID of associated WTA Tour season
        /// </summary>
        [Description("The ID of associated WTA Tour season")]
        [DataMember(Name = "WTATourSeasonId", Order = 11)]
        public int? WTATourSeasonId { get; set; }

        /// <summary>
        /// Contestant info on the Mens Singles Winner (if applicable)
        /// </summary>
        [Description("Contestant info on the Mens Singles Winner (if applicable)")]
        [DataMember(Name = "MensSinglesWinnerContestantDetails", Order = 10012)]
        public Contestant MensSinglesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Womens Singles Winner (if applicable)
        /// </summary>
        [Description("Contestant info on the Womens Singles Winner (if applicable)")]
        [DataMember(Name = "WomensSinglesWinnerContestantDetails", Order = 10013)]
        public Contestant WomensSinglesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Mens Doubles Winner (if applicable)
        /// </summary>
        [Description("Contestant info on the Mens Doubles Winner (if applicable)")]
        [DataMember(Name = "MensDoublesWinnerContestantDetails", Order = 10014)]
        public Contestant MensDoublesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Womens Doubles Winner (if applicable)
        /// </summary>
        [Description("Contestant info on the Womens Doubles Winner (if applicable)")]
        [DataMember(Name = "WomensDoublesWinnerContestantDetails", Order = 10015)]
        public Contestant WomensDoublesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Mixed Doubles Winner (if applicable)
        /// </summary>
        [Description("Contestant info on the Mixed Doubles Winner (if applicable)")]
        [DataMember(Name = "MixedDoublesWinnerContestantDetails", Order = 10016)]
        public Contestant MixedDoublesWinnerContestantDetails { get; set; }

    }
}

