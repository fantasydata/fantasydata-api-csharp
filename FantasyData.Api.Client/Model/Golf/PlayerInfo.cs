using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// The unique ID of the golfer
        /// </summary>
        [Description("The unique ID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The full name of the golfer
        /// </summary>
        [Description("The full name of the golfer")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

