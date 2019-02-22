using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Csgo
{
    [DataContract(Namespace="", Name="Game")]
    [Serializable]
    public partial class Game
    {
        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int GameId { get; set; }

        /// <summary>
        /// The RoundId of the round that this game is associated with
        /// </summary>
        [Description("The RoundId of the round that this game is associated with")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The calendar year of the season during which this game occurs
        /// </summary>
        [Description("The calendar year of the season during which this game occurs")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar)")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The name of the group in which this game occurs. This is used in tournaments / cups.
        /// </summary>
        [Description("The name of the group in which this game occurs. This is used in tournaments / cups.")]
        [DataMember(Name = "Group", Order = 5)]
        public string Group { get; set; }

        /// <summary>
        /// The TeamId of team A
        /// </summary>
        [Description("The TeamId of team A")]
        [DataMember(Name = "TeamAId", Order = 6)]
        public int? TeamAId { get; set; }

        /// <summary>
        /// The TeamId of team B
        /// </summary>
        [Description("The TeamId of team B")]
        [DataMember(Name = "TeamBId", Order = 7)]
        public int? TeamBId { get; set; }

        /// <summary>
        /// The VenueId of the venue
        /// </summary>
        [Description("The VenueId of the venue")]
        [DataMember(Name = "VenueId", Order = 8)]
        public int? VenueId { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in UTC
        /// </summary>
        [Description("The day that the game is scheduled to be played in UTC")]
        [DataMember(Name = "Day", Order = 9)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time that the game is scheduled to be played in UTC
        /// </summary>
        [Description("The date/time that the game is scheduled to be played in UTC")]
        [DataMember(Name = "DateTime", Order = 10)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is on break, then the Status will be Break. Awarded is used in cases where a game is decided without completing. That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Break, Final, Awarded, Postponed, Canceled, Suspended. If a game is called off before it starts, the Status is set to Postponed, until a new date/time is scheduled, at which point, the DateTime is updated, and the Status is set back to Scheduled. If a game has already started, and temporarily interrupted, it's Status is set to Suspended, until it either resumes, or gets postponed and replayed at a later date. If the game is on break, then the Status will be Break. Awarded is used in cases where a game is decided without completing. That means that a game was decided by the Federation/League to one team for a reason. This can include situations like riots, where the opponent team gets 3:0 win awarded as punishment. Awarded is also used when a club withdraws during the season from the competition then all the remaining matches getting awarded 3:0.")]
        [DataMember(Name = "Status", Order = 11)]
        public string Status { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs
        /// </summary>
        [Description("The week during the season/round in which this game occurs")]
        [DataMember(Name = "Week", Order = 12)]
        public int? Week { get; set; }

        /// <summary>
        /// How many matches/rounds are played if this game is a best of series
        /// </summary>
        [Description("How many matches/rounds are played if this game is a best of series")]
        [DataMember(Name = "BestOf", Order = 13)]
        public string BestOf { get; set; }

        /// <summary>
        /// The winner of the game. Possible values include: TeamA, TeamB, Draw, NULL
        /// </summary>
        [Description("The winner of the game. Possible values include: TeamA, TeamB, Draw, NULL")]
        [DataMember(Name = "Winner", Order = 14)]
        public string Winner { get; set; }

        /// <summary>
        /// Indicates home venue advantage. Possible values include: Home Away, Neutral
        /// </summary>
        [Description("Indicates home venue advantage. Possible values include: Home Away, Neutral")]
        [DataMember(Name = "VenueType", Order = 15)]
        public string VenueType { get; set; }

        /// <summary>
        /// The abbreviation of team A
        /// </summary>
        [Description("The abbreviation of team A")]
        [DataMember(Name = "TeamAKey", Order = 16)]
        public string TeamAKey { get; set; }

        /// <summary>
        /// The name of team A
        /// </summary>
        [Description("The name of team A")]
        [DataMember(Name = "TeamAName", Order = 17)]
        public string TeamAName { get; set; }

        /// <summary>
        /// The final score of team A
        /// </summary>
        [Description("The final score of team A")]
        [DataMember(Name = "TeamAScore", Order = 18)]
        public int? TeamAScore { get; set; }

        /// <summary>
        /// The abbreviation of team B
        /// </summary>
        [Description("The abbreviation of team B")]
        [DataMember(Name = "TeamBKey", Order = 19)]
        public string TeamBKey { get; set; }

        /// <summary>
        /// The name of team B
        /// </summary>
        [Description("The name of team B")]
        [DataMember(Name = "TeamBName", Order = 20)]
        public string TeamBName { get; set; }

        /// <summary>
        /// The final score of team B
        /// </summary>
        [Description("The final score of team B")]
        [DataMember(Name = "TeamBScore", Order = 21)]
        public int? TeamBScore { get; set; }

        /// <summary>
        /// Payout on a bet that the team A wins
        /// </summary>
        [Description("Payout on a bet that the team A wins")]
        [DataMember(Name = "TeamAMoneyLine", Order = 22)]
        public int? TeamAMoneyLine { get; set; }

        /// <summary>
        /// Payout on a bet that the team B wins
        /// </summary>
        [Description("Payout on a bet that the team B wins")]
        [DataMember(Name = "TeamBMoneyLine", Order = 23)]
        public int? TeamBMoneyLine { get; set; }

        /// <summary>
        /// Payout on a bet that the game is a draw
        /// </summary>
        [Description("Payout on a bet that the game is a draw")]
        [DataMember(Name = "DrawMoneyLine", Order = 24)]
        public int? DrawMoneyLine { get; set; }

        /// <summary>
        /// Point spread for team A
        /// </summary>
        [Description("Point spread for team A")]
        [DataMember(Name = "PointSpread", Order = 25)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// Payout if team A beats the spread
        /// </summary>
        [Description("Payout if team A beats the spread")]
        [DataMember(Name = "TeamAPointSpreadPayout", Order = 26)]
        public int? TeamAPointSpreadPayout { get; set; }

        /// <summary>
        /// Payout if team B beats the spread
        /// </summary>
        [Description("Payout if team B beats the spread")]
        [DataMember(Name = "TeamBPointSpreadPayout", Order = 27)]
        public int? TeamBPointSpreadPayout { get; set; }

        /// <summary>
        /// The timestamp of when this record was updated, based on US Eatern Time (EST/EDT)
        /// </summary>
        [Description("The timestamp of when this record was updated, based on US Eatern Time (EST/EDT)")]
        [DataMember(Name = "Updated", Order = 28)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when this record was updated, based on Universal Coordinated Time (UTC)
        /// </summary>
        [Description("The timestamp of when this record was updated, based on Universal Coordinated Time (UTC)")]
        [DataMember(Name = "UpdatedUtc", Order = 29)]
        public DateTime? UpdatedUtc { get; set; }

    }
}

