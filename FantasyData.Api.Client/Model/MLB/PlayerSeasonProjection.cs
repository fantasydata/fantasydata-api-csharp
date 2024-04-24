using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="PlayerSeasonProjection")]
    [Serializable]
    public partial class PlayerSeasonProjection
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The MLB regular season for which these totals apply
        /// </summary>
        [Description("The MLB regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Player's position in the starting lineup (if started), otherwise the position he substituted for
        /// </summary>
        [Description("Player's position in the starting lineup (if started), otherwise the position he substituted for")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// Abbreviation of the player's position (P, C, 1B, OF, etc.)
        /// </summary>
        [Description("Abbreviation of the player's position (P, C, 1B, OF, etc.)")]
        [DataMember(Name = "PositionCategory", Order = 9)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Number of games started
        /// </summary>
        [Description("Number of games started")]
        [DataMember(Name = "Started", Order = 10)]
        public int? Started { get; set; }

        /// <summary>
        /// Number in the batting order (1,2,3, etc.)
        /// </summary>
        [Description("Number in the batting order (1,2,3, etc.)")]
        [DataMember(Name = "BattingOrder", Order = 11)]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 12)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The average draft position of the player
        /// </summary>
        [Description("The average draft position of the player")]
        [DataMember(Name = "AverageDraftPosition", Order = 13)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The auction value for this player as it pertains to auction-style drafts for season-long fantasy baseball.
        /// </summary>
        [Description("The auction value for this player as it pertains to auction-style drafts for season-long fantasy baseball.")]
        [DataMember(Name = "AuctionValue", Order = 14)]
        public int? AuctionValue { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 15)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 16)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 17)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// At bats while hitting
        /// </summary>
        [Description("At bats while hitting")]
        [DataMember(Name = "AtBats", Order = 18)]
        public decimal? AtBats { get; set; }

        /// <summary>
        /// Total runs scored.
        /// </summary>
        [Description("Total runs scored.")]
        [DataMember(Name = "Runs", Order = 19)]
        public decimal? Runs { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 20)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total singles
        /// </summary>
        [Description("Total singles")]
        [DataMember(Name = "Singles", Order = 21)]
        public decimal? Singles { get; set; }

        /// <summary>
        /// Total doubles
        /// </summary>
        [Description("Total doubles")]
        [DataMember(Name = "Doubles", Order = 22)]
        public decimal? Doubles { get; set; }

        /// <summary>
        /// Total triples
        /// </summary>
        [Description("Total triples")]
        [DataMember(Name = "Triples", Order = 23)]
        public decimal? Triples { get; set; }

        /// <summary>
        /// Total home runs
        /// </summary>
        [Description("Total home runs")]
        [DataMember(Name = "HomeRuns", Order = 24)]
        public decimal? HomeRuns { get; set; }

        /// <summary>
        /// Total runs batted in
        /// </summary>
        [Description("Total runs batted in")]
        [DataMember(Name = "RunsBattedIn", Order = 25)]
        public decimal? RunsBattedIn { get; set; }

        /// <summary>
        /// Total batting average
        /// </summary>
        [Description("Total batting average")]
        [DataMember(Name = "BattingAverage", Order = 26)]
        public decimal? BattingAverage { get; set; }

        /// <summary>
        /// Total outs
        /// </summary>
        [Description("Total outs")]
        [DataMember(Name = "Outs", Order = 27)]
        public decimal? Outs { get; set; }

        /// <summary>
        /// Total strikeouts
        /// </summary>
        [Description("Total strikeouts")]
        [DataMember(Name = "Strikeouts", Order = 28)]
        public decimal? Strikeouts { get; set; }

        /// <summary>
        /// Total walks
        /// </summary>
        [Description("Total walks")]
        [DataMember(Name = "Walks", Order = 29)]
        public decimal? Walks { get; set; }

        /// <summary>
        /// Total times hit by pitch
        /// </summary>
        [Description("Total times hit by pitch")]
        [DataMember(Name = "HitByPitch", Order = 30)]
        public decimal? HitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices
        /// </summary>
        [Description("Total sacrifices")]
        [DataMember(Name = "Sacrifices", Order = 31)]
        public decimal? Sacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies
        /// </summary>
        [Description("Total sacrifice flies")]
        [DataMember(Name = "SacrificeFlies", Order = 32)]
        public decimal? SacrificeFlies { get; set; }

        /// <summary>
        /// Total times grounded into double play
        /// </summary>
        [Description("Total times grounded into double play")]
        [DataMember(Name = "GroundIntoDoublePlay", Order = 33)]
        public decimal? GroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total stolen bases
        /// </summary>
        [Description("Total stolen bases")]
        [DataMember(Name = "StolenBases", Order = 34)]
        public decimal? StolenBases { get; set; }

        /// <summary>
        /// Total caught stealing
        /// </summary>
        [Description("Total caught stealing")]
        [DataMember(Name = "CaughtStealing", Order = 35)]
        public decimal? CaughtStealing { get; set; }

        /// <summary>
        /// Total pitches seen
        /// </summary>
        [Description("Total pitches seen")]
        [DataMember(Name = "PitchesSeen", Order = 36)]
        public decimal? PitchesSeen { get; set; }

        /// <summary>
        /// Total on base percentage
        /// </summary>
        [Description("Total on base percentage")]
        [DataMember(Name = "OnBasePercentage", Order = 37)]
        public decimal? OnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage
        /// </summary>
        [Description("Total slugging percentage")]
        [DataMember(Name = "SluggingPercentage", Order = 38)]
        public decimal? SluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus percentage 
        /// </summary>
        [Description("Total on base plus percentage ")]
        [DataMember(Name = "OnBasePlusSlugging", Order = 39)]
        public decimal? OnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total errors
        /// </summary>
        [Description("Total errors")]
        [DataMember(Name = "Errors", Order = 40)]
        public decimal? Errors { get; set; }

        /// <summary>
        /// Total wins by the team/player
        /// </summary>
        [Description("Total wins by the team/player")]
        [DataMember(Name = "Wins", Order = 41)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Total losses by the team/player
        /// </summary>
        [Description("Total losses by the team/player")]
        [DataMember(Name = "Losses", Order = 42)]
        public decimal? Losses { get; set; }

        /// <summary>
        /// Total saves by team/player
        /// </summary>
        [Description("Total saves by team/player")]
        [DataMember(Name = "Saves", Order = 43)]
        public decimal? Saves { get; set; }

        /// <summary>
        /// Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)
        /// </summary>
        [Description("Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)")]
        [DataMember(Name = "InningsPitchedDecimal", Order = 44)]
        public decimal? InningsPitchedDecimal { get; set; }

        /// <summary>
        /// Total outs pitched by team/player
        /// </summary>
        [Description("Total outs pitched by team/player")]
        [DataMember(Name = "TotalOutsPitched", Order = 45)]
        public decimal? TotalOutsPitched { get; set; }

        /// <summary>
        /// Total full innings pitched (e.g. 6, 71, 89, etc)
        /// </summary>
        [Description("Total full innings pitched (e.g. 6, 71, 89, etc)")]
        [DataMember(Name = "InningsPitchedFull", Order = 46)]
        public decimal? InningsPitchedFull { get; set; }

        /// <summary>
        /// Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)
        /// </summary>
        [Description("Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)")]
        [DataMember(Name = "InningsPitchedOuts", Order = 47)]
        public decimal? InningsPitchedOuts { get; set; }

        /// <summary>
        /// Total earned run average by team/player
        /// </summary>
        [Description("Total earned run average by team/player")]
        [DataMember(Name = "EarnedRunAverage", Order = 48)]
        public decimal? EarnedRunAverage { get; set; }

        /// <summary>
        /// Hits allowed while pitching
        /// </summary>
        [Description("Hits allowed while pitching")]
        [DataMember(Name = "PitchingHits", Order = 49)]
        public decimal? PitchingHits { get; set; }

        /// <summary>
        /// Runs allowed while pitching
        /// </summary>
        [Description("Runs allowed while pitching")]
        [DataMember(Name = "PitchingRuns", Order = 50)]
        public decimal? PitchingRuns { get; set; }

        /// <summary>
        /// Earned runs allowed while pitching
        /// </summary>
        [Description("Earned runs allowed while pitching")]
        [DataMember(Name = "PitchingEarnedRuns", Order = 51)]
        public decimal? PitchingEarnedRuns { get; set; }

        /// <summary>
        /// Walks allowed while pitching
        /// </summary>
        [Description("Walks allowed while pitching")]
        [DataMember(Name = "PitchingWalks", Order = 52)]
        public decimal? PitchingWalks { get; set; }

        /// <summary>
        /// Strikeouts allowed while pitching
        /// </summary>
        [Description("Strikeouts allowed while pitching")]
        [DataMember(Name = "PitchingStrikeouts", Order = 53)]
        public decimal? PitchingStrikeouts { get; set; }

        /// <summary>
        /// Home runs allowed while pitching
        /// </summary>
        [Description("Home runs allowed while pitching")]
        [DataMember(Name = "PitchingHomeRuns", Order = 54)]
        public decimal? PitchingHomeRuns { get; set; }

        /// <summary>
        /// Total pitches thrown while pitching
        /// </summary>
        [Description("Total pitches thrown while pitching")]
        [DataMember(Name = "PitchesThrown", Order = 55)]
        public decimal? PitchesThrown { get; set; }

        /// <summary>
        /// Total pitches thrown for strikes while pitching
        /// </summary>
        [Description("Total pitches thrown for strikes while pitching")]
        [DataMember(Name = "PitchesThrownStrikes", Order = 56)]
        public decimal? PitchesThrownStrikes { get; set; }

        /// <summary>
        /// Walks plus hits per innings pitched (WHIP) while pitching
        /// </summary>
        [Description("Walks plus hits per innings pitched (WHIP) while pitching")]
        [DataMember(Name = "WalksHitsPerInningsPitched", Order = 57)]
        public decimal? WalksHitsPerInningsPitched { get; set; }

        /// <summary>
        /// Total batting average against (BAA) while pitching
        /// </summary>
        [Description("Total batting average against (BAA) while pitching")]
        [DataMember(Name = "PitchingBattingAverageAgainst", Order = 58)]
        public decimal? PitchingBattingAverageAgainst { get; set; }

        /// <summary>
        /// Total grand slams
        /// </summary>
        [Description("Total grand slams")]
        [DataMember(Name = "GrandSlams", Order = 59)]
        public decimal? GrandSlams { get; set; }

        /// <summary>
        /// Total FanDuel fantasy points
        /// </summary>
        [Description("Total FanDuel fantasy points")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 60)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points
        /// </summary>
        [Description("Total DraftKings fantasy points")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 61)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points
        /// </summary>
        [Description("Total Yahoo fantasy points")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 62)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total plate appearances
        /// </summary>
        [Description("Total plate appearances")]
        [DataMember(Name = "PlateAppearances", Order = 63)]
        public decimal? PlateAppearances { get; set; }

        /// <summary>
        /// Number of total bases
        /// </summary>
        [Description("Number of total bases")]
        [DataMember(Name = "TotalBases", Order = 64)]
        public decimal? TotalBases { get; set; }

        /// <summary>
        /// Total fly outs
        /// </summary>
        [Description("Total fly outs")]
        [DataMember(Name = "FlyOuts", Order = 65)]
        public decimal? FlyOuts { get; set; }

        /// <summary>
        /// Total ground outs
        /// </summary>
        [Description("Total ground outs")]
        [DataMember(Name = "GroundOuts", Order = 66)]
        public decimal? GroundOuts { get; set; }

        /// <summary>
        /// Total line outs
        /// </summary>
        [Description("Total line outs")]
        [DataMember(Name = "LineOuts", Order = 67)]
        public decimal? LineOuts { get; set; }

        /// <summary>
        /// Total pop outs
        /// </summary>
        [Description("Total pop outs")]
        [DataMember(Name = "PopOuts", Order = 68)]
        public decimal? PopOuts { get; set; }

        /// <summary>
        /// Total intentional walks
        /// </summary>
        [Description("Total intentional walks")]
        [DataMember(Name = "IntentionalWalks", Order = 69)]
        public decimal? IntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error
        /// </summary>
        [Description("Total times reached on error")]
        [DataMember(Name = "ReachedOnError", Order = 70)]
        public decimal? ReachedOnError { get; set; }

        /// <summary>
        /// Total balls in play
        /// </summary>
        [Description("Total balls in play")]
        [DataMember(Name = "BallsInPlay", Order = 71)]
        public decimal? BallsInPlay { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP)
        /// </summary>
        [Description("Total batting average on balls in play (BABIP)")]
        [DataMember(Name = "BattingAverageOnBallsInPlay", Order = 72)]
        public decimal? BattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weight on base percentage
        /// </summary>
        [Description("Total weight on base percentage")]
        [DataMember(Name = "WeightedOnBasePercentage", Order = 73)]
        public decimal? WeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total singles allowed while pitching
        /// </summary>
        [Description("Total singles allowed while pitching")]
        [DataMember(Name = "PitchingSingles", Order = 74)]
        public decimal? PitchingSingles { get; set; }

        /// <summary>
        /// Total doubles allowed while pitching
        /// </summary>
        [Description("Total doubles allowed while pitching")]
        [DataMember(Name = "PitchingDoubles", Order = 75)]
        public decimal? PitchingDoubles { get; set; }

        /// <summary>
        /// Total triples allowed while pitching
        /// </summary>
        [Description("Total triples allowed while pitching")]
        [DataMember(Name = "PitchingTriples", Order = 76)]
        public decimal? PitchingTriples { get; set; }

        /// <summary>
        /// Total grand slams allowed while pitching
        /// </summary>
        [Description("Total grand slams allowed while pitching")]
        [DataMember(Name = "PitchingGrandSlams", Order = 77)]
        public decimal? PitchingGrandSlams { get; set; }

        /// <summary>
        /// Total batters hit by pitch while pitching
        /// </summary>
        [Description("Total batters hit by pitch while pitching")]
        [DataMember(Name = "PitchingHitByPitch", Order = 78)]
        public decimal? PitchingHitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices while pitching
        /// </summary>
        [Description("Total sacrifices while pitching")]
        [DataMember(Name = "PitchingSacrifices", Order = 79)]
        public decimal? PitchingSacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies while pitching
        /// </summary>
        [Description("Total sacrifice flies while pitching")]
        [DataMember(Name = "PitchingSacrificeFlies", Order = 80)]
        public decimal? PitchingSacrificeFlies { get; set; }

        /// <summary>
        /// Total grounded into double plays while pitching
        /// </summary>
        [Description("Total grounded into double plays while pitching")]
        [DataMember(Name = "PitchingGroundIntoDoublePlay", Order = 81)]
        public decimal? PitchingGroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total complete games while pitching
        /// </summary>
        [Description("Total complete games while pitching")]
        [DataMember(Name = "PitchingCompleteGames", Order = 82)]
        public decimal? PitchingCompleteGames { get; set; }

        /// <summary>
        /// Total shuouts while pitching
        /// </summary>
        [Description("Total shuouts while pitching")]
        [DataMember(Name = "PitchingShutOuts", Order = 83)]
        public decimal? PitchingShutOuts { get; set; }

        /// <summary>
        /// Total no hitters while pitching
        /// </summary>
        [Description("Total no hitters while pitching")]
        [DataMember(Name = "PitchingNoHitters", Order = 84)]
        public decimal? PitchingNoHitters { get; set; }

        /// <summary>
        /// Total perfect games while pitching
        /// </summary>
        [Description("Total perfect games while pitching")]
        [DataMember(Name = "PitchingPerfectGames", Order = 85)]
        public decimal? PitchingPerfectGames { get; set; }

        /// <summary>
        /// Total plate appearances while pitching
        /// </summary>
        [Description("Total plate appearances while pitching")]
        [DataMember(Name = "PitchingPlateAppearances", Order = 86)]
        public decimal? PitchingPlateAppearances { get; set; }

        /// <summary>
        /// Total bases while pitching
        /// </summary>
        [Description("Total bases while pitching")]
        [DataMember(Name = "PitchingTotalBases", Order = 87)]
        public decimal? PitchingTotalBases { get; set; }

        /// <summary>
        /// Total fly outs while pitching
        /// </summary>
        [Description("Total fly outs while pitching")]
        [DataMember(Name = "PitchingFlyOuts", Order = 88)]
        public decimal? PitchingFlyOuts { get; set; }

        /// <summary>
        /// Total ground outs while pitching
        /// </summary>
        [Description("Total ground outs while pitching")]
        [DataMember(Name = "PitchingGroundOuts", Order = 89)]
        public decimal? PitchingGroundOuts { get; set; }

        /// <summary>
        /// Total line outs while pitching
        /// </summary>
        [Description("Total line outs while pitching")]
        [DataMember(Name = "PitchingLineOuts", Order = 90)]
        public decimal? PitchingLineOuts { get; set; }

        /// <summary>
        /// Total pop outs while pitching
        /// </summary>
        [Description("Total pop outs while pitching")]
        [DataMember(Name = "PitchingPopOuts", Order = 91)]
        public decimal? PitchingPopOuts { get; set; }

        /// <summary>
        /// Total intentional walks while pitching
        /// </summary>
        [Description("Total intentional walks while pitching")]
        [DataMember(Name = "PitchingIntentionalWalks", Order = 92)]
        public decimal? PitchingIntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error while pitching
        /// </summary>
        [Description("Total times reached on error while pitching")]
        [DataMember(Name = "PitchingReachedOnError", Order = 93)]
        public decimal? PitchingReachedOnError { get; set; }

        /// <summary>
        /// Total catchers interference while pitching
        /// </summary>
        [Description("Total catchers interference while pitching")]
        [DataMember(Name = "PitchingCatchersInterference", Order = 94)]
        public decimal? PitchingCatchersInterference { get; set; }

        /// <summary>
        /// Total balls in play while pitching
        /// </summary>
        [Description("Total balls in play while pitching")]
        [DataMember(Name = "PitchingBallsInPlay", Order = 95)]
        public decimal? PitchingBallsInPlay { get; set; }

        /// <summary>
        /// Total on base percentage (OBP) while pitching
        /// </summary>
        [Description("Total on base percentage (OBP) while pitching")]
        [DataMember(Name = "PitchingOnBasePercentage", Order = 96)]
        public decimal? PitchingOnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage (SLG) while pitching
        /// </summary>
        [Description("Total slugging percentage (SLG) while pitching")]
        [DataMember(Name = "PitchingSluggingPercentage", Order = 97)]
        public decimal? PitchingSluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus slugging (OPS) while pitching
        /// </summary>
        [Description("Total on base plus slugging (OPS) while pitching")]
        [DataMember(Name = "PitchingOnBasePlusSlugging", Order = 98)]
        public decimal? PitchingOnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total strikeouts per nine innings (K/9) while pitching
        /// </summary>
        [Description("Total strikeouts per nine innings (K/9) while pitching")]
        [DataMember(Name = "PitchingStrikeoutsPerNineInnings", Order = 99)]
        public decimal? PitchingStrikeoutsPerNineInnings { get; set; }

        /// <summary>
        /// Total walks per nine innings (BB/9) while pitching
        /// </summary>
        [Description("Total walks per nine innings (BB/9) while pitching")]
        [DataMember(Name = "PitchingWalksPerNineInnings", Order = 100)]
        public decimal? PitchingWalksPerNineInnings { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP) while pitching
        /// </summary>
        [Description("Total batting average on balls in play (BABIP) while pitching")]
        [DataMember(Name = "PitchingBattingAverageOnBallsInPlay", Order = 101)]
        public decimal? PitchingBattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weighted on base percentage while pitching 
        /// </summary>
        [Description("Total weighted on base percentage while pitching ")]
        [DataMember(Name = "PitchingWeightedOnBasePercentage", Order = 102)]
        public decimal? PitchingWeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total double plays, defined as one of: Bunted into Double Play, Fly into Double Play, Fouled into Double Play, Ground into Double Pla,y Line into Double Play, Popped into Double Play
        /// </summary>
        [Description("Total double plays, defined as one of: Bunted into Double Play, Fly into Double Play, Fouled into Double Play, Ground into Double Pla,y Line into Double Play, Popped into Double Play")]
        [DataMember(Name = "DoublePlays", Order = 103)]
        public decimal? DoublePlays { get; set; }

        /// <summary>
        /// Total double plays while pitching
        /// </summary>
        [Description("Total double plays while pitching")]
        [DataMember(Name = "PitchingDoublePlays", Order = 104)]
        public decimal? PitchingDoublePlays { get; set; }

        /// <summary>
        /// Whether the batting order is confirmed (true/false)
        /// </summary>
        [Description("Whether the batting order is confirmed (true/false)")]
        [DataMember(Name = "BattingOrderConfirmed", Order = 105)]
        public bool? BattingOrderConfirmed { get; set; }

        /// <summary>
        /// Total isolated power (ISO)
        /// </summary>
        [Description("Total isolated power (ISO)")]
        [DataMember(Name = "IsolatedPower", Order = 106)]
        public decimal? IsolatedPower { get; set; }

        /// <summary>
        /// Total fielding independent pitching (FIP)
        /// </summary>
        [Description("Total fielding independent pitching (FIP)")]
        [DataMember(Name = "FieldingIndependentPitching", Order = 107)]
        public decimal? FieldingIndependentPitching { get; set; }

        /// <summary>
        /// Total quality starts pitched
        /// </summary>
        [Description("Total quality starts pitched")]
        [DataMember(Name = "PitchingQualityStarts", Order = 108)]
        public decimal? PitchingQualityStarts { get; set; }

        /// <summary>
        /// The inning that the pitcher entered the game (if any).
        /// </summary>
        [Description("The inning that the pitcher entered the game (if any).")]
        [DataMember(Name = "PitchingInningStarted", Order = 109)]
        public int? PitchingInningStarted { get; set; }

        /// <summary>
        /// Total left on base percentage 
        /// </summary>
        [Description("Total left on base percentage ")]
        [DataMember(Name = "LeftOnBase", Order = 110)]
        public decimal? LeftOnBase { get; set; }

        /// <summary>
        /// Total holds pitched
        /// </summary>
        [Description("Total holds pitched")]
        [DataMember(Name = "PitchingHolds", Order = 111)]
        public decimal? PitchingHolds { get; set; }

        /// <summary>
        /// Total blown saves pitched
        /// </summary>
        [Description("Total blown saves pitched")]
        [DataMember(Name = "PitchingBlownSaves", Order = 112)]
        public decimal? PitchingBlownSaves { get; set; }

        /// <summary>
        /// The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)
        /// </summary>
        [Description("The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)")]
        [DataMember(Name = "SubstituteBattingOrder", Order = 113)]
        public int? SubstituteBattingOrder { get; set; }

        /// <summary>
        /// The sequence in which this player was substituted into the game, within the particular batting order
        /// </summary>
        [Description("The sequence in which this player was substituted into the game, within the particular batting order")]
        [DataMember(Name = "SubstituteBattingOrderSequence", Order = 114)]
        public int? SubstituteBattingOrderSequence { get; set; }

        /// <summary>
        /// Total FantasyDraft fantasy points
        /// </summary>
        [Description("Total FantasyDraft fantasy points")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 115)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// Total batting fantasy points
        /// </summary>
        [Description("Total batting fantasy points")]
        [DataMember(Name = "FantasyPointsBatting", Order = 116)]
        public decimal? FantasyPointsBatting { get; set; }

        /// <summary>
        /// Total pitching fantasy points
        /// </summary>
        [Description("Total pitching fantasy points")]
        [DataMember(Name = "FantasyPointsPitching", Order = 117)]
        public decimal? FantasyPointsPitching { get; set; }

    }
}

