using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Competition")]
    [Serializable]
    public partial class Competition
    {
        /// <summary>
        /// The unique ID of the competition/league
        /// </summary>
        [Description("The unique ID of the competition/league")]
        [DataMember(Name = "CompetitionId", Order = 1)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// The unique ID of the area where this competition/league is played
        /// </summary>
        [Description("The unique ID of the area where this competition/league is played")]
        [DataMember(Name = "AreaId", Order = 2)]
        public int AreaId { get; set; }

        /// <summary>
        /// The display name of the area where this competition/league is played
        /// </summary>
        [Description("The display name of the area where this competition/league is played")]
        [DataMember(Name = "AreaName", Order = 3)]
        public string AreaName { get; set; }

        /// <summary>
        /// The display name of the competition/league
        /// </summary>
        [Description("The display name of the competition/league")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates the gender of the players on this team (possible values: Make, Female)
        /// </summary>
        [Description("Indicates the gender of the players on this team (possible values: Make, Female)")]
        [DataMember(Name = "Gender", Order = 5)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this competition/league (possible values: Club, International)
        /// </summary>
        [Description("The type of this competition/league (possible values: Club, International)")]
        [DataMember(Name = "Type", Order = 6)]
        public string Type { get; set; }

        /// <summary>
        /// The format of the competition/league (possible values: Domestic League, International Cup)
        /// </summary>
        [Description("The format of the competition/league (possible values: Domestic League, International Cup)")]
        [DataMember(Name = "Format", Order = 7)]
        public string Format { get; set; }

        /// <summary>
        /// The seasons associated with this competition/league
        /// </summary>
        [Description("The seasons associated with this competition/league")]
        [DataMember(Name = "Seasons", Order = 20008)]
        public Season[] Seasons { get; set; }

        /// <summary>
        /// The unique string key of the competition/league
        /// </summary>
        [Description("The unique string key of the competition/league")]
        [DataMember(Name = "Key", Order = 9)]
        public string Key { get; set; }

    }
}

