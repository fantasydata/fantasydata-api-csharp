using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="StartingGoaltenders")]
    [Serializable]
    public partial class StartingGoaltenders
    {
        /// <summary>
        /// Unique ID of Game
        /// </summary>
        [Description("Unique ID of Game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// End Year of Season
        /// </summary>
        [Description("End Year of Season")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The Type of Season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The Type of Season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
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
        /// Game Status (ex.  Scheduled, Final, Cancelled)
        /// </summary>
        [Description("Game Status (ex.  Scheduled, Final, Cancelled)")]
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
        /// Information on the Home Team Goaltender
        /// </summary>
        [Description("Information on the Home Team Goaltender")]
        [DataMember(Name = "HomeGoaltender", Order = 10011)]
        public Goaltender HomeGoaltender { get; set; }

        /// <summary>
        /// Information on the Away Team Goaltender
        /// </summary>
        [Description("Information on the Away Team Goaltender")]
        [DataMember(Name = "AwayGoaltender", Order = 10012)]
        public Goaltender AwayGoaltender { get; set; }

    }
}

