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
        /// Unique ID of MatchOdd Record.
        /// </summary>
        [Description("Unique ID of MatchOdd Record.")]
        [DataMember(Name = "MatchOddId", Order = 1)]
        public int MatchOddId { get; set; }

        /// <summary>
        /// Unique ID of Sportsbook.
        /// </summary>
        [Description("Unique ID of Sportsbook.")]
        [DataMember(Name = "SportsbookId", Order = 2)]
        public int SportsbookId { get; set; }

        /// <summary>
        /// Name of Sportsbook.
        /// </summary>
        [Description("Name of Sportsbook.")]
        [DataMember(Name = "Sportsbook", Order = 3)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// Unique ID of associated Match.
        /// </summary>
        [Description("Unique ID of associated Match.")]
        [DataMember(Name = "MatchId", Order = 4)]
        public int MatchId { get; set; }

        /// <summary>
        /// Unique ID of Contestant.
        /// </summary>
        [Description("Unique ID of Contestant.")]
        [DataMember(Name = "ContestantAId", Order = 5)]
        public int? ContestantAId { get; set; }

        /// <summary>
        /// Name of Contestant.
        /// </summary>
        [Description("Name of Contestant.")]
        [DataMember(Name = "ContestantA1Name", Order = 6)]
        public string ContestantA1Name { get; set; }

        /// <summary>
        /// Name of Contestant (if doubles).
        /// </summary>
        [Description("Name of Contestant (if doubles).")]
        [DataMember(Name = "ContestantA2Name", Order = 7)]
        public string ContestantA2Name { get; set; }

        /// <summary>
        /// Unique ID of Contestant.
        /// </summary>
        [Description("Unique ID of Contestant.")]
        [DataMember(Name = "ContestantBId", Order = 8)]
        public int? ContestantBId { get; set; }

        /// <summary>
        /// Name of Contestant.
        /// </summary>
        [Description("Name of Contestant.")]
        [DataMember(Name = "ContestantB1Name", Order = 9)]
        public string ContestantB1Name { get; set; }

        /// <summary>
        /// Name of Contestant (if doubles).
        /// </summary>
        [Description("Name of Contestant (if doubles).")]
        [DataMember(Name = "ContestantB2Name", Order = 10)]
        public string ContestantB2Name { get; set; }

        /// <summary>
        /// Moneyline Odds for Contestant A.
        /// </summary>
        [Description("Moneyline Odds for Contestant A.")]
        [DataMember(Name = "ContestantAMoneyline", Order = 11)]
        public int? ContestantAMoneyline { get; set; }

        /// <summary>
        /// Moneyline Odds for Contestant B.
        /// </summary>
        [Description("Moneyline Odds for Contestant B.")]
        [DataMember(Name = "ContestantBMoneyline", Order = 12)]
        public int? ContestantBMoneyline { get; set; }

        /// <summary>
        /// Total Games O/U Value.
        /// </summary>
        [Description("Total Games O/U Value.")]
        [DataMember(Name = "TotalGames", Order = 13)]
        public decimal? TotalGames { get; set; }

        /// <summary>
        /// Total Games Over Odds.
        /// </summary>
        [Description("Total Games Over Odds.")]
        [DataMember(Name = "TotalGamesOverPayout", Order = 14)]
        public int? TotalGamesOverPayout { get; set; }

        /// <summary>
        /// Total Games Under Odds.
        /// </summary>
        [Description("Total Games Under Odds.")]
        [DataMember(Name = "TotalGamesUnderPayout", Order = 15)]
        public int? TotalGamesUnderPayout { get; set; }

        /// <summary>
        /// Total Sets O/U Value.
        /// </summary>
        [Description("Total Sets O/U Value.")]
        [DataMember(Name = "TotalSets", Order = 16)]
        public decimal? TotalSets { get; set; }

        /// <summary>
        /// Total Sets Over Odds.
        /// </summary>
        [Description("Total Sets Over Odds.")]
        [DataMember(Name = "TotalSetsOverPayout", Order = 17)]
        public int? TotalSetsOverPayout { get; set; }

        /// <summary>
        /// Total Sets Under Odds.
        /// </summary>
        [Description("Total Sets Under Odds.")]
        [DataMember(Name = "TotalSetsUnderPayout", Order = 18)]
        public int? TotalSetsUnderPayout { get; set; }

        /// <summary>
        /// Describes what kind of odd this is, eg. pregame.
        /// </summary>
        [Description("Describes what kind of odd this is, eg. pregame.")]
        [DataMember(Name = "OddType", Order = 19)]
        public string OddType { get; set; }

        /// <summary>
        /// Time at which this record was created.
        /// </summary>
        [Description("Time at which this record was created.")]
        [DataMember(Name = "Created", Order = 20)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Time at which this record was last updated.
        /// </summary>
        [Description("Time at which this record was last updated.")]
        [DataMember(Name = "Updated", Order = 21)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Spread Value for Contestant A.
        /// </summary>
        [Description("Spread Value for Contestant A.")]
        [DataMember(Name = "ContestantAGameSpread", Order = 22)]
        public decimal? ContestantAGameSpread { get; set; }

        /// <summary>
        /// Odds for Contestant A Spread.
        /// </summary>
        [Description("Odds for Contestant A Spread.")]
        [DataMember(Name = "ContestantAGameSpreadPayout", Order = 23)]
        public int? ContestantAGameSpreadPayout { get; set; }

        /// <summary>
        /// Spread Value for Contestant B.
        /// </summary>
        [Description("Spread Value for Contestant B.")]
        [DataMember(Name = "ContestantBGameSpread", Order = 24)]
        public decimal? ContestantBGameSpread { get; set; }

        /// <summary>
        /// Odds for Contestant B Spread.
        /// </summary>
        [Description("Odds for Contestant B Spread.")]
        [DataMember(Name = "ContestantBGameSpreadPayout", Order = 25)]
        public int? ContestantBGameSpreadPayout { get; set; }

    }
}

