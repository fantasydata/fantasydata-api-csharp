using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="AdvancedPlayer")]
    [Serializable]
    public partial class AdvancedPlayer
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
        /// Body Mass Index - a measure of thinness. Higher value means stockier, wider build.
        /// </summary>
        [Description("Body Mass Index - a measure of thinness. Higher value means stockier, wider build.")]
        [DataMember(Name = "BMI", Order = 8)]
        public decimal? BMI { get; set; }

        /// <summary>
        /// Player's BMI ranked alongside other players against an ideal value for their position
        /// </summary>
        [Description("Player's BMI ranked alongside other players against an ideal value for their position")]
        [DataMember(Name = "BMIRank", Order = 9)]
        public int? BMIRank { get; set; }

        /// <summary>
        /// Player's hand size in inches. Important Quarterback value, especially in cold weather play.
        /// </summary>
        [Description("Player's hand size in inches. Important Quarterback value, especially in cold weather play.")]
        [DataMember(Name = "HandSize", Order = 10)]
        public decimal? HandSize { get; set; }

        /// <summary>
        /// Player's hand size ranked alongside other players against an ideal value for their position
        /// </summary>
        [Description("Player's hand size ranked alongside other players against an ideal value for their position")]
        [DataMember(Name = "HandSizeRank", Order = 11)]
        public int? HandSizeRank { get; set; }

        /// <summary>
        /// Player's arm length in inches.
        /// </summary>
        [Description("Player's arm length in inches.")]
        [DataMember(Name = "ArmLength", Order = 12)]
        public decimal? ArmLength { get; set; }

        /// <summary>
        /// Player's arm length ranked alongside other players against an ideal value for their position	
        /// </summary>
        [Description("Player's arm length ranked alongside other players against an ideal value for their position	")]
        [DataMember(Name = "ArmLengthRank", Order = 13)]
        public int? ArmLengthRank { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        [Description("Not currently used")]
        [DataMember(Name = "QualityScore", Order = 14)]
        public decimal? QualityScore { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        [Description("Not currently used")]
        [DataMember(Name = "QualityScoreRank", Order = 15)]
        public int? QualityScoreRank { get; set; }

        /// <summary>
        /// 40-yard dash time in seconds.
        /// </summary>
        [Description("40-yard dash time in seconds.")]
        [DataMember(Name = "FortyYardDash", Order = 16)]
        public decimal? FortyYardDash { get; set; }

        /// <summary>
        /// 40-yard dash time ranked against other players.
        /// </summary>
        [Description("40-yard dash time ranked against other players.")]
        [DataMember(Name = "FortyYardDashRank", Order = 17)]
        public int? FortyYardDashRank { get; set; }

        /// <summary>
        /// Time taken to complete the three-cone drill short movement exercise.
        /// </summary>
        [Description("Time taken to complete the three-cone drill short movement exercise.")]
        [DataMember(Name = "ThreeConeDrill", Order = 18)]
        public decimal? ThreeConeDrill { get; set; }

        /// <summary>
        /// Three-cone drill time relative to other players.
        /// </summary>
        [Description("Three-cone drill time relative to other players.")]
        [DataMember(Name = "ThreeConeDrillRank", Order = 19)]
        public int? ThreeConeDrillRank { get; set; }

        /// <summary>
        /// Time taken to complete the 20-yard short shuttle in seconds.
        /// </summary>
        [Description("Time taken to complete the 20-yard short shuttle in seconds.")]
        [DataMember(Name = "TwentyYardShuttle", Order = 20)]
        public decimal? TwentyYardShuttle { get; set; }

        /// <summary>
        /// 20-yard short shuttle time relative to other players.
        /// </summary>
        [Description("20-yard short shuttle time relative to other players.")]
        [DataMember(Name = "TwentyYardShuttleRank", Order = 21)]
        public int? TwentyYardShuttleRank { get; set; }

        /// <summary>
        /// A measure of player's agility, calculated by sum of three-cone drill time and 20-yard short shuttle time.
        /// </summary>
        [Description("A measure of player's agility, calculated by sum of three-cone drill time and 20-yard short shuttle time.")]
        [DataMember(Name = "AgilityScore", Order = 22)]
        public decimal? AgilityScore { get; set; }

        /// <summary>
        /// Player's agility ranking relative to other players.
        /// </summary>
        [Description("Player's agility ranking relative to other players.")]
        [DataMember(Name = "AgilityScoreRank", Order = 23)]
        public int? AgilityScoreRank { get; set; }

        /// <summary>
        /// A player's vertical jump height, in inches.
        /// </summary>
        [Description("A player's vertical jump height, in inches.")]
        [DataMember(Name = "VerticalJump", Order = 24)]
        public decimal? VerticalJump { get; set; }

        /// <summary>
        /// Player's vertical jump performance relative to other players.
        /// </summary>
        [Description("Player's vertical jump performance relative to other players.")]
        [DataMember(Name = "VerticalJumpRank", Order = 25)]
        public int? VerticalJumpRank { get; set; }

        /// <summary>
        /// A player's long jump length, in inches.
        /// </summary>
        [Description("A player's long jump length, in inches.")]
        [DataMember(Name = "BroadJump", Order = 26)]
        public decimal? BroadJump { get; set; }

        /// <summary>
        /// Player's horizontal jump relative to other players.
        /// </summary>
        [Description("Player's horizontal jump relative to other players.")]
        [DataMember(Name = "BroadJumpRank", Order = 27)]
        public int? BroadJumpRank { get; set; }

        /// <summary>
        /// A measure of explosive, stop-start action. The sum of vertical jump height and broad jump distance.
        /// </summary>
        [Description("A measure of explosive, stop-start action. The sum of vertical jump height and broad jump distance.")]
        [DataMember(Name = "BurstScore", Order = 28)]
        public decimal? BurstScore { get; set; }

        /// <summary>
        /// Player's burst explosion capabilities relative to other players.
        /// </summary>
        [Description("Player's burst explosion capabilities relative to other players.")]
        [DataMember(Name = "BurstScoreRank", Order = 29)]
        public int? BurstScoreRank { get; set; }

        /// <summary>
        /// An approximation of the Nike SPARQ Rating. Comprises Speed, Power, Agility, Reaction and Quickness. The measurements used are: 40-yard dash, vertical jump, 20-yard short shuttle, and power ball throw.
        /// </summary>
        [Description("An approximation of the Nike SPARQ Rating. Comprises Speed, Power, Agility, Reaction and Quickness. The measurements used are: 40-yard dash, vertical jump, 20-yard short shuttle, and power ball throw.")]
        [DataMember(Name = "SPARQx", Order = 30)]
        public decimal? SPARQx { get; set; }

        /// <summary>
        /// A player's SPARQx ranking relative to other players.
        /// </summary>
        [Description("A player's SPARQx ranking relative to other players.")]
        [DataMember(Name = "SPARQxRank", Order = 31)]
        public int? SPARQxRank { get; set; }

        /// <summary>
        /// An aggregate of 40-yard dash, Burst Score, and Agility Score, normalized by size (so larger players with higher movement scores will get a bonus.)
        /// </summary>
        [Description("An aggregate of 40-yard dash, Burst Score, and Agility Score, normalized by size (so larger players with higher movement scores will get a bonus.)")]
        [DataMember(Name = "AthleticismScore", Order = 32)]
        public decimal? AthleticismScore { get; set; }

        /// <summary>
        /// A player's Athleticism Score relative to those of other players.
        /// </summary>
        [Description("A player's Athleticism Score relative to those of other players.")]
        [DataMember(Name = "AthleticismScoreRank", Order = 33)]
        public int? AthleticismScoreRank { get; set; }

        /// <summary>
        /// A formula to assign a speed rating to a player, giving a premium to heavier players' 40-yard dash times: (weight*200) / (40-time^4)
        /// </summary>
        [Description("A formula to assign a speed rating to a player, giving a premium to heavier players' 40-yard dash times: (weight*200) / (40-time^4)")]
        [DataMember(Name = "SpeedScore", Order = 34)]
        public decimal? SpeedScore { get; set; }

        /// <summary>
        /// A player's Speed Score relative to those of other players.
        /// </summary>
        [Description("A player's Speed Score relative to those of other players.")]
        [DataMember(Name = "SpeedScoreRank", Order = 35)]
        public int? SpeedScoreRank { get; set; }

        /// <summary>
        /// A player's throw speed in miles per hour.
        /// </summary>
        [Description("A player's throw speed in miles per hour.")]
        [DataMember(Name = "ThrowVelocity", Order = 36)]
        public decimal? ThrowVelocity { get; set; }

        /// <summary>
        /// A player's throw speed relative to those of other players.
        /// </summary>
        [Description("A player's throw speed relative to those of other players.")]
        [DataMember(Name = "ThrowVelocityRank", Order = 37)]
        public int? ThrowVelocityRank { get; set; }

        /// <summary>
        /// The Wonderlic is a test and resulting score used to gauge intelligence via problem-solving and learning puzzles. Scored from 0 to 50.
        /// </summary>
        [Description("The Wonderlic is a test and resulting score used to gauge intelligence via problem-solving and learning puzzles. Scored from 0 to 50.")]
        [DataMember(Name = "WonderlicScore", Order = 38)]
        public decimal? WonderlicScore { get; set; }

        /// <summary>
        /// A player's Wonderlic outcome relative to other players.
        /// </summary>
        [Description("A player's Wonderlic outcome relative to other players.")]
        [DataMember(Name = "WonderlicScoreRank", Order = 39)]
        public int? WonderlicScoreRank { get; set; }

        /// <summary>
        /// Also known as HaSS. A player's speed score after being normalized for height, specifically used for Wide Receivers and Tight Ends (WRs and TEs.) Taller players have a larger catch window so their scores are normalized downward.
        /// </summary>
        [Description("Also known as HaSS. A player's speed score after being normalized for height, specifically used for Wide Receivers and Tight Ends (WRs and TEs.) Taller players have a larger catch window so their scores are normalized downward.")]
        [DataMember(Name = "HeightAdjustedSpeedScore", Order = 40)]
        public decimal? HeightAdjustedSpeedScore { get; set; }

        /// <summary>
        /// A player's HaSS ranking relative to other players.
        /// </summary>
        [Description("A player's HaSS ranking relative to other players.")]
        [DataMember(Name = "HeightAdjustedSpeedScoreRank", Order = 41)]
        public int? HeightAdjustedSpeedScoreRank { get; set; }

        /// <summary>
        /// How large an area in which a player can catch. Based off the formula: the square of 40-yard dash time, 20-yard short shuttle time, and three-cone drill time; multiplied by the square of height, arm length, and vertical jump, all normalized to have equal weight.
        /// </summary>
        [Description("How large an area in which a player can catch. Based off the formula: the square of 40-yard dash time, 20-yard short shuttle time, and three-cone drill time; multiplied by the square of height, arm length, and vertical jump, all normalized to have equal weight.")]
        [DataMember(Name = "CatchRadius", Order = 42)]
        public decimal? CatchRadius { get; set; }

        /// <summary>
        /// A player's Catch Radius relative to other players.
        /// </summary>
        [Description("A player's Catch Radius relative to other players.")]
        [DataMember(Name = "CatchRadiusRank", Order = 43)]
        public int? CatchRadiusRank { get; set; }

        /// <summary>
        /// The number of reps a player can carry out of a 225-pound chest press exercise.
        /// </summary>
        [Description("The number of reps a player can carry out of a 225-pound chest press exercise.")]
        [DataMember(Name = "BenchPress", Order = 44)]
        public decimal? BenchPress { get; set; }

        /// <summary>
        /// A player's bench press performance relative to other players.
        /// </summary>
        [Description("A player's bench press performance relative to other players.")]
        [DataMember(Name = "BenchPressRank", Order = 45)]
        public int? BenchPressRank { get; set; }

        /// <summary>
        /// A property of arm length and tackle explosiveness, the radius at which the player can carry out a defensive play.
        /// </summary>
        [Description("A property of arm length and tackle explosiveness, the radius at which the player can carry out a defensive play.")]
        [DataMember(Name = "PlaymakingRadius", Order = 46)]
        public decimal? PlaymakingRadius { get; set; }

        /// <summary>
        /// A player's playmaking radius relative to other players of a similar position.
        /// </summary>
        [Description("A player's playmaking radius relative to other players of a similar position.")]
        [DataMember(Name = "PlaymakingRadiusRank", Order = 47)]
        public int? PlaymakingRadiusRank { get; set; }

        /// <summary>
        /// A curated highlight reel of a player in the form of a YouTube link.
        /// </summary>
        [Description("A curated highlight reel of a player in the form of a YouTube link.")]
        [DataMember(Name = "HighlightClip", Order = 48)]
        public string HighlightClip { get; set; }

        /// <summary>
        /// See the AdvancedPlayerMedical endpoint.
        /// </summary>
        [Description("See the AdvancedPlayerMedical endpoint.")]
        [DataMember(Name = "MedicalHistory", Order = 20049)]
        public AdvancedPlayerMedical[] MedicalHistory { get; set; }

        /// <summary>
        /// See the PlayerInfo endpoint.
        /// </summary>
        [Description("See the PlayerInfo endpoint.")]
        [DataMember(Name = "ComparablePlayers", Order = 20050)]
        public PlayerInfo[] ComparablePlayers { get; set; }

        /// <summary>
        /// See the AdvancedPlayerSeasons endpoint.
        /// </summary>
        [Description("See the AdvancedPlayerSeasons endpoint.")]
        [DataMember(Name = "AdvancedPlayerSeasons", Order = 20051)]
        public AdvancedPlayerSeason[] AdvancedPlayerSeasons { get; set; }

        /// <summary>
        /// See the AdvancedPlayerGames endpoint.
        /// </summary>
        [Description("See the AdvancedPlayerGames endpoint.")]
        [DataMember(Name = "AdvancedPlayerGames", Order = 20052)]
        public AdvancedPlayerGame[] AdvancedPlayerGames { get; set; }

    }
}

