using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The GUID/UUID of the player in the GRid system
        /// </summary>
        [Description("The GUID/UUID of the player in the GRid system")]
        [DataMember(Name = "PlayerGRid", Order = 1)]
        public string PlayerGRid { get; set; }

        /// <summary>
        /// The given name of the player
        /// </summary>
        [Description("The given name of the player")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The surname of the player
        /// </summary>
        [Description("The surname of the player")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The most commonly used name for the player (typically just `{FirstName} {LastName}`)
        /// </summary>
        [Description("The most commonly used name for the player (typically just `{FirstName} {LastName}`)")]
        [DataMember(Name = "CommonName", Order = 4)]
        public string CommonName { get; set; }

        /// <summary>
        /// Players Birthdate if available
        /// </summary>
        [Description("Players Birthdate if available")]
        [DataMember(Name = "Birthdate", Order = 5)]
        public string Birthdate { get; set; }

        /// <summary>
        /// The list of relevant Player Mappings from originators
        /// </summary>
        [Description("The list of relevant Player Mappings from originators")]
        [DataMember(Name = "Mappings", Order = 20006)]
        public PlayerMapping[] Mappings { get; set; }

        /// <summary>
        /// Extra player information about the player from SportsDataIO, intended for assistance in player identification
        /// </summary>
        [Description("Extra player information about the player from SportsDataIO, intended for assistance in player identification")]
        [DataMember(Name = "SportsDataIOPlayerProfile", Order = 10007)]
        public SportsDataIOPlayerProfile SportsDataIOPlayerProfile { get; set; }

    }
}

