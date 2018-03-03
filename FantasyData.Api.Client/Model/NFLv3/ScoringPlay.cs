using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="ScoringPlay")]
    [Serializable]
    public partial class ScoringPlay
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Unique id of the scoring play
        /// </summary>
        [Description("Unique id of the scoring play")]
        [DataMember(Name = "ScoringPlayID", Order = 3)]
        public int ScoringPlayID { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 5)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation of the away team
        /// </summary>
        [Description("The abbreviation of the away team")]
        [DataMember(Name = "AwayTeam", Order = 6)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the home team
        /// </summary>
        [Description("The abbreviation of the home team")]
        [DataMember(Name = "HomeTeam", Order = 7)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The order in which the scoring play happened
        /// </summary>
        [Description("The order in which the scoring play happened")]
        [DataMember(Name = "Sequence", Order = 9)]
        public int? Sequence { get; set; }

        /// <summary>
        /// The abbreviation of the team that scored
        /// </summary>
        [Description("The abbreviation of the team that scored")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

        /// <summary>
        /// The quarter that the score occurred in
        /// </summary>
        [Description("The quarter that the score occurred in")]
        [DataMember(Name = "Quarter", Order = 11)]
        public string Quarter { get; set; }

        /// <summary>
        /// The time remaining in the quarter when the score occurred
        /// </summary>
        [Description("The time remaining in the quarter when the score occurred")]
        [DataMember(Name = "TimeRemaining", Order = 12)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// The detailed description of the play for display purposes
        /// </summary>
        [Description("The detailed description of the play for display purposes")]
        [DataMember(Name = "PlayDescription", Order = 13)]
        public string PlayDescription { get; set; }

        /// <summary>
        /// The away team's score as a result of the scoring play (includes point after)
        /// </summary>
        [Description("The away team's score as a result of the scoring play (includes point after)")]
        [DataMember(Name = "AwayScore", Order = 14)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The home team's score as a result of the scoring play (includes point after)
        /// </summary>
        [Description("The home team's score as a result of the scoring play (includes point after)")]
        [DataMember(Name = "HomeScore", Order = 15)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 16)]
        public int ScoreID { get; set; }

    }
}

