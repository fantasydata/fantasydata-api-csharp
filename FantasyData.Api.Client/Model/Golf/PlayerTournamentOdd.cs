using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerTournamentOdd")]
    [Serializable]
    public partial class PlayerTournamentOdd
    {
        /// <summary>
        /// Unique Id of the PlayerTournamentOdd record.
        /// </summary>
        [Description("Unique Id of the PlayerTournamentOdd record.")]
        [DataMember(Name = "PlayerTournamentOddId", Order = 1)]
        public int PlayerTournamentOddId { get; set; }

        /// <summary>
        /// The Id of the Sportsbook associated with this record.
        /// </summary>
        [Description("The Id of the Sportsbook associated with this record.")]
        [DataMember(Name = "SportsbookId", Order = 2)]
        public int SportsbookId { get; set; }

        /// <summary>
        /// The name of the Sportbook.
        /// </summary>
        [Description("The name of the Sportbook.")]
        [DataMember(Name = "SportbookName", Order = 3)]
        public string SportbookName { get; set; }

        /// <summary>
        /// The name of the golfer.
        /// </summary>
        [Description("The name of the golfer.")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The Id of the Player associated with this record.
        /// </summary>
        [Description("The Id of the Player associated with this record.")]
        [DataMember(Name = "PlayerId", Order = 5)]
        public int PlayerId { get; set; }

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
        /// The date and time when this record was updated.
        /// </summary>
        [Description("The date and time when this record was updated.")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Indicates whether the odd is available for wagering at the related Sportsbook (excludes Consensus).
        /// </summary>
        [Description("Indicates whether the odd is available for wagering at the related Sportsbook (excludes Consensus).")]
        [DataMember(Name = "IsAvailable", Order = 9)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// The market type of the odd (e.g. live, pregame, 1st-half, 2nd-quarter)
        /// </summary>
        [Description("The market type of the odd (e.g. live, pregame, 1st-half, 2nd-quarter)")]
        [DataMember(Name = "OddType", Order = 10)]
        public string OddType { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 11)]
        public string SportsbookUrl { get; set; }

    }
}

