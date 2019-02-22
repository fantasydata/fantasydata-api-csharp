using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="Item")]
    [Serializable]
    public partial class Item
    {
        /// <summary>
        /// The unique id of the item
        /// </summary>
        [Description("The unique id of the item")]
        [DataMember(Name = "ItemId", Order = 1)]
        public int ItemId { get; set; }

        /// <summary>
        /// The name of the item
        /// </summary>
        [Description("The name of the item")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The base gold of the item
        /// </summary>
        [Description("The base gold of the item")]
        [DataMember(Name = "GoldBase", Order = 3)]
        public int GoldBase { get; set; }

        /// <summary>
        /// The total gold of the item
        /// </summary>
        [Description("The total gold of the item")]
        [DataMember(Name = "GoldTotal", Order = 4)]
        public int GoldTotal { get; set; }

        /// <summary>
        /// The sell price in gold of the item
        /// </summary>
        [Description("The sell price in gold of the item")]
        [DataMember(Name = "GoldSell", Order = 5)]
        public int GoldSell { get; set; }

    }
}

