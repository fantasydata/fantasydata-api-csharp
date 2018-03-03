using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Article")]
    [Serializable]
    public partial class Article
    {
        /// <summary>
        /// Unique ID of the Article (assigned by FantasyData)
        /// </summary>
        [Description("Unique ID of the Article (assigned by FantasyData)")]
        [DataMember(Name = "ArticleID", Order = 1)]
        public int ArticleID { get; set; }

        /// <summary>
        /// Article title
        /// </summary>
        [Description("Article title")]
        [DataMember(Name = "Title", Order = 2)]
        public string Title { get; set; }

        /// <summary>
        /// Article source company
        /// </summary>
        [Description("Article source company")]
        [DataMember(Name = "Source", Order = 3)]
        public string Source { get; set; }

        /// <summary>
        /// Article publish/last updated date
        /// </summary>
        [Description("Article publish/last updated date")]
        [DataMember(Name = "Updated", Order = 4)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Main Content of the article
        /// </summary>
        [Description("Main Content of the article")]
        [DataMember(Name = "Content", Order = 5)]
        public string Content { get; set; }

        /// <summary>
        /// Source company article url
        /// </summary>
        [Description("Source company article url")]
        [DataMember(Name = "Url", Order = 6)]
        public string Url { get; set; }

        /// <summary>
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 7)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// Article Author
        /// </summary>
        [Description("Article Author")]
        [DataMember(Name = "Author", Order = 8)]
        public string Author { get; set; }

        /// <summary>
        /// Basic info on players included in the article
        /// </summary>
        [Description("Basic info on players included in the article")]
        [DataMember(Name = "Players", Order = 20009)]
        public PlayerInfo[] Players { get; set; }

    }
}

