using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Tournament")]
    [Serializable]
    public partial class Tournament
    {
        /// <summary>
        /// The unique ID of the tournament. Note: this field is specific to March Madness tournament & does not include other tournaments
        /// </summary>
        [Description("The unique ID of the tournament. Note: this field is specific to March Madness tournament & does not include other tournaments")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The season that the tournament occurs in. Note: season is a single year that the majority of the season occurs in
        /// </summary>
        [Description("The season that the tournament occurs in. Note: season is a single year that the majority of the season occurs in")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The name of the tournament
        /// </summary>
        [Description("The name of the tournament")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Where the tournament in question is located/being played
        /// </summary>
        [Description("Where the tournament in question is located/being played")]
        [DataMember(Name = "Location", Order = 4)]
        public string Location { get; set; }

        /// <summary>
        /// Shows a list of games that are held within a tournament for a given season
        /// </summary>
        [Description("Shows a list of games that are held within a tournament for a given season")]
        [DataMember(Name = "Games", Order = 20005)]
        public Game[] Games { get; set; }

        /// <summary>
        /// The region that is designated to be in the top-left of the NCAA Tournament bracket
        /// </summary>
        [Description("The region that is designated to be in the top-left of the NCAA Tournament bracket")]
        [DataMember(Name = "LeftTopBracketConference", Order = 6)]
        public string LeftTopBracketConference { get; set; }

        /// <summary>
        /// The region that is designated to be in the bottom-left of the NCAA Tournament bracket
        /// </summary>
        [Description("The region that is designated to be in the bottom-left of the NCAA Tournament bracket")]
        [DataMember(Name = "LeftBottomBracketConference", Order = 7)]
        public string LeftBottomBracketConference { get; set; }

        /// <summary>
        /// The region that is designated to be in the top-right of the NCAA Tournament bracket
        /// </summary>
        [Description("The region that is designated to be in the top-right of the NCAA Tournament bracket")]
        [DataMember(Name = "RightTopBracketConference", Order = 8)]
        public string RightTopBracketConference { get; set; }

        /// <summary>
        /// The region that is designated to be in the bottom-right of the NCAA Tournament bracket
        /// </summary>
        [Description("The region that is designated to be in the bottom-right of the NCAA Tournament bracket")]
        [DataMember(Name = "RightBottomBracketConference", Order = 9)]
        public string RightBottomBracketConference { get; set; }

    }
}

