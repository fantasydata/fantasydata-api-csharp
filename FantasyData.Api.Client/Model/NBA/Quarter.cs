using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Quarter")]
    [Serializable]
    public partial class Quarter
    {
        /// <summary>
        /// Unique identifier for each Quarter.
        /// </summary>
        [Description("Unique identifier for each Quarter.")]
        [DataMember(Name = "QuarterID", Order = 1)]
        public int QuarterID { get; set; }

        /// <summary>
        /// The unique ID of the game associated with this quarter
        /// </summary>
        [Description("The unique ID of the game associated with this quarter")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The Number (Order) of the Quarter in the scope of the Game.
        /// </summary>
        [Description("The Number (Order) of the Quarter in the scope of the Game.")]
        [DataMember(Name = "Number", Order = 3)]
        public int Number { get; set; }

        /// <summary>
        /// The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)
        /// </summary>
        [Description("The Name of the Quarter (possible values: 1, 2, 3, 4, OT, OT2, OT3, etc)")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The total points scored by the away team in the given period only
        /// </summary>
        [Description("The total points scored by the away team in the given period only")]
        [DataMember(Name = "AwayScore", Order = 5)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The total points scored by the home team in the given period only
        /// </summary>
        [Description("The total points scored by the home team in the given period only")]
        [DataMember(Name = "HomeScore", Order = 6)]
        public int? HomeScore { get; set; }

    }
}

