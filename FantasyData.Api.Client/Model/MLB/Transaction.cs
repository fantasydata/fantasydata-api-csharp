using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Transaction")]
    [Serializable]
    public partial class Transaction
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// TeamID of player's former team
        /// </summary>
        [Description("TeamID of player's former team")]
        [DataMember(Name = "FormerTeamID", Order = 3)]
        public int? FormerTeamID { get; set; }

        /// <summary>
        /// Player's former team in abbreviated format [Key] (e.g. SD; PHI; LAD; ATL etc.)
        /// </summary>
        [Description("Player's former team in abbreviated format [Key] (e.g. SD; PHI; LAD; ATL etc.)")]
        [DataMember(Name = "FormerTeam", Order = 4)]
        public string FormerTeam { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
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
        /// The date that this transaction took place
        /// </summary>
        [Description("The date that this transaction took place")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// A summary of the transaction (e.g. "Harris has signed with the Diamondbacks.")
        /// </summary>
        [Description("A summary of the transaction (e.g. \"Harris has signed with the Diamondbacks.\")")]
        [DataMember(Name = "Note", Order = 9)]
        public string Note { get; set; }

        /// <summary>
        /// The date and time this transaction was created in US Eastern Time
        /// </summary>
        [Description("The date and time this transaction was created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 10)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date and time of the last update made to this transaction (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the last update made to this transaction (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

    }
}

