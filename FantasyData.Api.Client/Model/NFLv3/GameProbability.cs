using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="GameProbability")]
    [Serializable]
    public partial class GameProbability
    {
        /// <summary>
        /// Unique ID of the Score/Game
        /// </summary>
        [Description("Unique ID of the Score/Game")]
        [DataMember(Name = "ScoreID", Order = 1)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 6)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 7)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out")]
        [DataMember(Name = "Closed", Order = 8)]
        public bool? Closed { get; set; }

        /// <summary>
        /// The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "TimeRemaining", Order = 9)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)
        /// </summary>
        [Description("The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)")]
        [DataMember(Name = "Quarter", Order = 10)]
        public string Quarter { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 11)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team 
        /// </summary>
        [Description("The unique ID of the home team ")]
        [DataMember(Name = "HomeTeamID", Order = 12)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The score of the Away Team
        /// </summary>
        [Description("The score of the Away Team")]
        [DataMember(Name = "AwayScore", Order = 15)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The score of the Home Team
        /// </summary>
        [Description("The score of the Home Team")]
        [DataMember(Name = "HomeScore", Order = 16)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// The collection of win probabilities for this game
        /// </summary>
        [Description("The collection of win probabilities for this game")]
        [DataMember(Name = "WinProbabilities", Order = 20017)]
        public WinProbability[] WinProbabilities { get; set; }

    }
}

