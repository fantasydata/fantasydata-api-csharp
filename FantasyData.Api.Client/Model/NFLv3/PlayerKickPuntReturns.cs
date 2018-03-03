using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerKickPuntReturns")]
    [Serializable]
    public partial class PlayerKickPuntReturns
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
        /// Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)
        /// </summary>
        [Description("Fantasy points scored based on basic fantasy scoring system (https://fantasydata.com/resources/fantasy-scoring-system.aspx)")]
        [DataMember(Name = "FantasyPoints", Order = 10)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The date and time that this player game was last updated (US Eastern Time)
        /// </summary>
        [Description("The date and time that this player game was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Number of kick return attempts
        /// </summary>
        [Description("Number of kick return attempts")]
        [DataMember(Name = "KickReturns", Order = 12)]
        public int KickReturns { get; set; }

        /// <summary>
        /// Total return yards on kicks
        /// </summary>
        [Description("Total return yards on kicks")]
        [DataMember(Name = "KickReturnYards", Order = 13)]
        public int KickReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per kick return
        /// </summary>
        [Description("Average yards gained per kick return")]
        [DataMember(Name = "KickReturnYardsPerAttempt", Order = 14)]
        public decimal KickReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "KickReturnLong", Order = 15)]
        public int KickReturnLong { get; set; }

        /// <summary>
        /// Number of touchdowns on kick returns
        /// </summary>
        [Description("Number of touchdowns on kick returns")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 16)]
        public int KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Number of punt return attempts
        /// </summary>
        [Description("Number of punt return attempts")]
        [DataMember(Name = "PuntReturns", Order = 17)]
        public int PuntReturns { get; set; }

        /// <summary>
        /// Total return yards on punts
        /// </summary>
        [Description("Total return yards on punts")]
        [DataMember(Name = "PuntReturnYards", Order = 18)]
        public int PuntReturnYards { get; set; }

        /// <summary>
        /// Average yards gained per punt return
        /// </summary>
        [Description("Average yards gained per punt return")]
        [DataMember(Name = "PuntReturnYardsPerAttempt", Order = 19)]
        public decimal PuntReturnYardsPerAttempt { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 20)]
        public int PuntReturnLong { get; set; }

        /// <summary>
        /// Number of touchdowns on punt returns
        /// </summary>
        [Description("Number of touchdowns on punt returns")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 21)]
        public int PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Number of fumbles recovered by opponent
        /// </summary>
        [Description("Number of fumbles recovered by opponent")]
        [DataMember(Name = "FumblesLost", Order = 22)]
        public int FumblesLost { get; set; }

    }
}

