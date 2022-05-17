using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Goal")]
    [Serializable]
    public partial class Goal
    {
        /// <summary>
        /// The unique ID of the goal
        /// </summary>
        [Description("The unique ID of the goal")]
        [DataMember(Name = "GoalId", Order = 1)]
        public int GoalId { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 2)]
        public int GameId { get; set; }

        /// <summary>
        /// The unique ID of the team that scored the goal
        /// </summary>
        [Description("The unique ID of the team that scored the goal")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO")]
        [DataMember(Name = "PlayerId", Order = 4)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// The name of the player
        /// </summary>
        [Description("The name of the player")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The type of goal scored
        /// </summary>
        [Description("The type of goal scored")]
        [DataMember(Name = "Type", Order = 6)]
        public string Type { get; set; }

        /// <summary>
        /// The unique ID of the first assisted player
        /// </summary>
        [Description("The unique ID of the first assisted player")]
        [DataMember(Name = "AssistedByPlayerId1", Order = 7)]
        public int? AssistedByPlayerId1 { get; set; }

        /// <summary>
        /// The player's name of the first assisted player
        /// </summary>
        [Description("The player's name of the first assisted player")]
        [DataMember(Name = "AssistedByPlayerName1", Order = 8)]
        public string AssistedByPlayerName1 { get; set; }

        /// <summary>
        /// The unique ID of the second assisted player
        /// </summary>
        [Description("The unique ID of the second assisted player")]
        [DataMember(Name = "AssistedByPlayerId2", Order = 9)]
        public int? AssistedByPlayerId2 { get; set; }

        /// <summary>
        /// The player's name of the second assisted player
        /// </summary>
        [Description("The player's name of the second assisted player")]
        [DataMember(Name = "AssistedByPlayerName2", Order = 10)]
        public string AssistedByPlayerName2 { get; set; }

        /// <summary>
        /// The minute in the game in which the goal was scored
        /// </summary>
        [Description("The minute in the game in which the goal was scored")]
        [DataMember(Name = "GameMinute", Order = 11)]
        public int? GameMinute { get; set; }

        /// <summary>
        /// The extra minute in the game in which the goal was scored
        /// </summary>
        [Description("The extra minute in the game in which the goal was scored")]
        [DataMember(Name = "GameMinuteExtra", Order = 12)]
        public int? GameMinuteExtra { get; set; }

    }
}

