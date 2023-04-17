using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="RotoworldPlayerNewsItem")]
    [Serializable]
    public partial class RotoworldPlayerNewsItem
    {
        /// <summary>
        /// The ID of the news item on Rotoworld Player News feed
        /// </summary>
        [Description("The ID of the news item on Rotoworld Player News feed")]
        [DataMember(Name = "RotoworldPlayerNewsLine", Order = 1)]
        public int RotoworldPlayerNewsLine { get; set; }

        /// <summary>
        /// The short headline
        /// </summary>
        [Description("The short headline")]
        [DataMember(Name = "Headline", Order = 2)]
        public string Headline { get; set; }

        /// <summary>
        /// The longer headline used on the Rotoworld Player News page
        /// </summary>
        [Description("The longer headline used on the Rotoworld Player News page")]
        [DataMember(Name = "Comment", Order = 3)]
        public string Comment { get; set; }

        /// <summary>
        /// The body of the news blurb
        /// </summary>
        [Description("The body of the news blurb")]
        [DataMember(Name = "Impact", Order = 4)]
        public string Impact { get; set; }

        /// <summary>
        /// The date the news item was created as listed by Rotoworld Player News feed
        /// </summary>
        [Description("The date the news item was created as listed by Rotoworld Player News feed")]
        [DataMember(Name = "RotoworldCreated", Order = 5)]
        public DateTime RotoworldCreated { get; set; }

        /// <summary>
        /// The time of the last update as listed by Rotoworld Player News feed
        /// </summary>
        [Description("The time of the last update as listed by Rotoworld Player News feed")]
        [DataMember(Name = "RotoworldLastUpdated", Order = 6)]
        public DateTime RotoworldLastUpdated { get; set; }

        /// <summary>
        /// A flag for top news items as listed by Rotoworld Player News feed
        /// </summary>
        [Description("A flag for top news items as listed by Rotoworld Player News feed")]
        [DataMember(Name = "IsTopNews", Order = 7)]
        public bool IsTopNews { get; set; }

        /// <summary>
        /// A flag to indicate the news item relates to a transaction as listed by Rotoworld Player News feed
        /// </summary>
        [Description("A flag to indicate the news item relates to a transaction as listed by Rotoworld Player News feed")]
        [DataMember(Name = "IsTransaction", Order = 8)]
        public bool? IsTransaction { get; set; }

        /// <summary>
        /// A flag to indicate the news item relates to a rumor
        /// </summary>
        [Description("A flag to indicate the news item relates to a rumor")]
        [DataMember(Name = "IsRumor", Order = 9)]
        public bool? IsRumor { get; set; }

        /// <summary>
        /// A link to a source for the information in the news item
        /// </summary>
        [Description("A link to a source for the information in the news item")]
        [DataMember(Name = "MoreLink", Order = 10)]
        public string MoreLink { get; set; }

        /// <summary>
        /// The name of the source for the information in the news item
        /// </summary>
        [Description("The name of the source for the information in the news item")]
        [DataMember(Name = "MoreName", Order = 11)]
        public string MoreName { get; set; }

        /// <summary>
        /// Information about the player related to the article
        /// </summary>
        [Description("Information about the player related to the article")]
        [DataMember(Name = "PlayerInfo", Order = 10012)]
        public PlayerInfo PlayerInfo { get; set; }

        /// <summary>
        /// Lots of player and team information pertaining to the relevant player/team in the news item as listed by Rotoworld Player News
        /// </summary>
        [Description("Lots of player and team information pertaining to the relevant player/team in the news item as listed by Rotoworld Player News")]
        [DataMember(Name = "RotoworldPlayerMeta", Order = 10013)]
        public RotoworldPlayerNewsPlayerMetaData RotoworldPlayerMeta { get; set; }

    }
}

