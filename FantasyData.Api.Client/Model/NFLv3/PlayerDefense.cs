using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerDefense")]
    [Serializable]
    public partial class PlayerDefense
    {
        /// <summary>
        /// Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.
        /// </summary>
        [Description("Unique ID of PlayerGame record (subject to change, although it very rarely does).  For a static ID, use a combination of GameKey and PlayerID.")]
        [DataMember(Name = "PlayerGameID", Order = 1)]
        public int? PlayerGameID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A shortened version of the player's full name (C.Newton, A.Rodgers)
        /// </summary>
        [Description("A shortened version of the player's full name (C.Newton, A.Rodgers)")]
        [DataMember(Name = "ShortName", Order = 3)]
        public string ShortName { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 6)]
        public int Number { get; set; }

        /// <summary>
        /// Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR
        /// </summary>
        [Description("Player's position for this particular game or season. Possible values: C, CB, DB, DE, DE/LB, DL, DT, FB, FS, G, ILB, K, KR, LB, LS, NT, OL, OLB, OT, P, QB, RB, S, SS, T, TE, WR")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)
        /// </summary>
        [Description("Abbreviation of either Offense, Defense or Special Teams (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 8)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB, RB, WR, TE, DL, LB, DB, K, P, OL")]
        [DataMember(Name = "FantasyPosition", Order = 9)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Fantasy points scored based on basic fantasy scoring system
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system")]
        [DataMember(Name = "FantasyPoints", Order = 10)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The date and time that this player game was last updated (US Eastern Time)
        /// </summary>
        [Description("The date and time that this player game was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Sum of SoloTackles and AssistedTackles
        /// </summary>
        [Description("Sum of SoloTackles and AssistedTackles")]
        [DataMember(Name = "Tackles", Order = 12)]
        public int Tackles { get; set; }

        /// <summary>
        /// Solo, unassisted tackles
        /// </summary>
        [Description("Solo, unassisted tackles")]
        [DataMember(Name = "SoloTackles", Order = 13)]
        public int SoloTackles { get; set; }

        /// <summary>
        /// Assisted tackles (also called a half tackle)
        /// </summary>
        [Description("Assisted tackles (also called a half tackle)")]
        [DataMember(Name = "AssistedTackles", Order = 14)]
        public int AssistedTackles { get; set; }

        /// <summary>
        /// Sacks of the opposing quarterback
        /// </summary>
        [Description("Sacks of the opposing quarterback")]
        [DataMember(Name = "Sacks", Order = 15)]
        public decimal Sacks { get; set; }

        /// <summary>
        /// Yards lost as a result of sacking the opposing quarterback
        /// </summary>
        [Description("Yards lost as a result of sacking the opposing quarterback")]
        [DataMember(Name = "SackYards", Order = 16)]
        public int SackYards { get; set; }

        /// <summary>
        /// Number of fumbles forced
        /// </summary>
        [Description("Number of fumbles forced")]
        [DataMember(Name = "FumblesForced", Order = 17)]
        public int FumblesForced { get; set; }

        /// <summary>
        /// Number of fumbles recovered
        /// </summary>
        [Description("Number of fumbles recovered")]
        [DataMember(Name = "FumblesRecovered", Order = 18)]
        public int FumblesRecovered { get; set; }

        /// <summary>
        /// Passes defended or batted down
        /// </summary>
        [Description("Passes defended or batted down")]
        [DataMember(Name = "PassesDefended", Order = 19)]
        public int PassesDefended { get; set; }

        /// <summary>
        /// Number of interceptions
        /// </summary>
        [Description("Number of interceptions")]
        [DataMember(Name = "Interceptions", Order = 20)]
        public int Interceptions { get; set; }

        /// <summary>
        /// Return yards from interceptions
        /// </summary>
        [Description("Return yards from interceptions")]
        [DataMember(Name = "InterceptionReturnYards", Order = 21)]
        public int InterceptionReturnYards { get; set; }

        /// <summary>
        /// Return touchdowns from interceptions
        /// </summary>
        [Description("Return touchdowns from interceptions")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 22)]
        public int InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Tackles behind the opponent's line of scrimmage (sacks are also credited as a tackle for loss)
        /// </summary>
        [Description("Tackles behind the opponent's line of scrimmage (sacks are also credited as a tackle for loss)")]
        [DataMember(Name = "TacklesForLoss", Order = 23)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Number of times hitting an opposing quarterback (this inludes sacks)
        /// </summary>
        [Description("Number of times hitting an opposing quarterback (this inludes sacks)")]
        [DataMember(Name = "QuarterbackHits", Order = 24)]
        public int QuarterbackHits { get; set; }

        /// <summary>
        /// Return touchdowns from fumble recoveries
        /// </summary>
        [Description("Return touchdowns from fumble recoveries")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 25)]
        public int FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)
        /// </summary>
        [Description("Defensive safeties (sacks in end zone, solo tackles in end zone, blocked kicks that went out of bounds in the end zone)")]
        [DataMember(Name = "Safeties", Order = 26)]
        public int Safeties { get; set; }

    }
}

