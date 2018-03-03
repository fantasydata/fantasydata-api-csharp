using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerOwnership")]
    [Serializable]
    public partial class PlayerOwnership
    {
        /// <summary>
        /// Unique ID of the Player (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of the Player (assigned by FantasyData).")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The NFL season of the ownership info
        /// </summary>
        [Description("The NFL season of the ownership info")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// Player's fantasy position
        /// </summary>
        [Description("Player's fantasy position")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// Player's unique team key
        /// </summary>
        [Description("Player's unique team key")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Player's unique team ID
        /// </summary>
        [Description("Player's unique team ID")]
        [DataMember(Name = "TeamID", Order = 8)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Player's ownership percentage on NFL.com fantasy leagues during this week
        /// </summary>
        [Description("Player's ownership percentage on NFL.com fantasy leagues during this week")]
        [DataMember(Name = "OwnershipPercentage", Order = 9)]
        public decimal? OwnershipPercentage { get; set; }

        /// <summary>
        /// Player's change in ownership percentage on NFL.com fantasy leagues during this week
        /// </summary>
        [Description("Player's change in ownership percentage on NFL.com fantasy leagues during this week")]
        [DataMember(Name = "DeltaOwnershipPercentage", Order = 10)]
        public decimal? DeltaOwnershipPercentage { get; set; }

        /// <summary>
        /// Player's starting lineup percentage on NFL.com fantasy leagues during this week
        /// </summary>
        [Description("Player's starting lineup percentage on NFL.com fantasy leagues during this week")]
        [DataMember(Name = "StartPercentage", Order = 11)]
        public decimal? StartPercentage { get; set; }

        /// <summary>
        /// Player's change in starting lineup percentage on NFL.com fantasy leagues during this week
        /// </summary>
        [Description("Player's change in starting lineup percentage on NFL.com fantasy leagues during this week")]
        [DataMember(Name = "DeltaStartPercentage", Order = 12)]
        public decimal? DeltaStartPercentage { get; set; }

    }
}

