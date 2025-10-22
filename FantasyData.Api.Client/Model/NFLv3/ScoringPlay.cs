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
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Unique ID of the scoring play
        /// </summary>
        [Description("Unique ID of the scoring play")]
        [DataMember(Name = "ScoringPlayID", Order = 3)]
        public int ScoringPlayID { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 5)]
        public int Week { get; set; }

        /// <summary>
        /// The abbreviation [Key} of the away team
        /// </summary>
        [Description("The abbreviation [Key} of the away team")]
        [DataMember(Name = "AwayTeam", Order = 6)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 7)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The order in which the scoring play happened
        /// </summary>
        [Description("The order in which the scoring play happened")]
        [DataMember(Name = "Sequence", Order = 9)]
        public int? Sequence { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 10)]
        public string Team { get; set; }

        /// <summary>
        /// The quarter of the scoring play (1; 2; 3; 4; OT)
        /// </summary>
        [Description("The quarter of the scoring play (1; 2; 3; 4; OT)")]
        [DataMember(Name = "Quarter", Order = 11)]
        public string Quarter { get; set; }

        /// <summary>
        /// The amount of time remaining in the current quarter when the scoring play occurred (e.g. 11:23; 5:34; NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter when the scoring play occurred (e.g. 11:23; 5:34; NULL if game is not in progress or at halftime)")]
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
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 16)]
        public int ScoreID { get; set; }

    }
}

