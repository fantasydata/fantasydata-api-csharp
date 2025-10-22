using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="TeamSeason")]
    [Serializable]
    public partial class TeamSeason
    {
        /// <summary>
        /// The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 1)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL regular season for which these totals apply
        /// </summary>
        [Description("The NFL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// Total points scored by the team in the season
        /// </summary>
        [Description("Total points scored by the team in the season")]
        [DataMember(Name = "Score", Order = 4)]
        public int Score { get; set; }

        /// <summary>
        /// Total points scored by opponent teams in the season
        /// </summary>
        [Description("Total points scored by opponent teams in the season")]
        [DataMember(Name = "OpponentScore", Order = 5)]
        public int OpponentScore { get; set; }

        /// <summary>
        /// The total points scored and allowed by the team in the season
        /// </summary>
        [Description("The total points scored and allowed by the team in the season")]
        [DataMember(Name = "TotalScore", Order = 6)]
        public int TotalScore { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 7)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 8)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
        [DataMember(Name = "WindSpeed", Order = 9)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The average total points line (over/under) for the team in the season
        /// </summary>
        [Description("The average total points line (over/under) for the team in the season")]
        [DataMember(Name = "OverUnder", Order = 10)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The average point spread from the perspecive of the team for the season (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The average point spread from the perspecive of the team for the season (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 11)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the team in the season
        /// </summary>
        [Description("Points scored during Quarter 1 for the team in the season")]
        [DataMember(Name = "ScoreQuarter1", Order = 12)]
        public int? ScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the team in the season
        /// </summary>
        [Description("Points scored during Quarter 2 for the team in the season")]
        [DataMember(Name = "ScoreQuarter2", Order = 13)]
        public int? ScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the team in the season
        /// </summary>
        [Description("Points scored during Quarter 3 for the team in the season")]
        [DataMember(Name = "ScoreQuarter3", Order = 14)]
        public int? ScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the team in the season
        /// </summary>
        [Description("Points scored during Quarter 4 for the team in the season")]
        [DataMember(Name = "ScoreQuarter4", Order = 15)]
        public int? ScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during overtime for the team in the season
        /// </summary>
        [Description("Points scored during overtime for the team in the season")]
        [DataMember(Name = "ScoreOvertime", Order = 16)]
        public int ScoreOvertime { get; set; }

        /// <summary>
        /// Total average time of possession by the team in the season
        /// </summary>
        [Description("Total average time of possession by the team in the season")]
        [DataMember(Name = "TimeOfPossession", Order = 17)]
        public string TimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs by the team in the season
        /// </summary>
        [Description("Total first downs by the team in the season")]
        [DataMember(Name = "FirstDowns", Order = 18)]
        public int? FirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs by the team in the season
        /// </summary>
        [Description("Total rushing first downs by the team in the season")]
        [DataMember(Name = "FirstDownsByRushing", Order = 19)]
        public int? FirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs team in the season
        /// </summary>
        [Description("Total passing first downs team in the season")]
        [DataMember(Name = "FirstDownsByPassing", Order = 20)]
        public int? FirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by opponent's penalty by the team in the season
        /// </summary>
        [Description("Total first downs by opponent's penalty by the team in the season")]
        [DataMember(Name = "FirstDownsByPenalty", Order = 21)]
        public int? FirstDownsByPenalty { get; set; }

        /// <summary>
        /// Number of offensive plays run by the season in the game
        /// </summary>
        [Description("Number of offensive plays run by the season in the game")]
        [DataMember(Name = "OffensivePlays", Order = 22)]
        public int OffensivePlays { get; set; }

        /// <summary>
        /// Total offensive yards gained by the team in the season
        /// </summary>
        [Description("Total offensive yards gained by the team in the season")]
        [DataMember(Name = "OffensiveYards", Order = 23)]
        public int OffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play by the team in the season
        /// </summary>
        [Description("Average yards gained per offensive play by the team in the season")]
        [DataMember(Name = "OffensiveYardsPerPlay", Order = 24)]
        public decimal OffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Total touchdowns scored by the team in the season
        /// </summary>
        [Description("Total touchdowns scored by the team in the season")]
        [DataMember(Name = "Touchdowns", Order = 25)]
        public int? Touchdowns { get; set; }

        /// <summary>
        /// Total rushing attempts by the team in the season
        /// </summary>
        [Description("Total rushing attempts by the team in the season")]
        [DataMember(Name = "RushingAttempts", Order = 26)]
        public int? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the team in the season
        /// </summary>
        [Description("Total rushing yards by the team in the season")]
        [DataMember(Name = "RushingYards", Order = 27)]
        public int? RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt by the team in the season
        /// </summary>
        [Description("Total rushing yards per attempt by the team in the season")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 28)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the team in the season
        /// </summary>
        [Description("Total rushing touchdowns by the team in the season")]
        [DataMember(Name = "RushingTouchdowns", Order = 29)]
        public int? RushingTouchdowns { get; set; }

        /// <summary>
        /// Total passes thrown by the team in the season
        /// </summary>
        [Description("Total passes thrown by the team in the season")]
        [DataMember(Name = "PassingAttempts", Order = 30)]
        public int? PassingAttempts { get; set; }

        /// <summary>
        /// Total passes completed by the team in the season
        /// </summary>
        [Description("Total passes completed by the team in the season")]
        [DataMember(Name = "PassingCompletions", Order = 31)]
        public int? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the team in the season
        /// </summary>
        [Description("Total passing yards by the team in the season")]
        [DataMember(Name = "PassingYards", Order = 32)]
        public int? PassingYards { get; set; }

        /// <summary>
        /// Total passing touchdowns by the team in the season
        /// </summary>
        [Description("Total passing touchdowns by the team in the season")]
        [DataMember(Name = "PassingTouchdowns", Order = 33)]
        public int? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the team in the season
        /// </summary>
        [Description("Total interceptions thrown by the team in the season")]
        [DataMember(Name = "PassingInterceptions", Order = 34)]
        public int? PassingInterceptions { get; set; }

        /// <summary>
        /// Total average passing yards per attempt by the team in the season
        /// </summary>
        [Description("Total average passing yards per attempt by the team in the season")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 35)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total average passing yards per completion by the team in the season
        /// </summary>
        [Description("Total average passing yards per completion by the team in the season")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 36)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Percentage of passes that were completed by the team in the season
        /// </summary>
        [Description("Percentage of passes that were completed by the team in the season")]
        [DataMember(Name = "CompletionPercentage", Order = 37)]
        public decimal CompletionPercentage { get; set; }

        /// <summary>
        /// The team's passer rating in the season
        /// </summary>
        [Description("The team's passer rating in the season")]
        [DataMember(Name = "PasserRating", Order = 38)]
        public decimal? PasserRating { get; set; }

        /// <summary>
        /// Total third down attempts by the team in the season
        /// </summary>
        [Description("Total third down attempts by the team in the season")]
        [DataMember(Name = "ThirdDownAttempts", Order = 39)]
        public int? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Total third down conversions by the team in the season
        /// </summary>
        [Description("Total third down conversions by the team in the season")]
        [DataMember(Name = "ThirdDownConversions", Order = 40)]
        public int? ThirdDownConversions { get; set; }

        /// <summary>
        /// Total percentage of third downs converted by the team in the season
        /// </summary>
        [Description("Total percentage of third downs converted by the team in the season")]
        [DataMember(Name = "ThirdDownPercentage", Order = 41)]
        public decimal? ThirdDownPercentage { get; set; }

        /// <summary>
        /// Total fourth down attempts by the team in the season
        /// </summary>
        [Description("Total fourth down attempts by the team in the season")]
        [DataMember(Name = "FourthDownAttempts", Order = 42)]
        public int? FourthDownAttempts { get; set; }

        /// <summary>
        /// Total fourth down conversions by the team in the season
        /// </summary>
        [Description("Total fourth down conversions by the team in the season")]
        [DataMember(Name = "FourthDownConversions", Order = 43)]
        public int? FourthDownConversions { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted by the team in the season
        /// </summary>
        [Description("Percentage of fourth downs converted by the team in the season")]
        [DataMember(Name = "FourthDownPercentage", Order = 44)]
        public decimal? FourthDownPercentage { get; set; }

        /// <summary>
        /// Total red zone opportunities by the team in the season
        /// </summary>
        [Description("Total red zone opportunities by the team in the season")]
        [DataMember(Name = "RedZoneAttempts", Order = 45)]
        public int? RedZoneAttempts { get; set; }

        /// <summary>
        /// Total red zone opportunities converted into touchdowns by the team in the season
        /// </summary>
        [Description("Total red zone opportunities converted into touchdowns by the team in the season")]
        [DataMember(Name = "RedZoneConversions", Order = 46)]
        public int? RedZoneConversions { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoAttempts", Order = 47)]
        public int? GoalToGoAttempts { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoConversions", Order = 48)]
        public int? GoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards by the team in the season
        /// </summary>
        [Description("Total punt and defensive return yards by the team in the season")]
        [DataMember(Name = "ReturnYards", Order = 49)]
        public int? ReturnYards { get; set; }

        /// <summary>
        /// Total penalties committed by the team in the season
        /// </summary>
        [Description("Total penalties committed by the team in the season")]
        [DataMember(Name = "Penalties", Order = 50)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the team
        /// </summary>
        [Description("Total penalty yards enforced against the team")]
        [DataMember(Name = "PenaltyYards", Order = 51)]
        public int? PenaltyYards { get; set; }

        /// <summary>
        /// Total fumbles by the team in the season
        /// </summary>
        [Description("Total fumbles by the team in the season")]
        [DataMember(Name = "Fumbles", Order = 52)]
        public int? Fumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the team in the season
        /// </summary>
        [Description("Total fumbles lost by the team in the season")]
        [DataMember(Name = "FumblesLost", Order = 53)]
        public int? FumblesLost { get; set; }

        /// <summary>
        /// Total number of sacks allowed by the team in the season
        /// </summary>
        [Description("Total number of sacks allowed by the team in the season")]
        [DataMember(Name = "TimesSacked", Order = 54)]
        public int? TimesSacked { get; set; }

        /// <summary>
        /// Total sack yards allowed by the team in the season
        /// </summary>
        [Description("Total sack yards allowed by the team in the season")]
        [DataMember(Name = "TimesSackedYards", Order = 55)]
        public int? TimesSackedYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the team in the season. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the team in the season. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 56)]
        public int? QuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the team in the season. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the team in the season. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 57)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the team in the season
        /// </summary>
        [Description("Total defensive safeties scored by the team in the season")]
        [DataMember(Name = "Safeties", Order = 58)]
        public int? Safeties { get; set; }

        /// <summary>
        /// Total number of punts by the team in the game
        /// </summary>
        [Description("Total number of punts by the team in the game")]
        [DataMember(Name = "Punts", Order = 59)]
        public int? Punts { get; set; }

        /// <summary>
        /// Total punt yards by the team in the season
        /// </summary>
        [Description("Total punt yards by the team in the season")]
        [DataMember(Name = "PuntYards", Order = 60)]
        public int? PuntYards { get; set; }

        /// <summary>
        /// The average number of yards per punt by the team in the season
        /// </summary>
        [Description("The average number of yards per punt by the team in the season")]
        [DataMember(Name = "PuntAverage", Order = 61)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Total number of giveaways by the team in the season
        /// </summary>
        [Description("Total number of giveaways by the team in the season")]
        [DataMember(Name = "Giveaways", Order = 62)]
        public int Giveaways { get; set; }

        /// <summary>
        /// Total takeaways by the team in the season
        /// </summary>
        [Description("Total takeaways by the team in the season")]
        [DataMember(Name = "Takeaways", Order = 63)]
        public int Takeaways { get; set; }

        /// <summary>
        /// Total turnover differential (takeaways minus giveaways) by the team in the season
        /// </summary>
        [Description("Total turnover differential (takeaways minus giveaways) by the team in the season")]
        [DataMember(Name = "TurnoverDifferential", Order = 64)]
        public int TurnoverDifferential { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the opponent teams in the season
        /// </summary>
        [Description("Points scored during Quarter 1 for the opponent teams in the season")]
        [DataMember(Name = "OpponentScoreQuarter1", Order = 65)]
        public int? OpponentScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the opponent teams in the season
        /// </summary>
        [Description("Points scored during Quarter 2 for the opponent teams in the season")]
        [DataMember(Name = "OpponentScoreQuarter2", Order = 66)]
        public int? OpponentScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the opponent teams in the season
        /// </summary>
        [Description("Points scored during Quarter 3 for the opponent teams in the season")]
        [DataMember(Name = "OpponentScoreQuarter3", Order = 67)]
        public int? OpponentScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the opponent teams in the season
        /// </summary>
        [Description("Points scored during Quarter 4 for the opponent teams in the season")]
        [DataMember(Name = "OpponentScoreQuarter4", Order = 68)]
        public int? OpponentScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during overtime for the opponent teams in the season
        /// </summary>
        [Description("Points scored during overtime for the opponent teams in the season")]
        [DataMember(Name = "OpponentScoreOvertime", Order = 69)]
        public int OpponentScoreOvertime { get; set; }

        /// <summary>
        /// Total average time of possession for the opponent teams in the season
        /// </summary>
        [Description("Total average time of possession for the opponent teams in the season")]
        [DataMember(Name = "OpponentTimeOfPossession", Order = 70)]
        public string OpponentTimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs converted the opponent teams in the season
        /// </summary>
        [Description("Total first downs converted the opponent teams in the season")]
        [DataMember(Name = "OpponentFirstDowns", Order = 71)]
        public int? OpponentFirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs by the opponent teams in the season
        /// </summary>
        [Description("Total rushing first downs by the opponent teams in the season")]
        [DataMember(Name = "OpponentFirstDownsByRushing", Order = 72)]
        public int? OpponentFirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs converted the opponent teams in the season
        /// </summary>
        [Description("Total passing first downs converted the opponent teams in the season")]
        [DataMember(Name = "OpponentFirstDownsByPassing", Order = 73)]
        public int? OpponentFirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by penalty for the opponent teams in the season
        /// </summary>
        [Description("Total first downs by penalty for the opponent teams in the season")]
        [DataMember(Name = "OpponentFirstDownsByPenalty", Order = 74)]
        public int? OpponentFirstDownsByPenalty { get; set; }

        /// <summary>
        /// Total offensive plays by the opponent teams in the season
        /// </summary>
        [Description("Total offensive plays by the opponent teams in the season")]
        [DataMember(Name = "OpponentOffensivePlays", Order = 75)]
        public int OpponentOffensivePlays { get; set; }

        /// <summary>
        /// Total offensive yards gained by the opponent teams in the season
        /// </summary>
        [Description("Total offensive yards gained by the opponent teams in the season")]
        [DataMember(Name = "OpponentOffensiveYards", Order = 76)]
        public int OpponentOffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play by the opponent teams in the season
        /// </summary>
        [Description("Average yards gained per offensive play by the opponent teams in the season")]
        [DataMember(Name = "OpponentOffensiveYardsPerPlay", Order = 77)]
        public decimal OpponentOffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Total touchdowns scored by the opponent teams in the season
        /// </summary>
        [Description("Total touchdowns scored by the opponent teams in the season")]
        [DataMember(Name = "OpponentTouchdowns", Order = 78)]
        public int? OpponentTouchdowns { get; set; }

        /// <summary>
        /// Total rushing attempts by the opponent teams in the season
        /// </summary>
        [Description("Total rushing attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentRushingAttempts", Order = 79)]
        public int? OpponentRushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the opponent teams in the season
        /// </summary>
        [Description("Total rushing yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentRushingYards", Order = 80)]
        public int? OpponentRushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt by the opponent teams in the season
        /// </summary>
        [Description("Average rushing yards gained per attempt by the opponent teams in the season")]
        [DataMember(Name = "OpponentRushingYardsPerAttempt", Order = 81)]
        public decimal OpponentRushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the opponent teams in the season
        /// </summary>
        [Description("Total rushing touchdowns by the opponent teams in the season")]
        [DataMember(Name = "OpponentRushingTouchdowns", Order = 82)]
        public int? OpponentRushingTouchdowns { get; set; }

        /// <summary>
        /// Total passes thrown by the opponent teams in the season
        /// </summary>
        [Description("Total passes thrown by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingAttempts", Order = 83)]
        public int? OpponentPassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions by the opponent teams in the season
        /// </summary>
        [Description("Total passing completions by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingCompletions", Order = 84)]
        public int? OpponentPassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the opponent teams in the season
        /// </summary>
        [Description("Total passing yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingYards", Order = 85)]
        public int? OpponentPassingYards { get; set; }

        /// <summary>
        /// Total passing touchdowns by the opponent teams in the season
        /// </summary>
        [Description("Total passing touchdowns by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingTouchdowns", Order = 86)]
        public int? OpponentPassingTouchdowns { get; set; }

        /// <summary>
        /// Total interception thrown by the opponent teams in the season
        /// </summary>
        [Description("Total interception thrown by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingInterceptions", Order = 87)]
        public int? OpponentPassingInterceptions { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt by the opponent teams in the season
        /// </summary>
        [Description("Average passing yards gained per attempt by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingYardsPerAttempt", Order = 88)]
        public decimal OpponentPassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion by the opponent teams in the season
        /// </summary>
        [Description("Average passing yards gained per completion by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingYardsPerCompletion", Order = 89)]
        public decimal OpponentPassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total completion percentage of the opponent teams in the season
        /// </summary>
        [Description("Total completion percentage of the opponent teams in the season")]
        [DataMember(Name = "OpponentCompletionPercentage", Order = 90)]
        public decimal OpponentCompletionPercentage { get; set; }

        /// <summary>
        /// Total passer rating by the opponent teams in the season
        /// </summary>
        [Description("Total passer rating by the opponent teams in the season")]
        [DataMember(Name = "OpponentPasserRating", Order = 91)]
        public decimal? OpponentPasserRating { get; set; }

        /// <summary>
        /// Total third down attempts by the opponent teams in the season
        /// </summary>
        [Description("Total third down attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentThirdDownAttempts", Order = 92)]
        public int? OpponentThirdDownAttempts { get; set; }

        /// <summary>
        /// Total third down conversions by the opponent teams in the season
        /// </summary>
        [Description("Total third down conversions by the opponent teams in the season")]
        [DataMember(Name = "OpponentThirdDownConversions", Order = 93)]
        public int? OpponentThirdDownConversions { get; set; }

        /// <summary>
        /// Total third down percentage by the opponent teams in the season
        /// </summary>
        [Description("Total third down percentage by the opponent teams in the season")]
        [DataMember(Name = "OpponentThirdDownPercentage", Order = 94)]
        public decimal? OpponentThirdDownPercentage { get; set; }

        /// <summary>
        /// Total fourth downs attempted by the opponent teams in the season
        /// </summary>
        [Description("Total fourth downs attempted by the opponent teams in the season")]
        [DataMember(Name = "OpponentFourthDownAttempts", Order = 95)]
        public int? OpponentFourthDownAttempts { get; set; }

        /// <summary>
        /// Total fourth downs converted by the opponent teams in the season
        /// </summary>
        [Description("Total fourth downs converted by the opponent teams in the season")]
        [DataMember(Name = "OpponentFourthDownConversions", Order = 96)]
        public int? OpponentFourthDownConversions { get; set; }

        /// <summary>
        /// Total fourth down conversion percentage by the opponent teams in the season
        /// </summary>
        [Description("Total fourth down conversion percentage by the opponent teams in the season")]
        [DataMember(Name = "OpponentFourthDownPercentage", Order = 97)]
        public decimal? OpponentFourthDownPercentage { get; set; }

        /// <summary>
        /// Total red zone opportunities by the opponents in the season
        /// </summary>
        [Description("Total red zone opportunities by the opponents in the season")]
        [DataMember(Name = "OpponentRedZoneAttempts", Order = 98)]
        public int? OpponentRedZoneAttempts { get; set; }

        /// <summary>
        /// Total red zone opportunities converted to touchdowns by the opponents in the season
        /// </summary>
        [Description("Total red zone opportunities converted to touchdowns by the opponents in the season")]
        [DataMember(Name = "OpponentRedZoneConversions", Order = 99)]
        public int? OpponentRedZoneConversions { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoAttempts", Order = 100)]
        public int? OpponentGoalToGoAttempts { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoConversions", Order = 101)]
        public int? OpponentGoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards by the opponent teams in the season
        /// </summary>
        [Description("Total punt and defensive return yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentReturnYards", Order = 102)]
        public int? OpponentReturnYards { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the opponent teams in the season
        /// </summary>
        [Description("Total penalty yards enforced against the opponent teams in the season")]
        [DataMember(Name = "OpponentPenalties", Order = 103)]
        public int? OpponentPenalties { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the opponent teams in the season
        /// </summary>
        [Description("Total penalty yards enforced against the opponent teams in the season")]
        [DataMember(Name = "OpponentPenaltyYards", Order = 104)]
        public int? OpponentPenaltyYards { get; set; }

        /// <summary>
        /// Total offensive fumbles by the opponent teams in the season
        /// </summary>
        [Description("Total offensive fumbles by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumbles", Order = 105)]
        public int? OpponentFumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the opponent teams in the season
        /// </summary>
        [Description("Total fumbles lost by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumblesLost", Order = 106)]
        public int? OpponentFumblesLost { get; set; }

        /// <summary>
        /// Total sacks allowed by the opponent teams in the season
        /// </summary>
        [Description("Total sacks allowed by the opponent teams in the season")]
        [DataMember(Name = "OpponentTimesSacked", Order = 107)]
        public int? OpponentTimesSacked { get; set; }

        /// <summary>
        /// Total yards as a result of a sack allowed by the opponent teams in the season
        /// </summary>
        [Description("Total yards as a result of a sack allowed by the opponent teams in the season")]
        [DataMember(Name = "OpponentTimesSackedYards", Order = 108)]
        public int? OpponentTimesSackedYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the opponent teams in the season
        /// </summary>
        [Description("Total quarterback hits by the opponent teams in the season")]
        [DataMember(Name = "OpponentQuarterbackHits", Order = 109)]
        public int? OpponentQuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the opponent teams in the season
        /// </summary>
        [Description("Total tackles for loss by the opponent teams in the season")]
        [DataMember(Name = "OpponentTacklesForLoss", Order = 110)]
        public int? OpponentTacklesForLoss { get; set; }

        /// <summary>
        /// Total safeties recorded by the opponent teams in the season
        /// </summary>
        [Description("Total safeties recorded by the opponent teams in the season")]
        [DataMember(Name = "OpponentSafeties", Order = 111)]
        public int? OpponentSafeties { get; set; }

        /// <summary>
        /// Total punts by the opponent teams in the season
        /// </summary>
        [Description("Total punts by the opponent teams in the season")]
        [DataMember(Name = "OpponentPunts", Order = 112)]
        public int? OpponentPunts { get; set; }

        /// <summary>
        /// Total punt yards by the opponent teams in the season
        /// </summary>
        [Description("Total punt yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntYards", Order = 113)]
        public int? OpponentPuntYards { get; set; }

        /// <summary>
        /// Average number of yards per punt by the opponent team in the season
        /// </summary>
        [Description("Average number of yards per punt by the opponent team in the season")]
        [DataMember(Name = "OpponentPuntAverage", Order = 114)]
        public decimal OpponentPuntAverage { get; set; }

        /// <summary>
        /// Total giveaways by the opponent teams in the season
        /// </summary>
        [Description("Total giveaways by the opponent teams in the season")]
        [DataMember(Name = "OpponentGiveaways", Order = 115)]
        public int OpponentGiveaways { get; set; }

        /// <summary>
        /// Total takeaways by the opponent teams in the season
        /// </summary>
        [Description("Total takeaways by the opponent teams in the season")]
        [DataMember(Name = "OpponentTakeaways", Order = 116)]
        public int OpponentTakeaways { get; set; }

        /// <summary>
        /// Total turnover differential by the opponent teams in the season (takeaways minus giveaways)
        /// </summary>
        [Description("Total turnover differential by the opponent teams in the season (takeaways minus giveaways)")]
        [DataMember(Name = "OpponentTurnoverDifferential", Order = 117)]
        public int OpponentTurnoverDifferential { get; set; }

        /// <summary>
        /// Total percentage of red zone opportunities converted into touchdowns by the team in the season
        /// </summary>
        [Description("Total percentage of red zone opportunities converted into touchdowns by the team in the season")]
        [DataMember(Name = "RedZonePercentage", Order = 118)]
        public decimal? RedZonePercentage { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoPercentage", Order = 119)]
        public decimal? GoalToGoPercentage { get; set; }

        /// <summary>
        /// The quarterback hits differential of the team in the season. Note: Determined by hits on opposing quarterback minus hits on own quarterback
        /// </summary>
        [Description("The quarterback hits differential of the team in the season. Note: Determined by hits on opposing quarterback minus hits on own quarterback")]
        [DataMember(Name = "QuarterbackHitsDifferential", Order = 120)]
        public int? QuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// Total tackles for loss differential by the team in the season
        /// </summary>
        [Description("Total tackles for loss differential by the team in the season")]
        [DataMember(Name = "TacklesForLossDifferential", Order = 121)]
        public int? TacklesForLossDifferential { get; set; }

        /// <summary>
        /// Total sack differential of the team in the season
        /// </summary>
        [Description("Total sack differential of the team in the season")]
        [DataMember(Name = "QuarterbackSacksDifferential", Order = 122)]
        public int QuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Total percentage of plays defended that resulted in a tackle for loss by the team in the season
        /// </summary>
        [Description("Total percentage of plays defended that resulted in a tackle for loss by the team in the season")]
        [DataMember(Name = "TacklesForLossPercentage", Order = 123)]
        public decimal? TacklesForLossPercentage { get; set; }

        /// <summary>
        /// Total percentage of opposing quarterback dropbacks that resulted in a quarterback hit by the team in the season
        /// </summary>
        [Description("Total percentage of opposing quarterback dropbacks that resulted in a quarterback hit by the team in the season")]
        [DataMember(Name = "QuarterbackHitsPercentage", Order = 124)]
        public decimal? QuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Total percentage of drop backs that resulted in a sack by the team in the season
        /// </summary>
        [Description("Total percentage of drop backs that resulted in a sack by the team in the season")]
        [DataMember(Name = "TimesSackedPercentage", Order = 125)]
        public decimal TimesSackedPercentage { get; set; }

        /// <summary>
        /// Percentage of opponent's red zone opportunities converted into touchdowns in the season
        /// </summary>
        [Description("Percentage of opponent's red zone opportunities converted into touchdowns in the season")]
        [DataMember(Name = "OpponentRedZonePercentage", Order = 126)]
        public decimal? OpponentRedZonePercentage { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoPercentage", Order = 127)]
        public decimal? OpponentGoalToGoPercentage { get; set; }

        /// <summary>
        /// Total quarterback hits differential by the opponent teams in the season
        /// </summary>
        [Description("Total quarterback hits differential by the opponent teams in the season")]
        [DataMember(Name = "OpponentQuarterbackHitsDifferential", Order = 128)]
        public int? OpponentQuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// Total tackles for loss differential by the opponent teams in the season
        /// </summary>
        [Description("Total tackles for loss differential by the opponent teams in the season")]
        [DataMember(Name = "OpponentTacklesForLossDifferential", Order = 129)]
        public int? OpponentTacklesForLossDifferential { get; set; }

        /// <summary>
        /// Total quarterback sacks differential by the opponent teams in the season
        /// </summary>
        [Description("Total quarterback sacks differential by the opponent teams in the season")]
        [DataMember(Name = "OpponentQuarterbackSacksDifferential", Order = 130)]
        public int? OpponentQuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Total percentage of tackles for loss by the opponent teams in the season
        /// </summary>
        [Description("Total percentage of tackles for loss by the opponent teams in the season")]
        [DataMember(Name = "OpponentTacklesForLossPercentage", Order = 131)]
        public decimal? OpponentTacklesForLossPercentage { get; set; }

        /// <summary>
        /// Percentage of own team's quarterback drop backs that resulted in our quarterback getting hit
        /// </summary>
        [Description("Percentage of own team's quarterback drop backs that resulted in our quarterback getting hit")]
        [DataMember(Name = "OpponentQuarterbackHitsPercentage", Order = 132)]
        public decimal? OpponentQuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Total percentage of dropbacks that resulted in a sack allowed by the opponent teams in the season
        /// </summary>
        [Description("Total percentage of dropbacks that resulted in a sack allowed by the opponent teams in the season")]
        [DataMember(Name = "OpponentTimesSackedPercentage", Order = 133)]
        public decimal OpponentTimesSackedPercentage { get; set; }

        /// <summary>
        /// Total number of kickoffs by the team in the season
        /// </summary>
        [Description("Total number of kickoffs by the team in the season")]
        [DataMember(Name = "Kickoffs", Order = 134)]
        public int? Kickoffs { get; set; }

        /// <summary>
        /// Total kickoffs that went into the end zone by the team in the season
        /// </summary>
        [Description("Total kickoffs that went into the end zone by the team in the season")]
        [DataMember(Name = "KickoffsInEndZone", Order = 135)]
        public int? KickoffsInEndZone { get; set; }

        /// <summary>
        /// Total kickoffs that resulted in touchbacks by the team in the season
        /// </summary>
        [Description("Total kickoffs that resulted in touchbacks by the team in the season")]
        [DataMember(Name = "KickoffTouchbacks", Order = 136)]
        public int? KickoffTouchbacks { get; set; }

        /// <summary>
        /// Total punts by the team that were blocked in the season
        /// </summary>
        [Description("Total punts by the team that were blocked in the season")]
        [DataMember(Name = "PuntsHadBlocked", Order = 137)]
        public int? PuntsHadBlocked { get; set; }

        /// <summary>
        /// The average net yards per punt by the team in the season
        /// </summary>
        [Description("The average net yards per punt by the team in the season")]
        [DataMember(Name = "PuntNetAverage", Order = 138)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the team in the season
        /// </summary>
        [Description("Total extra point kick attempts by the team in the season")]
        [DataMember(Name = "ExtraPointKickingAttempts", Order = 139)]
        public int? ExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Total extra point kicks made by the team in the season
        /// </summary>
        [Description("Total extra point kicks made by the team in the season")]
        [DataMember(Name = "ExtraPointKickingConversions", Order = 140)]
        public int? ExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the team that were blocked in the season
        /// </summary>
        [Description("Total extra point kick attempts by the team that were blocked in the season")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 141)]
        public int? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Total two point conversion passing attempts by the team in the season
        /// </summary>
        [Description("Total two point conversion passing attempts by the team in the season")]
        [DataMember(Name = "ExtraPointPassingAttempts", Order = 142)]
        public int? ExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion passing conversions by the team in the season
        /// </summary>
        [Description("Total two point conversion passing conversions by the team in the season")]
        [DataMember(Name = "ExtraPointPassingConversions", Order = 143)]
        public int? ExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Total two point conversion rushing attempts by the team in the season
        /// </summary>
        [Description("Total two point conversion rushing attempts by the team in the season")]
        [DataMember(Name = "ExtraPointRushingAttempts", Order = 144)]
        public int? ExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion rushing conversions in the season
        /// </summary>
        [Description("Total two point conversion rushing conversions in the season")]
        [DataMember(Name = "ExtraPointRushingConversions", Order = 145)]
        public int? ExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Total field goal attempts by the team in the season
        /// </summary>
        [Description("Total field goal attempts by the team in the season")]
        [DataMember(Name = "FieldGoalAttempts", Order = 146)]
        public int? FieldGoalAttempts { get; set; }

        /// <summary>
        /// Total field goals made by the team in season
        /// </summary>
        [Description("Total field goals made by the team in season")]
        [DataMember(Name = "FieldGoalsMade", Order = 147)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goals by the team that were blocked in the season
        /// </summary>
        [Description("Total field goals by the team that were blocked in the season")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 148)]
        public int? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punt returns by the team in the season
        /// </summary>
        [Description("Total punt returns by the team in the season")]
        [DataMember(Name = "PuntReturns", Order = 149)]
        public int? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the team in the season
        /// </summary>
        [Description("Total punt return yards by the team in the season")]
        [DataMember(Name = "PuntReturnYards", Order = 150)]
        public int? PuntReturnYards { get; set; }

        /// <summary>
        /// Total kickoff returns by the team in the season
        /// </summary>
        [Description("Total kickoff returns by the team in the season")]
        [DataMember(Name = "KickReturns", Order = 151)]
        public int? KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the team in the season
        /// </summary>
        [Description("Total kickoff return yards by the team in the season")]
        [DataMember(Name = "KickReturnYards", Order = 152)]
        public int? KickReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception returns by the team in the season
        /// </summary>
        [Description("Total defensive interception returns by the team in the season")]
        [DataMember(Name = "InterceptionReturns", Order = 153)]
        public int? InterceptionReturns { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the team in the season
        /// </summary>
        [Description("Total defensive interception return yards by the team in the season")]
        [DataMember(Name = "InterceptionReturnYards", Order = 154)]
        public int? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total kickoffs by the opponent teams in the season
        /// </summary>
        [Description("Total kickoffs by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickoffs", Order = 155)]
        public int? OpponentKickoffs { get; set; }

        /// <summary>
        /// Total kickoffs that went into the end zone by the opponent teams in the season
        /// </summary>
        [Description("Total kickoffs that went into the end zone by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickoffsInEndZone", Order = 156)]
        public int? OpponentKickoffsInEndZone { get; set; }

        /// <summary>
        /// Total kickoffs that resulted in touchbacks by the opponent teams in the season
        /// </summary>
        [Description("Total kickoffs that resulted in touchbacks by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickoffTouchbacks", Order = 157)]
        public int? OpponentKickoffTouchbacks { get; set; }

        /// <summary>
        /// Total punt yard that were blocked for the opponent teams in the season
        /// </summary>
        [Description("Total punt yard that were blocked for the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntsHadBlocked", Order = 158)]
        public int? OpponentPuntsHadBlocked { get; set; }

        /// <summary>
        /// Average net punt yards by the opponent team in the season
        /// </summary>
        [Description("Average net punt yards by the opponent team in the season")]
        [DataMember(Name = "OpponentPuntNetAverage", Order = 159)]
        public decimal? OpponentPuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the opponent teams in the season
        /// </summary>
        [Description("Total extra point kick attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointKickingAttempts", Order = 160)]
        public int? OpponentExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Total extra point kicks made by the opponent teams in the season
        /// </summary>
        [Description("Total extra point kicks made by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointKickingConversions", Order = 161)]
        public int? OpponentExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Total extra point kick attempts that were blocked against the opponent teams in the season
        /// </summary>
        [Description("Total extra point kick attempts that were blocked against the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointsHadBlocked", Order = 162)]
        public int? OpponentExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Total two point conversion passing attempts by the opponent teams in the season
        /// </summary>
        [Description("Total two point conversion passing attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointPassingAttempts", Order = 163)]
        public int? OpponentExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion passing conversions by the opponent teams in the season
        /// </summary>
        [Description("Total two point conversion passing conversions by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointPassingConversions", Order = 164)]
        public int? OpponentExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Total two point conversion rushing attempts by the opponent teams in the season
        /// </summary>
        [Description("Total two point conversion rushing attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointRushingAttempts", Order = 165)]
        public int? OpponentExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion rushing conversions by the opponent teams in the season
        /// </summary>
        [Description("Total two point conversion rushing conversions by the opponent teams in the season")]
        [DataMember(Name = "OpponentExtraPointRushingConversions", Order = 166)]
        public int? OpponentExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Total field goal attempts by the opponent teams in the season
        /// </summary>
        [Description("Total field goal attempts by the opponent teams in the season")]
        [DataMember(Name = "OpponentFieldGoalAttempts", Order = 167)]
        public int? OpponentFieldGoalAttempts { get; set; }

        /// <summary>
        /// Total field goals made the opponent teams in the season
        /// </summary>
        [Description("Total field goals made the opponent teams in the season")]
        [DataMember(Name = "OpponentFieldGoalsMade", Order = 168)]
        public int? OpponentFieldGoalsMade { get; set; }

        /// <summary>
        /// Total blocked field goals against the opponent teams in the season
        /// </summary>
        [Description("Total blocked field goals against the opponent teams in the season")]
        [DataMember(Name = "OpponentFieldGoalsHadBlocked", Order = 169)]
        public int? OpponentFieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punt returns by the opponent teams in the season
        /// </summary>
        [Description("Total punt returns by the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntReturns", Order = 170)]
        public int? OpponentPuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards the opponent teams in the season
        /// </summary>
        [Description("Total punt return yards the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntReturnYards", Order = 171)]
        public int? OpponentPuntReturnYards { get; set; }

        /// <summary>
        /// Total kickoff returns by the opponent teams in the season
        /// </summary>
        [Description("Total kickoff returns by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickReturns", Order = 172)]
        public int? OpponentKickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the opponent teams in the season
        /// </summary>
        [Description("Total kickoff return yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickReturnYards", Order = 173)]
        public int? OpponentKickReturnYards { get; set; }

        /// <summary>
        /// Total defensive interceptions by the opponent teams in the seasons
        /// </summary>
        [Description("Total defensive interceptions by the opponent teams in the seasons")]
        [DataMember(Name = "OpponentInterceptionReturns", Order = 174)]
        public int? OpponentInterceptionReturns { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the opponent teams in the seasons
        /// </summary>
        [Description("Total defensive interception return yards by the opponent teams in the seasons")]
        [DataMember(Name = "OpponentInterceptionReturnYards", Order = 175)]
        public int? OpponentInterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the team in the season
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the team in the season")]
        [DataMember(Name = "SoloTackles", Order = 176)]
        public int? SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the team in the season
        /// </summary>
        [Description("Total defensive assisted tackles by the team in the season")]
        [DataMember(Name = "AssistedTackles", Order = 177)]
        public int? AssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the team in the season
        /// </summary>
        [Description("Total defensive sacks by the team in the season")]
        [DataMember(Name = "Sacks", Order = 178)]
        public int? Sacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the team in the season
        /// </summary>
        [Description("Total defensive sack yards by the team in the season")]
        [DataMember(Name = "SackYards", Order = 179)]
        public int? SackYards { get; set; }

        /// <summary>
        /// Total passes defended by the team's defense in the season
        /// </summary>
        [Description("Total passes defended by the team's defense in the season")]
        [DataMember(Name = "PassesDefended", Order = 180)]
        public int? PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the team in the season
        /// </summary>
        [Description("Total fumbles forced on defense by the team in the season")]
        [DataMember(Name = "FumblesForced", Order = 181)]
        public int? FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the team in the season
        /// </summary>
        [Description("Total defensive fumble recoveries by the team in the season")]
        [DataMember(Name = "FumblesRecovered", Order = 182)]
        public int? FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the team in the season
        /// </summary>
        [Description("Total fumble return yards by the team in the season")]
        [DataMember(Name = "FumbleReturnYards", Order = 183)]
        public int? FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the team in the season
        /// </summary>
        [Description("Total fumble return touchdowns by the team in the season")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 184)]
        public int? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the team in the season
        /// </summary>
        [Description("Total defensive interception return touchdowns by the team in the season")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 185)]
        public int? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by the team in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by the team in the season. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 186)]
        public int? BlockedKicks { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the team in the season
        /// </summary>
        [Description("Total punt return touchdowns by the team in the season")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 187)]
        public int? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the team in the season
        /// </summary>
        [Description("The longest punt return by the team in the season")]
        [DataMember(Name = "PuntReturnLong", Order = 188)]
        public int? PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the team in the season
        /// </summary>
        [Description("Total kickoff return touchdowns by the team in the season")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 189)]
        public int? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the team in the season
        /// </summary>
        [Description("Longest kick return by the team in the season")]
        [DataMember(Name = "KickReturnLong", Order = 190)]
        public int? KickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the team in the season
        /// </summary>
        [Description("Total blocked kick recovery return yards for the team in the season")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 191)]
        public int? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the team in the season
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the team in the season")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 192)]
        public int? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return yards by the team in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the team in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 193)]
        public int? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the team in the season. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the team in the season. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 194)]
        public int? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// The net yards of the punts by the team in the season
        /// </summary>
        [Description("The net yards of the punts by the team in the season")]
        [DataMember(Name = "PuntNetYards", Order = 195)]
        public int? PuntNetYards { get; set; }

        /// <summary>
        /// Total defensive solo tackles by the opponent teams in the season
        /// </summary>
        [Description("Total defensive solo tackles by the opponent teams in the season")]
        [DataMember(Name = "OpponentSoloTackles", Order = 196)]
        public int? OpponentSoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the opponent teams in the season
        /// </summary>
        [Description("Total defensive assisted tackles by the opponent teams in the season")]
        [DataMember(Name = "OpponentAssistedTackles", Order = 197)]
        public int? OpponentAssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the opponent teams in the season
        /// </summary>
        [Description("Total defensive sacks by the opponent teams in the season")]
        [DataMember(Name = "OpponentSacks", Order = 198)]
        public int? OpponentSacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the opponent teams in the season
        /// </summary>
        [Description("Total defensive sack yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentSackYards", Order = 199)]
        public int? OpponentSackYards { get; set; }

        /// <summary>
        /// Total passes defended by the opponent teams in the season
        /// </summary>
        [Description("Total passes defended by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassesDefended", Order = 200)]
        public int? OpponentPassesDefended { get; set; }

        /// <summary>
        /// Total defensive fumbles forced by the opponent teams in the season
        /// </summary>
        [Description("Total defensive fumbles forced by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumblesForced", Order = 201)]
        public int? OpponentFumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the opponent teams in the season
        /// </summary>
        [Description("Total defensive fumble recoveries by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumblesRecovered", Order = 202)]
        public int? OpponentFumblesRecovered { get; set; }

        /// <summary>
        /// Total defensive fumbles return yards by the opponent teams in the season
        /// </summary>
        [Description("Total defensive fumbles return yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumbleReturnYards", Order = 203)]
        public int? OpponentFumbleReturnYards { get; set; }

        /// <summary>
        /// Total defensive fumbles return touchdowns by the opponent teams in the season
        /// </summary>
        [Description("Total defensive fumbles return touchdowns by the opponent teams in the season")]
        [DataMember(Name = "OpponentFumbleReturnTouchdowns", Order = 204)]
        public int? OpponentFumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interception touchdowns by the opponent teams in the seasons
        /// </summary>
        [Description("Total defensive interception touchdowns by the opponent teams in the seasons")]
        [DataMember(Name = "OpponentInterceptionReturnTouchdowns", Order = 205)]
        public int? OpponentInterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks against the opponent teams in the season
        /// </summary>
        [Description("Total blocked kicks against the opponent teams in the season")]
        [DataMember(Name = "OpponentBlockedKicks", Order = 206)]
        public int? OpponentBlockedKicks { get; set; }

        /// <summary>
        /// Total punt return touchdowns the opponent teams in the season
        /// </summary>
        [Description("Total punt return touchdowns the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntReturnTouchdowns", Order = 207)]
        public int? OpponentPuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return by the opponent teams in the season
        /// </summary>
        [Description("Longest punt return by the opponent teams in the season")]
        [DataMember(Name = "OpponentPuntReturnLong", Order = 208)]
        public int? OpponentPuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the opponent teams in the season
        /// </summary>
        [Description("Total kickoff return touchdowns by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickReturnTouchdowns", Order = 209)]
        public int? OpponentKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the opponent teams in the season
        /// </summary>
        [Description("Longest kick return by the opponent teams in the season")]
        [DataMember(Name = "OpponentKickReturnLong", Order = 210)]
        public int? OpponentKickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick return yards by the opponent teams in the season
        /// </summary>
        [Description("Total blocked kick return yards by the opponent teams in the season")]
        [DataMember(Name = "OpponentBlockedKickReturnYards", Order = 211)]
        public int? OpponentBlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total blocked kick return touchdowns by the opponent teams in the season
        /// </summary>
        [Description("Total blocked kick return touchdowns by the opponent teams in the season")]
        [DataMember(Name = "OpponentBlockedKickReturnTouchdowns", Order = 212)]
        public int? OpponentBlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return yards by the opponent teams in the season. Note: Excludes blocked field goals (only for straight misses that are returned)
        /// </summary>
        [Description("Total field goal return yards by the opponent teams in the season. Note: Excludes blocked field goals (only for straight misses that are returned)")]
        [DataMember(Name = "OpponentFieldGoalReturnYards", Order = 213)]
        public int? OpponentFieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the opponent teams in the season. Note: Excludes blocked field goals (only for straight misses that are returned)
        /// </summary>
        [Description("Total field goal return touchdowns by the opponent teams in the season. Note: Excludes blocked field goals (only for straight misses that are returned)")]
        [DataMember(Name = "OpponentFieldGoalReturnTouchdowns", Order = 214)]
        public int? OpponentFieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// Total net punt yards by the opponent team in the season
        /// </summary>
        [Description("Total net punt yards by the opponent team in the season")]
        [DataMember(Name = "OpponentPuntNetYards", Order = 215)]
        public int? OpponentPuntNetYards { get; set; }

        /// <summary>
        /// The full name of the team (e.g. New England Patriots; Los Angeles Chargers)
        /// </summary>
        [Description("The full name of the team (e.g. New England Patriots; Los Angeles Chargers)")]
        [DataMember(Name = "TeamName", Order = 216)]
        public string TeamName { get; set; }

        /// <summary>
        /// The total number of games played by the team in the season
        /// </summary>
        [Description("The total number of games played by the team in the season")]
        [DataMember(Name = "Games", Order = 217)]
        public int? Games { get; set; }

        /// <summary>
        /// Total number of times the team dropped back to pass in the season
        /// </summary>
        [Description("Total number of times the team dropped back to pass in the season")]
        [DataMember(Name = "PassingDropbacks", Order = 218)]
        public int? PassingDropbacks { get; set; }

        /// <summary>
        /// Total passing dropbacks by the opponent teams in the season
        /// </summary>
        [Description("Total passing dropbacks by the opponent teams in the season")]
        [DataMember(Name = "OpponentPassingDropbacks", Order = 219)]
        public int? OpponentPassingDropbacks { get; set; }

        /// <summary>
        /// The unique identifier for this TeamSeason record (subject to change; although it very rarely does). For a static ID; use a combination of SeasonType; Season and Team.
        /// </summary>
        [Description("The unique identifier for this TeamSeason record (subject to change; although it very rarely does). For a static ID; use a combination of SeasonType; Season and Team.")]
        [DataMember(Name = "TeamSeasonID", Order = 220)]
        public int TeamSeasonID { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the team in the season
        /// </summary>
        [Description("Total successful two point conversion returns by the team in the season")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 221)]
        public int? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Total two point attempt returns converted by the defense for the opponent teams in the season
        /// </summary>
        [Description("Total two point attempt returns converted by the defense for the opponent teams in the season")]
        [DataMember(Name = "OpponentTwoPointConversionReturns", Order = 222)]
        public int? OpponentTwoPointConversionReturns { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 223)]
        public int? TeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 224)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Unique ID of this TeamStatID record.
        /// </summary>
        [Description("Unique ID of this TeamStatID record.")]
        [DataMember(Name = "TeamStatID", Order = 225)]
        public int TeamStatID { get; set; }

    }
}

