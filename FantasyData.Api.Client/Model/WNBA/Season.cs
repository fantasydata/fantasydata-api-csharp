using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The WNBA regular season for which these totals apply
        /// </summary>
        [Description("The WNBA regular season for which these totals apply")]
        [DataMember(Name = "Year", Order = 1)]
        public int Year { get; set; }

        /// <summary>
        /// The year in which the season started
        /// </summary>
        [Description("The year in which the season started")]
        [DataMember(Name = "PreseasonStartDate", Order = 2)]
        public DateTime PreseasonStartDate { get; set; }

        /// <summary>
        /// The start date of the regular season
        /// </summary>
        [Description("The start date of the regular season")]
        [DataMember(Name = "RegularSeasonStartDate", Order = 3)]
        public DateTime? RegularSeasonStartDate { get; set; }

        /// <summary>
        /// The start date of the postseason
        /// </summary>
        [Description("The start date of the postseason")]
        [DataMember(Name = "PostSeasonStartDate", Order = 4)]
        public DateTime? PostSeasonStartDate { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "CurrentSeasonType", Order = 5)]
        public string CurrentSeasonType { get; set; }

        /// <summary>
        /// The string to pass into subsequent API calls in the season parameter
        /// </summary>
        [Description("The string to pass into subsequent API calls in the season parameter")]
        [DataMember(Name = "ApiSeason", Order = 6)]
        public string ApiSeason { get; set; }

    }
}

