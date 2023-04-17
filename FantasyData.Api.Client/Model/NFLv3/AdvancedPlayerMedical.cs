using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerMedical")]
    [Serializable]
    public partial class AdvancedPlayerMedical
    {
        /// <summary>
        /// A unique ID of the medical event associated with the player in question.
        /// </summary>
        [Description("A unique ID of the medical event associated with the player in question.")]
        [DataMember(Name = "AdvancedPlayerMedicalID", Order = 1)]
        public int AdvancedPlayerMedicalID { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.
        /// </summary>
        [Description("The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The NFL season in four-digit year format.
        /// </summary>
        [Description("The NFL season in four-digit year format.")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The week of the season in which the incident took place (e.g. Week 11.)
        /// </summary>
        [Description("The week of the season in which the incident took place (e.g. Week 11.)")]
        [DataMember(Name = "IncidentDate", Order = 5)]
        public string IncidentDate { get; set; }

        /// <summary>
        /// A brief description of the player's injury (e.g. hip contusion).
        /// </summary>
        [Description("A brief description of the player's injury (e.g. hip contusion).")]
        [DataMember(Name = "InjuryDescription", Order = 6)]
        public string InjuryDescription { get; set; }

        /// <summary>
        /// How severe the injury is likely to be - Low, Medium, or High Severity.
        /// </summary>
        [Description("How severe the injury is likely to be - Low, Medium, or High Severity.")]
        [DataMember(Name = "Severity", Order = 7)]
        public string Severity { get; set; }

        /// <summary>
        /// How many games the player has missed due to this injury.
        /// </summary>
        [Description("How many games the player has missed due to this injury.")]
        [DataMember(Name = "GamesMissed", Order = 8)]
        public int? GamesMissed { get; set; }

        /// <summary>
        /// How many times the player has appeared on the weekly NFL Injury Report due to this injury so far.
        /// </summary>
        [Description("How many times the player has appeared on the weekly NFL Injury Report due to this injury so far.")]
        [DataMember(Name = "GamesOnInjuryReport", Order = 9)]
        public int? GamesOnInjuryReport { get; set; }

        /// <summary>
        /// Details about a player's surgery in text format.
        /// </summary>
        [Description("Details about a player's surgery in text format.")]
        [DataMember(Name = "Surgery", Order = 10)]
        public string Surgery { get; set; }

        /// <summary>
        /// A potential recovery timeline for the player, as communicated by the team.
        /// </summary>
        [Description("A potential recovery timeline for the player, as communicated by the team.")]
        [DataMember(Name = "RecoveryTimetable", Order = 11)]
        public string RecoveryTimetable { get; set; }

    }
}

