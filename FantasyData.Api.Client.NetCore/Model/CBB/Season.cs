using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The college basketball season of the game
        /// </summary>
        [Description("The college basketball season of the game")]
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
        /// The description of this season for display purposes (e.g. 2017-18, 2018-19, etc)
        /// </summary>
        [Description("The description of this season for display purposes (e.g. 2017-18, 2018-19, etc)")]
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
        /// The string to pass into subsequent API calls in the season parameter
        /// </summary>
        [Description("The string to pass into subsequent API calls in the season parameter")]
        [DataMember(Name = "ApiSeason", Order = 7)]
        public string ApiSeason { get; set; }

    }
}

