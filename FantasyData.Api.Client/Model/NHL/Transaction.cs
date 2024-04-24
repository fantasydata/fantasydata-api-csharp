using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Transaction")]
    [Serializable]
    public partial class Transaction
    {
        /// <summary>
        /// Unique ID of Player
        /// </summary>
        [Description("Unique ID of Player")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player Name
        /// </summary>
        [Description("Player Name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// ID of Player's former team
        /// </summary>
        [Description("ID of Player's former team")]
        [DataMember(Name = "FormerTeamID", Order = 3)]
        public int? FormerTeamID { get; set; }

        /// <summary>
        /// Player's former team in abbreviated format (e.g. SD, PHI, NE, IND etc.)
        /// </summary>
        [Description("Player's former team in abbreviated format (e.g. SD, PHI, NE, IND etc.)")]
        [DataMember(Name = "FormerTeam", Order = 4)]
        public string FormerTeam { get; set; }

        /// <summary>
        /// Unique ID of the former team
        /// </summary>
        [Description("Unique ID of the former team")]
        [DataMember(Name = "TeamID", Order = 5)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Player's new team, when applicable, in abbreviated format (e.g. SD, PHI, NE, IND etc.)
        /// </summary>
        [Description("Player's new team, when applicable, in abbreviated format (e.g. SD, PHI, NE, IND etc.)")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Type of Transaction. Released, Waived, Signed, Promoted, Elevated, Demoted, and Traded.
        /// </summary>
        [Description("Type of Transaction. Released, Waived, Signed, Promoted, Elevated, Demoted, and Traded.")]
        [DataMember(Name = "Type", Order = 7)]
        public string Type { get; set; }

        /// <summary>
        /// Date and Time Transaction took place
        /// </summary>
        [Description("Date and Time Transaction took place")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Transaction Summary (e.g. "Harris has signed with the Commanders.")
        /// </summary>
        [Description("Transaction Summary (e.g. \"Harris has signed with the Commanders.\")")]
        [DataMember(Name = "Note", Order = 9)]
        public string Note { get; set; }

        /// <summary>
        /// Date and Time Created
        /// </summary>
        [Description("Date and Time Created")]
        [DataMember(Name = "Created", Order = 10)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Date and Time Last Updated
        /// </summary>
        [Description("Date and Time Last Updated")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

    }
}

