using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Booking")]
    [Serializable]
    public partial class Booking
    {
        /// <summary>
        /// The unique ID of the booking
        /// </summary>
        [Description("The unique ID of the booking")]
        [DataMember(Name = "BookingId", Order = 1)]
        public int BookingId { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 2)]
        public int GameId { get; set; }

        /// <summary>
        /// The type of booking. Possible values: Yellow Card, Red Card, Yellow Red Card
        /// </summary>
        [Description("The type of booking. Possible values: Yellow Card, Red Card, Yellow Red Card")]
        [DataMember(Name = "Type", Order = 3)]
        public string Type { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 4)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO")]
        [DataMember(Name = "PlayerId", Order = 5)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// The name of the player who was booked 
        /// </summary>
        [Description("The name of the player who was booked ")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The minute in the game in which the booking occurred
        /// </summary>
        [Description("The minute in the game in which the booking occurred")]
        [DataMember(Name = "GameMinute", Order = 7)]
        public int? GameMinute { get; set; }

        /// <summary>
        /// The extra minute in the game in which the booking occurred
        /// </summary>
        [Description("The extra minute in the game in which the booking occurred")]
        [DataMember(Name = "GameMinuteExtra", Order = 8)]
        public int? GameMinuteExtra { get; set; }

    }
}

