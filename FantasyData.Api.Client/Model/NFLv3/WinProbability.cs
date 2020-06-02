using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="WinProbability")]
    [Serializable]
    public partial class WinProbability
    {
        /// <summary>
        /// The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "TimeRemaining", Order = 1)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)
        /// </summary>
        [Description("The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)")]
        [DataMember(Name = "Quarter", Order = 2)]
        public string Quarter { get; set; }

        /// <summary>
        /// The probability of the Away Team winning the game
        /// </summary>
        [Description("The probability of the Away Team winning the game")]
        [DataMember(Name = "AwayWinProbability", Order = 3)]
        public decimal? AwayWinProbability { get; set; }

        /// <summary>
        /// The probability of the Home Team winning the game
        /// </summary>
        [Description("The probability of the Home Team winning the game")]
        [DataMember(Name = "HomeWinProbability", Order = 4)]
        public decimal? HomeWinProbability { get; set; }

        /// <summary>
        /// The database generated timestamp of when this win probability was first updated.
        /// </summary>
        [Description("The database generated timestamp of when this win probability was first updated.")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The database generated timestamp of when this win probability was last updated.
        /// </summary>
        [Description("The database generated timestamp of when this win probability was last updated.")]
        [DataMember(Name = "Updated", Order = 6)]
        public DateTime? Updated { get; set; }

    }
}

