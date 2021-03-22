using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Season")]
    [Serializable]
    public partial class Season
    {
        /// <summary>
        /// The year of the season usable in the API
        /// </summary>
        [Description("The year of the season usable in the API")]
        [DataMember(Name = "SeasonID", Order = 1)]
        public int SeasonID { get; set; }

        /// <summary>
        /// The calendar years spanned by this season
        /// </summary>
        [Description("The calendar years spanned by this season")]
        [DataMember(Name = "Description", Order = 2)]
        public string Description { get; set; }

        /// <summary>
        /// The start date of the season
        /// </summary>
        [Description("The start date of the season")]
        [DataMember(Name = "StartDate", Order = 3)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the season
        /// </summary>
        [Description("The end date of the season")]
        [DataMember(Name = "EndDate", Order = 4)]
        public DateTime EndDate { get; set; }

    }
}

