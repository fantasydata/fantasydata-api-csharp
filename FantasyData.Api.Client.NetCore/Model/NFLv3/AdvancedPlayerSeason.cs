using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerSeason")]
    [Serializable]
    public partial class AdvancedPlayerSeason
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

        [DataMember(Name = "Games", Order = 10)]
        public int? Games { get; set; }

        [DataMember(Name = "Snaps", Order = 11)]
        public decimal? Snaps { get; set; }

        [DataMember(Name = "SnapShare", Order = 12)]
        public decimal? SnapShare { get; set; }

        [DataMember(Name = "SnapShareRank", Order = 13)]
        public int? SnapShareRank { get; set; }

        [DataMember(Name = "SlotRate", Order = 14)]
        public decimal? SlotRate { get; set; }

        [DataMember(Name = "SlotRateRank", Order = 15)]
        public int? SlotRateRank { get; set; }

        [DataMember(Name = "TargetSeparation", Order = 16)]
        public decimal? TargetSeparation { get; set; }

        [DataMember(Name = "TargetSeparationRank", Order = 17)]
        public int? TargetSeparationRank { get; set; }

        [DataMember(Name = "BurnRate", Order = 18)]
        public decimal? BurnRate { get; set; }

        [DataMember(Name = "AirYards", Order = 19)]
        public decimal? AirYards { get; set; }

        [DataMember(Name = "AirYardsPerGame", Order = 20)]
        public decimal? AirYardsPerGame { get; set; }

        [DataMember(Name = "AirYardsRank", Order = 21)]
        public int? AirYardsRank { get; set; }

        [DataMember(Name = "Carries", Order = 22)]
        public decimal? Carries { get; set; }

        [DataMember(Name = "CarriesInside10", Order = 23)]
        public decimal? CarriesInside10 { get; set; }

        [DataMember(Name = "CarriesInside10PerGame", Order = 24)]
        public decimal? CarriesInside10PerGame { get; set; }

        [DataMember(Name = "CarriesInside5", Order = 25)]
        public decimal? CarriesInside5 { get; set; }

        [DataMember(Name = "CarriesInside5PerGame", Order = 26)]
        public decimal? CarriesInside5PerGame { get; set; }

        [DataMember(Name = "CarriesPerGame", Order = 27)]
        public decimal? CarriesPerGame { get; set; }

        [DataMember(Name = "CarriesPerGameRank", Order = 28)]
        public int? CarriesPerGameRank { get; set; }

        [DataMember(Name = "CarriesRank", Order = 29)]
        public int? CarriesRank { get; set; }

        [DataMember(Name = "GameScript", Order = 30)]
        public decimal? GameScript { get; set; }

        [DataMember(Name = "GameScriptRank", Order = 31)]
        public int? GameScriptRank { get; set; }

        [DataMember(Name = "GoalLineCarries", Order = 32)]
        public decimal? GoalLineCarries { get; set; }

        [DataMember(Name = "GoalLineCarriesPerGame", Order = 33)]
        public decimal? GoalLineCarriesPerGame { get; set; }

        [DataMember(Name = "GoalLineCarriesPerGameRank", Order = 34)]
        public int? GoalLineCarriesPerGameRank { get; set; }

        [DataMember(Name = "GoalLineCarriesRank", Order = 35)]
        public int? GoalLineCarriesRank { get; set; }

        [DataMember(Name = "ProductionPremium", Order = 36)]
        public decimal? ProductionPremium { get; set; }

        [DataMember(Name = "ProductionPremiumRank", Order = 37)]
        public int? ProductionPremiumRank { get; set; }

        [DataMember(Name = "RedZoneCarries", Order = 38)]
        public decimal? RedZoneCarries { get; set; }

        [DataMember(Name = "RedZoneCarriesPerGame", Order = 39)]
        public decimal? RedZoneCarriesPerGame { get; set; }

        [DataMember(Name = "RedZoneCarriesPerGameRank", Order = 40)]
        public int? RedZoneCarriesPerGameRank { get; set; }

        [DataMember(Name = "RedZoneCarriesRank", Order = 41)]
        public int? RedZoneCarriesRank { get; set; }

        [DataMember(Name = "RushingTouchdowns", Order = 42)]
        public decimal? RushingTouchdowns { get; set; }

        [DataMember(Name = "RushingTouchdownsRank", Order = 43)]
        public int? RushingTouchdownsRank { get; set; }

        [DataMember(Name = "RushingYards", Order = 44)]
        public decimal? RushingYards { get; set; }

        [DataMember(Name = "RushingYardsRank", Order = 45)]
        public int? RushingYardsRank { get; set; }

        [DataMember(Name = "RushYardsPerGame", Order = 46)]
        public decimal? RushYardsPerGame { get; set; }

        [DataMember(Name = "RedZoneSnaps", Order = 47)]
        public decimal? RedZoneSnaps { get; set; }

        [DataMember(Name = "RunSnaps", Order = 48)]
        public decimal? RunSnaps { get; set; }

        [DataMember(Name = "PassSnaps", Order = 49)]
        public decimal? PassSnaps { get; set; }

        [DataMember(Name = "SnapweightedGameScript", Order = 50)]
        public decimal? SnapweightedGameScript { get; set; }

        [DataMember(Name = "SnapweightedGameScriptRank", Order = 51)]
        public int? SnapweightedGameScriptRank { get; set; }

        [DataMember(Name = "TeamPassPlays", Order = 52)]
        public decimal? TeamPassPlays { get; set; }

        [DataMember(Name = "TeamPassPlaysRank", Order = 53)]
        public int? TeamPassPlaysRank { get; set; }

        [DataMember(Name = "TouchdownRate", Order = 54)]
        public decimal? TouchdownRate { get; set; }

        [DataMember(Name = "WeeklyVolatility", Order = 55)]
        public decimal? WeeklyVolatility { get; set; }

        [DataMember(Name = "WeeklyVolatilityRank", Order = 56)]
        public int? WeeklyVolatilityRank { get; set; }

        [DataMember(Name = "VOS", Order = 57)]
        public decimal? VOS { get; set; }

        [DataMember(Name = "VOSRank", Order = 58)]
        public int? VOSRank { get; set; }

        [DataMember(Name = "YardsPerTarget", Order = 59)]
        public decimal? YardsPerTarget { get; set; }

        [DataMember(Name = "YardsPerTargetRank", Order = 60)]
        public int? YardsPerTargetRank { get; set; }

        [DataMember(Name = "YardsPerReception", Order = 61)]
        public decimal? YardsPerReception { get; set; }

        [DataMember(Name = "YardsAfterCatch", Order = 62)]
        public decimal? YardsAfterCatch { get; set; }

        [DataMember(Name = "YardsAfterCatchPerGame", Order = 63)]
        public decimal? YardsAfterCatchPerGame { get; set; }

        [DataMember(Name = "YardsAfterCatchPerReception", Order = 64)]
        public decimal? YardsAfterCatchPerReception { get; set; }

        [DataMember(Name = "YardsAfterCatchPerTarget", Order = 65)]
        public decimal? YardsAfterCatchPerTarget { get; set; }

        [DataMember(Name = "YardsAfterCatchRank", Order = 66)]
        public int? YardsAfterCatchRank { get; set; }

        [DataMember(Name = "TotalTouchdowns", Order = 67)]
        public decimal? TotalTouchdowns { get; set; }

        [DataMember(Name = "TotalTouchdownsRank", Order = 68)]
        public int? TotalTouchdownsRank { get; set; }

        [DataMember(Name = "TotalTouches", Order = 69)]
        public decimal? TotalTouches { get; set; }

        [DataMember(Name = "TotalYards", Order = 70)]
        public decimal? TotalYards { get; set; }

        [DataMember(Name = "TotalYardsPerGame", Order = 71)]
        public decimal? TotalYardsPerGame { get; set; }

        [DataMember(Name = "Targets", Order = 72)]
        public decimal? Targets { get; set; }

        [DataMember(Name = "TargetShare", Order = 73)]
        public decimal? TargetShare { get; set; }

        [DataMember(Name = "TargetShareRank", Order = 74)]
        public int? TargetShareRank { get; set; }

        [DataMember(Name = "TargetsInside10", Order = 75)]
        public decimal? TargetsInside10 { get; set; }

        [DataMember(Name = "TargetsInside10PerGame", Order = 76)]
        public decimal? TargetsInside10PerGame { get; set; }

        [DataMember(Name = "TargetsInside5", Order = 77)]
        public decimal? TargetsInside5 { get; set; }

        [DataMember(Name = "TargetsInside5PerGame", Order = 78)]
        public decimal? TargetsInside5PerGame { get; set; }

        [DataMember(Name = "TargetsPerGame", Order = 79)]
        public decimal? TargetsPerGame { get; set; }

        [DataMember(Name = "TargetsPerGameRank", Order = 80)]
        public int? TargetsPerGameRank { get; set; }

        [DataMember(Name = "TargetsRank", Order = 81)]
        public int? TargetsRank { get; set; }

        [DataMember(Name = "SlotSnaps", Order = 82)]
        public decimal? SlotSnaps { get; set; }

        [DataMember(Name = "SlotYPR", Order = 83)]
        public decimal? SlotYPR { get; set; }

        [DataMember(Name = "SlotYPRRank", Order = 84)]
        public int? SlotYPRRank { get; set; }

        [DataMember(Name = "SlotYPT", Order = 85)]
        public decimal? SlotYPT { get; set; }

        [DataMember(Name = "SlotYPTRank", Order = 86)]
        public int? SlotYPTRank { get; set; }

        [DataMember(Name = "RedZoneSnapShare", Order = 87)]
        public decimal? RedZoneSnapShare { get; set; }

        [DataMember(Name = "RedZoneSnapShareRank", Order = 88)]
        public int? RedZoneSnapShareRank { get; set; }

        [DataMember(Name = "RouteParticipation", Order = 89)]
        public decimal? RouteParticipation { get; set; }

        [DataMember(Name = "RouteParticipationRank", Order = 90)]
        public int? RouteParticipationRank { get; set; }

        [DataMember(Name = "PassRoutes", Order = 91)]
        public decimal? PassRoutes { get; set; }

        [DataMember(Name = "PassRoutesPerGame", Order = 92)]
        public decimal? PassRoutesPerGame { get; set; }

        [DataMember(Name = "PassRoutesPerGameRank", Order = 93)]
        public int? PassRoutesPerGameRank { get; set; }

        [DataMember(Name = "RedZoneReceptions", Order = 94)]
        public decimal? RedZoneReceptions { get; set; }

        [DataMember(Name = "RedZoneReceptionsRank", Order = 95)]
        public int? RedZoneReceptionsRank { get; set; }

        [DataMember(Name = "RedZoneTargets", Order = 96)]
        public decimal? RedZoneTargets { get; set; }

        [DataMember(Name = "RedZoneTargetShare", Order = 97)]
        public decimal? RedZoneTargetShare { get; set; }

        [DataMember(Name = "RedZoneTargetShareRank", Order = 98)]
        public int? RedZoneTargetShareRank { get; set; }

        [DataMember(Name = "RedZoneTargetsRank", Order = 99)]
        public int? RedZoneTargetsRank { get; set; }

        [DataMember(Name = "RedZoneTouches", Order = 100)]
        public decimal? RedZoneTouches { get; set; }

        [DataMember(Name = "RedZoneTouchesPerGame", Order = 101)]
        public decimal? RedZoneTouchesPerGame { get; set; }

        [DataMember(Name = "QBRatingWhenTargeted", Order = 102)]
        public decimal? QBRatingWhenTargeted { get; set; }

        [DataMember(Name = "QBRatingWhenTargetedRank", Order = 103)]
        public int? QBRatingWhenTargetedRank { get; set; }

        [DataMember(Name = "ReceivingTDs", Order = 104)]
        public decimal? ReceivingTDs { get; set; }

        [DataMember(Name = "ReceivingYards", Order = 105)]
        public decimal? ReceivingYards { get; set; }

        [DataMember(Name = "ReceivingYardsPerGame", Order = 106)]
        public decimal? ReceivingYardsPerGame { get; set; }

        [DataMember(Name = "ReceivingYardsPerGameRank", Order = 107)]
        public int? ReceivingYardsPerGameRank { get; set; }

        [DataMember(Name = "ReceivingYardsRank", Order = 108)]
        public int? ReceivingYardsRank { get; set; }

        [DataMember(Name = "Receptions", Order = 109)]
        public decimal? Receptions { get; set; }

        [DataMember(Name = "ReceptionsPerGame", Order = 110)]
        public decimal? ReceptionsPerGame { get; set; }

        [DataMember(Name = "ReceptionsPerGameRank", Order = 111)]
        public int? ReceptionsPerGameRank { get; set; }

        [DataMember(Name = "ReceptionsRank", Order = 112)]
        public int? ReceptionsRank { get; set; }

        [DataMember(Name = "RedZoneCatchRate", Order = 113)]
        public decimal? RedZoneCatchRate { get; set; }

        [DataMember(Name = "RedZoneCatchRateRank", Order = 114)]
        public int? RedZoneCatchRateRank { get; set; }

        [DataMember(Name = "CatchableTargetRate", Order = 115)]
        public decimal? CatchableTargetRate { get; set; }

        [DataMember(Name = "CatchableTargetRateRank", Order = 116)]
        public int? CatchableTargetRateRank { get; set; }

        [DataMember(Name = "CatchableTargets", Order = 117)]
        public decimal? CatchableTargets { get; set; }

        [DataMember(Name = "CatchRate", Order = 118)]
        public decimal? CatchRate { get; set; }

        [DataMember(Name = "CatchRateRank", Order = 119)]
        public int? CatchRateRank { get; set; }

        [DataMember(Name = "DominatorRating", Order = 120)]
        public decimal? DominatorRating { get; set; }

        [DataMember(Name = "DominatorRatingRank", Order = 121)]
        public int? DominatorRatingRank { get; set; }

        [DataMember(Name = "Drops", Order = 122)]
        public decimal? Drops { get; set; }

        [DataMember(Name = "DropsPerGame", Order = 123)]
        public decimal? DropsPerGame { get; set; }

        [DataMember(Name = "DropsPerGameRank", Order = 124)]
        public int? DropsPerGameRank { get; set; }

        [DataMember(Name = "DropRate", Order = 125)]
        public decimal? DropRate { get; set; }

        [DataMember(Name = "DropRateRank", Order = 126)]
        public int? DropRateRank { get; set; }

        [DataMember(Name = "DropsRank", Order = 127)]
        public int? DropsRank { get; set; }

        [DataMember(Name = "EndzoneTargets", Order = 128)]
        public decimal? EndzoneTargets { get; set; }

        [DataMember(Name = "EndzoneTargetShare", Order = 129)]
        public decimal? EndzoneTargetShare { get; set; }

        [DataMember(Name = "EndzoneTargetShareRank", Order = 130)]
        public int? EndzoneTargetShareRank { get; set; }

        [DataMember(Name = "AccuracyRating", Order = 131)]
        public decimal? AccuracyRating { get; set; }

        [DataMember(Name = "AccuracyRatingRank", Order = 132)]
        public int? AccuracyRatingRank { get; set; }

        [DataMember(Name = "AdjustedAttempts", Order = 133)]
        public decimal? AdjustedAttempts { get; set; }

        [DataMember(Name = "AdjustedYardsPerAttempt", Order = 134)]
        public decimal? AdjustedYardsPerAttempt { get; set; }

        [DataMember(Name = "AdjustedYardsPerAttemptRank", Order = 135)]
        public int? AdjustedYardsPerAttemptRank { get; set; }

        [DataMember(Name = "AirYardsPerAttempt", Order = 136)]
        public decimal? AirYardsPerAttempt { get; set; }

        [DataMember(Name = "AirYardsPerAttemptRank", Order = 137)]
        public int? AirYardsPerAttemptRank { get; set; }

        [DataMember(Name = "AttemptsInside10", Order = 138)]
        public decimal? AttemptsInside10 { get; set; }

        [DataMember(Name = "AttemptsInside10PerGame", Order = 139)]
        public decimal? AttemptsInside10PerGame { get; set; }

        [DataMember(Name = "AttemptsInside5", Order = 140)]
        public decimal? AttemptsInside5 { get; set; }

        [DataMember(Name = "AttemptsInside5PerGame", Order = 141)]
        public decimal? AttemptsInside5PerGame { get; set; }

        [DataMember(Name = "AttemptsPerGame", Order = 142)]
        public decimal? AttemptsPerGame { get; set; }

        [DataMember(Name = "CatchablePasses", Order = 143)]
        public decimal? CatchablePasses { get; set; }

        [DataMember(Name = "CatchablePassesPerGame", Order = 144)]
        public decimal? CatchablePassesPerGame { get; set; }

        [DataMember(Name = "CatchablePassesRank", Order = 145)]
        public int? CatchablePassesRank { get; set; }

        [DataMember(Name = "CompletionPercentage", Order = 146)]
        public decimal? CompletionPercentage { get; set; }

        [DataMember(Name = "CompletionPercentageRank", Order = 147)]
        public int? CompletionPercentageRank { get; set; }

        [DataMember(Name = "Completions", Order = 148)]
        public decimal? Completions { get; set; }

        [DataMember(Name = "DangerPlays", Order = 149)]
        public decimal? DangerPlays { get; set; }

        [DataMember(Name = "DangerPlaysPerGame", Order = 150)]
        public decimal? DangerPlaysPerGame { get; set; }

        [DataMember(Name = "DangerPlaysRank", Order = 151)]
        public int? DangerPlaysRank { get; set; }

        [DataMember(Name = "DeepBallAttempts", Order = 152)]
        public decimal? DeepBallAttempts { get; set; }

        [DataMember(Name = "DeepBallAttemptsPerGame", Order = 153)]
        public decimal? DeepBallAttemptsPerGame { get; set; }

        [DataMember(Name = "DeepBallAttemptsPerGameRank", Order = 154)]
        public int? DeepBallAttemptsPerGameRank { get; set; }

        [DataMember(Name = "DeepBallAttemptsRank", Order = 155)]
        public int? DeepBallAttemptsRank { get; set; }

        [DataMember(Name = "DeepBallCompletionPercentage", Order = 156)]
        public decimal? DeepBallCompletionPercentage { get; set; }

        [DataMember(Name = "DeepBallCompletionPercentageRank", Order = 157)]
        public int? DeepBallCompletionPercentageRank { get; set; }

        [DataMember(Name = "DeepBallCompletions", Order = 158)]
        public decimal? DeepBallCompletions { get; set; }

        [DataMember(Name = "DeepBallCompletionsRank", Order = 159)]
        public int? DeepBallCompletionsRank { get; set; }

        [DataMember(Name = "DroppedPasses", Order = 160)]
        public decimal? DroppedPasses { get; set; }

        [DataMember(Name = "DroppedPassesRank", Order = 161)]
        public int? DroppedPassesRank { get; set; }

        [DataMember(Name = "DroppedPassesPerGame", Order = 162)]
        public decimal? DroppedPassesPerGame { get; set; }

        [DataMember(Name = "DropsPerAttempt", Order = 163)]
        public decimal? DropsPerAttempt { get; set; }

        [DataMember(Name = "DropsPerAttemptRank", Order = 164)]
        public int? DropsPerAttemptRank { get; set; }

        [DataMember(Name = "DropBacks", Order = 165)]
        public decimal? DropBacks { get; set; }

        [DataMember(Name = "InterceptablePasses", Order = 166)]
        public decimal? InterceptablePasses { get; set; }

        [DataMember(Name = "InterceptablePassesPerGame", Order = 167)]
        public decimal? InterceptablePassesPerGame { get; set; }

        [DataMember(Name = "InterceptablePassesRank", Order = 168)]
        public int? InterceptablePassesRank { get; set; }

        [DataMember(Name = "MoneyThrows", Order = 169)]
        public decimal? MoneyThrows { get; set; }

        [DataMember(Name = "MoneyThrowsPerGame", Order = 170)]
        public decimal? MoneyThrowsPerGame { get; set; }

        [DataMember(Name = "MoneyThrowsRank", Order = 171)]
        public int? MoneyThrowsRank { get; set; }

        [DataMember(Name = "PassAttempts", Order = 172)]
        public decimal? PassAttempts { get; set; }

        [DataMember(Name = "PassAttemptsRank", Order = 173)]
        public int? PassAttemptsRank { get; set; }

        [DataMember(Name = "PassAttemptDistance", Order = 174)]
        public decimal? PassAttemptDistance { get; set; }

        [DataMember(Name = "PassAttemptDistanceRank", Order = 175)]
        public int? PassAttemptDistanceRank { get; set; }

        [DataMember(Name = "PassAttemptDistancePerAttempt", Order = 176)]
        public decimal? PassAttemptDistancePerAttempt { get; set; }

        [DataMember(Name = "PassAttemptDistancePerAttemptRank", Order = 177)]
        public int? PassAttemptDistancePerAttemptRank { get; set; }

        [DataMember(Name = "PassingAttempts", Order = 178)]
        public decimal? PassingAttempts { get; set; }

        [DataMember(Name = "PassingTouchdowns", Order = 179)]
        public decimal? PassingTouchdowns { get; set; }

        [DataMember(Name = "PassingTouchdownsRank", Order = 180)]
        public int? PassingTouchdownsRank { get; set; }

        [DataMember(Name = "PassingYards", Order = 181)]
        public decimal? PassingYards { get; set; }

        [DataMember(Name = "PassingYardsPerAttempt", Order = 182)]
        public decimal? PassingYardsPerAttempt { get; set; }

        [DataMember(Name = "PassingYardsPerAttemptRank", Order = 183)]
        public int? PassingYardsPerAttemptRank { get; set; }

        [DataMember(Name = "PassingYardsPerGame", Order = 184)]
        public decimal? PassingYardsPerGame { get; set; }

        [DataMember(Name = "PassingYardsPerGameRank", Order = 185)]
        public int? PassingYardsPerGameRank { get; set; }

        [DataMember(Name = "PassingYardsRank", Order = 186)]
        public int? PassingYardsRank { get; set; }

        [DataMember(Name = "PlayactionPassAttempts", Order = 187)]
        public decimal? PlayactionPassAttempts { get; set; }

        [DataMember(Name = "PlayactionPassAttemptsPerGame", Order = 188)]
        public decimal? PlayactionPassAttemptsPerGame { get; set; }

        [DataMember(Name = "PlayactionPassAttemptsRank", Order = 189)]
        public int? PlayactionPassAttemptsRank { get; set; }

        [DataMember(Name = "PlayactionPassCompletionPercentage", Order = 190)]
        public decimal? PlayactionPassCompletionPercentage { get; set; }

        [DataMember(Name = "PlayactionPassCompletionPercentageRank", Order = 191)]
        public int? PlayactionPassCompletionPercentageRank { get; set; }

        [DataMember(Name = "ProtectionRate", Order = 192)]
        public decimal? ProtectionRate { get; set; }

        [DataMember(Name = "ProtectionRateRank", Order = 193)]
        public int? ProtectionRateRank { get; set; }

        [DataMember(Name = "RedZoneAttempts", Order = 194)]
        public decimal? RedZoneAttempts { get; set; }

        [DataMember(Name = "RedZoneAttemptsPerGame", Order = 195)]
        public decimal? RedZoneAttemptsPerGame { get; set; }

        [DataMember(Name = "RedZoneAttemptsRank", Order = 196)]
        public int? RedZoneAttemptsRank { get; set; }

        [DataMember(Name = "RedZoneCompletionPercentage", Order = 197)]
        public decimal? RedZoneCompletionPercentage { get; set; }

        [DataMember(Name = "RedZoneCompletionPercentageRank", Order = 198)]
        public int? RedZoneCompletionPercentageRank { get; set; }

        [DataMember(Name = "RedZoneTDtoINTRatio", Order = 199)]
        public decimal? RedZoneTDtoINTRatio { get; set; }

        [DataMember(Name = "RushingTDs", Order = 200)]
        public decimal? RushingTDs { get; set; }

        [DataMember(Name = "RushingYardsPerGameRank", Order = 201)]
        public int? RushingYardsPerGameRank { get; set; }

        [DataMember(Name = "ShotgunCompletionPercentage", Order = 202)]
        public decimal? ShotgunCompletionPercentage { get; set; }

        [DataMember(Name = "ShotgunSnaps", Order = 203)]
        public decimal? ShotgunSnaps { get; set; }

        [DataMember(Name = "UnderCenterCompletionPercentage", Order = 204)]
        public decimal? UnderCenterCompletionPercentage { get; set; }

        [DataMember(Name = "UnderCenterSnaps", Order = 205)]
        public decimal? UnderCenterSnaps { get; set; }

        [DataMember(Name = "ReceiverContestedCatchRate", Order = 206)]
        public decimal? ReceiverContestedCatchRate { get; set; }

        [DataMember(Name = "ReceiverContestedCatchRateRank", Order = 207)]
        public int? ReceiverContestedCatchRateRank { get; set; }

        [DataMember(Name = "ReceiverTargetSeparation", Order = 208)]
        public decimal? ReceiverTargetSeparation { get; set; }

        [DataMember(Name = "ReceiverTargetSeparationRank", Order = 209)]
        public int? ReceiverTargetSeparationRank { get; set; }

        [DataMember(Name = "ReceiverYardsAfterTheCatch", Order = 210)]
        public decimal? ReceiverYardsAfterTheCatch { get; set; }

        [DataMember(Name = "ReceiverYardsAfterTheCatchRank", Order = 211)]
        public int? ReceiverYardsAfterTheCatchRank { get; set; }

        [DataMember(Name = "ReceiverYardsAfterTheCatchPerTarget", Order = 212)]
        public decimal? ReceiverYardsAfterTheCatchPerTarget { get; set; }

        [DataMember(Name = "SupportingCastEfficiency", Order = 213)]
        public decimal? SupportingCastEfficiency { get; set; }

        [DataMember(Name = "SupportingCastEfficiencyRank", Order = 214)]
        public int? SupportingCastEfficiencyRank { get; set; }

        [DataMember(Name = "TotalQBR", Order = 215)]
        public decimal? TotalQBR { get; set; }

        [DataMember(Name = "TotalQBRRank", Order = 216)]
        public int? TotalQBRRank { get; set; }

        [DataMember(Name = "TrueCompletionPercentage", Order = 217)]
        public decimal? TrueCompletionPercentage { get; set; }

        [DataMember(Name = "TrueCompletionPercentageRank", Order = 218)]
        public int? TrueCompletionPercentageRank { get; set; }

        [DataMember(Name = "TruePasserRating", Order = 219)]
        public decimal? TruePasserRating { get; set; }

        [DataMember(Name = "TruePasserRatingRank", Order = 220)]
        public int? TruePasserRatingRank { get; set; }

        [DataMember(Name = "UncatchablePasses", Order = 221)]
        public decimal? UncatchablePasses { get; set; }

        [DataMember(Name = "UncatchablePassesPerGame", Order = 222)]
        public decimal? UncatchablePassesPerGame { get; set; }

        [DataMember(Name = "UncatchablePassesRank", Order = 223)]
        public int? UncatchablePassesRank { get; set; }

        [DataMember(Name = "UnderPressureAttempts", Order = 224)]
        public decimal? UnderPressureAttempts { get; set; }

        [DataMember(Name = "UnderPressureAttemptsRank", Order = 225)]
        public int? UnderPressureAttemptsRank { get; set; }

        [DataMember(Name = "UnderPressureAttemptsPerGame", Order = 226)]
        public decimal? UnderPressureAttemptsPerGame { get; set; }

        [DataMember(Name = "PressuredCompletionPercentage", Order = 227)]
        public decimal? PressuredCompletionPercentage { get; set; }

        [DataMember(Name = "PressuredCompletionPercentageRank", Order = 228)]
        public int? PressuredCompletionPercentageRank { get; set; }

        [DataMember(Name = "AverageDefendersInTheBox", Order = 229)]
        public decimal? AverageDefendersInTheBox { get; set; }

        [DataMember(Name = "AverageDefendersInTheBoxRank", Order = 230)]
        public int? AverageDefendersInTheBoxRank { get; set; }

        [DataMember(Name = "BaseFrontCarryRate", Order = 231)]
        public decimal? BaseFrontCarryRate { get; set; }

        [DataMember(Name = "BaseFrontCarryRateRank", Order = 232)]
        public int? BaseFrontCarryRateRank { get; set; }

        [DataMember(Name = "BaseFrontYardsPerCarry", Order = 233)]
        public decimal? BaseFrontYardsPerCarry { get; set; }

        [DataMember(Name = "BaseFrontYardsPerCarryRank", Order = 234)]
        public int? BaseFrontYardsPerCarryRank { get; set; }

        [DataMember(Name = "BreakawayRunRate", Order = 235)]
        public decimal? BreakawayRunRate { get; set; }

        [DataMember(Name = "BreakawayRunRateRank", Order = 236)]
        public int? BreakawayRunRateRank { get; set; }

        [DataMember(Name = "BreakawayRuns", Order = 237)]
        public decimal? BreakawayRuns { get; set; }

        [DataMember(Name = "BreakawayRunsPerGame", Order = 238)]
        public decimal? BreakawayRunsPerGame { get; set; }

        [DataMember(Name = "BreakawayRunsPerGameRank", Order = 239)]
        public int? BreakawayRunsPerGameRank { get; set; }

        [DataMember(Name = "BreakawayRunsRank", Order = 240)]
        public int? BreakawayRunsRank { get; set; }

        [DataMember(Name = "EvadedTackles", Order = 241)]
        public decimal? EvadedTackles { get; set; }

        [DataMember(Name = "EvadedTacklesPerGame", Order = 242)]
        public decimal? EvadedTacklesPerGame { get; set; }

        [DataMember(Name = "EvadedTacklesPerGameRank", Order = 243)]
        public int? EvadedTacklesPerGameRank { get; set; }

        [DataMember(Name = "EvadedTacklesRank", Order = 244)]
        public int? EvadedTacklesRank { get; set; }

        [DataMember(Name = "JukeRate", Order = 245)]
        public decimal? JukeRate { get; set; }

        [DataMember(Name = "JukeRateRank", Order = 246)]
        public int? JukeRateRank { get; set; }

        [DataMember(Name = "LightFrontCarryRate", Order = 247)]
        public decimal? LightFrontCarryRate { get; set; }

        [DataMember(Name = "LightFrontCarryRateRank", Order = 248)]
        public int? LightFrontCarryRateRank { get; set; }

        [DataMember(Name = "LightFrontYardsPerCarry", Order = 249)]
        public decimal? LightFrontYardsPerCarry { get; set; }

        [DataMember(Name = "LightFrontYardsPerCarryRank", Order = 250)]
        public int? LightFrontYardsPerCarryRank { get; set; }

        [DataMember(Name = "Opportunities", Order = 251)]
        public decimal? Opportunities { get; set; }

        [DataMember(Name = "OpportunityShare", Order = 252)]
        public decimal? OpportunityShare { get; set; }

        [DataMember(Name = "OpportunityShareRank", Order = 253)]
        public int? OpportunityShareRank { get; set; }

        [DataMember(Name = "RedZoneOpportunities", Order = 254)]
        public decimal? RedZoneOpportunities { get; set; }

        [DataMember(Name = "RedZoneTouchesPerGameRank", Order = 255)]
        public int? RedZoneTouchesPerGameRank { get; set; }

        [DataMember(Name = "RedZoneTouchesRank", Order = 256)]
        public int? RedZoneTouchesRank { get; set; }

        [DataMember(Name = "RunBlockingEfficiency", Order = 257)]
        public decimal? RunBlockingEfficiency { get; set; }

        [DataMember(Name = "RunBlockingEfficiencyRank", Order = 258)]
        public int? RunBlockingEfficiencyRank { get; set; }

        [DataMember(Name = "RushYardsPerGameRank", Order = 259)]
        public int? RushYardsPerGameRank { get; set; }

        [DataMember(Name = "ShotgunCarryRate", Order = 260)]
        public decimal? ShotgunCarryRate { get; set; }

        [DataMember(Name = "ShotgunCarryRateRank", Order = 261)]
        public int? ShotgunCarryRateRank { get; set; }

        [DataMember(Name = "ShotgunYardsPerCarry", Order = 262)]
        public decimal? ShotgunYardsPerCarry { get; set; }

        [DataMember(Name = "ShotgunYardsPerCarryRank", Order = 263)]
        public int? ShotgunYardsPerCarryRank { get; set; }

        [DataMember(Name = "RedZoneOpportunityShare", Order = 264)]
        public decimal? RedZoneOpportunityShare { get; set; }

        [DataMember(Name = "RedZoneOpportunityShareRank", Order = 265)]
        public int? RedZoneOpportunityShareRank { get; set; }

        [DataMember(Name = "RedZoneTDConversionRate", Order = 266)]
        public decimal? RedZoneTDConversionRate { get; set; }

        [DataMember(Name = "RedZoneTDConversionRateRank", Order = 267)]
        public int? RedZoneTDConversionRateRank { get; set; }

        [DataMember(Name = "StackedFrontCarryRate", Order = 268)]
        public decimal? StackedFrontCarryRate { get; set; }

        [DataMember(Name = "StackedFrontCarryRateRank", Order = 269)]
        public int? StackedFrontCarryRateRank { get; set; }

        [DataMember(Name = "StackedFrontYardsPerCarry", Order = 270)]
        public decimal? StackedFrontYardsPerCarry { get; set; }

        [DataMember(Name = "StackedFrontYardsPerCarryRank", Order = 271)]
        public int? StackedFrontYardsPerCarryRank { get; set; }

        [DataMember(Name = "StuffedRuns", Order = 272)]
        public decimal? StuffedRuns { get; set; }

        [DataMember(Name = "StuffedRunsRank", Order = 273)]
        public int? StuffedRunsRank { get; set; }

        [DataMember(Name = "StuffedRunRate", Order = 274)]
        public decimal? StuffedRunRate { get; set; }

        [DataMember(Name = "StuffedRunRateRank", Order = 275)]
        public int? StuffedRunRateRank { get; set; }

        [DataMember(Name = "TeamRunPlays", Order = 276)]
        public decimal? TeamRunPlays { get; set; }

        [DataMember(Name = "TeamRunPlaysRank", Order = 277)]
        public int? TeamRunPlaysRank { get; set; }

        [DataMember(Name = "TotalYardsPerGameRank", Order = 278)]
        public int? TotalYardsPerGameRank { get; set; }

        [DataMember(Name = "TotalYardsRank", Order = 279)]
        public int? TotalYardsRank { get; set; }

        [DataMember(Name = "TrueYardsPerCarry", Order = 280)]
        public decimal? TrueYardsPerCarry { get; set; }

        [DataMember(Name = "TrueYardsPerCarryRank", Order = 281)]
        public int? TrueYardsPerCarryRank { get; set; }

        [DataMember(Name = "UnderCenterCarryRate", Order = 282)]
        public decimal? UnderCenterCarryRate { get; set; }

        [DataMember(Name = "UnderCenterCarryRateRank", Order = 283)]
        public int? UnderCenterCarryRateRank { get; set; }

        [DataMember(Name = "UnderCenterYardsPerCarry", Order = 284)]
        public decimal? UnderCenterYardsPerCarry { get; set; }

        [DataMember(Name = "UnderCenterYardsPerCarryRank", Order = 285)]
        public int? UnderCenterYardsPerCarryRank { get; set; }

        [DataMember(Name = "WeightedOpportunities", Order = 286)]
        public decimal? WeightedOpportunities { get; set; }

        [DataMember(Name = "WeightedOpportunitiesRank", Order = 287)]
        public int? WeightedOpportunitiesRank { get; set; }

        [DataMember(Name = "WeightedOpportunitiesPerGame", Order = 288)]
        public decimal? WeightedOpportunitiesPerGame { get; set; }

        [DataMember(Name = "WeightedOpportunitiesPerGameRank", Order = 289)]
        public int? WeightedOpportunitiesPerGameRank { get; set; }

        [DataMember(Name = "YardsCreated", Order = 290)]
        public decimal? YardsCreated { get; set; }

        [DataMember(Name = "YardsCreatedPerGame", Order = 291)]
        public decimal? YardsCreatedPerGame { get; set; }

        [DataMember(Name = "YardsCreatedPerGameRank", Order = 292)]
        public int? YardsCreatedPerGameRank { get; set; }

        [DataMember(Name = "YardsCreatedPerCarry", Order = 293)]
        public decimal? YardsCreatedPerCarry { get; set; }

        [DataMember(Name = "YardsCreatedPerCarryRank", Order = 294)]
        public int? YardsCreatedPerCarryRank { get; set; }

        [DataMember(Name = "YardsCreatedRank", Order = 295)]
        public int? YardsCreatedRank { get; set; }

        [DataMember(Name = "YardsPerCarry", Order = 296)]
        public decimal? YardsPerCarry { get; set; }

        [DataMember(Name = "YardsPerCarryRank", Order = 297)]
        public int? YardsPerCarryRank { get; set; }

        [DataMember(Name = "YardsPerOpportunity", Order = 298)]
        public decimal? YardsPerOpportunity { get; set; }

        [DataMember(Name = "YardsPerRouteRun", Order = 299)]
        public decimal? YardsPerRouteRun { get; set; }

        [DataMember(Name = "YardsPerRouteRunRank", Order = 300)]
        public int? YardsPerRouteRunRank { get; set; }

        [DataMember(Name = "YardsPerTouch", Order = 301)]
        public decimal? YardsPerTouch { get; set; }

        [DataMember(Name = "YardsPerTouchRank", Order = 302)]
        public int? YardsPerTouchRank { get; set; }

        [DataMember(Name = "AirYardsPerReception", Order = 303)]
        public decimal? AirYardsPerReception { get; set; }

        [DataMember(Name = "AirYardsPerTarget", Order = 304)]
        public decimal? AirYardsPerTarget { get; set; }

        [DataMember(Name = "Cushion", Order = 305)]
        public decimal? Cushion { get; set; }

        [DataMember(Name = "CushionRank", Order = 306)]
        public int? CushionRank { get; set; }

        [DataMember(Name = "AverageTargetDistance", Order = 307)]
        public decimal? AverageTargetDistance { get; set; }

        [DataMember(Name = "AverageTargetDistanceRank", Order = 308)]
        public int? AverageTargetDistanceRank { get; set; }

        [DataMember(Name = "Burns", Order = 309)]
        public decimal? Burns { get; set; }

        [DataMember(Name = "CatchableTargetsPerGame", Order = 310)]
        public decimal? CatchableTargetsPerGame { get; set; }

        [DataMember(Name = "CatchableTargetsRank", Order = 311)]
        public int? CatchableTargetsRank { get; set; }

        [DataMember(Name = "ContestedCatchConversionRate", Order = 312)]
        public decimal? ContestedCatchConversionRate { get; set; }

        [DataMember(Name = "ContestedCatchConversionRateRank", Order = 313)]
        public int? ContestedCatchConversionRateRank { get; set; }

        [DataMember(Name = "ContestedCatches", Order = 314)]
        public decimal? ContestedCatches { get; set; }

        [DataMember(Name = "ContestedTargets", Order = 315)]
        public decimal? ContestedTargets { get; set; }

        [DataMember(Name = "HogRate", Order = 316)]
        public decimal? HogRate { get; set; }

        [DataMember(Name = "HogRateRank", Order = 317)]
        public int? HogRateRank { get; set; }

        [DataMember(Name = "PassSnapsRank", Order = 318)]
        public int? PassSnapsRank { get; set; }

        [DataMember(Name = "RunSnapsRank", Order = 319)]
        public int? RunSnapsRank { get; set; }

        [DataMember(Name = "SlotCatchRate", Order = 320)]
        public decimal? SlotCatchRate { get; set; }

        [DataMember(Name = "SlotCatchRateRank", Order = 321)]
        public int? SlotCatchRateRank { get; set; }

        [DataMember(Name = "SlotSnapsRank", Order = 322)]
        public int? SlotSnapsRank { get; set; }

        [DataMember(Name = "SnapweighedGameScript", Order = 323)]
        public decimal? SnapweighedGameScript { get; set; }

        [DataMember(Name = "SnapweighedGameScriptRank", Order = 324)]
        public int? SnapweighedGameScriptRank { get; set; }

        [DataMember(Name = "TargetPremium", Order = 325)]
        public decimal? TargetPremium { get; set; }

        [DataMember(Name = "TargetPremiumRank", Order = 326)]
        public int? TargetPremiumRank { get; set; }

        [DataMember(Name = "TargetQualityRating", Order = 327)]
        public decimal? TargetQualityRating { get; set; }

        [DataMember(Name = "TargetQualityRatingRank", Order = 328)]
        public int? TargetQualityRatingRank { get; set; }

        [DataMember(Name = "TargetAccuracy", Order = 329)]
        public decimal? TargetAccuracy { get; set; }

        [DataMember(Name = "TargetAccuracyRank", Order = 330)]
        public int? TargetAccuracyRank { get; set; }

        [DataMember(Name = "TargetDistance", Order = 331)]
        public decimal? TargetDistance { get; set; }

        [DataMember(Name = "TargetDistancePerGame", Order = 332)]
        public decimal? TargetDistancePerGame { get; set; }

        [DataMember(Name = "TargetDistanceRank", Order = 333)]
        public int? TargetDistanceRank { get; set; }

        [DataMember(Name = "TrueCatchRate", Order = 334)]
        public decimal? TrueCatchRate { get; set; }

        [DataMember(Name = "TrueCatchRateRank", Order = 335)]
        public int? TrueCatchRateRank { get; set; }

        [DataMember(Name = "UncatchableTargets", Order = 336)]
        public decimal? UncatchableTargets { get; set; }

        [DataMember(Name = "UncatchableTargetsGame", Order = 337)]
        public decimal? UncatchableTargetsGame { get; set; }

        [DataMember(Name = "YardsPerReceptionRank", Order = 338)]
        public int? YardsPerReceptionRank { get; set; }

        [DataMember(Name = "YardsPerPassRoute", Order = 339)]
        public decimal? YardsPerPassRoute { get; set; }

        [DataMember(Name = "YardsPerPassRouteRank", Order = 340)]
        public int? YardsPerPassRouteRank { get; set; }

        [DataMember(Name = "TeamDefensiveSnaps", Order = 341)]
        public decimal? TeamDefensiveSnaps { get; set; }

        [DataMember(Name = "SoloTackles", Order = 342)]
        public decimal? SoloTackles { get; set; }

        [DataMember(Name = "SoloTacklesRank", Order = 343)]
        public int? SoloTacklesRank { get; set; }

        [DataMember(Name = "SoloTacklesPerGame", Order = 344)]
        public decimal? SoloTacklesPerGame { get; set; }

        [DataMember(Name = "AssistedTackles", Order = 345)]
        public decimal? AssistedTackles { get; set; }

        [DataMember(Name = "AssistedTacklesRank", Order = 346)]
        public int? AssistedTacklesRank { get; set; }

        [DataMember(Name = "AssistedTacklesPerGame", Order = 347)]
        public decimal? AssistedTacklesPerGame { get; set; }

        [DataMember(Name = "TotalTackles", Order = 348)]
        public decimal? TotalTackles { get; set; }

        [DataMember(Name = "TotalTacklesRank", Order = 349)]
        public int? TotalTacklesRank { get; set; }

        [DataMember(Name = "TotalTacklesPerGame", Order = 350)]
        public decimal? TotalTacklesPerGame { get; set; }

        [DataMember(Name = "Sacks", Order = 351)]
        public decimal? Sacks { get; set; }

        [DataMember(Name = "SacksRank", Order = 352)]
        public int? SacksRank { get; set; }

        [DataMember(Name = "SackYards", Order = 353)]
        public decimal? SackYards { get; set; }

        [DataMember(Name = "ForcedFumbles", Order = 354)]
        public decimal? ForcedFumbles { get; set; }

        [DataMember(Name = "ForcedFumblesRank", Order = 355)]
        public int? ForcedFumblesRank { get; set; }

        [DataMember(Name = "FumbleRecoveries", Order = 356)]
        public decimal? FumbleRecoveries { get; set; }

        [DataMember(Name = "FumbleRecoveriesRank", Order = 357)]
        public int? FumbleRecoveriesRank { get; set; }

        [DataMember(Name = "BattedPasses", Order = 358)]
        public decimal? BattedPasses { get; set; }

        [DataMember(Name = "BattedPassesRank", Order = 359)]
        public int? BattedPassesRank { get; set; }

        [DataMember(Name = "TacklesForLoss", Order = 360)]
        public decimal? TacklesForLoss { get; set; }

        [DataMember(Name = "TacklesForLossRank", Order = 361)]
        public int? TacklesForLossRank { get; set; }

        [DataMember(Name = "RunStuffs", Order = 362)]
        public decimal? RunStuffs { get; set; }

        [DataMember(Name = "RunStuffsRank", Order = 363)]
        public int? RunStuffsRank { get; set; }

        [DataMember(Name = "PassBreakups", Order = 364)]
        public decimal? PassBreakups { get; set; }

        [DataMember(Name = "PassBreakupsRank", Order = 365)]
        public int? PassBreakupsRank { get; set; }

        [DataMember(Name = "PassBreakupsPerGame", Order = 366)]
        public decimal? PassBreakupsPerGame { get; set; }

        [DataMember(Name = "PassBreakupsPerGameRank", Order = 367)]
        public int? PassBreakupsPerGameRank { get; set; }

        [DataMember(Name = "PassBreakupsPerTarget", Order = 368)]
        public decimal? PassBreakupsPerTarget { get; set; }

        [DataMember(Name = "PassBreakupsPerTargetRank", Order = 369)]
        public int? PassBreakupsPerTargetRank { get; set; }

        [DataMember(Name = "Interceptions", Order = 370)]
        public decimal? Interceptions { get; set; }

        [DataMember(Name = "InterceptionsRank", Order = 371)]
        public int? InterceptionsRank { get; set; }

        [DataMember(Name = "TargetsAllowed", Order = 372)]
        public decimal? TargetsAllowed { get; set; }

        [DataMember(Name = "TargetsAllowedRank", Order = 373)]
        public int? TargetsAllowedRank { get; set; }

        [DataMember(Name = "ReceptionsAllowed", Order = 374)]
        public decimal? ReceptionsAllowed { get; set; }

        [DataMember(Name = "ReceptionsAllowedRank", Order = 375)]
        public int? ReceptionsAllowedRank { get; set; }

        [DataMember(Name = "YardsAllowed", Order = 376)]
        public decimal? YardsAllowed { get; set; }

        [DataMember(Name = "YardsAllowedRank", Order = 377)]
        public int? YardsAllowedRank { get; set; }

        [DataMember(Name = "YardsAllowedPerGame", Order = 378)]
        public decimal? YardsAllowedPerGame { get; set; }

        [DataMember(Name = "YardsAllowedPerGameRank", Order = 379)]
        public int? YardsAllowedPerGameRank { get; set; }

        [DataMember(Name = "YardsPerReceptionAllowed", Order = 380)]
        public decimal? YardsPerReceptionAllowed { get; set; }

        [DataMember(Name = "YardsPerReceptionAllowedRank", Order = 381)]
        public int? YardsPerReceptionAllowedRank { get; set; }

        [DataMember(Name = "CatchRateAllowed", Order = 382)]
        public decimal? CatchRateAllowed { get; set; }

        [DataMember(Name = "CatchRateAllowedRank", Order = 383)]
        public int? CatchRateAllowedRank { get; set; }

        [DataMember(Name = "PasserRatingAllowed", Order = 384)]
        public decimal? PasserRatingAllowed { get; set; }

        [DataMember(Name = "PasserRatingAllowedRank", Order = 385)]
        public int? PasserRatingAllowedRank { get; set; }

        [DataMember(Name = "TouchdownsAllowed", Order = 386)]
        public decimal? TouchdownsAllowed { get; set; }

        [DataMember(Name = "TouchdownsAllowedRank", Order = 387)]
        public int? TouchdownsAllowedRank { get; set; }

        [DataMember(Name = "InterceptionsPerTarget", Order = 388)]
        public decimal? InterceptionsPerTarget { get; set; }

        [DataMember(Name = "InterceptionsPerTargetRank", Order = 389)]
        public int? InterceptionsPerTargetRank { get; set; }

        [DataMember(Name = "CoverageRating", Order = 390)]
        public decimal? CoverageRating { get; set; }

        [DataMember(Name = "CoverageRatingRank", Order = 391)]
        public int? CoverageRatingRank { get; set; }

        [DataMember(Name = "RunPlayStops", Order = 392)]
        public decimal? RunPlayStops { get; set; }

        [DataMember(Name = "RunPlayStopsRank", Order = 393)]
        public int? RunPlayStopsRank { get; set; }

        [DataMember(Name = "TargetsAllowedPerGame", Order = 394)]
        public decimal? TargetsAllowedPerGame { get; set; }

        [DataMember(Name = "TargetsAllowedPerGameRank", Order = 395)]
        public int? TargetsAllowedPerGameRank { get; set; }

        [DataMember(Name = "ReceptionsAllowedPerGame", Order = 396)]
        public decimal? ReceptionsAllowedPerGame { get; set; }

        [DataMember(Name = "ReceptionsAllowedPerGameRank", Order = 397)]
        public int? ReceptionsAllowedPerGameRank { get; set; }

        [DataMember(Name = "TargetRate", Order = 398)]
        public decimal? TargetRate { get; set; }

        [DataMember(Name = "TargetRateRank", Order = 399)]
        public int? TargetRateRank { get; set; }

        [DataMember(Name = "BurnRateRank", Order = 400)]
        public int? BurnRateRank { get; set; }

        [DataMember(Name = "AverageCushion", Order = 401)]
        public decimal? AverageCushion { get; set; }

        [DataMember(Name = "AverageCushionRank", Order = 402)]
        public int? AverageCushionRank { get; set; }

        [DataMember(Name = "YardsPerTargetAllowed", Order = 403)]
        public decimal? YardsPerTargetAllowed { get; set; }

        [DataMember(Name = "YardsPerTargetAllowedRank", Order = 404)]
        public int? YardsPerTargetAllowedRank { get; set; }

        [DataMember(Name = "RoutesDefended", Order = 405)]
        public decimal? RoutesDefended { get; set; }

        [DataMember(Name = "RoutesDefendedRank", Order = 406)]
        public int? RoutesDefendedRank { get; set; }

        [DataMember(Name = "RoutesDefendedPerGame", Order = 407)]
        public decimal? RoutesDefendedPerGame { get; set; }

        [DataMember(Name = "RoutesDefendedPerGameRank", Order = 408)]
        public int? RoutesDefendedPerGameRank { get; set; }

        [DataMember(Name = "FantasyPoints", Order = 409)]
        public decimal? FantasyPoints { get; set; }

        [DataMember(Name = "FantasyPointsPerAttempt", Order = 410)]
        public decimal? FantasyPointsPerAttempt { get; set; }

        [DataMember(Name = "FantasyPointsPerAttemptRank", Order = 411)]
        public int? FantasyPointsPerAttemptRank { get; set; }

        [DataMember(Name = "FantasyPointsPerDropBack", Order = 412)]
        public decimal? FantasyPointsPerDropBack { get; set; }

        [DataMember(Name = "FantasyPointsPerDropBackRank", Order = 413)]
        public int? FantasyPointsPerDropBackRank { get; set; }

        [DataMember(Name = "FantasyPointsPerGame", Order = 414)]
        public decimal? FantasyPointsPerGame { get; set; }

        [DataMember(Name = "FantasyPointsPerGameDifferential", Order = 415)]
        public decimal? FantasyPointsPerGameDifferential { get; set; }

        [DataMember(Name = "FantasyPointsPerGameRank", Order = 416)]
        public int? FantasyPointsPerGameRank { get; set; }

        [DataMember(Name = "FantasyPointsPerOpportunity", Order = 417)]
        public decimal? FantasyPointsPerOpportunity { get; set; }

        [DataMember(Name = "FantasyPointsPerOpportunityRank", Order = 418)]
        public int? FantasyPointsPerOpportunityRank { get; set; }

        [DataMember(Name = "FantasyPointsPerSnap", Order = 419)]
        public decimal? FantasyPointsPerSnap { get; set; }

        [DataMember(Name = "FantasyPointsPerSnapRank", Order = 420)]
        public int? FantasyPointsPerSnapRank { get; set; }

        [DataMember(Name = "FantasyPointsPerPassRoute", Order = 421)]
        public decimal? FantasyPointsPerPassRoute { get; set; }

        [DataMember(Name = "FantasyPointsPerPassRouteRank", Order = 422)]
        public int? FantasyPointsPerPassRouteRank { get; set; }

        [DataMember(Name = "FantasyPointsPerTarget", Order = 423)]
        public decimal? FantasyPointsPerTarget { get; set; }

        [DataMember(Name = "FantasyPointsPerTargetRank", Order = 424)]
        public int? FantasyPointsPerTargetRank { get; set; }

        [DataMember(Name = "SlotFantasyPoints", Order = 425)]
        public decimal? SlotFantasyPoints { get; set; }

        [DataMember(Name = "SlotFantasyPointsRank", Order = 426)]
        public int? SlotFantasyPointsRank { get; set; }

        [DataMember(Name = "SlotFantasyPointsPerGame", Order = 427)]
        public decimal? SlotFantasyPointsPerGame { get; set; }

        [DataMember(Name = "SlotFantasyPointsPerGameRank", Order = 428)]
        public int? SlotFantasyPointsPerGameRank { get; set; }

        [DataMember(Name = "SlotFantasyPointsPerTarget", Order = 429)]
        public decimal? SlotFantasyPointsPerTarget { get; set; }

        [DataMember(Name = "SlotFantasyPointsPerTargetRank", Order = 430)]
        public int? SlotFantasyPointsPerTargetRank { get; set; }

        [DataMember(Name = "FantasyPointsAllowed", Order = 431)]
        public decimal? FantasyPointsAllowed { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerTarget", Order = 432)]
        public decimal? FantasyPointsAllowedPerTarget { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerTargetRank", Order = 433)]
        public int? FantasyPointsAllowedPerTargetRank { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerGame", Order = 434)]
        public decimal? FantasyPointsAllowedPerGame { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerGameRank", Order = 435)]
        public int? FantasyPointsAllowedPerGameRank { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerSnap", Order = 436)]
        public decimal? FantasyPointsAllowedPerSnap { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerSnapRank", Order = 437)]
        public int? FantasyPointsAllowedPerSnapRank { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerCoverSnap", Order = 438)]
        public decimal? FantasyPointsAllowedPerCoverSnap { get; set; }

        [DataMember(Name = "FantasyPointsAllowedPerCoverSnapRank", Order = 439)]
        public int? FantasyPointsAllowedPerCoverSnapRank { get; set; }

        [DataMember(Name = "ExpectedFantasyPoints", Order = 440)]
        public decimal? ExpectedFantasyPoints { get; set; }

        [DataMember(Name = "ExpectedFantasyPointsRank", Order = 441)]
        public int? ExpectedFantasyPointsRank { get; set; }

        [DataMember(Name = "ExpectedFantasyPointsPerGame", Order = 442)]
        public decimal? ExpectedFantasyPointsPerGame { get; set; }

        [DataMember(Name = "ExpectedFantasyPointsPerGameRank", Order = 443)]
        public int? ExpectedFantasyPointsPerGameRank { get; set; }

        [DataMember(Name = "NormalizedFantasyPointsPerGame", Order = 444)]
        public decimal? NormalizedFantasyPointsPerGame { get; set; }

        [DataMember(Name = "NormalizedFantasyPointsPerGameRank", Order = 445)]
        public int? NormalizedFantasyPointsPerGameRank { get; set; }

    }
}

