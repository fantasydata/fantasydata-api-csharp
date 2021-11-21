using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.MLB
{
    [DataContract(Namespace="", Name="Pitch")]
    [Serializable]
    public partial class Pitch
    {
        /// <summary>
        /// The unqiue ID of the pitch.
        /// </summary>
        [Description("The unqiue ID of the pitch.")]
        [DataMember(Name = "PitchID", Order = 1)]
        public int PitchID { get; set; }

        /// <summary>
        /// The unique ID of the play.
        /// </summary>
        [Description("The unique ID of the play.")]
        [DataMember(Name = "PlayID", Order = 2)]
        public int PlayID { get; set; }

        /// <summary>
        /// The pitch number of the current at bat.
        /// </summary>
        [Description("The pitch number of the current at bat.")]
        [DataMember(Name = "PitchNumberThisAtBat", Order = 3)]
        public int? PitchNumberThisAtBat { get; set; }

        /// <summary>
        /// The unique ID of the pitcher.
        /// </summary>
        [Description("The unique ID of the pitcher.")]
        [DataMember(Name = "PitcherID", Order = 4)]
        public int? PitcherID { get; set; }

        /// <summary>
        /// The unique ID of the hitter.
        /// </summary>
        [Description("The unique ID of the hitter.")]
        [DataMember(Name = "HitterID", Order = 5)]
        public int? HitterID { get; set; }

        /// <summary>
        /// The number of outs hte pitcher recorded.
        /// </summary>
        [Description("The number of outs hte pitcher recorded.")]
        [DataMember(Name = "Outs", Order = 6)]
        public int? Outs { get; set; }

        /// <summary>
        /// The number of balls the pitcher has thrown before the current pitch.
        /// </summary>
        [Description("The number of balls the pitcher has thrown before the current pitch.")]
        [DataMember(Name = "BallsBeforePitch", Order = 7)]
        public int? BallsBeforePitch { get; set; }

        /// <summary>
        /// The number of strikes the pitcher has thrown before the current pitch.
        /// </summary>
        [Description("The number of strikes the pitcher has thrown before the current pitch.")]
        [DataMember(Name = "StrikesBeforePitch", Order = 8)]
        public int? StrikesBeforePitch { get; set; }

        /// <summary>
        /// Whether the pitch was a strike. (true/false)
        /// </summary>
        [Description("Whether the pitch was a strike. (true/false)")]
        [DataMember(Name = "Strike", Order = 9)]
        public bool? Strike { get; set; }

        /// <summary>
        /// Whether the pitch was a ball. (true/false)
        /// </summary>
        [Description("Whether the pitch was a ball. (true/false)")]
        [DataMember(Name = "Ball", Order = 10)]
        public bool? Ball { get; set; }

        /// <summary>
        /// Whether the pitch was hit foul. (true/false)
        /// </summary>
        [Description("Whether the pitch was hit foul. (true/false)")]
        [DataMember(Name = "Foul", Order = 11)]
        public bool? Foul { get; set; }

        /// <summary>
        /// Whether the hitter struck out swinging. (true/false)
        /// </summary>
        [Description("Whether the hitter struck out swinging. (true/false)")]
        [DataMember(Name = "Swinging", Order = 12)]
        public bool? Swinging { get; set; }

        /// <summary>
        /// Whether the hitter struck out looking. (true/false)
        /// </summary>
        [Description("Whether the hitter struck out looking. (true/false)")]
        [DataMember(Name = "Looking", Order = 13)]
        public bool? Looking { get; set; }

    }
}

