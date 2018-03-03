using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Injury")]
    [Serializable]
    public partial class Injury
    {
        [DataMember(Name = "InjuryID", Order = 1)]
        public int InjuryID { get; set; }

        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        [DataMember(Name = "Active", Order = 4)]
        public bool Active { get; set; }

        [DataMember(Name = "StartDate", Order = 5)]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        [DataMember(Name = "BodyPart", Order = 7)]
        public string BodyPart { get; set; }

        [DataMember(Name = "ExpectedReturn", Order = 8)]
        public string ExpectedReturn { get; set; }

    }
}

