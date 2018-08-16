using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="News")]
    [Serializable]
    public partial class News
    {
        /// <summary>
        /// Unique ID of news story
        /// </summary>
        [Description("Unique ID of news story")]
        [DataMember(Name = "NewsID", Order = 1)]
        public int NewsID { get; set; }

        /// <summary>
        /// The PlayerID of the player who relates to this story
        /// </summary>
        [Description("The PlayerID of the player who relates to this story")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The brief title of the news (typically less than 100 characters)
        /// </summary>
        [Description("The brief title of the news (typically less than 100 characters)")]
        [DataMember(Name = "Title", Order = 3)]
        public string Title { get; set; }

        /// <summary>
        /// The full body content of the story
        /// </summary>
        [Description("The full body content of the story")]
        [DataMember(Name = "Content", Order = 4)]
        public string Content { get; set; }

        /// <summary>
        /// The url of the full story
        /// </summary>
        [Description("The url of the full story")]
        [DataMember(Name = "Url", Order = 5)]
        public string Url { get; set; }

        /// <summary>
        /// The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)
        /// </summary>
        [Description("The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)")]
        [DataMember(Name = "Source", Order = 6)]
        public string Source { get; set; }

        /// <summary>
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 7)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// The date/time that the content was published
        /// </summary>
        [Description("The date/time that the content was published")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

    }
}

