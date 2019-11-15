using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerGame")]
    [Serializable]
    public partial class AdvancedPlayerGame
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

        [DataMember(Name = "Season", Order = 8)]
        public int Season { get; set; }

        [DataMember(Name = "SeasonType", Order = 9)]
        public int SeasonType { get; set; }

        [DataMember(Name = "Week", Order = 10)]
        public int Week { get; set; }

        [DataMember(Name = "Opponent", Order = 11)]
        public string Opponent { get; set; }

        [DataMember(Name = "OpponentID", Order = 12)]
        public int? OpponentID { get; set; }

        [DataMember(Name = "Snaps", Order = 13)]
        public decimal? Snaps { get; set; }

        [DataMember(Name = "SnapShare", Order = 14)]
        public decimal? SnapShare { get; set; }

        [DataMember(Name = "PassingAttempts", Order = 15)]
        public decimal? PassingAttempts { get; set; }

        [DataMember(Name = "Completions", Order = 16)]
        public decimal? Completions { get; set; }

        [DataMember(Name = "CompletionPercentage", Order = 17)]
        public decimal? CompletionPercentage { get; set; }

        [DataMember(Name = "PassingYards", Order = 18)]
        public decimal? PassingYards { get; set; }

        [DataMember(Name = "PassingYardsPerAttempt", Order = 19)]
        public decimal? PassingYardsPerAttempt { get; set; }

        [DataMember(Name = "PassingTouchdowns", Order = 20)]
        public decimal? PassingTouchdowns { get; set; }

        [DataMember(Name = "PassingTDs", Order = 21)]
        public decimal? PassingTDs { get; set; }

        [DataMember(Name = "Interceptions", Order = 22)]
        public decimal? Interceptions { get; set; }

        [DataMember(Name = "RedZoneAttempts", Order = 23)]
        public decimal? RedZoneAttempts { get; set; }

        [DataMember(Name = "RedZoneCompletionPercentage", Order = 24)]
        public decimal? RedZoneCompletionPercentage { get; set; }

        [DataMember(Name = "DeepBallAttempts", Order = 25)]
        public decimal? DeepBallAttempts { get; set; }

        [DataMember(Name = "DeepBallCompletions", Order = 26)]
        public decimal? DeepBallCompletions { get; set; }

        [DataMember(Name = "Carries", Order = 27)]
        public decimal? Carries { get; set; }

        [DataMember(Name = "RushingYards", Order = 28)]
        public decimal? RushingYards { get; set; }

        [DataMember(Name = "RushingTouchdowns", Order = 29)]
        public decimal? RushingTouchdowns { get; set; }

        [DataMember(Name = "Targets", Order = 30)]
        public decimal? Targets { get; set; }

        [DataMember(Name = "Receptions", Order = 31)]
        public decimal? Receptions { get; set; }

        [DataMember(Name = "ReceivingYards", Order = 32)]
        public decimal? ReceivingYards { get; set; }

        [DataMember(Name = "ReceivingTouchdowns", Order = 33)]
        public decimal? ReceivingTouchdowns { get; set; }

        [DataMember(Name = "TotalYards", Order = 34)]
        public decimal? TotalYards { get; set; }

        [DataMember(Name = "TotalTouches", Order = 35)]
        public decimal? TotalTouches { get; set; }

        [DataMember(Name = "YardsPerTouch", Order = 36)]
        public decimal? YardsPerTouch { get; set; }

        [DataMember(Name = "Opportunities", Order = 37)]
        public decimal? Opportunities { get; set; }

        [DataMember(Name = "OpportunityShare", Order = 38)]
        public decimal? OpportunityShare { get; set; }

        [DataMember(Name = "TotalTouchdowns", Order = 39)]
        public decimal? TotalTouchdowns { get; set; }

        [DataMember(Name = "EvadedTackles", Order = 40)]
        public decimal? EvadedTackles { get; set; }

        [DataMember(Name = "JukeRate", Order = 41)]
        public decimal? JukeRate { get; set; }

        [DataMember(Name = "CatchRate", Order = 42)]
        public decimal? CatchRate { get; set; }

        [DataMember(Name = "TargetShare", Order = 43)]
        public decimal? TargetShare { get; set; }

        [DataMember(Name = "HogRate", Order = 44)]
        public decimal? HogRate { get; set; }

        [DataMember(Name = "ContestedTargets", Order = 45)]
        public decimal? ContestedTargets { get; set; }

        [DataMember(Name = "ContestedCatches", Order = 46)]
        public decimal? ContestedCatches { get; set; }

        [DataMember(Name = "RedZoneCarries", Order = 47)]
        public decimal? RedZoneCarries { get; set; }

        [DataMember(Name = "RedZoneTargets", Order = 48)]
        public decimal? RedZoneTargets { get; set; }

        [DataMember(Name = "RedZoneOpportunities", Order = 49)]
        public decimal? RedZoneOpportunities { get; set; }

        [DataMember(Name = "RedZoneTouches", Order = 50)]
        public decimal? RedZoneTouches { get; set; }

        [DataMember(Name = "RedZoneReceptions", Order = 51)]
        public decimal? RedZoneReceptions { get; set; }

        [DataMember(Name = "RedZoneCatchRate", Order = 52)]
        public decimal? RedZoneCatchRate { get; set; }

        [DataMember(Name = "YardsPerCarry", Order = 53)]
        public decimal? YardsPerCarry { get; set; }

        [DataMember(Name = "YardsPerTarget", Order = 54)]
        public decimal? YardsPerTarget { get; set; }

        [DataMember(Name = "YardsPerOpportunity", Order = 55)]
        public decimal? YardsPerOpportunity { get; set; }

        [DataMember(Name = "YardsPerReception", Order = 56)]
        public decimal? YardsPerReception { get; set; }

        [DataMember(Name = "EndZoneTargets", Order = 57)]
        public decimal? EndZoneTargets { get; set; }

        [DataMember(Name = "RoutesRun", Order = 58)]
        public decimal? RoutesRun { get; set; }

        [DataMember(Name = "Burns", Order = 59)]
        public decimal? Burns { get; set; }

        [DataMember(Name = "Hurries", Order = 60)]
        public decimal? Hurries { get; set; }

        [DataMember(Name = "YardsCreated", Order = 61)]
        public decimal? YardsCreated { get; set; }

        [DataMember(Name = "PassAttemptsInside5", Order = 62)]
        public decimal? PassAttemptsInside5 { get; set; }

        [DataMember(Name = "PassAttemptsInside10", Order = 63)]
        public decimal? PassAttemptsInside10 { get; set; }

        [DataMember(Name = "CarriesInside5", Order = 64)]
        public decimal? CarriesInside5 { get; set; }

        [DataMember(Name = "CarriesInside10", Order = 65)]
        public decimal? CarriesInside10 { get; set; }

        [DataMember(Name = "TargetsInside5", Order = 66)]
        public decimal? TargetsInside5 { get; set; }

        [DataMember(Name = "TargetsInside10", Order = 67)]
        public decimal? TargetsInside10 { get; set; }

        [DataMember(Name = "PrimaryCorner", Order = 68)]
        public decimal? PrimaryCorner { get; set; }

        [DataMember(Name = "RoutesDefended", Order = 69)]
        public decimal? RoutesDefended { get; set; }

        [DataMember(Name = "TargetsAllowed", Order = 70)]
        public decimal? TargetsAllowed { get; set; }

        [DataMember(Name = "ReceptionsAllowed", Order = 71)]
        public decimal? ReceptionsAllowed { get; set; }

        [DataMember(Name = "YardsAllowed", Order = 72)]
        public decimal? YardsAllowed { get; set; }

        [DataMember(Name = "BurnsCB", Order = 73)]
        public decimal? BurnsCB { get; set; }

        [DataMember(Name = "PassBreakups", Order = 74)]
        public decimal? PassBreakups { get; set; }

        [DataMember(Name = "InterceptionsCB", Order = 75)]
        public decimal? InterceptionsCB { get; set; }

        [DataMember(Name = "WRMatchup", Order = 76)]
        public decimal? WRMatchup { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 77)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsRank", Order = 78)]
        public int? FantasyPointsRank { get; set; }

        [DataMember(Name = "FantasyPointsPerAttempt", Order = 79)]
        public decimal? FantasyPointsPerAttempt { get; set; }

        [DataMember(Name = "FantasyPointsPerTarget", Order = 80)]
        public decimal? FantasyPointsPerTarget { get; set; }

        [DataMember(Name = "FantasyPointsPerOpportunity", Order = 81)]
        public decimal? FantasyPointsPerOpportunity { get; set; }

        [DataMember(Name = "FantasyPointsAllowed", Order = 82)]
        public decimal? FantasyPointsAllowed { get; set; }

        [DataMember(Name = "FantasyPointsAllowedWeekRank", Order = 83)]
        public int? FantasyPointsAllowedWeekRank { get; set; }

    }
}

