using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayer")]
    [Serializable]
    public partial class AdvancedPlayer
    {
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        [DataMember(Name = "FantasyPosition", Order = 6)]
        public string FantasyPosition { get; set; }

        [DataMember(Name = "PositionGroup", Order = 7)]
        public string PositionGroup { get; set; }

        [DataMember(Name = "BMI", Order = 8)]
        public decimal? BMI { get; set; }

        [DataMember(Name = "BMIRank", Order = 9)]
        public int? BMIRank { get; set; }

        [DataMember(Name = "HandSize", Order = 10)]
        public decimal? HandSize { get; set; }

        [DataMember(Name = "HandSizeRank", Order = 11)]
        public int? HandSizeRank { get; set; }

        [DataMember(Name = "ArmLength", Order = 12)]
        public decimal? ArmLength { get; set; }

        [DataMember(Name = "ArmLengthRank", Order = 13)]
        public int? ArmLengthRank { get; set; }

        [DataMember(Name = "QualityScore", Order = 14)]
        public decimal? QualityScore { get; set; }

        [DataMember(Name = "QualityScoreRank", Order = 15)]
        public int? QualityScoreRank { get; set; }

        [DataMember(Name = "FortyYardDash", Order = 16)]
        public decimal? FortyYardDash { get; set; }

        [DataMember(Name = "FortyYardDashRank", Order = 17)]
        public int? FortyYardDashRank { get; set; }

        [DataMember(Name = "ThreeConeDrill", Order = 18)]
        public decimal? ThreeConeDrill { get; set; }

        [DataMember(Name = "ThreeConeDrillRank", Order = 19)]
        public int? ThreeConeDrillRank { get; set; }

        [DataMember(Name = "TwentyYardShuttle", Order = 20)]
        public decimal? TwentyYardShuttle { get; set; }

        [DataMember(Name = "TwentyYardShuttleRank", Order = 21)]
        public int? TwentyYardShuttleRank { get; set; }

        [DataMember(Name = "AgilityScore", Order = 22)]
        public decimal? AgilityScore { get; set; }

        [DataMember(Name = "AgilityScoreRank", Order = 23)]
        public int? AgilityScoreRank { get; set; }

        [DataMember(Name = "VerticalJump", Order = 24)]
        public decimal? VerticalJump { get; set; }

        [DataMember(Name = "VerticalJumpRank", Order = 25)]
        public int? VerticalJumpRank { get; set; }

        [DataMember(Name = "BroadJump", Order = 26)]
        public decimal? BroadJump { get; set; }

        [DataMember(Name = "BroadJumpRank", Order = 27)]
        public int? BroadJumpRank { get; set; }

        [DataMember(Name = "BurstScore", Order = 28)]
        public decimal? BurstScore { get; set; }

        [DataMember(Name = "BurstScoreRank", Order = 29)]
        public int? BurstScoreRank { get; set; }

        [DataMember(Name = "SPARQx", Order = 30)]
        public decimal? SPARQx { get; set; }

        [DataMember(Name = "SPARQxRank", Order = 31)]
        public int? SPARQxRank { get; set; }

        [DataMember(Name = "AthleticismScore", Order = 32)]
        public decimal? AthleticismScore { get; set; }

        [DataMember(Name = "AthleticismScoreRank", Order = 33)]
        public int? AthleticismScoreRank { get; set; }

        [DataMember(Name = "SpeedScore", Order = 34)]
        public decimal? SpeedScore { get; set; }

        [DataMember(Name = "SpeedScoreRank", Order = 35)]
        public int? SpeedScoreRank { get; set; }

        [DataMember(Name = "ThrowVelocity", Order = 36)]
        public decimal? ThrowVelocity { get; set; }

        [DataMember(Name = "ThrowVelocityRank", Order = 37)]
        public int? ThrowVelocityRank { get; set; }

        [DataMember(Name = "WonderlicScore", Order = 38)]
        public decimal? WonderlicScore { get; set; }

        [DataMember(Name = "WonderlicScoreRank", Order = 39)]
        public int? WonderlicScoreRank { get; set; }

        [DataMember(Name = "HeightAdjustedSpeedScore", Order = 40)]
        public decimal? HeightAdjustedSpeedScore { get; set; }

        [DataMember(Name = "HeightAdjustedSpeedScoreRank", Order = 41)]
        public int? HeightAdjustedSpeedScoreRank { get; set; }

        [DataMember(Name = "CatchRadius", Order = 42)]
        public decimal? CatchRadius { get; set; }

        [DataMember(Name = "CatchRadiusRank", Order = 43)]
        public int? CatchRadiusRank { get; set; }

        [DataMember(Name = "BenchPress", Order = 44)]
        public decimal? BenchPress { get; set; }

        [DataMember(Name = "BenchPressRank", Order = 45)]
        public int? BenchPressRank { get; set; }

        [DataMember(Name = "PlaymakingRadius", Order = 46)]
        public decimal? PlaymakingRadius { get; set; }

        [DataMember(Name = "PlaymakingRadiusRank", Order = 47)]
        public int? PlaymakingRadiusRank { get; set; }

        [DataMember(Name = "HighlightClip", Order = 48)]
        public string HighlightClip { get; set; }

        [DataMember(Name = "MedicalHistory", Order = 20049)]
        public AdvancedPlayerMedical[] MedicalHistory { get; set; }

        [DataMember(Name = "ComparablePlayers", Order = 20050)]
        public PlayerInfo[] ComparablePlayers { get; set; }

        [DataMember(Name = "AdvancedPlayerSeasons", Order = 20051)]
        public AdvancedPlayerSeason[] AdvancedPlayerSeasons { get; set; }

        [DataMember(Name = "AdvancedPlayerGames", Order = 20052)]
        public AdvancedPlayerGame[] AdvancedPlayerGames { get; set; }

    }
}

