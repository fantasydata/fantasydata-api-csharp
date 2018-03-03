using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The NCAA football season
        /// </summary>
        [Description("The NCAA football season")]
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
        /// The description of this season for display purposes
        /// </summary>
        [Description("The description of this season for display purposes")]
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

    }
}

