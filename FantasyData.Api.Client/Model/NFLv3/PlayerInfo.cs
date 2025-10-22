using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The unique PlayerID of the player as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL
        /// </summary>
        [Description("The unique ID of the team that the player is on. Note: If the player is a free agent; this field is NULL")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR
        /// </summary>
        [Description("The primary position of the player. Possible Values: C; CB; DB; DE; DL; DT; FB; FS; G; ILB; K; KR; LB; LS; NT; OL; OLB; OT; P; QB; RB; S; SS; T; TE; WR")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

    }
}

