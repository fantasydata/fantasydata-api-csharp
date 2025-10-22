using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Goaltender")]
    [Serializable]
    public partial class Goaltender
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team the goaltender belongs to
        /// </summary>
        [Description("The abbreviation [Key] of the team the goaltender belongs to")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The first name of the goaltender
        /// </summary>
        [Description("The first name of the goaltender")]
        [DataMember(Name = "FirstName", Order = 4)]
        public string FirstName { get; set; }

        /// <summary>
        /// The goaltender's last name
        /// </summary>
        [Description("The goaltender's last name")]
        [DataMember(Name = "LastName", Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// The goaltender's jersey number
        /// </summary>
        [Description("The goaltender's jersey number")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Indicates whether the starting goaltender is projected or confirmed
        /// </summary>
        [Description("Indicates whether the starting goaltender is projected or confirmed")]
        [DataMember(Name = "Confirmed", Order = 7)]
        public bool Confirmed { get; set; }

    }
}

