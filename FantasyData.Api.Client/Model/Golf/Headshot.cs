using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Headshot")]
    [Serializable]
    public partial class Headshot
    {
        /// <summary>
        /// The unique ID of the golfer
        /// </summary>
        [Description("The unique ID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The name of the golfer
        /// </summary>
        [Description("The name of the golfer")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The player's preferred hosted headshot URL. This returns the headshot with transparent background; if available
        /// </summary>
        [Description("The player's preferred hosted headshot URL. This returns the headshot with transparent background; if available")]
        [DataMember(Name = "PreferredHostedHeadshotUrl", Order = 3)]
        public string PreferredHostedHeadshotUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's preferred hosted headshot
        /// </summary>
        [Description("The last updated date of the player's preferred hosted headshot")]
        [DataMember(Name = "PreferredHostedHeadshotUpdated", Order = 4)]
        public DateTime? PreferredHostedHeadshotUpdated { get; set; }

        /// <summary>
        /// The player's hosted headshot URL
        /// </summary>
        [Description("The player's hosted headshot URL")]
        [DataMember(Name = "HostedHeadshotWithBackgroundUrl", Order = 5)]
        public string HostedHeadshotWithBackgroundUrl { get; set; }

        /// <summary>
        /// The timestamp of when the player's hosted headshot was last updated
        /// </summary>
        [Description("The timestamp of when the player's hosted headshot was last updated")]
        [DataMember(Name = "HostedHeadshotWithBackgroundUpdated", Order = 6)]
        public DateTime? HostedHeadshotWithBackgroundUpdated { get; set; }

        /// <summary>
        /// The player's transparent background hosted headshot URL
        /// </summary>
        [Description("The player's transparent background hosted headshot URL")]
        [DataMember(Name = "HostedHeadshotNoBackgroundUrl", Order = 7)]
        public string HostedHeadshotNoBackgroundUrl { get; set; }

        /// <summary>
        /// The timestamp of when the player's transparent background hosted headshot was last updated
        /// </summary>
        [Description("The timestamp of when the player's transparent background hosted headshot was last updated")]
        [DataMember(Name = "HostedHeadshotNoBackgroundUpdated", Order = 8)]
        public DateTime? HostedHeadshotNoBackgroundUpdated { get; set; }

    }
}

