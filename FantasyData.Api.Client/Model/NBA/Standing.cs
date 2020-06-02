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
        /// The NBA regular season for which these totals apply
        /// </summary>
        [Description("The NBA regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The unique ID for the team
        /// </summary>
        [Description("The unique ID for the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// Whether or not the team is active
        /// </summary>
        [Description("Whether or not the team is active")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The name of the city
        /// </summary>
        [Description("The name of the city")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (Eastern or Western)
        /// </summary>
        [Description("The conference of the team (Eastern or Western)")]
        [DataMember(Name = "Conference", Order = 7)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. Atlantic, Central, Southeast, etc.)
        /// </summary>
        [Description("The division of the team (e.g. Atlantic, Central, Southeast, etc.)")]
        [DataMember(Name = "Division", Order = 8)]
        public string Division { get; set; }

        /// <summary>
        /// Regular season wins
        /// </summary>
        [Description("Regular season wins")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Regular season losses
        /// </summary>
        [Description("Regular season losses")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Winning percentage
        /// </summary>
        [Description("Winning percentage")]
        [DataMember(Name = "Percentage", Order = 11)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Regular season conference wins
        /// </summary>
        [Description("Regular season conference wins")]
        [DataMember(Name = "ConferenceWins", Order = 12)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// Regular season conference losses
        /// </summary>
        [Description("Regular season conference losses")]
        [DataMember(Name = "ConferenceLosses", Order = 13)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// Regular season division wins
        /// </summary>
        [Description("Regular season division wins")]
        [DataMember(Name = "DivisionWins", Order = 14)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Regular season division losses
        /// </summary>
        [Description("Regular season division losses")]
        [DataMember(Name = "DivisionLosses", Order = 15)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Regular season wins at home
        /// </summary>
        [Description("Regular season wins at home")]
        [DataMember(Name = "HomeWins", Order = 16)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Regular season losses at home
        /// </summary>
        [Description("Regular season losses at home")]
        [DataMember(Name = "HomeLosses", Order = 17)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Regular season wins on the road
        /// </summary>
        [Description("Regular season wins on the road")]
        [DataMember(Name = "AwayWins", Order = 18)]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Regular season losses on the road
        /// </summary>
        [Description("Regular season losses on the road")]
        [DataMember(Name = "AwayLosses", Order = 19)]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Regular season wins in last 10 games
        /// </summary>
        [Description("Regular season wins in last 10 games")]
        [DataMember(Name = "LastTenWins", Order = 20)]
        public int? LastTenWins { get; set; }

        /// <summary>
        /// Regular season losses in last 10 games
        /// </summary>
        [Description("Regular season losses in last 10 games")]
        [DataMember(Name = "LastTenLosses", Order = 21)]
        public int? LastTenLosses { get; set; }

        /// <summary>
        /// Average Points Scored
        /// </summary>
        [Description("Average Points Scored")]
        [DataMember(Name = "PointsPerGameFor", Order = 22)]
        public decimal? PointsPerGameFor { get; set; }

        /// <summary>
        /// Average Points Scored Against
        /// </summary>
        [Description("Average Points Scored Against")]
        [DataMember(Name = "PointsPerGameAgainst", Order = 23)]
        public decimal? PointsPerGameAgainst { get; set; }

        /// <summary>
        /// Winning or Losing Streak
        /// </summary>
        [Description("Winning or Losing Streak")]
        [DataMember(Name = "Streak", Order = 24)]
        public int? Streak { get; set; }

        /// <summary>
        /// Games behind the leader
        /// </summary>
        [Description("Games behind the leader")]
        [DataMember(Name = "GamesBack", Order = 25)]
        public decimal? GamesBack { get; set; }

        /// <summary>
        /// Winning or Losing Streak written in the form W5 or L1
        /// </summary>
        [Description("Winning or Losing Streak written in the form W5 or L1")]
        [DataMember(Name = "StreakDescription", Order = 26)]
        public string StreakDescription { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 27)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Team rank within the Conference level
        /// </summary>
        [Description("Team rank within the Conference level")]
        [DataMember(Name = "ConferenceRank", Order = 28)]
        public int? ConferenceRank { get; set; }

        /// <summary>
        /// Team rank within the Division level
        /// </summary>
        [Description("Team rank within the Division level")]
        [DataMember(Name = "DivisionRank", Order = 29)]
        public int? DivisionRank { get; set; }

    }
}

