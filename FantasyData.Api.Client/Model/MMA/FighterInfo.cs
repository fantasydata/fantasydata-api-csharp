using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="FighterInfo")]
    [Serializable]
    public partial class FighterInfo
    {
        /// <summary>
        /// The unique ID of this fighter
        /// </summary>
        [Description("The unique ID of this fighter")]
        [DataMember(Name = "FighterId", Order = 1)]
        public int? FighterId { get; set; }

        /// <summary>
        /// The fighter's first name
        /// </summary>
        [Description("The fighter's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The fighter's last name
        /// </summary>
        [Description("The fighter's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The fighter's win total prior to the fight
        /// </summary>
        [Description("The fighter's win total prior to the fight")]
        [DataMember(Name = "PreFightWins", Order = 4)]
        public int? PreFightWins { get; set; }

        /// <summary>
        /// The fighter's loss total prior to the fight
        /// </summary>
        [Description("The fighter's loss total prior to the fight")]
        [DataMember(Name = "PreFightLosses", Order = 5)]
        public int? PreFightLosses { get; set; }

        /// <summary>
        /// The fighter's draw total prior to the fight
        /// </summary>
        [Description("The fighter's draw total prior to the fight")]
        [DataMember(Name = "PreFightDraws", Order = 6)]
        public int? PreFightDraws { get; set; }

        /// <summary>
        /// The fighter's no contest total prior to the fight
        /// </summary>
        [Description("The fighter's no contest total prior to the fight")]
        [DataMember(Name = "PreFightNoContests", Order = 7)]
        public int? PreFightNoContests { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight
        /// </summary>
        [Description("Indicates if this fighter won the fight")]
        [DataMember(Name = "Winner", Order = 8)]
        public bool? Winner { get; set; }

        /// <summary>
        /// Moneyline for the fighters odds to win the fight
        /// </summary>
        [Description("Moneyline for the fighters odds to win the fight")]
        [DataMember(Name = "Moneyline", Order = 9)]
        public int? Moneyline { get; set; }

        /// <summary>
        /// Indicates the fighter is still listed for this fight
        /// </summary>
        [Description("Indicates the fighter is still listed for this fight")]
        [DataMember(Name = "Active", Order = 10)]
        public bool? Active { get; set; }

    }
}

