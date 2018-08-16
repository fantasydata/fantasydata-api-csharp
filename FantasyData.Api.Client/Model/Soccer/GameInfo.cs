using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="GameInfo")]
    [Serializable]
    public partial class GameInfo
    {
        /// <summary>
        /// The unique ID of the game.
        /// </summary>
        [Description("The unique ID of the game.")]
        [DataMember(Name = "GameId", Order = 1)]
        public int GameId { get; set; }

        /// <summary>
        /// The RoundId of the round that this game is associated with.
        /// </summary>
        [Description("The RoundId of the round that this game is associated with.")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The calendar year of the season during which this game occurs.
        /// </summary>
        [Description("The calendar year of the season during which this game occurs.")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs.
        /// </summary>
        [Description("The week during the season/round in which this game occurs.")]
        [DataMember(Name = "Week", Order = 5)]
        public int? Week { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in UTC.
        /// </summary>
        [Description("The day that the game is scheduled to be played in UTC.")]
        [DataMember(Name = "Day", Order = 6)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time that the game is scheduled to be played in UTC.
        /// </summary>
        [Description("The date/time that the game is scheduled to be played in UTC.")]
        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called "green table." That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is at halftime, then the Status will be Break. Awarded is used in cases where a game is decided on the so called \"green table.\" That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.")]
        [DataMember(Name = "Status", Order = 8)]
        public string Status { get; set; }

        /// <summary>
        /// The TeamId of the away team.
        /// </summary>
        [Description("The TeamId of the away team.")]
        [DataMember(Name = "AwayTeamId", Order = 9)]
        public int? AwayTeamId { get; set; }

        /// <summary>
        /// The TeamId of the home team.
        /// </summary>
        [Description("The TeamId of the home team.")]
        [DataMember(Name = "HomeTeamId", Order = 10)]
        public int? HomeTeamId { get; set; }

        /// <summary>
        /// The name of the away team.
        /// </summary>
        [Description("The name of the away team.")]
        [DataMember(Name = "AwayTeamName", Order = 11)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team.
        /// </summary>
        [Description("The name of the home team.")]
        [DataMember(Name = "HomeTeamName", Order = 12)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 13)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamId", Order = 14)]
        public int? GlobalAwayTeamId { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamId", Order = 15)]
        public int? GlobalHomeTeamId { get; set; }

        /// <summary>
        /// List of Pregame Odds from different sportsbooks
        /// </summary>
        [Description("List of Pregame Odds from different sportsbooks")]
        [DataMember(Name = "PregameOdds", Order = 20016)]
        public GameOdd[] PregameOdds { get; set; }

        /// <summary>
        /// List of Live Odds from different sportsbooks
        /// </summary>
        [Description("List of Live Odds from different sportsbooks")]
        [DataMember(Name = "LiveOdds", Order = 20017)]
        public GameOdd[] LiveOdds { get; set; }

    }
}

