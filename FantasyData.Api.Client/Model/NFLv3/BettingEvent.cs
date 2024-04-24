using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="BettingEvent")]
    [Serializable]
    public partial class BettingEvent
    {
        /// <summary>
        /// The unique identifier for this betting event
        /// </summary>
        [Description("The unique identifier for this betting event")]
        [DataMember(Name = "BettingEventID", Order = 1)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The name of this betting event
        /// </summary>
        [Description("The name of this betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The season of this betting event
        /// </summary>
        [Description("The season of this betting event")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The identifier of the bet type of this betting event
        /// </summary>
        [Description("The identifier of the bet type of this betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 4)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// The name of the bet type of this betting event
        /// </summary>
        [Description("The name of the bet type of this betting event")]
        [DataMember(Name = "BettingEventType", Order = 5)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The furthest forward time any book has a market set to close for this betting event
        /// </summary>
        [Description("The furthest forward time any book has a market set to close for this betting event")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The created date of this betting event
        /// </summary>
        [Description("The created date of this betting event")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of this betting event
        /// </summary>
        [Description("The last updated date of this betting event")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// ScoreID has been superseded by GameID and should not be used in any new integrations. Existing integrations can be updated to use GameID instead, so that they are consistent with all other sports.
        /// </summary>
        [Description("ScoreID has been superseded by GameID and should not be used in any new integrations. Existing integrations can be updated to use GameID instead, so that they are consistent with all other sports.")]
        [DataMember(Name = "ScoreID", Order = 9)]
        public int? ScoreID { get; set; }

        /// <summary>
        /// The GlobalGameId of the game tied to this event
        /// </summary>
        [Description("The GlobalGameId of the game tied to this event")]
        [DataMember(Name = "GlobalScoreID", Order = 10)]
        public int? GlobalScoreID { get; set; }

        /// <summary>
        /// The status of the game tied to this event
        /// </summary>
        [Description("The status of the game tied to this event")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The quarter of the game tied to this event
        /// </summary>
        [Description("The quarter of the game tied to this event")]
        [DataMember(Name = "Quarter", Order = 12)]
        public string Quarter { get; set; }

        /// <summary>
        /// The Away Team Key of the game tied to this event
        /// </summary>
        [Description("The Away Team Key of the game tied to this event")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The Home team key of the game tied to this event
        /// </summary>
        [Description("The Home team key of the game tied to this event")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The Away team ID of the game tied to this event
        /// </summary>
        [Description("The Away team ID of the game tied to this event")]
        [DataMember(Name = "AwayTeamID", Order = 15)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The Home team ID of the game tied to this event
        /// </summary>
        [Description("The Home team ID of the game tied to this event")]
        [DataMember(Name = "HomeTeamID", Order = 16)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The global away team id of the game tied to this event
        /// </summary>
        [Description("The global away team id of the game tied to this event")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 17)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// The global home team id of the game tied to this event
        /// </summary>
        [Description("The global home team id of the game tied to this event")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 18)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The away team score of the game tied to this event (post-game)
        /// </summary>
        [Description("The away team score of the game tied to this event (post-game)")]
        [DataMember(Name = "AwayTeamScore", Order = 19)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The home team score of the game tied to this event (post-game)
        /// </summary>
        [Description("The home team score of the game tied to this event (post-game)")]
        [DataMember(Name = "HomeTeamScore", Order = 20)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The combined scores of the home and away team of the game tied to this event (post-game)
        /// </summary>
        [Description("The combined scores of the home and away team of the game tied to this event (post-game)")]
        [DataMember(Name = "TotalScore", Order = 21)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The away team rotation number of the game tied to this event
        /// </summary>
        [Description("The away team rotation number of the game tied to this event")]
        [DataMember(Name = "AwayRotationNumber", Order = 22)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// The home team rotation number of the game tied to this event
        /// </summary>
        [Description("The home team rotation number of the game tied to this event")]
        [DataMember(Name = "HomeRotationNumber", Order = 23)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20024)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time the connected game starts, where applicable
        /// </summary>
        [Description("The date and time the connected game starts, where applicable")]
        [DataMember(Name = "GameStartTime", Order = 25)]
        public DateTime? GameStartTime { get; set; }

    }
}

