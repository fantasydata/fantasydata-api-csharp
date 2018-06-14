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
        /// The MLB regular season for which these totals apply
        /// </summary>
        [Description("The MLB regular season for which these totals apply")]
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
        /// The league of the team (e.g. American or National)
        /// </summary>
        [Description("The league of the team (e.g. American or National)")]
        [DataMember(Name = "League", Order = 7)]
        public string League { get; set; }

        /// <summary>
        /// The division of the team (e.g. East, Central, West)
        /// </summary>
        [Description("The division of the team (e.g. East, Central, West)")]
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
        /// Regular season wins within the division
        /// </summary>
        [Description("Regular season wins within the division")]
        [DataMember(Name = "DivisionWins", Order = 12)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Regular season losses within the division
        /// </summary>
        [Description("Regular season losses within the division")]
        [DataMember(Name = "DivisionLosses", Order = 13)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Number of games behind the first place team
        /// </summary>
        [Description("Number of games behind the first place team")]
        [DataMember(Name = "GamesBehind", Order = 14)]
        public decimal? GamesBehind { get; set; }

        /// <summary>
        /// Number of wins in the last ten games
        /// </summary>
        [Description("Number of wins in the last ten games")]
        [DataMember(Name = "LastTenGamesWins", Order = 15)]
        public int? LastTenGamesWins { get; set; }

        /// <summary>
        /// Number of losses in the last ten games
        /// </summary>
        [Description("Number of losses in the last ten games")]
        [DataMember(Name = "LastTenGamesLosses", Order = 16)]
        public int? LastTenGamesLosses { get; set; }

        /// <summary>
        /// Current streak the team is on (e.g. Win 3, Lost 3)
        /// </summary>
        [Description("Current streak the team is on (e.g. Win 3, Lost 3)")]
        [DataMember(Name = "Streak", Order = 17)]
        public string Streak { get; set; }

        /// <summary>
        /// The ranking in the wild card
        /// </summary>
        [Description("The ranking in the wild card")]
        [DataMember(Name = "WildCardRank", Order = 18)]
        public int? WildCardRank { get; set; }

        /// <summary>
        /// Number of games behind the team leading the wild card
        /// </summary>
        [Description("Number of games behind the team leading the wild card")]
        [DataMember(Name = "WildCardGamesBehind", Order = 19)]
        public decimal? WildCardGamesBehind { get; set; }

        /// <summary>
        /// Number of home wins
        /// </summary>
        [Description("Number of home wins")]
        [DataMember(Name = "HomeWins", Order = 20)]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Number of home losses
        /// </summary>
        [Description("Number of home losses")]
        [DataMember(Name = "HomeLosses", Order = 21)]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Number of away wins
        /// </summary>
        [Description("Number of away wins")]
        [DataMember(Name = "AwayWins", Order = 22)]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Number of away losses
        /// </summary>
        [Description("Number of away losses")]
        [DataMember(Name = "AwayLosses", Order = 23)]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Number of wins during the day
        /// </summary>
        [Description("Number of wins during the day")]
        [DataMember(Name = "DayWins", Order = 24)]
        public int? DayWins { get; set; }

        /// <summary>
        /// Number of losses during the day
        /// </summary>
        [Description("Number of losses during the day")]
        [DataMember(Name = "DayLosses", Order = 25)]
        public int? DayLosses { get; set; }

        /// <summary>
        /// Number of wins at night
        /// </summary>
        [Description("Number of wins at night")]
        [DataMember(Name = "NightWins", Order = 26)]
        public int? NightWins { get; set; }

        /// <summary>
        /// Number of losses at night
        /// </summary>
        [Description("Number of losses at night")]
        [DataMember(Name = "NightLosses", Order = 27)]
        public int? NightLosses { get; set; }

        /// <summary>
        /// Number of runs scored
        /// </summary>
        [Description("Number of runs scored")]
        [DataMember(Name = "RunsScored", Order = 28)]
        public int? RunsScored { get; set; }

        /// <summary>
        /// Number of runs scored by opponents
        /// </summary>
        [Description("Number of runs scored by opponents")]
        [DataMember(Name = "RunsAgainst", Order = 29)]
        public int? RunsAgainst { get; set; }

    }
}

