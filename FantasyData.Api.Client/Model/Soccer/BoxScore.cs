using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The game details associated with this box score
        /// </summary>
        [Description("The game details associated with this box score")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The coach of the away team
        /// </summary>
        [Description("The coach of the away team")]
        [DataMember(Name = "AwayTeamCoach", Order = 10002)]
        public Coach AwayTeamCoach { get; set; }

        /// <summary>
        /// The coach of the home team
        /// </summary>
        [Description("The coach of the home team")]
        [DataMember(Name = "HomeTeamCoach", Order = 10003)]
        public Coach HomeTeamCoach { get; set; }

        /// <summary>
        /// The main referee
        /// </summary>
        [Description("The main referee")]
        [DataMember(Name = "MainReferee", Order = 10004)]
        public Referee MainReferee { get; set; }

        /// <summary>
        /// The first assistant referee
        /// </summary>
        [Description("The first assistant referee")]
        [DataMember(Name = "AssistantReferee1", Order = 10005)]
        public Referee AssistantReferee1 { get; set; }

        /// <summary>
        /// The second assistant referee
        /// </summary>
        [Description("The second assistant referee")]
        [DataMember(Name = "AssistantReferee2", Order = 10006)]
        public Referee AssistantReferee2 { get; set; }

        /// <summary>
        /// The information about the fourth referee working the match
        /// </summary>
        [Description("The information about the fourth referee working the match")]
        [DataMember(Name = "FourthReferee", Order = 10007)]
        public Referee FourthReferee { get; set; }

        /// <summary>
        /// The first additional assistant referee
        /// </summary>
        [Description("The first additional assistant referee")]
        [DataMember(Name = "AdditionalAssistantReferee1", Order = 10008)]
        public Referee AdditionalAssistantReferee1 { get; set; }

        /// <summary>
        /// The second additional assistant referee
        /// </summary>
        [Description("The second additional assistant referee")]
        [DataMember(Name = "AdditionalAssistantReferee2", Order = 10009)]
        public Referee AdditionalAssistantReferee2 { get; set; }

        /// <summary>
        /// The details of the lineups for each team
        /// </summary>
        [Description("The details of the lineups for each team")]
        [DataMember(Name = "Lineups", Order = 20010)]
        public Lineup[] Lineups { get; set; }

        /// <summary>
        /// The details of the goals scored during this game
        /// </summary>
        [Description("The details of the goals scored during this game")]
        [DataMember(Name = "Goals", Order = 20011)]
        public Goal[] Goals { get; set; }

        /// <summary>
        /// The details of the bookings (yellow/red cards) recorded during this game
        /// </summary>
        [Description("The details of the bookings (yellow/red cards) recorded during this game")]
        [DataMember(Name = "Bookings", Order = 20012)]
        public Booking[] Bookings { get; set; }

        /// <summary>
        /// The details of the penalty shootouts recorded during this game
        /// </summary>
        [Description("The details of the penalty shootouts recorded during this game")]
        [DataMember(Name = "PenaltyShootouts", Order = 20013)]
        public PenaltyShootout[] PenaltyShootouts { get; set; }

        /// <summary>
        /// The stats by the team in the game
        /// </summary>
        [Description("The stats by the team in the game")]
        [DataMember(Name = "TeamGames", Order = 20014)]
        public TeamGame[] TeamGames { get; set; }

        /// <summary>
        /// The player stats for this game
        /// </summary>
        [Description("The player stats for this game")]
        [DataMember(Name = "PlayerGames", Order = 20015)]
        public PlayerGame[] PlayerGames { get; set; }

        /// <summary>
        /// The name of the referee in charge of the video reviews (VAR)
        /// </summary>
        [Description("The name of the referee in charge of the video reviews (VAR)")]
        [DataMember(Name = "VideoAssistantReferee", Order = 10016)]
        public Referee VideoAssistantReferee { get; set; }

    }
}

