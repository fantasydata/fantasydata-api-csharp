using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceBasic")]
    [Serializable]
    public partial class RaceBasic
    {
        /// <summary>
        /// The unique ID of this race
        /// </summary>
        [Description("The unique ID of this race")]
        [DataMember(Name = "RaceID", Order = 1)]
        public int RaceID { get; set; }

        /// <summary>
        /// The day of this race
        /// </summary>
        [Description("The day of this race")]
        [DataMember(Name = "Day", Order = 2)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The date/time of this race
        /// </summary>
        [Description("The date/time of this race")]
        [DataMember(Name = "DateTime", Order = 3)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The date/time when this race was last updated
        /// </summary>
        [Description("The date/time when this race was last updated")]
        [DataMember(Name = "Updated", Order = 4)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date/time when this race was created
        /// </summary>
        [Description("The date/time when this race was created")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime? Created { get; set; }

    }
}

