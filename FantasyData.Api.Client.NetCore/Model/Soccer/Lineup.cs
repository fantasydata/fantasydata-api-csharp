using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Soccer
{
    [DataContract(Namespace="", Name="Lineup")]
    [Serializable]
    public partial class Lineup
    {
        /// <summary>
        /// The unique ID of the lineup 
        /// </summary>
        [Description("The unique ID of the lineup ")]
        [DataMember(Name = "LineupId", Order = 1)]
        public int LineupId { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 2)]
        public int GameId { get; set; }

        /// <summary>
        /// The player's status in the lineup. Possible values: Substitute In, Starter, Bench
        /// </summary>
        [Description("The player's status in the lineup. Possible values: Substitute In, Starter, Bench")]
        [DataMember(Name = "Type", Order = 3)]
        public string Type { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 4)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by FantasyData
        /// </summary>
        [Description("The player's unique PlayerID as assigned by FantasyData")]
        [DataMember(Name = "PlayerId", Order = 5)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The name of the player in the lineup
        /// </summary>
        [Description("The name of the player in the lineup")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The position of the player
        /// </summary>
        [Description("The position of the player")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The unique ID of the replaced player
        /// </summary>
        [Description("The unique ID of the replaced player")]
        [DataMember(Name = "ReplacedPlayerId", Order = 8)]
        public int? ReplacedPlayerId { get; set; }

        /// <summary>
        /// The name of the replaced player
        /// </summary>
        [Description("The name of the replaced player")]
        [DataMember(Name = "ReplacedPlayerName", Order = 9)]
        public string ReplacedPlayerName { get; set; }

        /// <summary>
        /// The minute of the game
        /// </summary>
        [Description("The minute of the game")]
        [DataMember(Name = "GameMinute", Order = 10)]
        public int? GameMinute { get; set; }

        /// <summary>
        /// The extra minute of the game
        /// </summary>
        [Description("The extra minute of the game")]
        [DataMember(Name = "GameMinuteExtra", Order = 11)]
        public int? GameMinuteExtra { get; set; }

        /// <summary>
        /// The pitch position of where this player lined up on the field. This is used for rendering an image of a soccer/football field with the players marked as such. This will be a number between 0 and 50.
        /// </summary>
        [Description("The pitch position of where this player lined up on the field. This is used for rendering an image of a soccer/football field with the players marked as such. This will be a number between 0 and 50.")]
        [DataMember(Name = "PitchPositionHorizontal", Order = 12)]
        public int? PitchPositionHorizontal { get; set; }

        /// <summary>
        /// The pitch position of where this player lined up on the field. This is used for rendering an image of a soccer/football field with the players marked as such. This will be a number between 0 and 50.
        /// </summary>
        [Description("The pitch position of where this player lined up on the field. This is used for rendering an image of a soccer/football field with the players marked as such. This will be a number between 0 and 50.")]
        [DataMember(Name = "PitchPositionVertical", Order = 13)]
        public int? PitchPositionVertical { get; set; }

    }
}

