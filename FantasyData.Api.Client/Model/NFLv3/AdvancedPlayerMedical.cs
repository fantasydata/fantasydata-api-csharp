using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerMedical")]
    [Serializable]
    public partial class AdvancedPlayerMedical
    {
        [DataMember(Name = "AdvancedPlayerMedicalID", Order = 1)]
        public int AdvancedPlayerMedicalID { get; set; }

        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        [DataMember(Name = "IncidentDate", Order = 5)]
        public string IncidentDate { get; set; }

        [DataMember(Name = "InjuryDescription", Order = 6)]
        public string InjuryDescription { get; set; }

        [DataMember(Name = "Severity", Order = 7)]
        public string Severity { get; set; }

        [DataMember(Name = "GamesMissed", Order = 8)]
        public int? GamesMissed { get; set; }

        [DataMember(Name = "GamesOnInjuryReport", Order = 9)]
        public int? GamesOnInjuryReport { get; set; }

        [DataMember(Name = "Surgery", Order = 10)]
        public string Surgery { get; set; }

        [DataMember(Name = "RecoveryTimetable", Order = 11)]
        public string RecoveryTimetable { get; set; }

    }
}

