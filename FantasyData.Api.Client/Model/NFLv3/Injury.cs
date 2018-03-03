using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Injury")]
    [Serializable]
    public partial class Injury
    {
        /// <summary>
        /// Unique ID of the injury status
        /// </summary>
        [Description("Unique ID of the injury status")]
        [DataMember(Name = "InjuryID", Order = 1)]
        public int InjuryID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season of the game that this injury leads up to
        /// </summary>
        [Description("The season of the game that this injury leads up to")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The week of the game that this injury leads up to
        /// </summary>
        [Description("The week of the game that this injury leads up to")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The PlayerID of the injured player
        /// </summary>
        [Description("The PlayerID of the injured player")]
        [DataMember(Name = "PlayerID", Order = 5)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The full name of the injured player
        /// </summary>
        [Description("The full name of the injured player")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The position of the injured player
        /// </summary>
        [Description("The position of the injured player")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The jersey number of the injured player
        /// </summary>
        [Description("The jersey number of the injured player")]
        [DataMember(Name = "Number", Order = 8)]
        public int Number { get; set; }

        /// <summary>
        /// The team the injured player is on
        /// </summary>
        [Description("The team the injured player is on")]
        [DataMember(Name = "Team", Order = 9)]
        public string Team { get; set; }

        /// <summary>
        /// The upcoming opponent of the injured player
        /// </summary>
        [Description("The upcoming opponent of the injured player")]
        [DataMember(Name = "Opponent", Order = 10)]
        public string Opponent { get; set; }

        /// <summary>
        /// The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)
        /// </summary>
        [Description("The body part that is injured (Knee, Groin, Calf, Hamstring, etc.)")]
        [DataMember(Name = "BodyPart", Order = 11)]
        public string BodyPart { get; set; }

        /// <summary>
        /// Likelihood that player plays (Probable, Questionable, Doubtful, Out)
        /// </summary>
        [Description("Likelihood that player plays (Probable, Questionable, Doubtful, Out)")]
        [DataMember(Name = "Status", Order = 12)]
        public string Status { get; set; }

        /// <summary>
        /// Whether the player participated in practice (None, Limited, Full)
        /// </summary>
        [Description("Whether the player participated in practice (None, Limited, Full)")]
        [DataMember(Name = "Practice", Order = 13)]
        public string Practice { get; set; }

        /// <summary>
        /// Full description of whether the player participated in practice)
        /// </summary>
        [Description("Full description of whether the player participated in practice)")]
        [DataMember(Name = "PracticeDescription", Order = 14)]
        public string PracticeDescription { get; set; }

        /// <summary>
        /// The date/time the injury status was updated
        /// </summary>
        [Description("The date/time the injury status was updated")]
        [DataMember(Name = "Updated", Order = 15)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Whether the player has been declared inactive.  This value is updated in the hours leading up to game start time, as teams announce their inactive players.  This is only updated for offensive skill position players (QB, RB, WR, TE)
        /// </summary>
        [Description("Whether the player has been declared inactive.  This value is updated in the hours leading up to game start time, as teams announce their inactive players.  This is only updated for offensive skill position players (QB, RB, WR, TE)")]
        [DataMember(Name = "DeclaredInactive", Order = 16)]
        public bool? DeclaredInactive { get; set; }

        /// <summary>
        /// The TeamID of the team this player played on during this game.
        /// </summary>
        [Description("The TeamID of the team this player played on during this game.")]
        [DataMember(Name = "TeamID", Order = 17)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The TeamID of the opponent this player played on during this game.
        /// </summary>
        [Description("The TeamID of the opponent this player played on during this game.")]
        [DataMember(Name = "OpponentID", Order = 18)]
        public int? OpponentID { get; set; }

    }
}

