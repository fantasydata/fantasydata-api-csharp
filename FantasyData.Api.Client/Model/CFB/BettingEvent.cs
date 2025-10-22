using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
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
        /// The name of this betting event
        /// </summary>
        [Description("The name of this betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The college football season of the game
        /// </summary>
        [Description("The college football season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The ID associated with the type of betting event - Game or Future
        /// </summary>
        [Description("The ID associated with the type of betting event - Game or Future")]
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
        /// The created date of this betting event
        /// </summary>
        [Description("The created date of this betting event")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated timestamp of this betting event (US Eastern Time)
        /// </summary>
        [Description("The last updated timestamp of this betting event (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The unique ID of this game tied to this event
        /// </summary>
        [Description("The unique ID of this game tied to this event")]
        [DataMember(Name = "GameID", Order = 9)]
        public int? GameID { get; set; }

        /// <summary>
        /// A globally unique ID for this game tied to this event. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game tied to this event. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 10)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The status of the game tied to this event
        /// </summary>
        [Description("The status of the game tied to this event")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team tied to this event
        /// </summary>
        [Description("The abbreviation [Key] of the away team tied to this event")]
        [DataMember(Name = "AwayTeam", Order = 12)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 13)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team tied to this event
        /// </summary>
        [Description("The unique ID of the away team tied to this event")]
        [DataMember(Name = "AwayTeamID", Order = 14)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 15)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team tied this event. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team tied this event. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 16)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 17)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The away team score of the game tied to this event (post-game)
        /// </summary>
        [Description("The away team score of the game tied to this event (post-game)")]
        [DataMember(Name = "AwayTeamScore", Order = 18)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The home team score of the game tied to this event (postgame)
        /// </summary>
        [Description("The home team score of the game tied to this event (postgame)")]
        [DataMember(Name = "HomeTeamScore", Order = 19)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The total points scored by both teams in the game tied to this event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The total points scored by both teams in the game tied to this event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 20)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The away team rotation number of the game tied to this event
        /// </summary>
        [Description("The away team rotation number of the game tied to this event")]
        [DataMember(Name = "AwayRotationNumber", Order = 21)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of home team tied to this event
        /// </summary>
        [Description("Rotation number of home team tied to this event")]
        [DataMember(Name = "HomeRotationNumber", Order = 22)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20023)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time the connected game starts, where applicable
        /// </summary>
        [Description("The date and time the connected game starts, where applicable")]
        [DataMember(Name = "GameStartTime", Order = 24)]
        public DateTime? GameStartTime { get; set; }

    }
}

