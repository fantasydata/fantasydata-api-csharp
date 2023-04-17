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
        /// Unique ID of Season
        /// </summary>
        [Description("Unique ID of Season")]
        [DataMember(Name = "SeasonId", Order = 1)]
        public int SeasonId { get; set; }

        /// <summary>
        /// ID of associated Competition.
        /// </summary>
        [Description("ID of associated Competition.")]
        [DataMember(Name = "CompetitionId", Order = 2)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// Year in which Season takes place.
        /// </summary>
        [Description("Year in which Season takes place.")]
        [DataMember(Name = "Year", Order = 3)]
        public int Year { get; set; }

        /// <summary>
        /// Name of Season.
        /// </summary>
        [Description("Name of Season.")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Name of Competition
        /// </summary>
        [Description("Name of Competition")]
        [DataMember(Name = "CompetitionName", Order = 5)]
        public string CompetitionName { get; set; }

        /// <summary>
        /// Type of Surface (eg. Clay, Grass, Hard)
        /// </summary>
        [Description("Type of Surface (eg. Clay, Grass, Hard)")]
        [DataMember(Name = "Surface", Order = 6)]
        public string Surface { get; set; }

        /// <summary>
        /// Start Date of Season.  Day on which matches begin.
        /// </summary>
        [Description("Start Date of Season.  Day on which matches begin.")]
        [DataMember(Name = "StartDate", Order = 7)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date of Season.  Last day of matches.
        /// </summary>
        [Description("End Date of Season.  Last day of matches.")]
        [DataMember(Name = "EndDate", Order = 8)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Status of Tournament (Eg. Scheduled, InProgress, Final)
        /// </summary>
        [Description("Status of Tournament (Eg. Scheduled, InProgress, Final)")]
        [DataMember(Name = "Status", Order = 9)]
        public string Status { get; set; }

        /// <summary>
        /// ID of associated ATP Tour Season.
        /// </summary>
        [Description("ID of associated ATP Tour Season.")]
        [DataMember(Name = "ATPTourSeasonId", Order = 10)]
        public int? ATPTourSeasonId { get; set; }

        /// <summary>
        /// ID of associated WTA Tour Season.
        /// </summary>
        [Description("ID of associated WTA Tour Season.")]
        [DataMember(Name = "WTATourSeasonId", Order = 11)]
        public int? WTATourSeasonId { get; set; }

        /// <summary>
        /// Contestant info on the Mens Singles Winner, if applicable.
        /// </summary>
        [Description("Contestant info on the Mens Singles Winner, if applicable.")]
        [DataMember(Name = "MensSinglesWinnerContestantDetails", Order = 10012)]
        public Contestant MensSinglesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Womens Singles Winner, if applicable.
        /// </summary>
        [Description("Contestant info on the Womens Singles Winner, if applicable.")]
        [DataMember(Name = "WomensSinglesWinnerContestantDetails", Order = 10013)]
        public Contestant WomensSinglesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Mens Doubles Winner, if applicable.
        /// </summary>
        [Description("Contestant info on the Mens Doubles Winner, if applicable.")]
        [DataMember(Name = "MensDoublesWinnerContestantDetails", Order = 10014)]
        public Contestant MensDoublesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Womens Doubles Winner, if applicable.
        /// </summary>
        [Description("Contestant info on the Womens Doubles Winner, if applicable.")]
        [DataMember(Name = "WomensDoublesWinnerContestantDetails", Order = 10015)]
        public Contestant WomensDoublesWinnerContestantDetails { get; set; }

        /// <summary>
        /// Contestant info on the Mixed Doubles Winner, if applicable.
        /// </summary>
        [Description("Contestant info on the Mixed Doubles Winner, if applicable.")]
        [DataMember(Name = "MixedDoublesWinnerContestantDetails", Order = 10016)]
        public Contestant MixedDoublesWinnerContestantDetails { get; set; }

    }
}

