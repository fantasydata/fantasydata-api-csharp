using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="FightOdds")]
    [Serializable]
    public partial class FightOdds
    {
        /// <summary>
        /// The unique ID of this Fight Odd
        /// </summary>
        [Description("The unique ID of this Fight Odd")]
        [DataMember(Name = "FightOddId", Order = 1)]
        public int? FightOddId { get; set; }

        /// <summary>
        /// The unique ID of this Sportsbook
        /// </summary>
        [Description("The unique ID of this Sportsbook")]
        [DataMember(Name = "SportsbookId", Order = 2)]
        public int? SportsbookId { get; set; }

        /// <summary>
        /// The name of Sportsbook
        /// </summary>
        [Description("The name of Sportsbook")]
        [DataMember(Name = "SportsbookName", Order = 3)]
        public string SportsbookName { get; set; }

        /// <summary>
        /// The unique ID of this event
        /// </summary>
        [Description("The unique ID of this event")]
        [DataMember(Name = "EventId", Order = 4)]
        public int? EventId { get; set; }

        /// <summary>
        /// The unique ID of this Fight
        /// </summary>
        [Description("The unique ID of this Fight")]
        [DataMember(Name = "FightId", Order = 5)]
        public int? FightId { get; set; }

        /// <summary>
        /// The details of Fighter A
        /// </summary>
        [Description("The details of Fighter A")]
        [DataMember(Name = "FighterA", Order = 10006)]
        public Fighter FighterA { get; set; }

        /// <summary>
        /// The details of Fighter B
        /// </summary>
        [Description("The details of Fighter B")]
        [DataMember(Name = "FighterB", Order = 10007)]
        public Fighter FighterB { get; set; }

        /// <summary>
        /// The Sportsbook's money line for Fighter A
        /// </summary>
        [Description("The Sportsbook's money line for Fighter A")]
        [DataMember(Name = "FighterAMoneyline", Order = 8)]
        public int? FighterAMoneyline { get; set; }

        /// <summary>
        /// The Sportsbook's money line for Fighter B
        /// </summary>
        [Description("The Sportsbook's money line for Fighter B")]
        [DataMember(Name = "FighterBMoneyline", Order = 9)]
        public int? FighterBMoneyline { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first created based on US Eastern Time
        /// </summary>
        [Description("The timestamp of when these odds were first created based on US Eastern Time")]
        [DataMember(Name = "Created", Order = 10)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when these odds were last updated based on US Eastern Time
        /// </summary>
        [Description("The timestamp of when these odds were last updated based on US Eastern Time")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 12)]
        public string SportsbookUrl { get; set; }

    }
}

