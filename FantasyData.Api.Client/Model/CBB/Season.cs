using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The season that the game occurs in. Note: season is a single year that the majority of the season occurs in
        /// </summary>
        [Description("The season that the game occurs in. Note: season is a single year that the majority of the season occurs in")]
        [DataMember(Name = "Season", Order = 1)]
        public int Year { get; set; }

        /// <summary>
        /// The year in which the season started
        /// </summary>
        [Description("The year in which the season started")]
        [DataMember(Name = "StartYear", Order = 2)]
        public int StartYear { get; set; }

        /// <summary>
        /// The year in which the season ended
        /// </summary>
        [Description("The year in which the season ended")]
        [DataMember(Name = "EndYear", Order = 3)]
        public int EndYear { get; set; }

        /// <summary>
        /// The description of this season for display purposes (e.g. 2024-25; 2025-26; etc)
        /// </summary>
        [Description("The description of this season for display purposes (e.g. 2024-25; 2025-26; etc)")]
        [DataMember(Name = "Description", Order = 4)]
        public string Description { get; set; }

        /// <summary>
        /// The start date of the regular season
        /// </summary>
        [Description("The start date of the regular season")]
        [DataMember(Name = "RegularSeasonStartDate", Order = 5)]
        public DateTime? RegularSeasonStartDate { get; set; }

        /// <summary>
        /// The start date of the postseason
        /// </summary>
        [Description("The start date of the postseason")]
        [DataMember(Name = "PostSeasonStartDate", Order = 6)]
        public DateTime? PostSeasonStartDate { get; set; }

        /// <summary>
        /// The string to pass into subsequent API calls in the season parameter (e.g. 2025REG, 2025POST, etc.)
        /// </summary>
        [Description("The string to pass into subsequent API calls in the season parameter (e.g. 2025REG, 2025POST, etc.)")]
        [DataMember(Name = "ApiSeason", Order = 7)]
        public string ApiSeason { get; set; }

    }
}

