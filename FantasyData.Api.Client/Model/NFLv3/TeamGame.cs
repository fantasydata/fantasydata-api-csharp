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
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 2)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this team corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). For seasons prior to 2021 there will be 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). For seasons prior to 2021 there will be 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 5)]
        public int? Week { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the opponent team
        /// </summary>
        [Description("The abbreviation [Key] of the opponent team")]
        [DataMember(Name = "Opponent", Order = 7)]
        public string Opponent { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 8)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// The final score of the team in the game
        /// </summary>
        [Description("The final score of the team in the game")]
        [DataMember(Name = "Score", Order = 9)]
        public int Score { get; set; }

        /// <summary>
        /// The final score of the opponent team in the game
        /// </summary>
        [Description("The final score of the opponent team in the game")]
        [DataMember(Name = "OpponentScore", Order = 10)]
        public int OpponentScore { get; set; }

        /// <summary>
        /// The total points scored by both teams in the game
        /// </summary>
        [Description("The total points scored by both teams in the game")]
        [DataMember(Name = "TotalScore", Order = 11)]
        public int TotalScore { get; set; }

        /// <summary>
        /// Stadium of the event
        /// </summary>
        [Description("Stadium of the event")]
        [DataMember(Name = "Stadium", Order = 12)]
        public string Stadium { get; set; }

        /// <summary>
        /// The playing surface of the stadium
        /// </summary>
        [Description("The playing surface of the stadium")]
        [DataMember(Name = "PlayingSurface", Order = 13)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// Temperature at game start (Fahrenheit)
        /// </summary>
        [Description("Temperature at game start (Fahrenheit)")]
        [DataMember(Name = "Temperature", Order = 14)]
        public int? Temperature { get; set; }

        /// <summary>
        /// The humidity percentage at the start of the game
        /// </summary>
        [Description("The humidity percentage at the start of the game")]
        [DataMember(Name = "Humidity", Order = 15)]
        public int? Humidity { get; set; }

        /// <summary>
        /// The wind speed at the start of the game (in MPH)
        /// </summary>
        [Description("The wind speed at the start of the game (in MPH)")]
        [DataMember(Name = "WindSpeed", Order = 16)]
        public int? WindSpeed { get; set; }

        /// <summary>
        /// The total points line (over/under) for the team in the game
        /// </summary>
        [Description("The total points line (over/under) for the team in the game")]
        [DataMember(Name = "OverUnder", Order = 17)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The oddsmaker point spread at game start from the perspective of the team (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker point spread at game start from the perspective of the team (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 18)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the team in the game
        /// </summary>
        [Description("Points scored during Quarter 1 for the team in the game")]
        [DataMember(Name = "ScoreQuarter1", Order = 19)]
        public int? ScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the team in the game
        /// </summary>
        [Description("Points scored during Quarter 2 for the team in the game")]
        [DataMember(Name = "ScoreQuarter2", Order = 20)]
        public int? ScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the team in the game
        /// </summary>
        [Description("Points scored during Quarter 3 for the team in the game")]
        [DataMember(Name = "ScoreQuarter3", Order = 21)]
        public int? ScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the team in the game
        /// </summary>
        [Description("Points scored during Quarter 4 for the team in the game")]
        [DataMember(Name = "ScoreQuarter4", Order = 22)]
        public int? ScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during overtime for the team in the game
        /// </summary>
        [Description("Points scored during overtime for the team in the game")]
        [DataMember(Name = "ScoreOvertime", Order = 23)]
        public int ScoreOvertime { get; set; }

        /// <summary>
        /// Total time of possession (minutes) by the team in the game
        /// </summary>
        [Description("Total time of possession (minutes) by the team in the game")]
        [DataMember(Name = "TimeOfPossessionMinutes", Order = 24)]
        public int? TimeOfPossessionMinutes { get; set; }

        /// <summary>
        /// Total time of possession (seconds) by the team in the game
        /// </summary>
        [Description("Total time of possession (seconds) by the team in the game")]
        [DataMember(Name = "TimeOfPossessionSeconds", Order = 25)]
        public int? TimeOfPossessionSeconds { get; set; }

        /// <summary>
        /// Total time of possession by the team in the game
        /// </summary>
        [Description("Total time of possession by the team in the game")]
        [DataMember(Name = "TimeOfPossession", Order = 26)]
        public string TimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs by the team in the game
        /// </summary>
        [Description("Total first downs by the team in the game")]
        [DataMember(Name = "FirstDowns", Order = 27)]
        public int? FirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs by the team in the game
        /// </summary>
        [Description("Total rushing first downs by the team in the game")]
        [DataMember(Name = "FirstDownsByRushing", Order = 28)]
        public int? FirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs by the team in the game
        /// </summary>
        [Description("Total passing first downs by the team in the game")]
        [DataMember(Name = "FirstDownsByPassing", Order = 29)]
        public int? FirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by opponent's penalty by the team in the game
        /// </summary>
        [Description("Total first downs by opponent's penalty by the team in the game")]
        [DataMember(Name = "FirstDownsByPenalty", Order = 30)]
        public int? FirstDownsByPenalty { get; set; }

        /// <summary>
        /// Number of offensive plays run by the team in the game
        /// </summary>
        [Description("Number of offensive plays run by the team in the game")]
        [DataMember(Name = "OffensivePlays", Order = 31)]
        public int OffensivePlays { get; set; }

        /// <summary>
        /// Total offensive yards gained by the team in the game
        /// </summary>
        [Description("Total offensive yards gained by the team in the game")]
        [DataMember(Name = "OffensiveYards", Order = 32)]
        public int OffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play by the team in the game
        /// </summary>
        [Description("Average yards gained per offensive play by the team in the game")]
        [DataMember(Name = "OffensiveYardsPerPlay", Order = 33)]
        public decimal OffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Total touchdowns scored by the team in the game
        /// </summary>
        [Description("Total touchdowns scored by the team in the game")]
        [DataMember(Name = "Touchdowns", Order = 34)]
        public int? Touchdowns { get; set; }

        /// <summary>
        /// Total rushing attempts by the team in the game
        /// </summary>
        [Description("Total rushing attempts by the team in the game")]
        [DataMember(Name = "RushingAttempts", Order = 35)]
        public int? RushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the team in the game
        /// </summary>
        [Description("Total rushing yards by the team in the game")]
        [DataMember(Name = "RushingYards", Order = 36)]
        public int? RushingYards { get; set; }

        /// <summary>
        /// Total rushing yards per attempt by the team in the game
        /// </summary>
        [Description("Total rushing yards per attempt by the team in the game")]
        [DataMember(Name = "RushingYardsPerAttempt", Order = 37)]
        public decimal RushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the team in the game
        /// </summary>
        [Description("Total rushing touchdowns by the team in the game")]
        [DataMember(Name = "RushingTouchdowns", Order = 38)]
        public int? RushingTouchdowns { get; set; }

        /// <summary>
        /// Total passes thrown by the team in the game
        /// </summary>
        [Description("Total passes thrown by the team in the game")]
        [DataMember(Name = "PassingAttempts", Order = 39)]
        public int? PassingAttempts { get; set; }

        /// <summary>
        /// Total passes completed by the team in the game
        /// </summary>
        [Description("Total passes completed by the team in the game")]
        [DataMember(Name = "PassingCompletions", Order = 40)]
        public int? PassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the team in the game
        /// </summary>
        [Description("Total passing yards by the team in the game")]
        [DataMember(Name = "PassingYards", Order = 41)]
        public int? PassingYards { get; set; }

        /// <summary>
        /// Total passing touchdowns by the team in the game
        /// </summary>
        [Description("Total passing touchdowns by the team in the game")]
        [DataMember(Name = "PassingTouchdowns", Order = 42)]
        public int? PassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the team in the game
        /// </summary>
        [Description("Total interceptions thrown by the team in the game")]
        [DataMember(Name = "PassingInterceptions", Order = 43)]
        public int? PassingInterceptions { get; set; }

        /// <summary>
        /// Total average passing yards per attempt by the team in the game
        /// </summary>
        [Description("Total average passing yards per attempt by the team in the game")]
        [DataMember(Name = "PassingYardsPerAttempt", Order = 44)]
        public decimal PassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total average passing yards per completion by the team in the game
        /// </summary>
        [Description("Total average passing yards per completion by the team in the game")]
        [DataMember(Name = "PassingYardsPerCompletion", Order = 45)]
        public decimal PassingYardsPerCompletion { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "CompletionPercentage", Order = 46)]
        public decimal CompletionPercentage { get; set; }

        /// <summary>
        /// The team's passer rating in the game
        /// </summary>
        [Description("The team's passer rating in the game")]
        [DataMember(Name = "PasserRating", Order = 47)]
        public decimal? PasserRating { get; set; }

        /// <summary>
        /// Total third down attempts by the team in the game
        /// </summary>
        [Description("Total third down attempts by the team in the game")]
        [DataMember(Name = "ThirdDownAttempts", Order = 48)]
        public int? ThirdDownAttempts { get; set; }

        /// <summary>
        /// Total percentage of third downs converted by the team in the game
        /// </summary>
        [Description("Total percentage of third downs converted by the team in the game")]
        [DataMember(Name = "ThirdDownConversions", Order = 49)]
        public int? ThirdDownConversions { get; set; }

        /// <summary>
        /// Percentage of third downs converted
        /// </summary>
        [Description("Percentage of third downs converted")]
        [DataMember(Name = "ThirdDownPercentage", Order = 50)]
        public decimal? ThirdDownPercentage { get; set; }

        /// <summary>
        /// Total fourth down attempts by the team in the game
        /// </summary>
        [Description("Total fourth down attempts by the team in the game")]
        [DataMember(Name = "FourthDownAttempts", Order = 51)]
        public int? FourthDownAttempts { get; set; }

        /// <summary>
        /// Total fourth down conversions by the team in the game
        /// </summary>
        [Description("Total fourth down conversions by the team in the game")]
        [DataMember(Name = "FourthDownConversions", Order = 52)]
        public int? FourthDownConversions { get; set; }

        /// <summary>
        /// Percentage of fourth downs converted by the team in the game
        /// </summary>
        [Description("Percentage of fourth downs converted by the team in the game")]
        [DataMember(Name = "FourthDownPercentage", Order = 53)]
        public decimal? FourthDownPercentage { get; set; }

        /// <summary>
        /// Total red zone opportunities by the team in the game
        /// </summary>
        [Description("Total red zone opportunities by the team in the game")]
        [DataMember(Name = "RedZoneAttempts", Order = 54)]
        public int? RedZoneAttempts { get; set; }

        /// <summary>
        /// Total red zone opportunities converted into touchdowns by the team in the game
        /// </summary>
        [Description("Total red zone opportunities converted into touchdowns by the team in the game")]
        [DataMember(Name = "RedZoneConversions", Order = 55)]
        public int? RedZoneConversions { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoAttempts", Order = 56)]
        public int? GoalToGoAttempts { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoConversions", Order = 57)]
        public int? GoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards by the team in the game
        /// </summary>
        [Description("Total punt and defensive return yards by the team in the game")]
        [DataMember(Name = "ReturnYards", Order = 58)]
        public int? ReturnYards { get; set; }

        /// <summary>
        /// Total penalties committed by the team in the game
        /// </summary>
        [Description("Total penalties committed by the team in the game")]
        [DataMember(Name = "Penalties", Order = 59)]
        public int? Penalties { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the team
        /// </summary>
        [Description("Total penalty yards enforced against the team")]
        [DataMember(Name = "PenaltyYards", Order = 60)]
        public int? PenaltyYards { get; set; }

        /// <summary>
        /// Total fumbles by the team in the game
        /// </summary>
        [Description("Total fumbles by the team in the game")]
        [DataMember(Name = "Fumbles", Order = 61)]
        public int? Fumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the team in the game
        /// </summary>
        [Description("Total fumbles lost by the team in the game")]
        [DataMember(Name = "FumblesLost", Order = 62)]
        public int? FumblesLost { get; set; }

        /// <summary>
        /// Total number of sacks allowed by the team in the game
        /// </summary>
        [Description("Total number of sacks allowed by the team in the game")]
        [DataMember(Name = "TimesSacked", Order = 63)]
        public int? TimesSacked { get; set; }

        /// <summary>
        /// Total sack yards allowed by the team in the game
        /// </summary>
        [Description("Total sack yards allowed by the team in the game")]
        [DataMember(Name = "TimesSackedYards", Order = 64)]
        public int? TimesSackedYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the team in the game. Note: This is a defensive stat that includes sacks
        /// </summary>
        [Description("Total quarterback hits by the team in the game. Note: This is a defensive stat that includes sacks")]
        [DataMember(Name = "QuarterbackHits", Order = 65)]
        public int? QuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the team in the game. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)
        /// </summary>
        [Description("Total tackles for loss by the team in the game. Note: These are tackles behind the line of scrimmage for loss of yards (including sacks)")]
        [DataMember(Name = "TacklesForLoss", Order = 66)]
        public int? TacklesForLoss { get; set; }

        /// <summary>
        /// Total defensive safeties scored by the team in the game
        /// </summary>
        [Description("Total defensive safeties scored by the team in the game")]
        [DataMember(Name = "Safeties", Order = 67)]
        public int? Safeties { get; set; }

        /// <summary>
        /// Total number of punts by the team in the game
        /// </summary>
        [Description("Total number of punts by the team in the game")]
        [DataMember(Name = "Punts", Order = 68)]
        public int? Punts { get; set; }

        /// <summary>
        /// Total punt yards by the team in the game
        /// </summary>
        [Description("Total punt yards by the team in the game")]
        [DataMember(Name = "PuntYards", Order = 69)]
        public int? PuntYards { get; set; }

        /// <summary>
        /// The average number of yards per punt by the team in the game
        /// </summary>
        [Description("The average number of yards per punt by the team in the game")]
        [DataMember(Name = "PuntAverage", Order = 70)]
        public decimal PuntAverage { get; set; }

        /// <summary>
        /// Total number of giveaways by the team in the game
        /// </summary>
        [Description("Total number of giveaways by the team in the game")]
        [DataMember(Name = "Giveaways", Order = 71)]
        public int Giveaways { get; set; }

        /// <summary>
        /// Total takeaways by the team in the game
        /// </summary>
        [Description("Total takeaways by the team in the game")]
        [DataMember(Name = "Takeaways", Order = 72)]
        public int Takeaways { get; set; }

        /// <summary>
        /// Total turnover differential (takeaways minus giveaways) by the team in the game
        /// </summary>
        [Description("Total turnover differential (takeaways minus giveaways) by the team in the game")]
        [DataMember(Name = "TurnoverDifferential", Order = 73)]
        public int TurnoverDifferential { get; set; }

        /// <summary>
        /// Points scored during Quarter 1 for the opponent team in the game
        /// </summary>
        [Description("Points scored during Quarter 1 for the opponent team in the game")]
        [DataMember(Name = "OpponentScoreQuarter1", Order = 74)]
        public int? OpponentScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2 for the opponent team in the game
        /// </summary>
        [Description("Points scored during Quarter 2 for the opponent team in the game")]
        [DataMember(Name = "OpponentScoreQuarter2", Order = 75)]
        public int? OpponentScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3 for the opponent team in the game
        /// </summary>
        [Description("Points scored during Quarter 3 for the opponent team in the game")]
        [DataMember(Name = "OpponentScoreQuarter3", Order = 76)]
        public int? OpponentScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4 for the opponent team in the game
        /// </summary>
        [Description("Points scored during Quarter 4 for the opponent team in the game")]
        [DataMember(Name = "OpponentScoreQuarter4", Order = 77)]
        public int? OpponentScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during overtime for the opponent team in the game
        /// </summary>
        [Description("Points scored during overtime for the opponent team in the game")]
        [DataMember(Name = "OpponentScoreOvertime", Order = 78)]
        public int OpponentScoreOvertime { get; set; }

        /// <summary>
        /// Total time of possession minutes for the opponent team in the game
        /// </summary>
        [Description("Total time of possession minutes for the opponent team in the game")]
        [DataMember(Name = "OpponentTimeOfPossessionMinutes", Order = 79)]
        public int? OpponentTimeOfPossessionMinutes { get; set; }

        /// <summary>
        /// Total time of possession seconds for the opponent team in the game
        /// </summary>
        [Description("Total time of possession seconds for the opponent team in the game")]
        [DataMember(Name = "OpponentTimeOfPossessionSeconds", Order = 80)]
        public int? OpponentTimeOfPossessionSeconds { get; set; }

        /// <summary>
        /// Total time of possession for the opponent team in the game
        /// </summary>
        [Description("Total time of possession for the opponent team in the game")]
        [DataMember(Name = "OpponentTimeOfPossession", Order = 81)]
        public string OpponentTimeOfPossession { get; set; }

        /// <summary>
        /// Total first downs converted by the opponent team in the game
        /// </summary>
        [Description("Total first downs converted by the opponent team in the game")]
        [DataMember(Name = "OpponentFirstDowns", Order = 82)]
        public int? OpponentFirstDowns { get; set; }

        /// <summary>
        /// Total rushing first downs by the opponent team in the game
        /// </summary>
        [Description("Total rushing first downs by the opponent team in the game")]
        [DataMember(Name = "OpponentFirstDownsByRushing", Order = 83)]
        public int? OpponentFirstDownsByRushing { get; set; }

        /// <summary>
        /// Total passing first downs converted by the opponent team in the game
        /// </summary>
        [Description("Total passing first downs converted by the opponent team in the game")]
        [DataMember(Name = "OpponentFirstDownsByPassing", Order = 84)]
        public int? OpponentFirstDownsByPassing { get; set; }

        /// <summary>
        /// Total first downs by penalty for the opponent team in the game
        /// </summary>
        [Description("Total first downs by penalty for the opponent team in the game")]
        [DataMember(Name = "OpponentFirstDownsByPenalty", Order = 85)]
        public int? OpponentFirstDownsByPenalty { get; set; }

        /// <summary>
        /// Total offensive plays by the opponent team in the game
        /// </summary>
        [Description("Total offensive plays by the opponent team in the game")]
        [DataMember(Name = "OpponentOffensivePlays", Order = 86)]
        public int OpponentOffensivePlays { get; set; }

        /// <summary>
        /// Total offensive yards gained by the opponent team in the game
        /// </summary>
        [Description("Total offensive yards gained by the opponent team in the game")]
        [DataMember(Name = "OpponentOffensiveYards", Order = 87)]
        public int OpponentOffensiveYards { get; set; }

        /// <summary>
        /// Average yards gained per offensive play by the opponent team in the game
        /// </summary>
        [Description("Average yards gained per offensive play by the opponent team in the game")]
        [DataMember(Name = "OpponentOffensiveYardsPerPlay", Order = 88)]
        public decimal OpponentOffensiveYardsPerPlay { get; set; }

        /// <summary>
        /// Total touchdowns scored by the opponent team in the game
        /// </summary>
        [Description("Total touchdowns scored by the opponent team in the game")]
        [DataMember(Name = "OpponentTouchdowns", Order = 89)]
        public int? OpponentTouchdowns { get; set; }

        /// <summary>
        /// Total rushing attempts by the opponent team in the game
        /// </summary>
        [Description("Total rushing attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentRushingAttempts", Order = 90)]
        public int? OpponentRushingAttempts { get; set; }

        /// <summary>
        /// Total rushing yards by the opponent team in the game
        /// </summary>
        [Description("Total rushing yards by the opponent team in the game")]
        [DataMember(Name = "OpponentRushingYards", Order = 91)]
        public int? OpponentRushingYards { get; set; }

        /// <summary>
        /// Average rushing yards gained per attempt by the opponent team in the game
        /// </summary>
        [Description("Average rushing yards gained per attempt by the opponent team in the game")]
        [DataMember(Name = "OpponentRushingYardsPerAttempt", Order = 92)]
        public decimal OpponentRushingYardsPerAttempt { get; set; }

        /// <summary>
        /// Total rushing touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total rushing touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentRushingTouchdowns", Order = 93)]
        public int? OpponentRushingTouchdowns { get; set; }

        /// <summary>
        /// Total passes thrown by the opponent team in the game
        /// </summary>
        [Description("Total passes thrown by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingAttempts", Order = 94)]
        public int? OpponentPassingAttempts { get; set; }

        /// <summary>
        /// Total passing completions by the opponent team in the game
        /// </summary>
        [Description("Total passing completions by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingCompletions", Order = 95)]
        public int? OpponentPassingCompletions { get; set; }

        /// <summary>
        /// Total passing yards by the opponent team in the game
        /// </summary>
        [Description("Total passing yards by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingYards", Order = 96)]
        public int? OpponentPassingYards { get; set; }

        /// <summary>
        /// Total passing touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total passing touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingTouchdowns", Order = 97)]
        public int? OpponentPassingTouchdowns { get; set; }

        /// <summary>
        /// Total interceptions thrown by the opponent team in the game
        /// </summary>
        [Description("Total interceptions thrown by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingInterceptions", Order = 98)]
        public int? OpponentPassingInterceptions { get; set; }

        /// <summary>
        /// Average passing yards gained per attempt by the opponent team in the game
        /// </summary>
        [Description("Average passing yards gained per attempt by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingYardsPerAttempt", Order = 99)]
        public decimal OpponentPassingYardsPerAttempt { get; set; }

        /// <summary>
        /// Average passing yards gained per completion by the opponent team in the game
        /// </summary>
        [Description("Average passing yards gained per completion by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingYardsPerCompletion", Order = 100)]
        public decimal OpponentPassingYardsPerCompletion { get; set; }

        /// <summary>
        /// Total completion percentage of the opponent team in the game
        /// </summary>
        [Description("Total completion percentage of the opponent team in the game")]
        [DataMember(Name = "OpponentCompletionPercentage", Order = 101)]
        public decimal OpponentCompletionPercentage { get; set; }

        /// <summary>
        /// Total passer rating by the opponent team in the game
        /// </summary>
        [Description("Total passer rating by the opponent team in the game")]
        [DataMember(Name = "OpponentPasserRating", Order = 102)]
        public decimal? OpponentPasserRating { get; set; }

        /// <summary>
        /// Total third down attempts by the opponent team in the game
        /// </summary>
        [Description("Total third down attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentThirdDownAttempts", Order = 103)]
        public int? OpponentThirdDownAttempts { get; set; }

        /// <summary>
        /// Total third down conversions by the opponent team in the game
        /// </summary>
        [Description("Total third down conversions by the opponent team in the game")]
        [DataMember(Name = "OpponentThirdDownConversions", Order = 104)]
        public int? OpponentThirdDownConversions { get; set; }

        /// <summary>
        /// Total third down percentage by the opponent team in the game
        /// </summary>
        [Description("Total third down percentage by the opponent team in the game")]
        [DataMember(Name = "OpponentThirdDownPercentage", Order = 105)]
        public decimal? OpponentThirdDownPercentage { get; set; }

        /// <summary>
        /// Total fourth downs attempted by the opponent team in the game
        /// </summary>
        [Description("Total fourth downs attempted by the opponent team in the game")]
        [DataMember(Name = "OpponentFourthDownAttempts", Order = 106)]
        public int? OpponentFourthDownAttempts { get; set; }

        /// <summary>
        /// Total fourth downs converted by the opponent team in the game
        /// </summary>
        [Description("Total fourth downs converted by the opponent team in the game")]
        [DataMember(Name = "OpponentFourthDownConversions", Order = 107)]
        public int? OpponentFourthDownConversions { get; set; }

        /// <summary>
        /// Total fourth down conversion percentage by the opponent team in the game
        /// </summary>
        [Description("Total fourth down conversion percentage by the opponent team in the game")]
        [DataMember(Name = "OpponentFourthDownPercentage", Order = 108)]
        public decimal? OpponentFourthDownPercentage { get; set; }

        /// <summary>
        /// Total red zone opportunities by the opponent team in the game
        /// </summary>
        [Description("Total red zone opportunities by the opponent team in the game")]
        [DataMember(Name = "OpponentRedZoneAttempts", Order = 109)]
        public int? OpponentRedZoneAttempts { get; set; }

        /// <summary>
        /// Total red zone opportunities converted to touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total red zone opportunities converted to touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentRedZoneConversions", Order = 110)]
        public int? OpponentRedZoneConversions { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoAttempts", Order = 111)]
        public int? OpponentGoalToGoAttempts { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoConversions", Order = 112)]
        public int? OpponentGoalToGoConversions { get; set; }

        /// <summary>
        /// Total punt and defensive return yards by the opponent team in the game
        /// </summary>
        [Description("Total punt and defensive return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentReturnYards", Order = 113)]
        public int? OpponentReturnYards { get; set; }

        /// <summary>
        /// Total penalties enforced against the opponent team in the game
        /// </summary>
        [Description("Total penalties enforced against the opponent team in the game")]
        [DataMember(Name = "OpponentPenalties", Order = 114)]
        public int? OpponentPenalties { get; set; }

        /// <summary>
        /// Total penalty yards enforced against the opponent team in the game
        /// </summary>
        [Description("Total penalty yards enforced against the opponent team in the game")]
        [DataMember(Name = "OpponentPenaltyYards", Order = 115)]
        public int? OpponentPenaltyYards { get; set; }

        /// <summary>
        /// Total offensive fumbles by the opponent team in the game
        /// </summary>
        [Description("Total offensive fumbles by the opponent team in the game")]
        [DataMember(Name = "OpponentFumbles", Order = 116)]
        public int? OpponentFumbles { get; set; }

        /// <summary>
        /// Total fumbles lost by the opponent team in the game
        /// </summary>
        [Description("Total fumbles lost by the opponent team in the game")]
        [DataMember(Name = "OpponentFumblesLost", Order = 117)]
        public int? OpponentFumblesLost { get; set; }

        /// <summary>
        /// Total sacks allowed by the opponent team in the game
        /// </summary>
        [Description("Total sacks allowed by the opponent team in the game")]
        [DataMember(Name = "OpponentTimesSacked", Order = 118)]
        public int? OpponentTimesSacked { get; set; }

        /// <summary>
        /// Total yards as a result of a sack allowed by the opponent team in the game
        /// </summary>
        [Description("Total yards as a result of a sack allowed by the opponent team in the game")]
        [DataMember(Name = "OpponentTimesSackedYards", Order = 119)]
        public int? OpponentTimesSackedYards { get; set; }

        /// <summary>
        /// Total quarterback hits by the opponent team in the game
        /// </summary>
        [Description("Total quarterback hits by the opponent team in the game")]
        [DataMember(Name = "OpponentQuarterbackHits", Order = 120)]
        public int? OpponentQuarterbackHits { get; set; }

        /// <summary>
        /// Total tackles for loss by the opponent team in the game
        /// </summary>
        [Description("Total tackles for loss by the opponent team in the game")]
        [DataMember(Name = "OpponentTacklesForLoss", Order = 121)]
        public int? OpponentTacklesForLoss { get; set; }

        /// <summary>
        /// Total safeties recorded by the opponent team in the game
        /// </summary>
        [Description("Total safeties recorded by the opponent team in the game")]
        [DataMember(Name = "OpponentSafeties", Order = 122)]
        public int? OpponentSafeties { get; set; }

        /// <summary>
        /// Total punts by the opponent team in the game
        /// </summary>
        [Description("Total punts by the opponent team in the game")]
        [DataMember(Name = "OpponentPunts", Order = 123)]
        public int? OpponentPunts { get; set; }

        /// <summary>
        /// Total punt yards by the opponent team in the game
        /// </summary>
        [Description("Total punt yards by the opponent team in the game")]
        [DataMember(Name = "OpponentPuntYards", Order = 124)]
        public int? OpponentPuntYards { get; set; }

        /// <summary>
        /// Average number of yards per punt
        /// </summary>
        [Description("Average number of yards per punt")]
        [DataMember(Name = "OpponentPuntAverage", Order = 125)]
        public decimal OpponentPuntAverage { get; set; }

        /// <summary>
        /// Total giveaways by the opponent team in the game
        /// </summary>
        [Description("Total giveaways by the opponent team in the game")]
        [DataMember(Name = "OpponentGiveaways", Order = 126)]
        public int OpponentGiveaways { get; set; }

        /// <summary>
        /// Total takeaways by the opponent team in the game
        /// </summary>
        [Description("Total takeaways by the opponent team in the game")]
        [DataMember(Name = "OpponentTakeaways", Order = 127)]
        public int OpponentTakeaways { get; set; }

        /// <summary>
        /// Total turnover differential by the opponent team in the game (takeaways minus giveaways)
        /// </summary>
        [Description("Total turnover differential by the opponent team in the game (takeaways minus giveaways)")]
        [DataMember(Name = "OpponentTurnoverDifferential", Order = 128)]
        public int OpponentTurnoverDifferential { get; set; }

        /// <summary>
        /// Total percentage of red zone opportunities converted into touchdowns by the team in the game
        /// </summary>
        [Description("Total percentage of red zone opportunities converted into touchdowns by the team in the game")]
        [DataMember(Name = "RedZonePercentage", Order = 129)]
        public decimal? RedZonePercentage { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "GoalToGoPercentage", Order = 130)]
        public decimal? GoalToGoPercentage { get; set; }

        /// <summary>
        /// The quarterback hits differential of the team in the game. Note: Determined by hits on opposing quarterback minus hits on own quarterback
        /// </summary>
        [Description("The quarterback hits differential of the team in the game. Note: Determined by hits on opposing quarterback minus hits on own quarterback")]
        [DataMember(Name = "QuarterbackHitsDifferential", Order = 131)]
        public int? QuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// Total tackles for loss differential by the team in the game
        /// </summary>
        [Description("Total tackles for loss differential by the team in the game")]
        [DataMember(Name = "TacklesForLossDifferential", Order = 132)]
        public int? TacklesForLossDifferential { get; set; }

        /// <summary>
        /// Total sack differential of the team in the game
        /// </summary>
        [Description("Total sack differential of the team in the game")]
        [DataMember(Name = "QuarterbackSacksDifferential", Order = 133)]
        public int QuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Total percentage of plays defended that resulted in a tackle for loss by the team in the game
        /// </summary>
        [Description("Total percentage of plays defended that resulted in a tackle for loss by the team in the game")]
        [DataMember(Name = "TacklesForLossPercentage", Order = 134)]
        public decimal? TacklesForLossPercentage { get; set; }

        /// <summary>
        /// Total percentage of opposing quarterback dropbacks that resulted in a quarterback hit by the team in the game
        /// </summary>
        [Description("Total percentage of opposing quarterback dropbacks that resulted in a quarterback hit by the team in the game")]
        [DataMember(Name = "QuarterbackHitsPercentage", Order = 135)]
        public decimal? QuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Total percentage of drop backs that resulted in a sack by the team in the game
        /// </summary>
        [Description("Total percentage of drop backs that resulted in a sack by the team in the game")]
        [DataMember(Name = "TimesSackedPercentage", Order = 136)]
        public decimal TimesSackedPercentage { get; set; }

        /// <summary>
        /// Percentage of opponent's red zone opportunities converted into touchdowns in the game
        /// </summary>
        [Description("Percentage of opponent's red zone opportunities converted into touchdowns in the game")]
        [DataMember(Name = "OpponentRedZonePercentage", Order = 137)]
        public decimal? OpponentRedZonePercentage { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentGoalToGoPercentage", Order = 138)]
        public decimal? OpponentGoalToGoPercentage { get; set; }

        /// <summary>
        /// Total quarterback hits differential by the opponent team in the game
        /// </summary>
        [Description("Total quarterback hits differential by the opponent team in the game")]
        [DataMember(Name = "OpponentQuarterbackHitsDifferential", Order = 139)]
        public int? OpponentQuarterbackHitsDifferential { get; set; }

        /// <summary>
        /// Total tackles for loss differential by the opponent team in the game
        /// </summary>
        [Description("Total tackles for loss differential by the opponent team in the game")]
        [DataMember(Name = "OpponentTacklesForLossDifferential", Order = 140)]
        public int? OpponentTacklesForLossDifferential { get; set; }

        /// <summary>
        /// Total quarterback sacks differential by the opponent team in the game
        /// </summary>
        [Description("Total quarterback sacks differential by the opponent team in the game")]
        [DataMember(Name = "OpponentQuarterbackSacksDifferential", Order = 141)]
        public int? OpponentQuarterbackSacksDifferential { get; set; }

        /// <summary>
        /// Total percentage of tackles for loss by the opponent team in the game
        /// </summary>
        [Description("Total percentage of tackles for loss by the opponent team in the game")]
        [DataMember(Name = "OpponentTacklesForLossPercentage", Order = 142)]
        public decimal? OpponentTacklesForLossPercentage { get; set; }

        /// <summary>
        /// Total quarterback hits percentage by the opponent team in the game
        /// </summary>
        [Description("Total quarterback hits percentage by the opponent team in the game")]
        [DataMember(Name = "OpponentQuarterbackHitsPercentage", Order = 143)]
        public decimal? OpponentQuarterbackHitsPercentage { get; set; }

        /// <summary>
        /// Total percentage of dropbacks that resulted in a sack allowed by the opponent team in the game
        /// </summary>
        [Description("Total percentage of dropbacks that resulted in a sack allowed by the opponent team in the game")]
        [DataMember(Name = "OpponentTimesSackedPercentage", Order = 144)]
        public decimal OpponentTimesSackedPercentage { get; set; }

        /// <summary>
        /// Total number of kickoffs by the team in the game
        /// </summary>
        [Description("Total number of kickoffs by the team in the game")]
        [DataMember(Name = "Kickoffs", Order = 145)]
        public int? Kickoffs { get; set; }

        /// <summary>
        /// Total kickoffs that went into the end zone by the team in the game
        /// </summary>
        [Description("Total kickoffs that went into the end zone by the team in the game")]
        [DataMember(Name = "KickoffsInEndZone", Order = 146)]
        public int? KickoffsInEndZone { get; set; }

        /// <summary>
        /// Total kickoffs that resulted in touchbacks by the team in the game
        /// </summary>
        [Description("Total kickoffs that resulted in touchbacks by the team in the game")]
        [DataMember(Name = "KickoffTouchbacks", Order = 147)]
        public int? KickoffTouchbacks { get; set; }

        /// <summary>
        /// Total punts by the team that were blocked in the game
        /// </summary>
        [Description("Total punts by the team that were blocked in the game")]
        [DataMember(Name = "PuntsHadBlocked", Order = 148)]
        public int? PuntsHadBlocked { get; set; }

        /// <summary>
        /// The average net yards per punt by the team in the game
        /// </summary>
        [Description("The average net yards per punt by the team in the game")]
        [DataMember(Name = "PuntNetAverage", Order = 149)]
        public decimal? PuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the team in the game
        /// </summary>
        [Description("Total extra point kick attempts by the team in the game")]
        [DataMember(Name = "ExtraPointKickingAttempts", Order = 150)]
        public int? ExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Total extra point kicks made by the team in the game
        /// </summary>
        [Description("Total extra point kicks made by the team in the game")]
        [DataMember(Name = "ExtraPointKickingConversions", Order = 151)]
        public int? ExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the team that were blocked in the game
        /// </summary>
        [Description("Total extra point kick attempts by the team that were blocked in the game")]
        [DataMember(Name = "ExtraPointsHadBlocked", Order = 152)]
        public int? ExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Total two point conversions passing conversions by the team in the game
        /// </summary>
        [Description("Total two point conversions passing conversions by the team in the game")]
        [DataMember(Name = "ExtraPointPassingAttempts", Order = 153)]
        public int? ExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Total two point conversions passing conversions by the team in the game
        /// </summary>
        [Description("Total two point conversions passing conversions by the team in the game")]
        [DataMember(Name = "ExtraPointPassingConversions", Order = 154)]
        public int? ExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Total two point conversion rushing attempts by the team in the game
        /// </summary>
        [Description("Total two point conversion rushing attempts by the team in the game")]
        [DataMember(Name = "ExtraPointRushingAttempts", Order = 155)]
        public int? ExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion rushing conversions in the game
        /// </summary>
        [Description("Total two point conversion rushing conversions in the game")]
        [DataMember(Name = "ExtraPointRushingConversions", Order = 156)]
        public int? ExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Total field goal attempts by the team in the game
        /// </summary>
        [Description("Total field goal attempts by the team in the game")]
        [DataMember(Name = "FieldGoalAttempts", Order = 157)]
        public int? FieldGoalAttempts { get; set; }

        /// <summary>
        /// Total field goals made by the team in game
        /// </summary>
        [Description("Total field goals made by the team in game")]
        [DataMember(Name = "FieldGoalsMade", Order = 158)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goals by the team that were blocked in the game
        /// </summary>
        [Description("Total field goals by the team that were blocked in the game")]
        [DataMember(Name = "FieldGoalsHadBlocked", Order = 159)]
        public int? FieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punt returns by the team in the game
        /// </summary>
        [Description("Total punt returns by the team in the game")]
        [DataMember(Name = "PuntReturns", Order = 160)]
        public int? PuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the team in the game
        /// </summary>
        [Description("Total punt return yards by the team in the game")]
        [DataMember(Name = "PuntReturnYards", Order = 161)]
        public int? PuntReturnYards { get; set; }

        /// <summary>
        /// Total kickoff returns by the team in the game
        /// </summary>
        [Description("Total kickoff returns by the team in the game")]
        [DataMember(Name = "KickReturns", Order = 162)]
        public int? KickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the team in the game
        /// </summary>
        [Description("Total kickoff return yards by the team in the game")]
        [DataMember(Name = "KickReturnYards", Order = 163)]
        public int? KickReturnYards { get; set; }

        /// <summary>
        /// Total defensive interception returns by the team in the game
        /// </summary>
        [Description("Total defensive interception returns by the team in the game")]
        [DataMember(Name = "InterceptionReturns", Order = 164)]
        public int? InterceptionReturns { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the team in the game
        /// </summary>
        [Description("Total defensive interception return yards by the team in the game")]
        [DataMember(Name = "InterceptionReturnYards", Order = 165)]
        public int? InterceptionReturnYards { get; set; }

        /// <summary>
        /// Total kickoffs by the opponent team in the game
        /// </summary>
        [Description("Total kickoffs by the opponent team in the game")]
        [DataMember(Name = "OpponentKickoffs", Order = 166)]
        public int? OpponentKickoffs { get; set; }

        /// <summary>
        /// Total kickoffs that went into the end zone by the opponent team in the game
        /// </summary>
        [Description("Total kickoffs that went into the end zone by the opponent team in the game")]
        [DataMember(Name = "OpponentKickoffsInEndZone", Order = 167)]
        public int? OpponentKickoffsInEndZone { get; set; }

        /// <summary>
        /// Total kickoffs that resulted in touchbacks by the opponent team in the game
        /// </summary>
        [Description("Total kickoffs that resulted in touchbacks by the opponent team in the game")]
        [DataMember(Name = "OpponentKickoffTouchbacks", Order = 168)]
        public int? OpponentKickoffTouchbacks { get; set; }

        /// <summary>
        /// Total punt yard that were blocked for the opponent team in the game
        /// </summary>
        [Description("Total punt yard that were blocked for the opponent team in the game")]
        [DataMember(Name = "OpponentPuntsHadBlocked", Order = 169)]
        public int? OpponentPuntsHadBlocked { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentPuntNetAverage", Order = 170)]
        public decimal? OpponentPuntNetAverage { get; set; }

        /// <summary>
        /// Total extra point kick attempts by the opponent team in the game
        /// </summary>
        [Description("Total extra point kick attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointKickingAttempts", Order = 171)]
        public int? OpponentExtraPointKickingAttempts { get; set; }

        /// <summary>
        /// Total extra point kicks made by the opponent team in the game
        /// </summary>
        [Description("Total extra point kicks made by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointKickingConversions", Order = 172)]
        public int? OpponentExtraPointKickingConversions { get; set; }

        /// <summary>
        /// Total extra point kick attempts that were blocked against the opponent team in the game
        /// </summary>
        [Description("Total extra point kick attempts that were blocked against the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointsHadBlocked", Order = 173)]
        public int? OpponentExtraPointsHadBlocked { get; set; }

        /// <summary>
        /// Total two point conversion passing attempts by the opponent team in the game
        /// </summary>
        [Description("Total two point conversion passing attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointPassingAttempts", Order = 174)]
        public int? OpponentExtraPointPassingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion passing conversions by the opponent team in the game
        /// </summary>
        [Description("Total two point conversion passing conversions by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointPassingConversions", Order = 175)]
        public int? OpponentExtraPointPassingConversions { get; set; }

        /// <summary>
        /// Total two point conversion rushing attempts by the opponent team in the game
        /// </summary>
        [Description("Total two point conversion rushing attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointRushingAttempts", Order = 176)]
        public int? OpponentExtraPointRushingAttempts { get; set; }

        /// <summary>
        /// Total two point conversion rushing conversions by the opponent team in the game
        /// </summary>
        [Description("Total two point conversion rushing conversions by the opponent team in the game")]
        [DataMember(Name = "OpponentExtraPointRushingConversions", Order = 177)]
        public int? OpponentExtraPointRushingConversions { get; set; }

        /// <summary>
        /// Total field goal attempts by the opponent team in the game
        /// </summary>
        [Description("Total field goal attempts by the opponent team in the game")]
        [DataMember(Name = "OpponentFieldGoalAttempts", Order = 178)]
        public int? OpponentFieldGoalAttempts { get; set; }

        /// <summary>
        /// Total field goals made by the opponent team in the game
        /// </summary>
        [Description("Total field goals made by the opponent team in the game")]
        [DataMember(Name = "OpponentFieldGoalsMade", Order = 179)]
        public int? OpponentFieldGoalsMade { get; set; }

        /// <summary>
        /// Total blocked field goals against the opponent team in the game
        /// </summary>
        [Description("Total blocked field goals against the opponent team in the game")]
        [DataMember(Name = "OpponentFieldGoalsHadBlocked", Order = 180)]
        public int? OpponentFieldGoalsHadBlocked { get; set; }

        /// <summary>
        /// Total punt returns by the opponent team in the game
        /// </summary>
        [Description("Total punt returns by the opponent team in the game")]
        [DataMember(Name = "OpponentPuntReturns", Order = 181)]
        public int? OpponentPuntReturns { get; set; }

        /// <summary>
        /// Total punt return yards by the opponent team in the game
        /// </summary>
        [Description("Total punt return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentPuntReturnYards", Order = 182)]
        public int? OpponentPuntReturnYards { get; set; }

        /// <summary>
        /// Total kickoff returns by the opponent team in the game
        /// </summary>
        [Description("Total kickoff returns by the opponent team in the game")]
        [DataMember(Name = "OpponentKickReturns", Order = 183)]
        public int? OpponentKickReturns { get; set; }

        /// <summary>
        /// Total kickoff return yards by the opponent team in the game
        /// </summary>
        [Description("Total kickoff return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentKickReturnYards", Order = 184)]
        public int? OpponentKickReturnYards { get; set; }

        /// <summary>
        /// Total defensive interceptions by the opponent team in the game
        /// </summary>
        [Description("Total defensive interceptions by the opponent team in the game")]
        [DataMember(Name = "OpponentInterceptionReturns", Order = 185)]
        public int? OpponentInterceptionReturns { get; set; }

        /// <summary>
        /// Total defensive interception return yards by the opponent team in the game
        /// </summary>
        [Description("Total defensive interception return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentInterceptionReturnYards", Order = 186)]
        public int? OpponentInterceptionReturnYards { get; set; }

        /// <summary>
        /// Total defensive solo (unassisted) tackles by the team in the game
        /// </summary>
        [Description("Total defensive solo (unassisted) tackles by the team in the game")]
        [DataMember(Name = "SoloTackles", Order = 187)]
        public int? SoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the team in the game
        /// </summary>
        [Description("Total defensive assisted tackles by the team in the game")]
        [DataMember(Name = "AssistedTackles", Order = 188)]
        public int? AssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the team in the game
        /// </summary>
        [Description("Total defensive sacks by the team in the game")]
        [DataMember(Name = "Sacks", Order = 189)]
        public int? Sacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the team in the game
        /// </summary>
        [Description("Total defensive sack yards by the team in the game")]
        [DataMember(Name = "SackYards", Order = 190)]
        public int? SackYards { get; set; }

        /// <summary>
        /// Total passes defended by the team's defense in the game
        /// </summary>
        [Description("Total passes defended by the team's defense in the game")]
        [DataMember(Name = "PassesDefended", Order = 191)]
        public int? PassesDefended { get; set; }

        /// <summary>
        /// Total fumbles forced on defense by the team in the game
        /// </summary>
        [Description("Total fumbles forced on defense by the team in the game")]
        [DataMember(Name = "FumblesForced", Order = 192)]
        public int? FumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the team in the game
        /// </summary>
        [Description("Total defensive fumble recoveries by the team in the game")]
        [DataMember(Name = "FumblesRecovered", Order = 193)]
        public int? FumblesRecovered { get; set; }

        /// <summary>
        /// Total fumble return yards by the team in the game
        /// </summary>
        [Description("Total fumble return yards by the team in the game")]
        [DataMember(Name = "FumbleReturnYards", Order = 194)]
        public int? FumbleReturnYards { get; set; }

        /// <summary>
        /// Total fumble return touchdowns by the team in the game
        /// </summary>
        [Description("Total fumble return touchdowns by the team in the game")]
        [DataMember(Name = "FumbleReturnTouchdowns", Order = 195)]
        public int? FumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interception return touchdowns by the team in the game
        /// </summary>
        [Description("Total defensive interception return touchdowns by the team in the game")]
        [DataMember(Name = "InterceptionReturnTouchdowns", Order = 196)]
        public int? InterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks by the team in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points
        /// </summary>
        [Description("Total blocked kicks by the team in the game. Note: BlockedKicks include Field Goals and Punts but NOT Extra Points")]
        [DataMember(Name = "BlockedKicks", Order = 197)]
        public int? BlockedKicks { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the team in the game
        /// </summary>
        [Description("Total punt return touchdowns by the team in the game")]
        [DataMember(Name = "PuntReturnTouchdowns", Order = 198)]
        public int? PuntReturnTouchdowns { get; set; }

        /// <summary>
        /// The longest punt return by the team in the game
        /// </summary>
        [Description("The longest punt return by the team in the game")]
        [DataMember(Name = "PuntReturnLong", Order = 199)]
        public int? PuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the team in the game
        /// </summary>
        [Description("Total kickoff return touchdowns by the team in the game")]
        [DataMember(Name = "KickReturnTouchdowns", Order = 200)]
        public int? KickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the team in the game
        /// </summary>
        [Description("Longest kick return by the team in the game")]
        [DataMember(Name = "KickReturnLong", Order = 201)]
        public int? KickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick recovery return yards for the team in the game
        /// </summary>
        [Description("Total blocked kick recovery return yards for the team in the game")]
        [DataMember(Name = "BlockedKickReturnYards", Order = 202)]
        public int? BlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total blocked kick recovery return touchdowns for the team in the game
        /// </summary>
        [Description("Total blocked kick recovery return touchdowns for the team in the game")]
        [DataMember(Name = "BlockedKickReturnTouchdowns", Order = 203)]
        public int? BlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return yards by the team in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return yards by the team in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnYards", Order = 204)]
        public int? FieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the team in the game. Note: This field excludes blocked field goals
        /// </summary>
        [Description("Total field goal return touchdowns by the team in the game. Note: This field excludes blocked field goals")]
        [DataMember(Name = "FieldGoalReturnTouchdowns", Order = 205)]
        public int? FieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// The net yards of the punts by the team in the game
        /// </summary>
        [Description("The net yards of the punts by the team in the game")]
        [DataMember(Name = "PuntNetYards", Order = 206)]
        public int? PuntNetYards { get; set; }

        /// <summary>
        /// Total defensive solo tackles by the opponent team in the game
        /// </summary>
        [Description("Total defensive solo tackles by the opponent team in the game")]
        [DataMember(Name = "OpponentSoloTackles", Order = 207)]
        public int? OpponentSoloTackles { get; set; }

        /// <summary>
        /// Total defensive assisted tackles by the opponent team in the game
        /// </summary>
        [Description("Total defensive assisted tackles by the opponent team in the game")]
        [DataMember(Name = "OpponentAssistedTackles", Order = 208)]
        public int? OpponentAssistedTackles { get; set; }

        /// <summary>
        /// Total defensive sacks by the opponent team in the game
        /// </summary>
        [Description("Total defensive sacks by the opponent team in the game")]
        [DataMember(Name = "OpponentSacks", Order = 209)]
        public int? OpponentSacks { get; set; }

        /// <summary>
        /// Total defensive sack yards by the opponent team in the game
        /// </summary>
        [Description("Total defensive sack yards by the opponent team in the game")]
        [DataMember(Name = "OpponentSackYards", Order = 210)]
        public int? OpponentSackYards { get; set; }

        /// <summary>
        /// Total passes defended by the opponent team in the game
        /// </summary>
        [Description("Total passes defended by the opponent team in the game")]
        [DataMember(Name = "OpponentPassesDefended", Order = 211)]
        public int? OpponentPassesDefended { get; set; }

        /// <summary>
        /// Total defensive fumbles forced by the opponent team in the game
        /// </summary>
        [Description("Total defensive fumbles forced by the opponent team in the game")]
        [DataMember(Name = "OpponentFumblesForced", Order = 212)]
        public int? OpponentFumblesForced { get; set; }

        /// <summary>
        /// Total defensive fumble recoveries by the opponent team in the game
        /// </summary>
        [Description("Total defensive fumble recoveries by the opponent team in the game")]
        [DataMember(Name = "OpponentFumblesRecovered", Order = 213)]
        public int? OpponentFumblesRecovered { get; set; }

        /// <summary>
        /// Total defensive fumbles return yards by the opponent team in the game
        /// </summary>
        [Description("Total defensive fumbles return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentFumbleReturnYards", Order = 214)]
        public int? OpponentFumbleReturnYards { get; set; }

        /// <summary>
        /// Total defensive fumbles return touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total defensive fumbles return touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentFumbleReturnTouchdowns", Order = 215)]
        public int? OpponentFumbleReturnTouchdowns { get; set; }

        /// <summary>
        /// Total defensive interception touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total defensive interception touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentInterceptionReturnTouchdowns", Order = 216)]
        public int? OpponentInterceptionReturnTouchdowns { get; set; }

        /// <summary>
        /// Total blocked kicks against the opponent team in the game
        /// </summary>
        [Description("Total blocked kicks against the opponent team in the game")]
        [DataMember(Name = "OpponentBlockedKicks", Order = 217)]
        public int? OpponentBlockedKicks { get; set; }

        /// <summary>
        /// Total punt return touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total punt return touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentPuntReturnTouchdowns", Order = 218)]
        public int? OpponentPuntReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest punt return by the opponent team in the game
        /// </summary>
        [Description("Longest punt return by the opponent team in the game")]
        [DataMember(Name = "OpponentPuntReturnLong", Order = 219)]
        public int? OpponentPuntReturnLong { get; set; }

        /// <summary>
        /// Total kickoff return touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total kickoff return touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentKickReturnTouchdowns", Order = 220)]
        public int? OpponentKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Longest kick return by the opponent team in the game
        /// </summary>
        [Description("Longest kick return by the opponent team in the game")]
        [DataMember(Name = "OpponentKickReturnLong", Order = 221)]
        public int? OpponentKickReturnLong { get; set; }

        /// <summary>
        /// Total blocked kick return yards by the opponent team in the game
        /// </summary>
        [Description("Total blocked kick return yards by the opponent team in the game")]
        [DataMember(Name = "OpponentBlockedKickReturnYards", Order = 222)]
        public int? OpponentBlockedKickReturnYards { get; set; }

        /// <summary>
        /// Total blocked kick return touchdowns by the opponent team in the game
        /// </summary>
        [Description("Total blocked kick return touchdowns by the opponent team in the game")]
        [DataMember(Name = "OpponentBlockedKickReturnTouchdowns", Order = 223)]
        public int? OpponentBlockedKickReturnTouchdowns { get; set; }

        /// <summary>
        /// Total field goal return yards by the opponent team in the game. Note: Excludes blocked field goals (only for straight misses that are returned)
        /// </summary>
        [Description("Total field goal return yards by the opponent team in the game. Note: Excludes blocked field goals (only for straight misses that are returned)")]
        [DataMember(Name = "OpponentFieldGoalReturnYards", Order = 224)]
        public int? OpponentFieldGoalReturnYards { get; set; }

        /// <summary>
        /// Total field goal return touchdowns by the opponent team in the game. Note: Excludes blocked field goals (only for straight misses that are returned)
        /// </summary>
        [Description("Total field goal return touchdowns by the opponent team in the game. Note: Excludes blocked field goals (only for straight misses that are returned)")]
        [DataMember(Name = "OpponentFieldGoalReturnTouchdowns", Order = 225)]
        public int? OpponentFieldGoalReturnTouchdowns { get; set; }

        /// <summary>
        /// This field is deprecated
        /// </summary>
        [Description("This field is deprecated")]
        [DataMember(Name = "OpponentPuntNetYards", Order = 226)]
        public int? OpponentPuntNetYards { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 227)]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// The full name of the team (e.g. New England Patriots; Los Angeles Chargers)
        /// </summary>
        [Description("The full name of the team (e.g. New England Patriots; Los Angeles Chargers)")]
        [DataMember(Name = "TeamName", Order = 228)]
        public string TeamName { get; set; }

        /// <summary>
        /// The day of the week this game was played on (e.g. Sunday; Monday; Thursday)
        /// </summary>
        [Description("The day of the week this game was played on (e.g. Sunday; Monday; Thursday)")]
        [DataMember(Name = "DayOfWeek", Order = 229)]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Total number of times the team dropped back to pass in the game
        /// </summary>
        [Description("Total number of times the team dropped back to pass in the game")]
        [DataMember(Name = "PassingDropbacks", Order = 230)]
        public int? PassingDropbacks { get; set; }

        /// <summary>
        /// Total passing dropbacks by the opponent team in the game
        /// </summary>
        [Description("Total passing dropbacks by the opponent team in the game")]
        [DataMember(Name = "OpponentPassingDropbacks", Order = 231)]
        public int? OpponentPassingDropbacks { get; set; }

        /// <summary>
        /// Unique ID of this TeamGame record (subject to change; although it very rarely does). For a guaranteed static ID; use a combination of GameKey and Team.
        /// </summary>
        [Description("Unique ID of this TeamGame record (subject to change; although it very rarely does). For a guaranteed static ID; use a combination of GameKey and Team.")]
        [DataMember(Name = "TeamGameID", Order = 232)]
        public int TeamGameID { get; set; }

        /// <summary>
        /// Total successful two point conversion returns by the team in the game
        /// </summary>
        [Description("Total successful two point conversion returns by the team in the game")]
        [DataMember(Name = "TwoPointConversionReturns", Order = 233)]
        public int? TwoPointConversionReturns { get; set; }

        /// <summary>
        /// Total two point attempt returns converted by the defense for the opponent team in the game
        /// </summary>
        [Description("Total two point attempt returns converted by the defense for the opponent team in the game")]
        [DataMember(Name = "OpponentTwoPointConversionReturns", Order = 234)]
        public int? OpponentTwoPointConversionReturns { get; set; }

        /// <summary>
        /// The unique ID of this team
        /// </summary>
        [Description("The unique ID of this team")]
        [DataMember(Name = "TeamID", Order = 235)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Total defensive interceptions by the opponent team in the game
        /// </summary>
        [Description("Total defensive interceptions by the opponent team in the game")]
        [DataMember(Name = "OpponentID", Order = 236)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 237)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 238)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 239)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 240)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalOpponentID", Order = 241)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 242)]
        public int ScoreID { get; set; }

    }
}

