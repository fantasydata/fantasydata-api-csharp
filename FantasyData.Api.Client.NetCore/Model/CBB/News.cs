using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
{
    [DataContract(Namespace="", Name="News")]
    [Serializable]
    public partial class News
    {
        /// <summary>
        /// Unique ID of the news story
        /// </summary>
        [Description("Unique ID of the news story")]
        [DataMember(Name = "NewsID", Order = 1)]
        public int NewsID { get; set; }

        /// <summary>
        /// The title of the news story
        /// </summary>
        [Description("The title of the news story")]
        [DataMember(Name = "Title", Order = 2)]
        public string Title { get; set; }

        /// <summary>
        /// The date/time that the content was published
        /// </summary>
        [Description("The date/time that the content was published")]
        [DataMember(Name = "Updated", Order = 3)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The url of the full story
        /// </summary>
        [Description("The url of the full story")]
        [DataMember(Name = "Url", Order = 4)]
        public string Url { get; set; }

        /// <summary>
        /// The full body content of the story
        /// </summary>
        [Description("The full body content of the story")]
        [DataMember(Name = "Content", Order = 5)]
        public string Content { get; set; }

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
        /// The PlayerID of the player who relates to this story
        /// </summary>
        [Description("The PlayerID of the player who relates to this story")]
        [DataMember(Name = "PlayerID", Order = 8)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The TeamID of the team that relates to this story
        /// </summary>
        [Description("The TeamID of the team that relates to this story")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The team that relates to this story
        /// </summary>
        [Description("The team that relates to this story")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

    }
}

