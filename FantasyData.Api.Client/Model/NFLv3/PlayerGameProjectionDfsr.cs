using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerGameProjectionDfsr")]
    [Serializable]
    public partial class PlayerGameProjectionDfsr
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam.. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam.. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this player corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The date and time the game is scheduled to start
        /// </summary>
        [Description("The date and time the game is scheduled to start")]
        [DataMember(Name = "GameDate", Order = 5)]
        public DateTime GameDate { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 6)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: if this player is a free agent; this field is NULL
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: if this player is a free agent; this field is NULL")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 8)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 9)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 10)]
        public int Number { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 11)]
        public string Name { get; set; }

        /// <summary>
        /// The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR
        /// </summary>
        [Description("The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR")]
        [DataMember(Name = "Position", Order = 12)]
        public string Position { get; set; }

        /// <summary>
        /// The category of the player's position (OFF; DEF; ST)
        /// </summary>
        [Description("The category of the player's position (OFF; DEF; ST)")]
        [DataMember(Name = "PositionCategory", Order = 13)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Whether or not the player was active for the game
        /// </summary>
        [Description("Whether or not the player was active for the game")]
        [DataMember(Name = "Activated", Order = 14)]
        public int Activated { get; set; }

        /// <summary>
        /// Whether the player played at least one snap in the game Note: Will return "1" if player played at least one snap and "0" if they did not
        /// </summary>
        [Description("Whether the player played at least one snap in the game Note: Will return \"1\" if player played at least one snap and \"0\" if they did not")]
        [DataMember(Name = "Played", Order = 15)]
        public int Played { get; set; }

        /// <summary>
        /// Whether the player started the game (on offensive or defense). Note: Started = 1 / Did Not Start = 0
        /// </summary>
        [Description("Whether the player started the game (on offensive or defense). Note: Started = 1 / Did Not Start = 0")]
        [DataMember(Name = "Started", Order = 16)]
        public int Started { get; set; }

        /// <summary>
        /// Total passes thrown by the player in the game
        /// </summary>
        [Description("Total passes thrown by the player in the game")]
        [DataMember(Name = "PassingAttempts", Order = 17)]
        public decimal PassingAttempts { get; set; }

        /// <summary>
        /// Total passes completed by the player in the game
        /// </summary>
        [Description("Total passes completed by the player in the game")]
        [DataMember(Name = "PassingCompletions", Order = 18)]
        public decimal PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the player in the game
        /// </summary>
        [Description("Total passing yards by the player in the game")]
        [DataMember(Name = "PassingYards", Order = 19)]
        public decimal PassingYards { get; set; }

        /// <summary>
        /// The percentage of passes completed by the player in the game
        /// </summary>
        [Description("The percentage of passes completed by the player in the game")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 20)]
        public decimal PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Total average passing yards per attempt by the player in the game
        /// </summary>
        [Description("Total average passing yards per attempt by the player in the game")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 21)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total average passing yards per completion by the player in the game
        /// </summary>
        [Description("Total average passing yards per completion by the player in the game")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 22)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total passing touchdowns by the player in the game
        /// </summary>
        [Description("Total passing touchdowns by the player in the game")]
        [DataMember(Name = "PassingTouchdowns", Order = 23)]
        public decimal PassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the player in the game
        /// </summary>
        [Description("Total interceptions thrown by the player in the game")]
        [DataMember(Name = "PassingInterceptions", Order = 24)]
        public decimal PassingInterceptions { get; set; }

        /// <summary>
        /// The passer rating of the player in the game
        /// </summary>
        [Description("The passer rating of the player in the game")]
        [DataMember(Name = "PassingRating", Order = 25)]
        public decimal PassingRating { get; set; }

        /// <summary>
        /// Total yards of longest completion by the player in the game
        /// </summary>
        [Description("Total yards of longest completion by the player in the game")]
        [DataMember(Name = "PassingLong", Order = 26)]
        public decimal PassingLong { get; set; }

        /// <summary>
        /// The total number of times the player was sacked in the game
        /// </summary>
        [Description("The total number of times the player was sacked in the game")]
        [DataMember(Name = "PassingSacks", Order = 27)]
        public decimal PassingSacks { get; set; }

        /// <summary>
        /// Total yards lost by the player in the game as a result of being sacked
        /// </summary>
        [Description("Total yards lost by the player in the game as a result of being sacked")]
        [DataMember(Name = "PassingSackYards", Order = 28)]
        public decimal PassingSackYards { get; set; }

        /// <summary>
        /// Total rushing attempts by the player in the game
        /// </summary>
        [Description("Total rushing attempts by the player in the game")]
        [DataMember(Name = "RushingAttempts", Order = 29)]
        public decimal RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the player in the game
        /// </summary>
        [Description("Total rushing yards by the player in the game")]
        [DataMember(Name = "RushingYards", Order = 30)]
        public decimal RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt by the player in the game
        /// </summary>
        [Description("Total rushing yards per attempt by the player in the game")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 31)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the player in the game
        /// </summary>
        [Description("Total rushing touchdowns by the player in the game")]
        [DataMember(Name = "RushingTouchdowns", Order = 32)]
        public decimal RushingTouchdowns { get; set; }

        /// <summary>
        /// The longest rush by the player in the game
        /// </summary>
        [Description("The longest rush by the player in the game")]
        [DataMember(Name = "RushingLong", Order = 33)]
        public decimal RushingLong { get; set; }

        /// <summary>
        /// Total receiving targets by the player in the game
        /// </summary>
        [Description("Total receiving targets by the player in the game")]
        [DataMember(Name = "ReceivingTargets", Order = 34)]
        public decimal? ReceivingTargets { get; set; }

        /// <summary>
        /// Total receptions by the player in the game
        /// </summary>
        [Description("Total receptions by the player in the game")]
        [DataMember(Name = "Receptions", Order = 35)]
        public decimal Receptions { get; set; }

        /// <summary>
        /// Total receiving yards by the player in the game
        /// </summary>
        [Description("Total receiving yards by the player in the game")]
        [DataMember(Name = "ReceivingYards", Order = 36)]
        public decimal ReceivingYards { get; set; }

        /// <summary>
        /// Average receiving yards per reception by the player in the game
        /// </summary>
        [Description("Average receiving yards per reception by the player in the game")]
        [DataMember(Name = "ReceivingYardsPerReception", Order = 37)]
        public decimal ReceivingYardsPerReception { get; set; }

        /// <summary>
        /// Total receiving touchdowns by the player in the game
        /// </summary>
        [Description("Total receiving touchdowns by the player in the game")]
        [DataMember(Name = "ReceivingTouchdowns", Order = 38)]
        public decimal ReceivingTouchdowns { get; set; }

        /// <summary>
        /// The longest reception by the player in the game
        /// </summary>
        [Description("The longest reception by the player in the game")]
        [DataMember(Name = "ReceivingLong", Order = 39)]
        public decimal ReceivingLong { get; set; }

        /// <summary>
        /// Total fumbles by the player in the game
        /// </summary>
        [Description("Total fumbles by the player in the game")]
        [DataMember(Name = "Fumbles", Order = 40)]
        public decimal Fumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the player in the game
        /// </summary>
        [Description("Total fumbles lost by the player in the game")]
        [DataMember(Name = "FumblesLost", Order = 41)]
        public decimal? FumblesLost { get; set; }

        /// <summary>
        /// Total punt returns by the player in the game
        /// </summary>
        [Description("Total punt returns by the player in the game")]
        [DataMember(Name = "PuntReturns", Order = 42)]
        public decimal PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the player in the game
        /// </summary>
        [Description("Total punt return yards by the player in the game")]
        [DataMember(Name = "PuntReturnYards", Order = 43)]
        public decimal PuntReturnYards { get; set; }

        /// <summary>
        /// Total average yards gained per punt return by the player in the game
        /// </summary>
        [Description("Total average yards gained per punt return by the player in the game")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 44)]
        public decimal PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the player in the game
        /// </summary>
        [Description("Total punt return touchdowns by the player in the game")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 45)]
        public decimal PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the player in the game
        /// </summary>
        [Description("The longest punt return by the player in the game")]
        [DataMember(Name = "PuntReturnLong", Order = 46)]
        public decimal PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff returns by the player in the game
        /// </summary>
        [Description("Total kickoff returns by the player in the game")]
        [DataMember(Name = "KickReturns", Order = 47)]
        public decimal KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the player in the game
        /// </summary>
        [Description("Total kickoff return yards by the player in the game")]
        [DataMember(Name = "KickReturnYards", Order = 48)]
        public decimal KickReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per kick return by the player in the game
        /// </summary>
        [Description("Average yards gained per kick return by the player in the game")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 49)]
        public decimal KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the player in the game
        /// </summary>
        [Description("Total kickoff return touchdowns by the player in the game")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 50)]
        public decimal KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the player in the game
        /// </summary>
        [Description("Longest kick return by the player in the game")]
        [DataMember(Name = "KickReturnLong", Order = 51)]
        public decimal KickReturnLong { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the player in the game
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the player in the game")]
        [DataMember(Name = "SoloTackles", Order = 52)]
        public decimal SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the player in the game
        /// </summary>
        [Description("Total defensive assisted tackles by the player in the game")]
        [DataMember(Name = "AssistedTackles", Order = 53)]
        public decimal AssistedTackles { get; set; }

        /// <summary>
        /// Total tackles for loss by the player in the game. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the player in the game. Note: these are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 54)]
        public decimal? TacklesForLoss { get; set; }

        /// <summary>
        /// Total defensive sacks by the player in the game
        /// </summary>
        [Description("Total defensive sacks by the player in the game")]
        [DataMember(Name = "Sacks", Order = 55)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Total defensive sacks yards by the player in the game
        /// </summary>
        [Description("Total defensive sacks yards by the player in the game")]
        [DataMember(Name = "SackYards", Order = 56)]
        public decimal SackYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the player in the game. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the player in the game. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 57)]
        public decimal? QuarterbackHits { get; set; }

        /// <summary>
        /// Total passes defended by the player in the game
        /// </summary>
        [Description("Total passes defended by the player in the game")]
        [DataMember(Name = "PassesDefended", Order = 58)]
        public decimal PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the player in the game
        /// </summary>
        [Description("Total fumbles forced on defense by the player in the game")]
        [DataMember(Name = "FumblesForced", Order = 59)]
        public decimal FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the player in the game
        /// </summary>
        [Description("Total defensive fumble recoveries by the player in the game")]
        [DataMember(Name = "FumblesRecovered", Order = 60)]
        public decimal FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the player in the game
        /// </summary>
        [Description("Total fumble return yards by the player in the game")]
        [DataMember(Name = "FumbleReturnYards", Order = 61)]
        public decimal FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the player in the game
        /// </summary>
        [Description("Total fumble return touchdowns by the player in the game")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 62)]
        public decimal FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interceptions by the player in the game
        /// </summary>
        [Description("Total defensive interceptions by the player in the game")]
        [DataMember(Name = "Interceptions", Order = 63)]
        public decimal Interceptions { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the player in the game
        /// </summary>
        [Description("Total defensive interception return yards by the player in the game")]
        [DataMember(Name = "InterceptionReturnYards", Order = 64)]
        public decimal InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the player in the game
        /// </summary>
        [Description("Total defensive interception return touchdowns by the player in the game")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 65)]
        public decimal InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by the player in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by the player in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 66)]
        public decimal BlockedKicks { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsSoloTackles", Order = 67)]
        public decimal SpecialTeamsSoloTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsAssistedTackles", Order = 68)]
        public decimal SpecialTeamsAssistedTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscSoloTackles", Order = 69)]
        public decimal MiscSoloTackles { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscAssistedTackles", Order = 70)]
        public decimal MiscAssistedTackles { get; set; }

        /// <summary>
        /// Total number of punts by the player in the game
        /// </summary>
        [Description("Total number of punts by the player in the game")]
        [DataMember(Name = "Punts", Order = 71)]
        public decimal Punts { get; set; }

        /// <summary>
        /// Total punt yards by the player in the game
        /// </summary>
        [Description("Total punt yards by the player in the game")]
        [DataMember(Name = "PuntYards", Order = 72)]
        public decimal PuntYards { get; set; }

        /// <summary>
        /// The average number of yards per punt by the player in the game
        /// </summary>
        [Description("The average number of yards per punt by the player in the game")]
        [DataMember(Name = "PuntAverage", Order = 73)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Total field goals attempted by the player in the game
        /// </summary>
        [Description("Total field goals attempted by the player in the game")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 74)]
        public decimal FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goals made by the player in game
        /// </summary>
        [Description("Total field goals made by the player in game")]
        [DataMember(Name = "FieldGoalsMade", Order = 75)]
        public decimal FieldGoalsMade { get; set; }

        /// <summary>
        /// Longest field goal made by the player in the game
        /// </summary>
        [Description("Longest field goal made by the player in the game")]
        [DataMember(Name = "FieldGoalsLongestMade", Order = 76)]
        public decimal FieldGoalsLongestMade { get; set; }

        /// <summary>
        /// Total extra points made by the player in the game
        /// </summary>
        [Description("Total extra points made by the player in the game")]
        [DataMember(Name = "ExtraPointsMade", Order = 77)]
        public decimal ExtraPointsMade { get; set; }

        /// <summary>
        /// Total successful two point conversion passes by the player in the game
        /// </summary>
        [Description("Total successful two point conversion passes by the player in the game")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 78)]
        public decimal TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Total successful two point conversion rushes by the player in the game
        /// </summary>
        [Description("Total successful two point conversion rushes by the player in the game")]
        [DataMember(Name = "TwoPointConversionRuns", Order = 79)]
        public decimal TwoPointConversionRuns { get; set; }

        /// <summary>
        /// Total successful two point conversion receptions by the player in the game
        /// </summary>
        [Description("Total successful two point conversion receptions by the player in the game")]
        [DataMember(Name = "TwoPointConversionReceptions", Order = 80)]
        public decimal TwoPointConversionReceptions { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system by the player in the game")]
        [DataMember(Name = "FantasyPoints", Order = 81)]
        public decimal FantasyPoints { get; set; }

        /// <summary>
        /// This field is expected to be NULL
        /// </summary>
        [Description("This field is expected to be NULL")]
        [DataMember(Name = "FantasyPointsPPR", Order = 82)]
        public decimal FantasyPointsPPR { get; set; }

        /// <summary>
        /// Total percentage of receiving targets that were receptions by the player in the game
        /// </summary>
        [Description("Total percentage of receiving targets that were receptions by the player in the game")]
        [DataMember(Name = "ReceptionPercentage", Order = 83)]
        public decimal ReceptionPercentage { get; set; }

        /// <summary>
        /// Average receiving yards per target by the player in the game
        /// </summary>
        [Description("Average receiving yards per target by the player in the game")]
        [DataMember(Name = "ReceivingYardsPerTarget", Order = 84)]
        public decimal ReceivingYardsPerTarget { get; set; }

        /// <summary>
        /// Total tackles (solo & assisted) by the player in the game
        /// </summary>
        [Description("Total tackles (solo & assisted) by the player in the game")]
        [DataMember(Name = "Tackles", Order = 85)]
        public decimal Tackles { get; set; }

        /// <summary>
        /// Total offensive touchdowns scored by the player in the game
        /// </summary>
        [Description("Total offensive touchdowns scored by the player in the game")]
        [DataMember(Name = "OffensiveTouchdowns", Order = 86)]
        public decimal OffensiveTouchdowns { get; set; }

        /// <summary>
        /// Total defensive touchdowns scored by the player in the game
        /// </summary>
        [Description("Total defensive touchdowns scored by the player in the game")]
        [DataMember(Name = "DefensiveTouchdowns", Order = 87)]
        public decimal DefensiveTouchdowns { get; set; }

        /// <summary>
        /// Total special teams touchdowns scored by the player in the game
        /// </summary>
        [Description("Total special teams touchdowns scored by the player in the game")]
        [DataMember(Name = "SpecialTeamsTouchdowns", Order = 88)]
        public decimal SpecialTeamsTouchdowns { get; set; }

        /// <summary>
        /// Total touchdowns scored by the player in the game (excludes passing touchdowns)
        /// </summary>
        [Description("Total touchdowns scored by the player in the game (excludes passing touchdowns)")]
        [DataMember(Name = "Touchdowns", Order = 89)]
        public decimal Touchdowns { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL")]
        [DataMember(Name = "FantasyPosition", Order = 90)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Total field goal attempts made by the player in the game
        /// </summary>
        [Description("Total field goal attempts made by the player in the game")]
        [DataMember(Name = "FieldGoalPercentage", Order = 91)]
        public decimal FieldGoalPercentage { get; set; }

        /// <summary>
        /// Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.
        /// </summary>
        [Description("Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.")]
        [DataMember(Name = "PlayerGameID", Order = 92)]
        public int PlayerGameID { get; set; }

        /// <summary>
        /// Total own fumble recoveries by the player in the game. Note: this fumble doesn't result in a turnover - the fumbling team recovers the fumble
        /// </summary>
        [Description("Total own fumble recoveries by the player in the game. Note: this fumble doesn't result in a turnover - the fumbling team recovers the fumble")]
        [DataMember(Name = "FumblesOwnRecoveries", Order = 93)]
        public decimal? FumblesOwnRecoveries { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "FumblesOutOfBounds", Order = 94)]
        public decimal? FumblesOutOfBounds { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "KickReturnFairCatches", Order = 95)]
        public decimal? KickReturnFairCatches { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "PuntReturnFairCatches", Order = 96)]
        public decimal? PuntReturnFairCatches { get; set; }

        /// <summary>
        /// Total punts that resulted in touchbacks by the player in the game
        /// </summary>
        [Description("Total punts that resulted in touchbacks by the player in the game")]
        [DataMember(Name = "PuntTouchbacks", Order = 97)]
        public decimal? PuntTouchbacks { get; set; }

        /// <summary>
        /// Total punts downed inside the 20 yard line by the player in the game
        /// </summary>
        [Description("Total punts downed inside the 20 yard line by the player in the game")]
        [DataMember(Name = "PuntInside20", Order = 98)]
        public decimal? PuntInside20 { get; set; }

        /// <summary>
        /// The average net yards per punt by the player in the game
        /// </summary>
        [Description("The average net yards per punt by the player in the game")]
        [DataMember(Name = "PuntNetAverage", Order = 99)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kicks attempted by the player in the game
        /// </summary>
        [Description("Total extra point kicks attempted by the player in the game")]
        [DataMember(Name = "ExtraPointsAttempted", Order = 100)]
        public decimal? ExtraPointsAttempted { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the player in the game
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the player in the game")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 101)]
        public decimal? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the player in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the player in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 102)]
        public decimal? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the player in the game
        /// </summary>
        [Description("Total defensive safeties scored by the player in the game")]
        [DataMember(Name = "Safeties", Order = 103)]
        public decimal? Safeties { get; set; }

        /// <summary>
        /// Total field goals by the player that were blocked in the game
        /// </summary>
        [Description("Total field goals by the player that were blocked in the game")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 104)]
        public decimal? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punts by the player that were blocked in the game
        /// </summary>
        [Description("Total punts by the player that were blocked in the game")]
        [DataMember(Name = "PuntsHadBlocked", Order = 105)]
        public decimal? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the player that were blocked in the game
        /// </summary>
        [Description("Total extra point kick attempts by the player that were blocked in the game")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 106)]
        public decimal? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// The longest punt by the player in the game
        /// </summary>
        [Description("The longest punt by the player in the game")]
        [DataMember(Name = "PuntLong", Order = 107)]
        public decimal? PuntLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the player in the game
        /// </summary>
        [Description("Total blocked kick recovery return yards for the player in the game")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 108)]
        public decimal? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total field goal return yards by the player in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the player in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 109)]
        public decimal? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// The net yards of the punts by the player in the game
        /// </summary>
        [Description("The net yards of the punts by the player in the game")]
        [DataMember(Name = "PuntNetYards", Order = 110)]
        public decimal? PuntNetYards { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsFumblesForced", Order = 111)]
        public decimal? SpecialTeamsFumblesForced { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SpecialTeamsFumblesRecovered", Order = 112)]
        public decimal? SpecialTeamsFumblesRecovered { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscFumblesForced", Order = 113)]
        public decimal? MiscFumblesForced { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "MiscFumblesRecovered", Order = 114)]
        public decimal? MiscFumblesRecovered { get; set; }

        /// <summary>
        /// The first initial and last name of the player (J. Doe)
        /// </summary>
        [Description("The first initial and last name of the player (J. Doe)")]
        [DataMember(Name = "ShortName", Order = 115)]
        public string ShortName { get; set; }

        /// <summary>
        /// The playing surface of the stadium
        /// </summary>
        [Description("The playing surface of the stadium")]
        [DataMember(Name = "PlayingSurface", Order = 116)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 117)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "SafetiesAllowed", Order = 118)]
        public decimal? SafetiesAllowed { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 119)]
        public string Stadium { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 120)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 121)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
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
        /// The player's salary as calculated by SportsDataIO (formerly known as FantasyData).  Based on the same salary cap as DraftKings contests ($50,000).
        /// </summary>
        [Description("The player's salary as calculated by SportsDataIO (formerly known as FantasyData).  Based on the same salary cap as DraftKings contests ($50,000).")]
        [DataMember(Name = "FantasyDataSalary", Order = 125)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// Total snaps this player played on offense in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on offense in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "OffensiveSnapsPlayed", Order = 126)]
        public int? OffensiveSnapsPlayed { get; set; }

        /// <summary>
        /// Total snaps this player played on defense in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on defense in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "DefensiveSnapsPlayed", Order = 127)]
        public int? DefensiveSnapsPlayed { get; set; }

        /// <summary>
        /// Total snaps this player played on special teams in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total snaps this player played on special teams in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "SpecialTeamsSnapsPlayed", Order = 128)]
        public int? SpecialTeamsSnapsPlayed { get; set; }

        /// <summary>
        /// Total offensive snaps this player's team played in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total offensive snaps this player's team played in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "OffensiveTeamSnaps", Order = 129)]
        public int? OffensiveTeamSnaps { get; set; }

        /// <summary>
        /// Total defensive snaps this player's team played in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total defensive snaps this player's team played in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "DefensiveTeamSnaps", Order = 130)]
        public int? DefensiveTeamSnaps { get; set; }

        /// <summary>
        /// Total special teams snaps this player's team played in the game. Note: Snap counts are available the morning after the game.
        /// </summary>
        [Description("Total special teams snaps this player's team played in the game. Note: Snap counts are available the morning after the game.")]
        [DataMember(Name = "SpecialTeamsTeamSnaps", Order = 131)]
        public int? SpecialTeamsTeamSnaps { get; set; }

        /// <summary>
        /// The player's salary for Victiv daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Victiv daily fantasy contests.")]
        [DataMember(Name = "VictivSalary", Order = 132)]
        public int? VictivSalary { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the player in the game
        /// </summary>
        [Description("Total successful two point conversion returns by the player in the game")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 133)]
        public decimal? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Fantasy points based on FanDuel's scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points based on FanDuel's scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 134)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total field goals of 0 to 19 yards made by the player in game
        /// </summary>
        [Description("Total field goals of 0 to 19 yards made by the player in game")]
        [DataMember(Name = "FieldGoalsMade0to19", Order = 135)]
        public decimal? FieldGoalsMade0to19 { get; set; }

        /// <summary>
        /// Total field goals of 20 to 29 yards made by the player in game
        /// </summary>
        [Description("Total field goals of 20 to 29 yards made by the player in game")]
        [DataMember(Name = "FieldGoalsMade20to29", Order = 136)]
        public decimal? FieldGoalsMade20to29 { get; set; }

        /// <summary>
        /// Total field goals of 30 to 39 yards made by the player in game
        /// </summary>
        [Description("Total field goals of 30 to 39 yards made by the player in game")]
        [DataMember(Name = "FieldGoalsMade30to39", Order = 137)]
        public decimal? FieldGoalsMade30to39 { get; set; }

        /// <summary>
        /// Total field goals of 40 to 49 yards made by the player in game
        /// </summary>
        [Description("Total field goals of 40 to 49 yards made by the player in game")]
        [DataMember(Name = "FieldGoalsMade40to49", Order = 138)]
        public decimal? FieldGoalsMade40to49 { get; set; }

        /// <summary>
        /// Total field goals of 50+ yards made by the player in game
        /// </summary>
        [Description("Total field goals of 50+ yards made by the player in game")]
        [DataMember(Name = "FieldGoalsMade50Plus", Order = 139)]
        public decimal? FieldGoalsMade50Plus { get; set; }

        /// <summary>
        /// Fantasy points based on DraftKings' scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points based on DraftKings' scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 140)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests")]
        [DataMember(Name = "YahooSalary", Order = 141)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// Fantasy points based on Yahoo's daily fantasy scoring system by the player in the game
        /// </summary>
        [Description("Fantasy points based on Yahoo's daily fantasy scoring system by the player in the game")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 142)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// The player's current injury status; in the form of likelihood that player plays (Probable; Questionable; Doubtful; Out)
        /// </summary>
        [Description("The player's current injury status; in the form of likelihood that player plays (Probable; Questionable; Doubtful; Out)")]
        [DataMember(Name = "InjuryStatus", Order = 143)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured for the player (Knee; Groin; Calf; Hamstring; etc.)
        /// </summary>
        [Description("The body part that is injured for the player (Knee; Groin; Calf; Hamstring; etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 144)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the player's injury started or was first discovered
        /// </summary>
        [Description("The day that the player's injury started or was first discovered")]
        [DataMember(Name = "InjuryStartDate", Order = 145)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// A brief description of the player's injury and expected availability
        /// </summary>
        [Description("A brief description of the player's injury and expected availability")]
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
        /// The player's eligible position in Yahoo's daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform")]
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
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "InjuryPractice", Order = 152)]
        public string InjuryPractice { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "InjuryPracticeDescription", Order = 153)]
        public string InjuryPracticeDescription { get; set; }

        /// <summary>
        /// Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players.  Note: This is only updated for offensive skill position players (QB; RB; WR; TE)
        /// </summary>
        [Description("Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players.  Note: This is only updated for offensive skill position players (QB; RB; WR; TE)")]
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
        /// The unique ID of the team that the player is on. Note: if the player is a free agent; this field is NULL
        /// </summary>
        [Description("The unique ID of the team that the player is on. Note: if the player is a free agent; this field is NULL")]
        [DataMember(Name = "TeamID", Order = 157)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of this opponent team
        /// </summary>
        [Description("The unique ID of this opponent team")]
        [DataMember(Name = "OpponentID", Order = 158)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 159)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 160)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 161)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 162)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 163)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 164)]
        public int ScoreID { get; set; }

        /// <summary>
        /// This field is no longer in use and will return null.
        /// </summary>
        [Description("This field is no longer in use and will return null.")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 165)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// The details of the scoring plays this player recorded in the game
        /// </summary>
        [Description("The details of the scoring plays this player recorded in the game")]
        [DataMember(Name = "ScoringDetails", Order = 20166)]
        public ScoringDetail[] ScoringDetails { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OffensiveFumbleRecoveryTouchdowns", Order = 167)]
        public decimal? OffensiveFumbleRecoveryTouchdowns { get; set; }

        /// <summary>
        /// Whether snap count fields are confirmed (true/false). Note: This takes place the morning after the game.
        /// </summary>
        [Description("Whether snap count fields are confirmed (true/false). Note: This takes place the morning after the game.")]
        [DataMember(Name = "SnapCountsConfirmed", Order = 168)]
        public bool? SnapCountsConfirmed { get; set; }

        /// <summary>
        /// Time of last sync (in US Eastern time). Note: this does not indicate that stats changed.
        /// </summary>
        [Description("Time of last sync (in US Eastern time). Note: this does not indicate that stats changed.")]
        [DataMember(Name = "Updated", Order = 169)]
        public DateTime? Updated { get; set; }

    }
}

