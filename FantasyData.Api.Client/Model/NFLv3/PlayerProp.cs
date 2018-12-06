using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerProp")]
    [Serializable]
    public partial class PlayerProp
    {
        /// <summary>
        /// The PlayerID of the player
        /// </summary>
        [Description("The PlayerID of the player")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The ScoreID of the game
        /// </summary>
        [Description("The ScoreID of the game")]
        [DataMember(Name = "ScoreID", Order = 2)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The full name of the player
        /// </summary>
        [Description("The full name of the player")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The TeamKey of the opponent in the game
        /// </summary>
        [Description("The TeamKey of the opponent in the game")]
        [DataMember(Name = "Opponent", Order = 4)]
        public string Opponent { get; set; }

        /// <summary>
        /// The TeamKey of the player's team in the game
        /// </summary>
        [Description("The TeamKey of the player's team in the game")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The start time of the game (to give an idea of when prop should close)
        /// </summary>
        [Description("The start time of the game (to give an idea of when prop should close)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// A description of the stat the over/under is referring to (ex: Passing Yards)
        /// </summary>
        [Description("A description of the stat the over/under is referring to (ex: Passing Yards)")]
        [DataMember(Name = "Description", Order = 7)]
        public string Description { get; set; }

        /// <summary>
        /// The over under value in question (ex: 1.5)
        /// </summary>
        [Description("The over under value in question (ex: 1.5)")]
        [DataMember(Name = "OverUnder", Order = 8)]
        public decimal OverUnder { get; set; }

        /// <summary>
        /// The (american styled) payout for a successful over bet.
        /// </summary>
        [Description("The (american styled) payout for a successful over bet.")]
        [DataMember(Name = "OverPayout", Order = 9)]
        public int OverPayout { get; set; }

        /// <summary>
        /// The (american styled) payout for a successful under bet.
        /// </summary>
        [Description("The (american styled) payout for a successful under bet.")]
        [DataMember(Name = "UnderPayout", Order = 10)]
        public int UnderPayout { get; set; }

    }
}

