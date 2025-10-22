using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="TournamentRound")]
    [Serializable]
    public partial class TournamentRound
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The unique ID of this player/tournament combination
        /// </summary>
        [Description("The unique ID of this player/tournament combination")]
        [DataMember(Name = "PlayerTournamentID", Order = 2)]
        public int PlayerTournamentID { get; set; }

        /// <summary>
        /// The total score of the golfer for this tournament as compared to par
        /// </summary>
        [Description("The total score of the golfer for this tournament as compared to par")]
        [DataMember(Name = "TotalScore", Order = 3)]
        public decimal? TotalScore { get; set; }

        /// <summary>
        /// The total strokes this golfer has for this tournament
        /// </summary>
        [Description("The total strokes this golfer has for this tournament")]
        [DataMember(Name = "TotalStrokes", Order = 4)]
        public decimal? TotalStrokes { get; set; }

        /// <summary>
        /// PlayerRoundScore object
        /// </summary>
        [Description("PlayerRoundScore object")]
        [DataMember(Name = "PlayerRoundScore", Order = 20005)]
        public PlayerRoundScore[] PlayerRoundScore { get; set; }

        /// <summary>
        /// The unique ID of the golfer
        /// </summary>
        [Description("The unique ID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 6)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The first name of the golfer
        /// </summary>
        [Description("The first name of the golfer")]
        [DataMember(Name = "FirstName", Order = 7)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this golfer
        /// </summary>
        [Description("The last name of this golfer")]
        [DataMember(Name = "LastName", Order = 8)]
        public string LastName { get; set; }

        /// <summary>
        /// The golfer's weight (in pounds)
        /// </summary>
        [Description("The golfer's weight (in pounds)")]
        [DataMember(Name = "Weight", Order = 9)]
        public int? Weight { get; set; }

        /// <summary>
        /// Indicates whether this golfer swings right-handed (R) or left-handed (L)
        /// </summary>
        [Description("Indicates whether this golfer swings right-handed (R) or left-handed (L)")]
        [DataMember(Name = "Swings", Order = 10)]
        public string Swings { get; set; }

        /// <summary>
        /// The year that this golfer made his PGA debut
        /// </summary>
        [Description("The year that this golfer made his PGA debut")]
        [DataMember(Name = "PgaDebut", Order = 11)]
        public int? PgaDebut { get; set; }

        /// <summary>
        /// The country where this golfer is from
        /// </summary>
        [Description("The country where this golfer is from")]
        [DataMember(Name = "Country", Order = 12)]
        public string Country { get; set; }

        /// <summary>
        /// The golfer's date of birth
        /// </summary>
        [Description("The golfer's date of birth")]
        [DataMember(Name = "BirthDate", Order = 13)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city where this golfer was born
        /// </summary>
        [Description("The city where this golfer was born")]
        [DataMember(Name = "BirthCity", Order = 14)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state where this golfer was born. Note: This field is null for any golfer born outside the US, Canada, and Australia
        /// </summary>
        [Description("The state where this golfer was born. Note: This field is null for any golfer born outside the US, Canada, and Australia")]
        [DataMember(Name = "BirthState", Order = 15)]
        public string BirthState { get; set; }

        /// <summary>
        /// The college that this golfer attended
        /// </summary>
        [Description("The college that this golfer attended")]
        [DataMember(Name = "College", Order = 16)]
        public string College { get; set; }

    }
}

