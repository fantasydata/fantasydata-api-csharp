using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="RotoworldPlayerNewsPlayerMetaData")]
    [Serializable]
    public partial class RotoworldPlayerNewsPlayerMetaData
    {
        /// <summary>
        /// The first name of the golfer as listed by Rotoworld Player News
        /// </summary>
        [Description("The first name of the golfer as listed by Rotoworld Player News")]
        [DataMember(Name = "PlayerFirstName", Order = 1)]
        public string PlayerFirstName { get; set; }

        /// <summary>
        /// The last name of the golfer as listed by Rotoworld Player News
        /// </summary>
        [Description("The last name of the golfer as listed by Rotoworld Player News")]
        [DataMember(Name = "PlayerLastName", Order = 2)]
        public string PlayerLastName { get; set; }

        /// <summary>
        /// The Rotoworld Player ID/GUID of the player related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The Rotoworld Player ID/GUID of the player related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "RotoworldPlayerId", Order = 3)]
        public string RotoworldPlayerId { get; set; }

        /// <summary>
        /// The Stats Player ID of the golfer related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The Stats Player ID of the golfer related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "StatsPlayerID", Order = 4)]
        public int? StatsPlayerID { get; set; }

        /// <summary>
        /// The SportRadar Player ID of the golfer related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The SportRadar Player ID of the golfer related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "SportRadarPlayerID", Order = 5)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The status of the golfer related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The status of the golfer related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "PlayerStatus", Order = 6)]
        public string PlayerStatus { get; set; }

        /// <summary>
        /// The team key of the team related to the news item as listed by Rotoworld Player News (the league's abbreviation will be used for general news, not specific to a team)
        /// </summary>
        [Description("The team key of the team related to the news item as listed by Rotoworld Player News (the league's abbreviation will be used for general news, not specific to a team)")]
        [DataMember(Name = "TeamKey", Order = 7)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The team city of the team related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The team city of the team related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "TeamCity", Order = 8)]
        public string TeamCity { get; set; }

        /// <summary>
        /// The team name of the team related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The team name of the team related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "TeamName", Order = 9)]
        public string TeamName { get; set; }

        /// <summary>
        /// The hex color of the team related to the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The hex color of the team related to the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "TeamColor", Order = 10)]
        public string TeamColor { get; set; }

    }
}

