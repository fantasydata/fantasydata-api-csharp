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
        /// The unique ID of the news story
        /// </summary>
        [Description("The unique ID of the news story")]
        [DataMember(Name = "NewsID", Order = 1)]
        public int NewsID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The title of the news story
        /// </summary>
        [Description("The title of the news story")]
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
        /// The source of the story (RotoBaller, NBCSports.com, etc.)
        /// </summary>
        [Description("The source of the story (RotoBaller, NBCSports.com, etc.)")]
        [DataMember(Name = "Source", Order = 8)]
        public string Source { get; set; }

        /// <summary>
        /// The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use
        /// </summary>
        [Description("The terms of use with using this news item, credit must be given to the originator of the story when specified in the terms of use")]
        [DataMember(Name = "TermsOfUse", Order = 9)]
        public string TermsOfUse { get; set; }

        /// <summary>
        /// The timestamp of when the news story was last updated
        /// </summary>
        [Description("The timestamp of when the news story was last updated")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// A description of how long ago this content was published
        /// </summary>
        [Description("A description of how long ago this content was published")]
        [DataMember(Name = "TimeAgo", Order = 11)]
        public string TimeAgo { get; set; }

    }
}

