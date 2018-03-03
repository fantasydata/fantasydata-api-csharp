using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerRound")]
    [Serializable]
    public partial class PlayerRound
    {
        [DataMember(Name = "Number", Order = 1)]
        public int? Number { get; set; }

        [DataMember(Name = "Day", Order = 2)]
        public DateTime Day { get; set; }

        [DataMember(Name = "Par", Order = 3)]
        public int? Par { get; set; }

        [DataMember(Name = "Score", Order = 4)]
        public int? Score { get; set; }

        [DataMember(Name = "BogeyFree", Order = 5)]
        public bool BogeyFree { get; set; }

        [DataMember(Name = "IncludesStreakOfThreeBirdiesOrBetter", Order = 6)]
        public bool IncludesStreakOfThreeBirdiesOrBetter { get; set; }

        [DataMember(Name = "DoubleEagles", Order = 7)]
        public int? DoubleEagles { get; set; }

        [DataMember(Name = "Eagles", Order = 8)]
        public int? Eagles { get; set; }

        [DataMember(Name = "Birdies", Order = 9)]
        public int? Birdies { get; set; }

        [DataMember(Name = "Pars", Order = 10)]
        public int? Pars { get; set; }

        [DataMember(Name = "Bogeys", Order = 11)]
        public int? Bogeys { get; set; }

        [DataMember(Name = "DoubleBogeys", Order = 12)]
        public int? DoubleBogeys { get; set; }

        [DataMember(Name = "WorseThanDoubleBogey", Order = 13)]
        public int? WorseThanDoubleBogey { get; set; }

        [DataMember(Name = "HoleInOnes", Order = 14)]
        public int? HoleInOnes { get; set; }

        [DataMember(Name = "TripleBogeys", Order = 15)]
        public int? TripleBogeys { get; set; }

        [DataMember(Name = "WorseThanTripleBogey", Order = 16)]
        public int? WorseThanTripleBogey { get; set; }

        [DataMember(Name = "Holes", Order = 20017)]
        public PlayerHole[] Holes { get; set; }

        [DataMember(Name = "LongestBirdieOrBetterStreak", Order = 18)]
        public decimal? LongestBirdieOrBetterStreak { get; set; }

        [DataMember(Name = "ConsecutiveBirdieOrBetterCount", Order = 19)]
        public decimal? ConsecutiveBirdieOrBetterCount { get; set; }

        [DataMember(Name = "BounceBackCount", Order = 20)]
        public decimal? BounceBackCount { get; set; }

        [DataMember(Name = "IncludesStreakOfFourBirdiesOrBetter", Order = 21)]
        public bool IncludesStreakOfFourBirdiesOrBetter { get; set; }

        [DataMember(Name = "IncludesStreakOfFiveBirdiesOrBetter", Order = 22)]
        public bool IncludesStreakOfFiveBirdiesOrBetter { get; set; }

        [DataMember(Name = "IncludesFiveOrMoreBirdiesOrBetter", Order = 23)]
        public bool IncludesFiveOrMoreBirdiesOrBetter { get; set; }

    }
}

