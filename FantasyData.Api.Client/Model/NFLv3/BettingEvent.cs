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
        /// The unique ID assocated with the betting event
        /// </summary>
        [Description("The unique ID assocated with the betting event")]
        [DataMember(Name = "BettingEventID", Order = 1)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The name of the betting event
        /// </summary>
        [Description("The name of the betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The NFL season of the betting event
        /// </summary>
        [Description("The NFL season of the betting event")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The ID associated with the type of betting event
        /// </summary>
        [Description("The ID associated with the type of betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 4)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// Indicates the type of betting event - Game or Future
        /// </summary>
        [Description("Indicates the type of betting event - Game or Future")]
        [DataMember(Name = "BettingEventType", Order = 5)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The furthest forward time any book has a market set to close for this betting event
        /// </summary>
        [Description("The furthest forward time any book has a market set to close for this betting event")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date and time when this betting event was created in US Eastern Time
        /// </summary>
        [Description("The date and time when this betting event was created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date and time of the last update made to this betting event (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the last update made to this betting event (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// ScoreID has been superseded by GameID and should not be used in any new integrations. Existing integrations can be updated to use GameID instead, so that they are consistent with all other sports.
        /// </summary>
        [Description("ScoreID has been superseded by GameID and should not be used in any new integrations. Existing integrations can be updated to use GameID instead, so that they are consistent with all other sports.")]
        [DataMember(Name = "ScoreID", Order = 9)]
        public int? ScoreID { get; set; }

        /// <summary>
        /// A globally unique ID for the game tied to this betting event. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the game tied to this betting event. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalScoreID", Order = 10)]
        public int? GlobalScoreID { get; set; }

        /// <summary>
        /// The status of the game tied to this betting event
        /// </summary>
        [Description("The status of the game tied to this betting event")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The quarter of the game tied to this event
        /// </summary>
        [Description("The quarter of the game tied to this event")]
        [DataMember(Name = "Quarter", Order = 12)]
        public string Quarter { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the Home Team
        /// </summary>
        [Description("The abbreviation [Key] of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique TeamID of the away team tied to this BettingEvent
        /// </summary>
        [Description("The unique TeamID of the away team tied to this BettingEvent")]
        [DataMember(Name = "AwayTeamID", Order = 15)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique TeamID of the home team tied to this BettingEvent
        /// </summary>
        [Description("The unique TeamID of the home team tied to this BettingEvent")]
        [DataMember(Name = "HomeTeamID", Order = 16)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team tied to this BettingEvent This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team tied to this BettingEvent This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 17)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team tied to this BettingEvent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team tied to this BettingEvent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 18)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Score of the away team tied to this betting event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the away team tied to this betting event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 19)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Score of the home team tied to this betting event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the home team tied to this betting event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 20)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)
        /// </summary>
        [Description("The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)")]
        [DataMember(Name = "TotalScore", Order = 21)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation number of away team for this game
        /// </summary>
        [Description("Rotation number of away team for this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 22)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of home team for this game
        /// </summary>
        [Description("Rotation number of home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 23)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20024)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time the game starts
        /// </summary>
        [Description("The date and time the game starts")]
        [DataMember(Name = "GameStartTime", Order = 25)]
        public DateTime? GameStartTime { get; set; }

    }
}

