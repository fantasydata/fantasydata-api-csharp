using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="MatchOdd")]
    [Serializable]
    public partial class MatchOdd
    {
        /// <summary>
        /// The unique ID of the MatchOdd record
        /// </summary>
        [Description("The unique ID of the MatchOdd record")]
        [DataMember(Name = "MatchOddId", Order = 1)]
        public int MatchOddId { get; set; }

        /// <summary>
        /// The unique ID of the sportsbook
        /// </summary>
        [Description("The unique ID of the sportsbook")]
        [DataMember(Name = "SportsbookId", Order = 2)]
        public int SportsbookId { get; set; }

        /// <summary>
        /// The name of the sportsbook
        /// </summary>
        [Description("The name of the sportsbook")]
        [DataMember(Name = "Sportsbook", Order = 3)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// The unique ID of the match associated with this odd
        /// </summary>
        [Description("The unique ID of the match associated with this odd")]
        [DataMember(Name = "MatchId", Order = 4)]
        public int MatchId { get; set; }

        /// <summary>
        /// The unique ID of contestant A
        /// </summary>
        [Description("The unique ID of contestant A")]
        [DataMember(Name = "ContestantAId", Order = 5)]
        public int? ContestantAId { get; set; }

        /// <summary>
        /// The name of the first (or single) player of contestant A
        /// </summary>
        [Description("The name of the first (or single) player of contestant A")]
        [DataMember(Name = "ContestantA1Name", Order = 6)]
        public string ContestantA1Name { get; set; }

        /// <summary>
        /// The name of the second player (if doubles) of contestant A
        /// </summary>
        [Description("The name of the second player (if doubles) of contestant A")]
        [DataMember(Name = "ContestantA2Name", Order = 7)]
        public string ContestantA2Name { get; set; }

        /// <summary>
        /// The unique ID of contestant B
        /// </summary>
        [Description("The unique ID of contestant B")]
        [DataMember(Name = "ContestantBId", Order = 8)]
        public int? ContestantBId { get; set; }

        /// <summary>
        /// The name of the first (or single) player of contestant B
        /// </summary>
        [Description("The name of the first (or single) player of contestant B")]
        [DataMember(Name = "ContestantB1Name", Order = 9)]
        public string ContestantB1Name { get; set; }

        /// <summary>
        /// The name of the second player (if doubles) of contestant B
        /// </summary>
        [Description("The name of the second player (if doubles) of contestant B")]
        [DataMember(Name = "ContestantB2Name", Order = 10)]
        public string ContestantB2Name { get; set; }

        /// <summary>
        /// Moneyline odds for contestant A
        /// </summary>
        [Description("Moneyline odds for contestant A")]
        [DataMember(Name = "ContestantAMoneyline", Order = 11)]
        public int? ContestantAMoneyline { get; set; }

        /// <summary>
        /// Moneyline odds for contestant B
        /// </summary>
        [Description("Moneyline odds for contestant B")]
        [DataMember(Name = "ContestantBMoneyline", Order = 12)]
        public int? ContestantBMoneyline { get; set; }

        /// <summary>
        /// Total games over/under line value
        /// </summary>
        [Description("Total games over/under line value")]
        [DataMember(Name = "TotalGames", Order = 13)]
        public decimal? TotalGames { get; set; }

        /// <summary>
        /// The payout for over result in total games over/under line
        /// </summary>
        [Description("The payout for over result in total games over/under line")]
        [DataMember(Name = "TotalGamesOverPayout", Order = 14)]
        public int? TotalGamesOverPayout { get; set; }

        /// <summary>
        /// The payout for under result in total games over/under line
        /// </summary>
        [Description("The payout for under result in total games over/under line")]
        [DataMember(Name = "TotalGamesUnderPayout", Order = 15)]
        public int? TotalGamesUnderPayout { get; set; }

        /// <summary>
        /// Total sets over/under line value
        /// </summary>
        [Description("Total sets over/under line value")]
        [DataMember(Name = "TotalSets", Order = 16)]
        public decimal? TotalSets { get; set; }

        /// <summary>
        /// The payout for over result in total sets over/under line
        /// </summary>
        [Description("The payout for over result in total sets over/under line")]
        [DataMember(Name = "TotalSetsOverPayout", Order = 17)]
        public int? TotalSetsOverPayout { get; set; }

        /// <summary>
        /// The payout for under result in total sets over/under line
        /// </summary>
        [Description("The payout for under result in total sets over/under line")]
        [DataMember(Name = "TotalSetsUnderPayout", Order = 18)]
        public int? TotalSetsUnderPayout { get; set; }

        /// <summary>
        /// Describes what kind of odd this is (e.g. pregame)
        /// </summary>
        [Description("Describes what kind of odd this is (e.g. pregame)")]
        [DataMember(Name = "OddType", Order = 19)]
        public string OddType { get; set; }

        /// <summary>
        /// Timestamp of this record's creation (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of this record's creation (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 20)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Timestamp of the last update of this record (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of the last update of this record (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 21)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Spread value for contestant A
        /// </summary>
        [Description("Spread value for contestant A")]
        [DataMember(Name = "ContestantAGameSpread", Order = 22)]
        public decimal? ContestantAGameSpread { get; set; }

        /// <summary>
        /// Spread payout for contestant A
        /// </summary>
        [Description("Spread payout for contestant A")]
        [DataMember(Name = "ContestantAGameSpreadPayout", Order = 23)]
        public int? ContestantAGameSpreadPayout { get; set; }

        /// <summary>
        /// Spread value for contestant B
        /// </summary>
        [Description("Spread value for contestant B")]
        [DataMember(Name = "ContestantBGameSpread", Order = 24)]
        public decimal? ContestantBGameSpread { get; set; }

        /// <summary>
        /// Spread payout for contestant B
        /// </summary>
        [Description("Spread payout for contestant B")]
        [DataMember(Name = "ContestantBGameSpreadPayout", Order = 25)]
        public int? ContestantBGameSpreadPayout { get; set; }

    }
}

