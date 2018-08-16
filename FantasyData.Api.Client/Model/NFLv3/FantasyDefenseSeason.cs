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
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL regular season for which these totals apply
        /// </summary>
        [Description("The NFL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// Number of points allowed
        /// </summary>
        [Description("Number of points allowed")]
        [DataMember(Name = "PointsAllowed", Order = 4)]
        public decimal PointsAllowed { get; set; }

        /// <summary>
        /// Defensive and special teams touchdowns scores
        /// </summary>
        [Description("Defensive and special teams touchdowns scores")]
        [DataMember(Name = "TouchdownsScored", Order = 5)]
        public decimal TouchdownsScored { get; set; }

        /// <summary>
        /// Total number solo tackles
        /// </summary>
        [Description("Total number solo tackles")]
        [DataMember(Name = "SoloTackles", Order = 6)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total number assisted tackles
        /// </summary>
        [Description("Total number assisted tackles")]
        [DataMember(Name = "AssistedTackles", Order = 7)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total number of sacks of the opposing quarterback
        /// </summary>
        [Description("Total number of sacks of the opposing quarterback")]
        [DataMember(Name = "Sacks", Order = 8)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total number of yards lost when sacking the opposing quarterback
        /// </summary>
        [Description("Total number of yards lost when sacking the opposing quarterback")]
        [DataMember(Name = "SackYards", Order = 9)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total number of passes defended
        /// </summary>
        [Description("Total number of passes defended")]
        [DataMember(Name = "PassesDefended", Order = 10)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total number of fumbles forced
        /// </summary>
        [Description("Total number of fumbles forced")]
        [DataMember(Name = "FumblesForced", Order = 11)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total number of fumbles recovered
        /// </summary>
        [Description("Total number of fumbles recovered")]
        [DataMember(Name = "FumblesRecovered", Order = 12)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total return yards from fumbles recovered
        /// </summary>
        [Description("Total return yards from fumbles recovered")]
        [DataMember(Name = "FumbleReturnYards", Order = 13)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total touchdowns from fumbles recovered
        /// </summary>
        [Description("Total touchdowns from fumbles recovered")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 14)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of interceptions
        /// </summary>
        [Description("Total number of interceptions")]
        [DataMember(Name = "Interceptions", Order = 15)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total number of interception return yards
        /// </summary>
        [Description("Total number of interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 16)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total number of interception returns for touchdowns
        /// </summary>
        [Description("Total number of interception returns for touchdowns")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 17)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of blocked field goals and blocked punts
        /// </summary>
        [Description("Total number of blocked field goals and blocked punts")]
        [DataMember(Name = "BlockedKicks", Order = 18)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// Total safeties scored
        /// </summary>
        [Description("Total safeties scored")]
        [DataMember(Name = "Safeties", Order = 19)]
        public decimal Safeties { get; set; }

        /// <summary>
        /// Total number of punt returns
        /// </summary>
        [Description("Total number of punt returns")]
        [DataMember(Name = "PuntReturns", Order = 20)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total number of punt return yards
        /// </summary>
        [Description("Total number of punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 21)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total number of punt returns for touchdowns
        /// </summary>
        [Description("Total number of punt returns for touchdowns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 22)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 23)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total number of kick returns
        /// </summary>
        [Description("Total number of kick returns")]
        [DataMember(Name = "KickReturns", Order = 24)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total number of kick return yards
        /// </summary>
        [Description("Total number of kick return yards")]
        [DataMember(Name = "KickReturnYards", Order = 25)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Total number of kick returns for touchdowns
        /// </summary>
        [Description("Total number of kick returns for touchdowns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 26)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "KickReturnLong", Order = 27)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Blocked kicks returned for a touchdown
        /// </summary>
        [Description("Blocked kicks returned for a touchdown")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 28)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal returns for touchdowns
        /// </summary>
        [Description("Field goal returns for touchdowns")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 29)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("Fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 30)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("Fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "QuarterbackFantasyPointsAllowed", Order = 31)]
        public decimal? QuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing running backs
        /// </summary>
        [Description("Fantasy points allowed to opposing running backs")]
        [DataMember(Name = "RunningbackFantasyPointsAllowed", Order = 32)]
        public decimal? RunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "WideReceiverFantasyPointsAllowed", Order = 33)]
        public decimal? WideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("Fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "TightEndFantasyPointsAllowed", Order = 34)]
        public decimal? TightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points allowed to opposing kickers
        /// </summary>
        [Description("Fantasy points allowed to opposing kickers")]
        [DataMember(Name = "KickerFantasyPointsAllowed", Order = 35)]
        public decimal? KickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Games played
        /// </summary>
        [Description("Games played")]
        [DataMember(Name = "Games", Order = 36)]
        public int? Games { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 37)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 38)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Quarterback hits
        /// </summary>
        [Description("Quarterback hits")]
        [DataMember(Name = "QuarterbackHits", Order = 39)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Tackles for a loss
        /// </summary>
        [Description("Tackles for a loss")]
        [DataMember(Name = "TacklesForLoss", Order = 40)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total touchdowns scored by the defense
        /// </summary>
        [Description("Total touchdowns scored by the defense")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 41)]
        public decimal? DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total touchdowns scored by the special teams
        /// </summary>
        [Description("Total touchdowns scored by the special teams")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 42)]
        public decimal? SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPoints", Order = 43)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Temperature", Order = 44)]
        public int? Temperature { get; set; }

        /// <summary>
        /// Humidity at game start (Percentage)
        /// </summary>
        [Description("Humidity at game start (Percentage)")]
        [DataMember(Name = "Humidity", Order = 45)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Wind speed at game start (MPH)
        /// </summary>
        [Description("Wind speed at game start (MPH)")]
        [DataMember(Name = "WindSpeed", Order = 46)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// Opponent's third down attempts
        /// </summary>
        [Description("Opponent's third down attempts")]
        [DataMember(Name = "ThirdDownAttempts", Order = 47)]
        public decimal? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Opponent's third down conversions
        /// </summary>
        [Description("Opponent's third down conversions")]
        [DataMember(Name = "ThirdDownConversions", Order = 48)]
        public decimal? ThirdDownConversions { get; set; }

        /// <summary>
        /// Opponent's fourth down attempts
        /// </summary>
        [Description("Opponent's fourth down attempts")]
        [DataMember(Name = "FourthDownAttempts", Order = 49)]
        public decimal? FourthDownAttempts { get; set; }

        /// <summary>
        /// Opponent's fourth down conversions
        /// </summary>
        [Description("Opponent's fourth down conversions")]
        [DataMember(Name = "FourthDownConversions", Order = 50)]
        public decimal? FourthDownConversions { get; set; }

        /// <summary>
        /// Number of points allowed to opposing offense and special teams.  This excludes points scored by the opponent's defense.
        /// </summary>
        [Description("Number of points allowed to opposing offense and special teams.  This excludes points scored by the opponent's defense.")]
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
        /// Two point conversions returned for two points.
        /// </summary>
        [Description("Two point conversions returned for two points.")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 54)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system.
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system.")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 55)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system.
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system.")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 56)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Offensive yards allowed by this team's defense.
        /// </summary>
        [Description("Offensive yards allowed by this team's defense.")]
        [DataMember(Name = "OffensiveYardsAllowed", Order = 57)]
        public decimal? OffensiveYardsAllowed { get; set; }

        /// <summary>
        /// The team's unique PlayerID for use when mixing with player feeds.
        /// </summary>
        [Description("The team's unique PlayerID for use when mixing with player feeds.")]
        [DataMember(Name = "PlayerID", Order = 58)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 59)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The average draft position of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPosition", Order = 60)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The average draft position in PPR leagues of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position in PPR leagues of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPositionPPR", Order = 61)]
        public decimal? AverageDraftPositionPPR { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 62)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 63)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FanDuelFantasyPointsAllowed", Order = 64)]
        public decimal? FanDuelFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "FanDuelQuarterbackFantasyPointsAllowed", Order = 65)]
        public decimal? FanDuelQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing running backs
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing running backs")]
        [DataMember(Name = "FanDuelRunningbackFantasyPointsAllowed", Order = 66)]
        public decimal? FanDuelRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "FanDuelWideReceiverFantasyPointsAllowed", Order = 67)]
        public decimal? FanDuelWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "FanDuelTightEndFantasyPointsAllowed", Order = 68)]
        public decimal? FanDuelTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FanDuel fantasy points allowed to opposing kickers
        /// </summary>
        [Description("FanDuel fantasy points allowed to opposing kickers")]
        [DataMember(Name = "FanDuelKickerFantasyPointsAllowed", Order = 69)]
        public decimal? FanDuelKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "DraftKingsFantasyPointsAllowed", Order = 70)]
        public decimal? DraftKingsFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "DraftKingsQuarterbackFantasyPointsAllowed", Order = 71)]
        public decimal? DraftKingsQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing running backs
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing running backs")]
        [DataMember(Name = "DraftKingsRunningbackFantasyPointsAllowed", Order = 72)]
        public decimal? DraftKingsRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "DraftKingsWideReceiverFantasyPointsAllowed", Order = 73)]
        public decimal? DraftKingsWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "DraftKingsTightEndFantasyPointsAllowed", Order = 74)]
        public decimal? DraftKingsTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// DraftKings fantasy points allowed to opposing kickers
        /// </summary>
        [Description("DraftKings fantasy points allowed to opposing kickers")]
        [DataMember(Name = "DraftKingsKickerFantasyPointsAllowed", Order = 75)]
        public decimal? DraftKingsKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "YahooFantasyPointsAllowed", Order = 76)]
        public decimal? YahooFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "YahooQuarterbackFantasyPointsAllowed", Order = 77)]
        public decimal? YahooQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing running backs
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing running backs")]
        [DataMember(Name = "YahooRunningbackFantasyPointsAllowed", Order = 78)]
        public decimal? YahooRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "YahooWideReceiverFantasyPointsAllowed", Order = 79)]
        public decimal? YahooWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "YahooTightEndFantasyPointsAllowed", Order = 80)]
        public decimal? YahooTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Yahoo fantasy points allowed to opposing kickers
        /// </summary>
        [Description("Yahoo fantasy points allowed to opposing kickers")]
        [DataMember(Name = "YahooKickerFantasyPointsAllowed", Order = 81)]
        public decimal? YahooKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// Fantasy points based on FantasyDraft's daily fantasy scoring system.
        /// </summary>
        [Description("Fantasy points based on FantasyDraft's daily fantasy scoring system.")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 82)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing offensive players (QB, RB, WR and TE)
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing offensive players (QB, RB, WR and TE)")]
        [DataMember(Name = "FantasyDraftFantasyPointsAllowed", Order = 83)]
        public decimal? FantasyDraftFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing quarterbacks
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing quarterbacks")]
        [DataMember(Name = "FantasyDraftQuarterbackFantasyPointsAllowed", Order = 84)]
        public decimal? FantasyDraftQuarterbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing running backs
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing running backs")]
        [DataMember(Name = "FantasyDraftRunningbackFantasyPointsAllowed", Order = 85)]
        public decimal? FantasyDraftRunningbackFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing wide receivers
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing wide receivers")]
        [DataMember(Name = "FantasyDraftWideReceiverFantasyPointsAllowed", Order = 86)]
        public decimal? FantasyDraftWideReceiverFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing tight ends
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing tight ends")]
        [DataMember(Name = "FantasyDraftTightEndFantasyPointsAllowed", Order = 87)]
        public decimal? FantasyDraftTightEndFantasyPointsAllowed { get; set; }

        /// <summary>
        /// FantasyDraft fantasy points allowed to opposing kickers
        /// </summary>
        [Description("FantasyDraft fantasy points allowed to opposing kickers")]
        [DataMember(Name = "FantasyDraftKickerFantasyPointsAllowed", Order = 88)]
        public decimal? FantasyDraftKickerFantasyPointsAllowed { get; set; }

        /// <summary>
        /// The details of the scoring plays this fantasy DST recorded
        /// </summary>
        [Description("The details of the scoring plays this fantasy DST recorded")]
        [DataMember(Name = "ScoringDetails", Order = 20089)]
        public ScoringDetail[] ScoringDetails { get; set; }

        /// <summary>
        /// The average draft position of the team's fantasy defense (DST) in dynasty leagues
        /// </summary>
        [Description("The average draft position of the team's fantasy defense (DST) in dynasty leagues")]
        [DataMember(Name = "AverageDraftPositionDynasty", Order = 90)]
        public decimal? AverageDraftPositionDynasty { get; set; }

        /// <summary>
        /// The average draft position of the team's fantasy defense (DST) in 2 Quarterback Leagues
        /// </summary>
        [Description("The average draft position of the team's fantasy defense (DST) in 2 Quarterback Leagues")]
        [DataMember(Name = "AverageDraftPosition2QB", Order = 91)]
        public decimal? AverageDraftPosition2QB { get; set; }

    }
}

