using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The NBA season that these totals apply for
        /// </summary>
        [Description("The NBA season that these totals apply for")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The unique ID for the team
        /// </summary>
        [Description("The unique ID for the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// The key (short team name) of the team
        /// </summary>
        [Description("The key (short team name) of the team")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The team's full name
        /// </summary>
        [Description("The team's full name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (can either be Eastern or Western)
        /// </summary>
        [Description("The conference of the team (can either be Eastern or Western)")]
        [DataMember(Name = "Conference", Order = 7)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. Atlantic, Central, Southeast, etc.)
        /// </summary>
        [Description("The division of the team (e.g. Atlantic, Central, Southeast, etc.)")]
        [DataMember(Name = "Division", Order = 8)]
        public string Division { get; set; }

        /// <summary>
        /// Total wins by the team
        /// </summary>
        [Description("Total wins by the team")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total losses by the team
        /// </summary>
        [Description("Total losses by the team")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// The team's winning percentage
        /// </summary>
        [Description("The team's winning percentage")]
        [DataMember(Name = "Percentage", Order = 11)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Total conference wins
        /// </summary>
        [Description("Total conference wins")]
        [DataMember(Name = "ConferenceWins", Order = 12)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// Total conference losses
        /// </summary>
        [Description("Total conference losses")]
        [DataMember(Name = "ConferenceLosses", Order = 13)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// Total number of division wins
        /// </summary>
        [Description("Total number of division wins")]
        [DataMember(Name = "DivisionWins", Order = 14)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Total number of division losses
        /// </summary>
        [Description("Total number of division losses")]
        [DataMember(Name = "DivisionLosses", Order = 15)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Total number of home game wins
        /// </summary>
        [Description("Total number of home game wins")]
        [DataMember(Name = "HomeWins", Order = 16)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Total number of home game losses
        /// </summary>
        [Description("Total number of home game losses")]
        [DataMember(Name = "HomeLosses", Order = 17)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Total number of away game wins
        /// </summary>
        [Description("Total number of away game wins")]
        [DataMember(Name = "AwayWins", Order = 18)]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Total number of away game losses
        /// </summary>
        [Description("Total number of away game losses")]
        [DataMember(Name = "AwayLosses", Order = 19)]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Total wins in the last 10 games
        /// </summary>
        [Description("Total wins in the last 10 games")]
        [DataMember(Name = "LastTenWins", Order = 20)]
        public int? LastTenWins { get; set; }

        /// <summary>
        /// Total losses in the last 10 games
        /// </summary>
        [Description("Total losses in the last 10 games")]
        [DataMember(Name = "LastTenLosses", Order = 21)]
        public int? LastTenLosses { get; set; }

        /// <summary>
        /// Average points scored by the team per game
        /// </summary>
        [Description("Average points scored by the team per game")]
        [DataMember(Name = "PointsPerGameFor", Order = 22)]
        public decimal? PointsPerGameFor { get; set; }

        /// <summary>
        /// Average points scored against the team per game
        /// </summary>
        [Description("Average points scored against the team per game")]
        [DataMember(Name = "PointsPerGameAgainst", Order = 23)]
        public decimal? PointsPerGameAgainst { get; set; }

        /// <summary>
        /// Total games that the streak (winning or losing) has lasted
        /// </summary>
        [Description("Total games that the streak (winning or losing) has lasted")]
        [DataMember(Name = "Streak", Order = 24)]
        public int? Streak { get; set; }

        /// <summary>
        /// Total number of games behind the top ranked team for a given team
        /// </summary>
        [Description("Total number of games behind the top ranked team for a given team")]
        [DataMember(Name = "GamesBack", Order = 25)]
        public decimal? GamesBack { get; set; }

        /// <summary>
        /// The winning or losing streak written in the form W5 or L1
        /// </summary>
        [Description("The winning or losing streak written in the form W5 or L1")]
        [DataMember(Name = "StreakDescription", Order = 26)]
        public string StreakDescription { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 27)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Team rank at the conference level
        /// </summary>
        [Description("Team rank at the conference level")]
        [DataMember(Name = "ConferenceRank", Order = 28)]
        public int? ConferenceRank { get; set; }

        /// <summary>
        /// Team rank at the division level
        /// </summary>
        [Description("Team rank at the division level")]
        [DataMember(Name = "DivisionRank", Order = 29)]
        public int? DivisionRank { get; set; }

    }
}

