using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Transaction")]
    [Serializable]
    public partial class Transaction
    {
        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO tied to this transaction. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO tied to this transaction. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// ID of Player's former team
        /// </summary>
        [Description("ID of Player's former team")]
        [DataMember(Name = "FormerTeamID", Order = 3)]
        public int? FormerTeamID { get; set; }

        /// <summary>
        /// Player's former team abbreviation [Key] (e.g. LAC; PHI; NE; IND etc.)
        /// </summary>
        [Description("Player's former team abbreviation [Key] (e.g. LAC; PHI; NE; IND etc.)")]
        [DataMember(Name = "FormerTeam", Order = 4)]
        public string FormerTeam { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 5)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Type of Transaction. Released, Waived, Signed, Promoted, Elevated, Demoted, and Traded.
        /// </summary>
        [Description("Type of Transaction. Released, Waived, Signed, Promoted, Elevated, Demoted, and Traded.")]
        [DataMember(Name = "Type", Order = 7)]
        public string Type { get; set; }

        /// <summary>
        /// Date & time that the transaction took place (in US Eastern Time)
        /// </summary>
        [Description("Date & time that the transaction took place (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Transaction Summary (e.g. "Harris has signed with the Commanders.")
        /// </summary>
        [Description("Transaction Summary (e.g. \"Harris has signed with the Commanders.\")")]
        [DataMember(Name = "Note", Order = 9)]
        public string Note { get; set; }

        /// <summary>
        /// Date and time of the transaction creation (in US Eastern Time)
        /// </summary>
        [Description("Date and time of the transaction creation (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 10)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Date and time last updated (in US Eastern Time)
        /// </summary>
        [Description("Date and time last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

    }
}

