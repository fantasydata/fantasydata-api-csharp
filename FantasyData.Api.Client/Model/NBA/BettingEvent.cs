using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// The NBA season of the BettingEvent
        /// </summary>
        [Description("The NBA season of the BettingEvent")]
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
        /// The furthest forward time any sportsbook has an event or market set to start for this betting event
        /// </summary>
        [Description("The furthest forward time any sportsbook has an event or market set to start for this betting event")]
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
        /// The unique ID of the game associated with this BettingEvent
        /// </summary>
        [Description("The unique ID of the game associated with this BettingEvent")]
        [DataMember(Name = "GameID", Order = 9)]
        public int? GameID { get; set; }

        /// <summary>
        /// The GlobalGameID of the game tied to this event
        /// </summary>
        [Description("The GlobalGameID of the game tied to this event")]
        [DataMember(Name = "GlobalGameID", Order = 10)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The status of the game in tied to this event
        /// </summary>
        [Description("The status of the game in tied to this event")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The current quarter in the game tied to this betting event. Possible values include: 1; 2; 3; 4; Half; OT; NULL
        /// </summary>
        [Description("The current quarter in the game tied to this betting event. Possible values include: 1; 2; 3; 4; Half; OT; NULL")]
        [DataMember(Name = "Quarter", Order = 12)]
        public string Quarter { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team tied to the event
        /// </summary>
        [Description("The abbreviation [Key] of the away team tied to the event")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team tied to the event
        /// </summary>
        [Description("The unique ID of the away team tied to the event")]
        [DataMember(Name = "AwayTeamID", Order = 15)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to the event
        /// </summary>
        [Description("The unique ID of the home team tied to the event")]
        [DataMember(Name = "HomeTeamID", Order = 16)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 17)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 18)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game tied to the event (post-game)
        /// </summary>
        [Description("Total number of points the away team scored in the game tied to the event (post-game)")]
        [DataMember(Name = "AwayTeamScore", Order = 19)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total points scored by the home team in the game (post-game)
        /// </summary>
        [Description("Total points scored by the home team in the game (post-game)")]
        [DataMember(Name = "HomeTeamScore", Order = 20)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The total amount of points scored in the game by both teams. Updated after the game ends to allow for resulting bets
        /// </summary>
        [Description("The total amount of points scored in the game by both teams. Updated after the game ends to allow for resulting bets")]
        [DataMember(Name = "TotalScore", Order = 21)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation number of away team for this event Note: if the betting event is a future this field will be NULL
        /// </summary>
        [Description("Rotation number of away team for this event Note: if the betting event is a future this field will be NULL")]
        [DataMember(Name = "AwayRotationNumber", Order = 22)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// The rotation number of the home team for this event Note: If betting event is a future this field will be NULL
        /// </summary>
        [Description("The rotation number of the home team for this event Note: If betting event is a future this field will be NULL")]
        [DataMember(Name = "HomeRotationNumber", Order = 23)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20024)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time that the game started (in US Eastern Time)
        /// </summary>
        [Description("The date and time that the game started (in US Eastern Time)")]
        [DataMember(Name = "GameStartTime", Order = 25)]
        public DateTime? GameStartTime { get; set; }

    }
}

