using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="FantasyDefenseGameProjectionDfsr")]
    [Serializable]
    public partial class FantasyDefenseGameProjectionDfsr
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 5)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 7)]
        public string Opponent { get; set; }

        /// <summary>
        /// Total points allowed by the team during the game
        /// </summary>
        [Description("Total points allowed by the team during the game")]
        [DataMember(Name = "PointsAllowed", Order = 8)]
        public decimal PointsAllowed { get; set; }

        /// <summary>
        /// Total defensive and special teams touchdowns scored by the team in the game
        /// </summary>
        [Description("Total defensive and special teams touchdowns scored by the team in the game")]
        [DataMember(Name = "TouchdownsScored", Order = 9)]
        public decimal TouchdownsScored { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the team in the game
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the team in the game")]
        [DataMember(Name = "SoloTackles", Order = 10)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the team in the game
        /// </summary>
        [Description("Total defensive assisted tackles by the team in the game")]
        [DataMember(Name = "AssistedTackles", Order = 11)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the team in the game
        /// </summary>
        [Description("Total defensive sacks by the team in the game")]
        [DataMember(Name = "Sacks", Order = 12)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the team in the game
        /// </summary>
        [Description("Total defensive sack yards by the team in the game")]
        [DataMember(Name = "SackYards", Order = 13)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total passes defended by the team in the game
        /// </summary>
        [Description("Total passes defended by the team in the game")]
        [DataMember(Name = "PassesDefended", Order = 14)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the team in the game
        /// </summary>
        [Description("Total fumbles forced on defense by the team in the game")]
        [DataMember(Name = "FumblesForced", Order = 15)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the team in the game
        /// </summary>
        [Description("Total defensive fumble recoveries by the team in the game")]
        [DataMember(Name = "FumblesRecovered", Order = 16)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the team in the game
        /// </summary>
        [Description("Total fumble return yards by the team in the game")]
        [DataMember(Name = "FumbleReturnYards", Order = 17)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the team in the game
        /// </summary>
        [Description("Total fumble return touchdowns by the team in the game")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 18)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interceptions by the team in the game
        /// </summary>
        [Description("Total defensive interceptions by the team in the game")]
        [DataMember(Name = "Interceptions", Order = 19)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the team in the game
        /// </summary>
        [Description("Total defensive interception return yards by the team in the game")]
        [DataMember(Name = "InterceptionReturnYards", Order = 20)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the team in the game
        /// </summary>
        [Description("Total defensive interception return touchdowns by the team in the game")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 21)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by team in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by team in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 22)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the team in the game
        /// </summary>
        [Description("Total defensive safeties scored by the team in the game")]
        [DataMember(Name = "Safeties", Order = 23)]
        public decimal Safeties { get; set; }

        /// <summary>
        /// Total punt returns by the team in the game
        /// </summary>
        [Description("Total punt returns by the team in the game")]
        [DataMember(Name = "PuntReturns", Order = 24)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the team in the game
        /// </summary>
        [Description("Total punt return yards by the team in the game")]
        [DataMember(Name = "PuntReturnYards", Order = 25)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the team in the game
        /// </summary>
        [Description("Total punt return touchdowns by the team in the game")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 26)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the team in the game
        /// </summary>
        [Description("The longest punt return by the team in the game")]
        [DataMember(Name = "PuntReturnLong", Order = 27)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff returns by the team in the game
        /// </summary>
        [Description("Total kickoff returns by the team in the game")]
        [DataMember(Name = "KickReturns", Order = 28)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the team in the game
        /// </summary>
        [Description("Total kickoff return yards by the team in the game")]
        [DataMember(Name = "KickReturnYards", Order = 29)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the team in the game
        /// </summary>
        [Description("Total kickoff return touchdowns by the team in the game")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 30)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the team in the game
        /// </summary>
        [Description("Longest kick return by the team in the game")]
        [DataMember(Name = "KickReturnLong", Order = 31)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the team in the game
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the team in the game")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 32)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the team in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the team in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 33)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("Fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 34)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing quarterbacks by the team in the game
        /// </summary>
        [Description("Fantasy points allowed to opposing quarterbacks by the team in the game")]
        [DataMember(Name = "QuarterbackFantasyPointsAllowed", Order = 35)]
        public decimal? QuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total fantasy points allowed to opposing running backs by the team in the game
        /// </summary>
        [Description("Total fantasy points allowed to opposing running backs by the team in the game")]
        [DataMember(Name = "RunningbackFantasyPointsAllowed", Order = 36)]
        public decimal? RunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "WideReceiverFantasyPointsAllowed", Order = 37)]
        public decimal? WideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing tight ends by the team in the game
        /// </summary>
        [Description("Fantasy points allowed to opposing tight ends by the team in the game")]
        [DataMember(Name = "TightEndFantasyPointsAllowed", Order = 38)]
        public decimal? TightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opponent kickers by the team in the game
        /// </summary>
        [Description("Fantasy points allowed to opponent kickers by the team in the game")]
        [DataMember(Name = "KickerFantasyPointsAllowed", Order = 39)]
        public decimal? KickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the team in the game
        /// </summary>
        [Description("Total blocked kick recovery return yards for the team in the game")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 40)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total field goal return yards by the team in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the team in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 41)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the team in the game. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the team in the game. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 42)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the team in the game. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the team in the game. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 43)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total touchdowns scored by the defense
        /// </summary>
        [Description("Total touchdowns scored by the defense")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 44)]
        public decimal? DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total special teams touchdowns scored by the team in the game
        /// </summary>
        [Description("Total special teams touchdowns scored by the team in the game")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 45)]
        public decimal? SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 46)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system by the team's D/ST in the game
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system by the team's D/ST in the game")]
        [DataMember(Name = "FantasyPoints", Order = 47)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 48)]
        public string Stadium { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 49)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 50)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
        [DataMember(Name = "WindSpeed", Order = 51)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// Total third down attempts against the team in the game
        /// </summary>
        [Description("Total third down attempts against the team in the game")]
        [DataMember(Name = "ThirdDownAttempts", Order = 52)]
        public decimal? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Total third down conversions against the team in the game
        /// </summary>
        [Description("Total third down conversions against the team in the game")]
        [DataMember(Name = "ThirdDownConversions", Order = 53)]
        public decimal? ThirdDownConversions { get; set; }

        /// <summary>
        /// Opponent's fourth down attempts against the team in the game
        /// </summary>
        [Description("Opponent's fourth down attempts against the team in the game")]
        [DataMember(Name = "FourthDownAttempts", Order = 54)]
        public decimal? FourthDownAttempts { get; set; }

        /// <summary>
        /// Opponent's fourth down conversions against the team in the game
        /// </summary>
        [Description("Opponent's fourth down conversions against the team in the game")]
        [DataMember(Name = "FourthDownConversions", Order = 55)]
        public decimal? FourthDownConversions { get; set; }

        /// <summary>
        /// Total number of points allowed by the team in the game to the opposing offense and special teams. Note: This field excludes points scored by the opponent's defense
        /// </summary>
        [Description("Total number of points allowed by the team in the game to the opposing offense and special teams. Note: This field excludes points scored by the opponent's defense")]
        [DataMember(Name = "PointsAllowedByDefenseSpecialTeams", Order = 56)]
        public decimal? PointsAllowedByDefenseSpecialTeams { get; set; }

        /// <summary>
        /// The team's D/ST salary for FanDuel daily fantasy contests
        /// </summary>
        [Description("The team's D/ST salary for FanDuel daily fantasy contests")]
        [DataMember(Name = "FanDuelSalary", Order = 57)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The team's D/ST salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The team's D/ST salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 58)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The team's D/ST salary as calculated by SportsDataIO (formerly known as FantasyData). Based on the same salary cap as DraftKings contests ($50,000)
        /// </summary>
        [Description("The team's D/ST salary as calculated by SportsDataIO (formerly known as FantasyData). Based on the same salary cap as DraftKings contests ($50,000)")]
        [DataMember(Name = "FantasyDataSalary", Order = 59)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The player's salary for Victiv daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Victiv daily fantasy contests.")]
        [DataMember(Name = "VictivSalary", Order = 60)]
        public int? VictivSalary { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the team in the game
        /// </summary>
        [Description("Total successful two point conversion returns by the team in the game")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 61)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system by the team in the game
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system by the team in the game")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 62)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system by the team in the game
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system by the team in the game")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 63)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Offensive yards allowed by the team's defense in the game
        /// </summary>
        [Description("Offensive yards allowed by the team's defense in the game")]
        [DataMember(Name = "OffensiveYardsAllowed", Order = 64)]
        public decimal? OffensiveYardsAllowed { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests")]
        [DataMember(Name = "YahooSalary", Order = 65)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO for use when combining with player feeds. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO for use when combining with player feeds. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 66)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system by the team in the game
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system by the team in the game")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 67)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 68)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST
        /// </summary>
        [Description("The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST")]
        [DataMember(Name = "OpponentRank", Order = 69)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST
        /// </summary>
        [Description("The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST")]
        [DataMember(Name = "OpponentPositionRank", Order = 70)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// The team's D/ST salary for FantasyDraft daily fantasy contests.
        /// </summary>
        [Description("The team's D/ST salary for FantasyDraft daily fantasy contests.")]
        [DataMember(Name = "FantasyDraftSalary", Order = 71)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 72)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of this opponent team
        /// </summary>
        [Description("The unique ID of this opponent team")]
        [DataMember(Name = "OpponentID", Order = 73)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 74)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 75)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 76)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 77)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalOpponentID", Order = 78)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The position of this team's D/ST; as listed by DraftKings.
        /// </summary>
        [Description("The position of this team's D/ST; as listed by DraftKings.")]
        [DataMember(Name = "DraftKingsPosition", Order = 79)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The position of this team's D/ST; as listed by FanDuel.
        /// </summary>
        [Description("The position of this team's D/ST; as listed by FanDuel.")]
        [DataMember(Name = "FanDuelPosition", Order = 80)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The position of this team's D/ST; as listed by FantasyDraft
        /// </summary>
        [Description("The position of this team's D/ST; as listed by FantasyDraft")]
        [DataMember(Name = "FantasyDraftPosition", Order = 81)]
        public string FantasyDraftPosition { get; set; }

        /// <summary>
        /// The position of the team's defense/special teams unit, as listed on Yahoo's daily fantasy sports platform
        /// </summary>
        [Description("The position of the team's defense/special teams unit, as listed on Yahoo's daily fantasy sports platform")]
        [DataMember(Name = "YahooPosition", Order = 82)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// "Unique ID of FantasyDefense record (subject to change; although it very rarely does).  Note: For a guaranteed static ID; use a combination of GameKey and Team"
        /// </summary>
        [Description("\"Unique ID of FantasyDefense record (subject to change; although it very rarely does).  Note: For a guaranteed static ID; use a combination of GameKey and Team\"")]
        [DataMember(Name = "FantasyDefenseID", Order = 83)]
        public int? FantasyDefenseID { get; set; }

        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 84)]
        public int ScoreID { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FanDuelFantasyPointsAllowed", Order = 85)]
        public decimal? FanDuelFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing quarterbacks in the game
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing quarterbacks in the game")]
        [DataMember(Name = "FanDuelQuarterbackFantasyPointsAllowed", Order = 86)]
        public decimal? FanDuelQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing running backs in the game
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing running backs in the game")]
        [DataMember(Name = "FanDuelRunningbackFantasyPointsAllowed", Order = 87)]
        public decimal? FanDuelRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing wide receivers in the game
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing wide receivers in the game")]
        [DataMember(Name = "FanDuelWideReceiverFantasyPointsAllowed", Order = 88)]
        public decimal? FanDuelWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing tight ends in the game
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing tight ends in the game")]
        [DataMember(Name = "FanDuelTightEndFantasyPointsAllowed", Order = 89)]
        public decimal? FanDuelTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing kickers in the game
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing kickers in the game")]
        [DataMember(Name = "FanDuelKickerFantasyPointsAllowed", Order = 90)]
        public decimal? FanDuelKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "DraftKingsFantasyPointsAllowed", Order = 91)]
        public decimal? DraftKingsFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent quarterbacks in the game
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent quarterbacks in the game")]
        [DataMember(Name = "DraftKingsQuarterbackFantasyPointsAllowed", Order = 92)]
        public decimal? DraftKingsQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent running backs in the game
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent running backs in the game")]
        [DataMember(Name = "DraftKingsRunningbackFantasyPointsAllowed", Order = 93)]
        public decimal? DraftKingsRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent wide receivers in the game
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent wide receivers in the game")]
        [DataMember(Name = "DraftKingsWideReceiverFantasyPointsAllowed", Order = 94)]
        public decimal? DraftKingsWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent tight ends in the game
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent tight ends in the game")]
        [DataMember(Name = "DraftKingsTightEndFantasyPointsAllowed", Order = 95)]
        public decimal? DraftKingsTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing kickers
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing kickers")]
        [DataMember(Name = "DraftKingsKickerFantasyPointsAllowed", Order = 96)]
        public decimal? DraftKingsKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing offensive players by the team in the game. Note: Offensive players include: QB, RB, WR, & TE
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing offensive players by the team in the game. Note: Offensive players include: QB, RB, WR, & TE")]
        [DataMember(Name = "YahooFantasyPointsAllowed", Order = 97)]
        public decimal? YahooFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing quarterbacks by the team in the game
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing quarterbacks by the team in the game")]
        [DataMember(Name = "YahooQuarterbackFantasyPointsAllowed", Order = 98)]
        public decimal? YahooQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing running backs by the team in the game
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing running backs by the team in the game")]
        [DataMember(Name = "YahooRunningbackFantasyPointsAllowed", Order = 99)]
        public decimal? YahooRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing wide receivers by the team in the game
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing wide receivers by the team in the game")]
        [DataMember(Name = "YahooWideReceiverFantasyPointsAllowed", Order = 100)]
        public decimal? YahooWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing tight ends by the team in the game
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing tight ends by the team in the game")]
        [DataMember(Name = "YahooTightEndFantasyPointsAllowed", Order = 101)]
        public decimal? YahooTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing kickers by the team in the game
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing kickers by the team in the game")]
        [DataMember(Name = "YahooKickerFantasyPointsAllowed", Order = 102)]
        public decimal? YahooKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points based on FantasyDraft's scoring system by the team in the game
        /// </summary>
        [Description("Fantasy points based on FantasyDraft's scoring system by the team in the game")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 103)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing offensive players in the game. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FantasyDraftFantasyPointsAllowed", Order = 104)]
        public decimal? FantasyDraftFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing quarterbacks in the game
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing quarterbacks in the game")]
        [DataMember(Name = "FantasyDraftQuarterbackFantasyPointsAllowed", Order = 105)]
        public decimal? FantasyDraftQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing running backs in the game
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing running backs in the game")]
        [DataMember(Name = "FantasyDraftRunningbackFantasyPointsAllowed", Order = 106)]
        public decimal? FantasyDraftRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing wide receivers in the game
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing wide receivers in the game")]
        [DataMember(Name = "FantasyDraftWideReceiverFantasyPointsAllowed", Order = 107)]
        public decimal? FantasyDraftWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing tight ends in the game
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing tight ends in the game")]
        [DataMember(Name = "FantasyDraftTightEndFantasyPointsAllowed", Order = 108)]
        public decimal? FantasyDraftTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing kickers in the game
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing kickers in the game")]
        [DataMember(Name = "FantasyDraftKickerFantasyPointsAllowed", Order = 109)]
        public decimal? FantasyDraftKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// The details of the scoring plays this team DST recorded in the game
        /// </summary>
        [Description("The details of the scoring plays this team DST recorded in the game")]
        [DataMember(Name = "ScoringDetails", Order = 20110)]
        public ScoringDetail[] ScoringDetails { get; set; }

    }
}

