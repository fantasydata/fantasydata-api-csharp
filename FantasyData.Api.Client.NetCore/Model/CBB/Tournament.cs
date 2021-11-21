using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
{
    [DataContract(Namespace="", Name="Tournament")]
    [Serializable]
    public partial class Tournament
    {
        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 1)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The college basketball season of the tournament
        /// </summary>
        [Description("The college basketball season of the tournament")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The name of the tournament
        /// </summary>
        [Description("The name of the tournament")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The location of the tournament
        /// </summary>
        [Description("The location of the tournament")]
        [DataMember(Name = "Location", Order = 4)]
        public string Location { get; set; }

        /// <summary>
        /// The games of this tournament
        /// </summary>
        [Description("The games of this tournament")]
        [DataMember(Name = "Games", Order = 20005)]
        public Game[] Games { get; set; }

        /// <summary>
        /// The conference that is displayed on the top-left when rendering the tournament bracket.
        /// </summary>
        [Description("The conference that is displayed on the top-left when rendering the tournament bracket.")]
        [DataMember(Name = "LeftTopBracketConference", Order = 6)]
        public string LeftTopBracketConference { get; set; }

        /// <summary>
        /// The conference that is displayed on the bottom-left when rendering the tournament bracket.
        /// </summary>
        [Description("The conference that is displayed on the bottom-left when rendering the tournament bracket.")]
        [DataMember(Name = "LeftBottomBracketConference", Order = 7)]
        public string LeftBottomBracketConference { get; set; }

        /// <summary>
        /// The conference that is displayed on the top-right when rendering the tournament bracket.
        /// </summary>
        [Description("The conference that is displayed on the top-right when rendering the tournament bracket.")]
        [DataMember(Name = "RightTopBracketConference", Order = 8)]
        public string RightTopBracketConference { get; set; }

        /// <summary>
        /// The conference that is displayed on the bottom-right when rendering the tournament bracket.
        /// </summary>
        [Description("The conference that is displayed on the bottom-right when rendering the tournament bracket.")]
        [DataMember(Name = "RightBottomBracketConference", Order = 9)]
        public string RightBottomBracketConference { get; set; }

    }
}

