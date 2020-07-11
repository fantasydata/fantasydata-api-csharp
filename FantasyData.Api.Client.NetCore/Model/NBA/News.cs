using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NBA
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
        /// The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)
        /// </summary>
        [Description("The source of the story (FantasyData, RotoBaller, NBCSports.com, etc.)")]
        [DataMember(Name = "Source", Order = 2)]
        public string Source { get; set; }

        /// <summary>
        /// The date/time that the content was published (UTC time zone)
        /// </summary>
        [Description("The date/time that the content was published (UTC time zone)")]
        [DataMember(Name = "Updated", Order = 3)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// A description of how long ago this content was published
        /// </summary>
        [Description("A description of how long ago this content was published")]
        [DataMember(Name = "TimeAgo", Order = 4)]
        public string TimeAgo { get; set; }

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
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 8)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// The author of the content
        /// </summary>
        [Description("The author of the content")]
        [DataMember(Name = "Author", Order = 9)]
        public string Author { get; set; }

        /// <summary>
        /// Comma delimited meta tags describing the categories of this content. Possible tags include: Top Headlines, Breaking News, Injury, Sit/Start, Waiver Wire, Risers, Fallers, Lineups, Transactions, Free Agents, Prospects/Rookies, Game Recap, Matchup Outlook
        /// </summary>
        [Description("Comma delimited meta tags describing the categories of this content. Possible tags include: Top Headlines, Breaking News, Injury, Sit/Start, Waiver Wire, Risers, Fallers, Lineups, Transactions, Free Agents, Prospects/Rookies, Game Recap, Matchup Outlook")]
        [DataMember(Name = "Categories", Order = 10)]
        public string Categories { get; set; }

        /// <summary>
        /// The PlayerID of the player who relates to this story
        /// </summary>
        [Description("The PlayerID of the player who relates to this story")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The TeamID of the team that relates to this story
        /// </summary>
        [Description("The TeamID of the team that relates to this story")]
        [DataMember(Name = "TeamID", Order = 12)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The team that relates to this story
        /// </summary>
        [Description("The team that relates to this story")]
        [DataMember(Name = "Team", Order = 13)]
        public string Team { get; set; }

        /// <summary>
        /// The PlayerID of the player who relates to this story
        /// </summary>
        [Description("The PlayerID of the player who relates to this story")]
        [DataMember(Name = "PlayerID2", Order = 14)]
        public int? PlayerID2 { get; set; }

        /// <summary>
        /// The TeamID of the team that relates to this story
        /// </summary>
        [Description("The TeamID of the team that relates to this story")]
        [DataMember(Name = "TeamID2", Order = 15)]
        public int? TeamID2 { get; set; }

        /// <summary>
        /// The team that relates to this story
        /// </summary>
        [Description("The team that relates to this story")]
        [DataMember(Name = "Team2", Order = 16)]
        public string Team2 { get; set; }

    }
}

