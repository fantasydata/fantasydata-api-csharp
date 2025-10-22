using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerSeasonRedZone")]
    [Serializable]
    public partial class PlayerSeasonRedZone
    {
        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season for which these totals apply
        /// </summary>
        [Description("The NFL season for which these totals apply")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 5)]
        public int Number { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR
        /// </summary>
        [Description("The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The category of the player's position (OFF; DEF; ST)
        /// </summary>
        [Description("The category of the player's position (OFF; DEF; ST)")]
        [DataMember(Name = "PositionCategory", Order = 8)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The total number of games that the player was active for in the season
        /// </summary>
        [Description("The total number of games that the player was active for in the season")]
        [DataMember(Name = "Activated", Order = 9)]
        public int Activated { get; set; }

        /// <summary>
        /// The total number of games played by the the player in the season
        /// </summary>
        [Description("The total number of games played by the the player in the season")]
        [DataMember(Name = "Played", Order = 10)]
        public int Played { get; set; }

        /// <summary>
        /// Total games started (on offense or defense) by the player in the season
        /// </summary>
        [Description("Total games started (on offense or defense) by the player in the season")]
        [DataMember(Name = "Started", Order = 11)]
        public int Started { get; set; }

        /// <summary>
        /// Total passes thrown by the player in the season
        /// </summary>
        [Description("Total passes thrown by the player in the season")]
        [DataMember(Name = "PassingAttempts", Order = 12)]
        public decimal PassingAttempts { get; set; }

        /// <summary>
        /// Total passes completed by the player in the season
        /// </summary>
        [Description("Total passes completed by the player in the season")]
        [DataMember(Name = "PassingCompletions", Order = 13)]
        public decimal PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the player in the season
        /// </summary>
        [Description("Total passing yards by the player in the season")]
        [DataMember(Name = "PassingYards", Order = 14)]
        public decimal PassingYards { get; set; }

        /// <summary>
        /// The percentage of passes completed by the player in the season
        /// </summary>
        [Description("The percentage of passes completed by the player in the season")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 15)]
        public decimal PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Total average passing yards per attempt by the player in the season
        /// </summary>
        [Description("Total average passing yards per attempt by the player in the season")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 16)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total average passing yards per completion by the player in the season
        /// </summary>
        [Description("Total average passing yards per completion by the player in the season")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 17)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total passing touchdowns by the player in the season
        /// </summary>
        [Description("Total passing touchdowns by the player in the season")]
        [DataMember(Name = "PassingTouchdowns", Order = 18)]
        public decimal PassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the player in the season
        /// </summary>
        [Description("Total interceptions thrown by the player in the season")]
        [DataMember(Name = "PassingInterceptions", Order = 19)]
        public decimal PassingInterceptions { get; set; }

        /// <summary>
        /// The passer rating of the player in the season
        /// </summary>
        [Description("The passer rating of the player in the season")]
        [DataMember(Name = "PassingRating", Order = 20)]
        public decimal PassingRating { get; set; }

        /// <summary>
        /// Total yards of longest completion by the player in the season
        /// </summary>
        [Description("Total yards of longest completion by the player in the season")]
        [DataMember(Name = "PassingLong", Order = 21)]
        public decimal PassingLong { get; set; }

        /// <summary>
        /// The total number of times the player was sacked in the season
        /// </summary>
        [Description("The total number of times the player was sacked in the season")]
        [DataMember(Name = "PassingSacks", Order = 22)]
        public decimal PassingSacks { get; set; }

        /// <summary>
        /// Total yards lost by the player in the season as a result of being sacked
        /// </summary>
        [Description("Total yards lost by the player in the season as a result of being sacked")]
        [DataMember(Name = "PassingSackYards", Order = 23)]
        public decimal PassingSackYards { get; set; }

        /// <summary>
        /// Total rushing attempts by the player in the season
        /// </summary>
        [Description("Total rushing attempts by the player in the season")]
        [DataMember(Name = "RushingAttempts", Order = 24)]
        public decimal RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the player in the season
        /// </summary>
        [Description("Total rushing yards by the player in the season")]
        [DataMember(Name = "RushingYards", Order = 25)]
        public decimal RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt by the player in the season
        /// </summary>
        [Description("Total rushing yards per attempt by the player in the season")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 26)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the player in the season
        /// </summary>
        [Description("Total rushing touchdowns by the player in the season")]
        [DataMember(Name = "RushingTouchdowns", Order = 27)]
        public decimal RushingTouchdowns { get; set; }

        /// <summary>
        /// The longest rush by the player in the season
        /// </summary>
        [Description("The longest rush by the player in the season")]
        [DataMember(Name = "RushingLong", Order = 28)]
        public decimal RushingLong { get; set; }

        /// <summary>
        /// Total receiving targets by the player in the season
        /// </summary>
        [Description("Total receiving targets by the player in the season")]
        [DataMember(Name = "ReceivingTargets", Order = 29)]
        public decimal? ReceivingTargets { get; set; }

        /// <summary>
        /// Total receptions by the player in the season
        /// </summary>
        [Description("Total receptions by the player in the season")]
        [DataMember(Name = "Receptions", Order = 30)]
        public decimal Receptions { get; set; }

        /// <summary>
        /// Total receiving yards by the player in the season
        /// </summary>
        [Description("Total receiving yards by the player in the season")]
        [DataMember(Name = "ReceivingYards", Order = 31)]
        public decimal ReceivingYards { get; set; }

        /// <summary>
        /// Average receiving yards per reception by the player in the season
        /// </summary>
        [Description("Average receiving yards per reception by the player in the season")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 32)]
        public decimal ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Total receiving touchdowns by the player in the season
        /// </summary>
        [Description("Total receiving touchdowns by the player in the season")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 33)]
        public decimal ReceivingTouchdowns { get; set; }

        /// <summary>
        /// The longest reception by the player in the season
        /// </summary>
        [Description("The longest reception by the player in the season")]
        [DataMember(Name = "ReceivingLong", Order = 34)]
        public decimal ReceivingLong { get; set; }

        /// <summary>
        /// Total fumbles by the player in the season
        /// </summary>
        [Description("Total fumbles by the player in the season")]
        [DataMember(Name = "Fumbles", Order = 35)]
        public decimal Fumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the player in the season
        /// </summary>
        [Description("Total fumbles lost by the player in the season")]
        [DataMember(Name = "FumblesLost", Order = 36)]
        public decimal? FumblesLost { get; set; }

        /// <summary>
        /// Total punt returns by the player in the season
        /// </summary>
        [Description("Total punt returns by the player in the season")]
        [DataMember(Name = "PuntReturns", Order = 37)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the player in the season
        /// </summary>
        [Description("Total punt return yards by the player in the season")]
        [DataMember(Name = "PuntReturnYards", Order = 38)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total average yards gained per punt return by the player in the season
        /// </summary>
        [Description("Total average yards gained per punt return by the player in the season")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 39)]
        public decimal PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the player in the season
        /// </summary>
        [Description("Total punt return touchdowns by the player in the season")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 40)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the player in the season
        /// </summary>
        [Description("The longest punt return by the player in the season")]
        [DataMember(Name = "PuntReturnLong", Order = 41)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff returns by the player in the season
        /// </summary>
        [Description("Total kickoff returns by the player in the season")]
        [DataMember(Name = "KickReturns", Order = 42)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the player in the season
        /// </summary>
        [Description("Total kickoff return yards by the player in the season")]
        [DataMember(Name = "KickReturnYards", Order = 43)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per kick return by the player in the season
        /// </summary>
        [Description("Average yards gained per kick return by the player in the season")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 44)]
        public decimal KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the player in the season
        /// </summary>
        [Description("Total kickoff return touchdowns by the player in the season")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 45)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the player in the season
        /// </summary>
        [Description("Longest kick return by the player in the season")]
        [DataMember(Name = "KickReturnLong", Order = 46)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the player in the season
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the player in the season")]
        [DataMember(Name = "SoloTackles", Order = 47)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the player in the season
        /// </summary>
        [Description("Total defensive assisted tackles by the player in the season")]
        [DataMember(Name = "AssistedTackles", Order = 48)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total tackles for loss by the player in the season. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the player in the season. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 49)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total defensive sacks by the player in the season
        /// </summary>
        [Description("Total defensive sacks by the player in the season")]
        [DataMember(Name = "Sacks", Order = 50)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the player in the season
        /// </summary>
        [Description("Total defensive safeties scored by the player in the season")]
        [DataMember(Name = "SackYards", Order = 51)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the player in the season. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the player in the season. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 52)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Total passes defended by the player in the season
        /// </summary>
        [Description("Total passes defended by the player in the season")]
        [DataMember(Name = "PassesDefended", Order = 53)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the player in the season
        /// </summary>
        [Description("Total fumbles forced on defense by the player in the season")]
        [DataMember(Name = "FumblesForced", Order = 54)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the player in the season
        /// </summary>
        [Description("Total defensive fumble recoveries by the player in the season")]
        [DataMember(Name = "FumblesRecovered", Order = 55)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the player in the season
        /// </summary>
        [Description("Total fumble return yards by the player in the season")]
        [DataMember(Name = "FumbleReturnYards", Order = 56)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the player in the season
        /// </summary>
        [Description("Total fumble return touchdowns by the player in the season")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 57)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interceptions by the player in the season
        /// </summary>
        [Description("Total defensive interceptions by the player in the season")]
        [DataMember(Name = "Interceptions", Order = 58)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the player in the season
        /// </summary>
        [Description("Total defensive interception return yards by the player in the season")]
        [DataMember(Name = "InterceptionReturnYards", Order = 59)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the player in the season
        /// </summary>
        [Description("Total defensive interception return touchdowns by the player in the season")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 60)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by the player in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by the player in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 61)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsSoloTackles", Order = 62)]
        public decimal SpecialTeamsSoloTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsAssistedTackles", Order = 63)]
        public decimal SpecialTeamsAssistedTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscSoloTackles", Order = 64)]
        public decimal MiscSoloTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscAssistedTackles", Order = 65)]
        public decimal MiscAssistedTackles { get; set; }

        /// <summary>
        /// Total number of punts by the player in the season
        /// </summary>
        [Description("Total number of punts by the player in the season")]
        [DataMember(Name = "Punts", Order = 66)]
        public decimal Punts { get; set; }

        /// <summary>
        /// Total punt yards by the player in the season
        /// </summary>
        [Description("Total punt yards by the player in the season")]
        [DataMember(Name = "PuntYards", Order = 67)]
        public decimal PuntYards { get; set; }

        /// <summary>
        /// The average number of yards per punt by the player in the season
        /// </summary>
        [Description("The average number of yards per punt by the player in the season")]
        [DataMember(Name = "PuntAverage", Order = 68)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Total field goals attempted by the player in the season
        /// </summary>
        [Description("Total field goals attempted by the player in the season")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 69)]
        public decimal FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goals made by the player in season
        /// </summary>
        [Description("Total field goals made by the player in season")]
        [DataMember(Name = "FieldGoalsMade", Order = 70)]
        public decimal FieldGoalsMade { get; set; }

        /// <summary>
        /// Longest field goal made by the player in the season
        /// </summary>
        [Description("Longest field goal made by the player in the season")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 71)]
        public decimal FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Total extra points made by the player in the season
        /// </summary>
        [Description("Total extra points made by the player in the season")]
        [DataMember(Name = "ExtraPointsMade", Order = 72)]
        public decimal ExtraPointsMade { get; set; }

        /// <summary>
        /// Total successful two point conversion passes by the player in the season
        /// </summary>
        [Description("Total successful two point conversion passes by the player in the season")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 73)]
        public decimal TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Total successful two point conversion rushes by the player in the season
        /// </summary>
        [Description("Total successful two point conversion rushes by the player in the season")]
        [DataMember(Name = "TwoPointConversionRuns", Order = 74)]
        public decimal TwoPointConversionRuns { get; set; }

        /// <summary>
        /// Total successful two point conversion receptions by the player in the season
        /// </summary>
        [Description("Total successful two point conversion receptions by the player in the season")]
        [DataMember(Name = "TwoPointConversionReceptions", Order = 75)]
        public decimal TwoPointConversionReceptions { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system by the player in the season")]
        [DataMember(Name = "FantasyPoints", Order = 76)]
        public decimal FantasyPoints { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic PPR fantasy scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points scored based on basic PPR fantasy scoring system by the player in the season")]
        [DataMember(Name = "FantasyPointsPPR", Order = 77)]
        public decimal FantasyPointsPPR { get; set; }

        /// <summary>
        /// Total percentage of receiving targets that were receptions by the player in the season
        /// </summary>
        [Description("Total percentage of receiving targets that were receptions by the player in the season")]
        [DataMember(Name = "ReceptionPercentage", Order = 78)]
        public decimal ReceptionPercentage { get; set; }

        /// <summary>
        /// Average receiving yards per target by the player in the season
        /// </summary>
        [Description("Average receiving yards per target by the player in the season")]
        [DataMember(Name = "ReceivingYardsPerTarget", Order = 79)]
        public decimal ReceivingYardsPerTarget { get; set; }

        /// <summary>
        /// Total tackles (solo & assisted) by the player in the season
        /// </summary>
        [Description("Total tackles (solo & assisted) by the player in the season")]
        [DataMember(Name = "Tackles", Order = 80)]
        public decimal Tackles { get; set; }

        /// <summary>
        /// Total offensive touchdowns scored by the player in the season
        /// </summary>
        [Description("Total offensive touchdowns scored by the player in the season")]
        [DataMember(Name = "OffensiveTouchdowns", Order = 81)]
        public decimal OffensiveTouchdowns { get; set; }

        /// <summary>
        /// Total defensive touchdowns scored by the player in the season
        /// </summary>
        [Description("Total defensive touchdowns scored by the player in the season")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 82)]
        public decimal DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total special teams touchdowns scored by the player in the season
        /// </summary>
        [Description("Total special teams touchdowns scored by the player in the season")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 83)]
        public decimal SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Total touchdowns scored by the player in the season
        /// </summary>
        [Description("Total touchdowns scored by the player in the season")]
        [DataMember(Name = "Touchdowns", Order = 84)]
        public decimal Touchdowns { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 85)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Total field goal attempts made by the player in the season
        /// </summary>
        [Description("Total field goal attempts made by the player in the season")]
        [DataMember(Name = "FieldGoalPercentage", Order = 86)]
        public decimal FieldGoalPercentage { get; set; }

        /// <summary>
        /// Unique ID of PlayerSeason record (subject to change, although it very rarely does).  For a static ID, use a combination of SeasonType, Season and PlayerID.
        /// </summary>
        [Description("Unique ID of PlayerSeason record (subject to change, although it very rarely does).  For a static ID, use a combination of SeasonType, Season and PlayerID.")]
        [DataMember(Name = "PlayerSeasonID", Order = 87)]
        public int PlayerSeasonID { get; set; }

        /// <summary>
        /// Total own fumble recoveries by the player in the season. Note: this fumble doesn't result in a turnover - the fumbling team recovers the fumble
        /// </summary>
        [Description("Total own fumble recoveries by the player in the season. Note: this fumble doesn't result in a turnover - the fumbling team recovers the fumble")]
        [DataMember(Name = "FumblesOwnRecoveries", Order = 88)]
        public decimal? FumblesOwnRecoveries { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "FumblesOutOfBounds", Order = 89)]
        public decimal? FumblesOutOfBounds { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "KickReturnFairCatches", Order = 90)]
        public decimal? KickReturnFairCatches { get; set; }

        /// <summary>
        /// This field is deprecated.
        /// </summary>
        [Description("This field is deprecated.")]
        [DataMember(Name = "PuntReturnFairCatches", Order = 91)]
        public decimal? PuntReturnFairCatches { get; set; }

        /// <summary>
        /// Total punts that resulted in touchbacks by the player in the season
        /// </summary>
        [Description("Total punts that resulted in touchbacks by the player in the season")]
        [DataMember(Name = "PuntTouchbacks", Order = 92)]
        public decimal? PuntTouchbacks { get; set; }

        /// <summary>
        /// Total punts downed inside the 20 yard line by the player in the season
        /// </summary>
        [Description("Total punts downed inside the 20 yard line by the player in the season")]
        [DataMember(Name = "PuntInside20", Order = 93)]
        public decimal? PuntInside20 { get; set; }

        /// <summary>
        /// The average net yards per punt by the player in the season
        /// </summary>
        [Description("The average net yards per punt by the player in the season")]
        [DataMember(Name = "PuntNetAverage", Order = 94)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kicks attempted by the player in the season
        /// </summary>
        [Description("Total extra point kicks attempted by the player in the season")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 95)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the player in the season
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the player in the season")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 96)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the player in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the player in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 97)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)
        /// </summary>
        [Description("Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)")]
        [DataMember(Name = "Safeties", Order = 98)]
        public decimal? Safeties { get; set; }

        /// <summary>
        /// Total field goals by the player that were blocked in the season
        /// </summary>
        [Description("Total field goals by the player that were blocked in the season")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 99)]
        public decimal? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punts by the player that were blocked in the season
        /// </summary>
        [Description("Total punts by the player that were blocked in the season")]
        [DataMember(Name = "PuntsHadBlocked", Order = 100)]
        public decimal? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the player that were blocked in the season
        /// </summary>
        [Description("Total extra point kick attempts by the player that were blocked in the season")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 101)]
        public decimal? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// The longest punt by the player in the season
        /// </summary>
        [Description("The longest punt by the player in the season")]
        [DataMember(Name = "PuntLong", Order = 102)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the player in the season
        /// </summary>
        [Description("Total blocked kick recovery return yards for the player in the season")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 103)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total field goal return yards by the player in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the player in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 104)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// The net yards of the punts by the player in the season
        /// </summary>
        [Description("The net yards of the punts by the player in the season")]
        [DataMember(Name = "PuntNetYards", Order = 105)]
        public decimal? PuntNetYards { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsFumblesForced", Order = 106)]
        public decimal? SpecialTeamsFumblesForced { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsFumblesRecovered", Order = 107)]
        public decimal? SpecialTeamsFumblesRecovered { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscFumblesForced", Order = 108)]
        public decimal? MiscFumblesForced { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscFumblesRecovered", Order = 109)]
        public decimal? MiscFumblesRecovered { get; set; }

        /// <summary>
        /// The first initial and last name of the player (J. Doe)
        /// </summary>
        [Description("The first initial and last name of the player (J. Doe)")]
        [DataMember(Name = "ShortName", Order = 110)]
        public string ShortName { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SafetiesAllowed", Order = 111)]
        public decimal? SafetiesAllowed { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 112)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 113)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
        [DataMember(Name = "WindSpeed", Order = 114)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// Total snaps this player played on offensive in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on offensive in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "OffensiveSnapsPlayed", Order = 115)]
        public int? OffensiveSnapsPlayed { get; set; }

        /// <summary>
        /// Total snaps this player played on defense in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on defense in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "DefensiveSnapsPlayed", Order = 116)]
        public int? DefensiveSnapsPlayed { get; set; }

        /// <summary>
        /// Total snaps this player played on special teams in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on special teams in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "SpecialTeamsSnapsPlayed", Order = 117)]
        public int? SpecialTeamsSnapsPlayed { get; set; }

        /// <summary>
        /// Total offensive snaps this player's team played in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total offensive snaps this player's team played in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "OffensiveTeamSnaps", Order = 118)]
        public int? OffensiveTeamSnaps { get; set; }

        /// <summary>
        /// Total defensive snaps this player's team played in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total defensive snaps this player's team played in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "DefensiveTeamSnaps", Order = 119)]
        public int? DefensiveTeamSnaps { get; set; }

        /// <summary>
        /// Total special teams snaps this player's team played in the season. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total special teams snaps this player's team played in the season. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "SpecialTeamsTeamSnaps", Order = 120)]
        public int? SpecialTeamsTeamSnaps { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap auction draft.")]
        [DataMember(Name = "AuctionValue", Order = 121)]
        public decimal? AuctionValue { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap PPR auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap PPR auction draft.")]
        [DataMember(Name = "AuctionValuePPR", Order = 122)]
        public decimal? AuctionValuePPR { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the player in the season
        /// </summary>
        [Description("Total successful two point conversion returns by the player in the season")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 123)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system by the player in the season")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 124)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total field goals of 0 to 19 yards made by the player in season
        /// </summary>
        [Description("Total field goals of 0 to 19 yards made by the player in season")]
        [DataMember(Name = "FieldGoalsMade0to19", Order = 125)]
        public decimal? FieldGoalsMade0to19 { get; set; }

        /// <summary>
        /// Total field goals of 20 to 29 yards made by the player in season
        /// </summary>
        [Description("Total field goals of 20 to 29 yards made by the player in season")]
        [DataMember(Name = "FieldGoalsMade20to29", Order = 126)]
        public decimal? FieldGoalsMade20to29 { get; set; }

        /// <summary>
        /// Total field goals of 30 to 39 yards made by the player in season
        /// </summary>
        [Description("Total field goals of 30 to 39 yards made by the player in season")]
        [DataMember(Name = "FieldGoalsMade30to39", Order = 127)]
        public decimal? FieldGoalsMade30to39 { get; set; }

        /// <summary>
        /// Total field goals of 40 to 49 yards made by the player in season
        /// </summary>
        [Description("Total field goals of 40 to 49 yards made by the player in season")]
        [DataMember(Name = "FieldGoalsMade40to49", Order = 128)]
        public decimal? FieldGoalsMade40to49 { get; set; }

        /// <summary>
        /// Total field goals of 50+ yards made by the player in season
        /// </summary>
        [Description("Total field goals of 50+ yards made by the player in season")]
        [DataMember(Name = "FieldGoalsMade50Plus", Order = 129)]
        public decimal? FieldGoalsMade50Plus { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system by the player in the season")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 130)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system by the player in the season")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 131)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The average draft position of the player in re-draft leagues
        /// </summary>
        [Description("The average draft position of the player in re-draft leagues")]
        [DataMember(Name = "AverageDraftPosition", Order = 132)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The average draft position of this player in Points Per Reception (PPR) leagues.
        /// </summary>
        [Description("The average draft position of this player in Points Per Reception (PPR) leagues.")]
        [DataMember(Name = "AverageDraftPositionPPR", Order = 133)]
        public decimal? AverageDraftPositionPPR { get; set; }

        /// <summary>
        /// The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL
        /// </summary>
        [Description("The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL")]
        [DataMember(Name = "TeamID", Order = 134)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 135)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Fantasy points based on FantasyDraft's scoring system by the player in the season
        /// </summary>
        [Description("Fantasy points based on FantasyDraft's scoring system by the player in the season")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 136)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// The details of the scoring plays this player recorded in the season
        /// </summary>
        [Description("The details of the scoring plays this player recorded in the season")]
        [DataMember(Name = "ScoringDetails", Order = 20137)]
        public ScoringDetail[] ScoringDetails { get; set; }

        /// <summary>
        /// The average draft position of this rookie in Points Per Reception (PPR) leagues.
        /// </summary>
        [Description("The average draft position of this rookie in Points Per Reception (PPR) leagues.")]
        [DataMember(Name = "AverageDraftPositionRookie", Order = 138)]
        public decimal? AverageDraftPositionRookie { get; set; }

        /// <summary>
        /// The average draft position of this player in dynasty drafts leagues
        /// </summary>
        [Description("The average draft position of this player in dynasty drafts leagues")]
        [DataMember(Name = "AverageDraftPositionDynasty", Order = 139)]
        public decimal? AverageDraftPositionDynasty { get; set; }

        /// <summary>
        /// The average draft position of this player in 2 Quarterback leagues
        /// </summary>
        [Description("The average draft position of this player in 2 Quarterback leagues")]
        [DataMember(Name = "AverageDraftPosition2QB", Order = 140)]
        public decimal? AverageDraftPosition2QB { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OffensiveFumbleRecoveryTouchdowns", Order = 141)]
        public int? OffensiveFumbleRecoveryTouchdowns { get; set; }

    }
}

