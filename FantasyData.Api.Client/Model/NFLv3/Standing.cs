using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season for which these totals apply
        /// </summary>
        [Description("The NFL season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The conference of the team (e.g. AFC or NFC)
        /// </summary>
        [Description("The conference of the team (e.g. AFC or NFC)")]
        [DataMember(Name = "Conference", Order = 3)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. East; North; South; West)
        /// </summary>
        [Description("The division of the team (e.g. East; North; South; West)")]
        [DataMember(Name = "Division", Order = 4)]
        public string Division { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// Total number of wins by the team in the season
        /// </summary>
        [Description("Total number of wins by the team in the season")]
        [DataMember(Name = "Wins", Order = 7)]
        public int Wins { get; set; }

        /// <summary>
        /// Regular season losses by the team
        /// </summary>
        [Description("Regular season losses by the team")]
        [DataMember(Name = "Losses", Order = 8)]
        public int Losses { get; set; }

        /// <summary>
        /// Total ties by the team
        /// </summary>
        [Description("Total ties by the team")]
        [DataMember(Name = "Ties", Order = 9)]
        public int Ties { get; set; }

        /// <summary>
        /// The winning percentage of the team in the season
        /// </summary>
        [Description("The winning percentage of the team in the season")]
        [DataMember(Name = "Percentage", Order = 10)]
        public decimal Percentage { get; set; }

        /// <summary>
        /// Total points scored by the team in the season
        /// </summary>
        [Description("Total points scored by the team in the season")]
        [DataMember(Name = "PointsFor", Order = 11)]
        public int PointsFor { get; set; }

        /// <summary>
        /// Total points allowed by the team during the season
        /// </summary>
        [Description("Total points allowed by the team during the season")]
        [DataMember(Name = "PointsAgainst", Order = 12)]
        public int PointsAgainst { get; set; }

        /// <summary>
        /// Difference between PointsFor and PointsAgainst for the team
        /// </summary>
        [Description("Difference between PointsFor and PointsAgainst for the team")]
        [DataMember(Name = "NetPoints", Order = 13)]
        public int NetPoints { get; set; }

        /// <summary>
        /// Total touchdowns scored by the team
        /// </summary>
        [Description("Total touchdowns scored by the team")]
        [DataMember(Name = "Touchdowns", Order = 14)]
        public int? Touchdowns { get; set; }

        /// <summary>
        /// Regular season wins within the division by the team
        /// </summary>
        [Description("Regular season wins within the division by the team")]
        [DataMember(Name = "DivisionWins", Order = 15)]
        public int DivisionWins { get; set; }

        /// <summary>
        /// Regular season losses within the division by the team
        /// </summary>
        [Description("Regular season losses within the division by the team")]
        [DataMember(Name = "DivisionLosses", Order = 16)]
        public int DivisionLosses { get; set; }

        /// <summary>
        /// Regular season wins within the conference by the team
        /// </summary>
        [Description("Regular season wins within the conference by the team")]
        [DataMember(Name = "ConferenceWins", Order = 17)]
        public int ConferenceWins { get; set; }

        /// <summary>
        /// Regular season losses within the conference by the team
        /// </summary>
        [Description("Regular season losses within the conference by the team")]
        [DataMember(Name = "ConferenceLosses", Order = 18)]
        public int ConferenceLosses { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 19)]
        public int TeamID { get; set; }

        /// <summary>
        /// Regular season ties within the division by the team
        /// </summary>
        [Description("Regular season ties within the division by the team")]
        [DataMember(Name = "DivisionTies", Order = 20)]
        public int DivisionTies { get; set; }

        /// <summary>
        /// Regular season ties within the conference by the team
        /// </summary>
        [Description("Regular season ties within the conference by the team")]
        [DataMember(Name = "ConferenceTies", Order = 21)]
        public int ConferenceTies { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 22)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Team's rank within the division
        /// </summary>
        [Description("Team's rank within the division")]
        [DataMember(Name = "DivisionRank", Order = 23)]
        public int DivisionRank { get; set; }

        /// <summary>
        /// Team's rank within the conference
        /// </summary>
        [Description("Team's rank within the conference")]
        [DataMember(Name = "ConferenceRank", Order = 24)]
        public int ConferenceRank { get; set; }

        /// <summary>
        /// Home wins for the team
        /// </summary>
        [Description("Home wins for the team")]
        [DataMember(Name = "HomeWins", Order = 25)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Home losses for the team
        /// </summary>
        [Description("Home losses for the team")]
        [DataMember(Name = "HomeLosses", Order = 26)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Home ties for the team
        /// </summary>
        [Description("Home ties for the team")]
        [DataMember(Name = "HomeTies", Order = 27)]
        public int? HomeTies { get; set; }

        /// <summary>
        /// Away wins for the team
        /// </summary>
        [Description("Away wins for the team")]
        [DataMember(Name = "AwayWins", Order = 28)]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Away losses for the team
        /// </summary>
        [Description("Away losses for the team")]
        [DataMember(Name = "AwayLosses", Order = 29)]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Away ties for the team
        /// </summary>
        [Description("Away ties for the team")]
        [DataMember(Name = "AwayTies", Order = 30)]
        public int? AwayTies { get; set; }

        /// <summary>
        /// The current winning or losing streak for this team (negative numbers represent losing streaks).
        /// </summary>
        [Description("The current winning or losing streak for this team (negative numbers represent losing streaks).")]
        [DataMember(Name = "Streak", Order = 31)]
        public int? Streak { get; set; }

    }
}

