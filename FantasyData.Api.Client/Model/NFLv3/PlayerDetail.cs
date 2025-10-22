using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerDetail")]
    [Serializable]
    public partial class PlayerDetail
    {
        /// <summary>
        /// This field is expected to be NULL
        /// </summary>
        [Description("This field is expected to be NULL")]
        [DataMember(Name = "PlayerSeason", Order = 10001)]
        public PlayerSeason PlayerSeason { get; set; }

        /// <summary>
        /// The latest news associated with this player
        /// </summary>
        [Description("The latest news associated with this player")]
        [DataMember(Name = "LatestNews", Order = 20002)]
        public News[] LatestNews { get; set; }

        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career.
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career.")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL.
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL.")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Player's jersey number
        /// </summary>
        [Description("Player's jersey number")]
        [DataMember(Name = "Number", Order = 5)]
        public int? Number { get; set; }

        /// <summary>
        /// Player's first name
        /// </summary>
        [Description("Player's first name")]
        [DataMember(Name = "FirstName", Order = 6)]
        public string FirstName { get; set; }

        /// <summary>
        /// Player's last name
        /// </summary>
        [Description("Player's last name")]
        [DataMember(Name = "LastName", Order = 7)]
        public string LastName { get; set; }

        /// <summary>
        /// The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR.
        /// </summary>
        [Description("The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR.")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.
        /// </summary>
        [Description("The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.")]
        [DataMember(Name = "Status", Order = 9)]
        public string Status { get; set; }

        /// <summary>
        /// Height in feet, inches
        /// </summary>
        [Description("Height in feet, inches")]
        [DataMember(Name = "Height", Order = 10)]
        public string Height { get; set; }

        /// <summary>
        /// Player's weight in pounds
        /// </summary>
        [Description("Player's weight in pounds")]
        [DataMember(Name = "Weight", Order = 11)]
        public int? Weight { get; set; }

        /// <summary>
        /// Player's date of birth
        /// </summary>
        [Description("Player's date of birth")]
        [DataMember(Name = "BirthDate", Order = 12)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// College team the player played for prior to turning professional
        /// </summary>
        [Description("College team the player played for prior to turning professional")]
        [DataMember(Name = "College", Order = 13)]
        public string College { get; set; }

        /// <summary>
        /// Number of years experience.  Note: This number is incremented every year; in the Spring; when we load the rookies following the NFL Draft. Rookies will have Experience = 0; while second year players will have Experience = 2.
        /// </summary>
        [Description("Number of years experience.  Note: This number is incremented every year; in the Spring; when we load the rookies following the NFL Draft. Rookies will have Experience = 0; while second year players will have Experience = 2.")]
        [DataMember(Name = "Experience", Order = 14)]
        public int? Experience { get; set; }

        /// <summary>
        /// The player's fantasy football position. Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL.
        /// </summary>
        [Description("The player's fantasy football position. Possible values: QB; RB; WR; TE; DL; LB; DB; K; P; OL.")]
        [DataMember(Name = "FantasyPosition", Order = 15)]
        public string FantasyPosition { get; set; }

        /// <summary>
        /// Whether or not the player is on the active roster of the NFL team (True/False)
        /// </summary>
        [Description("Whether or not the player is on the active roster of the NFL team (True/False)")]
        [DataMember(Name = "Active", Order = 16)]
        public bool? Active { get; set; }

        /// <summary>
        /// The category of the player's position (OFF; DEF; ST)
        /// </summary>
        [Description("The category of the player's position (OFF; DEF; ST)")]
        [DataMember(Name = "PositionCategory", Order = 17)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 18)]
        public string Name { get; set; }

        /// <summary>
        /// The player's current age
        /// </summary>
        [Description("The player's current age")]
        [DataMember(Name = "Age", Order = 19)]
        public int? Age { get; set; }

        /// <summary>
        /// The player's experience converted to a string
        /// </summary>
        [Description("The player's experience converted to a string")]
        [DataMember(Name = "ExperienceString", Order = 20)]
        public string ExperienceString { get; set; }

        /// <summary>
        /// The player's date of birth converted to a string
        /// </summary>
        [Description("The player's date of birth converted to a string")]
        [DataMember(Name = "BirthDateString", Order = 21)]
        public string BirthDateString { get; set; }

        /// <summary>
        /// This field is deprecated. Note: Headshots are now delivered through IMAGN. Please see our Headshots products for further information.
        /// </summary>
        [Description("This field is deprecated. Note: Headshots are now delivered through IMAGN. Please see our Headshots products for further information.")]
        [DataMember(Name = "PhotoUrl", Order = 22)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The week the player is on bye for the upcoming or current season
        /// </summary>
        [Description("The week the player is on bye for the upcoming or current season")]
        [DataMember(Name = "ByeWeek", Order = 23)]
        public int? ByeWeek { get; set; }

        /// <summary>
        /// The opposing team the player is playing against in the upcoming week
        /// </summary>
        [Description("The opposing team the player is playing against in the upcoming week")]
        [DataMember(Name = "UpcomingGameOpponent", Order = 24)]
        public string UpcomingGameOpponent { get; set; }

        /// <summary>
        /// The week of the player's upcoming game (this will be the upcoming week unless the player is on Bye that week, which would bump it to the next week)
        /// </summary>
        [Description("The week of the player's upcoming game (this will be the upcoming week unless the player is on Bye that week, which would bump it to the next week)")]
        [DataMember(Name = "UpcomingGameWeek", Order = 25)]
        public int UpcomingGameWeek { get; set; }

        /// <summary>
        /// The first initial and last name of the player (J. Doe)
        /// </summary>
        [Description("The first initial and last name of the player (J. Doe)")]
        [DataMember(Name = "ShortName", Order = 26)]
        public string ShortName { get; set; }

        /// <summary>
        /// The average draft position of the player in re-draft leagues
        /// </summary>
        [Description("The average draft position of the player in re-draft leagues")]
        [DataMember(Name = "AverageDraftPosition", Order = 27)]
        public decimal? AverageDraftPosition { get; set; }

        /// <summary>
        /// The category (Offense, Defense or Special Teams) of the players DepthPositionCategory (OFF, DEF, ST)
        /// </summary>
        [Description("The category (Offense, Defense or Special Teams) of the players DepthPositionCategory (OFF, DEF, ST)")]
        [DataMember(Name = "DepthPositionCategory", Order = 28)]
        public string DepthPositionCategory { get; set; }

        /// <summary>
        /// The position this player is listed at on his team's depth chart (e.g. QB; LWR; RDE; LILB, K)
        /// </summary>
        [Description("The position this player is listed at on his team's depth chart (e.g. QB; LWR; RDE; LILB, K)")]
        [DataMember(Name = "DepthPosition", Order = 29)]
        public string DepthPosition { get; set; }

        /// <summary>
        /// The order this player is at his position (1 = Starter; 2 = Backup; 3 = 3rd String; 4 = 4th String; 5 = 5th String)
        /// </summary>
        [Description("The order this player is at his position (1 = Starter; 2 = Backup; 3 = 3rd String; 4 = 4th String; 5 = 5th String)")]
        [DataMember(Name = "DepthOrder", Order = 30)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// The display order of the positions (for display purposes)
        /// </summary>
        [Description("The display order of the positions (for display purposes)")]
        [DataMember(Name = "DepthDisplayOrder", Order = 31)]
        public int? DepthDisplayOrder { get; set; }

        /// <summary>
        /// The team who currently employs this player. This value is null when this player is unemployed (for example a free agent or retired player).
        /// </summary>
        [Description("The team who currently employs this player. This value is null when this player is unemployed (for example a free agent or retired player).")]
        [DataMember(Name = "CurrentTeam", Order = 32)]
        public string CurrentTeam { get; set; }

        /// <summary>
        /// The team who drafted this player. Note: If this player was an Undrafted Free Agent; then it's the team who first signed him as a rookie.
        /// </summary>
        [Description("The team who drafted this player. Note: If this player was an Undrafted Free Agent; then it's the team who first signed him as a rookie.")]
        [DataMember(Name = "CollegeDraftTeam", Order = 33)]
        public string CollegeDraftTeam { get; set; }

        /// <summary>
        /// The year this player entered the NFL as a rookie
        /// </summary>
        [Description("The year this player entered the NFL as a rookie")]
        [DataMember(Name = "CollegeDraftYear", Order = 34)]
        public int? CollegeDraftYear { get; set; }

        /// <summary>
        /// The round this player was drafted in
        /// </summary>
        [Description("The round this player was drafted in")]
        [DataMember(Name = "CollegeDraftRound", Order = 35)]
        public int? CollegeDraftRound { get; set; }

        /// <summary>
        /// The overall pick in the draft this player was selected
        /// </summary>
        [Description("The overall pick in the draft this player was selected")]
        [DataMember(Name = "CollegeDraftPick", Order = 36)]
        public int? CollegeDraftPick { get; set; }

        /// <summary>
        /// Whether this player was an undrafted free agent. This value is True if the player was not drafted.
        /// </summary>
        [Description("Whether this player was an undrafted free agent. This value is True if the player was not drafted.")]
        [DataMember(Name = "IsUndraftedFreeAgent", Order = 37)]
        public bool IsUndraftedFreeAgent { get; set; }

        /// <summary>
        /// The feet component of a player's height (if player is 6'3", then this value would be 6)
        /// </summary>
        [Description("The feet component of a player's height (if player is 6'3\", then this value would be 6)")]
        [DataMember(Name = "HeightFeet", Order = 38)]
        public int? HeightFeet { get; set; }

        /// <summary>
        /// The inches component of a player's height (if player is 6'3", then this value would be 3)
        /// </summary>
        [Description("The inches component of a player's height (if player is 6'3\", then this value would be 3)")]
        [DataMember(Name = "HeightInches", Order = 39)]
        public int? HeightInches { get; set; }

        /// <summary>
        /// The player's upcoming opponent's rank in fantasy points allowed
        /// </summary>
        [Description("The player's upcoming opponent's rank in fantasy points allowed")]
        [DataMember(Name = "UpcomingOpponentRank", Order = 40)]
        public int? UpcomingOpponentRank { get; set; }

        /// <summary>
        /// The player's upcoming opponent's rank in fantasy points allowed to his fantasy position
        /// </summary>
        [Description("The player's upcoming opponent's rank in fantasy points allowed to his fantasy position")]
        [DataMember(Name = "UpcomingOpponentPositionRank", Order = 41)]
        public int? UpcomingOpponentPositionRank { get; set; }

        /// <summary>
        /// The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.  Can also include injury status.
        /// </summary>
        [Description("The player's current status.  Possible values include Active, Inactive, Injured Reserve, Physically Unable to Perform, Practice Squad, Suspended, Non Football Injury, Non-Football Illness, Commissioner Exempt List, Exempt/Left Team, Paternity, Bereavement, Reserve/COVID-19, and Voluntary Opt Out. Inactive indicates that this player is a free agent.  Active indicates that this player is on his team's active roster.  Can also include injury status.")]
        [DataMember(Name = "CurrentStatus", Order = 42)]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// The player's salary for the upcoming week in accordance with a $50,000 salary cap. This is used for daily fantasy sports salary cap contests. Salaries represent those published by DraftKings. When DraftKings doesn't publish a salary for a given game; the most recent DraftKings salary is used. We recommend using our new DFS endpoints instead.
        /// </summary>
        [Description("The player's salary for the upcoming week in accordance with a $50,000 salary cap. This is used for daily fantasy sports salary cap contests. Salaries represent those published by DraftKings. When DraftKings doesn't publish a salary for a given game; the most recent DraftKings salary is used. We recommend using our new DFS endpoints instead.")]
        [DataMember(Name = "UpcomingSalary", Order = 43)]
        public int? UpcomingSalary { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the FantasyAlarm news feed
        /// </summary>
        [Description("The player's cross reference PlayerID to the FantasyAlarm news feed")]
        [DataMember(Name = "FantasyAlarmPlayerID", Order = 44)]
        public int? FantasyAlarmPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportRadar API
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportRadar API")]
        [DataMember(Name = "SportRadarPlayerID", Order = 45)]
        public string SportRadarPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the Rotoworld news feed
        /// </summary>
        [Description("The player's cross reference PlayerID to the Rotoworld news feed")]
        [DataMember(Name = "RotoworldPlayerID", Order = 46)]
        public int? RotoworldPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the RotoWire news feed
        /// </summary>
        [Description("The player's cross reference PlayerID to the RotoWire news feed")]
        [DataMember(Name = "RotoWirePlayerID", Order = 47)]
        public int? RotoWirePlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the STATS data feeds
        /// </summary>
        [Description("The player's cross reference PlayerID to the STATS data feeds")]
        [DataMember(Name = "StatsPlayerID", Order = 48)]
        public int? StatsPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to the SportsDirect data feeds, now part of Nielsen GraceNote
        /// </summary>
        [Description("The player's cross reference PlayerID to the SportsDirect data feeds, now part of Nielsen GraceNote")]
        [DataMember(Name = "SportsDirectPlayerID", Order = 49)]
        public int? SportsDirectPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with XML Team data feeds
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with XML Team data feeds")]
        [DataMember(Name = "XmlTeamPlayerID", Order = 50)]
        public int? XmlTeamPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to FanDuel
        /// </summary>
        [Description("The player's cross reference PlayerID to FanDuel")]
        [DataMember(Name = "FanDuelPlayerID", Order = 51)]
        public int? FanDuelPlayerID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to DraftKings
        /// </summary>
        [Description("The player's cross reference PlayerID to DraftKings")]
        [DataMember(Name = "DraftKingsPlayerID", Order = 52)]
        public int? DraftKingsPlayerID { get; set; }

        /// <summary>
        /// The player's unique PlayerID for cross reference use with Yahoo
        /// </summary>
        [Description("The player's unique PlayerID for cross reference use with Yahoo")]
        [DataMember(Name = "YahooPlayerID", Order = 53)]
        public int? YahooPlayerID { get; set; }

        /// <summary>
        /// The player's current injury status, in the form of likelihood that player plays (Probable, Questionable, Doubtful, Out)
        /// </summary>
        [Description("The player's current injury status, in the form of likelihood that player plays (Probable, Questionable, Doubtful, Out)")]
        [DataMember(Name = "InjuryStatus", Order = 54)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured for the player (Knee; Groin; Calf; Hamstring; etc.)
        /// </summary>
        [Description("The body part that is injured for the player (Knee; Groin; Calf; Hamstring; etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 55)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the player's injury started or was first discovered
        /// </summary>
        [Description("The day that the player's injury started or was first discovered")]
        [DataMember(Name = "InjuryStartDate", Order = 56)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// A brief description of the player's injury and expected availability
        /// </summary>
        [Description("A brief description of the player's injury and expected availability")]
        [DataMember(Name = "InjuryNotes", Order = 57)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's full name in FanDuel's daily fantasy sports platform
        /// </summary>
        [Description("The player's full name in FanDuel's daily fantasy sports platform")]
        [DataMember(Name = "FanDuelName", Order = 58)]
        public string FanDuelName { get; set; }

        /// <summary>
        /// The player's full name in DraftKings' daily fantasy sports platform
        /// </summary>
        [Description("The player's full name in DraftKings' daily fantasy sports platform")]
        [DataMember(Name = "DraftKingsName", Order = 59)]
        public string DraftKingsName { get; set; }

        /// <summary>
        /// The player's name in Yahoo's daily fantasy sports platform
        /// </summary>
        [Description("The player's name in Yahoo's daily fantasy sports platform")]
        [DataMember(Name = "YahooName", Order = 60)]
        public string YahooName { get; set; }

        /// <summary>
        /// The order this player is at his team's FantasyPosition
        /// </summary>
        [Description("The order this player is at his team's FantasyPosition")]
        [DataMember(Name = "FantasyPositionDepthOrder", Order = 61)]
        public int? FantasyPositionDepthOrder { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "InjuryPractice", Order = 62)]
        public string InjuryPractice { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "InjuryPracticeDescription", Order = 63)]
        public string InjuryPracticeDescription { get; set; }

        /// <summary>
        /// Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players.  Note: This is only updated for offensive skill position players (QB; RB; WR; TE).
        /// </summary>
        [Description("Whether the player has been declared inactive. This value is updated in the hours leading up to game start time; as teams announce their inactive players.  Note: This is only updated for offensive skill position players (QB; RB; WR; TE).")]
        [DataMember(Name = "DeclaredInactive", Order = 64)]
        public bool DeclaredInactive { get; set; }

        /// <summary>
        /// The player's FanDuel salary for the upcoming week. Note: We recommend using our new DFS endpoints instead.
        /// </summary>
        [Description("The player's FanDuel salary for the upcoming week. Note: We recommend using our new DFS endpoints instead.")]
        [DataMember(Name = "UpcomingFanDuelSalary", Order = 65)]
        public int? UpcomingFanDuelSalary { get; set; }

        /// <summary>
        /// The player's DraftKings salary for the upcoming week. Note: We recommend using our new DFS endpoints instead.
        /// </summary>
        [Description("The player's DraftKings salary for the upcoming week. Note: We recommend using our new DFS endpoints instead.")]
        [DataMember(Name = "UpcomingDraftKingsSalary", Order = 66)]
        public int? UpcomingDraftKingsSalary { get; set; }

        /// <summary>
        /// The player's Yahoo salary for the upcoming week. We recommend using our new DFS endpoints instead.
        /// </summary>
        [Description("The player's Yahoo salary for the upcoming week. We recommend using our new DFS endpoints instead.")]
        [DataMember(Name = "UpcomingYahooSalary", Order = 67)]
        public int? UpcomingYahooSalary { get; set; }

        /// <summary>
        /// The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL
        /// </summary>
        [Description("The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL")]
        [DataMember(Name = "TeamID", Order = 68)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 69)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to FantasyDraft
        /// </summary>
        [Description("The player's cross reference PlayerID to FantasyDraft")]
        [DataMember(Name = "FantasyDraftPlayerID", Order = 70)]
        public int? FantasyDraftPlayerID { get; set; }

        /// <summary>
        /// The player's full name in FantasyDraft's daily fantasy sports platform
        /// </summary>
        [Description("The player's full name in FantasyDraft's daily fantasy sports platform")]
        [DataMember(Name = "FantasyDraftName", Order = 71)]
        public string FantasyDraftName { get; set; }

        /// <summary>
        /// The player's cross reference PlayerID to USA Today headshot data feeds
        /// </summary>
        [Description("The player's cross reference PlayerID to USA Today headshot data feeds")]
        [DataMember(Name = "UsaTodayPlayerID", Order = 72)]
        public int? UsaTodayPlayerID { get; set; }

        /// <summary>
        /// The player's headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUrl", Order = 73)]
        public string UsaTodayHeadshotUrl { get; set; }

        /// <summary>
        /// The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The player's transparent background headshot URL as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUrl", Order = 74)]
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }

        /// <summary>
        /// The last updated date of the player's headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated date of the player's headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotUpdated", Order = 75)]
        public DateTime? UsaTodayHeadshotUpdated { get; set; }

        /// <summary>
        /// The last updated date of the player's transparent background headshot as provided by USA Today. License from USA Today is required.
        /// </summary>
        [Description("The last updated date of the player's transparent background headshot as provided by USA Today. License from USA Today is required.")]
        [DataMember(Name = "UsaTodayHeadshotNoBackgroundUpdated", Order = 76)]
        public DateTime? UsaTodayHeadshotNoBackgroundUpdated { get; set; }

    }
}

