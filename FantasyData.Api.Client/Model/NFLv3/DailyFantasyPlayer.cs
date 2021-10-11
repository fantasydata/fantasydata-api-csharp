using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="DailyFantasyPlayer")]
    [Serializable]
    public partial class DailyFantasyPlayer
    {
        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The date/time of the event
        /// </summary>
        [Description("The date/time of the event")]
        [DataMember(Name = "Date", Order = 2)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Player's short name (typically first initial and last name)
        /// </summary>
        [Description("Player's short name (typically first initial and last name)")]
        [DataMember(Name = "ShortName", Order = 3)]
        public string ShortName { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the team of this player
        /// </summary>
        [Description("The abbreviation of the team of this player")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation of the upcoming opponent
        /// </summary>
        [Description("The abbreviation of the upcoming opponent")]
        [DataMember(Name = "Opponent", Order = 6)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the player is Home or Away
        /// </summary>
        [Description("Whether the player is Home or Away")]
        [DataMember(Name = "HomeOrAway", Order = 7)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The player's daily fantasy position
        /// </summary>
        [Description("The player's daily fantasy position")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's daily fantasy salary as determined by FantasyData, based on a $60,000 salary cap
        /// </summary>
        [Description("The player's daily fantasy salary as determined by FantasyData, based on a $60,000 salary cap")]
        [DataMember(Name = "Salary", Order = 9)]
        public int Salary { get; set; }

        /// <summary>
        /// The fantasy points scored by this player in the last game played
        /// </summary>
        [Description("The fantasy points scored by this player in the last game played")]
        [DataMember(Name = "LastGameFantasyPoints", Order = 10)]
        public decimal? LastGameFantasyPoints { get; set; }

        /// <summary>
        /// The projected fantasy points this player will score in the upcoming event
        /// </summary>
        [Description("The projected fantasy points this player will score in the upcoming event")]
        [DataMember(Name = "ProjectedFantasyPoints", Order = 11)]
        public decimal? ProjectedFantasyPoints { get; set; }

        /// <summary>
        /// The upcoming opponent's rank in fantasy points allowed
        /// </summary>
        [Description("The upcoming opponent's rank in fantasy points allowed")]
        [DataMember(Name = "OpponentRank", Order = 12)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The upcoming opponent's rank in fantasy points allowed to players at this player's position
        /// </summary>
        [Description("The upcoming opponent's rank in fantasy points allowed to players at this player's position")]
        [DataMember(Name = "OpponentPositionRank", Order = 13)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.
        /// </summary>
        [Description("The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.")]
        [DataMember(Name = "Status", Order = 14)]
        public string Status { get; set; }

        /// <summary>
        /// The shortened code representing the player's Status
        /// </summary>
        [Description("The shortened code representing the player's Status")]
        [DataMember(Name = "StatusCode", Order = 15)]
        public string StatusCode { get; set; }

        /// <summary>
        /// The color indicating how attractive this players status is (red, yellow, green)
        /// </summary>
        [Description("The color indicating how attractive this players status is (red, yellow, green)")]
        [DataMember(Name = "StatusColor", Order = 16)]
        public string StatusColor { get; set; }

        /// <summary>
        /// The player's salary for FanDuel daily fantasy contests.
        /// </summary>
        [Description("The player's salary for FanDuel daily fantasy contests.")]
        [DataMember(Name = "FanDuelSalary", Order = 17)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The player's salary for DraftKings daily fantasy contests.
        /// </summary>
        [Description("The player's salary for DraftKings daily fantasy contests.")]
        [DataMember(Name = "DraftKingsSalary", Order = 18)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 19)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// The player's salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).
        /// </summary>
        [Description("The player's salary as calculated by FantasyData.  Based on the same salary cap as DraftKings contests ($50,000).")]
        [DataMember(Name = "FantasyDataSalary", Order = 20)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The team's DEF/ST salary for FantasyDraft daily fantasy contests.
        /// </summary>
        [Description("The team's DEF/ST salary for FantasyDraft daily fantasy contests.")]
        [DataMember(Name = "FantasyDraftSalary", Order = 21)]
        public int? FantasyDraftSalary { get; set; }

    }
}

