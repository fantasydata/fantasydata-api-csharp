using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="EventOdds")]
    [Serializable]
    public partial class EventOdds
    {
        /// <summary>
        /// The Event as an object - including the EventID, LeagueID, Name (and ShortName)of the Event, Season, Day, DateTime, & Status
        /// </summary>
        [Description("The Event as an object - including the EventID, LeagueID, Name (and ShortName)of the Event, Season, Day, DateTime, & Status")]
        [DataMember(Name = "Event", Order = 10001)]
        public Event Event { get; set; }

        /// <summary>
        /// The Event's collection of FightOdds
        /// </summary>
        [Description("The Event's collection of FightOdds")]
        [DataMember(Name = "FightOdds", Order = 20002)]
        public FightOdds[] FightOdds { get; set; }

    }
}

