using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Game")]
    [Serializable]
    public partial class Game
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
        public DateTime Date { get; set; }

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
        public int Week { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 6)]
        public string Stadium { get; set; }

        /// <summary>
        /// Playing surface of the stadium
        /// </summary>
        [Description("Playing surface of the stadium")]
        [DataMember(Name = "PlayingSurface", Order = 7)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// Temperature at game start (Farenheit)
        /// </summary>
        [Description("Temperature at game start (Farenheit)")]
        [DataMember(Name = "Temperature", Order = 8)]
        public int? Temperature { get; set; }

        /// <summary>
        /// Humidity at game start (Percentage)
        /// </summary>
        [Description("Humidity at game start (Percentage)")]
        [DataMember(Name = "Humidity", Order = 9)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Wind speed at game start (MPH)
        /// </summary>
        [Description("Wind speed at game start (MPH)")]
        [DataMember(Name = "WindSpeed", Order = 10)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 11)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 12)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The final score of the Away Team
        /// </summary>
        [Description("The final score of the Away Team")]
        [DataMember(Name = "AwayScore", Order = 13)]
        public int AwayScore { get; set; }

        /// <summary>
        /// The final score of the Home Team
        /// </summary>
        [Description("The final score of the Home Team")]
        [DataMember(Name = "HomeScore", Order = 14)]
        public int HomeScore { get; set; }

        /// <summary>
        /// The total score of both teams
        /// </summary>
        [Description("The total score of both teams")]
        [DataMember(Name = "TotalScore", Order = 15)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 16)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 17)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "AwayScoreQuarter1", Order = 18)]
        public int? AwayScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "AwayScoreQuarter2", Order = 19)]
        public int? AwayScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "AwayScoreQuarter3", Order = 20)]
        public int? AwayScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "AwayScoreQuarter4", Order = 21)]
        public int? AwayScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "AwayScoreOvertime", Order = 22)]
        public int? AwayScoreOvertime { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "HomeScoreQuarter1", Order = 23)]
        public int? HomeScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "HomeScoreQuarter2", Order = 24)]
        public int? HomeScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "HomeScoreQuarter3", Order = 25)]
        public int? HomeScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "HomeScoreQuarter4", Order = 26)]
        public int? HomeScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "HomeScoreOvertime", Order = 27)]
        public int? HomeScoreOvertime { get; set; }

        /// <summary>
        /// Time of Possession
        /// </summary>
        [Description("Time of Possession")]
        [DataMember(Name = "AwayTimeOfPossession", Order = 28)]
        public string AwayTimeOfPossession { get; set; }

        /// <summary>
        /// Time of Possession
        /// </summary>
        [Description("Time of Possession")]
        [DataMember(Name = "HomeTimeOfPossession", Order = 29)]
        public string HomeTimeOfPossession { get; set; }

        /// <summary>
        /// Total First Downs
        /// </summary>
        [Description("Total First Downs")]
        [DataMember(Name = "AwayFirstDowns", Order = 30)]
        public int? AwayFirstDowns { get; set; }

        /// <summary>
        /// Total First Downs
        /// </summary>
        [Description("Total First Downs")]
        [DataMember(Name = "HomeFirstDowns", Order = 31)]
        public int? HomeFirstDowns { get; set; }

        /// <summary>
        /// Rushing First Downs
        /// </summary>
        [Description("Rushing First Downs")]
        [DataMember(Name = "AwayFirstDownsByRushing", Order = 32)]
        public int? AwayFirstDownsByRushing { get; set; }

        /// <summary>
        /// Rushing First Downs
        /// </summary>
        [Description("Rushing First Downs")]
        [DataMember(Name = "HomeFirstDownsByRushing", Order = 33)]
        public int? HomeFirstDownsByRushing { get; set; }

        /// <summary>
        /// Passing First Downs
        /// </summary>
        [Description("Passing First Downs")]
        [DataMember(Name = "AwayFirstDownsByPassing", Order = 34)]
        public int? AwayFirstDownsByPassing { get; set; }

        /// <summary>
        /// Passing First Downs
        /// </summary>
        [Description("Passing First Downs")]
        [DataMember(Name = "HomeFirstDownsByPassing", Order = 35)]
        public int? HomeFirstDownsByPassing { get; set; }

        /// <summary>
        /// First Downs (via Penalty)
        /// </summary>
        [Description("First Downs (via Penalty)")]
        [DataMember(Name = "AwayFirstDownsByPenalty", Order = 36)]
        public int? AwayFirstDownsByPenalty { get; set; }

        /// <summary>
        /// First Downs (via Penalty)
        /// </summary>
        [Description("First Downs (via Penalty)")]
        [DataMember(Name = "HomeFirstDownsByPenalty", Order = 37)]
        public int? HomeFirstDownsByPenalty { get; set; }

        /// <summary>
        /// Number of offensive plays run
        /// </summary>
        [Description("Number of offensive plays run")]
        [DataMember(Name = "AwayOffensivePlays", Order = 38)]
        public int? AwayOffensivePlays { get; set; }

        /// <summary>
        /// Number of offensive plays run
        /// </summary>
        [Description("Number of offensive plays run")]
        [DataMember(Name = "HomeOffensivePlays", Order = 39)]
        public int? HomeOffensivePlays { get; set; }

        /// <summary>
        /// Number of offensive yards gained
        /// </summary>
        [Description("Number of offensive yards gained")]
        [DataMember(Name = "AwayOffensiveYards", Order = 40)]
        public int? AwayOffensiveYards { get; set; }

        /// <summary>
        /// Number of offensive yards gained
        /// </summary>
        [Description("Number of offensive yards gained")]
        [DataMember(Name = "HomeOffensiveYards", Order = 41)]
        public int? HomeOffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play
        /// </summary>
        [Description("Average yards gained per offensive play")]
        [DataMember(Name = "AwayOffensiveYardsPerPlay", Order = 42)]
        public decimal? AwayOffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Average yards gained per offensive play
        /// </summary>
        [Description("Average yards gained per offensive play")]
        [DataMember(Name = "HomeOffensiveYardsPerPlay", Order = 43)]
        public decimal? HomeOffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Touchdowns scored
        /// </summary>
        [Description("Touchdowns scored")]
        [DataMember(Name = "AwayTouchdowns", Order = 44)]
        public int? AwayTouchdowns { get; set; }

        /// <summary>
        /// Touchdowns scored
        /// </summary>
        [Description("Touchdowns scored")]
        [DataMember(Name = "HomeTouchdowns", Order = 45)]
        public int? HomeTouchdowns { get; set; }

        /// <summary>
        /// Number of rushing attempts
        /// </summary>
        [Description("Number of rushing attempts")]
        [DataMember(Name = "AwayRushingAttempts", Order = 46)]
        public int? AwayRushingAttempts { get; set; }

        /// <summary>
        /// Number of rushing attempts
        /// </summary>
        [Description("Number of rushing attempts")]
        [DataMember(Name = "HomeRushingAttempts", Order = 47)]
        public int? HomeRushingAttempts { get; set; }

        /// <summary>
        /// Number of rushing yards
        /// </summary>
        [Description("Number of rushing yards")]
        [DataMember(Name = "AwayRushingYards", Order = 48)]
        public int? AwayRushingYards { get; set; }

        /// <summary>
        /// Number of rushing yards
        /// </summary>
        [Description("Number of rushing yards")]
        [DataMember(Name = "HomeRushingYards", Order = 49)]
        public int? HomeRushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt
        /// </summary>
        [Description("Average rushing yards gained per attempt")]
        [DataMember(Name = "AwayRushingYardsPerAttempt", Order = 50)]
        public decimal? AwayRushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt
        /// </summary>
        [Description("Average rushing yards gained per attempt")]
        [DataMember(Name = "HomeRushingYardsPerAttempt", Order = 51)]
        public decimal? HomeRushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Rushing touchdowns scored
        /// </summary>
        [Description("Rushing touchdowns scored")]
        [DataMember(Name = "AwayRushingTouchdowns", Order = 52)]
        public int? AwayRushingTouchdowns { get; set; }

        /// <summary>
        /// Rushing touchdowns scored
        /// </summary>
        [Description("Rushing touchdowns scored")]
        [DataMember(Name = "HomeRushingTouchdowns", Order = 53)]
        public int? HomeRushingTouchdowns { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "AwayPassingAttempts", Order = 54)]
        public int? AwayPassingAttempts { get; set; }

        /// <summary>
        /// Number of passes thrown
        /// </summary>
        [Description("Number of passes thrown")]
        [DataMember(Name = "HomePassingAttempts", Order = 55)]
        public int? HomePassingAttempts { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "AwayPassingCompletions", Order = 56)]
        public int? AwayPassingCompletions { get; set; }

        /// <summary>
        /// Number of pass completions
        /// </summary>
        [Description("Number of pass completions")]
        [DataMember(Name = "HomePassingCompletions", Order = 57)]
        public int? HomePassingCompletions { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "AwayPassingYards", Order = 58)]
        public int? AwayPassingYards { get; set; }

        /// <summary>
        /// Number of passing yards
        /// </summary>
        [Description("Number of passing yards")]
        [DataMember(Name = "HomePassingYards", Order = 59)]
        public int? HomePassingYards { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "AwayPassingTouchdowns", Order = 60)]
        public int? AwayPassingTouchdowns { get; set; }

        /// <summary>
        /// Passing touchdowns thrown
        /// </summary>
        [Description("Passing touchdowns thrown")]
        [DataMember(Name = "HomePassingTouchdowns", Order = 61)]
        public int? HomePassingTouchdowns { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "AwayPassingInterceptions", Order = 62)]
        public int? AwayPassingInterceptions { get; set; }

        /// <summary>
        /// Interceptions thrown
        /// </summary>
        [Description("Interceptions thrown")]
        [DataMember(Name = "HomePassingInterceptions", Order = 63)]
        public int? HomePassingInterceptions { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "AwayPassingYardsPerAttempt", Order = 64)]
        public decimal? AwayPassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt
        /// </summary>
        [Description("Average passing yards gained per attempt")]
        [DataMember(Name = "HomePassingYardsPerAttempt", Order = 65)]
        public decimal? HomePassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "AwayPassingYardsPerCompletion", Order = 66)]
        public decimal? AwayPassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Average passing yards gained per completion
        /// </summary>
        [Description("Average passing yards gained per completion")]
        [DataMember(Name = "HomePassingYardsPerCompletion", Order = 67)]
        public decimal? HomePassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "AwayCompletionPercentage", Order = 68)]
        public decimal? AwayCompletionPercentage { get; set; }

        /// <summary>
        /// Percentage of passes that were completed
        /// </summary>
        [Description("Percentage of passes that were completed")]
        [DataMember(Name = "HomeCompletionPercentage", Order = 69)]
        public decimal? HomeCompletionPercentage { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "AwayPasserRating", Order = 70)]
        public decimal? AwayPasserRating { get; set; }

        /// <summary>
        /// Passer rating
        /// </summary>
        [Description("Passer rating")]
        [DataMember(Name = "HomePasserRating", Order = 71)]
        public decimal? HomePasserRating { get; set; }

        /// <summary>
        /// Third down attempts
        /// </summary>
        [Description("Third down attempts")]
        [DataMember(Name = "AwayThirdDownAttempts", Order = 72)]
        public int? AwayThirdDownAttempts { get; set; }

        /// <summary>
        /// Third down attempts
        /// </summary>
        [Description("Third down attempts")]
        [DataMember(Name = "HomeThirdDownAttempts", Order = 73)]
        public int? HomeThirdDownAttempts { get; set; }

        /// <summary>
        /// Third down conversions
        /// </summary>
        [Description("Third down conversions")]
        [DataMember(Name = "AwayThirdDownConversions", Order = 74)]
        public int? AwayThirdDownConversions { get; set; }

        /// <summary>
        /// Third down conversions
        /// </summary>
        [Description("Third down conversions")]
        [DataMember(Name = "HomeThirdDownConversions", Order = 75)]
        public int? HomeThirdDownConversions { get; set; }

        /// <summary>
        /// Percentage of third downs converted
        /// </summary>
        [Description("Percentage of third downs converted")]
        [DataMember(Name = "AwayThirdDownPercentage", Order = 76)]
        public decimal? AwayThirdDownPercentage { get; set; }

        /// <summary>
        /// Percentage of third downs converted
        /// </summary>
        [Description("Percentage of third downs converted")]
        [DataMember(Name = "HomeThirdDownPercentage", Order = 77)]
        public decimal? HomeThirdDownPercentage { get; set; }

        /// <summary>
        /// Fourth down attempts
        /// </summary>
        [Description("Fourth down attempts")]
        [DataMember(Name = "AwayFourthDownAttempts", Order = 78)]
        public int? AwayFourthDownAttempts { get; set; }

        /// <summary>
        /// Fourth down attempts
        /// </summary>
        [Description("Fourth down attempts")]
        [DataMember(Name = "HomeFourthDownAttempts", Order = 79)]
        public int? HomeFourthDownAttempts { get; set; }

        /// <summary>
        /// Fourth down conversions
        /// </summary>
        [Description("Fourth down conversions")]
        [DataMember(Name = "AwayFourthDownConversions", Order = 80)]
        public int? AwayFourthDownConversions { get; set; }

        /// <summary>
        /// Fourth down conversions
        /// </summary>
        [Description("Fourth down conversions")]
        [DataMember(Name = "HomeFourthDownConversions", Order = 81)]
        public int? HomeFourthDownConversions { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted
        /// </summary>
        [Description("Percentage of fourth downs converted")]
        [DataMember(Name = "AwayFourthDownPercentage", Order = 82)]
        public decimal? AwayFourthDownPercentage { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted
        /// </summary>
        [Description("Percentage of fourth downs converted")]
        [DataMember(Name = "HomeFourthDownPercentage", Order = 83)]
        public decimal? HomeFourthDownPercentage { get; set; }

        /// <summary>
        /// Red zone opportunities
        /// </summary>
        [Description("Red zone opportunities")]
        [DataMember(Name = "AwayRedZoneAttempts", Order = 84)]
        public int? AwayRedZoneAttempts { get; set; }

        /// <summary>
        /// Red zone opportunities
        /// </summary>
        [Description("Red zone opportunities")]
        [DataMember(Name = "HomeRedZoneAttempts", Order = 85)]
        public int? HomeRedZoneAttempts { get; set; }

        /// <summary>
        /// Red zone opportunities converted to touchdowns
        /// </summary>
        [Description("Red zone opportunities converted to touchdowns")]
        [DataMember(Name = "AwayRedZoneConversions", Order = 86)]
        public int? AwayRedZoneConversions { get; set; }

        /// <summary>
        /// Red zone opportunities converted to touchdowns
        /// </summary>
        [Description("Red zone opportunities converted to touchdowns")]
        [DataMember(Name = "HomeRedZoneConversions", Order = 87)]
        public int? HomeRedZoneConversions { get; set; }

        /// <summary>
        /// 1st & Goal opportunities
        /// </summary>
        [Description("1st & Goal opportunities")]
        [DataMember(Name = "AwayGoalToGoAttempts", Order = 88)]
        public int? AwayGoalToGoAttempts { get; set; }

        /// <summary>
        /// 1st & Goal opportunities
        /// </summary>
        [Description("1st & Goal opportunities")]
        [DataMember(Name = "HomeGoalToGoAttempts", Order = 89)]
        public int? HomeGoalToGoAttempts { get; set; }

        /// <summary>
        /// 1st & Goal opportunities converted to touchdowns
        /// </summary>
        [Description("1st & Goal opportunities converted to touchdowns")]
        [DataMember(Name = "AwayGoalToGoConversions", Order = 90)]
        public int? AwayGoalToGoConversions { get; set; }

        /// <summary>
        /// 1st & Goal opportunities converted to touchdowns
        /// </summary>
        [Description("1st & Goal opportunities converted to touchdowns")]
        [DataMember(Name = "HomeGoalToGoConversions", Order = 91)]
        public int? HomeGoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards
        /// </summary>
        [Description("Total punt and defensive return yards")]
        [DataMember(Name = "AwayReturnYards", Order = 92)]
        public int? AwayReturnYards { get; set; }

        /// <summary>
        /// Total punt and defensive return yards
        /// </summary>
        [Description("Total punt and defensive return yards")]
        [DataMember(Name = "HomeReturnYards", Order = 93)]
        public int? HomeReturnYards { get; set; }

        /// <summary>
        /// Penalties committed
        /// </summary>
        [Description("Penalties committed")]
        [DataMember(Name = "AwayPenalties", Order = 94)]
        public int? AwayPenalties { get; set; }

        /// <summary>
        /// Penalties committed
        /// </summary>
        [Description("Penalties committed")]
        [DataMember(Name = "HomePenalties", Order = 95)]
        public int? HomePenalties { get; set; }

        /// <summary>
        /// Penalty yards enforced against the away team
        /// </summary>
        [Description("Penalty yards enforced against the away team")]
        [DataMember(Name = "AwayPenaltyYards", Order = 96)]
        public int? AwayPenaltyYards { get; set; }

        /// <summary>
        /// Penalty yards enforced against the away team
        /// </summary>
        [Description("Penalty yards enforced against the away team")]
        [DataMember(Name = "HomePenaltyYards", Order = 97)]
        public int? HomePenaltyYards { get; set; }

        /// <summary>
        /// Fumbles
        /// </summary>
        [Description("Fumbles")]
        [DataMember(Name = "AwayFumbles", Order = 98)]
        public int? AwayFumbles { get; set; }

        /// <summary>
        /// Fumbles
        /// </summary>
        [Description("Fumbles")]
        [DataMember(Name = "HomeFumbles", Order = 99)]
        public int? HomeFumbles { get; set; }

        /// <summary>
        /// Fumbles lost
        /// </summary>
        [Description("Fumbles lost")]
        [DataMember(Name = "AwayFumblesLost", Order = 100)]
        public int? AwayFumblesLost { get; set; }

        /// <summary>
        /// Fumbles lost
        /// </summary>
        [Description("Fumbles lost")]
        [DataMember(Name = "HomeFumblesLost", Order = 101)]
        public int? HomeFumblesLost { get; set; }

        /// <summary>
        /// Number of times the away team was sacked
        /// </summary>
        [Description("Number of times the away team was sacked")]
        [DataMember(Name = "AwayTimesSacked", Order = 102)]
        public int? AwayTimesSacked { get; set; }

        /// <summary>
        /// Number of times the away team was sacked
        /// </summary>
        [Description("Number of times the away team was sacked")]
        [DataMember(Name = "HomeTimesSacked", Order = 103)]
        public int? HomeTimesSacked { get; set; }

        /// <summary>
        /// Number of yards lost as a result of being sacked
        /// </summary>
        [Description("Number of yards lost as a result of being sacked")]
        [DataMember(Name = "AwayTimesSackedYards", Order = 104)]
        public int? AwayTimesSackedYards { get; set; }

        /// <summary>
        /// Number of yards lost as a result of being sacked
        /// </summary>
        [Description("Number of yards lost as a result of being sacked")]
        [DataMember(Name = "HomeTimesSackedYards", Order = 105)]
        public int? HomeTimesSackedYards { get; set; }

        /// <summary>
        /// Safeties scored
        /// </summary>
        [Description("Safeties scored")]
        [DataMember(Name = "AwaySafeties", Order = 106)]
        public int? AwaySafeties { get; set; }

        /// <summary>
        /// Safeties scored
        /// </summary>
        [Description("Safeties scored")]
        [DataMember(Name = "HomeSafeties", Order = 107)]
        public int? HomeSafeties { get; set; }

        /// <summary>
        /// Number of punts
        /// </summary>
        [Description("Number of punts")]
        [DataMember(Name = "AwayPunts", Order = 108)]
        public int? AwayPunts { get; set; }

        /// <summary>
        /// Number of punts
        /// </summary>
        [Description("Number of punts")]
        [DataMember(Name = "HomePunts", Order = 109)]
        public int? HomePunts { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "AwayPuntYards", Order = 110)]
        public int? AwayPuntYards { get; set; }

        /// <summary>
        /// Total punt yards
        /// </summary>
        [Description("Total punt yards")]
        [DataMember(Name = "HomePuntYards", Order = 111)]
        public int? HomePuntYards { get; set; }

        /// <summary>
        /// Average number of yards per punt
        /// </summary>
        [Description("Average number of yards per punt")]
        [DataMember(Name = "AwayPuntAverage", Order = 112)]
        public decimal? AwayPuntAverage { get; set; }

        /// <summary>
        /// Average number of yards per punt
        /// </summary>
        [Description("Average number of yards per punt")]
        [DataMember(Name = "HomePuntAverage", Order = 113)]
        public decimal? HomePuntAverage { get; set; }

        /// <summary>
        /// Number of giveaways
        /// </summary>
        [Description("Number of giveaways")]
        [DataMember(Name = "AwayGiveaways", Order = 114)]
        public int? AwayGiveaways { get; set; }

        /// <summary>
        /// Number of giveaways
        /// </summary>
        [Description("Number of giveaways")]
        [DataMember(Name = "HomeGiveaways", Order = 115)]
        public int? HomeGiveaways { get; set; }

        /// <summary>
        /// Number of takeaways
        /// </summary>
        [Description("Number of takeaways")]
        [DataMember(Name = "AwayTakeaways", Order = 116)]
        public int? AwayTakeaways { get; set; }

        /// <summary>
        /// Number of takeaways
        /// </summary>
        [Description("Number of takeaways")]
        [DataMember(Name = "HomeTakeaways", Order = 117)]
        public int? HomeTakeaways { get; set; }

        /// <summary>
        /// Number of takeaways minus giveaways
        /// </summary>
        [Description("Number of takeaways minus giveaways")]
        [DataMember(Name = "AwayTurnoverDifferential", Order = 118)]
        public int? AwayTurnoverDifferential { get; set; }

        /// <summary>
        /// Number of takeaways minus giveaways
        /// </summary>
        [Description("Number of takeaways minus giveaways")]
        [DataMember(Name = "HomeTurnoverDifferential", Order = 119)]
        public int? HomeTurnoverDifferential { get; set; }

        /// <summary>
        /// Number of kickoffs
        /// </summary>
        [Description("Number of kickoffs")]
        [DataMember(Name = "AwayKickoffs", Order = 120)]
        public int? AwayKickoffs { get; set; }

        /// <summary>
        /// Number of kickoffs
        /// </summary>
        [Description("Number of kickoffs")]
        [DataMember(Name = "HomeKickoffs", Order = 121)]
        public int? HomeKickoffs { get; set; }

        /// <summary>
        /// Number of kickoffs that went into the end zone
        /// </summary>
        [Description("Number of kickoffs that went into the end zone")]
        [DataMember(Name = "AwayKickoffsInEndZone", Order = 122)]
        public int? AwayKickoffsInEndZone { get; set; }

        /// <summary>
        /// Number of kickoffs that went into the end zone
        /// </summary>
        [Description("Number of kickoffs that went into the end zone")]
        [DataMember(Name = "HomeKickoffsInEndZone", Order = 123)]
        public int? HomeKickoffsInEndZone { get; set; }

        /// <summary>
        /// Number of kickoffs that resulted in touchbacks
        /// </summary>
        [Description("Number of kickoffs that resulted in touchbacks")]
        [DataMember(Name = "AwayKickoffTouchbacks", Order = 124)]
        public int? AwayKickoffTouchbacks { get; set; }

        /// <summary>
        /// Number of kickoffs that resulted in touchbacks
        /// </summary>
        [Description("Number of kickoffs that resulted in touchbacks")]
        [DataMember(Name = "HomeKickoffTouchbacks", Order = 125)]
        public int? HomeKickoffTouchbacks { get; set; }

        /// <summary>
        /// Number of punts that were blocked
        /// </summary>
        [Description("Number of punts that were blocked")]
        [DataMember(Name = "AwayPuntsHadBlocked", Order = 126)]
        public int? AwayPuntsHadBlocked { get; set; }

        /// <summary>
        /// Number of punts that were blocked
        /// </summary>
        [Description("Number of punts that were blocked")]
        [DataMember(Name = "HomePuntsHadBlocked", Order = 127)]
        public int? HomePuntsHadBlocked { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "AwayPuntNetAverage", Order = 128)]
        public decimal? AwayPuntNetAverage { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "HomePuntNetAverage", Order = 129)]
        public decimal? HomePuntNetAverage { get; set; }

        /// <summary>
        /// Extra point kick attempts
        /// </summary>
        [Description("Extra point kick attempts")]
        [DataMember(Name = "AwayExtraPointKickingAttempts", Order = 130)]
        public int? AwayExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Extra point kick attempts
        /// </summary>
        [Description("Extra point kick attempts")]
        [DataMember(Name = "HomeExtraPointKickingAttempts", Order = 131)]
        public int? HomeExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Extra point kicks made
        /// </summary>
        [Description("Extra point kicks made")]
        [DataMember(Name = "AwayExtraPointKickingConversions", Order = 132)]
        public int? AwayExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Extra point kicks made
        /// </summary>
        [Description("Extra point kicks made")]
        [DataMember(Name = "HomeExtraPointKickingConversions", Order = 133)]
        public int? HomeExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Extra point kick attempts that were blocked
        /// </summary>
        [Description("Extra point kick attempts that were blocked")]
        [DataMember(Name = "AwayExtraPointsHadBlocked", Order = 134)]
        public int? AwayExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Extra point kick attempts that were blocked
        /// </summary>
        [Description("Extra point kick attempts that were blocked")]
        [DataMember(Name = "HomeExtraPointsHadBlocked", Order = 135)]
        public int? HomeExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Two point conversion passing attempts
        /// </summary>
        [Description("Two point conversion passing attempts")]
        [DataMember(Name = "AwayExtraPointPassingAttempts", Order = 136)]
        public int? AwayExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Two point conversion passing attempts
        /// </summary>
        [Description("Two point conversion passing attempts")]
        [DataMember(Name = "HomeExtraPointPassingAttempts", Order = 137)]
        public int? HomeExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Two point conversion passing conversions
        /// </summary>
        [Description("Two point conversion passing conversions")]
        [DataMember(Name = "AwayExtraPointPassingConversions", Order = 138)]
        public int? AwayExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Two point conversion passing conversions
        /// </summary>
        [Description("Two point conversion passing conversions")]
        [DataMember(Name = "HomeExtraPointPassingConversions", Order = 139)]
        public int? HomeExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Two point conversion rushing attempts
        /// </summary>
        [Description("Two point conversion rushing attempts")]
        [DataMember(Name = "AwayExtraPointRushingAttempts", Order = 140)]
        public int? AwayExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Two point conversion rushing attempts
        /// </summary>
        [Description("Two point conversion rushing attempts")]
        [DataMember(Name = "HomeExtraPointRushingAttempts", Order = 141)]
        public int? HomeExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Two point conversion rushing conversions
        /// </summary>
        [Description("Two point conversion rushing conversions")]
        [DataMember(Name = "AwayExtraPointRushingConversions", Order = 142)]
        public int? AwayExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Two point conversion rushing conversions
        /// </summary>
        [Description("Two point conversion rushing conversions")]
        [DataMember(Name = "HomeExtraPointRushingConversions", Order = 143)]
        public int? HomeExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Field goal attempts
        /// </summary>
        [Description("Field goal attempts")]
        [DataMember(Name = "AwayFieldGoalAttempts", Order = 144)]
        public int? AwayFieldGoalAttempts { get; set; }

        /// <summary>
        /// Field goal attempts
        /// </summary>
        [Description("Field goal attempts")]
        [DataMember(Name = "HomeFieldGoalAttempts", Order = 145)]
        public int? HomeFieldGoalAttempts { get; set; }

        /// <summary>
        /// Field goals made
        /// </summary>
        [Description("Field goals made")]
        [DataMember(Name = "AwayFieldGoalsMade", Order = 146)]
        public int? AwayFieldGoalsMade { get; set; }

        /// <summary>
        /// Field goals made
        /// </summary>
        [Description("Field goals made")]
        [DataMember(Name = "HomeFieldGoalsMade", Order = 147)]
        public int? HomeFieldGoalsMade { get; set; }

        /// <summary>
        /// Field goal attempts that were blocked
        /// </summary>
        [Description("Field goal attempts that were blocked")]
        [DataMember(Name = "AwayFieldGoalsHadBlocked", Order = 148)]
        public int? AwayFieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Field goal attempts that were blocked
        /// </summary>
        [Description("Field goal attempts that were blocked")]
        [DataMember(Name = "HomeFieldGoalsHadBlocked", Order = 149)]
        public int? HomeFieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Punt returns
        /// </summary>
        [Description("Punt returns")]
        [DataMember(Name = "AwayPuntReturns", Order = 150)]
        public int? AwayPuntReturns { get; set; }

        /// <summary>
        /// Punt returns
        /// </summary>
        [Description("Punt returns")]
        [DataMember(Name = "HomePuntReturns", Order = 151)]
        public int? HomePuntReturns { get; set; }

        /// <summary>
        /// Punt return yards
        /// </summary>
        [Description("Punt return yards")]
        [DataMember(Name = "AwayPuntReturnYards", Order = 152)]
        public int? AwayPuntReturnYards { get; set; }

        /// <summary>
        /// Punt return yards
        /// </summary>
        [Description("Punt return yards")]
        [DataMember(Name = "HomePuntReturnYards", Order = 153)]
        public int? HomePuntReturnYards { get; set; }

        /// <summary>
        /// Kickoff returns
        /// </summary>
        [Description("Kickoff returns")]
        [DataMember(Name = "AwayKickReturns", Order = 154)]
        public int? AwayKickReturns { get; set; }

        /// <summary>
        /// Kickoff returns
        /// </summary>
        [Description("Kickoff returns")]
        [DataMember(Name = "HomeKickReturns", Order = 155)]
        public int? HomeKickReturns { get; set; }

        /// <summary>
        /// Kickoff return yards
        /// </summary>
        [Description("Kickoff return yards")]
        [DataMember(Name = "AwayKickReturnYards", Order = 156)]
        public int? AwayKickReturnYards { get; set; }

        /// <summary>
        /// Kickoff return yards
        /// </summary>
        [Description("Kickoff return yards")]
        [DataMember(Name = "HomeKickReturnYards", Order = 157)]
        public int? HomeKickReturnYards { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "AwayInterceptionReturns", Order = 158)]
        public int? AwayInterceptionReturns { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "HomeInterceptionReturns", Order = 159)]
        public int? HomeInterceptionReturns { get; set; }

        /// <summary>
        /// Interception return yards
        /// </summary>
        [Description("Interception return yards")]
        [DataMember(Name = "AwayInterceptionReturnYards", Order = 160)]
        public int? AwayInterceptionReturnYards { get; set; }

        /// <summary>
        /// Interception return yards
        /// </summary>
        [Description("Interception return yards")]
        [DataMember(Name = "HomeInterceptionReturnYards", Order = 161)]
        public int? HomeInterceptionReturnYards { get; set; }

        /// <summary>
        /// Defensive solo tackles
        /// </summary>
        [Description("Defensive solo tackles")]
        [DataMember(Name = "AwaySoloTackles", Order = 162)]
        public int? AwaySoloTackles { get; set; }

        /// <summary>
        /// Defensive assisted tackles
        /// </summary>
        [Description("Defensive assisted tackles")]
        [DataMember(Name = "AwayAssistedTackles", Order = 163)]
        public int? AwayAssistedTackles { get; set; }

        /// <summary>
        /// Defensive QB hits
        /// </summary>
        [Description("Defensive QB hits")]
        [DataMember(Name = "AwayQuarterbackHits", Order = 164)]
        public int? AwayQuarterbackHits { get; set; }

        /// <summary>
        /// Defensive tackles for a loss
        /// </summary>
        [Description("Defensive tackles for a loss")]
        [DataMember(Name = "AwayTacklesForLoss", Order = 165)]
        public int? AwayTacklesForLoss { get; set; }

        /// <summary>
        /// Defensive sacks
        /// </summary>
        [Description("Defensive sacks")]
        [DataMember(Name = "AwaySacks", Order = 166)]
        public int? AwaySacks { get; set; }

        /// <summary>
        /// Defensive sack yards
        /// </summary>
        [Description("Defensive sack yards")]
        [DataMember(Name = "AwaySackYards", Order = 167)]
        public int? AwaySackYards { get; set; }

        /// <summary>
        /// Defensive passes defended
        /// </summary>
        [Description("Defensive passes defended")]
        [DataMember(Name = "AwayPassesDefended", Order = 168)]
        public int? AwayPassesDefended { get; set; }

        /// <summary>
        /// Defensive fumbles forced
        /// </summary>
        [Description("Defensive fumbles forced")]
        [DataMember(Name = "AwayFumblesForced", Order = 169)]
        public int? AwayFumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered that resulted in change of possession
        /// </summary>
        [Description("Fumbles recovered that resulted in change of possession")]
        [DataMember(Name = "AwayFumblesRecovered", Order = 170)]
        public int? AwayFumblesRecovered { get; set; }

        /// <summary>
        /// Fumble return yards
        /// </summary>
        [Description("Fumble return yards")]
        [DataMember(Name = "AwayFumbleReturnYards", Order = 171)]
        public int? AwayFumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble return touchdowns
        /// </summary>
        [Description("Fumble return touchdowns")]
        [DataMember(Name = "AwayFumbleReturnTouchdowns", Order = 172)]
        public int? AwayFumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "AwayInterceptionReturnTouchdowns", Order = 173)]
        public int? AwayInterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of opponent's kicks that were blocked
        /// </summary>
        [Description("Total number of opponent's kicks that were blocked")]
        [DataMember(Name = "AwayBlockedKicks", Order = 174)]
        public int? AwayBlockedKicks { get; set; }

        /// <summary>
        /// Punt return touchdown
        /// </summary>
        [Description("Punt return touchdown")]
        [DataMember(Name = "AwayPuntReturnTouchdowns", Order = 175)]
        public int? AwayPuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "AwayPuntReturnLong", Order = 176)]
        public int? AwayPuntReturnLong { get; set; }

        /// <summary>
        /// Kick return touchdown
        /// </summary>
        [Description("Kick return touchdown")]
        [DataMember(Name = "AwayKickReturnTouchdowns", Order = 177)]
        public int? AwayKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "AwayKickReturnLong", Order = 178)]
        public int? AwayKickReturnLong { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "AwayBlockedKickReturnYards", Order = 179)]
        public int? AwayBlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick recovery return touchdowns
        /// </summary>
        [Description("Blocked kick recovery return touchdowns")]
        [DataMember(Name = "AwayBlockedKickReturnTouchdowns", Order = 180)]
        public int? AwayBlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "AwayFieldGoalReturnYards", Order = 181)]
        public int? AwayFieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return touchdowns (excluding blocked field goals)")]
        [DataMember(Name = "AwayFieldGoalReturnTouchdowns", Order = 182)]
        public int? AwayFieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "AwayPuntNetYards", Order = 183)]
        public int? AwayPuntNetYards { get; set; }

        /// <summary>
        /// Defensive solo tackles
        /// </summary>
        [Description("Defensive solo tackles")]
        [DataMember(Name = "HomeSoloTackles", Order = 184)]
        public int? HomeSoloTackles { get; set; }

        /// <summary>
        /// Defensive assisted tackles
        /// </summary>
        [Description("Defensive assisted tackles")]
        [DataMember(Name = "HomeAssistedTackles", Order = 185)]
        public int? HomeAssistedTackles { get; set; }

        /// <summary>
        /// Defensive QB hits
        /// </summary>
        [Description("Defensive QB hits")]
        [DataMember(Name = "HomeQuarterbackHits", Order = 186)]
        public int? HomeQuarterbackHits { get; set; }

        /// <summary>
        /// Defensive tackles for a loss
        /// </summary>
        [Description("Defensive tackles for a loss")]
        [DataMember(Name = "HomeTacklesForLoss", Order = 187)]
        public int? HomeTacklesForLoss { get; set; }

        /// <summary>
        /// Defensive sacks
        /// </summary>
        [Description("Defensive sacks")]
        [DataMember(Name = "HomeSacks", Order = 188)]
        public int? HomeSacks { get; set; }

        /// <summary>
        /// Defensive sack yards
        /// </summary>
        [Description("Defensive sack yards")]
        [DataMember(Name = "HomeSackYards", Order = 189)]
        public int? HomeSackYards { get; set; }

        /// <summary>
        /// Defensive passes defended
        /// </summary>
        [Description("Defensive passes defended")]
        [DataMember(Name = "HomePassesDefended", Order = 190)]
        public int? HomePassesDefended { get; set; }

        /// <summary>
        /// Defensive fumbles forced
        /// </summary>
        [Description("Defensive fumbles forced")]
        [DataMember(Name = "HomeFumblesForced", Order = 191)]
        public int? HomeFumblesForced { get; set; }

        /// <summary>
        /// Fumbles recovered that resulted in change of possession
        /// </summary>
        [Description("Fumbles recovered that resulted in change of possession")]
        [DataMember(Name = "HomeFumblesRecovered", Order = 192)]
        public int? HomeFumblesRecovered { get; set; }

        /// <summary>
        /// Fumble return yards
        /// </summary>
        [Description("Fumble return yards")]
        [DataMember(Name = "HomeFumbleReturnYards", Order = 193)]
        public int? HomeFumbleReturnYards { get; set; }

        /// <summary>
        /// Fumble return touchdowns
        /// </summary>
        [Description("Fumble return touchdowns")]
        [DataMember(Name = "HomeFumbleReturnTouchdowns", Order = 194)]
        public int? HomeFumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Defensive interceptions
        /// </summary>
        [Description("Defensive interceptions")]
        [DataMember(Name = "HomeInterceptionReturnTouchdowns", Order = 195)]
        public int? HomeInterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total number of opponent's kicks that were blocked
        /// </summary>
        [Description("Total number of opponent's kicks that were blocked")]
        [DataMember(Name = "HomeBlockedKicks", Order = 196)]
        public int? HomeBlockedKicks { get; set; }

        /// <summary>
        /// Punt return touchdown
        /// </summary>
        [Description("Punt return touchdown")]
        [DataMember(Name = "HomePuntReturnTouchdowns", Order = 197)]
        public int? HomePuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return
        /// </summary>
        [Description("Longest punt return")]
        [DataMember(Name = "HomePuntReturnLong", Order = 198)]
        public int? HomePuntReturnLong { get; set; }

        /// <summary>
        /// Kick return touchdown
        /// </summary>
        [Description("Kick return touchdown")]
        [DataMember(Name = "HomeKickReturnTouchdowns", Order = 199)]
        public int? HomeKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return
        /// </summary>
        [Description("Longest kick return")]
        [DataMember(Name = "HomeKickReturnLong", Order = 200)]
        public int? HomeKickReturnLong { get; set; }

        /// <summary>
        /// Blocked kick recovery return yards
        /// </summary>
        [Description("Blocked kick recovery return yards")]
        [DataMember(Name = "HomeBlockedKickReturnYards", Order = 201)]
        public int? HomeBlockedKickReturnYards { get; set; }

        /// <summary>
        /// Blocked kick recovery return touchdowns
        /// </summary>
        [Description("Blocked kick recovery return touchdowns")]
        [DataMember(Name = "HomeBlockedKickReturnTouchdowns", Order = 202)]
        public int? HomeBlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Field goal return yards (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return yards (excluding blocked field goals)")]
        [DataMember(Name = "HomeFieldGoalReturnYards", Order = 203)]
        public int? HomeFieldGoalReturnYards { get; set; }

        /// <summary>
        /// Field goal return touchdowns (excluding blocked field goals)
        /// </summary>
        [Description("Field goal return touchdowns (excluding blocked field goals)")]
        [DataMember(Name = "HomeFieldGoalReturnTouchdowns", Order = 204)]
        public int? HomeFieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [Description("Deprecated")]
        [DataMember(Name = "HomePuntNetYards", Order = 205)]
        public int? HomePuntNetYards { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 206)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Auto generated unique ID for this game (subject to change, although it very rarely does).  For a static ID, use GameKey.
        /// </summary>
        [Description("Auto generated unique ID for this game (subject to change, although it very rarely does).  For a static ID, use GameKey.")]
        [DataMember(Name = "GameID", Order = 207)]
        public int GameID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 208)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Two point conversion returns for two points.
        /// </summary>
        [Description("Two point conversion returns for two points.")]
        [DataMember(Name = "AwayTwoPointConversionReturns", Order = 209)]
        public int? AwayTwoPointConversionReturns { get; set; }

        /// <summary>
        /// Two point conversion returns for two points.
        /// </summary>
        [Description("Two point conversion returns for two points.")]
        [DataMember(Name = "HomeTwoPointConversionReturns", Order = 210)]
        public int? HomeTwoPointConversionReturns { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 211)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The details of the stadium where this game is played
        /// </summary>
        [Description("The details of the stadium where this game is played")]
        [DataMember(Name = "StadiumDetails", Order = 10212)]
        public Stadium StadiumDetails { get; set; }

    }
}

