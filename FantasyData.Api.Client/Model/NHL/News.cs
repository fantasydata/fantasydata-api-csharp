using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The brief title of the news (typically less than 100 characters)
        /// </summary>
        [Description("The brief title of the news (typically less than 100 characters)")]
        [DataMember(Name = "Title", Order = 5)]
        public string Title { get; set; }

        /// <summary>
        /// The full body content of the story
        /// </summary>
        [Description("The full body content of the story")]
        [DataMember(Name = "Content", Order = 6)]
        public string Content { get; set; }

        /// <summary>
        /// The url of the full story
        /// </summary>
        [Description("The url of the full story")]
        [DataMember(Name = "Url", Order = 7)]
        public string Url { get; set; }

        /// <summary>
        /// The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)
        /// </summary>
        [Description("The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)")]
        [DataMember(Name = "Source", Order = 8)]
        public string Source { get; set; }

        /// <summary>
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 9)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// The date the news story was updated
        /// </summary>
        [Description("The date the news story was updated")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

    }
}

