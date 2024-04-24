using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="RotoworldPlayerNewsItem")]
    [Serializable]
    public partial class RotoworldPlayerNewsItem
    {
        /// <summary>
        /// Rotoworld Player News Item ID/GUID
        /// </summary>
        [Description("Rotoworld Player News Item ID/GUID")]
        [DataMember(Name = "RotoworldPlayerNewsLine", Order = 1)]
        public string RotoworldPlayerNewsLine { get; set; }

        /// <summary>
        /// The short headline
        /// </summary>
        [Description("The short headline")]
        [DataMember(Name = "Headline", Order = 2)]
        public string Headline { get; set; }

        /// <summary>
        /// The longer headline used on Rotoworld Player News article
        /// </summary>
        [Description("The longer headline used on Rotoworld Player News article")]
        [DataMember(Name = "Comment", Order = 3)]
        public string Comment { get; set; }

        /// <summary>
        /// The body of the news article
        /// </summary>
        [Description("The body of the news article")]
        [DataMember(Name = "Impact", Order = 4)]
        public string Impact { get; set; }

        /// <summary>
        /// The date the news item was created as listed by Rotoworld Player News
        /// </summary>
        [Description("The date the news item was created as listed by Rotoworld Player News")]
        [DataMember(Name = "RotoworldCreated", Order = 5)]
        public DateTime RotoworldCreated { get; set; }

        /// <summary>
        /// The time of the last update to this news item as listed by Rotoworld Player News
        /// </summary>
        [Description("The time of the last update to this news item as listed by Rotoworld Player News")]
        [DataMember(Name = "RotoworldLastUpdated", Order = 6)]
        public DateTime RotoworldLastUpdated { get; set; }

        /// <summary>
        /// A flag for top news items as listed by Rotoworld Player News
        /// </summary>
        [Description("A flag for top news items as listed by Rotoworld Player News")]
        [DataMember(Name = "IsTopNews", Order = 7)]
        public bool IsTopNews { get; set; }

        /// <summary>
        /// A flag to indicate this news item relates to a transaction as listed by Rotoworld Player News
        /// </summary>
        [Description("A flag to indicate this news item relates to a transaction as listed by Rotoworld Player News")]
        [DataMember(Name = "IsTransaction", Order = 8)]
        public bool? IsTransaction { get; set; }

        /// <summary>
        /// A flag to indicate the news item relates to a rumor as listed by Rotoworld Player News
        /// </summary>
        [Description("A flag to indicate the news item relates to a rumor as listed by Rotoworld Player News")]
        [DataMember(Name = "IsRumor", Order = 9)]
        public bool? IsRumor { get; set; }

        /// <summary>
        /// A link to a source for the information in the news article
        /// </summary>
        [Description("A link to a source for the information in the news article")]
        [DataMember(Name = "MoreLink", Order = 10)]
        public string MoreLink { get; set; }

        /// <summary>
        /// The name of the source for the info in the article
        /// </summary>
        [Description("The name of the source for the info in the article")]
        [DataMember(Name = "MoreName", Order = 11)]
        public string MoreName { get; set; }

        /// <summary>
        /// Information about the player related to the article
        /// </summary>
        [Description("Information about the player related to the article")]
        [DataMember(Name = "PlayerInfo", Order = 10012)]
        public PlayerInfo PlayerInfo { get; set; }

        /// <summary>
        /// Lots of Player and Team information pertaining to the relevant player & team related to the news article as listed by Rotoworld Player News
        /// </summary>
        [Description("Lots of Player and Team information pertaining to the relevant player & team related to the news article as listed by Rotoworld Player News")]
        [DataMember(Name = "RotoworldPlayerMeta", Order = 10013)]
        public RotoworldPlayerNewsPlayerMetaData RotoworldPlayerMeta { get; set; }

    }
}

