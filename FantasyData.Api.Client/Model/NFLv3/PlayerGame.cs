using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerGame")]
    [Serializable]
    public partial class PlayerGame
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "GameDate", Order = 5)]
        public DateTime GameDate { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 6)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation of the Opponent
        /// </summary>
        [Description("The abbreviation of the Opponent")]
        [DataMember(Name = "Opponent", Order = 8)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the player is Home or Away
        /// </summary>
        [Description("Whether the player is Home or Away")]
        [DataMember(Name = "HomeOrAway", Order = 9)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 10)]
        public int Number { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 11)]
        public string Name { get; set; }

        /// <summary>
        /// Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR
        /// </summary>
        [Description("Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR")]
        [DataMember(Name = "Position", Order = 12)]
        public string Position { get; set; }

        /// <summary>
        /// Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)
        /// </summary>
        [Description("Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 13)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Whether the player was Active at gametime
        /// </summary>
        [Description("Whether the player was Active at gametime")]
        [DataMember(Name = "Activated", Order = 14)]
        public int Activated { get; set; }

        /// <summary>
        /// Whether the player played in at least one play
        /// </summary>
        [Description("Whether the player played in at least one play")]
        [DataMember(Name = "Played", Order = 15)]
        public int Played { get; set; }

        /// <summary>
        /// Whether the player started on offense or defense
        /// </summary>
        [Description("Whether the player started on offense or defense")]
        [DataMember(Name = "Started", Order = 16)]
        public int Started { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "PassingAttempts", Order = 17)]
        public decimal PassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "PassingCompletions", Order = 18)]
        public decimal PassingCompletions { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "PassingYards", Order = 19)]
        public decimal PassingYards { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 20)]
        public decimal PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 21)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 22)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "PassingTouchdowns", Order = 23)]
        public decimal PassingTouchdowns { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "PassingInterceptions", Order = 24)]
        public decimal PassingInterceptions { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "PassingRating", Order = 25)]
        public decimal PassingRating { get; set; }

        /// <summary>
        /// Longest completion
        /// </summary>
        [Description("Longest completion")]
        [DataMember(Name = "PassingLong", Order = 26)]
        public decimal PassingLong { get; set; }

        /// <summary>
        /// Number of times sacked
        /// </summary>
        [Description("Number of times sacked")]
        [DataMember(Name = "PassingSacks", Order = 27)]
        public decimal PassingSacks { get; set; }

        /// <summary>
        /// Yards lost as a result of being sacked
        /// </summary>
        [Description("Yards lost as a result of being sacked")]
        [DataMember(Name = "PassingSackYards", Order = 28)]
        public decimal PassingSackYards { get; set; }

        /// <summary>
        /// Number of rushing attempts
        /// </summary>
        [Description("Number of rushing attempts")]
        [DataMember(Name = "RushingAttempts", Order = 29)]
        public decimal RushingAttempts { get; set; }

        /// <summary>
        /// Number of rushing yards
        /// </summary>
        [Description("Number of rushing yards")]
        [DataMember(Name = "RushingYards", Order = 30)]
        public decimal RushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt
        /// </summary>
        [Description("Average rushing yards gained per attempt")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 31)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Rushing touchdowns scored
        /// </summary>
        [Description("Rushing touchdowns scored")]
        [DataMember(Name = "RushingTouchdowns", Order = 32)]
        public decimal RushingTouchdowns { get; set; }

        /// <summary>
        /// Longest rush
        /// </summary>
        [Description("Longest rush")]
        [DataMember(Name = "RushingLong", Order = 33)]
        public decimal RushingLong { get; set; }

        /// <summary>
        /// Number of times targeted by passer
        /// </summary>
        [Description("Number of times targeted by passer")]
        [DataMember(Name = "ReceivingTargets", Order = 34)]
        public decimal? ReceivingTargets { get; set; }

        /// <summary>
        /// Number of receptions
        /// </summary>
        [Description("Number of receptions")]
        [DataMember(Name = "Receptions", Order = 35)]
        public decimal Receptions { get; set; }

        /// <summary>
        /// Total receiving yards
        /// </summary>
        [Description("Total receiving yards")]
        [DataMember(Name = "ReceivingYards", Order = 36)]
        public decimal ReceivingYards { get; set; }

        /// <summary>
        /// Average yards gained per reception
        /// </summary>
        [Description("Average yards gained per reception")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 37)]
        public decimal ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Receiving touchdowns
        /// </summary>
        [Description("Receiving touchdowns")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 38)]
        public decimal ReceivingTouchdowns { get; set; }

        /// <summary>
        /// Longest reception
        /// </summary>
        [Description("Longest reception")]
        [DataMember(Name = "ReceivingLong", Order = 39)]
        public decimal ReceivingLong { get; set; }

        /// <summary>
        /// Times fumbled
        /// </summary>
        [Description("Times fumbled")]
        [DataMember(Name = "Fumbles", Order = 40)]
        public decimal Fumbles { get; set; }

        /// <summary>
        /// Number of fumbles recovered by opponent
        /// </summary>
        [Description("Number of fumbles recovered by opponent")]
        [DataMember(Name = "FumblesLost", Order = 41)]
        public decimal? FumblesLost { get; set; }

        /// <summary>
        /// Number of punt return attempts
        /// </summary>
        [Description("Number of punt return attempts")]
        [DataMember(Name = "PuntReturns", Order = 42)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total return yards on punts
        /// </summary>
        [Description("Total return yards on punts")]
        [DataMember(Name = "PuntReturnYards", Order = 43)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per punt return
        /// </summary>
        [Description("Average yards gained per punt return")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 44)]
        public decimal PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Number of touchdowns on punt returns
        /// </summary>
        [Description("Number of touchdowns on punt returns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 45)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 46)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Number of kick return attempts
        /// </summary>
        [Description("Number of kick return attempts")]
        [DataMember(Name = "KickReturns", Order = 47)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total return yards on kicks
        /// </summary>
        [Description("Total return yards on kicks")]
        [DataMember(Name = "KickReturnYards", Order = 48)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per kick return
        /// </summary>
        [Description("Average yards gained per kick return")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 49)]
        public decimal KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Number of touchdowns on kick returns
        /// </summary>
        [Description("Number of touchdowns on kick returns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 50)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "KickReturnLong", Order = 51)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Solo, unassisted tackles
        /// </summary>
        [Description("Solo, unassisted tackles")]
        [DataMember(Name = "SoloTackles", Order = 52)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Assisted tackles (also called a half tackle)
        /// </summary>
        [Description("Assisted tackles (also called a half tackle)")]
        [DataMember(Name = "AssistedTackles", Order = 53)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Tackles behind the opponent's line of scrimmage
        /// </summary>
        [Description("Tackles behind the opponent's line of scrimmage")]
        [DataMember(Name = "TacklesForLoss", Order = 54)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Sacks of the opposing quarterback
        /// </summary>
        [Description("Sacks of the opposing quarterback")]
        [DataMember(Name = "Sacks", Order = 55)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Yards lost as a result of sacking the opposing quarterback
        /// </summary>
        [Description("Yards lost as a result of sacking the opposing quarterback")]
        [DataMember(Name = "SackYards", Order = 56)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Number of times hitting an opposing quarterback without sacking him
        /// </summary>
        [Description("Number of times hitting an opposing quarterback without sacking him")]
        [DataMember(Name = "QuarterbackHits", Order = 57)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Passes defended or batted down
        /// </summary>
        [Description("Passes defended or batted down")]
        [DataMember(Name = "PassesDefended", Order = 58)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Number of fumbles forced
        /// </summary>
        [Description("Number of fumbles forced")]
        [DataMember(Name = "FumblesForced", Order = 59)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Number of fumbles recovered
        /// </summary>
        [Description("Number of fumbles recovered")]
        [DataMember(Name = "FumblesRecovered", Order = 60)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Return yards from fumble recoveries
        /// </summary>
        [Description("Return yards from fumble recoveries")]
        [DataMember(Name = "FumbleReturnYards", Order = 61)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Return touchdowns from fumble recoveries
        /// </summary>
        [Description("Return touchdowns from fumble recoveries")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 62)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Number of interceptions
        /// </summary>
        [Description("Number of interceptions")]
        [DataMember(Name = "Interceptions", Order = 63)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Return yards from interceptions
        /// </summary>
        [Description("Return yards from interceptions")]
        [DataMember(Name = "InterceptionReturnYards", Order = 64)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Return touchdowns from interceptions
        /// </summary>
        [Description("Return touchdowns from interceptions")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 65)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of field goals and punts blocked
        /// </summary>
        [Description("Total number of field goals and punts blocked")]
        [DataMember(Name = "BlockedKicks", Order = 66)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// Solo tackles on kick and punt plays
        /// </summary>
        [Description("Solo tackles on kick and punt plays")]
        [DataMember(Name = "SpecialTeamsSoloTackles", Order = 67)]
        public decimal SpecialTeamsSoloTackles { get; set; }

        /// <summary>
        /// Assisted tackles on kick and punt plays
        /// </summary>
        [Description("Assisted tackles on kick and punt plays")]
        [DataMember(Name = "SpecialTeamsAssistedTackles", Order = 68)]
        public decimal SpecialTeamsAssistedTackles { get; set; }

        /// <summary>
        /// Solo tackles when playing offense (after a turnover)
        /// </summary>
        [Description("Solo tackles when playing offense (after a turnover)")]
        [DataMember(Name = "MiscSoloTackles", Order = 69)]
        public decimal MiscSoloTackles { get; set; }

        /// <summary>
        /// Assisted tackles when playing offense (after a turnover)
        /// </summary>
        [Description("Assisted tackles when playing offense (after a turnover)")]
        [DataMember(Name = "MiscAssistedTackles", Order = 70)]
        public decimal MiscAssistedTackles { get; set; }

        /// <summary>
        /// Number of punts
        /// </summary>
        [Description("Number of punts")]
        [DataMember(Name = "Punts", Order = 71)]
        public decimal Punts { get; set; }

        /// <summary>
        /// Total number of punt yards
        /// </summary>
        [Description("Total number of punt yards")]
        [DataMember(Name = "PuntYards", Order = 72)]
        public decimal PuntYards { get; set; }

        /// <summary>
        /// Average yards per punt
        /// </summary>
        [Description("Average yards per punt")]
        [DataMember(Name = "PuntAverage", Order = 73)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Number of field goal attempts
        /// </summary>
        [Description("Number of field goal attempts")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 74)]
        public decimal FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Number of successful field goal attempts
        /// </summary>
        [Description("Number of successful field goal attempts")]
        [DataMember(Name = "FieldGoalsMade", Order = 75)]
        public decimal FieldGoalsMade { get; set; }

        /// <summary>
        /// Longest successful field goal attempt
        /// </summary>
        [Description("Longest successful field goal attempt")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 76)]
        public decimal FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Number of successful extra points
        /// </summary>
        [Description("Number of successful extra points")]
        [DataMember(Name = "ExtraPointsMade", Order = 77)]
        public decimal ExtraPointsMade { get; set; }

        /// <summary>
        /// Successful two point conversion passes
        /// </summary>
        [Description("Successful two point conversion passes")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 78)]
        public decimal TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Successful two point conversion runs
        /// </summary>
        [Description("Successful two point conversion runs")]
        [DataMember(Name = "TwoPointConversionRuns", Order = 79)]
        public decimal TwoPointConversionRuns { get; set; }

        /// <summary>
        /// Successful two point conversion receptions
        /// </summary>
        [Description("Successful two point conversion receptions")]
        [DataMember(Name = "TwoPointConversionReceptions", Order = 80)]
        public decimal TwoPointConversionReceptions { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPoints", Order = 81)]
        public decimal FantasyPoints { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic PPR fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic PPR fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPointsPPR", Order = 82)]
        public decimal FantasyPointsPPR { get; set; }

        /// <summary>
        /// Percentage of ReceivingTargets convert into Receptions
        /// </summary>
        [Description("Percentage of ReceivingTargets convert into Receptions")]
        [DataMember(Name = "ReceptionPercentage", Order = 83)]
        public decimal ReceptionPercentage { get; set; }

        /// <summary>
        /// Average yards gained per ReceivingTargets
        /// </summary>
        [Description("Average yards gained per ReceivingTargets")]
        [DataMember(Name = "ReceivingYardsPerTarget", Order = 84)]
        public decimal ReceivingYardsPerTarget { get; set; }

        /// <summary>
        /// Sum of SoloTackles and AssistedTackles
        /// </summary>
        [Description("Sum of SoloTackles and AssistedTackles")]
        [DataMember(Name = "Tackles", Order = 85)]
        public decimal Tackles { get; set; }

        /// <summary>
        /// Offensive touchdowns scored
        /// </summary>
        [Description("Offensive touchdowns scored")]
        [DataMember(Name = "OffensiveTouchdowns", Order = 86)]
        public decimal OffensiveTouchdowns { get; set; }

        /// <summary>
        /// Defensive touchdowns scored
        /// </summary>
        [Description("Defensive touchdowns scored")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 87)]
        public decimal DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Special teams touchdowns scored
        /// </summary>
        [Description("Special teams touchdowns scored")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 88)]
        public decimal SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Total touchdowns scored
        /// </summary>
        [Description("Total touchdowns scored")]
        [DataMember(Name = "Touchdowns", Order = 89)]
        public decimal Touchdowns { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 90)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Percentage of Field Goal attempts that we successful
        /// </summary>
        [Description("Percentage of Field Goal attempts that we successful")]
        [DataMember(Name = "FieldGoalPercentage", Order = 91)]
        public decimal FieldGoalPercentage { get; set; }

        /// <summary>
        /// Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.
        /// </summary>
        [Description("Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.")]
        [DataMember(Name = "PlayerGameID", Order = 92)]
        public int PlayerGameID { get; set; }

        /// <summary>
        /// Own team's fumbles recovered (did not result in a turnover)
        /// </summary>
        [Description("Own team's fumbles recovered (did not result in a turnover)")]
        [DataMember(Name = "FumblesOwnRecoveries", Order = 93)]
        public decimal? FumblesOwnRecoveries { get; set; }

        /// <summary>
        /// Fumbles by this player that went out of bounds (no one was awarded the recovery)
        /// </summary>
        [Description("Fumbles by this player that went out of bounds (no one was awarded the recovery)")]
        [DataMember(Name = "FumblesOutOfBounds", Order = 94)]
        public decimal? FumblesOutOfBounds { get; set; }

        /// <summary>
        /// Fair catches made on kickoffs
        /// </summary>
        [Description("Fair catches made on kickoffs")]
        [DataMember(Name = "KickReturnFairCatches", Order = 95)]
        public decimal? KickReturnFairCatches { get; set; }

        /// <summary>
        /// Fair catches made on punts
        /// </summary>
        [Description("Fair catches made on punts")]
        [DataMember(Name = "PuntReturnFairCatches", Order = 96)]
        public decimal? PuntReturnFairCatches { get; set; }

        /// <summary>
        /// Punts by this player that were touchbacks
        /// </summary>
        [Description("Punts by this player that were touchbacks")]
        [DataMember(Name = "PuntTouchbacks", Order = 97)]
        public decimal? PuntTouchbacks { get; set; }

        /// <summary>
        /// Punts by this player that were downed inside the 20 yard line
        /// </summary>
        [Description("Punts by this player that were downed inside the 20 yard line")]
        [DataMember(Name = "PuntInside20", Order = 98)]
        public decimal? PuntInside20 { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "PuntNetAverage", Order = 99)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Extra point kicks attempted
        /// </summary>
        [Description("Extra point kicks attempted")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 100)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Blocked kicks that this player returned for touchdowns
        /// </summary>
        [Description("Blocked kicks that this player returned for touchdowns")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 101)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goals that this player returned for touchdowns
        /// </summary>
        [Description("Field goals that this player returned for touchdowns")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 102)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)
        /// </summary>
        [Description("Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)")]
        [DataMember(Name = "Safeties", Order = 103)]
        public decimal? Safeties { get; set; }

        /// <summary>
        /// Field goal attempts that were blocked
        /// </summary>
        [Description("Field goal attempts that were blocked")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 104)]
        public decimal? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Punts that were blocked
        /// </summary>
        [Description("Punts that were blocked")]
        [DataMember(Name = "PuntsHadBlocked", Order = 105)]
        public decimal? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Extra points that were blocked
        /// </summary>
        [Description("Extra points that were blocked")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 106)]
        public decimal? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Longest punt
        /// </summary>
        [Description("Longest punt")]
        [DataMember(Name = "PuntLong", Order = 107)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 108)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 109)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "PuntNetYards", Order = 110)]
        public decimal? PuntNetYards { get; set; }

        /// <summary>
        /// Fumbles forced on special teams plays
        /// </summary>
        [Description("Fumbles forced on special teams plays")]
        [DataMember(Name = "SpecialTeamsFumblesForced", Order = 111)]
        public decimal? SpecialTeamsFumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered on special teams plays
        /// </summary>
        [Description("Fumbles recovered on special teams plays")]
        [DataMember(Name = "SpecialTeamsFumblesRecovered", Order = 112)]
        public decimal? SpecialTeamsFumblesRecovered { get; set; }

        /// <summary>
        /// Fumbles forced after a turnover on offensive plays
        /// </summary>
        [Description("Fumbles forced after a turnover on offensive plays")]
        [DataMember(Name = "MiscFumblesForced", Order = 113)]
        public decimal? MiscFumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered after a turnover on offensive plays
        /// </summary>
        [Description("Fumbles recovered after a turnover on offensive plays")]
        [DataMember(Name = "MiscFumblesRecovered", Order = 114)]
        public decimal? MiscFumblesRecovered { get; set; }

        /// <summary>
        /// Shorter version of player's name, includes first initial and last name (e.g. A. Rodgers, P.Manning)
        /// </summary>
        [Description("Shorter version of player's name, includes first initial and last name (e.g. A. Rodgers, P.Manning)")]
        [DataMember(Name = "ShortName", Order = 115)]
        public string ShortName { get; set; }

        /// <summary>
        /// Playing surface of the stadium
        /// </summary>
        [Description("Playing surface of the stadium")]
        [DataMember(Name = "PlayingSurface", Order = 116)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 117)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Safeties allowed (tackled in end zone, sacked in end zone, ran out of bounds in end zone, or committed a penalty in end zone, e.g. Intentional Grounding or Offensive Holding)
        /// </summary>
        [Description("Safeties allowed (tackled in end zone, sacked in end zone, ran out of bounds in end zone, or committed a penalty in end zone, e.g. Intentional Grounding or Offensive Holding)")]
        [DataMember(Name = "SafetiesAllowed", Order = 118)]
        public decimal? SafetiesAllowed { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 119)]
        public string Stadium { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Temperature", Order = 120)]
        public int? Temperature { get; set; }

        /// <summary>
        /// Humidity at game start (Percentage)
        /// </summary>
        [Description("Humidity at game start (Percentage)")]
        [DataMember(Name = "Humidity", Order = 121)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Wind speed at game start (MPH)
        /// </summary>
        [Description("Wind speed at game start (MPH)")]
        [DataMember(Name = "WindSpeed", Order = 122)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The player's salary for FanDuel daily fantasy contests.
        /// </summary>
        [Description("The player's salary for FanDuel daily fantasy contests.")]
        [DataMember(Name = "FanDuelSalary", Order = 123)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The player's salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The player's salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 124)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The player's salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).
        /// </summary>
        [Description("The player's salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).")]
        [DataMember(Name = "FantasyDataSalary", Order = 125)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The number of snaps this player played on offense.
        /// </summary>
        [Description("The number of snaps this player played on offense.")]
        [DataMember(Name = "OffensiveSnapsPlayed", Order = 126)]
        public int? OffensiveSnapsPlayed { get; set; }

        /// <summary>
        /// The number of snaps this player played on defense.
        /// </summary>
        [Description("The number of snaps this player played on defense.")]
        [DataMember(Name = "DefensiveSnapsPlayed", Order = 127)]
        public int? DefensiveSnapsPlayed { get; set; }

        /// <summary>
        /// The number of snaps this player played on special teams.
        /// </summary>
        [Description("The number of snaps this player played on special teams.")]
        [DataMember(Name = "SpecialTeamsSnapsPlayed", Order = 128)]
        public int? SpecialTeamsSnapsPlayed { get; set; }

        /// <summary>
        /// The total number of offensive snaps this player's team played.
        /// </summary>
        [Description("The total number of offensive snaps this player's team played.")]
        [DataMember(Name = "OffensiveTeamSnaps", Order = 129)]
        public int? OffensiveTeamSnaps { get; set; }

        /// <summary>
        /// The total number of defensive snaps this player's team played.
        /// </summary>
        [Description("The total number of defensive snaps this player's team played.")]
        [DataMember(Name = "DefensiveTeamSnaps", Order = 130)]
        public int? DefensiveTeamSnaps { get; set; }

        /// <summary>
        /// The total number of special teams snaps this player's team played.
        /// </summary>
        [Description("The total number of special teams snaps this player's team played.")]
        [DataMember(Name = "SpecialTeamsTeamSnaps", Order = 131)]
        public int? SpecialTeamsTeamSnaps { get; set; }

        /// <summary>
        /// The player's salary for Victiv daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Victiv daily fantasy contests.")]
        [DataMember(Name = "VictivSalary", Order = 132)]
        public int? VictivSalary { get; set; }

        /// <summary>
        /// Two point conversions returned for two points.
        /// </summary>
        [Description("Two point conversions returned for two points.")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 133)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system.
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system.")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 134)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Field goals made of 0 to 19 yards.
        /// </summary>
        [Description("Field goals made of 0 to 19 yards.")]
        [DataMember(Name = "FieldGoalsMade0to19", Order = 135)]
        public decimal? FieldGoalsMade0to19 { get; set; }

        /// <summary>
        /// Field goals made of 20 to 29 yards.
        /// </summary>
        [Description("Field goals made of 20 to 29 yards.")]
        [DataMember(Name = "FieldGoalsMade20to29", Order = 136)]
        public decimal? FieldGoalsMade20to29 { get; set; }

        /// <summary>
        /// Field goals made of 30 to 39 yards.
        /// </summary>
        [Description("Field goals made of 30 to 39 yards.")]
        [DataMember(Name = "FieldGoalsMade30to39", Order = 137)]
        public decimal? FieldGoalsMade30to39 { get; set; }

        /// <summary>
        /// Field goals made of 40 to 49 yards.
        /// </summary>
        [Description("Field goals made of 40 to 49 yards.")]
        [DataMember(Name = "FieldGoalsMade40to49", Order = 138)]
        public decimal? FieldGoalsMade40to49 { get; set; }

        /// <summary>
        /// Field goals made of 50+ yards.
        /// </summary>
        [Description("Field goals made of 50+ yards.")]
        [DataMember(Name = "FieldGoalsMade50Plus", Order = 139)]
        public decimal? FieldGoalsMade50Plus { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system.
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system.")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 140)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 141)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 142)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The player's injury status for the upcoming game, in the form of likelihood that player plays (Probable, Questionable, Doubtful, Out)
        /// </summary>
        [Description("The player's injury status for the upcoming game, in the form of likelihood that player plays (Probable, Questionable, Doubtful, Out)")]
        [DataMember(Name = "InjuryStatus", Order = 143)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 144)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or first discovered.
        /// </summary>
        [Description("The day that the injury started or first discovered.")]
        [DataMember(Name = "InjuryStartDate", Order = 145)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability.
        /// </summary>
        [Description("Brief description of the player's injury and expected availability.")]
        [DataMember(Name = "InjuryNotes", Order = 146)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform.")]
        [DataMember(Name = "FanDuelPosition", Order = 147)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform.")]
        [DataMember(Name = "DraftKingsPosition", Order = 148)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooPosition", Order = 149)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentRank", Order = 150)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed.
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed.")]
        [DataMember(Name = "OpponentPositionRank", Order = 151)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// Whether the player participated in practice (None, Limited, Full)
        /// </summary>
        [Description("Whether the player participated in practice (None, Limited, Full)")]
        [DataMember(Name = "InjuryPractice", Order = 152)]
        public string InjuryPractice { get; set; }

        /// <summary>
        /// Full description of whether the player participated in practice)
        /// </summary>
        [Description("Full description of whether the player participated in practice)")]
        [DataMember(Name = "InjuryPracticeDescription", Order = 153)]
        public string InjuryPracticeDescription { get; set; }

        /// <summary>
        /// Whether the player has been declared inactive.  This value is updated in the hours leading up to game start time, as teams announce their inactive players.  This is only updated for offensive skill position players (QB, RB, WR, TE)
        /// </summary>
        [Description("Whether the player has been declared inactive.  This value is updated in the hours leading up to game start time, as teams announce their inactive players.  This is only updated for offensive skill position players (QB, RB, WR, TE)")]
        [DataMember(Name = "DeclaredInactive", Order = 154)]
        public bool DeclaredInactive { get; set; }

        /// <summary>
        /// The player's salary for FantasyDraft daily fantasy contests.
        /// </summary>
        [Description("The player's salary for FantasyDraft daily fantasy contests.")]
        [DataMember(Name = "FantasyDraftSalary", Order = 155)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// The player's eligible position in FantasyDraft's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in FantasyDraft's daily fantasy sports platform.")]
        [DataMember(Name = "FantasyDraftPosition", Order = 156)]
        public string FantasyDraftPosition { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 157)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of this opposing team
        /// </summary>
        [Description("The unique ID of this opposing team")]
        [DataMember(Name = "OpponentID", Order = 158)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The date of the game in US Eastern Time
        /// </summary>
        [Description("The date of the game in US Eastern Time")]
        [DataMember(Name = "Day", Order = 159)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 160)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 161)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 162)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 163)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 164)]
        public int ScoreID { get; set; }

        /// <summary>
        /// Fantasy points based on FantasyDraft's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on FantasyDraft's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 165)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// The details of the scoring plays this player recorded
        /// </summary>
        [Description("The details of the scoring plays this player recorded")]
        [DataMember(Name = "ScoringDetails", Order = 20166)]
        public ScoringDetail[] ScoringDetails { get; set; }

    }
}

