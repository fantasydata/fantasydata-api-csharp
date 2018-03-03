using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerHole")]
    [Serializable]
    public partial class PlayerHole
    {
        [DataMember(Name = "Number", Order = 1)]
        public int? Number { get; set; }

        [DataMember(Name = "Par", Order = 2)]
        public int? Par { get; set; }

        [DataMember(Name = "Score", Order = 3)]
        public int? Score { get; set; }

        [DataMember(Name = "ToPar", Order = 4)]
        public int? ToPar { get; set; }

        [DataMember(Name = "HoleInOne", Order = 5)]
        public bool HoleInOne { get; set; }

        [DataMember(Name = "DoubleEagle", Order = 6)]
        public bool DoubleEagle { get; set; }

        [DataMember(Name = "Eagle", Order = 7)]
        public bool Eagle { get; set; }

        [DataMember(Name = "Birdie", Order = 8)]
        public bool Birdie { get; set; }

        [DataMember(Name = "IsPar", Order = 9)]
        public bool IsPar { get; set; }

        [DataMember(Name = "Bogey", Order = 10)]
        public bool Bogey { get; set; }

        [DataMember(Name = "DoubleBogey", Order = 11)]
        public bool DoubleBogey { get; set; }

        [DataMember(Name = "WorseThanDoubleBogey", Order = 12)]
        public bool WorseThanDoubleBogey { get; set; }

    }
}

