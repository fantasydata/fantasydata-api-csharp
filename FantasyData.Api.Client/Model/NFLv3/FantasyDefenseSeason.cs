using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="FantasyDefenseSeason")]
    [Serializable]
    public partial class FantasyDefenseSeason
    {
        /// <summary>
        /// The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL regular season for which these totals apply
        /// </summary>
        [Description("The NFL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// Total points allowed by the team during the season
        /// </summary>
        [Description("Total points allowed by the team during the season")]
        [DataMember(Name = "PointsAllowed", Order = 4)]
        public decimal PointsAllowed { get; set; }

        /// <summary>
        /// Total defensive and special teams touchdowns scored by the team in the season
        /// </summary>
        [Description("Total defensive and special teams touchdowns scored by the team in the season")]
        [DataMember(Name = "TouchdownsScored", Order = 5)]
        public decimal TouchdownsScored { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the team in the season
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the team in the season")]
        [DataMember(Name = "SoloTackles", Order = 6)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the team in the season
        /// </summary>
        [Description("Total defensive assisted tackles by the team in the season")]
        [DataMember(Name = "AssistedTackles", Order = 7)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the team in the season
        /// </summary>
        [Description("Total defensive sacks by the team in the season")]
        [DataMember(Name = "Sacks", Order = 8)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the team in the season
        /// </summary>
        [Description("Total defensive sack yards by the team in the season")]
        [DataMember(Name = "SackYards", Order = 9)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total passes defended by the team in the season
        /// </summary>
        [Description("Total passes defended by the team in the season")]
        [DataMember(Name = "PassesDefended", Order = 10)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the team in the season
        /// </summary>
        [Description("Total fumbles forced on defense by the team in the season")]
        [DataMember(Name = "FumblesForced", Order = 11)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the team in the season
        /// </summary>
        [Description("Total defensive fumble recoveries by the team in the season")]
        [DataMember(Name = "FumblesRecovered", Order = 12)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the team in the season
        /// </summary>
        [Description("Total fumble return yards by the team in the season")]
        [DataMember(Name = "FumbleReturnYards", Order = 13)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the team in the season
        /// </summary>
        [Description("Total fumble return touchdowns by the team in the season")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 14)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interceptions by the team in the season
        /// </summary>
        [Description("Total defensive interceptions by the team in the season")]
        [DataMember(Name = "Interceptions", Order = 15)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the team in the season
        /// </summary>
        [Description("Total defensive interception return yards by the team in the season")]
        [DataMember(Name = "InterceptionReturnYards", Order = 16)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the team in the season
        /// </summary>
        [Description("Total defensive interception return touchdowns by the team in the season")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 17)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by the team in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by the team in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 18)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the team in the season
        /// </summary>
        [Description("Total defensive safeties scored by the team in the season")]
        [DataMember(Name = "Safeties", Order = 19)]
        public decimal Safeties { get; set; }

        /// <summary>
        /// Total punt returns by the team in the season
        /// </summary>
        [Description("Total punt returns by the team in the season")]
        [DataMember(Name = "PuntReturns", Order = 20)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the team in the season
        /// </summary>
        [Description("Total punt return yards by the team in the season")]
        [DataMember(Name = "PuntReturnYards", Order = 21)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the team in the season
        /// </summary>
        [Description("Total punt return touchdowns by the team in the season")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 22)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the team in the season
        /// </summary>
        [Description("The longest punt return by the team in the season")]
        [DataMember(Name = "PuntReturnLong", Order = 23)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff returns by the team in the season
        /// </summary>
        [Description("Total kickoff returns by the team in the season")]
        [DataMember(Name = "KickReturns", Order = 24)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the team in the season
        /// </summary>
        [Description("Total kickoff return yards by the team in the season")]
        [DataMember(Name = "KickReturnYards", Order = 25)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the team in the season
        /// </summary>
        [Description("Total kickoff return touchdowns by the team in the season")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 26)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the team in the season
        /// </summary>
        [Description("Longest kick return by the team in the season")]
        [DataMember(Name = "KickReturnLong", Order = 27)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the team in the season
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the team in the season")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 28)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the team in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the team in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 29)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("Fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 30)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing quarterbacks by the team in the season
        /// </summary>
        [Description("Fantasy points allowed to opposing quarterbacks by the team in the season")]
        [DataMember(Name = "QuarterbackFantasyPointsAllowed", Order = 31)]
        public decimal? QuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total fantasy points allowed to opposing running backs by the team in the season
        /// </summary>
        [Description("Total fantasy points allowed to opposing running backs by the team in the season")]
        [DataMember(Name = "RunningbackFantasyPointsAllowed", Order = 32)]
        public decimal? RunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "WideReceiverFantasyPointsAllowed", Order = 33)]
        public decimal? WideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing tight ends by the team in the season
        /// </summary>
        [Description("Fantasy points allowed to opposing tight ends by the team in the season")]
        [DataMember(Name = "TightEndFantasyPointsAllowed", Order = 34)]
        public decimal? TightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opponent kickers by the team in the season
        /// </summary>
        [Description("Fantasy points allowed to opponent kickers by the team in the season")]
        [DataMember(Name = "KickerFantasyPointsAllowed", Order = 35)]
        public decimal? KickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// The total number of games played by the team in the season
        /// </summary>
        [Description("The total number of games played by the team in the season")]
        [DataMember(Name = "Games", Order = 36)]
        public int? Games { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the team in the season
        /// </summary>
        [Description("Total blocked kick recovery return yards for the team in the season")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 37)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total field goal return yards by the team in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the team in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 38)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the team in the season. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the team in the season. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 39)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the team in the season. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the team in the season. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 40)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total defensive touchdowns scored by the team in the season
        /// </summary>
        [Description("Total defensive touchdowns scored by the team in the season")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 41)]
        public decimal? DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total special teams touchdowns scored by the team in the season
        /// </summary>
        [Description("Total special teams touchdowns scored by the team in the season")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 42)]
        public decimal? SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system by the team in the season
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system by the team in the season")]
        [DataMember(Name = "FantasyPoints", Order = 43)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 44)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 45)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
        [DataMember(Name = "WindSpeed", Order = 46)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// Total third down attempts against the team in the season
        /// </summary>
        [Description("Total third down attempts against the team in the season")]
        [DataMember(Name = "ThirdDownAttempts", Order = 47)]
        public decimal? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Total third down conversions against the team in the season
        /// </summary>
        [Description("Total third down conversions against the team in the season")]
        [DataMember(Name = "ThirdDownConversions", Order = 48)]
        public decimal? ThirdDownConversions { get; set; }

        /// <summary>
        /// Opponent's fourth down attempts against the team in the season
        /// </summary>
        [Description("Opponent's fourth down attempts against the team in the season")]
        [DataMember(Name = "FourthDownAttempts", Order = 49)]
        public decimal? FourthDownAttempts { get; set; }

        /// <summary>
        /// Opponent's fourth down conversions against the team in the season
        /// </summary>
        [Description("Opponent's fourth down conversions against the team in the season")]
        [DataMember(Name = "FourthDownConversions", Order = 50)]
        public decimal? FourthDownConversions { get; set; }

        /// <summary>
        /// Total number of points allowed by the team in the season to the opposing offense and special teams. Note: This field excludes points scored by the opponent's defense
        /// </summary>
        [Description("Total number of points allowed by the team in the season to the opposing offense and special teams. Note: This field excludes points scored by the opponent's defense")]
        [DataMember(Name = "PointsAllowedByDefenseSpecialTeams", Order = 51)]
        public decimal? PointsAllowedByDefenseSpecialTeams { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap auction draft.")]
        [DataMember(Name = "AuctionValue", Order = 52)]
        public decimal? AuctionValue { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap PPR auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap PPR auction draft.")]
        [DataMember(Name = "AuctionValuePPR", Order = 53)]
        public decimal? AuctionValuePPR { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the team in the season
        /// </summary>
        [Description("Total successful two point conversion returns by the team in the season")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 54)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system by the team in the season
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system by the team in the season")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 55)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system by the team in the season
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system by the team in the season")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 56)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Offensive yards allowed by the team's defense in the season
        /// </summary>
        [Description("Offensive yards allowed by the team's defense in the season")]
        [DataMember(Name = "OffensiveYardsAllowed", Order = 57)]
        public decimal? OffensiveYardsAllowed { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO for use when combining with player feeds. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO for use when combining with player feeds. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 58)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system by the team in the season
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system by the team in the season")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 59)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The average draft position of the team's fantasy defense (DST) in re-draft leagues
        /// </summary>
        [Description("The average draft position of the team's fantasy defense (DST) in re-draft leagues")]
        [DataMember(Name = "AverageDraftPosition", Order = 60)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The average draft position of the team (DST) in Points Per Reception (PPR) leagues
        /// </summary>
        [Description("The average draft position of the team (DST) in Points Per Reception (PPR) leagues")]
        [DataMember(Name = "AverageDraftPositionPPR", Order = 61)]
        public decimal? AverageDraftPositionPPR { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 62)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 63)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FanDuelFantasyPointsAllowed", Order = 64)]
        public decimal? FanDuelFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing quarterbacks in the season
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing quarterbacks in the season")]
        [DataMember(Name = "FanDuelQuarterbackFantasyPointsAllowed", Order = 65)]
        public decimal? FanDuelQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing running backs in the season
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing running backs in the season")]
        [DataMember(Name = "FanDuelRunningbackFantasyPointsAllowed", Order = 66)]
        public decimal? FanDuelRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing wide receivers in the season
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing wide receivers in the season")]
        [DataMember(Name = "FanDuelWideReceiverFantasyPointsAllowed", Order = 67)]
        public decimal? FanDuelWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing tight ends in the season
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing tight ends in the season")]
        [DataMember(Name = "FanDuelTightEndFantasyPointsAllowed", Order = 68)]
        public decimal? FanDuelTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed by the team to opposing kickers in the season
        /// </summary>
        [Description("FanDuel fantasy points allowed by the team to opposing kickers in the season")]
        [DataMember(Name = "FanDuelKickerFantasyPointsAllowed", Order = 69)]
        public decimal? FanDuelKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "DraftKingsFantasyPointsAllowed", Order = 70)]
        public decimal? DraftKingsFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent quarterbacks in the season
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent quarterbacks in the season")]
        [DataMember(Name = "DraftKingsQuarterbackFantasyPointsAllowed", Order = 71)]
        public decimal? DraftKingsQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent running backs in the season
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent running backs in the season")]
        [DataMember(Name = "DraftKingsRunningbackFantasyPointsAllowed", Order = 72)]
        public decimal? DraftKingsRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent wide receivers in the season
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent wide receivers in the season")]
        [DataMember(Name = "DraftKingsWideReceiverFantasyPointsAllowed", Order = 73)]
        public decimal? DraftKingsWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent tight ends in the season
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent tight ends in the season")]
        [DataMember(Name = "DraftKingsTightEndFantasyPointsAllowed", Order = 74)]
        public decimal? DraftKingsTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed by the team to opponent kickers in the season
        /// </summary>
        [Description("DraftKings fantasy points allowed by the team to opponent kickers in the season")]
        [DataMember(Name = "DraftKingsKickerFantasyPointsAllowed", Order = 75)]
        public decimal? DraftKingsKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing offensive players by the team in the season. Note: Offensive players include: QB, RB, WR, & TE
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing offensive players by the team in the season. Note: Offensive players include: QB, RB, WR, & TE")]
        [DataMember(Name = "YahooFantasyPointsAllowed", Order = 76)]
        public decimal? YahooFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing quarterbacks by the team in the season
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing quarterbacks by the team in the season")]
        [DataMember(Name = "YahooQuarterbackFantasyPointsAllowed", Order = 77)]
        public decimal? YahooQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing running backs by the team in the season
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing running backs by the team in the season")]
        [DataMember(Name = "YahooRunningbackFantasyPointsAllowed", Order = 78)]
        public decimal? YahooRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing wide receivers by the team in the season
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing wide receivers by the team in the season")]
        [DataMember(Name = "YahooWideReceiverFantasyPointsAllowed", Order = 79)]
        public decimal? YahooWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing tight ends by the team in the season
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing tight ends by the team in the season")]
        [DataMember(Name = "YahooTightEndFantasyPointsAllowed", Order = 80)]
        public decimal? YahooTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points allowed to opposing kickers by the team in the season
        /// </summary>
        [Description("Total Yahoo fantasy points allowed to opposing kickers by the team in the season")]
        [DataMember(Name = "YahooKickerFantasyPointsAllowed", Order = 81)]
        public decimal? YahooKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points based on FanDraft's scoring system by the team in the season
        /// </summary>
        [Description("Fantasy points based on FanDraft's scoring system by the team in the season")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 82)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing offensive players in the season. Note: positions include: QB; RB; WR; TE")]
        [DataMember(Name = "FantasyDraftFantasyPointsAllowed", Order = 83)]
        public decimal? FantasyDraftFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing quarterbacks in the season
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing quarterbacks in the season")]
        [DataMember(Name = "FantasyDraftQuarterbackFantasyPointsAllowed", Order = 84)]
        public decimal? FantasyDraftQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing running backs in the season
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing running backs in the season")]
        [DataMember(Name = "FantasyDraftRunningbackFantasyPointsAllowed", Order = 85)]
        public decimal? FantasyDraftRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing wide receivers in the season
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing wide receivers in the season")]
        [DataMember(Name = "FantasyDraftWideReceiverFantasyPointsAllowed", Order = 86)]
        public decimal? FantasyDraftWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing tight ends in the season
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing tight ends in the season")]
        [DataMember(Name = "FantasyDraftTightEndFantasyPointsAllowed", Order = 87)]
        public decimal? FantasyDraftTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed by the team to opposing kickers in the season
        /// </summary>
        [Description("FantasyDraft fantasy points allowed by the team to opposing kickers in the season")]
        [DataMember(Name = "FantasyDraftKickerFantasyPointsAllowed", Order = 88)]
        public decimal? FantasyDraftKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// The details of the scoring plays this team DST recorded in the season
        /// </summary>
        [Description("The details of the scoring plays this team DST recorded in the season")]
        [DataMember(Name = "ScoringDetails", Order = 20089)]
        public ScoringDetail[] ScoringDetails { get; set; }

        /// <summary>
        /// The average draft position of this team (DST) in dynasty drafts leagues
        /// </summary>
        [Description("The average draft position of this team (DST) in dynasty drafts leagues")]
        [DataMember(Name = "AverageDraftPositionDynasty", Order = 90)]
        public decimal? AverageDraftPositionDynasty { get; set; }

        /// <summary>
        /// The average draft position of the team (DST) in 2 Quarterback leagues
        /// </summary>
        [Description("The average draft position of the team (DST) in 2 Quarterback leagues")]
        [DataMember(Name = "AverageDraftPosition2QB", Order = 91)]
        public decimal? AverageDraftPosition2QB { get; set; }

    }
}

