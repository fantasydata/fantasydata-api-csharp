using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerSeason")]
    [Serializable]
    public partial class PlayerSeason
    {
        [DataMember(Name = "PlayerSeasonID", Order = 1)]
        public int PlayerSeasonID { get; set; }

        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = "WorldGolfRank", Order = 5)]
        public int? WorldGolfRank { get; set; }

        [DataMember(Name = "WorldGolfRankLastWeek", Order = 6)]
        public int? WorldGolfRankLastWeek { get; set; }

        [DataMember(Name = "Events", Order = 7)]
        public int? Events { get; set; }

        [DataMember(Name = "AveragePoints", Order = 8)]
        public decimal? AveragePoints { get; set; }

        [DataMember(Name = "TotalPoints", Order = 9)]
        public decimal? TotalPoints { get; set; }

        [DataMember(Name = "PointsLost", Order = 10)]
        public decimal? PointsLost { get; set; }

        [DataMember(Name = "PointsGained", Order = 11)]
        public decimal? PointsGained { get; set; }

    }
}

