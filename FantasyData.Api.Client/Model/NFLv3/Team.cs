using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// Abbreviation of the team (e.g. SD, PHI, NE, IND, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. SD, PHI, NE, IND, etc.)")]
        [DataMember(Name = "Key", Order = 1)]
        public string Key { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team.
        /// </summary>
        [Description("The auto-generated unique ID of the Team.")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team, that avoids collisions with PlayerIDs.  This is useful when combining players and fantasy defenses to create fantasy teams.
        /// </summary>
        [Description("The auto-generated unique ID of the Team, that avoids collisions with PlayerIDs.  This is useful when combining players and fantasy defenses to create fantasy teams.")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. San Diego, Philadelphia, New England, Indianapolis, etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. San Diego, Philadelphia, New England, Indianapolis, etc.)")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Chargers, Eagles, Patriots, Colts, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Chargers, Eagles, Patriots, Colts, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (e.g. AFC or NFC)
        /// </summary>
        [Description("The conference of the team (e.g. AFC or NFC)")]
        [DataMember(Name = "Conference", Order = 6)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. East, North, South, West)
        /// </summary>
        [Description("The division of the team (e.g. East, North, South, West)")]
        [DataMember(Name = "Division", Order = 7)]
        public string Division { get; set; }

        /// <summary>
        /// The full name of the team (e.g. New England Patriots)
        /// </summary>
        [Description("The full name of the team (e.g. New England Patriots)")]
        [DataMember(Name = "FullName", Order = 8)]
        public string FullName { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 9)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The bye week of the team in the upcoming regular season
        /// </summary>
        [Description("The bye week of the team in the upcoming regular season")]
        [DataMember(Name = "ByeWeek", Order = 10)]
        public int? ByeWeek { get; set; }

        /// <summary>
        /// The average draft position of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPosition", Order = 11)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The average draft position in PPR leagues of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position in PPR leagues of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPositionPPR", Order = 12)]
        public decimal? AverageDraftPositionPPR { get; set; }

        /// <summary>
        /// The current head coach of the team
        /// </summary>
        [Description("The current head coach of the team")]
        [DataMember(Name = "HeadCoach", Order = 13)]
        public string HeadCoach { get; set; }

        /// <summary>
        /// The current offensive coordinator of the team
        /// </summary>
        [Description("The current offensive coordinator of the team")]
        [DataMember(Name = "OffensiveCoordinator", Order = 14)]
        public string OffensiveCoordinator { get; set; }

        /// <summary>
        /// The current defensive coordinator of the team
        /// </summary>
        [Description("The current defensive coordinator of the team")]
        [DataMember(Name = "DefensiveCoordinator", Order = 15)]
        public string DefensiveCoordinator { get; set; }

        /// <summary>
        /// The current special teams coach of the team
        /// </summary>
        [Description("The current special teams coach of the team")]
        [DataMember(Name = "SpecialTeamsCoach", Order = 16)]
        public string SpecialTeamsCoach { get; set; }

        /// <summary>
        /// The offensive scheme this team runs (PRO, 2TE, 3WR).  This is decided at our discretion.
        /// </summary>
        [Description("The offensive scheme this team runs (PRO, 2TE, 3WR).  This is decided at our discretion.")]
        [DataMember(Name = "OffensiveScheme", Order = 17)]
        public string OffensiveScheme { get; set; }

        /// <summary>
        /// The current defensive scheme this team runs (3-4, 4-3)
        /// </summary>
        [Description("The current defensive scheme this team runs (3-4, 4-3)")]
        [DataMember(Name = "DefensiveScheme", Order = 18)]
        public string DefensiveScheme { get; set; }

        /// <summary>
        /// The team's DEF/ST salary for the upcoming week in accordance with a $50,000 salary cap.  This is used for daily fantasy sports salary cap contests.  Salaries represent those published by DraftKings. When DraftKings doesn't publish a salary for a given game, the most recent DraftKings salary is used.
        /// </summary>
        [Description("The team's DEF/ST salary for the upcoming week in accordance with a $50,000 salary cap.  This is used for daily fantasy sports salary cap contests.  Salaries represent those published by DraftKings. When DraftKings doesn't publish a salary for a given game, the most recent DraftKings salary is used.")]
        [DataMember(Name = "UpcomingSalary", Order = 19)]
        public int? UpcomingSalary { get; set; }

        /// <summary>
        /// The team's upcoming opponent's rank in DEF/ST fantasy points allowed.
        /// </summary>
        [Description("The team's upcoming opponent's rank in DEF/ST fantasy points allowed.")]
        [DataMember(Name = "UpcomingOpponent", Order = 20)]
        public string UpcomingOpponent { get; set; }

        /// <summary>
        /// The team's upcoming opponent's rank in DEF/ST fantasy points allowed.
        /// </summary>
        [Description("The team's upcoming opponent's rank in DEF/ST fantasy points allowed.")]
        [DataMember(Name = "UpcomingOpponentRank", Order = 21)]
        public int? UpcomingOpponentRank { get; set; }

        /// <summary>
        /// The team's upcoming opponent's rank in DEF/ST fantasy points allowed.
        /// </summary>
        [Description("The team's upcoming opponent's rank in DEF/ST fantasy points allowed.")]
        [DataMember(Name = "UpcomingOpponentPositionRank", Order = 22)]
        public int? UpcomingOpponentPositionRank { get; set; }

        /// <summary>
        /// The team's DEF/ST FanDuel salary for the upcoming week.
        /// </summary>
        [Description("The team's DEF/ST FanDuel salary for the upcoming week.")]
        [DataMember(Name = "UpcomingFanDuelSalary", Order = 23)]
        public int? UpcomingFanDuelSalary { get; set; }

        /// <summary>
        /// The team's DEF/ST DraftKings salary for the upcoming week.
        /// </summary>
        [Description("The team's DEF/ST DraftKings salary for the upcoming week.")]
        [DataMember(Name = "UpcomingDraftKingsSalary", Order = 24)]
        public int? UpcomingDraftKingsSalary { get; set; }

        /// <summary>
        /// The team's DEF/ST Yahoo salary for the upcoming week.
        /// </summary>
        [Description("The team's DEF/ST Yahoo salary for the upcoming week.")]
        [DataMember(Name = "UpcomingYahooSalary", Order = 25)]
        public int? UpcomingYahooSalary { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 26)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 27)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 28)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 29)]
        public string QuaternaryColor { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoUrl", Order = 30)]
        public string WikipediaLogoUrl { get; set; }

        /// <summary>
        /// The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaWordMarkUrl", Order = 31)]
        public string WikipediaWordMarkUrl { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 32)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Team's DST name on DraftKings daily fantasy contests
        /// </summary>
        [Description("Team's DST name on DraftKings daily fantasy contests")]
        [DataMember(Name = "DraftKingsName", Order = 33)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// Team's DST player ID on DraftKings daily fantasy contests
        /// </summary>
        [Description("Team's DST player ID on DraftKings daily fantasy contests")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 34)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// Team's DST name on FanDuel daily fantasy contests
        /// </summary>
        [Description("Team's DST name on FanDuel daily fantasy contests")]
        [DataMember(Name = "FanDuelName", Order = 35)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// Team's DST player ID on FanDuel daily fantasy contests
        /// </summary>
        [Description("Team's DST player ID on FanDuel daily fantasy contests")]
        [DataMember(Name = "FanDuelPlayerID", Order = 36)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// Team's DST name on daily fantasyDraft daily fantasy contests
        /// </summary>
        [Description("Team's DST name on daily fantasyDraft daily fantasy contests")]
        [DataMember(Name = "FantasyDraftName", Order = 37)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// Team's DST player ID on daily fantasyDraft daily fantasy contests
        /// </summary>
        [Description("Team's DST player ID on daily fantasyDraft daily fantasy contests")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 38)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// Team's DST name on Yahoo daily fantasy contests
        /// </summary>
        [Description("Team's DST name on Yahoo daily fantasy contests")]
        [DataMember(Name = "YahooName", Order = 39)]
        public string YahooName { get; set; }

        /// <summary>
        /// Team's DST player ID on Yahoo daily fantasy contests
        /// </summary>
        [Description("Team's DST player ID on Yahoo daily fantasy contests")]
        [DataMember(Name = "YahooPlayerID", Order = 40)]
        public int? YahooPlayerID { get; set; }

        /// <summary>
        /// The details of this team's home stadium
        /// </summary>
        [Description("The details of this team's home stadium")]
        [DataMember(Name = "StadiumDetails", Order = 10041)]
        public Stadium StadiumDetails { get; set; }

        /// <summary>
        /// The average draft position in 2 QuarterBack Leagues of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position in 2 QuarterBack Leagues of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPosition2QB", Order = 42)]
        public decimal? AverageDraftPosition2QB { get; set; }

        /// <summary>
        /// The average draft position in dynasty of the team's fantasy defense (DST)
        /// </summary>
        [Description("The average draft position in dynasty of the team's fantasy defense (DST)")]
        [DataMember(Name = "AverageDraftPositionDynasty", Order = 43)]
        public decimal? AverageDraftPositionDynasty { get; set; }

    }
}

