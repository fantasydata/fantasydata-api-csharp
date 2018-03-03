using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The NBA regular season for which these totals apply
        /// </summary>
        [Description("The NBA regular season for which these totals apply")]
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
        /// The description of the season for display purposes (possible values include: 2017-18, 2018-19, etc)
        /// </summary>
        [Description("The description of the season for display purposes (possible values include: 2017-18, 2018-19, etc)")]
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
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 7)]
        public string SeasonType { get; set; }

        /// <summary>
        /// The string to pass into subsequent API calls in the season parameter
        /// </summary>
        [Description("The string to pass into subsequent API calls in the season parameter")]
        [DataMember(Name = "ApiSeason", Order = 8)]
        public string ApiSeason { get; set; }

    }
}

