using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The MLB season for which these totals apply
        /// </summary>
        [Description("The MLB season for which these totals apply")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// Abbreviation of the team (e.g. LAD; PHI; BOS; CHC; etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. LAD; PHI; BOS; CHC; etc.)")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// Team's full name (city and mascot)
        /// </summary>
        [Description("Team's full name (city and mascot)")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The league of the team (possible values: AL; NL)
        /// </summary>
        [Description("The league of the team (possible values: AL; NL)")]
        [DataMember(Name = "League", Order = 7)]
        public string League { get; set; }

        /// <summary>
        /// The division of the team (e.g. East, Central, West)
        /// </summary>
        [Description("The division of the team (e.g. East, Central, West)")]
        [DataMember(Name = "Division", Order = 8)]
        public string Division { get; set; }

        /// <summary>
        /// The total number of wins by a team in the season
        /// </summary>
        [Description("The total number of wins by a team in the season")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total number of losses by the team in the season
        /// </summary>
        [Description("Total number of losses by the team in the season")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Winning percentage of a team
        /// </summary>
        [Description("Winning percentage of a team")]
        [DataMember(Name = "Percentage", Order = 11)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Total number of division wins in the season
        /// </summary>
        [Description("Total number of division wins in the season")]
        [DataMember(Name = "DivisionWins", Order = 12)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Total number of division losses in a season
        /// </summary>
        [Description("Total number of division losses in a season")]
        [DataMember(Name = "DivisionLosses", Order = 13)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Number of games behind the first place team
        /// </summary>
        [Description("Number of games behind the first place team")]
        [DataMember(Name = "GamesBehind", Order = 14)]
        public decimal? GamesBehind { get; set; }

        /// <summary>
        /// Total number of wins in the last ten games
        /// </summary>
        [Description("Total number of wins in the last ten games")]
        [DataMember(Name = "LastTenGamesWins", Order = 15)]
        public int? LastTenGamesWins { get; set; }

        /// <summary>
        /// Total number of losses in the last ten games
        /// </summary>
        [Description("Total number of losses in the last ten games")]
        [DataMember(Name = "LastTenGamesLosses", Order = 16)]
        public int? LastTenGamesLosses { get; set; }

        /// <summary>
        /// Current streak the team is on (e.g. Win 3, Lost 3)
        /// </summary>
        [Description("Current streak the team is on (e.g. Win 3, Lost 3)")]
        [DataMember(Name = "Streak", Order = 17)]
        public string Streak { get; set; }

        /// <summary>
        /// The ranking in the league
        /// </summary>
        [Description("The ranking in the league")]
        [DataMember(Name = "LeagueRank", Order = 18)]
        public int? LeagueRank { get; set; }

        /// <summary>
        /// The ranking in the division (e.g. 1, 2, 3, 4, 5)
        /// </summary>
        [Description("The ranking in the division (e.g. 1, 2, 3, 4, 5)")]
        [DataMember(Name = "DivisionRank", Order = 19)]
        public int? DivisionRank { get; set; }

        /// <summary>
        /// The rank of the team in terms of Wild Card standings only
        /// </summary>
        [Description("The rank of the team in terms of Wild Card standings only")]
        [DataMember(Name = "WildCardRank", Order = 20)]
        public int? WildCardRank { get; set; }

        /// <summary>
        /// The number of games behind a team is of the final Wild Card spot
        /// </summary>
        [Description("The number of games behind a team is of the final Wild Card spot")]
        [DataMember(Name = "WildCardGamesBehind", Order = 21)]
        public decimal? WildCardGamesBehind { get; set; }

        /// <summary>
        /// Total number of home wins in the season
        /// </summary>
        [Description("Total number of home wins in the season")]
        [DataMember(Name = "HomeWins", Order = 22)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Total number of home losses in the season
        /// </summary>
        [Description("Total number of home losses in the season")]
        [DataMember(Name = "HomeLosses", Order = 23)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Total number of away wins in the season
        /// </summary>
        [Description("Total number of away wins in the season")]
        [DataMember(Name = "AwayWins", Order = 24)]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Total number of away losses in the season
        /// </summary>
        [Description("Total number of away losses in the season")]
        [DataMember(Name = "AwayLosses", Order = 25)]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Total number of wins in daytime games
        /// </summary>
        [Description("Total number of wins in daytime games")]
        [DataMember(Name = "DayWins", Order = 26)]
        public int? DayWins { get; set; }

        /// <summary>
        /// Total number of losses in daytime games
        /// </summary>
        [Description("Total number of losses in daytime games")]
        [DataMember(Name = "DayLosses", Order = 27)]
        public int? DayLosses { get; set; }

        /// <summary>
        /// Total number of wins in nighttime games
        /// </summary>
        [Description("Total number of wins in nighttime games")]
        [DataMember(Name = "NightWins", Order = 28)]
        public int? NightWins { get; set; }

        /// <summary>
        /// Total number of losses in nighttime games
        /// </summary>
        [Description("Total number of losses in nighttime games")]
        [DataMember(Name = "NightLosses", Order = 29)]
        public int? NightLosses { get; set; }

        /// <summary>
        /// Total runs scored by the team in the season
        /// </summary>
        [Description("Total runs scored by the team in the season")]
        [DataMember(Name = "RunsScored", Order = 30)]
        public int? RunsScored { get; set; }

        /// <summary>
        /// Total number of runs scored by the opponents of a specified team
        /// </summary>
        [Description("Total number of runs scored by the opponents of a specified team")]
        [DataMember(Name = "RunsAgainst", Order = 31)]
        public int? RunsAgainst { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 32)]
        public int? GlobalTeamID { get; set; }

    }
}

