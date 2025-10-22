using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Pitch")]
    [Serializable]
    public partial class Pitch
    {
        /// <summary>
        /// The unique ID of the pitch
        /// </summary>
        [Description("The unique ID of the pitch")]
        [DataMember(Name = "PitchID", Order = 1)]
        public int PitchID { get; set; }

        /// <summary>
        /// The unique ID of the play assigned by SportsDataIO
        /// </summary>
        [Description("The unique ID of the play assigned by SportsDataIO")]
        [DataMember(Name = "PlayID", Order = 2)]
        public int PlayID { get; set; }

        /// <summary>
        /// The number of pitches in the at bat in which the pitch occurred.
        /// </summary>
        [Description("The number of pitches in the at bat in which the pitch occurred.")]
        [DataMember(Name = "PitchNumberThisAtBat", Order = 3)]
        public int? PitchNumberThisAtBat { get; set; }

        /// <summary>
        /// The PlayerID of the pitcher who threw the pitch
        /// </summary>
        [Description("The PlayerID of the pitcher who threw the pitch")]
        [DataMember(Name = "PitcherID", Order = 4)]
        public int? PitcherID { get; set; }

        /// <summary>
        /// The unique PlayerID of the hitter who represents the play
        /// </summary>
        [Description("The unique PlayerID of the hitter who represents the play")]
        [DataMember(Name = "HitterID", Order = 5)]
        public int? HitterID { get; set; }

        /// <summary>
        /// The number of outs when the pitch occurred
        /// </summary>
        [Description("The number of outs when the pitch occurred")]
        [DataMember(Name = "Outs", Order = 6)]
        public int? Outs { get; set; }

        /// <summary>
        /// The number of balls the pitcher has thrown before the current pitch
        /// </summary>
        [Description("The number of balls the pitcher has thrown before the current pitch")]
        [DataMember(Name = "BallsBeforePitch", Order = 7)]
        public int? BallsBeforePitch { get; set; }

        /// <summary>
        /// The number of strikes the pitcher has thrown before the current pitch
        /// </summary>
        [Description("The number of strikes the pitcher has thrown before the current pitch")]
        [DataMember(Name = "StrikesBeforePitch", Order = 8)]
        public int? StrikesBeforePitch { get; set; }

        /// <summary>
        /// Whether the pitch was a strike (true/false)
        /// </summary>
        [Description("Whether the pitch was a strike (true/false)")]
        [DataMember(Name = "Strike", Order = 9)]
        public bool? Strike { get; set; }

        /// <summary>
        /// Whether the pitch was a ball (true/false)
        /// </summary>
        [Description("Whether the pitch was a ball (true/false)")]
        [DataMember(Name = "Ball", Order = 10)]
        public bool? Ball { get; set; }

        /// <summary>
        /// Whether the pitch was hit foul (true/false)
        /// </summary>
        [Description("Whether the pitch was hit foul (true/false)")]
        [DataMember(Name = "Foul", Order = 11)]
        public bool? Foul { get; set; }

        /// <summary>
        /// Whether the hitter struck out swinging (true/false)
        /// </summary>
        [Description("Whether the hitter struck out swinging (true/false)")]
        [DataMember(Name = "Swinging", Order = 12)]
        public bool? Swinging { get; set; }

        /// <summary>
        /// Whether or not the hitter struck out looking (returns true/false)
        /// </summary>
        [Description("Whether or not the hitter struck out looking (returns true/false)")]
        [DataMember(Name = "Looking", Order = 13)]
        public bool? Looking { get; set; }

    }
}

