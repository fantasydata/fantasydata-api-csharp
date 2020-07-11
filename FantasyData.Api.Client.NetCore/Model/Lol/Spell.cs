using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Lol
{
    [DataContract(Namespace="", Name="Spell")]
    [Serializable]
    public partial class Spell
    {
        /// <summary>
        /// The unique id of the spell
        /// </summary>
        [Description("The unique id of the spell")]
        [DataMember(Name = "SpellId", Order = 1)]
        public int SpellId { get; set; }

        /// <summary>
        /// The name of the spell
        /// </summary>
        [Description("The name of the spell")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

