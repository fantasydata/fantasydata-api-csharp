using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="TeamGame")]
    [Serializable]
    public partial class TeamGame
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "Date", Order = 2)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 5)]
        public int? Week { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation of the Opponent
        /// </summary>
        [Description("The abbreviation of the Opponent")]
        [DataMember(Name = "Opponent", Order = 7)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the Team is Home or Away
        /// </summary>
        [Description("Whether the Team is Home or Away")]
        [DataMember(Name = "HomeOrAway", Order = 8)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The final score of the Team
        /// </summary>
        [Description("The final score of the Team")]
        [DataMember(Name = "Score", Order = 9)]
        public int Score { get; set; }

        /// <summary>
        /// The final score of the Opponent
        /// </summary>
        [Description("The final score of the Opponent")]
        [DataMember(Name = "OpponentScore", Order = 10)]
        public int OpponentScore { get; set; }

        /// <summary>
        /// The total score of both teams
        /// </summary>
        [Description("The total score of both teams")]
        [DataMember(Name = "TotalScore", Order = 11)]
        public int TotalScore { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 12)]
        public string Stadium { get; set; }

        /// <summary>
        /// Playing surface of the stadium
        /// </summary>
        [Description("Playing surface of the stadium")]
        [DataMember(Name = "PlayingSurface", Order = 13)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Temperature", Order = 14)]
        public int? Temperature { get; set; }

        /// <summary>
        /// Humidity at game start (Percentage)
        /// </summary>
        [Description("Humidity at game start (Percentage)")]
        [DataMember(Name = "Humidity", Order = 15)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Wind speed at game start (MPH)
        /// </summary>
        [Description("Wind speed at game start (MPH)")]
        [DataMember(Name = "WindSpeed", Order = 16)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 17)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the Team (negative numbers indicate the Team is favored, positive numbers indicate the Opponent is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the Team (negative numbers indicate the Team is favored, positive numbers indicate the Opponent is favored)")]
        [DataMember(Name = "PointSpread", Order = 18)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the Team
        /// </summary>
        [Description("Points scored during Quarter 1 for the Team")]
        [DataMember(Name = "ScoreQuarter1", Order = 19)]
        public int? ScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the Team
        /// </summary>
        [Description("Points scored during Quarter 2 for the Team")]
        [DataMember(Name = "ScoreQuarter2", Order = 20)]
        public int? ScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the Team
        /// </summary>
        [Description("Points scored during Quarter 3 for the Team")]
        [DataMember(Name = "ScoreQuarter3", Order = 21)]
        public int? ScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the Team
        /// </summary>
        [Description("Points scored during Quarter 4 for the Team")]
        [DataMember(Name = "ScoreQuarter4", Order = 22)]
        public int? ScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime for the Team
        /// </summary>
        [Description("Points scored during Overtime for the Team")]
        [DataMember(Name = "ScoreOvertime", Order = 23)]
        public int ScoreOvertime { get; set; }

        /// <summary>
        /// Time of possession minutes
        /// </summary>
        [Description("Time of possession minutes")]
        [DataMember(Name = "TimeOfPossessionMinutes", Order = 24)]
        public int? TimeOfPossessionMinutes { get; set; }

        /// <summary>
        /// Time of possession seconds
        /// </summary>
        [Description("Time of possession seconds")]
        [DataMember(Name = "TimeOfPossessionSeconds", Order = 25)]
        public int? TimeOfPossessionSeconds { get; set; }

        /// <summary>
        /// Time of possession
        /// </summary>
        [Description("Time of possession")]
        [DataMember(Name = "TimeOfPossession", Order = 26)]
        public string TimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs
        /// </summary>
        [Description("Total first downs")]
        [DataMember(Name = "FirstDowns", Order = 27)]
        public int? FirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs
        /// </summary>
        [Description("Total rushing first downs")]
        [DataMember(Name = "FirstDownsByRushing", Order = 28)]
        public int? FirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs
        /// </summary>
        [Description("Total passing first downs")]
        [DataMember(Name = "FirstDownsByPassing", Order = 29)]
        public int? FirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by opponent's penalty
        /// </summary>
        [Description("Total first downs by opponent's penalty")]
        [DataMember(Name = "FirstDownsByPenalty", Order = 30)]
        public int? FirstDownsByPenalty { get; set; }

        /// <summary>
        /// Number of offensive plays run
        /// </summary>
        [Description("Number of offensive plays run")]
        [DataMember(Name = "OffensivePlays", Order = 31)]
        public int OffensivePlays { get; set; }

        /// <summary>
        /// Number of offensive yards gained
        /// </summary>
        [Description("Number of offensive yards gained")]
        [DataMember(Name = "OffensiveYards", Order = 32)]
        public int OffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play
        /// </summary>
        [Description("Average yards gained per offensive play")]
        [DataMember(Name = "OffensiveYardsPerPlay", Order = 33)]
        public decimal OffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Touchdowns scored
        /// </summary>
        [Description("Touchdowns scored")]
        [DataMember(Name = "Touchdowns", Order = 34)]
        public int? Touchdowns { get; set; }

        /// <summary>
        /// Number of rushing attempts
        /// </summary>
        [Description("Number of rushing attempts")]
        [DataMember(Name = "RushingAttempts", Order = 35)]
        public int? RushingAttempts { get; set; }

        /// <summary>
        /// Number of rushing yards
        /// </summary>
        [Description("Number of rushing yards")]
        [DataMember(Name = "RushingYards", Order = 36)]
        public int? RushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt
        /// </summary>
        [Description("Average rushing yards gained per attempt")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 37)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Rushing touchdowns scored
        /// </summary>
        [Description("Rushing touchdowns scored")]
        [DataMember(Name = "RushingTouchdowns", Order = 38)]
        public int? RushingTouchdowns { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "PassingAttempts", Order = 39)]
        public int? PassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "PassingCompletions", Order = 40)]
        public int? PassingCompletions { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "PassingYards", Order = 41)]
        public int? PassingYards { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "PassingTouchdowns", Order = 42)]
        public int? PassingTouchdowns { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "PassingInterceptions", Order = 43)]
        public int? PassingInterceptions { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 44)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 45)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "CompletionPercentage", Order = 46)]
        public decimal CompletionPercentage { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "PasserRating", Order = 47)]
        public decimal? PasserRating { get; set; }

        /// <summary>
        /// Third down attempts
        /// </summary>
        [Description("Third down attempts")]
        [DataMember(Name = "ThirdDownAttempts", Order = 48)]
        public int? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Third down conversions
        /// </summary>
        [Description("Third down conversions")]
        [DataMember(Name = "ThirdDownConversions", Order = 49)]
        public int? ThirdDownConversions { get; set; }

        /// <summary>
        /// Percentage of third downs converted
        /// </summary>
        [Description("Percentage of third downs converted")]
        [DataMember(Name = "ThirdDownPercentage", Order = 50)]
        public decimal? ThirdDownPercentage { get; set; }

        /// <summary>
        /// Fourth down attempts
        /// </summary>
        [Description("Fourth down attempts")]
        [DataMember(Name = "FourthDownAttempts", Order = 51)]
        public int? FourthDownAttempts { get; set; }

        /// <summary>
        /// Fourth down conversions
        /// </summary>
        [Description("Fourth down conversions")]
        [DataMember(Name = "FourthDownConversions", Order = 52)]
        public int? FourthDownConversions { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted
        /// </summary>
        [Description("Percentage of fourth downs converted")]
        [DataMember(Name = "FourthDownPercentage", Order = 53)]
        public decimal? FourthDownPercentage { get; set; }

        /// <summary>
        /// Red zone opportunities
        /// </summary>
        [Description("Red zone opportunities")]
        [DataMember(Name = "RedZoneAttempts", Order = 54)]
        public int? RedZoneAttempts { get; set; }

        /// <summary>
        /// Red zone opportunities converted to touchdowns
        /// </summary>
        [Description("Red zone opportunities converted to touchdowns")]
        [DataMember(Name = "RedZoneConversions", Order = 55)]
        public int? RedZoneConversions { get; set; }

        /// <summary>
        /// 1st & Goal opportunities
        /// </summary>
        [Description("1st & Goal opportunities")]
        [DataMember(Name = "GoalToGoAttempts", Order = 56)]
        public int? GoalToGoAttempts { get; set; }

        /// <summary>
        /// 1st & Goal opportunities converted to touchdowns
        /// </summary>
        [Description("1st & Goal opportunities converted to touchdowns")]
        [DataMember(Name = "GoalToGoConversions", Order = 57)]
        public int? GoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards
        /// </summary>
        [Description("Total punt and defensive return yards")]
        [DataMember(Name = "ReturnYards", Order = 58)]
        public int? ReturnYards { get; set; }

        /// <summary>
        /// Penalties committed
        /// </summary>
        [Description("Penalties committed")]
        [DataMember(Name = "Penalties", Order = 59)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Penalty yards enforced against team
        /// </summary>
        [Description("Penalty yards enforced against team")]
        [DataMember(Name = "PenaltyYards", Order = 60)]
        public int? PenaltyYards { get; set; }

        /// <summary>
        /// Fumbles
        /// </summary>
        [Description("Fumbles")]
        [DataMember(Name = "Fumbles", Order = 61)]
        public int? Fumbles { get; set; }

        /// <summary>
        /// Fumbles lost
        /// </summary>
        [Description("Fumbles lost")]
        [DataMember(Name = "FumblesLost", Order = 62)]
        public int? FumblesLost { get; set; }

        /// <summary>
        /// Number of sacks allowed by Team
        /// </summary>
        [Description("Number of sacks allowed by Team")]
        [DataMember(Name = "TimesSacked", Order = 63)]
        public int? TimesSacked { get; set; }

        /// <summary>
        /// Number of yards lost as a result of sacks allowed
        /// </summary>
        [Description("Number of yards lost as a result of sacks allowed")]
        [DataMember(Name = "TimesSackedYards", Order = 64)]
        public int? TimesSackedYards { get; set; }

        /// <summary>
        /// Number of times the opposing QB was hit (includes sacks)
        /// </summary>
        [Description("Number of times the opposing QB was hit (includes sacks)")]
        [DataMember(Name = "QuarterbackHits", Order = 65)]
        public int? QuarterbackHits { get; set; }

        /// <summary>
        /// Number of times the opponent was tackled for a loss
        /// </summary>
        [Description("Number of times the opponent was tackled for a loss")]
        [DataMember(Name = "TacklesForLoss", Order = 66)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Safeties scored
        /// </summary>
        [Description("Safeties scored")]
        [DataMember(Name = "Safeties", Order = 67)]
        public int? Safeties { get; set; }

        /// <summary>
        /// Number of punts
        /// </summary>
        [Description("Number of punts")]
        [DataMember(Name = "Punts", Order = 68)]
        public int? Punts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "PuntYards", Order = 69)]
        public int? PuntYards { get; set; }

        /// <summary>
        /// Average number of yards per punt
        /// </summary>
        [Description("Average number of yards per punt")]
        [DataMember(Name = "PuntAverage", Order = 70)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Number of giveaways
        /// </summary>
        [Description("Number of giveaways")]
        [DataMember(Name = "Giveaways", Order = 71)]
        public int Giveaways { get; set; }

        /// <summary>
        /// Number of takeaways
        /// </summary>
        [Description("Number of takeaways")]
        [DataMember(Name = "Takeaways", Order = 72)]
        public int Takeaways { get; set; }

        /// <summary>
        /// Number of takeaways minus giveaways
        /// </summary>
        [Description("Number of takeaways minus giveaways")]
        [DataMember(Name = "TurnoverDifferential", Order = 73)]
        public int TurnoverDifferential { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the Team
        /// </summary>
        [Description("Points scored during Quarter 1 for the Team")]
        [DataMember(Name = "OpponentScoreQuarter1", Order = 74)]
        public int? OpponentScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the Team
        /// </summary>
        [Description("Points scored during Quarter 2 for the Team")]
        [DataMember(Name = "OpponentScoreQuarter2", Order = 75)]
        public int? OpponentScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the Team
        /// </summary>
        [Description("Points scored during Quarter 3 for the Team")]
        [DataMember(Name = "OpponentScoreQuarter3", Order = 76)]
        public int? OpponentScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the Team
        /// </summary>
        [Description("Points scored during Quarter 4 for the Team")]
        [DataMember(Name = "OpponentScoreQuarter4", Order = 77)]
        public int? OpponentScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime for the Team
        /// </summary>
        [Description("Points scored during Overtime for the Team")]
        [DataMember(Name = "OpponentScoreOvertime", Order = 78)]
        public int OpponentScoreOvertime { get; set; }

        /// <summary>
        /// Time of possession minutes
        /// </summary>
        [Description("Time of possession minutes")]
        [DataMember(Name = "OpponentTimeOfPossessionMinutes", Order = 79)]
        public int? OpponentTimeOfPossessionMinutes { get; set; }

        /// <summary>
        /// Time of possession seconds
        /// </summary>
        [Description("Time of possession seconds")]
        [DataMember(Name = "OpponentTimeOfPossessionSeconds", Order = 80)]
        public int? OpponentTimeOfPossessionSeconds { get; set; }

        /// <summary>
        /// Time of possession
        /// </summary>
        [Description("Time of possession")]
        [DataMember(Name = "OpponentTimeOfPossession", Order = 81)]
        public string OpponentTimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs
        /// </summary>
        [Description("Total first downs")]
        [DataMember(Name = "OpponentFirstDowns", Order = 82)]
        public int? OpponentFirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs
        /// </summary>
        [Description("Total rushing first downs")]
        [DataMember(Name = "OpponentFirstDownsByRushing", Order = 83)]
        public int? OpponentFirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs
        /// </summary>
        [Description("Total passing first downs")]
        [DataMember(Name = "OpponentFirstDownsByPassing", Order = 84)]
        public int? OpponentFirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by opponent's penalty
        /// </summary>
        [Description("Total first downs by opponent's penalty")]
        [DataMember(Name = "OpponentFirstDownsByPenalty", Order = 85)]
        public int? OpponentFirstDownsByPenalty { get; set; }

        /// <summary>
        /// Number of offensive plays run
        /// </summary>
        [Description("Number of offensive plays run")]
        [DataMember(Name = "OpponentOffensivePlays", Order = 86)]
        public int OpponentOffensivePlays { get; set; }

        /// <summary>
        /// Number of offensive yards gained
        /// </summary>
        [Description("Number of offensive yards gained")]
        [DataMember(Name = "OpponentOffensiveYards", Order = 87)]
        public int OpponentOffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play
        /// </summary>
        [Description("Average yards gained per offensive play")]
        [DataMember(Name = "OpponentOffensiveYardsPerPlay", Order = 88)]
        public decimal OpponentOffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Touchdowns scored
        /// </summary>
        [Description("Touchdowns scored")]
        [DataMember(Name = "OpponentTouchdowns", Order = 89)]
        public int? OpponentTouchdowns { get; set; }

        /// <summary>
        /// Number of rushing attempts
        /// </summary>
        [Description("Number of rushing attempts")]
        [DataMember(Name = "OpponentRushingAttempts", Order = 90)]
        public int? OpponentRushingAttempts { get; set; }

        /// <summary>
        /// Number of rushing yards
        /// </summary>
        [Description("Number of rushing yards")]
        [DataMember(Name = "OpponentRushingYards", Order = 91)]
        public int? OpponentRushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt
        /// </summary>
        [Description("Average rushing yards gained per attempt")]
        [DataMember(Name = "OpponentRushingYardsPerAttempt", Order = 92)]
        public decimal OpponentRushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Rushing touchdowns scored
        /// </summary>
        [Description("Rushing touchdowns scored")]
        [DataMember(Name = "OpponentRushingTouchdowns", Order = 93)]
        public int? OpponentRushingTouchdowns { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "OpponentPassingAttempts", Order = 94)]
        public int? OpponentPassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "OpponentPassingCompletions", Order = 95)]
        public int? OpponentPassingCompletions { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "OpponentPassingYards", Order = 96)]
        public int? OpponentPassingYards { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "OpponentPassingTouchdowns", Order = 97)]
        public int? OpponentPassingTouchdowns { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "OpponentPassingInterceptions", Order = 98)]
        public int? OpponentPassingInterceptions { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "OpponentPassingYardsPerAttempt", Order = 99)]
        public decimal OpponentPassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "OpponentPassingYardsPerCompletion", Order = 100)]
        public decimal OpponentPassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "OpponentCompletionPercentage", Order = 101)]
        public decimal OpponentCompletionPercentage { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "OpponentPasserRating", Order = 102)]
        public decimal? OpponentPasserRating { get; set; }

        /// <summary>
        /// Third down attempts
        /// </summary>
        [Description("Third down attempts")]
        [DataMember(Name = "OpponentThirdDownAttempts", Order = 103)]
        public int? OpponentThirdDownAttempts { get; set; }

        /// <summary>
        /// Third down conversions
        /// </summary>
        [Description("Third down conversions")]
        [DataMember(Name = "OpponentThirdDownConversions", Order = 104)]
        public int? OpponentThirdDownConversions { get; set; }

        /// <summary>
        /// Percentage of third downs converted
        /// </summary>
        [Description("Percentage of third downs converted")]
        [DataMember(Name = "OpponentThirdDownPercentage", Order = 105)]
        public decimal? OpponentThirdDownPercentage { get; set; }

        /// <summary>
        /// Fourth down attempts
        /// </summary>
        [Description("Fourth down attempts")]
        [DataMember(Name = "OpponentFourthDownAttempts", Order = 106)]
        public int? OpponentFourthDownAttempts { get; set; }

        /// <summary>
        /// Fourth down conversions
        /// </summary>
        [Description("Fourth down conversions")]
        [DataMember(Name = "OpponentFourthDownConversions", Order = 107)]
        public int? OpponentFourthDownConversions { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted
        /// </summary>
        [Description("Percentage of fourth downs converted")]
        [DataMember(Name = "OpponentFourthDownPercentage", Order = 108)]
        public decimal? OpponentFourthDownPercentage { get; set; }

        /// <summary>
        /// Red zone opportunities
        /// </summary>
        [Description("Red zone opportunities")]
        [DataMember(Name = "OpponentRedZoneAttempts", Order = 109)]
        public int? OpponentRedZoneAttempts { get; set; }

        /// <summary>
        /// Red zone opportunities converted to touchdowns
        /// </summary>
        [Description("Red zone opportunities converted to touchdowns")]
        [DataMember(Name = "OpponentRedZoneConversions", Order = 110)]
        public int? OpponentRedZoneConversions { get; set; }

        /// <summary>
        /// 1st & Goal opportunities
        /// </summary>
        [Description("1st & Goal opportunities")]
        [DataMember(Name = "OpponentGoalToGoAttempts", Order = 111)]
        public int? OpponentGoalToGoAttempts { get; set; }

        /// <summary>
        /// 1st & Goal opportunities converted to touchdowns
        /// </summary>
        [Description("1st & Goal opportunities converted to touchdowns")]
        [DataMember(Name = "OpponentGoalToGoConversions", Order = 112)]
        public int? OpponentGoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards
        /// </summary>
        [Description("Total punt and defensive return yards")]
        [DataMember(Name = "OpponentReturnYards", Order = 113)]
        public int? OpponentReturnYards { get; set; }

        /// <summary>
        /// Penalties committed
        /// </summary>
        [Description("Penalties committed")]
        [DataMember(Name = "OpponentPenalties", Order = 114)]
        public int? OpponentPenalties { get; set; }

        /// <summary>
        /// Penalty yards enforced against the opponent
        /// </summary>
        [Description("Penalty yards enforced against the opponent")]
        [DataMember(Name = "OpponentPenaltyYards", Order = 115)]
        public int? OpponentPenaltyYards { get; set; }

        /// <summary>
        /// Fumbles
        /// </summary>
        [Description("Fumbles")]
        [DataMember(Name = "OpponentFumbles", Order = 116)]
        public int? OpponentFumbles { get; set; }

        /// <summary>
        /// Fumbles lost
        /// </summary>
        [Description("Fumbles lost")]
        [DataMember(Name = "OpponentFumblesLost", Order = 117)]
        public int? OpponentFumblesLost { get; set; }

        /// <summary>
        /// Number of sacks allowed by Opponent
        /// </summary>
        [Description("Number of sacks allowed by Opponent")]
        [DataMember(Name = "OpponentTimesSacked", Order = 118)]
        public int? OpponentTimesSacked { get; set; }

        /// <summary>
        /// Number of yards opponent lost as a result of being sacked
        /// </summary>
        [Description("Number of yards opponent lost as a result of being sacked")]
        [DataMember(Name = "OpponentTimesSackedYards", Order = 119)]
        public int? OpponentTimesSackedYards { get; set; }

        /// <summary>
        /// Number of times our QB was hit but not sacked
        /// </summary>
        [Description("Number of times our QB was hit but not sacked")]
        [DataMember(Name = "OpponentQuarterbackHits", Order = 120)]
        public int? OpponentQuarterbackHits { get; set; }

        /// <summary>
        /// Number of times our ball carrier was tackled for a loss
        /// </summary>
        [Description("Number of times our ball carrier was tackled for a loss")]
        [DataMember(Name = "OpponentTacklesForLoss", Order = 121)]
        public int? OpponentTacklesForLoss { get; set; }

        /// <summary>
        /// Safeties scored
        /// </summary>
        [Description("Safeties scored")]
        [DataMember(Name = "OpponentSafeties", Order = 122)]
        public int? OpponentSafeties { get; set; }

        /// <summary>
        /// Number of punts
        /// </summary>
        [Description("Number of punts")]
        [DataMember(Name = "OpponentPunts", Order = 123)]
        public int? OpponentPunts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "OpponentPuntYards", Order = 124)]
        public int? OpponentPuntYards { get; set; }

        /// <summary>
        /// Average number of yards per punt
        /// </summary>
        [Description("Average number of yards per punt")]
        [DataMember(Name = "OpponentPuntAverage", Order = 125)]
        public decimal OpponentPuntAverage { get; set; }

        /// <summary>
        /// Number of giveaways
        /// </summary>
        [Description("Number of giveaways")]
        [DataMember(Name = "OpponentGiveaways", Order = 126)]
        public int OpponentGiveaways { get; set; }

        /// <summary>
        /// Number of takeaways
        /// </summary>
        [Description("Number of takeaways")]
        [DataMember(Name = "OpponentTakeaways", Order = 127)]
        public int OpponentTakeaways { get; set; }

        /// <summary>
        /// Number of takeaways minus giveaways
        /// </summary>
        [Description("Number of takeaways minus giveaways")]
        [DataMember(Name = "OpponentTurnoverDifferential", Order = 128)]
        public int OpponentTurnoverDifferential { get; set; }

        /// <summary>
        /// Percentage of red zone opportunities converted into touchdowns
        /// </summary>
        [Description("Percentage of red zone opportunities converted into touchdowns")]
        [DataMember(Name = "RedZonePercentage", Order = 129)]
        public decimal? RedZonePercentage { get; set; }

        /// <summary>
        /// Percentage of goal-to-go opportunities converted into touchdowns
        /// </summary>
        [Description("Percentage of goal-to-go opportunities converted into touchdowns")]
        [DataMember(Name = "GoalToGoPercentage", Order = 130)]
        public decimal? GoalToGoPercentage { get; set; }

        /// <summary>
        /// The differential of hits on the opposing quarterback minus hits on own team's quarterback
        /// </summary>
        [Description("The differential of hits on the opposing quarterback minus hits on own team's quarterback")]
        [DataMember(Name = "QuarterbackHitsDifferential", Order = 131)]
        public int? QuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// The differential of tackles for loss minus opponent's tackles for loss
        /// </summary>
        [Description("The differential of tackles for loss minus opponent's tackles for loss")]
        [DataMember(Name = "TacklesForLossDifferential", Order = 132)]
        public int? TacklesForLossDifferential { get; set; }

        /// <summary>
        /// The Team's sack differential (similar to a turnover differential)
        /// </summary>
        [Description("The Team's sack differential (similar to a turnover differential)")]
        [DataMember(Name = "QuarterbackSacksDifferential", Order = 133)]
        public int QuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Percentage of running plays defended that resulted in tackle for loss
        /// </summary>
        [Description("Percentage of running plays defended that resulted in tackle for loss")]
        [DataMember(Name = "TacklesForLossPercentage", Order = 134)]
        public decimal? TacklesForLossPercentage { get; set; }

        /// <summary>
        /// Percantage of opposing quarterback drop backs that resulted hitting the quarterback
        /// </summary>
        [Description("Percantage of opposing quarterback drop backs that resulted hitting the quarterback")]
        [DataMember(Name = "QuarterbackHitsPercentage", Order = 135)]
        public decimal? QuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Percentage of drop backs that resulted in a sack
        /// </summary>
        [Description("Percentage of drop backs that resulted in a sack")]
        [DataMember(Name = "TimesSackedPercentage", Order = 136)]
        public decimal TimesSackedPercentage { get; set; }

        /// <summary>
        /// Percentage of opponent's red zone opportunities converted into touchdowns
        /// </summary>
        [Description("Percentage of opponent's red zone opportunities converted into touchdowns")]
        [DataMember(Name = "OpponentRedZonePercentage", Order = 137)]
        public decimal? OpponentRedZonePercentage { get; set; }

        /// <summary>
        /// Percentage of opponent's goal-to-go opportunities converted into touchdowns
        /// </summary>
        [Description("Percentage of opponent's goal-to-go opportunities converted into touchdowns")]
        [DataMember(Name = "OpponentGoalToGoPercentage", Order = 138)]
        public decimal? OpponentGoalToGoPercentage { get; set; }

        /// <summary>
        /// The inverse of QuarterbackHitsDifferential
        /// </summary>
        [Description("The inverse of QuarterbackHitsDifferential")]
        [DataMember(Name = "OpponentQuarterbackHitsDifferential", Order = 139)]
        public int? OpponentQuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// The inverse of TacklesForLossDifferential
        /// </summary>
        [Description("The inverse of TacklesForLossDifferential")]
        [DataMember(Name = "OpponentTacklesForLossDifferential", Order = 140)]
        public int? OpponentTacklesForLossDifferential { get; set; }

        /// <summary>
        /// The inverse of QuarterbackSacksDifferential
        /// </summary>
        [Description("The inverse of QuarterbackSacksDifferential")]
        [DataMember(Name = "OpponentQuarterbackSacksDifferential", Order = 141)]
        public int? OpponentQuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Percentage of running plays defended that resulted in tackle for loss
        /// </summary>
        [Description("Percentage of running plays defended that resulted in tackle for loss")]
        [DataMember(Name = "OpponentTacklesForLossPercentage", Order = 142)]
        public decimal? OpponentTacklesForLossPercentage { get; set; }

        /// <summary>
        /// Percantage of own team's quarterback drop backs that resulted in our quarterback getting hit
        /// </summary>
        [Description("Percantage of own team's quarterback drop backs that resulted in our quarterback getting hit")]
        [DataMember(Name = "OpponentQuarterbackHitsPercentage", Order = 143)]
        public decimal? OpponentQuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Percentage of drop backs that resulted in a sack
        /// </summary>
        [Description("Percentage of drop backs that resulted in a sack")]
        [DataMember(Name = "OpponentTimesSackedPercentage", Order = 144)]
        public decimal OpponentTimesSackedPercentage { get; set; }

        /// <summary>
        /// Number of kickoffs
        /// </summary>
        [Description("Number of kickoffs")]
        [DataMember(Name = "Kickoffs", Order = 145)]
        public int? Kickoffs { get; set; }

        /// <summary>
        /// Number of kickoffs that went into the end zone
        /// </summary>
        [Description("Number of kickoffs that went into the end zone")]
        [DataMember(Name = "KickoffsInEndZone", Order = 146)]
        public int? KickoffsInEndZone { get; set; }

        /// <summary>
        /// Number of kickoffs that resulted in touchbacks
        /// </summary>
        [Description("Number of kickoffs that resulted in touchbacks")]
        [DataMember(Name = "KickoffTouchbacks", Order = 147)]
        public int? KickoffTouchbacks { get; set; }

        /// <summary>
        /// Number of punts that were blocked
        /// </summary>
        [Description("Number of punts that were blocked")]
        [DataMember(Name = "PuntsHadBlocked", Order = 148)]
        public int? PuntsHadBlocked { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "PuntNetAverage", Order = 149)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Extra point kick attempts
        /// </summary>
        [Description("Extra point kick attempts")]
        [DataMember(Name = "ExtraPointKickingAttempts", Order = 150)]
        public int? ExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Extra point kicks made
        /// </summary>
        [Description("Extra point kicks made")]
        [DataMember(Name = "ExtraPointKickingConversions", Order = 151)]
        public int? ExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Extra point kick attempts that were blocked
        /// </summary>
        [Description("Extra point kick attempts that were blocked")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 152)]
        public int? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Two point conversion passing attempts
        /// </summary>
        [Description("Two point conversion passing attempts")]
        [DataMember(Name = "ExtraPointPassingAttempts", Order = 153)]
        public int? ExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Two point conversion passing conversions
        /// </summary>
        [Description("Two point conversion passing conversions")]
        [DataMember(Name = "ExtraPointPassingConversions", Order = 154)]
        public int? ExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Two point conversion rushing attempts
        /// </summary>
        [Description("Two point conversion rushing attempts")]
        [DataMember(Name = "ExtraPointRushingAttempts", Order = 155)]
        public int? ExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Two point conversion rushing conversions
        /// </summary>
        [Description("Two point conversion rushing conversions")]
        [DataMember(Name = "ExtraPointRushingConversions", Order = 156)]
        public int? ExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Field goal attempts
        /// </summary>
        [Description("Field goal attempts")]
        [DataMember(Name = "FieldGoalAttempts", Order = 157)]
        public int? FieldGoalAttempts { get; set; }

        /// <summary>
        /// Field goals made
        /// </summary>
        [Description("Field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 158)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Field goal attempts that were blocked
        /// </summary>
        [Description("Field goal attempts that were blocked")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 159)]
        public int? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Punt returns
        /// </summary>
        [Description("Punt returns")]
        [DataMember(Name = "PuntReturns", Order = 160)]
        public int? PuntReturns { get; set; }

        /// <summary>
        /// Punt return yards
        /// </summary>
        [Description("Punt return yards")]
        [DataMember(Name = "PuntReturnYards", Order = 161)]
        public int? PuntReturnYards { get; set; }

        /// <summary>
        /// Kickoff returns
        /// </summary>
        [Description("Kickoff returns")]
        [DataMember(Name = "KickReturns", Order = 162)]
        public int? KickReturns { get; set; }

        /// <summary>
        /// Kickoff return yards
        /// </summary>
        [Description("Kickoff return yards")]
        [DataMember(Name = "KickReturnYards", Order = 163)]
        public int? KickReturnYards { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "InterceptionReturns", Order = 164)]
        public int? InterceptionReturns { get; set; }

        /// <summary>
        /// Interception return yards
        /// </summary>
        [Description("Interception return yards")]
        [DataMember(Name = "InterceptionReturnYards", Order = 165)]
        public int? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Number of kickoffs
        /// </summary>
        [Description("Number of kickoffs")]
        [DataMember(Name = "OpponentKickoffs", Order = 166)]
        public int? OpponentKickoffs { get; set; }

        /// <summary>
        /// Number of kickoffs that went into the end zone
        /// </summary>
        [Description("Number of kickoffs that went into the end zone")]
        [DataMember(Name = "OpponentKickoffsInEndZone", Order = 167)]
        public int? OpponentKickoffsInEndZone { get; set; }

        /// <summary>
        /// Number of kickoffs that resulted in touchbacks
        /// </summary>
        [Description("Number of kickoffs that resulted in touchbacks")]
        [DataMember(Name = "OpponentKickoffTouchbacks", Order = 168)]
        public int? OpponentKickoffTouchbacks { get; set; }

        /// <summary>
        /// Number of punts that were blocked
        /// </summary>
        [Description("Number of punts that were blocked")]
        [DataMember(Name = "OpponentPuntsHadBlocked", Order = 169)]
        public int? OpponentPuntsHadBlocked { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "OpponentPuntNetAverage", Order = 170)]
        public decimal? OpponentPuntNetAverage { get; set; }

        /// <summary>
        /// Extra point kick attempts
        /// </summary>
        [Description("Extra point kick attempts")]
        [DataMember(Name = "OpponentExtraPointKickingAttempts", Order = 171)]
        public int? OpponentExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Extra point kicks made
        /// </summary>
        [Description("Extra point kicks made")]
        [DataMember(Name = "OpponentExtraPointKickingConversions", Order = 172)]
        public int? OpponentExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Extra point kick attempts that were blocked
        /// </summary>
        [Description("Extra point kick attempts that were blocked")]
        [DataMember(Name = "OpponentExtraPointsHadBlocked", Order = 173)]
        public int? OpponentExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Two point conversion passing attempts
        /// </summary>
        [Description("Two point conversion passing attempts")]
        [DataMember(Name = "OpponentExtraPointPassingAttempts", Order = 174)]
        public int? OpponentExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Two point conversion passing conversions
        /// </summary>
        [Description("Two point conversion passing conversions")]
        [DataMember(Name = "OpponentExtraPointPassingConversions", Order = 175)]
        public int? OpponentExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Two point conversion rushing attempts
        /// </summary>
        [Description("Two point conversion rushing attempts")]
        [DataMember(Name = "OpponentExtraPointRushingAttempts", Order = 176)]
        public int? OpponentExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Two point conversion rushing conversions
        /// </summary>
        [Description("Two point conversion rushing conversions")]
        [DataMember(Name = "OpponentExtraPointRushingConversions", Order = 177)]
        public int? OpponentExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Field goal attempts
        /// </summary>
        [Description("Field goal attempts")]
        [DataMember(Name = "OpponentFieldGoalAttempts", Order = 178)]
        public int? OpponentFieldGoalAttempts { get; set; }

        /// <summary>
        /// Field goals made
        /// </summary>
        [Description("Field goals made")]
        [DataMember(Name = "OpponentFieldGoalsMade", Order = 179)]
        public int? OpponentFieldGoalsMade { get; set; }

        /// <summary>
        /// Field goal attempts that were blocked
        /// </summary>
        [Description("Field goal attempts that were blocked")]
        [DataMember(Name = "OpponentFieldGoalsHadBlocked", Order = 180)]
        public int? OpponentFieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Punt returns
        /// </summary>
        [Description("Punt returns")]
        [DataMember(Name = "OpponentPuntReturns", Order = 181)]
        public int? OpponentPuntReturns { get; set; }

        /// <summary>
        /// Punt return yards
        /// </summary>
        [Description("Punt return yards")]
        [DataMember(Name = "OpponentPuntReturnYards", Order = 182)]
        public int? OpponentPuntReturnYards { get; set; }

        /// <summary>
        /// Kickoff returns
        /// </summary>
        [Description("Kickoff returns")]
        [DataMember(Name = "OpponentKickReturns", Order = 183)]
        public int? OpponentKickReturns { get; set; }

        /// <summary>
        /// Kickoff return yards
        /// </summary>
        [Description("Kickoff return yards")]
        [DataMember(Name = "OpponentKickReturnYards", Order = 184)]
        public int? OpponentKickReturnYards { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "OpponentInterceptionReturns", Order = 185)]
        public int? OpponentInterceptionReturns { get; set; }

        /// <summary>
        /// Interception return yards
        /// </summary>
        [Description("Interception return yards")]
        [DataMember(Name = "OpponentInterceptionReturnYards", Order = 186)]
        public int? OpponentInterceptionReturnYards { get; set; }

        /// <summary>
        /// Defensive solo tackles
        /// </summary>
        [Description("Defensive solo tackles")]
        [DataMember(Name = "SoloTackles", Order = 187)]
        public int? SoloTackles { get; set; }

        /// <summary>
        /// Defensive assisted tackles
        /// </summary>
        [Description("Defensive assisted tackles")]
        [DataMember(Name = "AssistedTackles", Order = 188)]
        public int? AssistedTackles { get; set; }

        /// <summary>
        /// Defensive sacks
        /// </summary>
        [Description("Defensive sacks")]
        [DataMember(Name = "Sacks", Order = 189)]
        public int? Sacks { get; set; }

        /// <summary>
        /// Defensive sack yards
        /// </summary>
        [Description("Defensive sack yards")]
        [DataMember(Name = "SackYards", Order = 190)]
        public int? SackYards { get; set; }

        /// <summary>
        /// Defensive passes defended
        /// </summary>
        [Description("Defensive passes defended")]
        [DataMember(Name = "PassesDefended", Order = 191)]
        public int? PassesDefended { get; set; }

        /// <summary>
        /// Defensive fumbles forced
        /// </summary>
        [Description("Defensive fumbles forced")]
        [DataMember(Name = "FumblesForced", Order = 192)]
        public int? FumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered that resulted in change of possession
        /// </summary>
        [Description("Fumbles recovered that resulted in change of possession")]
        [DataMember(Name = "FumblesRecovered", Order = 193)]
        public int? FumblesRecovered { get; set; }

        /// <summary>
        /// Fumble return yards
        /// </summary>
        [Description("Fumble return yards")]
        [DataMember(Name = "FumbleReturnYards", Order = 194)]
        public int? FumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble return touchdowns
        /// </summary>
        [Description("Fumble return touchdowns")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 195)]
        public int? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 196)]
        public int? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of opponent's kicks that were blocked
        /// </summary>
        [Description("Total number of opponent's kicks that were blocked")]
        [DataMember(Name = "BlockedKicks", Order = 197)]
        public int? BlockedKicks { get; set; }

        /// <summary>
        /// Punt return touchdown
        /// </summary>
        [Description("Punt return touchdown")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 198)]
        public int? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "PuntReturnLong", Order = 199)]
        public int? PuntReturnLong { get; set; }

        /// <summary>
        /// Kick return touchdown
        /// </summary>
        [Description("Kick return touchdown")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 200)]
        public int? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "KickReturnLong", Order = 201)]
        public int? KickReturnLong { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 202)]
        public int? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick recovery return touchdowns
        /// </summary>
        [Description("Blocked kick recovery return touchdowns")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 203)]
        public int? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 204)]
        public int? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return touchdowns (excluding blocked field goals)")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 205)]
        public int? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "PuntNetYards", Order = 206)]
        public int? PuntNetYards { get; set; }

        /// <summary>
        /// Defensive solo tackles
        /// </summary>
        [Description("Defensive solo tackles")]
        [DataMember(Name = "OpponentSoloTackles", Order = 207)]
        public int? OpponentSoloTackles { get; set; }

        /// <summary>
        /// Defensive assisted tackles
        /// </summary>
        [Description("Defensive assisted tackles")]
        [DataMember(Name = "OpponentAssistedTackles", Order = 208)]
        public int? OpponentAssistedTackles { get; set; }

        /// <summary>
        /// Defensive sacks
        /// </summary>
        [Description("Defensive sacks")]
        [DataMember(Name = "OpponentSacks", Order = 209)]
        public int? OpponentSacks { get; set; }

        /// <summary>
        /// Defensive sack yards
        /// </summary>
        [Description("Defensive sack yards")]
        [DataMember(Name = "OpponentSackYards", Order = 210)]
        public int? OpponentSackYards { get; set; }

        /// <summary>
        /// Defensive passes defended
        /// </summary>
        [Description("Defensive passes defended")]
        [DataMember(Name = "OpponentPassesDefended", Order = 211)]
        public int? OpponentPassesDefended { get; set; }

        /// <summary>
        /// Defensive fumbles forced
        /// </summary>
        [Description("Defensive fumbles forced")]
        [DataMember(Name = "OpponentFumblesForced", Order = 212)]
        public int? OpponentFumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered that resulted in change of possession
        /// </summary>
        [Description("Fumbles recovered that resulted in change of possession")]
        [DataMember(Name = "OpponentFumblesRecovered", Order = 213)]
        public int? OpponentFumblesRecovered { get; set; }

        /// <summary>
        /// Fumble return yards
        /// </summary>
        [Description("Fumble return yards")]
        [DataMember(Name = "OpponentFumbleReturnYards", Order = 214)]
        public int? OpponentFumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble return touchdowns
        /// </summary>
        [Description("Fumble return touchdowns")]
        [DataMember(Name = "OpponentFumbleReturnTouchdowns", Order = 215)]
        public int? OpponentFumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "OpponentInterceptionReturnTouchdowns", Order = 216)]
        public int? OpponentInterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of opponent's kicks that were blocked
        /// </summary>
        [Description("Total number of opponent's kicks that were blocked")]
        [DataMember(Name = "OpponentBlockedKicks", Order = 217)]
        public int? OpponentBlockedKicks { get; set; }

        /// <summary>
        /// Punt return touchdown
        /// </summary>
        [Description("Punt return touchdown")]
        [DataMember(Name = "OpponentPuntReturnTouchdowns", Order = 218)]
        public int? OpponentPuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "OpponentPuntReturnLong", Order = 219)]
        public int? OpponentPuntReturnLong { get; set; }

        /// <summary>
        /// Kick return touchdown
        /// </summary>
        [Description("Kick return touchdown")]
        [DataMember(Name = "OpponentKickReturnTouchdowns", Order = 220)]
        public int? OpponentKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "OpponentKickReturnLong", Order = 221)]
        public int? OpponentKickReturnLong { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "OpponentBlockedKickReturnYards", Order = 222)]
        public int? OpponentBlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick recovery return touchdowns
        /// </summary>
        [Description("Blocked kick recovery return touchdowns")]
        [DataMember(Name = "OpponentBlockedKickReturnTouchdowns", Order = 223)]
        public int? OpponentBlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "OpponentFieldGoalReturnYards", Order = 224)]
        public int? OpponentFieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return touchdowns (excluding blocked field goals)")]
        [DataMember(Name = "OpponentFieldGoalReturnTouchdowns", Order = 225)]
        public int? OpponentFieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "OpponentPuntNetYards", Order = 226)]
        public int? OpponentPuntNetYards { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 227)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// The full name of the team (e.g. New England Patriots)
        /// </summary>
        [Description("The full name of the team (e.g. New England Patriots)")]
        [DataMember(Name = "TeamName", Order = 228)]
        public string TeamName { get; set; }

        /// <summary>
        /// The day of the week this game was played on (e.g. Sunday, Monday)
        /// </summary>
        [Description("The day of the week this game was played on (e.g. Sunday, Monday)")]
        [DataMember(Name = "DayOfWeek", Order = 229)]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// The number of times the offense dropped back to pass
        /// </summary>
        [Description("The number of times the offense dropped back to pass")]
        [DataMember(Name = "PassingDropbacks", Order = 230)]
        public int? PassingDropbacks { get; set; }

        /// <summary>
        /// The number of times the opponent dropped back to pass
        /// </summary>
        [Description("The number of times the opponent dropped back to pass")]
        [DataMember(Name = "OpponentPassingDropbacks", Order = 231)]
        public int? OpponentPassingDropbacks { get; set; }

        /// <summary>
        /// Unique ID of this TeamGame record (subject to change, although it very rarely does).  For a guaranteed static ID, use a combination of GameKey and Team.
        /// </summary>
        [Description("Unique ID of this TeamGame record (subject to change, although it very rarely does).  For a guaranteed static ID, use a combination of GameKey and Team.")]
        [DataMember(Name = "TeamGameID", Order = 232)]
        public int TeamGameID { get; set; }

        /// <summary>
        /// Two point conversion returns for two points.
        /// </summary>
        [Description("Two point conversion returns for two points.")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 233)]
        public int? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Opponent's two point conversion returns for two points.
        /// </summary>
        [Description("Opponent's two point conversion returns for two points.")]
        [DataMember(Name = "OpponentTwoPointConversionReturns", Order = 234)]
        public int? OpponentTwoPointConversionReturns { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 235)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of this opposing team
        /// </summary>
        [Description("The unique ID of this opposing team")]
        [DataMember(Name = "OpponentID", Order = 236)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The date of the game in US Eastern Time
        /// </summary>
        [Description("The date of the game in US Eastern Time")]
        [DataMember(Name = "Day", Order = 237)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 238)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 239)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 240)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opposing team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 241)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 242)]
        public int ScoreID { get; set; }

    }
}

