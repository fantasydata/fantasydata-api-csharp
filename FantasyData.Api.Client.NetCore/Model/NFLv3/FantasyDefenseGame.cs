using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="FantasyDefenseGame")]
    [Serializable]
    public partial class FantasyDefenseGame
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "Date", Order = 5)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation of the Opponent
        /// </summary>
        [Description("The abbreviation of the Opponent")]
        [DataMember(Name = "Opponent", Order = 7)]
        public string Opponent { get; set; }

        /// <summary>
        /// Number of points allowed
        /// </summary>
        [Description("Number of points allowed")]
        [DataMember(Name = "PointsAllowed", Order = 8)]
        public decimal PointsAllowed { get; set; }

        /// <summary>
        /// Defensive and special teams touchdowns scores
        /// </summary>
        [Description("Defensive and special teams touchdowns scores")]
        [DataMember(Name = "TouchdownsScored", Order = 9)]
        public decimal TouchdownsScored { get; set; }

        /// <summary>
        /// Total number solo tackles
        /// </summary>
        [Description("Total number solo tackles")]
        [DataMember(Name = "SoloTackles", Order = 10)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total number assisted tackles
        /// </summary>
        [Description("Total number assisted tackles")]
        [DataMember(Name = "AssistedTackles", Order = 11)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total number of sacks of the opposing quarterback
        /// </summary>
        [Description("Total number of sacks of the opposing quarterback")]
        [DataMember(Name = "Sacks", Order = 12)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total number of yards lost when sacking the opposing quarterback
        /// </summary>
        [Description("Total number of yards lost when sacking the opposing quarterback")]
        [DataMember(Name = "SackYards", Order = 13)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total number of passes defended
        /// </summary>
        [Description("Total number of passes defended")]
        [DataMember(Name = "PassesDefended", Order = 14)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total number of fumbles forced
        /// </summary>
        [Description("Total number of fumbles forced")]
        [DataMember(Name = "FumblesForced", Order = 15)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total number of fumbles recovered
        /// </summary>
        [Description("Total number of fumbles recovered")]
        [DataMember(Name = "FumblesRecovered", Order = 16)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total return yards from fumbles recovered
        /// </summary>
        [Description("Total return yards from fumbles recovered")]
        [DataMember(Name = "FumbleReturnYards", Order = 17)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total touchdowns from fumbles recovered
        /// </summary>
        [Description("Total touchdowns from fumbles recovered")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 18)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of interceptions
        /// </summary>
        [Description("Total number of interceptions")]
        [DataMember(Name = "Interceptions", Order = 19)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total number of interception return yards
        /// </summary>
        [Description("Total number of interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 20)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total number of interception returns for touchdowns
        /// </summary>
        [Description("Total number of interception returns for touchdowns")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 21)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of blocked field goals and blocked punts
        /// </summary>
        [Description("Total number of blocked field goals and blocked punts")]
        [DataMember(Name = "BlockedKicks", Order = 22)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// Total safeties scored
        /// </summary>
        [Description("Total safeties scored")]
        [DataMember(Name = "Safeties", Order = 23)]
        public decimal Safeties { get; set; }

        /// <summary>
        /// Total number of punt returns
        /// </summary>
        [Description("Total number of punt returns")]
        [DataMember(Name = "PuntReturns", Order = 24)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total number of punt return yards
        /// </summary>
        [Description("Total number of punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 25)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total number of punt returns for touchdowns
        /// </summary>
        [Description("Total number of punt returns for touchdowns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 26)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 27)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total number of kick returns
        /// </summary>
        [Description("Total number of kick returns")]
        [DataMember(Name = "KickReturns", Order = 28)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total number of kick return yards
        /// </summary>
        [Description("Total number of kick return yards")]
        [DataMember(Name = "KickReturnYards", Order = 29)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Total number of kick returns for touchdowns
        /// </summary>
        [Description("Total number of kick returns for touchdowns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 30)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "KickReturnLong", Order = 31)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Blocked kicks returned for a touchdown
        /// </summary>
        [Description("Blocked kicks returned for a touchdown")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 32)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal returns for touchdowns
        /// </summary>
        [Description("Field goal returns for touchdowns")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 33)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("Fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 34)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("Fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "QuarterbackFantasyPointsAllowed", Order = 35)]
        public decimal? QuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing running backs
        /// </summary>
        [Description("Fantasy points allowed to opposing running backs")]
        [DataMember(Name = "RunningbackFantasyPointsAllowed", Order = 36)]
        public decimal? RunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "WideReceiverFantasyPointsAllowed", Order = 37)]
        public decimal? WideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("Fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "TightEndFantasyPointsAllowed", Order = 38)]
        public decimal? TightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing kickers
        /// </summary>
        [Description("Fantasy points allowed to opposing kickers")]
        [DataMember(Name = "KickerFantasyPointsAllowed", Order = 39)]
        public decimal? KickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 40)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 41)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Quarterback hits
        /// </summary>
        [Description("Quarterback hits")]
        [DataMember(Name = "QuarterbackHits", Order = 42)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Tackles for a loss
        /// </summary>
        [Description("Tackles for a loss")]
        [DataMember(Name = "TacklesForLoss", Order = 43)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total touchdowns scored by the defense
        /// </summary>
        [Description("Total touchdowns scored by the defense")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 44)]
        public decimal? DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total touchdowns scored by the special teams
        /// </summary>
        [Description("Total touchdowns scored by the special teams")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 45)]
        public decimal? SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 46)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPoints", Order = 47)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 48)]
        public string Stadium { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Temperature", Order = 49)]
        public int? Temperature { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Humidity", Order = 50)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Humidity at game start (Percentage)
        /// </summary>
        [Description("Humidity at game start (Percentage)")]
        [DataMember(Name = "WindSpeed", Order = 51)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// Opponent's third down attempts
        /// </summary>
        [Description("Opponent's third down attempts")]
        [DataMember(Name = "ThirdDownAttempts", Order = 52)]
        public decimal? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Opponent's third down conversions
        /// </summary>
        [Description("Opponent's third down conversions")]
        [DataMember(Name = "ThirdDownConversions", Order = 53)]
        public decimal? ThirdDownConversions { get; set; }

        /// <summary>
        /// Opponent's fourth down attempts
        /// </summary>
        [Description("Opponent's fourth down attempts")]
        [DataMember(Name = "FourthDownAttempts", Order = 54)]
        public decimal? FourthDownAttempts { get; set; }

        /// <summary>
        /// Opponent's fourth down conversions
        /// </summary>
        [Description("Opponent's fourth down conversions")]
        [DataMember(Name = "FourthDownConversions", Order = 55)]
        public decimal? FourthDownConversions { get; set; }

        /// <summary>
        /// Number of points allowed to opposing offense and special teams.  This excludes points scored by the opponent's defense.
        /// </summary>
        [Description("Number of points allowed to opposing offense and special teams.  This excludes points scored by the opponent's defense.")]
        [DataMember(Name = "PointsAllowedByDefenseSpecialTeams", Order = 56)]
        public decimal? PointsAllowedByDefenseSpecialTeams { get; set; }

        /// <summary>
        /// The team's DEF/ST salary for FanDuel daily fantasy contests.
        /// </summary>
        [Description("The team's DEF/ST salary for FanDuel daily fantasy contests.")]
        [DataMember(Name = "FanDuelSalary", Order = 57)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The team's DEF/ST salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The team's DEF/ST salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 58)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The team's DST salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).
        /// </summary>
        [Description("The team's DST salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).")]
        [DataMember(Name = "FantasyDataSalary", Order = 59)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The player's salary for Victiv daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Victiv daily fantasy contests.")]
        [DataMember(Name = "VictivSalary", Order = 60)]
        public int? VictivSalary { get; set; }

        /// <summary>
        /// Two point conversions returned for two points.
        /// </summary>
        [Description("Two point conversions returned for two points.")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 61)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system.
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system.")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 62)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system.
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system.")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 63)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Offensive yards allowed by this team's defense.
        /// </summary>
        [Description("Offensive yards allowed by this team's defense.")]
        [DataMember(Name = "OffensiveYardsAllowed", Order = 64)]
        public decimal? OffensiveYardsAllowed { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 65)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// The team's unique PlayerID for use when combining with player feeds.
        /// </summary>
        [Description("The team's unique PlayerID for use when combining with player feeds.")]
        [DataMember(Name = "PlayerID", Order = 66)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 67)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Whether the Team is Home or Away (possible values: HOME, AWAY)
        /// </summary>
        [Description("Whether the Team is Home or Away (possible values: HOME, AWAY)")]
        [DataMember(Name = "HomeOrAway", Order = 68)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST.
        /// </summary>
        [Description("The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST.")]
        [DataMember(Name = "OpponentRank", Order = 69)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST.
        /// </summary>
        [Description("The ranking of the opposing team's offense with regards to fantasy points allowed to fantasy DST.")]
        [DataMember(Name = "OpponentPositionRank", Order = 70)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// The team's DEF/ST salary for FantasyDraft daily fantasy contests.
        /// </summary>
        [Description("The team's DEF/ST salary for FantasyDraft daily fantasy contests.")]
        [DataMember(Name = "FantasyDraftSalary", Order = 71)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// The ID of the team.
        /// </summary>
        [Description("The ID of the team.")]
        [DataMember(Name = "TeamID", Order = 72)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The ID of the team's opponent.
        /// </summary>
        [Description("The ID of the team's opponent.")]
        [DataMember(Name = "OpponentID", Order = 73)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The day of the game.
        /// </summary>
        [Description("The day of the game.")]
        [DataMember(Name = "Day", Order = 74)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time of the game.
        /// </summary>
        [Description("The date/time of the game.")]
        [DataMember(Name = "DateTime", Order = 75)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 76)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 77)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 78)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The position of this team's DEF/ST, as listed by DraftKings.
        /// </summary>
        [Description("The position of this team's DEF/ST, as listed by DraftKings.")]
        [DataMember(Name = "DraftKingsPosition", Order = 79)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The position of this team's DEF/ST, as listed by FanDuel.
        /// </summary>
        [Description("The position of this team's DEF/ST, as listed by FanDuel.")]
        [DataMember(Name = "FanDuelPosition", Order = 80)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The position of this team's DEF/ST, as listed by FantasyDraft.
        /// </summary>
        [Description("The position of this team's DEF/ST, as listed by FantasyDraft.")]
        [DataMember(Name = "FantasyDraftPosition", Order = 81)]
        public string FantasyDraftPosition { get; set; }

        /// <summary>
        /// The position of this team's DEF/ST, as listed by Yahoo DFS.
        /// </summary>
        [Description("The position of this team's DEF/ST, as listed by Yahoo DFS.")]
        [DataMember(Name = "YahooPosition", Order = 82)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// Unique ID of FantasyDefense record (subject to change, although it very rarely does).  For a guaranteed static ID, use a combination of GameKey and Team.
        /// </summary>
        [Description("Unique ID of FantasyDefense record (subject to change, although it very rarely does).  For a guaranteed static ID, use a combination of GameKey and Team.")]
        [DataMember(Name = "FantasyDefenseID", Order = 83)]
        public int? FantasyDefenseID { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 84)]
        public int ScoreID { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FanDuelFantasyPointsAllowed", Order = 85)]
        public decimal? FanDuelFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "FanDuelQuarterbackFantasyPointsAllowed", Order = 86)]
        public decimal? FanDuelQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing running backs
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing running backs")]
        [DataMember(Name = "FanDuelRunningbackFantasyPointsAllowed", Order = 87)]
        public decimal? FanDuelRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "FanDuelWideReceiverFantasyPointsAllowed", Order = 88)]
        public decimal? FanDuelWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "FanDuelTightEndFantasyPointsAllowed", Order = 89)]
        public decimal? FanDuelTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing kickers
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing kickers")]
        [DataMember(Name = "FanDuelKickerFantasyPointsAllowed", Order = 90)]
        public decimal? FanDuelKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "DraftKingsFantasyPointsAllowed", Order = 91)]
        public decimal? DraftKingsFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "DraftKingsQuarterbackFantasyPointsAllowed", Order = 92)]
        public decimal? DraftKingsQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing running backs
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing running backs")]
        [DataMember(Name = "DraftKingsRunningbackFantasyPointsAllowed", Order = 93)]
        public decimal? DraftKingsRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "DraftKingsWideReceiverFantasyPointsAllowed", Order = 94)]
        public decimal? DraftKingsWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "DraftKingsTightEndFantasyPointsAllowed", Order = 95)]
        public decimal? DraftKingsTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing kickers
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing kickers")]
        [DataMember(Name = "DraftKingsKickerFantasyPointsAllowed", Order = 96)]
        public decimal? DraftKingsKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "YahooFantasyPointsAllowed", Order = 97)]
        public decimal? YahooFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "YahooQuarterbackFantasyPointsAllowed", Order = 98)]
        public decimal? YahooQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing running backs
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing running backs")]
        [DataMember(Name = "YahooRunningbackFantasyPointsAllowed", Order = 99)]
        public decimal? YahooRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "YahooWideReceiverFantasyPointsAllowed", Order = 100)]
        public decimal? YahooWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "YahooTightEndFantasyPointsAllowed", Order = 101)]
        public decimal? YahooTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing kickers
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing kickers")]
        [DataMember(Name = "YahooKickerFantasyPointsAllowed", Order = 102)]
        public decimal? YahooKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points based on FantasyDraft's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on FantasyDraft's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 103)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FantasyDraftFantasyPointsAllowed", Order = 104)]
        public decimal? FantasyDraftFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "FantasyDraftQuarterbackFantasyPointsAllowed", Order = 105)]
        public decimal? FantasyDraftQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing running backs
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing running backs")]
        [DataMember(Name = "FantasyDraftRunningbackFantasyPointsAllowed", Order = 106)]
        public decimal? FantasyDraftRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "FantasyDraftWideReceiverFantasyPointsAllowed", Order = 107)]
        public decimal? FantasyDraftWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "FantasyDraftTightEndFantasyPointsAllowed", Order = 108)]
        public decimal? FantasyDraftTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing kickers
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing kickers")]
        [DataMember(Name = "FantasyDraftKickerFantasyPointsAllowed", Order = 109)]
        public decimal? FantasyDraftKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// The details of the scoring plays this fantasy DST recorded
        /// </summary>
        [Description("The details of the scoring plays this fantasy DST recorded")]
        [DataMember(Name = "ScoringDetails", Order = 20110)]
        public ScoringDetail[] ScoringDetails { get; set; }

    }
}

