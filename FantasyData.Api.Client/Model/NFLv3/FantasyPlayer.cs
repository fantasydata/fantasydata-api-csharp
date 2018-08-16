using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="FantasyPlayer")]
    [Serializable]
    public partial class FantasyPlayer
    {
        /// <summary>
        /// Unique identifier of this fantasy player.  If this is a team defense, then this is the abbreviation of the team.  This field contains both integers and strings and should be treated as a string.  This value is guaranteed to be unique among all players and teams and can be used as the primary key for the FantasyPlayer table.
        /// </summary>
        [Description("Unique identifier of this fantasy player.  If this is a team defense, then this is the abbreviation of the team.  This field contains both integers and strings and should be treated as a string.  This value is guaranteed to be unique among all players and teams and can be used as the primary key for the FantasyPlayer table.")]
        [DataMember(Name = "FantasyPlayerKey", Order = 1)]
        public string FantasyPlayerKey { get; set; }

        /// <summary>
        /// PlayerID of this FantasyPlayer.  For players, this is the same as the PlayerID.  For teams, this is the uniquely generated PlayerID on the Team table.  This number is guaranteed to be unique among all players and teams and can be used as the primary key for the FantasyPlayer table.
        /// </summary>
        [Description("PlayerID of this FantasyPlayer.  For players, this is the same as the PlayerID.  For teams, this is the uniquely generated PlayerID on the Team table.  This number is guaranteed to be unique among all players and teams and can be used as the primary key for the FantasyPlayer table.")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The name of the player or team.
        /// </summary>
        [Description("The name of the player or team.")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the team this player is on.  If player is a free agent, this field is NULL.
        /// </summary>
        [Description("The abbreviation of the team this player is on.  If player is a free agent, this field is NULL.")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The fantasy position of this player or team (QB, RB, WR, TE, K, DEF)
        /// </summary>
        [Description("The fantasy position of this player or team (QB, RB, WR, TE, K, DEF)")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// The average draft position of this player in re-draft leagues.
        /// </summary>
        [Description("The average draft position of this player in re-draft leagues.")]
        [DataMember(Name = "AverageDraftPosition", Order = 6)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The average draft position of this player in PPR re-draft leagues.
        /// </summary>
        [Description("The average draft position of this player in PPR re-draft leagues.")]
        [DataMember(Name = "AverageDraftPositionPPR", Order = 7)]
        public decimal? AverageDraftPositionPPR { get; set; }

        /// <summary>
        /// The bye week of the team this player is currently on.
        /// </summary>
        [Description("The bye week of the team this player is currently on.")]
        [DataMember(Name = "ByeWeek", Order = 8)]
        public int? ByeWeek { get; set; }

        /// <summary>
        /// The fantasy points scored by this player or team last season.
        /// </summary>
        [Description("The fantasy points scored by this player or team last season.")]
        [DataMember(Name = "LastSeasonFantasyPoints", Order = 9)]
        public decimal? LastSeasonFantasyPoints { get; set; }

        /// <summary>
        /// The projected fantasy points this player will score this upcoming season.
        /// </summary>
        [Description("The projected fantasy points this player will score this upcoming season.")]
        [DataMember(Name = "ProjectedFantasyPoints", Order = 10)]
        public decimal? ProjectedFantasyPoints { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap auction draft.")]
        [DataMember(Name = "AuctionValue", Order = 11)]
        public int? AuctionValue { get; set; }

        /// <summary>
        /// Player's dollar value in a $200 salary cap PPR auction draft.
        /// </summary>
        [Description("Player's dollar value in a $200 salary cap PPR auction draft.")]
        [DataMember(Name = "AuctionValuePPR", Order = 12)]
        public int? AuctionValuePPR { get; set; }

        /// <summary>
        /// The average draft position of this player in IDP re-draft leagues.
        /// </summary>
        [Description("The average draft position of this player in IDP re-draft leagues.")]
        [DataMember(Name = "AverageDraftPositionIDP", Order = 13)]
        public int? AverageDraftPositionIDP { get; set; }

        /// <summary>
        /// The average draft position of this player in rookie drafts.
        /// </summary>
        [Description("The average draft position of this player in rookie drafts.")]
        [DataMember(Name = "AverageDraftPositionRookie", Order = 14)]
        public decimal? AverageDraftPositionRookie { get; set; }

        /// <summary>
        /// The average draft position of this player in dynasty leagues.
        /// </summary>
        [Description("The average draft position of this player in dynasty leagues.")]
        [DataMember(Name = "AverageDraftPositionDynasty", Order = 15)]
        public decimal? AverageDraftPositionDynasty { get; set; }

        /// <summary>
        /// The average draft position of this player in 2 Quarterback re-draft leagues.
        /// </summary>
        [Description("The average draft position of this player in 2 Quarterback re-draft leagues.")]
        [DataMember(Name = "AverageDraftPosition2QB", Order = 16)]
        public decimal? AverageDraftPosition2QB { get; set; }

    }
}

