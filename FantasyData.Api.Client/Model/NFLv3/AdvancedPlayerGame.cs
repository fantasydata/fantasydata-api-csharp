using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayerGame")]
    [Serializable]
    public partial class AdvancedPlayerGame
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
        /// 	The unique ID of this team
        /// </summary>
        [Description("	The unique ID of this team")]
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
        /// 	Player Position Group (QB, RB, WR, TE, DL, LB, DB, K, P, OL)
        /// </summary>
        [Description("	Player Position Group (QB, RB, WR, TE, DL, LB, DB, K, P, OL)")]
        [DataMember(Name = "PositionGroup", Order = 7)]
        public string PositionGroup { get; set; }

        /// <summary>
        /// The NFL season in four-digit year format.
        /// </summary>
        [Description("The NFL season in four-digit year format.")]
        [DataMember(Name = "Season", Order = 8)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 9)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs.
        /// </summary>
        [Description("The week during the season/round in which this game occurs.")]
        [DataMember(Name = "Week", Order = 10)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation of the Opponent
        /// </summary>
        [Description("The abbreviation of the Opponent")]
        [DataMember(Name = "Opponent", Order = 11)]
        public string Opponent { get; set; }

        /// <summary>
        /// The opposing team's unique ID number
        /// </summary>
        [Description("The opposing team's unique ID number")]
        [DataMember(Name = "OpponentID", Order = 12)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// How many snaps this player took part in in this game
        /// </summary>
        [Description("How many snaps this player took part in in this game")]
        [DataMember(Name = "Snaps", Order = 13)]
        public decimal? Snaps { get; set; }

        /// <summary>
        /// 	The percentage of total offensive plays that had this player on the field.
        /// </summary>
        [Description("	The percentage of total offensive plays that had this player on the field.")]
        [DataMember(Name = "SnapShare", Order = 14)]
        public decimal? SnapShare { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "PassingAttempts", Order = 15)]
        public decimal? PassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "Completions", Order = 16)]
        public decimal? Completions { get; set; }

        /// <summary>
        /// Percentage of completed passes from all passes thrown
        /// </summary>
        [Description("Percentage of completed passes from all passes thrown")]
        [DataMember(Name = "CompletionPercentage", Order = 17)]
        public decimal? CompletionPercentage { get; set; }

        /// <summary>
        /// Yards thrown by the player in the game.
        /// </summary>
        [Description("Yards thrown by the player in the game.")]
        [DataMember(Name = "PassingYards", Order = 18)]
        public decimal? PassingYards { get; set; }

        /// <summary>
        /// Yards thrown divided by total passing attempts.
        /// </summary>
        [Description("Yards thrown divided by total passing attempts.")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 19)]
        public decimal? PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// How many passes resulted in a touchdown.
        /// </summary>
        [Description("How many passes resulted in a touchdown.")]
        [DataMember(Name = "PassingTouchdowns", Order = 20)]
        public decimal? PassingTouchdowns { get; set; }

        /// <summary>
        /// Deprecated. Replaced by PassingTouchdowns
        /// </summary>
        [Description("Deprecated. Replaced by PassingTouchdowns")]
        [DataMember(Name = "PassingTDs", Order = 21)]
        public decimal? PassingTDs { get; set; }

        /// <summary>
        /// How many interceptions were given up by the player. (Not interceptions caught.)
        /// </summary>
        [Description("How many interceptions were given up by the player. (Not interceptions caught.)")]
        [DataMember(Name = "Interceptions", Order = 22)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// How many passing attempts were made inside the red zone by the player.
        /// </summary>
        [Description("How many passing attempts were made inside the red zone by the player.")]
        [DataMember(Name = "RedZoneAttempts", Order = 23)]
        public decimal? RedZoneAttempts { get; set; }

        /// <summary>
        /// What percentage of red zone passes were complete of all red zone passes attempted.
        /// </summary>
        [Description("What percentage of red zone passes were complete of all red zone passes attempted.")]
        [DataMember(Name = "RedZoneCompletionPercentage", Order = 24)]
        public decimal? RedZoneCompletionPercentage { get; set; }

        /// <summary>
        /// How many attempts were made to throw a pass with an aerial distance of 20 yards or greater.
        /// </summary>
        [Description("How many attempts were made to throw a pass with an aerial distance of 20 yards or greater.")]
        [DataMember(Name = "DeepBallAttempts", Order = 25)]
        public decimal? DeepBallAttempts { get; set; }

        /// <summary>
        /// How many successful passes with an aerial distance of 20 yards or greater were made by the player.
        /// </summary>
        [Description("How many successful passes with an aerial distance of 20 yards or greater were made by the player.")]
        [DataMember(Name = "DeepBallCompletions", Order = 26)]
        public decimal? DeepBallCompletions { get; set; }

        /// <summary>
        /// How many times the player carried the ball, i.e. unique rushing plays involving the player with the ball.
        /// </summary>
        [Description("How many times the player carried the ball, i.e. unique rushing plays involving the player with the ball.")]
        [DataMember(Name = "Carries", Order = 27)]
        public decimal? Carries { get; set; }

        /// <summary>
        /// Total number of carried yards on rushing plays.
        /// </summary>
        [Description("Total number of carried yards on rushing plays.")]
        [DataMember(Name = "RushingYards", Order = 28)]
        public decimal? RushingYards { get; set; }

        /// <summary>
        /// How many rushing touchdowns were achieved by the player.
        /// </summary>
        [Description("How many rushing touchdowns were achieved by the player.")]
        [DataMember(Name = "RushingTouchdowns", Order = 29)]
        public decimal? RushingTouchdowns { get; set; }

        /// <summary>
        /// How many times the player was targeted for a pass.
        /// </summary>
        [Description("How many times the player was targeted for a pass.")]
        [DataMember(Name = "Targets", Order = 30)]
        public decimal? Targets { get; set; }

        /// <summary>
        /// How many times the player received a pass.
        /// </summary>
        [Description("How many times the player received a pass.")]
        [DataMember(Name = "Receptions", Order = 31)]
        public decimal? Receptions { get; set; }

        /// <summary>
        /// How many total yards the player got from all plays in which he achieved a reception.
        /// </summary>
        [Description("How many total yards the player got from all plays in which he achieved a reception.")]
        [DataMember(Name = "ReceivingYards", Order = 32)]
        public decimal? ReceivingYards { get; set; }

        /// <summary>
        /// How many touchdowns the player scored by receiving a pass.
        /// </summary>
        [Description("How many touchdowns the player scored by receiving a pass.")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 33)]
        public decimal? ReceivingTouchdowns { get; set; }

        /// <summary>
        /// The total yards of gain (or loss) achieved by the player in the game.
        /// </summary>
        [Description("The total yards of gain (or loss) achieved by the player in the game.")]
        [DataMember(Name = "TotalYards", Order = 34)]
        public decimal? TotalYards { get; set; }

        /// <summary>
        /// Touches = carries + receptions.
        /// </summary>
        [Description("Touches = carries + receptions.")]
        [DataMember(Name = "TotalTouches", Order = 35)]
        public decimal? TotalTouches { get; set; }

        /// <summary>
        /// Average number of yards per carry and reception.
        /// </summary>
        [Description("Average number of yards per carry and reception.")]
        [DataMember(Name = "YardsPerTouch", Order = 36)]
        public decimal? YardsPerTouch { get; set; }

        /// <summary>
        /// For a given running back, number of carries and targets
        /// </summary>
        [Description("For a given running back, number of carries and targets")]
        [DataMember(Name = "Opportunities", Order = 37)]
        public decimal? Opportunities { get; set; }

        /// <summary>
        /// For a given running back, percentage of total team running back carries and targets
        /// </summary>
        [Description("For a given running back, percentage of total team running back carries and targets")]
        [DataMember(Name = "OpportunityShare", Order = 38)]
        public decimal? OpportunityShare { get; set; }

        /// <summary>
        /// Total number of touchdowns by all methods by the player.
        /// </summary>
        [Description("Total number of touchdowns by all methods by the player.")]
        [DataMember(Name = "TotalTouchdowns", Order = 39)]
        public decimal? TotalTouchdowns { get; set; }

        /// <summary>
        /// Number of attempted tackles evaded by the player.
        /// </summary>
        [Description("Number of attempted tackles evaded by the player.")]
        [DataMember(Name = "EvadedTackles", Order = 40)]
        public decimal? EvadedTackles { get; set; }

        /// <summary>
        /// Calculated by charting the number of broken, missed, and otherwise avoided tackles, and then dividing by the total number of touches (carries plus receptions). Juke rate is used to measure a running back's elusiveness and tackle-breaking power.
        /// </summary>
        [Description("Calculated by charting the number of broken, missed, and otherwise avoided tackles, and then dividing by the total number of touches (carries plus receptions). Juke rate is used to measure a running back's elusiveness and tackle-breaking power.")]
        [DataMember(Name = "JukeRate", Order = 41)]
        public decimal? JukeRate { get; set; }

        /// <summary>
        /// A measurement of a player's ability to secure the ball in all situations, regardless of difficulty level. Calculated by dividing total receptions by total targets.
        /// </summary>
        [Description("A measurement of a player's ability to secure the ball in all situations, regardless of difficulty level. Calculated by dividing total receptions by total targets.")]
        [DataMember(Name = "CatchRate", Order = 42)]
        public decimal? CatchRate { get; set; }

        /// <summary>
        /// The percentage of all passing targets directed at a given wide receiver or tight end, in games where that receiver was involved in the passing attack.
        /// </summary>
        [Description("The percentage of all passing targets directed at a given wide receiver or tight end, in games where that receiver was involved in the passing attack.")]
        [DataMember(Name = "TargetShare", Order = 43)]
        public decimal? TargetShare { get; set; }

        /// <summary>
        /// Number of targets per snap. Hog rate captures the rate of passing game utilization on a per-play basis, and helps to identify wide receivers and tight ends with limited route trees who are a focal point of the passing offense when on the field, even though they may have a low snap count and target share.
        /// </summary>
        [Description("Number of targets per snap. Hog rate captures the rate of passing game utilization on a per-play basis, and helps to identify wide receivers and tight ends with limited route trees who are a focal point of the passing offense when on the field, even though they may have a low snap count and target share.")]
        [DataMember(Name = "HogRate", Order = 44)]
        public decimal? HogRate { get; set; }

        /// <summary>
        /// Number of times the target player faced competition to catch the ball, i.e. a defender was in range to contest the ball at the point of catching.
        /// </summary>
        [Description("Number of times the target player faced competition to catch the ball, i.e. a defender was in range to contest the ball at the point of catching.")]
        [DataMember(Name = "ContestedTargets", Order = 45)]
        public decimal? ContestedTargets { get; set; }

        /// <summary>
        /// Number of times the received successfully caught the ball in a contested catch.
        /// </summary>
        [Description("Number of times the received successfully caught the ball in a contested catch.")]
        [DataMember(Name = "ContestedCatches", Order = 46)]
        public decimal? ContestedCatches { get; set; }

        /// <summary>
        /// Number of times the player executed a rushing play in the red zone.
        /// </summary>
        [Description("Number of times the player executed a rushing play in the red zone.")]
        [DataMember(Name = "RedZoneCarries", Order = 47)]
        public decimal? RedZoneCarries { get; set; }

        /// <summary>
        /// Number of times the player was targeted for a pass in the red zone.
        /// </summary>
        [Description("Number of times the player was targeted for a pass in the red zone.")]
        [DataMember(Name = "RedZoneTargets", Order = 48)]
        public decimal? RedZoneTargets { get; set; }

        /// <summary>
        /// Red zone opportunities are the number of carries plus targets combined for a player in the red zone.
        /// </summary>
        [Description("Red zone opportunities are the number of carries plus targets combined for a player in the red zone.")]
        [DataMember(Name = "RedZoneOpportunities", Order = 49)]
        public decimal? RedZoneOpportunities { get; set; }

        /// <summary>
        /// Number of times the player carried or received in the red zone.
        /// </summary>
        [Description("Number of times the player carried or received in the red zone.")]
        [DataMember(Name = "RedZoneTouches", Order = 50)]
        public decimal? RedZoneTouches { get; set; }

        /// <summary>
        /// Number of times the player successfully received a pass in the red zone.
        /// </summary>
        [Description("Number of times the player successfully received a pass in the red zone.")]
        [DataMember(Name = "RedZoneReceptions", Order = 51)]
        public decimal? RedZoneReceptions { get; set; }

        /// <summary>
        /// Percentage of catches successfully made versus targets.
        /// </summary>
        [Description("Percentage of catches successfully made versus targets.")]
        [DataMember(Name = "RedZoneCatchRate", Order = 52)]
        public decimal? RedZoneCatchRate { get; set; }

        /// <summary>
        /// Average number of yards achieved per carry by the player in the game.
        /// </summary>
        [Description("Average number of yards achieved per carry by the player in the game.")]
        [DataMember(Name = "YardsPerCarry", Order = 53)]
        public decimal? YardsPerCarry { get; set; }

        /// <summary>
        /// Average number of yards achieved per target by the player in the game.
        /// </summary>
        [Description("Average number of yards achieved per target by the player in the game.")]
        [DataMember(Name = "YardsPerTarget", Order = 54)]
        public decimal? YardsPerTarget { get; set; }

        /// <summary>
        /// Average number of yards achieved per opportunity (carry plus target) by the player in the game.
        /// </summary>
        [Description("Average number of yards achieved per opportunity (carry plus target) by the player in the game.")]
        [DataMember(Name = "YardsPerOpportunity", Order = 55)]
        public decimal? YardsPerOpportunity { get; set; }

        /// <summary>
        /// Average number of yards achieved per reception by the player in the game.
        /// </summary>
        [Description("Average number of yards achieved per reception by the player in the game.")]
        [DataMember(Name = "YardsPerReception", Order = 56)]
        public decimal? YardsPerReception { get; set; }

        /// <summary>
        /// Number of times the player was targeted for a pass in the endzone.
        /// </summary>
        [Description("Number of times the player was targeted for a pass in the endzone.")]
        [DataMember(Name = "EndZoneTargets", Order = 57)]
        public decimal? EndZoneTargets { get; set; }

        /// <summary>
        /// Number of times the player ran a route in the game.
        /// </summary>
        [Description("Number of times the player ran a route in the game.")]
        [DataMember(Name = "RoutesRun", Order = 58)]
        public decimal? RoutesRun { get; set; }

        /// <summary>
        /// Number of times the player burns - fakes out and defeats - a defending player and catches a pass.
        /// </summary>
        [Description("Number of times the player burns - fakes out and defeats - a defending player and catches a pass.")]
        [DataMember(Name = "Burns", Order = 59)]
        public decimal? Burns { get; set; }

        /// <summary>
        /// Number of times the player was hurried by the defense into throwing an early pass or to running in the pocket from a defender.
        /// </summary>
        [Description("Number of times the player was hurried by the defense into throwing an early pass or to running in the pocket from a defender.")]
        [DataMember(Name = "Hurries", Order = 60)]
        public decimal? Hurries { get; set; }

        /// <summary>
        /// All yards generated above and beyond what was blocked. Yards Created are accrued after the running back's first evaded tackle.
        /// </summary>
        [Description("All yards generated above and beyond what was blocked. Yards Created are accrued after the running back's first evaded tackle.")]
        [DataMember(Name = "YardsCreated", Order = 61)]
        public decimal? YardsCreated { get; set; }

        /// <summary>
        /// Number of passing attempts made inside the 5-yard line.
        /// </summary>
        [Description("Number of passing attempts made inside the 5-yard line.")]
        [DataMember(Name = "PassAttemptsInside5", Order = 62)]
        public decimal? PassAttemptsInside5 { get; set; }

        /// <summary>
        /// Number of passing attempts made inside the 10-yard line.
        /// </summary>
        [Description("Number of passing attempts made inside the 10-yard line.")]
        [DataMember(Name = "PassAttemptsInside10", Order = 63)]
        public decimal? PassAttemptsInside10 { get; set; }

        /// <summary>
        /// Number of rushing plays made inside the 5-yard line.
        /// </summary>
        [Description("Number of rushing plays made inside the 5-yard line.")]
        [DataMember(Name = "CarriesInside5", Order = 64)]
        public decimal? CarriesInside5 { get; set; }

        /// <summary>
        /// Number of rushing plays made inside the 10-yard line.
        /// </summary>
        [Description("Number of rushing plays made inside the 10-yard line.")]
        [DataMember(Name = "CarriesInside10", Order = 65)]
        public decimal? CarriesInside10 { get; set; }

        /// <summary>
        /// Number of times the player was a pass target inside the 5-yard line.
        /// </summary>
        [Description("Number of times the player was a pass target inside the 5-yard line.")]
        [DataMember(Name = "TargetsInside5", Order = 66)]
        public decimal? TargetsInside5 { get; set; }

        /// <summary>
        /// Number of times the player was a pass target inside the 10-yard line.
        /// </summary>
        [Description("Number of times the player was a pass target inside the 10-yard line.")]
        [DataMember(Name = "TargetsInside10", Order = 67)]
        public decimal? TargetsInside10 { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        [Description("Currently unused.")]
        [DataMember(Name = "PrimaryCorner", Order = 68)]
        public decimal? PrimaryCorner { get; set; }

        /// <summary>
        /// Number of times the player in question defended against a player running a route.
        /// </summary>
        [Description("Number of times the player in question defended against a player running a route.")]
        [DataMember(Name = "RoutesDefended", Order = 69)]
        public decimal? RoutesDefended { get; set; }

        /// <summary>
        /// Number of times the defensive player allowed a target a chance at a reception.
        /// </summary>
        [Description("Number of times the defensive player allowed a target a chance at a reception.")]
        [DataMember(Name = "TargetsAllowed", Order = 70)]
        public decimal? TargetsAllowed { get; set; }

        /// <summary>
        /// Number of times the defensive player allowed a target a chance at reception that was successfully achieved by the catcher.
        /// </summary>
        [Description("Number of times the defensive player allowed a target a chance at reception that was successfully achieved by the catcher.")]
        [DataMember(Name = "ReceptionsAllowed", Order = 71)]
        public decimal? ReceptionsAllowed { get; set; }

        /// <summary>
        /// Total number of yards allowed by the defensive player during the game.
        /// </summary>
        [Description("Total number of yards allowed by the defensive player during the game.")]
        [DataMember(Name = "YardsAllowed", Order = 72)]
        public decimal? YardsAllowed { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        [Description("Currently unused.")]
        [DataMember(Name = "BurnsCB", Order = 73)]
        public decimal? BurnsCB { get; set; }

        /// <summary>
        /// Number of times a defensive player successfully breaks up a pass with the arm or hand.
        /// </summary>
        [Description("Number of times a defensive player successfully breaks up a pass with the arm or hand.")]
        [DataMember(Name = "PassBreakups", Order = 74)]
        public decimal? PassBreakups { get; set; }

        /// <summary>
        /// Number of times a defensive player intercepts an opponent's pass.
        /// </summary>
        [Description("Number of times a defensive player intercepts an opponent's pass.")]
        [DataMember(Name = "InterceptionsCB", Order = 75)]
        public decimal? InterceptionsCB { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        [Description("Currently unused.")]
        [DataMember(Name = "WRMatchup", Order = 76)]
        public decimal? WRMatchup { get; set; }

        /// <summary>
        /// Number of Fantasy Points generated by the player that week.
        /// </summary>
        [Description("Number of Fantasy Points generated by the player that week.")]
        [DataMember(Name = "FantasyPoints", Order = 77)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The player's Fantasy Points ranking relative to other players
        /// </summary>
        [Description("The player's Fantasy Points ranking relative to other players")]
        [DataMember(Name = "FantasyPointsRank", Order = 78)]
        public int? FantasyPointsRank { get; set; }

        /// <summary>
        /// In terms of passing opportunities, measuring quarterback fantasy points by dividing total fantasy points by passing attempts
        /// </summary>
        [Description("In terms of passing opportunities, measuring quarterback fantasy points by dividing total fantasy points by passing attempts")]
        [DataMember(Name = "FantasyPointsPerAttempt", Order = 79)]
        public decimal? FantasyPointsPerAttempt { get; set; }

        /// <summary>
        /// In terms of player opportunities, dividing total fantasy points by total targets to measure wide receiver and tight end fantasy points
        /// </summary>
        [Description("In terms of player opportunities, dividing total fantasy points by total targets to measure wide receiver and tight end fantasy points")]
        [DataMember(Name = "FantasyPointsPerTarget", Order = 80)]
        public decimal? FantasyPointsPerTarget { get; set; }

        /// <summary>
        /// Running back fantasy points in terms of a player's overall usage and playmaking prowess. Calculated by adding the player's carries and targets, then dividing the result by total fantasy points.
        /// </summary>
        [Description("Running back fantasy points in terms of a player's overall usage and playmaking prowess. Calculated by adding the player's carries and targets, then dividing the result by total fantasy points.")]
        [DataMember(Name = "FantasyPointsPerOpportunity", Order = 81)]
        public decimal? FantasyPointsPerOpportunity { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        [Description("Currently unused.")]
        [DataMember(Name = "FantasyPointsAllowed", Order = 82)]
        public decimal? FantasyPointsAllowed { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        [Description("Currently unused.")]
        [DataMember(Name = "FantasyPointsAllowedWeekRank", Order = 83)]
        public int? FantasyPointsAllowedWeekRank { get; set; }

    }
}

