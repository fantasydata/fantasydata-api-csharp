using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerSeason")]
    [Serializable]
    public partial class AdvancedPlayerSeason
    {
        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Full name of the player (Cam Newton, Aaron Rodgers, etc.)
        /// </summary>
        [Description("Full name of the player (Cam Newton, Aaron Rodgers, etc.)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.
        /// </summary>
        [Description("The abbreviation of the team this player is employed by, or if currently unemployed, the most recent team this player was employed by.")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Player's primary position. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR
        /// </summary>
        [Description("Player's primary position. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 6)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Player Position Group (QB, RB, WR, TE, DL, LB, DB, K, P, OL)
        /// </summary>
        [Description("Player Position Group (QB, RB, WR, TE, DL, LB, DB, K, P, OL)")]
        [DataMember(Name = "PositionGroup", Order = 7)]
        public string PositionGroup { get; set; }

        /// <summary>
        /// The year of the season in question.
        /// </summary>
        [Description("The year of the season in question.")]
        [DataMember(Name = "Season", Order = 8)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 9)]
        public int SeasonType { get; set; }

        /// <summary>
        /// How many games in which the player took part in at least one snap.
        /// </summary>
        [Description("How many games in which the player took part in at least one snap.")]
        [DataMember(Name = "Games", Order = 10)]
        public int? Games { get; set; }

        /// <summary>
        /// How many snaps the player took part in over the course of the season.
        /// </summary>
        [Description("How many snaps the player took part in over the course of the season.")]
        [DataMember(Name = "Snaps", Order = 11)]
        public decimal? Snaps { get; set; }

        /// <summary>
        /// The percentage of total offensive plays that had this player on the field.
        /// </summary>
        [Description("The percentage of total offensive plays that had this player on the field.")]
        [DataMember(Name = "SnapShare", Order = 12)]
        public decimal? SnapShare { get; set; }

        /// <summary>
        /// This player's Snap Share ranking relative to other players.
        /// </summary>
        [Description("This player's Snap Share ranking relative to other players.")]
        [DataMember(Name = "SnapShareRank", Order = 13)]
        public int? SnapShareRank { get; set; }

        /// <summary>
        /// The percentage of times in which the player was in the slot when the team ran a play with a slot player.
        /// </summary>
        [Description("The percentage of times in which the player was in the slot when the team ran a play with a slot player.")]
        [DataMember(Name = "SlotRate", Order = 14)]
        public decimal? SlotRate { get; set; }

        /// <summary>
        /// This receiver's Slot Rate ranking relative to other players
        /// </summary>
        [Description("This receiver's Slot Rate ranking relative to other players")]
        [DataMember(Name = "SlotRateRank", Order = 15)]
        public int? SlotRateRank { get; set; }

        /// <summary>
        /// A receiver's average yards of distance from his assigned defender at the moment the pass arrives..
        /// </summary>
        [Description("A receiver's average yards of distance from his assigned defender at the moment the pass arrives..")]
        [DataMember(Name = "TargetSeparation", Order = 16)]
        public decimal? TargetSeparation { get; set; }

        /// <summary>
        /// 	This player's Target Separation ranking relative to other players.
        /// </summary>
        [Description("	This player's Target Separation ranking relative to other players.")]
        [DataMember(Name = "TargetSeparationRank", Order = 17)]
        public int? TargetSeparationRank { get; set; }

        /// <summary>
        /// Percentage of allowed targets in which the defensive back's assigned receiver gained more than five yards of downfield separation.
        /// </summary>
        [Description("Percentage of allowed targets in which the defensive back's assigned receiver gained more than five yards of downfield separation.")]
        [DataMember(Name = "BurnRate", Order = 18)]
        public decimal? BurnRate { get; set; }

        /// <summary>
        /// For quarterbacks, Air Yards is the total throw depth. For wide receivers and tight ends, Air Yards is the total target distance from the line of scrimmage to the catch point.
        /// </summary>
        [Description("For quarterbacks, Air Yards is the total throw depth. For wide receivers and tight ends, Air Yards is the total target distance from the line of scrimmage to the catch point.")]
        [DataMember(Name = "AirYards", Order = 19)]
        public decimal? AirYards { get; set; }

        /// <summary>
        /// An average of total Air Yards divided by games played.
        /// </summary>
        [Description("An average of total Air Yards divided by games played.")]
        [DataMember(Name = "AirYardsPerGame", Order = 20)]
        public decimal? AirYardsPerGame { get; set; }

        /// <summary>
        /// The player's air yards ranking relative to other players
        /// </summary>
        [Description("The player's air yards ranking relative to other players")]
        [DataMember(Name = "AirYardsRank", Order = 21)]
        public int? AirYardsRank { get; set; }

        /// <summary>
        /// The number of times the player carried the ball in a rushing play.
        /// </summary>
        [Description("The number of times the player carried the ball in a rushing play.")]
        [DataMember(Name = "Carries", Order = 22)]
        public decimal? Carries { get; set; }

        /// <summary>
        /// The number of times the player carried the ball in a rushing play inside the 10-yard line.
        /// </summary>
        [Description("The number of times the player carried the ball in a rushing play inside the 10-yard line.")]
        [DataMember(Name = "CarriesInside10", Order = 23)]
        public decimal? CarriesInside10 { get; set; }

        /// <summary>
        /// The average number of times the player carried the ball in a rushing play inside the 10-yard line per game.
        /// </summary>
        [Description("The average number of times the player carried the ball in a rushing play inside the 10-yard line per game.")]
        [DataMember(Name = "CarriesInside10PerGame", Order = 24)]
        public decimal? CarriesInside10PerGame { get; set; }

        /// <summary>
        /// The number of times the player carried the ball in a rushing play inside the 5-yard line.
        /// </summary>
        [Description("The number of times the player carried the ball in a rushing play inside the 5-yard line.")]
        [DataMember(Name = "CarriesInside5", Order = 25)]
        public decimal? CarriesInside5 { get; set; }

        /// <summary>
        /// The average number of times the player carried the ball in a rushing play inside the 5-yard line per game.
        /// </summary>
        [Description("The average number of times the player carried the ball in a rushing play inside the 5-yard line per game.")]
        [DataMember(Name = "CarriesInside5PerGame", Order = 26)]
        public decimal? CarriesInside5PerGame { get; set; }

        /// <summary>
        /// The average number of times the player carried per game.
        /// </summary>
        [Description("The average number of times the player carried per game.")]
        [DataMember(Name = "CarriesPerGame", Order = 27)]
        public decimal? CarriesPerGame { get; set; }

        /// <summary>
        /// The player's carries per game relative to other players
        /// </summary>
        [Description("The player's carries per game relative to other players")]
        [DataMember(Name = "CarriesPerGameRank", Order = 28)]
        public int? CarriesPerGameRank { get; set; }

        /// <summary>
        /// The player's Carries ranking relative to other players
        /// </summary>
        [Description("The player's Carries ranking relative to other players")]
        [DataMember(Name = "CarriesRank", Order = 29)]
        public int? CarriesRank { get; set; }

        /// <summary>
        /// The average points differential this player faced at any given point in the season. A positive number puts his team in the lead, a negative behind.
        /// </summary>
        [Description("The average points differential this player faced at any given point in the season. A positive number puts his team in the lead, a negative behind.")]
        [DataMember(Name = "GameScript", Order = 30)]
        public decimal? GameScript { get; set; }

        /// <summary>
        /// The player's Game Script ranking relative to other players
        /// </summary>
        [Description("The player's Game Script ranking relative to other players")]
        [DataMember(Name = "GameScriptRank", Order = 31)]
        public int? GameScriptRank { get; set; }

        /// <summary>
        /// The number of times the player carried the ball on a player that began with 5 yards or fewer to goal.
        /// </summary>
        [Description("The number of times the player carried the ball on a player that began with 5 yards or fewer to goal.")]
        [DataMember(Name = "GoalLineCarries", Order = 32)]
        public decimal? GoalLineCarries { get; set; }

        /// <summary>
        /// The average number of times per game the player carried the ball on a player that began with 5 yards or fewer to goal.
        /// </summary>
        [Description("The average number of times per game the player carried the ball on a player that began with 5 yards or fewer to goal.")]
        [DataMember(Name = "GoalLineCarriesPerGame", Order = 33)]
        public decimal? GoalLineCarriesPerGame { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "GoalLineCarriesPerGameRank", Order = 34)]
        public int? GoalLineCarriesPerGameRank { get; set; }

        /// <summary>
        /// The player ranked by number of goal line carries across the season.
        /// </summary>
        [Description("The player ranked by number of goal line carries across the season.")]
        [DataMember(Name = "GoalLineCarriesRank", Order = 35)]
        public int? GoalLineCarriesRank { get; set; }

        /// <summary>
        /// A player's situation-agnostic efficiency. Compares the outcome of all pass attempts, carries, and targets to league-average outcome in identical game situations (yard line, down, and distance), taking into account time remaining and game score to allow for non-standard situations (e.g. two-minute drills, clock-milking, and garbage time). Positive Production Premium values show that a player is more efficient than the average player with similar opportunities in similar situations. This metric is useful in isolating a player's true ability, as his on-field performance is always affected by his teammates.
        /// </summary>
        [Description("A player's situation-agnostic efficiency. Compares the outcome of all pass attempts, carries, and targets to league-average outcome in identical game situations (yard line, down, and distance), taking into account time remaining and game score to allow for non-standard situations (e.g. two-minute drills, clock-milking, and garbage time). Positive Production Premium values show that a player is more efficient than the average player with similar opportunities in similar situations. This metric is useful in isolating a player's true ability, as his on-field performance is always affected by his teammates.")]
        [DataMember(Name = "ProductionPremium", Order = 36)]
        public decimal? ProductionPremium { get; set; }

        /// <summary>
        /// The player's Production Premium ranking relative to other players
        /// </summary>
        [Description("The player's Production Premium ranking relative to other players")]
        [DataMember(Name = "ProductionPremiumRank", Order = 37)]
        public int? ProductionPremiumRank { get; set; }

        /// <summary>
        /// The number of times per game the player carried the ball on a player that began in the red zone.
        /// </summary>
        [Description("The number of times per game the player carried the ball on a player that began in the red zone.")]
        [DataMember(Name = "RedZoneCarries", Order = 38)]
        public decimal? RedZoneCarries { get; set; }

        /// <summary>
        /// The average number of times per game the player carried the ball on a player that began in the red zone.
        /// </summary>
        [Description("The average number of times per game the player carried the ball on a player that began in the red zone.")]
        [DataMember(Name = "RedZoneCarriesPerGame", Order = 39)]
        public decimal? RedZoneCarriesPerGame { get; set; }

        /// <summary>
        /// The player's Red Zone Carries Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Carries Per Game ranking relative to other players")]
        [DataMember(Name = "RedZoneCarriesPerGameRank", Order = 40)]
        public int? RedZoneCarriesPerGameRank { get; set; }

        /// <summary>
        /// The player's Red Zone Carries ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Carries ranking relative to other players")]
        [DataMember(Name = "RedZoneCarriesRank", Order = 41)]
        public int? RedZoneCarriesRank { get; set; }

        /// <summary>
        /// The number of touchdowns scored by the player on a rushng play.
        /// </summary>
        [Description("The number of touchdowns scored by the player on a rushng play.")]
        [DataMember(Name = "RushingTouchdowns", Order = 42)]
        public decimal? RushingTouchdowns { get; set; }

        /// <summary>
        /// The player's Rushing Touchdowns ranking relative to other players
        /// </summary>
        [Description("The player's Rushing Touchdowns ranking relative to other players")]
        [DataMember(Name = "RushingTouchdownsRank", Order = 43)]
        public int? RushingTouchdownsRank { get; set; }

        /// <summary>
        /// Total number of yards rushed per season.
        /// </summary>
        [Description("Total number of yards rushed per season.")]
        [DataMember(Name = "RushingYards", Order = 44)]
        public decimal? RushingYards { get; set; }

        /// <summary>
        /// The player's Rushing Yards ranking relative to other players
        /// </summary>
        [Description("The player's Rushing Yards ranking relative to other players")]
        [DataMember(Name = "RushingYardsRank", Order = 45)]
        public int? RushingYardsRank { get; set; }

        /// <summary>
        /// Average number of yards rushed by the player in each game in which they played.
        /// </summary>
        [Description("Average number of yards rushed by the player in each game in which they played.")]
        [DataMember(Name = "RushYardsPerGame", Order = 46)]
        public decimal? RushYardsPerGame { get; set; }

        /// <summary>
        /// Number of snaps the player took part in in plays that began in the red zone.
        /// </summary>
        [Description("Number of snaps the player took part in in plays that began in the red zone.")]
        [DataMember(Name = "RedZoneSnaps", Order = 47)]
        public decimal? RedZoneSnaps { get; set; }

        /// <summary>
        /// Total number of rushing plays in which the player took part.
        /// </summary>
        [Description("Total number of rushing plays in which the player took part.")]
        [DataMember(Name = "RunSnaps", Order = 48)]
        public decimal? RunSnaps { get; set; }

        /// <summary>
        /// Total number of passing plays in which the player took part.
        /// </summary>
        [Description("Total number of passing plays in which the player took part.")]
        [DataMember(Name = "PassSnaps", Order = 49)]
        public decimal? PassSnaps { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "SnapweightedGameScript", Order = 50)]
        public decimal? SnapweightedGameScript { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "SnapweightedGameScriptRank", Order = 51)]
        public int? SnapweightedGameScriptRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TeamPassPlays", Order = 52)]
        public decimal? TeamPassPlays { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TeamPassPlaysRank", Order = 53)]
        public int? TeamPassPlaysRank { get; set; }

        /// <summary>
        /// Percentage of receptions by the player that result in a touchdown.
        /// </summary>
        [Description("Percentage of receptions by the player that result in a touchdown.")]
        [DataMember(Name = "TouchdownRate", Order = 54)]
        public decimal? TouchdownRate { get; set; }

        /// <summary>
        /// A measure of week-to-week fantasy point scoring variance. Players with weekly volatility above 8.0 have significant weekly output oscillation. High weekly volatility negatively impacts standard league formats that require lineups to be manually set each week, but is preferred in "best-ball" formats that automatically set optimal weekly lineups.
        /// </summary>
        [Description("A measure of week-to-week fantasy point scoring variance. Players with weekly volatility above 8.0 have significant weekly output oscillation. High weekly volatility negatively impacts standard league formats that require lineups to be manually set each week, but is preferred in \"best-ball\" formats that automatically set optimal weekly lineups.")]
        [DataMember(Name = "WeeklyVolatility", Order = 55)]
        public decimal? WeeklyVolatility { get; set; }

        /// <summary>
        /// The player's Weekly Volatility ranking relative to other players
        /// </summary>
        [Description("The player's Weekly Volatility ranking relative to other players")]
        [DataMember(Name = "WeeklyVolatilityRank", Order = 56)]
        public int? WeeklyVolatilityRank { get; set; }

        /// <summary>
        /// Value Over Stream - a measure of each player's fantasy points per game, above the average waiver wire replacement, in standard fantasy league formats during either the previous or current season.
        /// </summary>
        [Description("Value Over Stream - a measure of each player's fantasy points per game, above the average waiver wire replacement, in standard fantasy league formats during either the previous or current season.")]
        [DataMember(Name = "VOS", Order = 57)]
        public decimal? VOS { get; set; }

        /// <summary>
        /// The player's Value Over Stream ranking relative to other players
        /// </summary>
        [Description("The player's Value Over Stream ranking relative to other players")]
        [DataMember(Name = "VOSRank", Order = 58)]
        public int? VOSRank { get; set; }

        /// <summary>
        /// The number of yards gained by the player when he is a pass target.
        /// </summary>
        [Description("The number of yards gained by the player when he is a pass target.")]
        [DataMember(Name = "YardsPerTarget", Order = 59)]
        public decimal? YardsPerTarget { get; set; }

        /// <summary>
        /// The player's Yards Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Target ranking relative to other players")]
        [DataMember(Name = "YardsPerTargetRank", Order = 60)]
        public int? YardsPerTargetRank { get; set; }

        /// <summary>
        /// The player's average yardage per received pass.
        /// </summary>
        [Description("The player's average yardage per received pass.")]
        [DataMember(Name = "YardsPerReception", Order = 61)]
        public decimal? YardsPerReception { get; set; }

        /// <summary>
        /// The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...)
        /// </summary>
        [Description("The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...)")]
        [DataMember(Name = "YardsAfterCatch", Order = 62)]
        public decimal? YardsAfterCatch { get; set; }

        /// <summary>
        /// The player's average yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a reception basis.
        /// </summary>
        [Description("The player's average yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a reception basis.")]
        [DataMember(Name = "YardsAfterCatchPerGame", Order = 63)]
        public decimal? YardsAfterCatchPerGame { get; set; }

        /// <summary>
        /// The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a game basis.
        /// </summary>
        [Description("The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a game basis.")]
        [DataMember(Name = "YardsAfterCatchPerReception", Order = 64)]
        public decimal? YardsAfterCatchPerReception { get; set; }

        /// <summary>
        /// The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a target basis.
        /// </summary>
        [Description("The player's total yardage gain between successfully receiving the ball and the play ending (e.g. by tackle, out of bounds...) on a target basis.")]
        [DataMember(Name = "YardsAfterCatchPerTarget", Order = 65)]
        public decimal? YardsAfterCatchPerTarget { get; set; }

        /// <summary>
        /// The player's Yards After Catch ranking relative to other players
        /// </summary>
        [Description("The player's Yards After Catch ranking relative to other players")]
        [DataMember(Name = "YardsAfterCatchRank", Order = 66)]
        public int? YardsAfterCatchRank { get; set; }

        /// <summary>
        /// Total number of touchdowns scored by this player this season.
        /// </summary>
        [Description("Total number of touchdowns scored by this player this season.")]
        [DataMember(Name = "TotalTouchdowns", Order = 67)]
        public decimal? TotalTouchdowns { get; set; }

        /// <summary>
        /// The player's Yards After Touchdowns ranking relative to other players
        /// </summary>
        [Description("The player's Yards After Touchdowns ranking relative to other players")]
        [DataMember(Name = "TotalTouchdownsRank", Order = 68)]
        public int? TotalTouchdownsRank { get; set; }

        /// <summary>
        /// Total number of touches (receptions and carries) by this player this season.
        /// </summary>
        [Description("Total number of touches (receptions and carries) by this player this season.")]
        [DataMember(Name = "TotalTouches", Order = 69)]
        public decimal? TotalTouches { get; set; }

        /// <summary>
        /// The total number of yards gained by the player.
        /// </summary>
        [Description("The total number of yards gained by the player.")]
        [DataMember(Name = "TotalYards", Order = 70)]
        public decimal? TotalYards { get; set; }

        /// <summary>
        /// The average number of yards gained by a player per game.
        /// </summary>
        [Description("The average number of yards gained by a player per game.")]
        [DataMember(Name = "TotalYardsPerGame", Order = 71)]
        public decimal? TotalYardsPerGame { get; set; }

        /// <summary>
        /// The number of times the player was a passing target.
        /// </summary>
        [Description("The number of times the player was a passing target.")]
        [DataMember(Name = "Targets", Order = 72)]
        public decimal? Targets { get; set; }

        /// <summary>
        /// The percentage of all passing targets directed at a given wide receiver or tight end, in games where that receiver was involved in the passing attack.
        /// </summary>
        [Description("The percentage of all passing targets directed at a given wide receiver or tight end, in games where that receiver was involved in the passing attack.")]
        [DataMember(Name = "TargetShare", Order = 73)]
        public decimal? TargetShare { get; set; }

        /// <summary>
        /// The player's Target Share ranking relative to other players
        /// </summary>
        [Description("The player's Target Share ranking relative to other players")]
        [DataMember(Name = "TargetShareRank", Order = 74)]
        public int? TargetShareRank { get; set; }

        /// <summary>
        /// The number of times the player was a passing target inside the ten yard line.
        /// </summary>
        [Description("The number of times the player was a passing target inside the ten yard line.")]
        [DataMember(Name = "TargetsInside10", Order = 75)]
        public decimal? TargetsInside10 { get; set; }

        /// <summary>
        /// The average number of times per game the player was a passing target inside the ten yard line.
        /// </summary>
        [Description("The average number of times per game the player was a passing target inside the ten yard line.")]
        [DataMember(Name = "TargetsInside10PerGame", Order = 76)]
        public decimal? TargetsInside10PerGame { get; set; }

        /// <summary>
        /// The number of times the player was a passing target inside the five yard line.
        /// </summary>
        [Description("The number of times the player was a passing target inside the five yard line.")]
        [DataMember(Name = "TargetsInside5", Order = 77)]
        public decimal? TargetsInside5 { get; set; }

        /// <summary>
        /// The average number of times per game the player was a passing target inside the five yard line.
        /// </summary>
        [Description("The average number of times per game the player was a passing target inside the five yard line.")]
        [DataMember(Name = "TargetsInside5PerGame", Order = 78)]
        public decimal? TargetsInside5PerGame { get; set; }

        /// <summary>
        /// The average number of times per game the player was a passing target.
        /// </summary>
        [Description("The average number of times per game the player was a passing target.")]
        [DataMember(Name = "TargetsPerGame", Order = 79)]
        public decimal? TargetsPerGame { get; set; }

        /// <summary>
        /// The player's Targets Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Targets Per Game ranking relative to other players")]
        [DataMember(Name = "TargetsPerGameRank", Order = 80)]
        public int? TargetsPerGameRank { get; set; }

        /// <summary>
        /// The player's Targets ranking relative to other players
        /// </summary>
        [Description("The player's Targets ranking relative to other players")]
        [DataMember(Name = "TargetsRank", Order = 81)]
        public int? TargetsRank { get; set; }

        /// <summary>
        /// The number of times the player - a WR or TE - lined up in the slot, i.e. lined up inside and covered by an outside receiver in a set of three or four receivers.
        /// </summary>
        [Description("The number of times the player - a WR or TE - lined up in the slot, i.e. lined up inside and covered by an outside receiver in a set of three or four receivers.")]
        [DataMember(Name = "SlotSnaps", Order = 82)]
        public decimal? SlotSnaps { get; set; }

        /// <summary>
        /// Yards per reception when in the slot for the player.
        /// </summary>
        [Description("Yards per reception when in the slot for the player.")]
        [DataMember(Name = "SlotYPR", Order = 83)]
        public decimal? SlotYPR { get; set; }

        /// <summary>
        /// The player's Slot YPR ranking relative to other players
        /// </summary>
        [Description("The player's Slot YPR ranking relative to other players")]
        [DataMember(Name = "SlotYPRRank", Order = 84)]
        public int? SlotYPRRank { get; set; }

        /// <summary>
        /// Yards per target when in the slot for the player.
        /// </summary>
        [Description("Yards per target when in the slot for the player.")]
        [DataMember(Name = "SlotYPT", Order = 85)]
        public decimal? SlotYPT { get; set; }

        /// <summary>
        /// The player's Slot YPT ranking relative to other players
        /// </summary>
        [Description("The player's Slot YPT ranking relative to other players")]
        [DataMember(Name = "SlotYPTRank", Order = 86)]
        public int? SlotYPTRank { get; set; }

        /// <summary>
        /// Percentage of snaps in the red zone for which the offensive player took part.
        /// </summary>
        [Description("Percentage of snaps in the red zone for which the offensive player took part.")]
        [DataMember(Name = "RedZoneSnapShare", Order = 87)]
        public decimal? RedZoneSnapShare { get; set; }

        /// <summary>
        /// The player's Red Zone Snap Share ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Snap Share ranking relative to other players")]
        [DataMember(Name = "RedZoneSnapShareRank", Order = 88)]
        public int? RedZoneSnapShareRank { get; set; }

        /// <summary>
        /// Percentage of passing plays in which the player ran a route.
        /// </summary>
        [Description("Percentage of passing plays in which the player ran a route.")]
        [DataMember(Name = "RouteParticipation", Order = 89)]
        public decimal? RouteParticipation { get; set; }

        /// <summary>
        /// The player's Route Participation ranking relative to other players
        /// </summary>
        [Description("The player's Route Participation ranking relative to other players")]
        [DataMember(Name = "RouteParticipationRank", Order = 90)]
        public int? RouteParticipationRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassRoutes", Order = 91)]
        public decimal? PassRoutes { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassRoutesPerGame", Order = 92)]
        public decimal? PassRoutesPerGame { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassRoutesPerGameRank", Order = 93)]
        public int? PassRoutesPerGameRank { get; set; }

        /// <summary>
        /// Number of times the player successfully received a pass in the red zone.
        /// </summary>
        [Description("Number of times the player successfully received a pass in the red zone.")]
        [DataMember(Name = "RedZoneReceptions", Order = 94)]
        public decimal? RedZoneReceptions { get; set; }

        /// <summary>
        /// The player's Red Zone Receptions ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Receptions ranking relative to other players")]
        [DataMember(Name = "RedZoneReceptionsRank", Order = 95)]
        public int? RedZoneReceptionsRank { get; set; }

        /// <summary>
        /// Number of times the player was targeted in the red zone.
        /// </summary>
        [Description("Number of times the player was targeted in the red zone.")]
        [DataMember(Name = "RedZoneTargets", Order = 96)]
        public decimal? RedZoneTargets { get; set; }

        /// <summary>
        /// A player's percentage share of the total number of targets in the red zone.
        /// </summary>
        [Description("A player's percentage share of the total number of targets in the red zone.")]
        [DataMember(Name = "RedZoneTargetShare", Order = 97)]
        public decimal? RedZoneTargetShare { get; set; }

        /// <summary>
        /// The player's Red Zone Target Share ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Target Share ranking relative to other players")]
        [DataMember(Name = "RedZoneTargetShareRank", Order = 98)]
        public int? RedZoneTargetShareRank { get; set; }

        /// <summary>
        /// The player's Red Zone Targets ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Targets ranking relative to other players")]
        [DataMember(Name = "RedZoneTargetsRank", Order = 99)]
        public int? RedZoneTargetsRank { get; set; }

        /// <summary>
        /// Number of touches - carries and receptions - by the player in the endzone.
        /// </summary>
        [Description("Number of touches - carries and receptions - by the player in the endzone.")]
        [DataMember(Name = "RedZoneTouches", Order = 100)]
        public decimal? RedZoneTouches { get; set; }

        /// <summary>
        /// Average number of red zone touches per game across the season.
        /// </summary>
        [Description("Average number of red zone touches per game across the season.")]
        [DataMember(Name = "RedZoneTouchesPerGame", Order = 101)]
        public decimal? RedZoneTouchesPerGame { get; set; }

        /// <summary>
        /// The rating a quarterback gets for passing accuracy when throwing to this player alone.
        /// </summary>
        [Description("The rating a quarterback gets for passing accuracy when throwing to this player alone.")]
        [DataMember(Name = "QBRatingWhenTargeted", Order = 102)]
        public decimal? QBRatingWhenTargeted { get; set; }

        /// <summary>
        /// The player's QB Rating When Targeted ranking relative to other players
        /// </summary>
        [Description("The player's QB Rating When Targeted ranking relative to other players")]
        [DataMember(Name = "QBRatingWhenTargetedRank", Order = 103)]
        public int? QBRatingWhenTargetedRank { get; set; }

        /// <summary>
        /// The number of touchdowns a player scored by receiving a pass.
        /// </summary>
        [Description("The number of touchdowns a player scored by receiving a pass.")]
        [DataMember(Name = "ReceivingTDs", Order = 104)]
        public decimal? ReceivingTDs { get; set; }

        /// <summary>
        /// The number of yards gained (or lost) by a player when receiving a pass.
        /// </summary>
        [Description("The number of yards gained (or lost) by a player when receiving a pass.")]
        [DataMember(Name = "ReceivingYards", Order = 105)]
        public decimal? ReceivingYards { get; set; }

        /// <summary>
        /// The average number of yards gained by reception by a player per game.
        /// </summary>
        [Description("The average number of yards gained by reception by a player per game.")]
        [DataMember(Name = "ReceivingYardsPerGame", Order = 106)]
        public decimal? ReceivingYardsPerGame { get; set; }

        /// <summary>
        /// The player's Receiving Yards Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Receiving Yards Per Game ranking relative to other players")]
        [DataMember(Name = "ReceivingYardsPerGameRank", Order = 107)]
        public int? ReceivingYardsPerGameRank { get; set; }

        /// <summary>
        /// The player's Receiving Yards ranking relative to other players
        /// </summary>
        [Description("The player's Receiving Yards ranking relative to other players")]
        [DataMember(Name = "ReceivingYardsRank", Order = 108)]
        public int? ReceivingYardsRank { get; set; }

        /// <summary>
        /// The number of times a player successfully received a pass.
        /// </summary>
        [Description("The number of times a player successfully received a pass.")]
        [DataMember(Name = "Receptions", Order = 109)]
        public decimal? Receptions { get; set; }

        /// <summary>
        /// The average number of times a player successfully received a pass per game.
        /// </summary>
        [Description("The average number of times a player successfully received a pass per game.")]
        [DataMember(Name = "ReceptionsPerGame", Order = 110)]
        public decimal? ReceptionsPerGame { get; set; }

        /// <summary>
        /// The player's Receptions Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Receptions Per Game ranking relative to other players")]
        [DataMember(Name = "ReceptionsPerGameRank", Order = 111)]
        public int? ReceptionsPerGameRank { get; set; }

        /// <summary>
        /// The player's Receptions ranking relative to other players
        /// </summary>
        [Description("The player's Receptions ranking relative to other players")]
        [DataMember(Name = "ReceptionsRank", Order = 112)]
        public int? ReceptionsRank { get; set; }

        /// <summary>
        ///  The percentage of times the player successfully received a pass in the red zone.
        /// </summary>
        [Description(" The percentage of times the player successfully received a pass in the red zone.")]
        [DataMember(Name = "RedZoneCatchRate", Order = 113)]
        public decimal? RedZoneCatchRate { get; set; }

        /// <summary>
        /// The player's Red Zone Catch Rate ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Catch Rate ranking relative to other players")]
        [DataMember(Name = "RedZoneCatchRateRank", Order = 114)]
        public int? RedZoneCatchRateRank { get; set; }

        /// <summary>
        /// The percentage rate at which the ball was in a catchable range when the player was targeted.
        /// </summary>
        [Description("The percentage rate at which the ball was in a catchable range when the player was targeted.")]
        [DataMember(Name = "CatchableTargetRate", Order = 115)]
        public decimal? CatchableTargetRate { get; set; }

        /// <summary>
        /// The player's Catchable Target Rate ranking relative to other players
        /// </summary>
        [Description("The player's Catchable Target Rate ranking relative to other players")]
        [DataMember(Name = "CatchableTargetRateRank", Order = 116)]
        public int? CatchableTargetRateRank { get; set; }

        /// <summary>
        /// The number of catchable passes the player was thrown in a season.
        /// </summary>
        [Description("The number of catchable passes the player was thrown in a season.")]
        [DataMember(Name = "CatchableTargets", Order = 117)]
        public decimal? CatchableTargets { get; set; }

        /// <summary>
        /// A measurement of a player's ability to secure the ball in all situations, regardless of difficulty level. Calculated by dividing total receptions by total targets.
        /// </summary>
        [Description("A measurement of a player's ability to secure the ball in all situations, regardless of difficulty level. Calculated by dividing total receptions by total targets.")]
        [DataMember(Name = "CatchRate", Order = 118)]
        public decimal? CatchRate { get; set; }

        /// <summary>
        /// The player's Catch Rate ranking relative to other players
        /// </summary>
        [Description("The player's Catch Rate ranking relative to other players")]
        [DataMember(Name = "CatchRateRank", Order = 119)]
        public int? CatchRateRank { get; set; }

        /// <summary>
        /// The player's Dominator rating: the percentage of team yards and touchdowns attributed to this player.
        /// </summary>
        [Description("The player's Dominator rating: the percentage of team yards and touchdowns attributed to this player.")]
        [DataMember(Name = "DominatorRating", Order = 120)]
        public decimal? DominatorRating { get; set; }

        /// <summary>
        /// The player's Dominator Rating ranking relative to other players
        /// </summary>
        [Description("The player's Dominator Rating ranking relative to other players")]
        [DataMember(Name = "DominatorRatingRank", Order = 121)]
        public int? DominatorRatingRank { get; set; }

        /// <summary>
        /// The number of dropped passes by this player.
        /// </summary>
        [Description("The number of dropped passes by this player.")]
        [DataMember(Name = "Drops", Order = 122)]
        public decimal? Drops { get; set; }

        /// <summary>
        /// The average number of times per game this player drops a pass.
        /// </summary>
        [Description("The average number of times per game this player drops a pass.")]
        [DataMember(Name = "DropsPerGame", Order = 123)]
        public decimal? DropsPerGame { get; set; }

        /// <summary>
        /// The player's Drops Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Drops Per Game ranking relative to other players")]
        [DataMember(Name = "DropsPerGameRank", Order = 124)]
        public int? DropsPerGameRank { get; set; }

        /// <summary>
        /// The percentage of passes dropped by this player this season.
        /// </summary>
        [Description("The percentage of passes dropped by this player this season.")]
        [DataMember(Name = "DropRate", Order = 125)]
        public decimal? DropRate { get; set; }

        /// <summary>
        /// The player's Drop Rate ranking relative to other players
        /// </summary>
        [Description("The player's Drop Rate ranking relative to other players")]
        [DataMember(Name = "DropRateRank", Order = 126)]
        public int? DropRateRank { get; set; }

        /// <summary>
        /// The player's Drops ranking relative to other players
        /// </summary>
        [Description("The player's Drops ranking relative to other players")]
        [DataMember(Name = "DropsRank", Order = 127)]
        public int? DropsRank { get; set; }

        /// <summary>
        /// The number of times this player was a pass target in the endzone.
        /// </summary>
        [Description("The number of times this player was a pass target in the endzone.")]
        [DataMember(Name = "EndzoneTargets", Order = 128)]
        public decimal? EndzoneTargets { get; set; }

        /// <summary>
        /// The percentage of times this player was a pass target in the endzone.
        /// </summary>
        [Description("The percentage of times this player was a pass target in the endzone.")]
        [DataMember(Name = "EndzoneTargetShare", Order = 129)]
        public decimal? EndzoneTargetShare { get; set; }

        /// <summary>
        /// The player's Endzone Target Share ranking relative to other players
        /// </summary>
        [Description("The player's Endzone Target Share ranking relative to other players")]
        [DataMember(Name = "EndzoneTargetShareRank", Order = 130)]
        public int? EndzoneTargetShareRank { get; set; }

        /// <summary>
        /// On a scale of 1-10, where higher is better, how accurate a quarterback's throwing is.
        /// </summary>
        [Description("On a scale of 1-10, where higher is better, how accurate a quarterback's throwing is.")]
        [DataMember(Name = "AccuracyRating", Order = 131)]
        public decimal? AccuracyRating { get; set; }

        /// <summary>
        /// The player's Accuracy Rating ranking relative to other players
        /// </summary>
        [Description("The player's Accuracy Rating ranking relative to other players")]
        [DataMember(Name = "AccuracyRatingRank", Order = 132)]
        public int? AccuracyRatingRank { get; set; }

        /// <summary>
        /// The number of passing attempts made by a player, adjusted for sacks etc.
        /// </summary>
        [Description("The number of passing attempts made by a player, adjusted for sacks etc.")]
        [DataMember(Name = "AdjustedAttempts", Order = 133)]
        public decimal? AdjustedAttempts { get; set; }

        /// <summary>
        /// The average yardage of a QB's passing, giving bonus weight to touchdowns and a penalizing rate to interceptions.
        /// </summary>
        [Description("The average yardage of a QB's passing, giving bonus weight to touchdowns and a penalizing rate to interceptions.")]
        [DataMember(Name = "AdjustedYardsPerAttempt", Order = 134)]
        public decimal? AdjustedYardsPerAttempt { get; set; }

        /// <summary>
        /// The player's Adjusted Yards Per Attempt ranking relative to other players
        /// </summary>
        [Description("The player's Adjusted Yards Per Attempt ranking relative to other players")]
        [DataMember(Name = "AdjustedYardsPerAttemptRank", Order = 135)]
        public int? AdjustedYardsPerAttemptRank { get; set; }

        /// <summary>
        /// The average number of yards - throw depth - per pass attempted by the quarterback.
        /// </summary>
        [Description("The average number of yards - throw depth - per pass attempted by the quarterback.")]
        [DataMember(Name = "AirYardsPerAttempt", Order = 136)]
        public decimal? AirYardsPerAttempt { get; set; }

        /// <summary>
        /// The player's Air Yards Per Attempt ranking relative to other players
        /// </summary>
        [Description("The player's Air Yards Per Attempt ranking relative to other players")]
        [DataMember(Name = "AirYardsPerAttemptRank", Order = 137)]
        public int? AirYardsPerAttemptRank { get; set; }

        /// <summary>
        /// The number of passing attempts made by the player within the 10 yard line.
        /// </summary>
        [Description("The number of passing attempts made by the player within the 10 yard line.")]
        [DataMember(Name = "AttemptsInside10", Order = 138)]
        public decimal? AttemptsInside10 { get; set; }

        /// <summary>
        /// The average number of passing attempts per game mad by the player within the 10 yard line.
        /// </summary>
        [Description("The average number of passing attempts per game mad by the player within the 10 yard line.")]
        [DataMember(Name = "AttemptsInside10PerGame", Order = 139)]
        public decimal? AttemptsInside10PerGame { get; set; }

        /// <summary>
        /// The number of passing attempts made by the player within the 5 yard line.
        /// </summary>
        [Description("The number of passing attempts made by the player within the 5 yard line.")]
        [DataMember(Name = "AttemptsInside5", Order = 140)]
        public decimal? AttemptsInside5 { get; set; }

        /// <summary>
        /// The average number of passing attempts per game mad by the player within the 5 yard line.
        /// </summary>
        [Description("The average number of passing attempts per game mad by the player within the 5 yard line.")]
        [DataMember(Name = "AttemptsInside5PerGame", Order = 141)]
        public decimal? AttemptsInside5PerGame { get; set; }

        /// <summary>
        /// The average number of passing attempts made per game by this player.
        /// </summary>
        [Description("The average number of passing attempts made per game by this player.")]
        [DataMember(Name = "AttemptsPerGame", Order = 142)]
        public decimal? AttemptsPerGame { get; set; }

        /// <summary>
        /// The number of passes thrown that can be caught by a receiver in this season by this player.
        /// </summary>
        [Description("The number of passes thrown that can be caught by a receiver in this season by this player.")]
        [DataMember(Name = "CatchablePasses", Order = 143)]
        public decimal? CatchablePasses { get; set; }

        /// <summary>
        /// The average number of passes thrown that can be caught by a receiver per game by this player.
        /// </summary>
        [Description("The average number of passes thrown that can be caught by a receiver per game by this player.")]
        [DataMember(Name = "CatchablePassesPerGame", Order = 144)]
        public decimal? CatchablePassesPerGame { get; set; }

        /// <summary>
        /// The player's Catchable Passes ranking relative to other players
        /// </summary>
        [Description("The player's Catchable Passes ranking relative to other players")]
        [DataMember(Name = "CatchablePassesRank", Order = 145)]
        public int? CatchablePassesRank { get; set; }

        /// <summary>
        /// The percentage of times an attempted pass is successfully completed by the receiver.
        /// </summary>
        [Description("The percentage of times an attempted pass is successfully completed by the receiver.")]
        [DataMember(Name = "CompletionPercentage", Order = 146)]
        public decimal? CompletionPercentage { get; set; }

        /// <summary>
        /// The player's Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's Completion Percentage ranking relative to other players")]
        [DataMember(Name = "CompletionPercentageRank", Order = 147)]
        public int? CompletionPercentageRank { get; set; }

        /// <summary>
        /// Number of completed passes thrown by this player.
        /// </summary>
        [Description("Number of completed passes thrown by this player.")]
        [DataMember(Name = "Completions", Order = 148)]
        public decimal? Completions { get; set; }

        /// <summary>
        /// The number of danger plays - plays in which the QB through lack of awareness or recklessness - risked a turnover for his team.
        /// </summary>
        [Description("The number of danger plays - plays in which the QB through lack of awareness or recklessness - risked a turnover for his team.")]
        [DataMember(Name = "DangerPlays", Order = 149)]
        public decimal? DangerPlays { get; set; }

        /// <summary>
        /// The average number per game of danger plays - plays in which the QB through lack of awareness or recklessness - risked a turnover for his team.
        /// </summary>
        [Description("The average number per game of danger plays - plays in which the QB through lack of awareness or recklessness - risked a turnover for his team.")]
        [DataMember(Name = "DangerPlaysPerGame", Order = 150)]
        public decimal? DangerPlaysPerGame { get; set; }

        /// <summary>
        /// The player's Danger Plays ranking relative to other players
        /// </summary>
        [Description("The player's Danger Plays ranking relative to other players")]
        [DataMember(Name = "DangerPlaysRank", Order = 151)]
        public int? DangerPlaysRank { get; set; }

        /// <summary>
        /// The number of times a QB attempted a pass of 20 yards or more downfield.
        /// </summary>
        [Description("The number of times a QB attempted a pass of 20 yards or more downfield.")]
        [DataMember(Name = "DeepBallAttempts", Order = 152)]
        public decimal? DeepBallAttempts { get; set; }

        /// <summary>
        /// The average number of times per game a QB attempted a pass of 20 yards or more downfield.
        /// </summary>
        [Description("The average number of times per game a QB attempted a pass of 20 yards or more downfield.")]
        [DataMember(Name = "DeepBallAttemptsPerGame", Order = 153)]
        public decimal? DeepBallAttemptsPerGame { get; set; }

        /// <summary>
        /// The player's Deep Ball Attempts Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Deep Ball Attempts Per Game ranking relative to other players")]
        [DataMember(Name = "DeepBallAttemptsPerGameRank", Order = 154)]
        public int? DeepBallAttemptsPerGameRank { get; set; }

        /// <summary>
        /// The player's Deep Ball Attempts ranking relative to other players
        /// </summary>
        [Description("The player's Deep Ball Attempts ranking relative to other players")]
        [DataMember(Name = "DeepBallAttemptsRank", Order = 155)]
        public int? DeepBallAttemptsRank { get; set; }

        /// <summary>
        /// The percentage of times the QB successfully threw a complete pass 20 yards or more.
        /// </summary>
        [Description("The percentage of times the QB successfully threw a complete pass 20 yards or more.")]
        [DataMember(Name = "DeepBallCompletionPercentage", Order = 156)]
        public decimal? DeepBallCompletionPercentage { get; set; }

        /// <summary>
        /// The player's Deep Ball Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's Deep Ball Completion Percentage ranking relative to other players")]
        [DataMember(Name = "DeepBallCompletionPercentageRank", Order = 157)]
        public int? DeepBallCompletionPercentageRank { get; set; }

        /// <summary>
        /// The number of times the QB successfully threw a complete pass 20 yards or more.
        /// </summary>
        [Description("The number of times the QB successfully threw a complete pass 20 yards or more.")]
        [DataMember(Name = "DeepBallCompletions", Order = 158)]
        public decimal? DeepBallCompletions { get; set; }

        /// <summary>
        /// The player's Deep Ball Completions ranking relative to other players
        /// </summary>
        [Description("The player's Deep Ball Completions ranking relative to other players")]
        [DataMember(Name = "DeepBallCompletionsRank", Order = 159)]
        public int? DeepBallCompletionsRank { get; set; }

        /// <summary>
        /// The number of droppsed passes thrown by this quarterback.
        /// </summary>
        [Description("The number of droppsed passes thrown by this quarterback.")]
        [DataMember(Name = "DroppedPasses", Order = 160)]
        public decimal? DroppedPasses { get; set; }

        /// <summary>
        /// The player's Dropped Passes ranking relative to other players
        /// </summary>
        [Description("The player's Dropped Passes ranking relative to other players")]
        [DataMember(Name = "DroppedPassesRank", Order = 161)]
        public int? DroppedPassesRank { get; set; }

        /// <summary>
        /// The average number of dropped passes per game thrown by this quarterback.
        /// </summary>
        [Description("The average number of dropped passes per game thrown by this quarterback.")]
        [DataMember(Name = "DroppedPassesPerGame", Order = 162)]
        public decimal? DroppedPassesPerGame { get; set; }

        /// <summary>
        /// The number of drops produced per attempt at a thrown pass by this quarterback, in decimal form.
        /// </summary>
        [Description("The number of drops produced per attempt at a thrown pass by this quarterback, in decimal form.")]
        [DataMember(Name = "DropsPerAttempt", Order = 163)]
        public decimal? DropsPerAttempt { get; set; }

        /// <summary>
        /// The player's Drops Per Attempt ranking relative to other players
        /// </summary>
        [Description("The player's Drops Per Attempt ranking relative to other players")]
        [DataMember(Name = "DropsPerAttemptRank", Order = 164)]
        public int? DropsPerAttemptRank { get; set; }

        /// <summary>
        /// The number of times this quarterback dropped back to execute a passing play, regardless of its success.
        /// </summary>
        [Description("The number of times this quarterback dropped back to execute a passing play, regardless of its success.")]
        [DataMember(Name = "DropBacks", Order = 165)]
        public decimal? DropBacks { get; set; }

        /// <summary>
        /// The number of interceptable passes thrown by this quarterback this season, regardless of whether they were intercepted or not.
        /// </summary>
        [Description("The number of interceptable passes thrown by this quarterback this season, regardless of whether they were intercepted or not.")]
        [DataMember(Name = "InterceptablePasses", Order = 166)]
        public decimal? InterceptablePasses { get; set; }

        /// <summary>
        /// The average number of interceptable passes thrown by this quarterback per game.
        /// </summary>
        [Description("The average number of interceptable passes thrown by this quarterback per game.")]
        [DataMember(Name = "InterceptablePassesPerGame", Order = 167)]
        public decimal? InterceptablePassesPerGame { get; set; }

        /// <summary>
        /// The player's Interceptable Passes ranking relative to other players
        /// </summary>
        [Description("The player's Interceptable Passes ranking relative to other players")]
        [DataMember(Name = "InterceptablePassesRank", Order = 168)]
        public int? InterceptablePassesRank { get; set; }

        /// <summary>
        /// The number of money throws completed by the quarterback this season. A money throw is a somewhat subjective measurement of an extremely skillfull pass resulting in a completion at a clutch moment.
        /// </summary>
        [Description("The number of money throws completed by the quarterback this season. A money throw is a somewhat subjective measurement of an extremely skillfull pass resulting in a completion at a clutch moment.")]
        [DataMember(Name = "MoneyThrows", Order = 169)]
        public decimal? MoneyThrows { get; set; }

        /// <summary>
        /// The average number of money throws completed by the quarterback per game. A money throw is a somewhat subjective measurement of an extremely skillfull pass resulting in a completion at a clutch moment.
        /// </summary>
        [Description("The average number of money throws completed by the quarterback per game. A money throw is a somewhat subjective measurement of an extremely skillfull pass resulting in a completion at a clutch moment.")]
        [DataMember(Name = "MoneyThrowsPerGame", Order = 170)]
        public decimal? MoneyThrowsPerGame { get; set; }

        /// <summary>
        /// The player's Money Throws ranking relative to other players
        /// </summary>
        [Description("The player's Money Throws ranking relative to other players")]
        [DataMember(Name = "MoneyThrowsRank", Order = 171)]
        public int? MoneyThrowsRank { get; set; }

        /// <summary>
        /// The number of attempts at passing made by this QB this season.
        /// </summary>
        [Description("The number of attempts at passing made by this QB this season.")]
        [DataMember(Name = "PassAttempts", Order = 172)]
        public decimal? PassAttempts { get; set; }

        /// <summary>
        /// The player's Pass Attempts ranking relative to other players
        /// </summary>
        [Description("The player's Pass Attempts ranking relative to other players")]
        [DataMember(Name = "PassAttemptsRank", Order = 173)]
        public int? PassAttemptsRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassAttemptDistance", Order = 174)]
        public decimal? PassAttemptDistance { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassAttemptDistanceRank", Order = 175)]
        public int? PassAttemptDistanceRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassAttemptDistancePerAttempt", Order = 176)]
        public decimal? PassAttemptDistancePerAttempt { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassAttemptDistancePerAttemptRank", Order = 177)]
        public int? PassAttemptDistancePerAttemptRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassingAttempts", Order = 178)]
        public decimal? PassingAttempts { get; set; }

        /// <summary>
        /// The number of passes thrown by this player that resulted in a touchdown.
        /// </summary>
        [Description("The number of passes thrown by this player that resulted in a touchdown.")]
        [DataMember(Name = "PassingTouchdowns", Order = 179)]
        public decimal? PassingTouchdowns { get; set; }

        /// <summary>
        /// The player's Passing Touchdown ranking relative to other players
        /// </summary>
        [Description("The player's Passing Touchdown ranking relative to other players")]
        [DataMember(Name = "PassingTouchdownsRank", Order = 180)]
        public int? PassingTouchdownsRank { get; set; }

        /// <summary>
        /// The total number of passing yards thrown by this player this season.
        /// </summary>
        [Description("The total number of passing yards thrown by this player this season.")]
        [DataMember(Name = "PassingYards", Order = 181)]
        public decimal? PassingYards { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 182)]
        public decimal? PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassingYardsPerAttemptRank", Order = 183)]
        public int? PassingYardsPerAttemptRank { get; set; }

        /// <summary>
        /// The average number of yards thrown in passing plays per game by this player.
        /// </summary>
        [Description("The average number of yards thrown in passing plays per game by this player.")]
        [DataMember(Name = "PassingYardsPerGame", Order = 184)]
        public decimal? PassingYardsPerGame { get; set; }

        /// <summary>
        /// The player's Passing Yards Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Passing Yards Per Game ranking relative to other players")]
        [DataMember(Name = "PassingYardsPerGameRank", Order = 185)]
        public int? PassingYardsPerGameRank { get; set; }

        /// <summary>
        /// The player's Passing Yards ranking relative to other players
        /// </summary>
        [Description("The player's Passing Yards ranking relative to other players")]
        [DataMember(Name = "PassingYardsRank", Order = 186)]
        public int? PassingYardsRank { get; set; }

        /// <summary>
        /// The number of attempts made by the passer on a play-action play - a play which looks like a running play to start but is actually a passing play.
        /// </summary>
        [Description("The number of attempts made by the passer on a play-action play - a play which looks like a running play to start but is actually a passing play.")]
        [DataMember(Name = "PlayactionPassAttempts", Order = 187)]
        public decimal? PlayactionPassAttempts { get; set; }

        /// <summary>
        /// The average number of play-action passes attempted per game, on average, by the QB.
        /// </summary>
        [Description("The average number of play-action passes attempted per game, on average, by the QB.")]
        [DataMember(Name = "PlayactionPassAttemptsPerGame", Order = 188)]
        public decimal? PlayactionPassAttemptsPerGame { get; set; }

        /// <summary>
        /// The player's Playaction Pass Attempts ranking relative to other players	
        /// </summary>
        [Description("The player's Playaction Pass Attempts ranking relative to other players	")]
        [DataMember(Name = "PlayactionPassAttemptsRank", Order = 189)]
        public int? PlayactionPassAttemptsRank { get; set; }

        /// <summary>
        /// The percentage of play-action passes completed when thrown by this QB.
        /// </summary>
        [Description("The percentage of play-action passes completed when thrown by this QB.")]
        [DataMember(Name = "PlayactionPassCompletionPercentage", Order = 190)]
        public decimal? PlayactionPassCompletionPercentage { get; set; }

        /// <summary>
        /// The player's Playaction Pass Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's Playaction Pass Completion Percentage ranking relative to other players")]
        [DataMember(Name = "PlayactionPassCompletionPercentageRank", Order = 191)]
        public int? PlayactionPassCompletionPercentageRank { get; set; }

        /// <summary>
        /// The percentage of times a QB is successfully protected by his offensive line to attempt a play.
        /// </summary>
        [Description("The percentage of times a QB is successfully protected by his offensive line to attempt a play.")]
        [DataMember(Name = "ProtectionRate", Order = 192)]
        public decimal? ProtectionRate { get; set; }

        /// <summary>
        /// The player's Protection Rate ranking relative to other players
        /// </summary>
        [Description("The player's Protection Rate ranking relative to other players")]
        [DataMember(Name = "ProtectionRateRank", Order = 193)]
        public int? ProtectionRateRank { get; set; }

        /// <summary>
        /// The total number of passing attempts by this QB in the red zone.
        /// </summary>
        [Description("The total number of passing attempts by this QB in the red zone.")]
        [DataMember(Name = "RedZoneAttempts", Order = 194)]
        public decimal? RedZoneAttempts { get; set; }

        /// <summary>
        /// The average number of passing attempts per game by this QB in the red zone.
        /// </summary>
        [Description("The average number of passing attempts per game by this QB in the red zone.")]
        [DataMember(Name = "RedZoneAttemptsPerGame", Order = 195)]
        public decimal? RedZoneAttemptsPerGame { get; set; }

        /// <summary>
        /// The player's Red Zone Attempts ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Attempts ranking relative to other players")]
        [DataMember(Name = "RedZoneAttemptsRank", Order = 196)]
        public int? RedZoneAttemptsRank { get; set; }

        /// <summary>
        /// The percentage of attempted red zone passes successfully completed by this QB.
        /// </summary>
        [Description("The percentage of attempted red zone passes successfully completed by this QB.")]
        [DataMember(Name = "RedZoneCompletionPercentage", Order = 197)]
        public decimal? RedZoneCompletionPercentage { get; set; }

        /// <summary>
        /// The player's Red Zone Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Completion Percentage ranking relative to other players")]
        [DataMember(Name = "RedZoneCompletionPercentageRank", Order = 198)]
        public int? RedZoneCompletionPercentageRank { get; set; }

        /// <summary>
        /// The number of times the QB throws a TD versus an interception in the red zone.
        /// </summary>
        [Description("The number of times the QB throws a TD versus an interception in the red zone.")]
        [DataMember(Name = "RedZoneTDtoINTRatio", Order = 199)]
        public decimal? RedZoneTDtoINTRatio { get; set; }

        /// <summary>
        /// The number of times the QB rushed a touchdown.
        /// </summary>
        [Description("The number of times the QB rushed a touchdown.")]
        [DataMember(Name = "RushingTDs", Order = 200)]
        public decimal? RushingTDs { get; set; }

        /// <summary>
        /// The player's Rushing Yards Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Rushing Yards Per Game ranking relative to other players")]
        [DataMember(Name = "RushingYardsPerGameRank", Order = 201)]
        public int? RushingYardsPerGameRank { get; set; }

        /// <summary>
        /// The percentage of shotgun attempts - when the QB lines up around 5-7 yards behind the center - completed.
        /// </summary>
        [Description("The percentage of shotgun attempts - when the QB lines up around 5-7 yards behind the center - completed.")]
        [DataMember(Name = "ShotgunCompletionPercentage", Order = 202)]
        public decimal? ShotgunCompletionPercentage { get; set; }

        /// <summary>
        /// The number of times the QB lined up in a shotgun formation at the snap in the season.
        /// </summary>
        [Description("The number of times the QB lined up in a shotgun formation at the snap in the season.")]
        [DataMember(Name = "ShotgunSnaps", Order = 203)]
        public decimal? ShotgunSnaps { get; set; }

        /// <summary>
        /// The percentage of under-center passing plays - when the quarterback lines up directly behind the center - completed.
        /// </summary>
        [Description("The percentage of under-center passing plays - when the quarterback lines up directly behind the center - completed.")]
        [DataMember(Name = "UnderCenterCompletionPercentage", Order = 204)]
        public decimal? UnderCenterCompletionPercentage { get; set; }

        /// <summary>
        /// The number of times the QB lined up in an under-center formation at the snap in the season.
        /// </summary>
        [Description("The number of times the QB lined up in an under-center formation at the snap in the season.")]
        [DataMember(Name = "UnderCenterSnaps", Order = 205)]
        public decimal? UnderCenterSnaps { get; set; }

        /// <summary>
        /// The percentage of passes thrown by this QB that result in the receiver having to contest the catch with a defensive player.
        /// </summary>
        [Description("The percentage of passes thrown by this QB that result in the receiver having to contest the catch with a defensive player.")]
        [DataMember(Name = "ReceiverContestedCatchRate", Order = 206)]
        public decimal? ReceiverContestedCatchRate { get; set; }

        /// <summary>
        /// The player's Receiver Contested Catch Rate ranking relative to other players
        /// </summary>
        [Description("The player's Receiver Contested Catch Rate ranking relative to other players")]
        [DataMember(Name = "ReceiverContestedCatchRateRank", Order = 207)]
        public int? ReceiverContestedCatchRateRank { get; set; }

        /// <summary>
        /// The average yards of separation between the ball receiver and his assigned defender when passes are thrown by this quarterback.
        /// </summary>
        [Description("The average yards of separation between the ball receiver and his assigned defender when passes are thrown by this quarterback.")]
        [DataMember(Name = "ReceiverTargetSeparation", Order = 208)]
        public decimal? ReceiverTargetSeparation { get; set; }

        /// <summary>
        /// The player's Receiver Target Separation ranking relative to other players
        /// </summary>
        [Description("The player's Receiver Target Separation ranking relative to other players")]
        [DataMember(Name = "ReceiverTargetSeparationRank", Order = 209)]
        public int? ReceiverTargetSeparationRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "ReceiverYardsAfterTheCatch", Order = 210)]
        public decimal? ReceiverYardsAfterTheCatch { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "ReceiverYardsAfterTheCatchRank", Order = 211)]
        public int? ReceiverYardsAfterTheCatchRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "ReceiverYardsAfterTheCatchPerTarget", Order = 212)]
        public decimal? ReceiverYardsAfterTheCatchPerTarget { get; set; }

        /// <summary>
        /// An aggregate of the weighted production scores - efficiency in gaining fantasy points -of all RBs, WRs, and TEs playing alongside the QB in question.
        /// </summary>
        [Description("An aggregate of the weighted production scores - efficiency in gaining fantasy points -of all RBs, WRs, and TEs playing alongside the QB in question.")]
        [DataMember(Name = "SupportingCastEfficiency", Order = 213)]
        public decimal? SupportingCastEfficiency { get; set; }

        /// <summary>
        /// The player's Supporting Cast Efficiency ranking relative to other players
        /// </summary>
        [Description("The player's Supporting Cast Efficiency ranking relative to other players")]
        [DataMember(Name = "SupportingCastEfficiencyRank", Order = 214)]
        public int? SupportingCastEfficiencyRank { get; set; }

        /// <summary>
        /// The degree to which a quarterback contributed to points scored and/or a team win. Total QBR can thus account for QB performance that does not directly lead to additional points scored, but does contribute to a team win (for example, by completing a pass that earns a first down at his 20-yard-line with 30 seconds remaining, allowing his leading team to run out the clock).
        /// </summary>
        [Description("The degree to which a quarterback contributed to points scored and/or a team win. Total QBR can thus account for QB performance that does not directly lead to additional points scored, but does contribute to a team win (for example, by completing a pass that earns a first down at his 20-yard-line with 30 seconds remaining, allowing his leading team to run out the clock).")]
        [DataMember(Name = "TotalQBR", Order = 215)]
        public decimal? TotalQBR { get; set; }

        /// <summary>
        /// The player's Total QBR ranking relative to other players
        /// </summary>
        [Description("The player's Total QBR ranking relative to other players")]
        [DataMember(Name = "TotalQBRRank", Order = 216)]
        public int? TotalQBRRank { get; set; }

        /// <summary>
        /// An adjusted QB pass completion metric also taking into account drops, spikes etc. that may alter a QB's actual passing ability.
        /// </summary>
        [Description("An adjusted QB pass completion metric also taking into account drops, spikes etc. that may alter a QB's actual passing ability.")]
        [DataMember(Name = "TrueCompletionPercentage", Order = 217)]
        public decimal? TrueCompletionPercentage { get; set; }

        /// <summary>
        /// The player's True Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's True Completion Percentage ranking relative to other players")]
        [DataMember(Name = "TrueCompletionPercentageRank", Order = 218)]
        public int? TrueCompletionPercentageRank { get; set; }

        /// <summary>
        ///  The player's passer rating - completion percentage, yards per attempt, TD rate, and interception rate - but adjusted for True Completion.
        /// </summary>
        [Description(" The player's passer rating - completion percentage, yards per attempt, TD rate, and interception rate - but adjusted for True Completion.")]
        [DataMember(Name = "TruePasserRating", Order = 219)]
        public decimal? TruePasserRating { get; set; }

        /// <summary>
        /// The player's True Passer Rating ranking relative to other players
        /// </summary>
        [Description("The player's True Passer Rating ranking relative to other players")]
        [DataMember(Name = "TruePasserRatingRank", Order = 220)]
        public int? TruePasserRatingRank { get; set; }

        /// <summary>
        /// The number of passes thrown by this QB that a receiver cannot reasonably be expected to catch.
        /// </summary>
        [Description("The number of passes thrown by this QB that a receiver cannot reasonably be expected to catch.")]
        [DataMember(Name = "UncatchablePasses", Order = 221)]
        public decimal? UncatchablePasses { get; set; }

        /// <summary>
        /// The average number of passes per game thrown by this QB that a receiver cannot reasonably be expected to catch.
        /// </summary>
        [Description("The average number of passes per game thrown by this QB that a receiver cannot reasonably be expected to catch.")]
        [DataMember(Name = "UncatchablePassesPerGame", Order = 222)]
        public decimal? UncatchablePassesPerGame { get; set; }

        /// <summary>
        /// A player's Uncatchable Passes rank relative to other players.
        /// </summary>
        [Description("A player's Uncatchable Passes rank relative to other players.")]
        [DataMember(Name = "UncatchablePassesRank", Order = 223)]
        public int? UncatchablePassesRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "UnderPressureAttempts", Order = 224)]
        public decimal? UnderPressureAttempts { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "UnderPressureAttemptsRank", Order = 225)]
        public int? UnderPressureAttemptsRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "UnderPressureAttemptsPerGame", Order = 226)]
        public decimal? UnderPressureAttemptsPerGame { get; set; }

        /// <summary>
        /// The percentage of passes thrown to completion by this quarterback when he is under pressure from defenders.
        /// </summary>
        [Description("The percentage of passes thrown to completion by this quarterback when he is under pressure from defenders.")]
        [DataMember(Name = "PressuredCompletionPercentage", Order = 227)]
        public decimal? PressuredCompletionPercentage { get; set; }

        /// <summary>
        /// The player's Pressured Completion Percentage ranking relative to other players
        /// </summary>
        [Description("The player's Pressured Completion Percentage ranking relative to other players")]
        [DataMember(Name = "PressuredCompletionPercentageRank", Order = 228)]
        public int? PressuredCompletionPercentageRank { get; set; }

        /// <summary>
        /// For RBs, the average number of defenders that lined up against them in the box - almost always a value between 5 and 8.
        /// </summary>
        [Description("For RBs, the average number of defenders that lined up against them in the box - almost always a value between 5 and 8.")]
        [DataMember(Name = "AverageDefendersInTheBox", Order = 229)]
        public decimal? AverageDefendersInTheBox { get; set; }

        /// <summary>
        /// The player's Average Defenders in the Box ranking relative to other players
        /// </summary>
        [Description("The player's Average Defenders in the Box ranking relative to other players")]
        [DataMember(Name = "AverageDefendersInTheBoxRank", Order = 230)]
        public int? AverageDefendersInTheBoxRank { get; set; }

        /// <summary>
        /// A player's carry rate when up against a base front defence (seven men).
        /// </summary>
        [Description("A player's carry rate when up against a base front defence (seven men).")]
        [DataMember(Name = "BaseFrontCarryRate", Order = 231)]
        public decimal? BaseFrontCarryRate { get; set; }

        /// <summary>
        /// The player's Base Front Carry Rate ranking relative to other players
        /// </summary>
        [Description("The player's Base Front Carry Rate ranking relative to other players")]
        [DataMember(Name = "BaseFrontCarryRateRank", Order = 232)]
        public int? BaseFrontCarryRateRank { get; set; }

        /// <summary>
        /// The average number of yards carried by this player against a base front defense.
        /// </summary>
        [Description("The average number of yards carried by this player against a base front defense.")]
        [DataMember(Name = "BaseFrontYardsPerCarry", Order = 233)]
        public decimal? BaseFrontYardsPerCarry { get; set; }

        /// <summary>
        /// The player's Base Front Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Base Front Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "BaseFrontYardsPerCarryRank", Order = 234)]
        public int? BaseFrontYardsPerCarryRank { get; set; }

        /// <summary>
        /// The rate at which a player produces a breakaway run - escaping his assigned defender and running the ball for 20 yards or more - adjusted for yardage. 
        /// </summary>
        [Description("The rate at which a player produces a breakaway run - escaping his assigned defender and running the ball for 20 yards or more - adjusted for yardage. ")]
        [DataMember(Name = "BreakawayRunRate", Order = 235)]
        public decimal? BreakawayRunRate { get; set; }

        /// <summary>
        /// The player's Breakaway Run Rate ranking relative to other players
        /// </summary>
        [Description("The player's Breakaway Run Rate ranking relative to other players")]
        [DataMember(Name = "BreakawayRunRateRank", Order = 236)]
        public int? BreakawayRunRateRank { get; set; }

        /// <summary>
        /// The number of breakaway runs over the course of the season by the RB in question.
        /// </summary>
        [Description("The number of breakaway runs over the course of the season by the RB in question.")]
        [DataMember(Name = "BreakawayRuns", Order = 237)]
        public decimal? BreakawayRuns { get; set; }

        /// <summary>
        /// The average number of breakaway runs produced by the RB per game.
        /// </summary>
        [Description("The average number of breakaway runs produced by the RB per game.")]
        [DataMember(Name = "BreakawayRunsPerGame", Order = 238)]
        public decimal? BreakawayRunsPerGame { get; set; }

        /// <summary>
        /// The player's Breakaway Runs Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Breakaway Runs Per Game ranking relative to other players")]
        [DataMember(Name = "BreakawayRunsPerGameRank", Order = 239)]
        public int? BreakawayRunsPerGameRank { get; set; }

        /// <summary>
        /// The player's Breakaway Runs ranking relative to other players
        /// </summary>
        [Description("The player's Breakaway Runs ranking relative to other players")]
        [DataMember(Name = "BreakawayRunsRank", Order = 240)]
        public int? BreakawayRunsRank { get; set; }

        /// <summary>
        /// The number of tackles in flight successfully dodged or broken by the RB.
        /// </summary>
        [Description("The number of tackles in flight successfully dodged or broken by the RB.")]
        [DataMember(Name = "EvadedTackles", Order = 241)]
        public decimal? EvadedTackles { get; set; }

        /// <summary>
        /// The average number of tackles successfully dodged or broken by the RB per game.
        /// </summary>
        [Description("The average number of tackles successfully dodged or broken by the RB per game.")]
        [DataMember(Name = "EvadedTacklesPerGame", Order = 242)]
        public decimal? EvadedTacklesPerGame { get; set; }

        /// <summary>
        /// The player's Evaded Tackles Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Evaded Tackles Per Game ranking relative to other players")]
        [DataMember(Name = "EvadedTacklesPerGameRank", Order = 243)]
        public int? EvadedTacklesPerGameRank { get; set; }

        /// <summary>
        /// The player's Evaded Tackles Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Evaded Tackles Per Game ranking relative to other players")]
        [DataMember(Name = "EvadedTacklesRank", Order = 244)]
        public int? EvadedTacklesRank { get; set; }

        /// <summary>
        /// Calculated by charting the number of broken, missed, and otherwise avoided tackles, and then dividing by the total number of touches (carries plus receptions). Juke rate is used to measure a running back's elusiveness and tackle-breaking power.
        /// </summary>
        [Description("Calculated by charting the number of broken, missed, and otherwise avoided tackles, and then dividing by the total number of touches (carries plus receptions). Juke rate is used to measure a running back's elusiveness and tackle-breaking power.")]
        [DataMember(Name = "JukeRate", Order = 245)]
        public decimal? JukeRate { get; set; }

        /// <summary>
        /// The player's Juke Rate ranking relative to other players
        /// </summary>
        [Description("The player's Juke Rate ranking relative to other players")]
        [DataMember(Name = "JukeRateRank", Order = 246)]
        public int? JukeRateRank { get; set; }

        /// <summary>
        /// A player's carry rate when up against a light front defense (six men).
        /// </summary>
        [Description("A player's carry rate when up against a light front defense (six men).")]
        [DataMember(Name = "LightFrontCarryRate", Order = 247)]
        public decimal? LightFrontCarryRate { get; set; }

        /// <summary>
        /// The player's Light Front Carry Rate ranking relative to other players
        /// </summary>
        [Description("The player's Light Front Carry Rate ranking relative to other players")]
        [DataMember(Name = "LightFrontCarryRateRank", Order = 248)]
        public int? LightFrontCarryRateRank { get; set; }

        /// <summary>
        /// A player's yards per carry when up against a light front defense (six men).
        /// </summary>
        [Description("A player's yards per carry when up against a light front defense (six men).")]
        [DataMember(Name = "LightFrontYardsPerCarry", Order = 249)]
        public decimal? LightFrontYardsPerCarry { get; set; }

        /// <summary>
        /// The player's Light Front Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Light Front Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "LightFrontYardsPerCarryRank", Order = 250)]
        public int? LightFrontYardsPerCarryRank { get; set; }

        /// <summary>
        /// The number of opportunities given to the RB.
        /// </summary>
        [Description("The number of opportunities given to the RB.")]
        [DataMember(Name = "Opportunities", Order = 251)]
        public decimal? Opportunities { get; set; }

        /// <summary>
        /// For a given running back, percentage of total team running back carries and targets
        /// </summary>
        [Description("For a given running back, percentage of total team running back carries and targets")]
        [DataMember(Name = "OpportunityShare", Order = 252)]
        public decimal? OpportunityShare { get; set; }

        /// <summary>
        /// The player's Opportunity Share ranking relative to other players
        /// </summary>
        [Description("The player's Opportunity Share ranking relative to other players")]
        [DataMember(Name = "OpportunityShareRank", Order = 253)]
        public int? OpportunityShareRank { get; set; }

        /// <summary>
        /// The number of opportunities given to the relevant RB.
        /// </summary>
        [Description("The number of opportunities given to the relevant RB.")]
        [DataMember(Name = "RedZoneOpportunities", Order = 254)]
        public decimal? RedZoneOpportunities { get; set; }

        /// <summary>
        /// The player's Red Zone Touches Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Touches Per Game ranking relative to other players")]
        [DataMember(Name = "RedZoneTouchesPerGameRank", Order = 255)]
        public int? RedZoneTouchesPerGameRank { get; set; }

        /// <summary>
        /// The player's Red Zone Touches ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Touches ranking relative to other players")]
        [DataMember(Name = "RedZoneTouchesRank", Order = 256)]
        public int? RedZoneTouchesRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "RunBlockingEfficiency", Order = 257)]
        public decimal? RunBlockingEfficiency { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "RunBlockingEfficiencyRank", Order = 258)]
        public int? RunBlockingEfficiencyRank { get; set; }

        /// <summary>
        /// The player's Rush Yards Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Rush Yards Per Game ranking relative to other players")]
        [DataMember(Name = "RushYardsPerGameRank", Order = 259)]
        public int? RushYardsPerGameRank { get; set; }

        /// <summary>
        /// Percentage of carries by this player when the team lines up shotgun.
        /// </summary>
        [Description("Percentage of carries by this player when the team lines up shotgun.")]
        [DataMember(Name = "ShotgunCarryRate", Order = 260)]
        public decimal? ShotgunCarryRate { get; set; }

        /// <summary>
        /// The player's Shotgun Carry Rate ranking relative to other players
        /// </summary>
        [Description("The player's Shotgun Carry Rate ranking relative to other players")]
        [DataMember(Name = "ShotgunCarryRateRank", Order = 261)]
        public int? ShotgunCarryRateRank { get; set; }

        /// <summary>
        /// Average number of yards per carry when the player carries from a shotgun formation.
        /// </summary>
        [Description("Average number of yards per carry when the player carries from a shotgun formation.")]
        [DataMember(Name = "ShotgunYardsPerCarry", Order = 262)]
        public decimal? ShotgunYardsPerCarry { get; set; }

        /// <summary>
        /// The player's Shotgun Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Shotgun Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "ShotgunYardsPerCarryRank", Order = 263)]
        public int? ShotgunYardsPerCarryRank { get; set; }

        /// <summary>
        /// Percentage of opportunities given to this RB when the team is in the red zone.
        /// </summary>
        [Description("Percentage of opportunities given to this RB when the team is in the red zone.")]
        [DataMember(Name = "RedZoneOpportunityShare", Order = 264)]
        public decimal? RedZoneOpportunityShare { get; set; }

        /// <summary>
        /// The player's Red Zone Opportunity Share ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone Opportunity Share ranking relative to other players")]
        [DataMember(Name = "RedZoneOpportunityShareRank", Order = 265)]
        public int? RedZoneOpportunityShareRank { get; set; }

        /// <summary>
        /// The percentage of times this player turns a red zone opportunity into a touchdown.
        /// </summary>
        [Description("The percentage of times this player turns a red zone opportunity into a touchdown.")]
        [DataMember(Name = "RedZoneTDConversionRate", Order = 266)]
        public decimal? RedZoneTDConversionRate { get; set; }

        /// <summary>
        /// The player's Red Zone TC Conversion Rate ranking relative to other players
        /// </summary>
        [Description("The player's Red Zone TC Conversion Rate ranking relative to other players")]
        [DataMember(Name = "RedZoneTDConversionRateRank", Order = 267)]
        public int? RedZoneTDConversionRateRank { get; set; }

        /// <summary>
        /// Percentage of carries by this player when the opposing team lines up with a stacked front (eight or more defenders.)
        /// </summary>
        [Description("Percentage of carries by this player when the opposing team lines up with a stacked front (eight or more defenders.)")]
        [DataMember(Name = "StackedFrontCarryRate", Order = 268)]
        public decimal? StackedFrontCarryRate { get; set; }

        /// <summary>
        /// The player's Stacked Front Carry Rate ranking relative to other players
        /// </summary>
        [Description("The player's Stacked Front Carry Rate ranking relative to other players")]
        [DataMember(Name = "StackedFrontCarryRateRank", Order = 269)]
        public int? StackedFrontCarryRateRank { get; set; }

        [DataMember(Name = "StackedFrontYardsPerCarry", Order = 270)]
        public decimal? StackedFrontYardsPerCarry { get; set; }

        /// <summary>
        /// The player's Stacked Front Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Stacked Front Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "StackedFrontYardsPerCarryRank", Order = 271)]
        public int? StackedFrontYardsPerCarryRank { get; set; }

        /// <summary>
        /// The number of runs made by this player resulting in zero or negative yardage.
        /// </summary>
        [Description("The number of runs made by this player resulting in zero or negative yardage.")]
        [DataMember(Name = "StuffedRuns", Order = 272)]
        public decimal? StuffedRuns { get; set; }

        /// <summary>
        /// The player's Stuffed Runs ranking relative to other players
        /// </summary>
        [Description("The player's Stuffed Runs ranking relative to other players")]
        [DataMember(Name = "StuffedRunsRank", Order = 273)]
        public int? StuffedRunsRank { get; set; }

        /// <summary>
        /// The percentage of this players' runs that are stuffed (resulting in zero or negative yardage.)
        /// </summary>
        [Description("The percentage of this players' runs that are stuffed (resulting in zero or negative yardage.)")]
        [DataMember(Name = "StuffedRunRate", Order = 274)]
        public decimal? StuffedRunRate { get; set; }

        /// <summary>
        /// The player's Stuffed Run Rate ranking relative to other players
        /// </summary>
        [Description("The player's Stuffed Run Rate ranking relative to other players")]
        [DataMember(Name = "StuffedRunRateRank", Order = 275)]
        public int? StuffedRunRateRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TeamRunPlays", Order = 276)]
        public decimal? TeamRunPlays { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TeamRunPlaysRank", Order = 277)]
        public int? TeamRunPlaysRank { get; set; }

        /// <summary>
        /// The player's Total Yards Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Total Yards Per Game ranking relative to other players")]
        [DataMember(Name = "TotalYardsPerGameRank", Order = 278)]
        public int? TotalYardsPerGameRank { get; set; }

        /// <summary>
        /// The player's Total Yards ranking relative to other players
        /// </summary>
        [Description("The player's Total Yards ranking relative to other players")]
        [DataMember(Name = "TotalYardsRank", Order = 279)]
        public int? TotalYardsRank { get; set; }

        /// <summary>
        /// A yards per carry metric filtering out long runs of 10 yards or longer, to emphasize consistency.
        /// </summary>
        [Description("A yards per carry metric filtering out long runs of 10 yards or longer, to emphasize consistency.")]
        [DataMember(Name = "TrueYardsPerCarry", Order = 280)]
        public decimal? TrueYardsPerCarry { get; set; }

        /// <summary>
        /// The player's True Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's True Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "TrueYardsPerCarryRank", Order = 281)]
        public int? TrueYardsPerCarryRank { get; set; }

        /// <summary>
        /// The percentage of times this player carries the ball when the QB lines up under the center.
        /// </summary>
        [Description("The percentage of times this player carries the ball when the QB lines up under the center.")]
        [DataMember(Name = "UnderCenterCarryRate", Order = 282)]
        public decimal? UnderCenterCarryRate { get; set; }

        /// <summary>
        /// The player's Under Center Carry Rate ranking relative to other players
        /// </summary>
        [Description("The player's Under Center Carry Rate ranking relative to other players")]
        [DataMember(Name = "UnderCenterCarryRateRank", Order = 283)]
        public int? UnderCenterCarryRateRank { get; set; }

        /// <summary>
        /// The average number of yards carried by the running back when the team lines up QB under C.
        /// </summary>
        [Description("The average number of yards carried by the running back when the team lines up QB under C.")]
        [DataMember(Name = "UnderCenterYardsPerCarry", Order = 284)]
        public decimal? UnderCenterYardsPerCarry { get; set; }

        /// <summary>
        /// The player's Under Center Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Under Center Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "UnderCenterYardsPerCarryRank", Order = 285)]
        public int? UnderCenterYardsPerCarryRank { get; set; }

        /// <summary>
        /// A variant of total opportunities that discounts carries and enhances the FF value of a target based on touch type.
        /// </summary>
        [Description("A variant of total opportunities that discounts carries and enhances the FF value of a target based on touch type.")]
        [DataMember(Name = "WeightedOpportunities", Order = 286)]
        public decimal? WeightedOpportunities { get; set; }

        /// <summary>
        /// The player's Weighted Opportunities ranking relative to other players
        /// </summary>
        [Description("The player's Weighted Opportunities ranking relative to other players")]
        [DataMember(Name = "WeightedOpportunitiesRank", Order = 287)]
        public int? WeightedOpportunitiesRank { get; set; }

        /// <summary>
        /// The average number of weighted opportunities - a calibrated subset of total opportunities - per game for this player.
        /// </summary>
        [Description("The average number of weighted opportunities - a calibrated subset of total opportunities - per game for this player.")]
        [DataMember(Name = "WeightedOpportunitiesPerGame", Order = 288)]
        public decimal? WeightedOpportunitiesPerGame { get; set; }

        /// <summary>
        /// The player's Weighted Opportunities Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Weighted Opportunities Per Game ranking relative to other players")]
        [DataMember(Name = "WeightedOpportunitiesPerGameRank", Order = 289)]
        public int? WeightedOpportunitiesPerGameRank { get; set; }

        /// <summary>
        /// All yards generated above and beyond what was blocked. Yards Created are accrued after the running back's first evaded tackle.
        /// </summary>
        [Description("All yards generated above and beyond what was blocked. Yards Created are accrued after the running back's first evaded tackle.")]
        [DataMember(Name = "YardsCreated", Order = 290)]
        public decimal? YardsCreated { get; set; }

        [DataMember(Name = "YardsCreatedPerGame", Order = 291)]
        public decimal? YardsCreatedPerGame { get; set; }

        /// <summary>
        /// The player's Yards Created Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Yards Created Per Game ranking relative to other players")]
        [DataMember(Name = "YardsCreatedPerGameRank", Order = 292)]
        public int? YardsCreatedPerGameRank { get; set; }

        /// <summary>
        /// The total number of yards gained above and beyond those blocked, i.e. after the first evaded tackle, the total number of yards gained by the player on that play.
        /// </summary>
        [Description("The total number of yards gained above and beyond those blocked, i.e. after the first evaded tackle, the total number of yards gained by the player on that play.")]
        [DataMember(Name = "YardsCreatedPerCarry", Order = 293)]
        public decimal? YardsCreatedPerCarry { get; set; }

        /// <summary>
        /// The player's Yards Created Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Yards Created Per Carry ranking relative to other players")]
        [DataMember(Name = "YardsCreatedPerCarryRank", Order = 294)]
        public int? YardsCreatedPerCarryRank { get; set; }

        /// <summary>
        /// The player's Yards Created ranking relative to other players
        /// </summary>
        [Description("The player's Yards Created ranking relative to other players")]
        [DataMember(Name = "YardsCreatedRank", Order = 295)]
        public int? YardsCreatedRank { get; set; }

        /// <summary>
        /// The average number of yards gained by the RB per carry.
        /// </summary>
        [Description("The average number of yards gained by the RB per carry.")]
        [DataMember(Name = "YardsPerCarry", Order = 296)]
        public decimal? YardsPerCarry { get; set; }

        /// <summary>
        /// The player's Yards Per Carry ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Carry ranking relative to other players")]
        [DataMember(Name = "YardsPerCarryRank", Order = 297)]
        public int? YardsPerCarryRank { get; set; }

        /// <summary>
        /// The average number of yards per opportunity (passes as well as carries) generated by this player.
        /// </summary>
        [Description("The average number of yards per opportunity (passes as well as carries) generated by this player.")]
        [DataMember(Name = "YardsPerOpportunity", Order = 298)]
        public decimal? YardsPerOpportunity { get; set; }

        /// <summary>
        /// The average number of yards generated by this player when the team runs a passing route.
        /// </summary>
        [Description("The average number of yards generated by this player when the team runs a passing route.")]
        [DataMember(Name = "YardsPerRouteRun", Order = 299)]
        public decimal? YardsPerRouteRun { get; set; }

        /// <summary>
        /// The player's Yards Per Route Run ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Route Run ranking relative to other players")]
        [DataMember(Name = "YardsPerRouteRunRank", Order = 300)]
        public int? YardsPerRouteRunRank { get; set; }

        /// <summary>
        /// The average number of yards generated by this player following a touch of any kind.
        /// </summary>
        [Description("The average number of yards generated by this player following a touch of any kind.")]
        [DataMember(Name = "YardsPerTouch", Order = 301)]
        public decimal? YardsPerTouch { get; set; }

        /// <summary>
        /// The player's Yards Per Touch ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Touch ranking relative to other players")]
        [DataMember(Name = "YardsPerTouchRank", Order = 302)]
        public int? YardsPerTouchRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "AirYardsPerReception", Order = 303)]
        public decimal? AirYardsPerReception { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "AirYardsPerTarget", Order = 304)]
        public decimal? AirYardsPerTarget { get; set; }

        /// <summary>
        /// The average distance in yards between the TE/WR and their assigned defender at the time of the snap.
        /// </summary>
        [Description("The average distance in yards between the TE/WR and their assigned defender at the time of the snap.")]
        [DataMember(Name = "Cushion", Order = 305)]
        public decimal? Cushion { get; set; }

        /// <summary>
        /// The player's Cushion ranking relative to other players
        /// </summary>
        [Description("The player's Cushion ranking relative to other players")]
        [DataMember(Name = "CushionRank", Order = 306)]
        public int? CushionRank { get; set; }

        /// <summary>
        /// The average number of yards this player is distant from the point of scrimmage when he is a passing target.
        /// </summary>
        [Description("The average number of yards this player is distant from the point of scrimmage when he is a passing target.")]
        [DataMember(Name = "AverageTargetDistance", Order = 307)]
        public decimal? AverageTargetDistance { get; set; }

        /// <summary>
        /// The player's Average Target Distance ranking relative to other players
        /// </summary>
        [Description("The player's Average Target Distance ranking relative to other players")]
        [DataMember(Name = "AverageTargetDistanceRank", Order = 308)]
        public int? AverageTargetDistanceRank { get; set; }

        /// <summary>
        /// Number of times the player burns - fakes out and defeats - a defending player and catches a pass.
        /// </summary>
        [Description("Number of times the player burns - fakes out and defeats - a defending player and catches a pass.")]
        [DataMember(Name = "Burns", Order = 309)]
        public decimal? Burns { get; set; }

        /// <summary>
        /// The number of times this player is targeted and thrown a catchable pass per game on average.
        /// </summary>
        [Description("The number of times this player is targeted and thrown a catchable pass per game on average.")]
        [DataMember(Name = "CatchableTargetsPerGame", Order = 310)]
        public decimal? CatchableTargetsPerGame { get; set; }

        /// <summary>
        /// The player's Catchable Targets ranking relative to other players
        /// </summary>
        [Description("The player's Catchable Targets ranking relative to other players")]
        [DataMember(Name = "CatchableTargetsRank", Order = 311)]
        public int? CatchableTargetsRank { get; set; }

        /// <summary>
        /// The percentage of contested catches this player successfully manages to catch.
        /// </summary>
        [Description("The percentage of contested catches this player successfully manages to catch.")]
        [DataMember(Name = "ContestedCatchConversionRate", Order = 312)]
        public decimal? ContestedCatchConversionRate { get; set; }

        /// <summary>
        /// The player's Contestec Catch Conversion Rate ranking relative to other players
        /// </summary>
        [Description("The player's Contestec Catch Conversion Rate ranking relative to other players")]
        [DataMember(Name = "ContestedCatchConversionRateRank", Order = 313)]
        public int? ContestedCatchConversionRateRank { get; set; }

        /// <summary>
        /// The total number of contested catches made by this player.
        /// </summary>
        [Description("The total number of contested catches made by this player.")]
        [DataMember(Name = "ContestedCatches", Order = 314)]
        public decimal? ContestedCatches { get; set; }

        /// <summary>
        /// The total number of times this player was targeted and had to contest a catch, regardless of whether or not he caught it.
        /// </summary>
        [Description("The total number of times this player was targeted and had to contest a catch, regardless of whether or not he caught it.")]
        [DataMember(Name = "ContestedTargets", Order = 315)]
        public decimal? ContestedTargets { get; set; }

        /// <summary>
        /// Number of targets per snap. Hog rate captures the rate of passing game utilization on a per-play basis, and helps to identify wide receivers and tight ends with limited route trees who are a focal point of the passing offense when on the field, even though they may have a low snap count and target share.
        /// </summary>
        [Description("Number of targets per snap. Hog rate captures the rate of passing game utilization on a per-play basis, and helps to identify wide receivers and tight ends with limited route trees who are a focal point of the passing offense when on the field, even though they may have a low snap count and target share.")]
        [DataMember(Name = "HogRate", Order = 316)]
        public decimal? HogRate { get; set; }

        /// <summary>
        /// The player's Hog Rate ranking relative to other players
        /// </summary>
        [Description("The player's Hog Rate ranking relative to other players")]
        [DataMember(Name = "HogRateRank", Order = 317)]
        public int? HogRateRank { get; set; }

        /// <summary>
        /// The player's Pass Snaps ranking relative to other players
        /// </summary>
        [Description("The player's Pass Snaps ranking relative to other players")]
        [DataMember(Name = "PassSnapsRank", Order = 318)]
        public int? PassSnapsRank { get; set; }

        /// <summary>
        /// The player's Run Snaps ranking relative to other players
        /// </summary>
        [Description("The player's Run Snaps ranking relative to other players")]
        [DataMember(Name = "RunSnapsRank", Order = 319)]
        public int? RunSnapsRank { get; set; }

        /// <summary>
        /// This player's percentage of successful catches when he lined up in the slot.
        /// </summary>
        [Description("This player's percentage of successful catches when he lined up in the slot.")]
        [DataMember(Name = "SlotCatchRate", Order = 320)]
        public decimal? SlotCatchRate { get; set; }

        /// <summary>
        /// The player's Slot Catch Rate ranking relative to other players
        /// </summary>
        [Description("The player's Slot Catch Rate ranking relative to other players")]
        [DataMember(Name = "SlotCatchRateRank", Order = 321)]
        public int? SlotCatchRateRank { get; set; }

        /// <summary>
        /// The player's Slot Snaps ranking relative to other players
        /// </summary>
        [Description("The player's Slot Snaps ranking relative to other players")]
        [DataMember(Name = "SlotSnapsRank", Order = 322)]
        public int? SlotSnapsRank { get; set; }

        /// <summary>
        /// The average Game Script (point differential, positive or negative, at any given point in the game when this player is involved) weighted for number of snaps.
        /// </summary>
        [Description("The average Game Script (point differential, positive or negative, at any given point in the game when this player is involved) weighted for number of snaps.")]
        [DataMember(Name = "SnapweighedGameScript", Order = 323)]
        public decimal? SnapweighedGameScript { get; set; }

        /// <summary>
        /// The player's Snapweighed Game Script ranking relative to other players
        /// </summary>
        [Description("The player's Snapweighed Game Script ranking relative to other players")]
        [DataMember(Name = "SnapweighedGameScriptRank", Order = 324)]
        public int? SnapweighedGameScriptRank { get; set; }

        /// <summary>
        /// A measure of additional fantasy points per target generated by a WR/TE above the other WRs/TEs on his team.
        /// </summary>
        [Description("A measure of additional fantasy points per target generated by a WR/TE above the other WRs/TEs on his team.")]
        [DataMember(Name = "TargetPremium", Order = 325)]
        public decimal? TargetPremium { get; set; }

        /// <summary>
        /// The player's Target Premium ranking relative to other players
        /// </summary>
        [Description("The player's Target Premium ranking relative to other players")]
        [DataMember(Name = "TargetPremiumRank", Order = 326)]
        public int? TargetPremiumRank { get; set; }

        /// <summary>
        /// The player's Target Quality ranking relative to other players
        /// </summary>
        [Description("The player's Target Quality ranking relative to other players")]
        [DataMember(Name = "TargetQualityRating", Order = 327)]
        public decimal? TargetQualityRating { get; set; }

        /// <summary>
        /// The player's Target Quality Rating ranking relative to other players
        /// </summary>
        [Description("The player's Target Quality Rating ranking relative to other players")]
        [DataMember(Name = "TargetQualityRatingRank", Order = 328)]
        public int? TargetQualityRatingRank { get; set; }

        /// <summary>
        /// The QB's accuracy rating - from 1 to 10, lowest to highest - when throwing to this receiver.
        /// </summary>
        [Description("The QB's accuracy rating - from 1 to 10, lowest to highest - when throwing to this receiver.")]
        [DataMember(Name = "TargetAccuracy", Order = 329)]
        public decimal? TargetAccuracy { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TargetAccuracyRank", Order = 330)]
        public int? TargetAccuracyRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TargetDistance", Order = 331)]
        public decimal? TargetDistance { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TargetDistancePerGame", Order = 332)]
        public decimal? TargetDistancePerGame { get; set; }

        /// <summary>
        /// The player's Target Distance ranking relative to other players
        /// </summary>
        [Description("The player's Target Distance ranking relative to other players")]
        [DataMember(Name = "TargetDistanceRank", Order = 333)]
        public int? TargetDistanceRank { get; set; }

        /// <summary>
        /// The percentage of catches made by this receiver based only on catachable passes.
        /// </summary>
        [Description("The percentage of catches made by this receiver based only on catachable passes.")]
        [DataMember(Name = "TrueCatchRate", Order = 334)]
        public decimal? TrueCatchRate { get; set; }

        /// <summary>
        /// The player's True Catch Rate ranking relative to other players
        /// </summary>
        [Description("The player's True Catch Rate ranking relative to other players")]
        [DataMember(Name = "TrueCatchRateRank", Order = 335)]
        public int? TrueCatchRateRank { get; set; }

        /// <summary>
        /// The number of times this receiver was thrown an uncatchable pass (which necessarily would be incomplete) this season.
        /// </summary>
        [Description("The number of times this receiver was thrown an uncatchable pass (which necessarily would be incomplete) this season.")]
        [DataMember(Name = "UncatchableTargets", Order = 336)]
        public decimal? UncatchableTargets { get; set; }

        /// <summary>
        /// The average number of times this receiver was thrown an uncatchable pass (which necessarily would be incomplete) per game.
        /// </summary>
        [Description("The average number of times this receiver was thrown an uncatchable pass (which necessarily would be incomplete) per game.")]
        [DataMember(Name = "UncatchableTargetsGame", Order = 337)]
        public decimal? UncatchableTargetsGame { get; set; }

        /// <summary>
        /// The player's Yards Per Reception ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Reception ranking relative to other players")]
        [DataMember(Name = "YardsPerReceptionRank", Order = 338)]
        public int? YardsPerReceptionRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "YardsPerPassRoute", Order = 339)]
        public decimal? YardsPerPassRoute { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "YardsPerPassRouteRank", Order = 340)]
        public int? YardsPerPassRouteRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "TeamDefensiveSnaps", Order = 341)]
        public decimal? TeamDefensiveSnaps { get; set; }

        /// <summary>
        /// Number of tackles solely credited to this defensive player.
        /// </summary>
        [Description("Number of tackles solely credited to this defensive player.")]
        [DataMember(Name = "SoloTackles", Order = 342)]
        public decimal? SoloTackles { get; set; }

        /// <summary>
        /// The player's Solo Tackles ranking relative to other players
        /// </summary>
        [Description("The player's Solo Tackles ranking relative to other players")]
        [DataMember(Name = "SoloTacklesRank", Order = 343)]
        public int? SoloTacklesRank { get; set; }

        /// <summary>
        /// Average number per game of tackles solely credited to this defensive player.
        /// </summary>
        [Description("Average number per game of tackles solely credited to this defensive player.")]
        [DataMember(Name = "SoloTacklesPerGame", Order = 344)]
        public decimal? SoloTacklesPerGame { get; set; }

        /// <summary>
        /// Number of tackles credited to this defensive player along with at least one other.
        /// </summary>
        [Description("Number of tackles credited to this defensive player along with at least one other.")]
        [DataMember(Name = "AssistedTackles", Order = 345)]
        public decimal? AssistedTackles { get; set; }

        /// <summary>
        /// The player's Assisted Tackles ranking relative to other players
        /// </summary>
        [Description("The player's Assisted Tackles ranking relative to other players")]
        [DataMember(Name = "AssistedTacklesRank", Order = 346)]
        public int? AssistedTacklesRank { get; set; }

        /// <summary>
        /// Average number per game of tackles credited to this defensive player along with at least one other.
        /// </summary>
        [Description("Average number per game of tackles credited to this defensive player along with at least one other.")]
        [DataMember(Name = "AssistedTacklesPerGame", Order = 347)]
        public decimal? AssistedTacklesPerGame { get; set; }

        /// <summary>
        /// Total number of all tackles (solo and assisted) credited to this defensive player.
        /// </summary>
        [Description("Total number of all tackles (solo and assisted) credited to this defensive player.")]
        [DataMember(Name = "TotalTackles", Order = 348)]
        public decimal? TotalTackles { get; set; }

        /// <summary>
        /// The player's Total Tackles ranking relative to other players
        /// </summary>
        [Description("The player's Total Tackles ranking relative to other players")]
        [DataMember(Name = "TotalTacklesRank", Order = 349)]
        public int? TotalTacklesRank { get; set; }

        /// <summary>
        /// Average number per game of all tackles (solo and assisted) credited to this defensive player.
        /// </summary>
        [Description("Average number per game of all tackles (solo and assisted) credited to this defensive player.")]
        [DataMember(Name = "TotalTacklesPerGame", Order = 350)]
        public decimal? TotalTacklesPerGame { get; set; }

        /// <summary>
        /// Number of times this defensive player sacked the quarterback.
        /// </summary>
        [Description("Number of times this defensive player sacked the quarterback.")]
        [DataMember(Name = "Sacks", Order = 351)]
        public decimal? Sacks { get; set; }

        /// <summary>
        /// The player's Sacks ranking relative to other players
        /// </summary>
        [Description("The player's Sacks ranking relative to other players")]
        [DataMember(Name = "SacksRank", Order = 352)]
        public int? SacksRank { get; set; }

        /// <summary>
        /// Total number of yards lost by the team in possession when this player sacked their quarterback.
        /// </summary>
        [Description("Total number of yards lost by the team in possession when this player sacked their quarterback.")]
        [DataMember(Name = "SackYards", Order = 353)]
        public decimal? SackYards { get; set; }

        /// <summary>
        /// The number of times this defensive player forced a fumble from the offensive team.
        /// </summary>
        [Description("The number of times this defensive player forced a fumble from the offensive team.")]
        [DataMember(Name = "ForcedFumbles", Order = 354)]
        public decimal? ForcedFumbles { get; set; }

        /// <summary>
        /// The player's Forced Fumbles ranking relative to other players
        /// </summary>
        [Description("The player's Forced Fumbles ranking relative to other players")]
        [DataMember(Name = "ForcedFumblesRank", Order = 355)]
        public int? ForcedFumblesRank { get; set; }

        /// <summary>
        /// The number of times this player recovered a fumbled ball.
        /// </summary>
        [Description("The number of times this player recovered a fumbled ball.")]
        [DataMember(Name = "FumbleRecoveries", Order = 356)]
        public decimal? FumbleRecoveries { get; set; }

        /// <summary>
        /// The player's Fumble Recoveries ranking relative to other players
        /// </summary>
        [Description("The player's Fumble Recoveries ranking relative to other players")]
        [DataMember(Name = "FumbleRecoveriesRank", Order = 357)]
        public int? FumbleRecoveriesRank { get; set; }

        /// <summary>
        /// The number of times this player batted an attempted pass to the ground, rendering it incomplete.
        /// </summary>
        [Description("The number of times this player batted an attempted pass to the ground, rendering it incomplete.")]
        [DataMember(Name = "BattedPasses", Order = 358)]
        public decimal? BattedPasses { get; set; }

        /// <summary>
        /// The player's Batted Passes ranking relative to other players
        /// </summary>
        [Description("The player's Batted Passes ranking relative to other players")]
        [DataMember(Name = "BattedPassesRank", Order = 359)]
        public int? BattedPassesRank { get; set; }

        /// <summary>
        /// The number of times this player made a tackle that resulted in a loss of yardage for the offensive team.
        /// </summary>
        [Description("The number of times this player made a tackle that resulted in a loss of yardage for the offensive team.")]
        [DataMember(Name = "TacklesForLoss", Order = 360)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// The player's Tackles For Loss ranking relative to other players
        /// </summary>
        [Description("The player's Tackles For Loss ranking relative to other players")]
        [DataMember(Name = "TacklesForLossRank", Order = 361)]
        public int? TacklesForLossRank { get; set; }

        /// <summary>
        /// The number of times this defensive player caused a stuffed run - a run resulting in zero or negative yardage - for the offensive team.
        /// </summary>
        [Description("The number of times this defensive player caused a stuffed run - a run resulting in zero or negative yardage - for the offensive team.")]
        [DataMember(Name = "RunStuffs", Order = 362)]
        public decimal? RunStuffs { get; set; }

        /// <summary>
        /// The player's Run Stuffs ranking relative to other players
        /// </summary>
        [Description("The player's Run Stuffs ranking relative to other players")]
        [DataMember(Name = "RunStuffsRank", Order = 363)]
        public int? RunStuffsRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassBreakups", Order = 364)]
        public decimal? PassBreakups { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassBreakupsRank", Order = 365)]
        public int? PassBreakupsRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassBreakupsPerGame", Order = 366)]
        public decimal? PassBreakupsPerGame { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassBreakupsPerGameRank", Order = 367)]
        public int? PassBreakupsPerGameRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "PassBreakupsPerTarget", Order = 368)]
        public decimal? PassBreakupsPerTarget { get; set; }

        /// <summary>
        /// The player's Pass Breakups Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Pass Breakups Per Target ranking relative to other players")]
        [DataMember(Name = "PassBreakupsPerTargetRank", Order = 369)]
        public int? PassBreakupsPerTargetRank { get; set; }

        /// <summary>
        /// The number of times this player successfully intercepted a pass.
        /// </summary>
        [Description("The number of times this player successfully intercepted a pass.")]
        [DataMember(Name = "Interceptions", Order = 370)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// The player's Interceptions ranking relative to other players
        /// </summary>
        [Description("The player's Interceptions ranking relative to other players")]
        [DataMember(Name = "InterceptionsRank", Order = 371)]
        public int? InterceptionsRank { get; set; }

        /// <summary>
        /// Number of times this defensive player allowed an offensive player to become a passing target.
        /// </summary>
        [Description("Number of times this defensive player allowed an offensive player to become a passing target.")]
        [DataMember(Name = "TargetsAllowed", Order = 372)]
        public decimal? TargetsAllowed { get; set; }

        /// <summary>
        /// The player's Targets Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Targets Allowed ranking relative to other players")]
        [DataMember(Name = "TargetsAllowedRank", Order = 373)]
        public int? TargetsAllowedRank { get; set; }

        /// <summary>
        /// Number of passing receptions this defensive player allowed to happen per game.
        /// </summary>
        [Description("Number of passing receptions this defensive player allowed to happen per game.")]
        [DataMember(Name = "ReceptionsAllowed", Order = 374)]
        public decimal? ReceptionsAllowed { get; set; }

        /// <summary>
        /// The player's Receptions Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Receptions Allowed ranking relative to other players")]
        [DataMember(Name = "ReceptionsAllowedRank", Order = 375)]
        public int? ReceptionsAllowedRank { get; set; }

        /// <summary>
        /// The total number of yards allowed to the offensive team by this defensive player.
        /// </summary>
        [Description("The total number of yards allowed to the offensive team by this defensive player.")]
        [DataMember(Name = "YardsAllowed", Order = 376)]
        public decimal? YardsAllowed { get; set; }

        /// <summary>
        /// The player's Yards Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Yards Allowed ranking relative to other players")]
        [DataMember(Name = "YardsAllowedRank", Order = 377)]
        public int? YardsAllowedRank { get; set; }

        /// <summary>
        /// The average number per game of yards allowed to the offensive team by this defensive player.
        /// </summary>
        [Description("The average number per game of yards allowed to the offensive team by this defensive player.")]
        [DataMember(Name = "YardsAllowedPerGame", Order = 378)]
        public decimal? YardsAllowedPerGame { get; set; }

        /// <summary>
        /// The player's Yards Allowed Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Yards Allowed Per Game ranking relative to other players")]
        [DataMember(Name = "YardsAllowedPerGameRank", Order = 379)]
        public int? YardsAllowedPerGameRank { get; set; }

        /// <summary>
        /// The average number of yards per reception gained by the offensive team when this defensive player allowed the reception.
        /// </summary>
        [Description("The average number of yards per reception gained by the offensive team when this defensive player allowed the reception.")]
        [DataMember(Name = "YardsPerReceptionAllowed", Order = 380)]
        public decimal? YardsPerReceptionAllowed { get; set; }

        /// <summary>
        /// The player's Yards Per Reception Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Reception Allowed ranking relative to other players")]
        [DataMember(Name = "YardsPerReceptionAllowedRank", Order = 381)]
        public int? YardsPerReceptionAllowedRank { get; set; }

        /// <summary>
        /// The percentage of catches thrown into this defensive player's coverage areas that were allowed to be caught.
        /// </summary>
        [Description("The percentage of catches thrown into this defensive player's coverage areas that were allowed to be caught.")]
        [DataMember(Name = "CatchRateAllowed", Order = 382)]
        public decimal? CatchRateAllowed { get; set; }

        /// <summary>
        /// The player's Catch Rate Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Catch Rate Allowed ranking relative to other players")]
        [DataMember(Name = "CatchRateAllowedRank", Order = 383)]
        public int? CatchRateAllowedRank { get; set; }

        /// <summary>
        /// The quarterback's passer rating when throwing to a target to whom this defensive player is assigned.
        /// </summary>
        [Description("The quarterback's passer rating when throwing to a target to whom this defensive player is assigned.")]
        [DataMember(Name = "PasserRatingAllowed", Order = 384)]
        public decimal? PasserRatingAllowed { get; set; }

        /// <summary>
        /// The player's Passer Rating Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Passer Rating Allowed ranking relative to other players")]
        [DataMember(Name = "PasserRatingAllowedRank", Order = 385)]
        public int? PasserRatingAllowedRank { get; set; }

        /// <summary>
        /// The number of touchdowns allowed by this defensive player.
        /// </summary>
        [Description("The number of touchdowns allowed by this defensive player.")]
        [DataMember(Name = "TouchdownsAllowed", Order = 386)]
        public decimal? TouchdownsAllowed { get; set; }

        /// <summary>
        /// The player's Touchdowns Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Touchdowns Allowed ranking relative to other players")]
        [DataMember(Name = "TouchdownsAllowedRank", Order = 387)]
        public int? TouchdownsAllowedRank { get; set; }

        /// <summary>
        /// The percentage of interceptions carried out by this defensive player when he is assigned to the player being targeted for a pass.
        /// </summary>
        [Description("The percentage of interceptions carried out by this defensive player when he is assigned to the player being targeted for a pass.")]
        [DataMember(Name = "InterceptionsPerTarget", Order = 388)]
        public decimal? InterceptionsPerTarget { get; set; }

        /// <summary>
        /// The player's Interceptions Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Interceptions Per Target ranking relative to other players")]
        [DataMember(Name = "InterceptionsPerTargetRank", Order = 389)]
        public int? InterceptionsPerTargetRank { get; set; }

        /// <summary>
        /// A comprehensive cornerback efficiency metric incorporating target rate, pass break-ups, catch rate allowed, and fantasy points allowed per snap.
        /// </summary>
        [Description("A comprehensive cornerback efficiency metric incorporating target rate, pass break-ups, catch rate allowed, and fantasy points allowed per snap.")]
        [DataMember(Name = "CoverageRating", Order = 390)]
        public decimal? CoverageRating { get; set; }

        /// <summary>
        /// The player's Coverage Rating ranking relative to other players
        /// </summary>
        [Description("The player's Coverage Rating ranking relative to other players")]
        [DataMember(Name = "CoverageRatingRank", Order = 391)]
        public int? CoverageRatingRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "RunPlayStops", Order = 392)]
        public decimal? RunPlayStops { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "RunPlayStopsRank", Order = 393)]
        public int? RunPlayStopsRank { get; set; }

        /// <summary>
        /// The average number of times per game that this defensive player allows a passing target to emerge.
        /// </summary>
        [Description("The average number of times per game that this defensive player allows a passing target to emerge.")]
        [DataMember(Name = "TargetsAllowedPerGame", Order = 394)]
        public decimal? TargetsAllowedPerGame { get; set; }

        /// <summary>
        /// The player's Targets Allowed Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Targets Allowed Per Game ranking relative to other players")]
        [DataMember(Name = "TargetsAllowedPerGameRank", Order = 395)]
        public int? TargetsAllowedPerGameRank { get; set; }

        /// <summary>
        /// The number of successful pasing receptions allowed per game by this defensive player.
        /// </summary>
        [Description("The number of successful pasing receptions allowed per game by this defensive player.")]
        [DataMember(Name = "ReceptionsAllowedPerGame", Order = 396)]
        public decimal? ReceptionsAllowedPerGame { get; set; }

        /// <summary>
        /// The player's Receptions Allowed Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Receptions Allowed Per Game ranking relative to other players")]
        [DataMember(Name = "ReceptionsAllowedPerGameRank", Order = 397)]
        public int? ReceptionsAllowedPerGameRank { get; set; }

        /// <summary>
        /// Ratio of total targets to total routes run by running backs, wide receivers, and tight ends.
        /// </summary>
        [Description("Ratio of total targets to total routes run by running backs, wide receivers, and tight ends.")]
        [DataMember(Name = "TargetRate", Order = 398)]
        public decimal? TargetRate { get; set; }

        /// <summary>
        /// The player's Target Rate ranking relative to other players
        /// </summary>
        [Description("The player's Target Rate ranking relative to other players")]
        [DataMember(Name = "TargetRateRank", Order = 399)]
        public int? TargetRateRank { get; set; }

        /// <summary>
        /// The player's Burn Rate ranking relative to other players
        /// </summary>
        [Description("The player's Burn Rate ranking relative to other players")]
        [DataMember(Name = "BurnRateRank", Order = 400)]
        public int? BurnRateRank { get; set; }

        /// <summary>
        /// The average distance in yards between the defensive player and their assigned TE/WR at the time of the snap.
        /// </summary>
        [Description("The average distance in yards between the defensive player and their assigned TE/WR at the time of the snap.")]
        [DataMember(Name = "AverageCushion", Order = 401)]
        public decimal? AverageCushion { get; set; }

        /// <summary>
        /// The player's Average Cushion ranking relative to other players
        /// </summary>
        [Description("The player's Average Cushion ranking relative to other players")]
        [DataMember(Name = "AverageCushionRank", Order = 402)]
        public int? AverageCushionRank { get; set; }

        /// <summary>
        /// The average number of yards conceded by this player's team per time this defensive player's target is thrown to.
        /// </summary>
        [Description("The average number of yards conceded by this player's team per time this defensive player's target is thrown to.")]
        [DataMember(Name = "YardsPerTargetAllowed", Order = 403)]
        public decimal? YardsPerTargetAllowed { get; set; }

        /// <summary>
        /// The player's Yards Per Target Allowed ranking relative to other players
        /// </summary>
        [Description("The player's Yards Per Target Allowed ranking relative to other players")]
        [DataMember(Name = "YardsPerTargetAllowedRank", Order = 404)]
        public int? YardsPerTargetAllowedRank { get; set; }

        /// <summary>
        /// The number of times this player was involved in a defensive play against a passing route play.
        /// </summary>
        [Description("The number of times this player was involved in a defensive play against a passing route play.")]
        [DataMember(Name = "RoutesDefended", Order = 405)]
        public decimal? RoutesDefended { get; set; }

        /// <summary>
        /// The player's Routes Defended ranking relative to other players
        /// </summary>
        [Description("The player's Routes Defended ranking relative to other players")]
        [DataMember(Name = "RoutesDefendedRank", Order = 406)]
        public int? RoutesDefendedRank { get; set; }

        /// <summary>
        /// The average number of times per game this player was involved in a defensive play against a passing route play.
        /// </summary>
        [Description("The average number of times per game this player was involved in a defensive play against a passing route play.")]
        [DataMember(Name = "RoutesDefendedPerGame", Order = 407)]
        public decimal? RoutesDefendedPerGame { get; set; }

        /// <summary>
        /// The player's Routes Defended Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Routes Defended Per Game ranking relative to other players")]
        [DataMember(Name = "RoutesDefendedPerGameRank", Order = 408)]
        public int? RoutesDefendedPerGameRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "FantasyPoints", Order = 409)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// In terms of passing opportunities, measuring quarterback fantasy points by dividing total fantasy points by passing attempts
        /// </summary>
        [Description("In terms of passing opportunities, measuring quarterback fantasy points by dividing total fantasy points by passing attempts")]
        [DataMember(Name = "FantasyPointsPerAttempt", Order = 410)]
        public decimal? FantasyPointsPerAttempt { get; set; }

        /// <summary>
        /// The QB's Fantasy Points Per Attempt ranking relative to other players
        /// </summary>
        [Description("The QB's Fantasy Points Per Attempt ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerAttemptRank", Order = 411)]
        public int? FantasyPointsPerAttemptRank { get; set; }

        /// <summary>
        /// The QB's average fantasy points per drop backs to pass.
        /// </summary>
        [Description("The QB's average fantasy points per drop backs to pass.")]
        [DataMember(Name = "FantasyPointsPerDropBack", Order = 412)]
        public decimal? FantasyPointsPerDropBack { get; set; }

        /// <summary>
        /// The player's Fantasy Points Per Dropback ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Per Dropback ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerDropBackRank", Order = 413)]
        public int? FantasyPointsPerDropBackRank { get; set; }

        /// <summary>
        /// The average number of fantasy points scored by a player with a point-scoring opportunity (in a game where the player had a passing attempt, carry, or target.) 1 point per 10 yards rushing/receiving, 1 point per 25 passing yards, 1 point per reception, and 4 points for quarterback passing touchdowns.
        /// </summary>
        [Description("The average number of fantasy points scored by a player with a point-scoring opportunity (in a game where the player had a passing attempt, carry, or target.) 1 point per 10 yards rushing/receiving, 1 point per 25 passing yards, 1 point per reception, and 4 points for quarterback passing touchdowns.")]
        [DataMember(Name = "FantasyPointsPerGame", Order = 414)]
        public decimal? FantasyPointsPerGame { get; set; }

        /// <summary>
        /// The difference, expressed as a percentage, of a player's expected fantasy point output and the one they get in reality.
        /// </summary>
        [Description("The difference, expressed as a percentage, of a player's expected fantasy point output and the one they get in reality.")]
        [DataMember(Name = "FantasyPointsPerGameDifferential", Order = 415)]
        public decimal? FantasyPointsPerGameDifferential { get; set; }

        /// <summary>
        /// The player's Fantasy Points Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Per Game ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerGameRank", Order = 416)]
        public int? FantasyPointsPerGameRank { get; set; }

        /// <summary>
        /// Running back fantasy points in terms of a player's overall usage and playmaking prowess. Calculated by adding the player's carries and targets, then dividing the result by total fantasy points.
        /// </summary>
        [Description("Running back fantasy points in terms of a player's overall usage and playmaking prowess. Calculated by adding the player's carries and targets, then dividing the result by total fantasy points.")]
        [DataMember(Name = "FantasyPointsPerOpportunity", Order = 417)]
        public decimal? FantasyPointsPerOpportunity { get; set; }

        /// <summary>
        /// The player's Fantasy Points Per Opportunity ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Per Opportunity ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerOpportunityRank", Order = 418)]
        public int? FantasyPointsPerOpportunityRank { get; set; }

        /// <summary>
        /// For RB/TE/WRs, the average number of fantasy points generated by the player per snap.
        /// </summary>
        [Description("For RB/TE/WRs, the average number of fantasy points generated by the player per snap.")]
        [DataMember(Name = "FantasyPointsPerSnap", Order = 419)]
        public decimal? FantasyPointsPerSnap { get; set; }

        /// <summary>
        /// The player's Fantasy Points Per Snap ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Per Snap ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerSnapRank", Order = 420)]
        public int? FantasyPointsPerSnapRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "FantasyPointsPerPassRoute", Order = 421)]
        public decimal? FantasyPointsPerPassRoute { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "FantasyPointsPerPassRouteRank", Order = 422)]
        public int? FantasyPointsPerPassRouteRank { get; set; }

        /// <summary>
        /// In terms of player opportunities, dividing total fantasy points by total targets to calculate WR and TE fantasy points
        /// </summary>
        [Description("In terms of player opportunities, dividing total fantasy points by total targets to calculate WR and TE fantasy points")]
        [DataMember(Name = "FantasyPointsPerTarget", Order = 423)]
        public decimal? FantasyPointsPerTarget { get; set; }

        /// <summary>
        /// The player's Fantasy Points Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Per Target ranking relative to other players")]
        [DataMember(Name = "FantasyPointsPerTargetRank", Order = 424)]
        public int? FantasyPointsPerTargetRank { get; set; }

        /// <summary>
        /// The number of fantasy points generated by this player when he lined up in the slot.
        /// </summary>
        [Description("The number of fantasy points generated by this player when he lined up in the slot.")]
        [DataMember(Name = "SlotFantasyPoints", Order = 425)]
        public decimal? SlotFantasyPoints { get; set; }

        /// <summary>
        /// The player's Slot Fantasy Points ranking relative to other players
        /// </summary>
        [Description("The player's Slot Fantasy Points ranking relative to other players")]
        [DataMember(Name = "SlotFantasyPointsRank", Order = 426)]
        public int? SlotFantasyPointsRank { get; set; }

        /// <summary>
        /// The average number of fantasy points per game generated by this player when he lined up in the slot.
        /// </summary>
        [Description("The average number of fantasy points per game generated by this player when he lined up in the slot.")]
        [DataMember(Name = "SlotFantasyPointsPerGame", Order = 427)]
        public decimal? SlotFantasyPointsPerGame { get; set; }

        /// <summary>
        /// The player's Slot Fantasy Points Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Slot Fantasy Points Per Game ranking relative to other players")]
        [DataMember(Name = "SlotFantasyPointsPerGameRank", Order = 428)]
        public int? SlotFantasyPointsPerGameRank { get; set; }

        /// <summary>
        /// The average number of fantasy points generated per play in which he was a target by this player when he lined up in the slot.
        /// </summary>
        [Description("The average number of fantasy points generated per play in which he was a target by this player when he lined up in the slot.")]
        [DataMember(Name = "SlotFantasyPointsPerTarget", Order = 429)]
        public decimal? SlotFantasyPointsPerTarget { get; set; }

        /// <summary>
        /// The player's Slot Fantasy Points Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Slot Fantasy Points Per Target ranking relative to other players")]
        [DataMember(Name = "SlotFantasyPointsPerTargetRank", Order = 430)]
        public int? SlotFantasyPointsPerTargetRank { get; set; }

        /// <summary>
        /// The number of fantasy points given up by this defensive player.
        /// </summary>
        [Description("The number of fantasy points given up by this defensive player.")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 431)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// The number of fantasy points given up by this defensive player each time his assigned offensive player is targeted for a pass.
        /// </summary>
        [Description("The number of fantasy points given up by this defensive player each time his assigned offensive player is targeted for a pass.")]
        [DataMember(Name = "FantasyPointsAllowedPerTarget", Order = 432)]
        public decimal? FantasyPointsAllowedPerTarget { get; set; }

        /// <summary>
        /// The player's Fantasy Points Allowed Per Target ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Allowed Per Target ranking relative to other players")]
        [DataMember(Name = "FantasyPointsAllowedPerTargetRank", Order = 433)]
        public int? FantasyPointsAllowedPerTargetRank { get; set; }

        /// <summary>
        /// The average number per game of fantasy points given up by this defensive player.
        /// </summary>
        [Description("The average number per game of fantasy points given up by this defensive player.")]
        [DataMember(Name = "FantasyPointsAllowedPerGame", Order = 434)]
        public decimal? FantasyPointsAllowedPerGame { get; set; }

        /// <summary>
        /// The player's Fantasy Points Allowed Per Game ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Allowed Per Game ranking relative to other players")]
        [DataMember(Name = "FantasyPointsAllowedPerGameRank", Order = 435)]
        public int? FantasyPointsAllowedPerGameRank { get; set; }

        /// <summary>
        /// The average number per snap of fantasy points given up by this defensive player.
        /// </summary>
        [Description("The average number per snap of fantasy points given up by this defensive player.")]
        [DataMember(Name = "FantasyPointsAllowedPerSnap", Order = 436)]
        public decimal? FantasyPointsAllowedPerSnap { get; set; }

        /// <summary>
        /// The player's Fantasy Points Allowed Per Snap ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Allowed Per Snap ranking relative to other players")]
        [DataMember(Name = "FantasyPointsAllowedPerSnapRank", Order = 437)]
        public int? FantasyPointsAllowedPerSnapRank { get; set; }

        /// <summary>
        /// For cornerbacks, the number of points given up on average each time they defended in a cover snap.
        /// </summary>
        [Description("For cornerbacks, the number of points given up on average each time they defended in a cover snap.")]
        [DataMember(Name = "FantasyPointsAllowedPerCoverSnap", Order = 438)]
        public decimal? FantasyPointsAllowedPerCoverSnap { get; set; }

        /// <summary>
        /// The player's Fantasy Points Allowed Per Cover Snap ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points Allowed Per Cover Snap ranking relative to other players")]
        [DataMember(Name = "FantasyPointsAllowedPerCoverSnapRank", Order = 439)]
        public int? FantasyPointsAllowedPerCoverSnapRank { get; set; }

        /// <summary>
        /// The offensive player's Expected Fantasy Points over the course of the season.
        /// </summary>
        [Description("The offensive player's Expected Fantasy Points over the course of the season.")]
        [DataMember(Name = "ExpectedFantasyPoints", Order = 440)]
        public decimal? ExpectedFantasyPoints { get; set; }

        /// <summary>
        /// The player's Expected Fantasy Points ranking relative to other players
        /// </summary>
        [Description("The player's Expected Fantasy Points ranking relative to other players")]
        [DataMember(Name = "ExpectedFantasyPointsRank", Order = 441)]
        public int? ExpectedFantasyPointsRank { get; set; }

        /// <summary>
        /// The offensive player's expected fantasy points in a given game.
        /// </summary>
        [Description("The offensive player's expected fantasy points in a given game.")]
        [DataMember(Name = "ExpectedFantasyPointsPerGame", Order = 442)]
        public decimal? ExpectedFantasyPointsPerGame { get; set; }

        /// <summary>
        /// The player's Expected Fantasy Points ranking relative to other players
        /// </summary>
        [Description("The player's Expected Fantasy Points ranking relative to other players")]
        [DataMember(Name = "ExpectedFantasyPointsPerGameRank", Order = 443)]
        public int? ExpectedFantasyPointsPerGameRank { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "NormalizedFantasyPointsPerGame", Order = 444)]
        public decimal? NormalizedFantasyPointsPerGame { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [Description("Not currently used.")]
        [DataMember(Name = "NormalizedFantasyPointsPerGameRank", Order = 445)]
        public int? NormalizedFantasyPointsPerGameRank { get; set; }

    }
}

