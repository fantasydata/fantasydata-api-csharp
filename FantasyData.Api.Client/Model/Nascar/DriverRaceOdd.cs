using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverRaceOdd")]
    [Serializable]
    public partial class DriverRaceOdd
    {
        /// <summary>
        /// Unique Id of the DriverRaceOdd record.
        /// </summary>
        [Description("Unique Id of the DriverRaceOdd record.")]
        [DataMember(Name = "DriverRaceOddID", Order = 1)]
        public int DriverRaceOddID { get; set; }

        /// <summary>
        /// The Id of the Sportsbook associated with this record.
        /// </summary>
        [Description("The Id of the Sportsbook associated with this record.")]
        [DataMember(Name = "SportsbookID", Order = 2)]
        public int? SportsbookID { get; set; }

        /// <summary>
        /// The name of the Sportbook.
        /// </summary>
        [Description("The name of the Sportbook.")]
        [DataMember(Name = "SportsbookName", Order = 3)]
        public string SportsbookName { get; set; }

        /// <summary>
        /// The name of the driver.
        /// </summary>
        [Description("The name of the driver.")]
        [DataMember(Name = "DriverName", Order = 4)]
        public string DriverName { get; set; }

        /// <summary>
        /// The Id of the Driver associated with this record.
        /// </summary>
        [Description("The Id of the Driver associated with this record.")]
        [DataMember(Name = "DriverID", Order = 5)]
        public int? DriverID { get; set; }

        /// <summary>
        /// The odds for this record, in American format i.e. +800, -200, etc.
        /// </summary>
        [Description("The odds for this record, in American format i.e. +800, -200, etc.")]
        [DataMember(Name = "OddsToWin", Order = 6)]
        public int OddsToWin { get; set; }

        /// <summary>
        /// The date and time when this record was created.
        /// </summary>
        [Description("The date and time when this record was created.")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time when this record was last seen from the sportsbook.
        /// </summary>
        [Description("The date and time when this record was last seen from the sportsbook.")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Indicates whether the odd is available for wagering at the related Sportsbook (excludes Consensus).
        /// </summary>
        [Description("Indicates whether the odd is available for wagering at the related Sportsbook (excludes Consensus).")]
        [DataMember(Name = "IsAvailable", Order = 9)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 10)]
        public string SportsbookUrl { get; set; }

    }
}

