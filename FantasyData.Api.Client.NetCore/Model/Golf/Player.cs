using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Golf
{
    [DataContract(Namespace="", Name="Player")]
    [Serializable]
    public partial class Player
    {
        /// <summary>
        /// The unique ID of this golfer
        /// </summary>
        [Description("The unique ID of this golfer")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The first name of this golfer
        /// </summary>
        [Description("The first name of this golfer")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this golfer
        /// </summary>
        [Description("The last name of this golfer")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The golfer's weight (in pounds)
        /// </summary>
        [Description("The golfer's weight (in pounds)")]
        [DataMember(Name = "Weight", Order = 4)]
        public int? Weight { get; set; }

        /// <summary>
        /// Indicates whether this golfer is right-handed or left-handed (Possible values: R, L)
        /// </summary>
        [Description("Indicates whether this golfer is right-handed or left-handed (Possible values: R, L)")]
        [DataMember(Name = "Swings", Order = 5)]
        public string Swings { get; set; }

        /// <summary>
        /// The year that this golfer made his PGA debut
        /// </summary>
        [Description("The year that this golfer made his PGA debut")]
        [DataMember(Name = "PgaDebut", Order = 6)]
        public int? PgaDebut { get; set; }

        /// <summary>
        /// The country where this golfer is from
        /// </summary>
        [Description("The country where this golfer is from")]
        [DataMember(Name = "Country", Order = 7)]
        public string Country { get; set; }

        /// <summary>
        /// The birthday of this golfer
        /// </summary>
        [Description("The birthday of this golfer")]
        [DataMember(Name = "BirthDate", Order = 8)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city where this golfer was born
        /// </summary>
        [Description("The city where this golfer was born")]
        [DataMember(Name = "BirthCity", Order = 9)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state where this golfer was born
        /// </summary>
        [Description("The state where this golfer was born")]
        [DataMember(Name = "BirthState", Order = 10)]
        public string BirthState { get; set; }

        /// <summary>
        /// The college that this golfer attended
        /// </summary>
        [Description("The college that this golfer attended")]
        [DataMember(Name = "College", Order = 11)]
        public string College { get; set; }

        /// <summary>
        /// The URL of this golfer's headshot photo
        /// </summary>
        [Description("The URL of this golfer's headshot photo")]
        [DataMember(Name = "PhotoUrl", Order = 12)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The unique ID of this golfer in the SportRadar API
        /// </summary>
        [Description("The unique ID of this golfer in the SportRadar API")]
        [DataMember(Name = "SportRadarPlayerID", Order = 13)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on PGATour.com
        /// </summary>
        [Description("The unique ID of this golfer on PGATour.com")]
        [DataMember(Name = "PgaTourPlayerID", Order = 14)]
        public int? PgaTourPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on Rotoworld
        /// </summary>
        [Description("The unique ID of this golfer on Rotoworld")]
        [DataMember(Name = "RotoworldPlayerID", Order = 15)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on RotoWire
        /// </summary>
        [Description("The unique ID of this golfer on RotoWire")]
        [DataMember(Name = "RotoWirePlayerID", Order = 16)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on FantasyAlarm
        /// </summary>
        [Description("The unique ID of this golfer on FantasyAlarm")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 17)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// The name of this golfer on DraftKings
        /// </summary>
        [Description("The name of this golfer on DraftKings")]
        [DataMember(Name = "DraftKingsName", Order = 18)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// The name of this golfer on FantasyDraft
        /// </summary>
        [Description("The name of this golfer on FantasyDraft")]
        [DataMember(Name = "FantasyDraftName", Order = 19)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// The name of this golfer on FanDuel
        /// </summary>
        [Description("The name of this golfer on FanDuel")]
        [DataMember(Name = "FanDuelName", Order = 20)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// The unique ID of this golfer on FantasyDraft
        /// </summary>
        [Description("The unique ID of this golfer on FantasyDraft")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 21)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on DraftKings
        /// </summary>
        [Description("The unique ID of this golfer on DraftKings")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 22)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on FanDuel
        /// </summary>
        [Description("The unique ID of this golfer on FanDuel")]
        [DataMember(Name = "FanDuelPlayerID", Order = 23)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// The unique ID of this golfer on Yahoo
        /// </summary>
        [Description("The unique ID of this golfer on Yahoo")]
        [DataMember(Name = "YahooPlayerID", Order = 24)]
        public int? YahooPlayerID { get; set; }

    }
}

