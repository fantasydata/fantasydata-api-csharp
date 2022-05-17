using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="PlayerGame")]
    [Serializable]
    public partial class PlayerGame
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)
        /// </summary>
        [Description("The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
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
        /// The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The category (P, C, 1B, OF, SS) of the players position
        /// </summary>
        [Description("The category (P, C, 1B, OF, SS) of the players position")]
        [DataMember(Name = "PositionCategory", Order = 9)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Whether the player started
        /// </summary>
        [Description("Whether the player started")]
        [DataMember(Name = "Started", Order = 10)]
        public int? Started { get; set; }

        /// <summary>
        /// Where the player batted in the line up (1,2,3, etc.)
        /// </summary>
        [Description("Where the player batted in the line up (1,2,3, etc.)")]
        [DataMember(Name = "BattingOrder", Order = 11)]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// The player's salary for FanDuel daily fantasy contests.
        /// </summary>
        [Description("The player's salary for FanDuel daily fantasy contests.")]
        [DataMember(Name = "FanDuelSalary", Order = 12)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The player's salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The player's salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 13)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The player's salary as calculated by SportsDataIO (formerly known as FantasyData).  Based on the same salary cap as DraftKings contests ($50,000).
        /// </summary>
        [Description("The player's salary as calculated by SportsDataIO (formerly known as FantasyData).  Based on the same salary cap as DraftKings contests ($50,000).")]
        [DataMember(Name = "FantasyDataSalary", Order = 14)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 15)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out, 7 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List
        /// </summary>
        [Description("Indicates the player's injury status. Possible values include: Probable, Questionable, Doubtful, Out, 7 Day Disabled List, 15 Day Disabled List, 60 Day Disabled List")]
        [DataMember(Name = "InjuryStatus", Order = 16)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 17)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 18)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability.
        /// </summary>
        [Description("Brief description of the player's injury and expected availability.")]
        [DataMember(Name = "InjuryNotes", Order = 19)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelPosition", Order = 20)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsPosition", Order = 21)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooPosition", Order = 22)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentRank", Order = 23)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentPositionRank", Order = 24)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 25)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's salary for Fantasy Draft daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Fantasy Draft daily fantasy contests.")]
        [DataMember(Name = "FantasyDraftSalary", Order = 26)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// The player's eligible position in Fantasy Drafts daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Fantasy Drafts daily fantasy sports platform.")]
        [DataMember(Name = "FantasyDraftPosition", Order = 27)]
        public string FantasyDraftPosition { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 28)]
        public int? GameID { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentID", Order = 29)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 30)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 31)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 32)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 33)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 34)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 35)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 36)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 37)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 38)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 39)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// At bats while hitting
        /// </summary>
        [Description("At bats while hitting")]
        [DataMember(Name = "AtBats", Order = 40)]
        public decimal? AtBats { get; set; }

        /// <summary>
        /// Total runs scored.
        /// </summary>
        [Description("Total runs scored.")]
        [DataMember(Name = "Runs", Order = 41)]
        public decimal? Runs { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 42)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total singles
        /// </summary>
        [Description("Total singles")]
        [DataMember(Name = "Singles", Order = 43)]
        public decimal? Singles { get; set; }

        /// <summary>
        /// Total doubles
        /// </summary>
        [Description("Total doubles")]
        [DataMember(Name = "Doubles", Order = 44)]
        public decimal? Doubles { get; set; }

        /// <summary>
        /// Total triples
        /// </summary>
        [Description("Total triples")]
        [DataMember(Name = "Triples", Order = 45)]
        public decimal? Triples { get; set; }

        /// <summary>
        /// Total home runs
        /// </summary>
        [Description("Total home runs")]
        [DataMember(Name = "HomeRuns", Order = 46)]
        public decimal? HomeRuns { get; set; }

        /// <summary>
        /// Total runs batted in
        /// </summary>
        [Description("Total runs batted in")]
        [DataMember(Name = "RunsBattedIn", Order = 47)]
        public decimal? RunsBattedIn { get; set; }

        /// <summary>
        /// Total batting average
        /// </summary>
        [Description("Total batting average")]
        [DataMember(Name = "BattingAverage", Order = 48)]
        public decimal? BattingAverage { get; set; }

        /// <summary>
        /// Total outs
        /// </summary>
        [Description("Total outs")]
        [DataMember(Name = "Outs", Order = 49)]
        public decimal? Outs { get; set; }

        /// <summary>
        /// Total strikeouts
        /// </summary>
        [Description("Total strikeouts")]
        [DataMember(Name = "Strikeouts", Order = 50)]
        public decimal? Strikeouts { get; set; }

        /// <summary>
        /// Total walks
        /// </summary>
        [Description("Total walks")]
        [DataMember(Name = "Walks", Order = 51)]
        public decimal? Walks { get; set; }

        /// <summary>
        /// Total times hit by pitch
        /// </summary>
        [Description("Total times hit by pitch")]
        [DataMember(Name = "HitByPitch", Order = 52)]
        public decimal? HitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices
        /// </summary>
        [Description("Total sacrifices")]
        [DataMember(Name = "Sacrifices", Order = 53)]
        public decimal? Sacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies
        /// </summary>
        [Description("Total sacrifice flies")]
        [DataMember(Name = "SacrificeFlies", Order = 54)]
        public decimal? SacrificeFlies { get; set; }

        /// <summary>
        /// Total times grounded into double play
        /// </summary>
        [Description("Total times grounded into double play")]
        [DataMember(Name = "GroundIntoDoublePlay", Order = 55)]
        public decimal? GroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total stolen bases
        /// </summary>
        [Description("Total stolen bases")]
        [DataMember(Name = "StolenBases", Order = 56)]
        public decimal? StolenBases { get; set; }

        /// <summary>
        /// Total caught stealing
        /// </summary>
        [Description("Total caught stealing")]
        [DataMember(Name = "CaughtStealing", Order = 57)]
        public decimal? CaughtStealing { get; set; }

        /// <summary>
        /// Total pitches seen
        /// </summary>
        [Description("Total pitches seen")]
        [DataMember(Name = "PitchesSeen", Order = 58)]
        public decimal? PitchesSeen { get; set; }

        /// <summary>
        /// Total on base percentage
        /// </summary>
        [Description("Total on base percentage")]
        [DataMember(Name = "OnBasePercentage", Order = 59)]
        public decimal? OnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage
        /// </summary>
        [Description("Total slugging percentage")]
        [DataMember(Name = "SluggingPercentage", Order = 60)]
        public decimal? SluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus percentage 
        /// </summary>
        [Description("Total on base plus percentage ")]
        [DataMember(Name = "OnBasePlusSlugging", Order = 61)]
        public decimal? OnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total errors
        /// </summary>
        [Description("Total errors")]
        [DataMember(Name = "Errors", Order = 62)]
        public decimal? Errors { get; set; }

        /// <summary>
        /// Total wins by the team/player
        /// </summary>
        [Description("Total wins by the team/player")]
        [DataMember(Name = "Wins", Order = 63)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Total losses by the team/player
        /// </summary>
        [Description("Total losses by the team/player")]
        [DataMember(Name = "Losses", Order = 64)]
        public decimal? Losses { get; set; }

        /// <summary>
        /// Total saves by team/player
        /// </summary>
        [Description("Total saves by team/player")]
        [DataMember(Name = "Saves", Order = 65)]
        public decimal? Saves { get; set; }

        /// <summary>
        /// Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)
        /// </summary>
        [Description("Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)")]
        [DataMember(Name = "InningsPitchedDecimal", Order = 66)]
        public decimal? InningsPitchedDecimal { get; set; }

        /// <summary>
        /// Total outs pitched by team/player
        /// </summary>
        [Description("Total outs pitched by team/player")]
        [DataMember(Name = "TotalOutsPitched", Order = 67)]
        public decimal? TotalOutsPitched { get; set; }

        /// <summary>
        /// Total full innings pitched (e.g. 6, 71, 89, etc)
        /// </summary>
        [Description("Total full innings pitched (e.g. 6, 71, 89, etc)")]
        [DataMember(Name = "InningsPitchedFull", Order = 68)]
        public decimal? InningsPitchedFull { get; set; }

        /// <summary>
        /// Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)
        /// </summary>
        [Description("Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)")]
        [DataMember(Name = "InningsPitchedOuts", Order = 69)]
        public decimal? InningsPitchedOuts { get; set; }

        /// <summary>
        /// Total earned run average by team/player
        /// </summary>
        [Description("Total earned run average by team/player")]
        [DataMember(Name = "EarnedRunAverage", Order = 70)]
        public decimal? EarnedRunAverage { get; set; }

        /// <summary>
        /// Hits allowed while pitching
        /// </summary>
        [Description("Hits allowed while pitching")]
        [DataMember(Name = "PitchingHits", Order = 71)]
        public decimal? PitchingHits { get; set; }

        /// <summary>
        /// Runs allowed while pitching
        /// </summary>
        [Description("Runs allowed while pitching")]
        [DataMember(Name = "PitchingRuns", Order = 72)]
        public decimal? PitchingRuns { get; set; }

        /// <summary>
        /// Earned runs allowed while pitching
        /// </summary>
        [Description("Earned runs allowed while pitching")]
        [DataMember(Name = "PitchingEarnedRuns", Order = 73)]
        public decimal? PitchingEarnedRuns { get; set; }

        /// <summary>
        /// Walks allowed while pitching
        /// </summary>
        [Description("Walks allowed while pitching")]
        [DataMember(Name = "PitchingWalks", Order = 74)]
        public decimal? PitchingWalks { get; set; }

        /// <summary>
        /// Strikeouts allowed while pitching
        /// </summary>
        [Description("Strikeouts allowed while pitching")]
        [DataMember(Name = "PitchingStrikeouts", Order = 75)]
        public decimal? PitchingStrikeouts { get; set; }

        /// <summary>
        /// Home runs allowed while pitching
        /// </summary>
        [Description("Home runs allowed while pitching")]
        [DataMember(Name = "PitchingHomeRuns", Order = 76)]
        public decimal? PitchingHomeRuns { get; set; }

        /// <summary>
        /// Total pitches thrown while pitching
        /// </summary>
        [Description("Total pitches thrown while pitching")]
        [DataMember(Name = "PitchesThrown", Order = 77)]
        public decimal? PitchesThrown { get; set; }

        /// <summary>
        /// Total pitches thrown for strikes while pitching
        /// </summary>
        [Description("Total pitches thrown for strikes while pitching")]
        [DataMember(Name = "PitchesThrownStrikes", Order = 78)]
        public decimal? PitchesThrownStrikes { get; set; }

        /// <summary>
        /// Walks plus hits per innings pitched (WHIP) while pitching
        /// </summary>
        [Description("Walks plus hits per innings pitched (WHIP) while pitching")]
        [DataMember(Name = "WalksHitsPerInningsPitched", Order = 79)]
        public decimal? WalksHitsPerInningsPitched { get; set; }

        /// <summary>
        /// Total batting average against (BAA) while pitching
        /// </summary>
        [Description("Total batting average against (BAA) while pitching")]
        [DataMember(Name = "PitchingBattingAverageAgainst", Order = 80)]
        public decimal? PitchingBattingAverageAgainst { get; set; }

        /// <summary>
        /// Total grand slams
        /// </summary>
        [Description("Total grand slams")]
        [DataMember(Name = "GrandSlams", Order = 81)]
        public decimal? GrandSlams { get; set; }

        /// <summary>
        /// Total FanDuel fantasy points
        /// </summary>
        [Description("Total FanDuel fantasy points")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 82)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points
        /// </summary>
        [Description("Total DraftKings fantasy points")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 83)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points
        /// </summary>
        [Description("Total Yahoo fantasy points")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 84)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total plate appearances
        /// </summary>
        [Description("Total plate appearances")]
        [DataMember(Name = "PlateAppearances", Order = 85)]
        public decimal? PlateAppearances { get; set; }

        /// <summary>
        /// Number of total bases
        /// </summary>
        [Description("Number of total bases")]
        [DataMember(Name = "TotalBases", Order = 86)]
        public decimal? TotalBases { get; set; }

        /// <summary>
        /// Total fly outs
        /// </summary>
        [Description("Total fly outs")]
        [DataMember(Name = "FlyOuts", Order = 87)]
        public decimal? FlyOuts { get; set; }

        /// <summary>
        /// Total ground outs
        /// </summary>
        [Description("Total ground outs")]
        [DataMember(Name = "GroundOuts", Order = 88)]
        public decimal? GroundOuts { get; set; }

        /// <summary>
        /// Total line outs
        /// </summary>
        [Description("Total line outs")]
        [DataMember(Name = "LineOuts", Order = 89)]
        public decimal? LineOuts { get; set; }

        /// <summary>
        /// Total pop outs
        /// </summary>
        [Description("Total pop outs")]
        [DataMember(Name = "PopOuts", Order = 90)]
        public decimal? PopOuts { get; set; }

        /// <summary>
        /// Total intentional walks
        /// </summary>
        [Description("Total intentional walks")]
        [DataMember(Name = "IntentionalWalks", Order = 91)]
        public decimal? IntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error
        /// </summary>
        [Description("Total times reached on error")]
        [DataMember(Name = "ReachedOnError", Order = 92)]
        public decimal? ReachedOnError { get; set; }

        /// <summary>
        /// Total balls in play
        /// </summary>
        [Description("Total balls in play")]
        [DataMember(Name = "BallsInPlay", Order = 93)]
        public decimal? BallsInPlay { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP
        /// </summary>
        [Description("Total batting average on balls in play (BABIP")]
        [DataMember(Name = "BattingAverageOnBallsInPlay", Order = 94)]
        public decimal? BattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weight on base percentage
        /// </summary>
        [Description("Total weight on base percentage")]
        [DataMember(Name = "WeightedOnBasePercentage", Order = 95)]
        public decimal? WeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total singles allowed while pitching
        /// </summary>
        [Description("Total singles allowed while pitching")]
        [DataMember(Name = "PitchingSingles", Order = 96)]
        public decimal? PitchingSingles { get; set; }

        /// <summary>
        /// Total doubles allowed while pitching
        /// </summary>
        [Description("Total doubles allowed while pitching")]
        [DataMember(Name = "PitchingDoubles", Order = 97)]
        public decimal? PitchingDoubles { get; set; }

        /// <summary>
        /// Total triples allowed while pitching
        /// </summary>
        [Description("Total triples allowed while pitching")]
        [DataMember(Name = "PitchingTriples", Order = 98)]
        public decimal? PitchingTriples { get; set; }

        /// <summary>
        /// Total grand slams allowed while pitching
        /// </summary>
        [Description("Total grand slams allowed while pitching")]
        [DataMember(Name = "PitchingGrandSlams", Order = 99)]
        public decimal? PitchingGrandSlams { get; set; }

        /// <summary>
        /// Total batters hit by pitch while pitching
        /// </summary>
        [Description("Total batters hit by pitch while pitching")]
        [DataMember(Name = "PitchingHitByPitch", Order = 100)]
        public decimal? PitchingHitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices while pitching
        /// </summary>
        [Description("Total sacrifices while pitching")]
        [DataMember(Name = "PitchingSacrifices", Order = 101)]
        public decimal? PitchingSacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies while pitching
        /// </summary>
        [Description("Total sacrifice flies while pitching")]
        [DataMember(Name = "PitchingSacrificeFlies", Order = 102)]
        public decimal? PitchingSacrificeFlies { get; set; }

        /// <summary>
        /// Total grounded into double plays while pitching
        /// </summary>
        [Description("Total grounded into double plays while pitching")]
        [DataMember(Name = "PitchingGroundIntoDoublePlay", Order = 103)]
        public decimal? PitchingGroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total complete games while pitching
        /// </summary>
        [Description("Total complete games while pitching")]
        [DataMember(Name = "PitchingCompleteGames", Order = 104)]
        public decimal? PitchingCompleteGames { get; set; }

        /// <summary>
        /// Total shuouts while pitching
        /// </summary>
        [Description("Total shuouts while pitching")]
        [DataMember(Name = "PitchingShutOuts", Order = 105)]
        public decimal? PitchingShutOuts { get; set; }

        /// <summary>
        /// Total no hitters while pitching
        /// </summary>
        [Description("Total no hitters while pitching")]
        [DataMember(Name = "PitchingNoHitters", Order = 106)]
        public decimal? PitchingNoHitters { get; set; }

        /// <summary>
        /// Total perfect games while pitching
        /// </summary>
        [Description("Total perfect games while pitching")]
        [DataMember(Name = "PitchingPerfectGames", Order = 107)]
        public decimal? PitchingPerfectGames { get; set; }

        /// <summary>
        /// Total plate appearances while pitching
        /// </summary>
        [Description("Total plate appearances while pitching")]
        [DataMember(Name = "PitchingPlateAppearances", Order = 108)]
        public decimal? PitchingPlateAppearances { get; set; }

        /// <summary>
        /// Total bases while pitching
        /// </summary>
        [Description("Total bases while pitching")]
        [DataMember(Name = "PitchingTotalBases", Order = 109)]
        public decimal? PitchingTotalBases { get; set; }

        /// <summary>
        /// Total fly outs while pitching
        /// </summary>
        [Description("Total fly outs while pitching")]
        [DataMember(Name = "PitchingFlyOuts", Order = 110)]
        public decimal? PitchingFlyOuts { get; set; }

        /// <summary>
        /// Total ground outs while pitching
        /// </summary>
        [Description("Total ground outs while pitching")]
        [DataMember(Name = "PitchingGroundOuts", Order = 111)]
        public decimal? PitchingGroundOuts { get; set; }

        /// <summary>
        /// Total line outs while pitching
        /// </summary>
        [Description("Total line outs while pitching")]
        [DataMember(Name = "PitchingLineOuts", Order = 112)]
        public decimal? PitchingLineOuts { get; set; }

        /// <summary>
        /// Total pop outs while pitching
        /// </summary>
        [Description("Total pop outs while pitching")]
        [DataMember(Name = "PitchingPopOuts", Order = 113)]
        public decimal? PitchingPopOuts { get; set; }

        /// <summary>
        /// Total intentional walks while pitching
        /// </summary>
        [Description("Total intentional walks while pitching")]
        [DataMember(Name = "PitchingIntentionalWalks", Order = 114)]
        public decimal? PitchingIntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error while pitching
        /// </summary>
        [Description("Total times reached on error while pitching")]
        [DataMember(Name = "PitchingReachedOnError", Order = 115)]
        public decimal? PitchingReachedOnError { get; set; }

        /// <summary>
        /// Total catchers interference while pitching
        /// </summary>
        [Description("Total catchers interference while pitching")]
        [DataMember(Name = "PitchingCatchersInterference", Order = 116)]
        public decimal? PitchingCatchersInterference { get; set; }

        /// <summary>
        /// Total balls in play while pitching
        /// </summary>
        [Description("Total balls in play while pitching")]
        [DataMember(Name = "PitchingBallsInPlay", Order = 117)]
        public decimal? PitchingBallsInPlay { get; set; }

        /// <summary>
        /// Total on base percentage (OBP) while pitching
        /// </summary>
        [Description("Total on base percentage (OBP) while pitching")]
        [DataMember(Name = "PitchingOnBasePercentage", Order = 118)]
        public decimal? PitchingOnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage (SLG) while pitching
        /// </summary>
        [Description("Total slugging percentage (SLG) while pitching")]
        [DataMember(Name = "PitchingSluggingPercentage", Order = 119)]
        public decimal? PitchingSluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus slugging (OPS) while pitching
        /// </summary>
        [Description("Total on base plus slugging (OPS) while pitching")]
        [DataMember(Name = "PitchingOnBasePlusSlugging", Order = 120)]
        public decimal? PitchingOnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total strikeouts per nine innings (K/9) while pitching
        /// </summary>
        [Description("Total strikeouts per nine innings (K/9) while pitching")]
        [DataMember(Name = "PitchingStrikeoutsPerNineInnings", Order = 121)]
        public decimal? PitchingStrikeoutsPerNineInnings { get; set; }

        /// <summary>
        /// Total walks per nine innings (BB/9) while pitching
        /// </summary>
        [Description("Total walks per nine innings (BB/9) while pitching")]
        [DataMember(Name = "PitchingWalksPerNineInnings", Order = 122)]
        public decimal? PitchingWalksPerNineInnings { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP) while pitching
        /// </summary>
        [Description("Total batting average on balls in play (BABIP) while pitching")]
        [DataMember(Name = "PitchingBattingAverageOnBallsInPlay", Order = 123)]
        public decimal? PitchingBattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weighted on base percentage while pitching 
        /// </summary>
        [Description("Total weighted on base percentage while pitching ")]
        [DataMember(Name = "PitchingWeightedOnBasePercentage", Order = 124)]
        public decimal? PitchingWeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total double plays
        /// </summary>
        [Description("Total double plays")]
        [DataMember(Name = "DoublePlays", Order = 125)]
        public decimal? DoublePlays { get; set; }

        /// <summary>
        /// Total double plays while pitching
        /// </summary>
        [Description("Total double plays while pitching")]
        [DataMember(Name = "PitchingDoublePlays", Order = 126)]
        public decimal? PitchingDoublePlays { get; set; }

        /// <summary>
        /// Whether the batting order is confirmed (true/false)
        /// </summary>
        [Description("Whether the batting order is confirmed (true/false)")]
        [DataMember(Name = "BattingOrderConfirmed", Order = 127)]
        public bool? BattingOrderConfirmed { get; set; }

        /// <summary>
        /// Total isolated power (ISO)
        /// </summary>
        [Description("Total isolated power (ISO)")]
        [DataMember(Name = "IsolatedPower", Order = 128)]
        public decimal? IsolatedPower { get; set; }

        /// <summary>
        /// Total fielding independent pitching (FIP)
        /// </summary>
        [Description("Total fielding independent pitching (FIP)")]
        [DataMember(Name = "FieldingIndependentPitching", Order = 129)]
        public decimal? FieldingIndependentPitching { get; set; }

        /// <summary>
        /// Total quality starts pitched
        /// </summary>
        [Description("Total quality starts pitched")]
        [DataMember(Name = "PitchingQualityStarts", Order = 130)]
        public decimal? PitchingQualityStarts { get; set; }

        /// <summary>
        /// The inning that the pitcher entered the game (if any).
        /// </summary>
        [Description("The inning that the pitcher entered the game (if any).")]
        [DataMember(Name = "PitchingInningStarted", Order = 131)]
        public int? PitchingInningStarted { get; set; }

        /// <summary>
        /// Total left on base percentage 
        /// </summary>
        [Description("Total left on base percentage ")]
        [DataMember(Name = "LeftOnBase", Order = 132)]
        public decimal? LeftOnBase { get; set; }

        /// <summary>
        /// Total holds pitched
        /// </summary>
        [Description("Total holds pitched")]
        [DataMember(Name = "PitchingHolds", Order = 133)]
        public decimal? PitchingHolds { get; set; }

        /// <summary>
        /// Total blown saves pitched
        /// </summary>
        [Description("Total blown saves pitched")]
        [DataMember(Name = "PitchingBlownSaves", Order = 134)]
        public decimal? PitchingBlownSaves { get; set; }

        /// <summary>
        /// The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)
        /// </summary>
        [Description("The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)")]
        [DataMember(Name = "SubstituteBattingOrder", Order = 135)]
        public int? SubstituteBattingOrder { get; set; }

        /// <summary>
        /// The sequence in which this player was substituted into the game, within the particular batting order
        /// </summary>
        [Description("The sequence in which this player was substituted into the game, within the particular batting order")]
        [DataMember(Name = "SubstituteBattingOrderSequence", Order = 136)]
        public int? SubstituteBattingOrderSequence { get; set; }

        /// <summary>
        /// Total FantasyDraft fantasy points
        /// </summary>
        [Description("Total FantasyDraft fantasy points")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 137)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

