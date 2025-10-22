using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// A unique abbreviation of the team (e.g. OAE; TAS; UAD; KAF; etc.)  Note: Due to being selected for uniqueness; these are not always a match with broadcaster abbreviations. For that use case; use ShortDisplayName
        /// </summary>
        [Description("A unique abbreviation of the team (e.g. OAE; TAS; UAD; KAF; etc.)  Note: Due to being selected for uniqueness; these are not always a match with broadcaster abbreviations. For that use case; use ShortDisplayName")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the school as used in college sports (e.g. SMU, South Florida, Stony Brook, UCLA, etc.)
        /// </summary>
        [Description("The name of the school as used in college sports (e.g. SMU, South Florida, Stony Brook, UCLA, etc.)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the stadium that the team plays its home games at
        /// </summary>
        [Description("The unique ID of the stadium that the team plays its home games at")]
        [DataMember(Name = "StadiumID", Order = 6)]
        public int StadiumID { get; set; }

        /// <summary>
        /// The rank of the team assigned to them by the Associated Press (AP)
        /// </summary>
        [Description("The rank of the team assigned to them by the Associated Press (AP)")]
        [DataMember(Name = "ApRank", Order = 7)]
        public int? ApRank { get; set; }

        /// <summary>
        /// Total number of wins by the team
        /// </summary>
        [Description("Total number of wins by the team")]
        [DataMember(Name = "Wins", Order = 8)]
        public int? Wins { get; set; }

        /// <summary>
        /// The total number of losses by the team in the current season
        /// </summary>
        [Description("The total number of losses by the team in the current season")]
        [DataMember(Name = "Losses", Order = 9)]
        public int? Losses { get; set; }

        /// <summary>
        /// The total number of conference wins by the team
        /// </summary>
        [Description("The total number of conference wins by the team")]
        [DataMember(Name = "ConferenceWins", Order = 10)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// The total number of conference losses by the team
        /// </summary>
        [Description("The total number of conference losses by the team")]
        [DataMember(Name = "ConferenceLosses", Order = 11)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 12)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The Coaches Rank of the team
        /// </summary>
        [Description("The Coaches Rank of the team")]
        [DataMember(Name = "CoachesRank", Order = 13)]
        public int? CoachesRank { get; set; }

        /// <summary>
        /// The CFP Rank of the team
        /// </summary>
        [Description("The CFP Rank of the team")]
        [DataMember(Name = "PlayoffRank", Order = 14)]
        public int? PlayoffRank { get; set; }

        /// <summary>
        /// The url of the team logo image
        /// </summary>
        [Description("The url of the team logo image")]
        [DataMember(Name = "TeamLogoUrl", Order = 15)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// The unique ID of the team's conference
        /// </summary>
        [Description("The unique ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 16)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's parent conference (e.g. SEC; Big Ten; etc)
        /// </summary>
        [Description("The name of the team's parent conference (e.g. SEC; Big Ten; etc)")]
        [DataMember(Name = "Conference", Order = 17)]
        public string Conference { get; set; }

        /// <summary>
        /// The shortened name of the team
        /// </summary>
        [Description("The shortened name of the team")]
        [DataMember(Name = "ShortDisplayName", Order = 18)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// The week that the AP Rank/CoachesRank was last updated
        /// </summary>
        [Description("The week that the AP Rank/CoachesRank was last updated")]
        [DataMember(Name = "RankWeek", Order = 19)]
        public int? RankWeek { get; set; }

        /// <summary>
        /// The season that the AP Rank/CoachesRank was last updated
        /// </summary>
        [Description("The season that the AP Rank/CoachesRank was last updated")]
        [DataMember(Name = "RankSeason", Order = 20)]
        public int? RankSeason { get; set; }

        /// <summary>
        /// The season type that the AP Rank/CoachesRank was last updated
        /// </summary>
        [Description("The season type that the AP Rank/CoachesRank was last updated")]
        [DataMember(Name = "RankSeasonType", Order = 21)]
        public int? RankSeasonType { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 22)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 23)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 24)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 25)]
        public string QuaternaryColor { get; set; }

    }
}

