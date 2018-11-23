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
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL regular season for which these totals apply
        /// </summary>
        [Description("The NFL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The conference of the team (e.g. AFC or NFC)
        /// </summary>
        [Description("The conference of the team (e.g. AFC or NFC)")]
        [DataMember(Name = "Conference", Order = 3)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. East, North, South, West)
        /// </summary>
        [Description("The division of the team (e.g. East, North, South, West)")]
        [DataMember(Name = "Division", Order = 4)]
        public string Division { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// Regular season wins
        /// </summary>
        [Description("Regular season wins")]
        [DataMember(Name = "Wins", Order = 7)]
        public int Wins { get; set; }

        /// <summary>
        /// Regular season losses
        /// </summary>
        [Description("Regular season losses")]
        [DataMember(Name = "Losses", Order = 8)]
        public int Losses { get; set; }

        /// <summary>
        /// Regular season ties
        /// </summary>
        [Description("Regular season ties")]
        [DataMember(Name = "Ties", Order = 9)]
        public int Ties { get; set; }

        /// <summary>
        /// Winning percentage
        /// </summary>
        [Description("Winning percentage")]
        [DataMember(Name = "Percentage", Order = 10)]
        public decimal Percentage { get; set; }

        /// <summary>
        /// Points scored during regular season games
        /// </summary>
        [Description("Points scored during regular season games")]
        [DataMember(Name = "PointsFor", Order = 11)]
        public int PointsFor { get; set; }

        /// <summary>
        /// Points allowed during regular season games
        /// </summary>
        [Description("Points allowed during regular season games")]
        [DataMember(Name = "PointsAgainst", Order = 12)]
        public int PointsAgainst { get; set; }

        /// <summary>
        /// Difference between PointsFor and PointsAgainst
        /// </summary>
        [Description("Difference between PointsFor and PointsAgainst")]
        [DataMember(Name = "NetPoints", Order = 13)]
        public int NetPoints { get; set; }

        /// <summary>
        /// Total touchdowns scored
        /// </summary>
        [Description("Total touchdowns scored")]
        [DataMember(Name = "Touchdowns", Order = 14)]
        public int? Touchdowns { get; set; }

        /// <summary>
        /// Regular season wins within the division
        /// </summary>
        [Description("Regular season wins within the division")]
        [DataMember(Name = "DivisionWins", Order = 15)]
        public int DivisionWins { get; set; }

        /// <summary>
        /// Regular season losses within the division
        /// </summary>
        [Description("Regular season losses within the division")]
        [DataMember(Name = "DivisionLosses", Order = 16)]
        public int DivisionLosses { get; set; }

        /// <summary>
        /// Regular season wins within the conference
        /// </summary>
        [Description("Regular season wins within the conference")]
        [DataMember(Name = "ConferenceWins", Order = 17)]
        public int ConferenceWins { get; set; }

        /// <summary>
        /// Regular season losses within the conference
        /// </summary>
        [Description("Regular season losses within the conference")]
        [DataMember(Name = "ConferenceLosses", Order = 18)]
        public int ConferenceLosses { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 19)]
        public int TeamID { get; set; }

        /// <summary>
        /// Regular season ties within the division
        /// </summary>
        [Description("Regular season ties within the division")]
        [DataMember(Name = "DivisionTies", Order = 20)]
        public int DivisionTies { get; set; }

        /// <summary>
        /// Regular season ties within the conference
        /// </summary>
        [Description("Regular season ties within the conference")]
        [DataMember(Name = "ConferenceTies", Order = 21)]
        public int ConferenceTies { get; set; }

    }
}

