using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Headshot")]
    [Serializable]
    public partial class Headshot
    {
        /// <summary>
        /// Unique ID of the Player (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of the Player (assigned by FantasyData).")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Name of Player.
        /// </summary>
        [Description("Name of Player.")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of the Team the player belongs to (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of the Team the player belongs to (assigned by FantasyData).")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Name of the team the player belongs to.
        /// </summary>
        [Description("Name of the team the player belongs to.")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Position player plays.
        /// </summary>
        [Description("Position player plays.")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// The player's preferred hosted headshot URL. This returns the headshot with transparent background, if available.
        /// </summary>
        [Description("The player's preferred hosted headshot URL. This returns the headshot with transparent background, if available.")]
        [DataMember(Name = "PreferredHostedHeadshotUrl", Order = 6)]
        public string PreferredHostedHeadshotUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's preferred hosted headshot.
        /// </summary>
        [Description("The last updated date of the player's preferred hosted headshot.")]
        [DataMember(Name = "PreferredHostedHeadshotUpdated", Order = 7)]
        public DateTime? PreferredHostedHeadshotUpdated { get; set; }

        /// <summary>
        /// The player's hosted headshot URL.
        /// </summary>
        [Description("The player's hosted headshot URL.")]
        [DataMember(Name = "HostedHeadshotWithBackgroundUrl", Order = 8)]
        public string HostedHeadshotWithBackgroundUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's hosted headshot.
        /// </summary>
        [Description("The last updated date of the player's hosted headshot.")]
        [DataMember(Name = "HostedHeadshotWithBackgroundUpdated", Order = 9)]
        public DateTime? HostedHeadshotWithBackgroundUpdated { get; set; }

        /// <summary>
        /// The player's transparent background hosted headshot URL.
        /// </summary>
        [Description("The player's transparent background hosted headshot URL.")]
        [DataMember(Name = "HostedHeadshotNoBackgroundUrl", Order = 10)]
        public string HostedHeadshotNoBackgroundUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's transparent background hosted headshot.
        /// </summary>
        [Description("The last updated date of the player's transparent background hosted headshot.")]
        [DataMember(Name = "HostedHeadshotNoBackgroundUpdated", Order = 11)]
        public DateTime? HostedHeadshotNoBackgroundUpdated { get; set; }

    }
}

