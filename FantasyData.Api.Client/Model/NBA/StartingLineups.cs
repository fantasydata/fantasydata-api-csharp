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
        /// Unique ID of Game
        /// </summary>
        [Description("Unique ID of Game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// End year of season that this game belongs to
        /// </summary>
        [Description("End year of season that this game belongs to")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// Type of Season that this game corresponds to (eg. 1 = Regular Season, 2 = Preseason, 3 = Postseason)
        /// </summary>
        [Description("Type of Season that this game corresponds to (eg. 1 = Regular Season, 2 = Preseason, 3 = Postseason)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Day of Game
        /// </summary>
        [Description("Day of Game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Date and Time of Game
        /// </summary>
        [Description("Date and Time of Game")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Game Status (eg.  Scheduled, Final, Cancelled)
        /// </summary>
        [Description("Game Status (eg.  Scheduled, Final, Cancelled)")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// Unique ID of Home Team
        /// </summary>
        [Description("Unique ID of Home Team")]
        [DataMember(Name = "HomeTeamID", Order = 7)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// Name of Home Team
        /// </summary>
        [Description("Name of Home Team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Unique ID of Away Team
        /// </summary>
        [Description("Unique ID of Away Team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// Name of Away Team
        /// </summary>
        [Description("Name of Away Team")]
        [DataMember(Name = "AwayTeam", Order = 10)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Home Team Lineup, including Starters and Bench Players
        /// </summary>
        [Description("Home Team Lineup, including Starters and Bench Players")]
        [DataMember(Name = "HomeLineup", Order = 20011)]
        public Lineup[] HomeLineup { get; set; }

        /// <summary>
        /// Away Team Lineup, including Starters and Bench Players
        /// </summary>
        [Description("Away Team Lineup, including Starters and Bench Players")]
        [DataMember(Name = "AwayLineup", Order = 20012)]
        public Lineup[] AwayLineup { get; set; }

    }
}

