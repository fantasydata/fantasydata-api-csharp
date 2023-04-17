using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="TeamBasic")]
    [Serializable]
    public partial class TeamBasic
    {
        /// <summary>
        /// Abbreviation of the team (e.g. SD, PHI, NE, IND, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. SD, PHI, NE, IND, etc.)")]
        [DataMember(Name = "Key", Order = 1)]
        public string Key { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team.
        /// </summary>
        [Description("The auto-generated unique ID of the Team.")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team, that avoids collisions with PlayerIDs.  This is useful when combining players and fantasy defenses to create fantasy teams.
        /// </summary>
        [Description("The auto-generated unique ID of the Team, that avoids collisions with PlayerIDs.  This is useful when combining players and fantasy defenses to create fantasy teams.")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. San Diego, Philadelphia, New England, Indianapolis, etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. San Diego, Philadelphia, New England, Indianapolis, etc.)")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Chargers, Eagles, Patriots, Colts, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Chargers, Eagles, Patriots, Colts, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (e.g. AFC or NFC)
        /// </summary>
        [Description("The conference of the team (e.g. AFC or NFC)")]
        [DataMember(Name = "Conference", Order = 6)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. East, North, South, West)
        /// </summary>
        [Description("The division of the team (e.g. East, North, South, West)")]
        [DataMember(Name = "Division", Order = 7)]
        public string Division { get; set; }

        /// <summary>
        /// The full name of the team (e.g. New England Patriots)
        /// </summary>
        [Description("The full name of the team (e.g. New England Patriots)")]
        [DataMember(Name = "FullName", Order = 8)]
        public string FullName { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 9)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The bye week of the team in the upcoming regular season
        /// </summary>
        [Description("The bye week of the team in the upcoming regular season")]
        [DataMember(Name = "ByeWeek", Order = 10)]
        public int? ByeWeek { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 11)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The current head coach of the team
        /// </summary>
        [Description("The current head coach of the team")]
        [DataMember(Name = "HeadCoach", Order = 12)]
        public string HeadCoach { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 13)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 14)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 15)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 16)]
        public string QuaternaryColor { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoURL", Order = 17)]
        public string WikipediaLogoURL { get; set; }

        /// <summary>
        /// The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaWordMarkURL", Order = 18)]
        public string WikipediaWordMarkURL { get; set; }

        /// <summary>
        /// The current offensive coordinator of the team
        /// </summary>
        [Description("The current offensive coordinator of the team")]
        [DataMember(Name = "OffensiveCoordinator", Order = 19)]
        public string OffensiveCoordinator { get; set; }

        /// <summary>
        /// The current defensive coordinator of the team
        /// </summary>
        [Description("The current defensive coordinator of the team")]
        [DataMember(Name = "DefensiveCoordinator", Order = 20)]
        public string DefensiveCoordinator { get; set; }

        /// <summary>
        /// The current special teams coach of the team
        /// </summary>
        [Description("The current special teams coach of the team")]
        [DataMember(Name = "SpecialTeamsCoach", Order = 21)]
        public string SpecialTeamsCoach { get; set; }

        /// <summary>
        /// The offensive scheme this team runs (PRO, 2TE, 3WR).  This is decided at our discretion.
        /// </summary>
        [Description("The offensive scheme this team runs (PRO, 2TE, 3WR).  This is decided at our discretion.")]
        [DataMember(Name = "OffensiveScheme", Order = 22)]
        public string OffensiveScheme { get; set; }

        /// <summary>
        /// The current defensive scheme this team runs (3-4, 4-3)
        /// </summary>
        [Description("The current defensive scheme this team runs (3-4, 4-3)")]
        [DataMember(Name = "DefensiveScheme", Order = 23)]
        public string DefensiveScheme { get; set; }

    }
}

