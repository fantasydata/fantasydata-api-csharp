using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
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
        /// The soccer regular season for which these totals apply
        /// </summary>
        [Description("The soccer regular season for which these totals apply")]
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
        /// The last day for betting on this event
        /// </summary>
        [Description("The last day for betting on this event")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The created date of this betting event (in US Eastern Time)
        /// </summary>
        [Description("The created date of this betting event (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the betting event record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the betting event record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameID", Order = 9)]
        public int? GameID { get; set; }

        /// <summary>
        /// A globally unique ID for this game tied to this event
        /// </summary>
        [Description("A globally unique ID for this game tied to this event")]
        [DataMember(Name = "GlobalGameID", Order = 10)]
        public int? GlobalGameID { get; set; }

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
        /// The abbreviation [Key] of the away team tied to this event
        /// </summary>
        [Description("The abbreviation [Key] of the away team tied to this event")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team tied to this event
        /// </summary>
        [Description("The abbreviation [Key] of the home team tied to this event")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team tied to this event
        /// </summary>
        [Description("The unique ID of the away team tied to this event")]
        [DataMember(Name = "AwayTeamID", Order = 15)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to this event
        /// </summary>
        [Description("The unique ID of the home team tied to this event")]
        [DataMember(Name = "HomeTeamID", Order = 16)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team tied to this event
        /// </summary>
        [Description("A globally unique ID for the away team tied to this event")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 17)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team tied to this event
        /// </summary>
        [Description("A globally unique ID for the home team tied to this event")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 18)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The away team score of the game tied to this event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The away team score of the game tied to this event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 19)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The home team score of the game tied to this event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The home team score of the game tied to this event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 20)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The total combined score of both teams in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The total combined score of both teams in the game (updated after game ends to allow for resolving bets)")]
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
        /// The Id of the competition related to this betting event
        /// </summary>
        [Description("The Id of the competition related to this betting event")]
        [DataMember(Name = "CompetitionId", Order = 25)]
        public int? CompetitionId { get; set; }

    }
}

