using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayByPlay")]
    [Serializable]
    public partial class PlayByPlay
    {
        /// <summary>
        /// The score object and other game details of the given game
        /// </summary>
        [Description("The score object and other game details of the given game")]
        [DataMember(Name = "Score", Order = 10001)]
        public Score Score { get; set; }

        /// <summary>
        /// The details of the quarters (including overtime periods) for the given game
        /// </summary>
        [Description("The details of the quarters (including overtime periods) for the given game")]
        [DataMember(Name = "Quarters", Order = 20002)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The list of plays for the given game
        /// </summary>
        [Description("The list of plays for the given game")]
        [DataMember(Name = "Plays", Order = 20003)]
        public Play[] Plays { get; set; }

    }
}

