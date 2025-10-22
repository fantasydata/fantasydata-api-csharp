using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The MLB season for which these totals apply
        /// </summary>
        [Description("The MLB season for which these totals apply")]
        [DataMember(Name = "Season", Order = 1)]
        public int Year { get; set; }

        /// <summary>
        /// The start date of the regular season
        /// </summary>
        [Description("The start date of the regular season")]
        [DataMember(Name = "RegularSeasonStartDate", Order = 2)]
        public DateTime? RegularSeasonStartDate { get; set; }

        /// <summary>
        /// The start date of the postseason
        /// </summary>
        [Description("The start date of the postseason")]
        [DataMember(Name = "PostSeasonStartDate", Order = 3)]
        public DateTime? PostSeasonStartDate { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public string SeasonType { get; set; }

        /// <summary>
        /// The string to pass into subsequent API calls in the season parameter (e.g. 2025REG, 2025POST, etc.).
        /// </summary>
        [Description("The string to pass into subsequent API calls in the season parameter (e.g. 2025REG, 2025POST, etc.).")]
        [DataMember(Name = "ApiSeason", Order = 5)]
        public string ApiSeason { get; set; }

    }
}

