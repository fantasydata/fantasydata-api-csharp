using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingEvent")]
    [Serializable]
    public partial class BettingEvent
    {
        /// <summary>
        /// The unique ID associated with the betting event
        /// </summary>
        [Description("The unique ID associated with the betting event")]
        [DataMember(Name = "BettingEventID", Order = 1)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The name of this betting event
        /// </summary>
        [Description("The name of this betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The season that this betting event occurs in. Note: season is a single year that the majority of the season occurs in
        /// </summary>
        [Description("The season that this betting event occurs in. Note: season is a single year that the majority of the season occurs in")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The ID associated with the type of betting event
        /// </summary>
        [Description("The ID associated with the type of betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 4)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// Indicates the type of betting event (Game or Future)
        /// </summary>
        [Description("Indicates the type of betting event (Game or Future)")]
        [DataMember(Name = "BettingEventType", Order = 5)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The date and time a specified event is scheduled to begin. Note: For Futures, this will be the furthest forward time a book has a market set to close
        /// </summary>
        [Description("The date and time a specified event is scheduled to begin. Note: For Futures, this will be the furthest forward time a book has a market set to close")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date and time when this betting event was created (in US Eastern Time)
        /// </summary>
        [Description("The date and time when this betting event was created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of the last time this betting event was updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of the last time this betting event was updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The unique ID of this game tied to this event
        /// </summary>
        [Description("The unique ID of this game tied to this event")]
        [DataMember(Name = "GameID", Order = 9)]
        public int? GameID { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 10)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The status of the game in tied to this event. A list of CBB game statuses can be found here
        /// </summary>
        [Description("The status of the game in tied to this event. A list of CBB game statuses can be found here")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team tied to the event
        /// </summary>
        [Description("The abbreviation [Key] of the away team tied to the event")]
        [DataMember(Name = "AwayTeam", Order = 12)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team tied to this event
        /// </summary>
        [Description("The abbreviation [Key] of the home team tied to this event")]
        [DataMember(Name = "HomeTeam", Order = 13)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team tied to the event
        /// </summary>
        [Description("The unique ID of the away team tied to the event")]
        [DataMember(Name = "AwayTeamID", Order = 14)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to this event
        /// </summary>
        [Description("The unique ID of the home team tied to this event")]
        [DataMember(Name = "HomeTeamID", Order = 15)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team tied to this event This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team tied to this event This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 16)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team tied to this event. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team tied to this event. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 17)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game tied to the event (post-game)
        /// </summary>
        [Description("Total number of points the away team scored in the game tied to the event (post-game)")]
        [DataMember(Name = "AwayTeamScore", Order = 18)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game (post-game)
        /// </summary>
        [Description("Total number of points the home team scored in this game (post-game)")]
        [DataMember(Name = "HomeTeamScore", Order = 19)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The total amount of points scored in the game by both teams, posted after the conclusion of the game
        /// </summary>
        [Description("The total amount of points scored in the game by both teams, posted after the conclusion of the game")]
        [DataMember(Name = "TotalScore", Order = 20)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation number of away team in the game tied to this event.
        /// </summary>
        [Description("Rotation number of away team in the game tied to this event.")]
        [DataMember(Name = "AwayRotationNumber", Order = 21)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of home team for this game for this event
        /// </summary>
        [Description("Rotation number of home team for this game for this event")]
        [DataMember(Name = "HomeRotationNumber", Order = 22)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20023)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time that the game started. Note: Time is in US Eastern Time
        /// </summary>
        [Description("The date and time that the game started. Note: Time is in US Eastern Time")]
        [DataMember(Name = "GameStartTime", Order = 24)]
        public DateTime? GameStartTime { get; set; }

    }
}

