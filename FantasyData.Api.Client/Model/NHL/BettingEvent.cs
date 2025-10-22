using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The NHL season of the betting event
        /// </summary>
        [Description("The NHL season of the betting event")]
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
        /// The date and time when this betting event was created in US Eastern Time.
        /// </summary>
        [Description("The date and time when this betting event was created in US Eastern Time.")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of the last time this betting event was updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of the last time this betting event was updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The unique ID of the game tied to this BettingEvent
        /// </summary>
        [Description("The unique ID of the game tied to this BettingEvent")]
        [DataMember(Name = "GameID", Order = 9)]
        public int? GameID { get; set; }

        /// <summary>
        /// A globally unique ID for the game tied to this betting event. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the game tied to this betting event. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 10)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// The status of the game tied to this event. A list of NHL game statuses can be found here.
        /// </summary>
        [Description("The status of the game tied to this event. A list of NHL game statuses can be found here.")]
        [DataMember(Name = "GameStatus", Order = 11)]
        public string GameStatus { get; set; }

        /// <summary>
        /// The quarter of the game tied to this event. Note: This field will be null unless the game is ongoing.
        /// </summary>
        [Description("The quarter of the game tied to this event. Note: This field will be null unless the game is ongoing.")]
        [DataMember(Name = "Quarter", Order = 12)]
        public string Quarter { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique TeamID of the away team in the game tied to this betting event
        /// </summary>
        [Description("The unique TeamID of the away team in the game tied to this betting event")]
        [DataMember(Name = "AwayTeamID", Order = 15)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to this betting event
        /// </summary>
        [Description("The unique ID of the home team tied to this betting event")]
        [DataMember(Name = "HomeTeamID", Order = 16)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team tied to this betting event. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team tied to this betting event. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 17)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team tied to this betting event. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team tied to this betting event. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 18)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Total number of goals the away team scored in the game tied to the event (post-game)
        /// </summary>
        [Description("Total number of goals the away team scored in the game tied to the event (post-game)")]
        [DataMember(Name = "AwayTeamScore", Order = 19)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in the game tied to the event (post-game)
        /// </summary>
        [Description("Total number of points the home team scored in the game tied to the event (post-game)")]
        [DataMember(Name = "HomeTeamScore", Order = 20)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Total goals scored in the game (post-game)
        /// </summary>
        [Description("Total goals scored in the game (post-game)")]
        [DataMember(Name = "TotalScore", Order = 21)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The rotation number of the away team for a game
        /// </summary>
        [Description("The rotation number of the away team for a game")]
        [DataMember(Name = "AwayRotationNumber", Order = 22)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// The rotation number of the home team for this game
        /// </summary>
        [Description("The rotation number of the home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 23)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20024)]
        public BettingMarket[] BettingMarkets { get; set; }

        /// <summary>
        /// The date and time that the game attached to the betting event started. Note: Time is in US Eastern Time
        /// </summary>
        [Description("The date and time that the game attached to the betting event started. Note: Time is in US Eastern Time")]
        [DataMember(Name = "GameStartTime", Order = 25)]
        public DateTime? GameStartTime { get; set; }

    }
}

