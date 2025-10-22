using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="News")]
    [Serializable]
    public partial class News
    {
        /// <summary>
        /// The unique ID of news story
        /// </summary>
        [Description("The unique ID of news story")]
        [DataMember(Name = "NewsID", Order = 1)]
        public int NewsID { get; set; }

        /// <summary>
        /// The source of the story (RotoBaller, NBCSports.com, etc.)
        /// </summary>
        [Description("The source of the story (RotoBaller, NBCSports.com, etc.)")]
        [DataMember(Name = "Source", Order = 2)]
        public string Source { get; set; }

        /// <summary>
        /// The timestamp of when this news story was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this news story was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 3)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// How long ago this news story was published
        /// </summary>
        [Description("How long ago this news story was published")]
        [DataMember(Name = "TimeAgo", Order = 4)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// The headline of the news story (typically less than 100 characters)
        /// </summary>
        [Description("The headline of the news story (typically less than 100 characters)")]
        [DataMember(Name = "Title", Order = 5)]
        public string Title { get; set; }

        /// <summary>
        /// The full body content of the story
        /// </summary>
        [Description("The full body content of the story")]
        [DataMember(Name = "Content", Order = 6)]
        public string Content { get; set; }

        /// <summary>
        /// The URL of the full news story
        /// </summary>
        [Description("The URL of the full news story")]
        [DataMember(Name = "Url", Order = 7)]
        public string Url { get; set; }

        /// <summary>
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 8)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// The author responsible for writing the news posting
        /// </summary>
        [Description("The author responsible for writing the news posting")]
        [DataMember(Name = "Author", Order = 9)]
        public string Author { get; set; }

        /// <summary>
        /// Comma delimited meta tags describing the categories of this content. Possible tags include: Top Headlines, Breaking News, Injury, Sit/Start, Waiver Wire, Risers, Fallers, Lineups, Transactions, Free Agents, Prospects/Rookies, Game Recap, Matchup Outlook
        /// </summary>
        [Description("Comma delimited meta tags describing the categories of this content. Possible tags include: Top Headlines, Breaking News, Injury, Sit/Start, Waiver Wire, Risers, Fallers, Lineups, Transactions, Free Agents, Prospects/Rookies, Game Recap, Matchup Outlook")]
        [DataMember(Name = "Categories", Order = 10)]
        public string Categories { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The unique ID of the team that relates to this story
        /// </summary>
        [Description("The unique ID of the team that relates to this story")]
        [DataMember(Name = "TeamID", Order = 12)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that relates to this news story
        /// </summary>
        [Description("The abbreviation [Key] of the team that relates to this news story")]
        [DataMember(Name = "Team", Order = 13)]
        public string Team { get; set; }

        /// <summary>
        /// The PlayerID of the additional player who relates to this story (if applicable)
        /// </summary>
        [Description("The PlayerID of the additional player who relates to this story (if applicable)")]
        [DataMember(Name = "PlayerID2", Order = 14)]
        public int? PlayerID2 { get; set; }

        /// <summary>
        /// The unique ID of the additional team that relates to this news story (if applicable)
        /// </summary>
        [Description("The unique ID of the additional team that relates to this news story (if applicable)")]
        [DataMember(Name = "TeamID2", Order = 15)]
        public int? TeamID2 { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the additional team that relates to this story (if applicable)
        /// </summary>
        [Description("The abbreviation [Key] of the additional team that relates to this story (if applicable)")]
        [DataMember(Name = "Team2", Order = 16)]
        public string Team2 { get; set; }

        /// <summary>
        /// The original source who broke this news (before it was picked up by the publisher of this blurb)
        /// </summary>
        [Description("The original source who broke this news (before it was picked up by the publisher of this blurb)")]
        [DataMember(Name = "OriginalSource", Order = 17)]
        public string OriginalSource { get; set; }

        /// <summary>
        /// The URL of the original source who broke this news blurb
        /// </summary>
        [Description("The URL of the original source who broke this news blurb")]
        [DataMember(Name = "OriginalSourceUrl", Order = 18)]
        public string OriginalSourceUrl { get; set; }

    }
}

