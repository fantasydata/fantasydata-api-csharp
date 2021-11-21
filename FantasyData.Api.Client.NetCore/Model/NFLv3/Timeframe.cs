using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="Timeframe")]
    [Serializable]
    public partial class Timeframe
    {
        /// <summary>
        /// The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason)
        /// </summary>
        [Description("The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason)")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The league year of the timeframe (this gets incremented on the first day of the league year during free agency)
        /// </summary>
        [Description("The league year of the timeframe (this gets incremented on the first day of the league year during free agency)")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The week of the timeframe (Regular Season=1 to 17, Preseason=1 to 4, Postseason=1 to4, Offseason=NULL)
        /// </summary>
        [Description("The week of the timeframe (Regular Season=1 to 17, Preseason=1 to 4, Postseason=1 to4, Offseason=NULL)")]
        [DataMember(Name = "Week", Order = 3)]
        public int? Week { get; set; }

        /// <summary>
        /// The friendly name of the Timeframe
        /// </summary>
        [Description("The friendly name of the Timeframe")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The shorter name of the Timeframe
        /// </summary>
        [Description("The shorter name of the Timeframe")]
        [DataMember(Name = "ShortName", Order = 5)]
        public string ShortName { get; set; }

        /// <summary>
        /// The start date/time of this Timeframe
        /// </summary>
        [Description("The start date/time of this Timeframe")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date/time of the Timeframe
        /// </summary>
        [Description("The end date/time of the Timeframe")]
        [DataMember(Name = "EndDate", Order = 7)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The start date/time of the first game of the Timeframe (if no games then returns the StartDate)
        /// </summary>
        [Description("The start date/time of the first game of the Timeframe (if no games then returns the StartDate)")]
        [DataMember(Name = "FirstGameStart", Order = 8)]
        public DateTime? FirstGameStart { get; set; }

        /// <summary>
        /// The end date/time of the first game of the Timeframe (if no games then returns the EndDate)
        /// </summary>
        [Description("The end date/time of the first game of the Timeframe (if no games then returns the EndDate)")]
        [DataMember(Name = "FirstGameEnd", Order = 9)]
        public DateTime? FirstGameEnd { get; set; }

        /// <summary>
        /// The end date/time of the last game of the Timeframe (if no games then returns the EndDate)
        /// </summary>
        [Description("The end date/time of the last game of the Timeframe (if no games then returns the EndDate)")]
        [DataMember(Name = "LastGameEnd", Order = 10)]
        public DateTime? LastGameEnd { get; set; }

        /// <summary>
        /// Whether there are any games in this Timeframe
        /// </summary>
        [Description("Whether there are any games in this Timeframe")]
        [DataMember(Name = "HasGames", Order = 11)]
        public bool HasGames { get; set; }

        /// <summary>
        /// Whether this Timeframe has started
        /// </summary>
        [Description("Whether this Timeframe has started")]
        [DataMember(Name = "HasStarted", Order = 12)]
        public bool HasStarted { get; set; }

        /// <summary>
        /// Whether this Timeframe has ended
        /// </summary>
        [Description("Whether this Timeframe has ended")]
        [DataMember(Name = "HasEnded", Order = 13)]
        public bool HasEnded { get; set; }

        /// <summary>
        /// Whether the first game has started
        /// </summary>
        [Description("Whether the first game has started")]
        [DataMember(Name = "HasFirstGameStarted", Order = 14)]
        public bool HasFirstGameStarted { get; set; }

        /// <summary>
        /// Whether the first game has ended
        /// </summary>
        [Description("Whether the first game has ended")]
        [DataMember(Name = "HasFirstGameEnded", Order = 15)]
        public bool HasFirstGameEnded { get; set; }

        /// <summary>
        /// Whether the last game has ended
        /// </summary>
        [Description("Whether the last game has ended")]
        [DataMember(Name = "HasLastGameEnded", Order = 16)]
        public bool HasLastGameEnded { get; set; }

        /// <summary>
        /// The value of the Season parameter used to pass into the API.
        /// </summary>
        [Description("The value of the Season parameter used to pass into the API.")]
        [DataMember(Name = "ApiSeason", Order = 17)]
        public string ApiSeason { get; set; }

        /// <summary>
        /// The value of the Week parameter used to pass into the API.
        /// </summary>
        [Description("The value of the Week parameter used to pass into the API.")]
        [DataMember(Name = "ApiWeek", Order = 18)]
        public string ApiWeek { get; set; }

    }
}

