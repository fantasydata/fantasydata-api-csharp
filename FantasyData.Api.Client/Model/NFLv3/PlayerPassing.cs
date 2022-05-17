using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerPassing")]
    [Serializable]
    public partial class PlayerPassing
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
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "PassingAttempts", Order = 12)]
        public int PassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "PassingCompletions", Order = 13)]
        public int PassingCompletions { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "PassingYards", Order = 14)]
        public int PassingYards { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "PassingTouchdowns", Order = 15)]
        public int PassingTouchdowns { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "PassingInterceptions", Order = 16)]
        public int PassingInterceptions { get; set; }

        /// <summary>
        /// Longest completion
        /// </summary>
        [Description("Longest completion")]
        [DataMember(Name = "PassingLong", Order = 17)]
        public int PassingLong { get; set; }

        /// <summary>
        /// Number of times sacked
        /// </summary>
        [Description("Number of times sacked")]
        [DataMember(Name = "PassingSacks", Order = 18)]
        public int PassingSacks { get; set; }

        /// <summary>
        /// Yards lost as a result of being sacked
        /// </summary>
        [Description("Yards lost as a result of being sacked")]
        [DataMember(Name = "PassingSackYards", Order = 19)]
        public int PassingSackYards { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "PassingCompletionPercentage", Order = 20)]
        public decimal PassingCompletionPercentage { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 21)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 22)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "PassingRating", Order = 23)]
        public decimal PassingRating { get; set; }

        /// <summary>
        /// Successful two point conversion passes
        /// </summary>
        [Description("Successful two point conversion passes")]
        [DataMember(Name = "TwoPointConversionPasses", Order = 24)]
        public int TwoPointConversionPasses { get; set; }

        /// <summary>
        /// Number of fumbles recovered by opponent
        /// </summary>
        [Description("Number of fumbles recovered by opponent")]
        [DataMember(Name = "FumblesLost", Order = 25)]
        public int FumblesLost { get; set; }

    }
}

