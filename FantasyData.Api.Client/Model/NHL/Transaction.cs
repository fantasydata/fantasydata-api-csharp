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
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the player's former team
        /// </summary>
        [Description("The ID of the player's former team")]
        [DataMember(Name = "FormerTeamID", Order = 3)]
        public int? FormerTeamID { get; set; }

        /// <summary>
        /// The [Key] of the player's former team (e.g. BOS; PHI; DET; EDM, etc.)
        /// </summary>
        [Description("The [Key] of the player's former team (e.g. BOS; PHI; DET; EDM, etc.)")]
        [DataMember(Name = "FormerTeam", Order = 4)]
        public string FormerTeam { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 5)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team involved in the transaction
        /// </summary>
        [Description("The abbreviation [Key] of the team involved in the transaction")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// Type of transaction that occurred
        /// </summary>
        [Description("Type of transaction that occurred")]
        [DataMember(Name = "Type", Order = 7)]
        public string Type { get; set; }

        /// <summary>
        /// The date this transaction was created
        /// </summary>
        [Description("The date this transaction was created")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// A summary of the transaction that occurred (e.g. "Harris has signed with the Canucks.")
        /// </summary>
        [Description("A summary of the transaction that occurred (e.g. \"Harris has signed with the Canucks.\")")]
        [DataMember(Name = "Note", Order = 9)]
        public string Note { get; set; }

        /// <summary>
        /// The date and time this transaction was created
        /// </summary>
        [Description("The date and time this transaction was created")]
        [DataMember(Name = "Created", Order = 10)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date and time this transaction was last updated (in US Eastern Time)
        /// </summary>
        [Description("The date and time this transaction was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

    }
}

