using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="StartingLineups")]
    [Serializable]
    public partial class StartingLineups
    {
        /// <summary>
        /// The unique ID of the game associated with this lineup
        /// </summary>
        [Description("The unique ID of the game associated with this lineup")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The NBA season of the game that the lineups is associated with
        /// </summary>
        [Description("The NBA season of the game that the lineups is associated with")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Date and Time of Game
        /// </summary>
        [Description("Date and Time of Game")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 7)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Unique ID of Away Team
        /// </summary>
        [Description("Unique ID of Away Team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 10)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The lineup (starters and bench players) of the home team in a given game
        /// </summary>
        [Description("The lineup (starters and bench players) of the home team in a given game")]
        [DataMember(Name = "HomeLineup", Order = 20011)]
        public Lineup[] HomeLineup { get; set; }

        /// <summary>
        /// The lineup (starters and bench players) of the away team in a given game
        /// </summary>
        [Description("The lineup (starters and bench players) of the away team in a given game")]
        [DataMember(Name = "AwayLineup", Order = 20012)]
        public Lineup[] AwayLineup { get; set; }

    }
}

