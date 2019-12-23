using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Lol
{
    [DataContract(Namespace="", Name="Champion")]
    [Serializable]
    public partial class Champion
    {
        /// <summary>
        /// The attack of the champion
        /// </summary>
        [Description("The attack of the champion")]
        [DataMember(Name = "Attack", Order = 1)]
        public decimal Attack { get; set; }

        /// <summary>
        /// The defense of the champion
        /// </summary>
        [Description("The defense of the champion")]
        [DataMember(Name = "Defense", Order = 2)]
        public decimal Defense { get; set; }

        /// <summary>
        /// The magic of the champion
        /// </summary>
        [Description("The magic of the champion")]
        [DataMember(Name = "Magic", Order = 3)]
        public decimal Magic { get; set; }

        /// <summary>
        /// The difficulty of the champion
        /// </summary>
        [Description("The difficulty of the champion")]
        [DataMember(Name = "Difficulty", Order = 4)]
        public decimal Difficulty { get; set; }

        /// <summary>
        /// The health points of the champion
        /// </summary>
        [Description("The health points of the champion")]
        [DataMember(Name = "Hp", Order = 5)]
        public decimal Hp { get; set; }

        /// <summary>
        /// The health points gained per level of the champion
        /// </summary>
        [Description("The health points gained per level of the champion")]
        [DataMember(Name = "HpUpPerLevel", Order = 6)]
        public decimal HpUpPerLevel { get; set; }

        /// <summary>
        /// The magic points of the champion
        /// </summary>
        [Description("The magic points of the champion")]
        [DataMember(Name = "Mp", Order = 7)]
        public decimal Mp { get; set; }

        /// <summary>
        /// The magic points gained per level of the champion
        /// </summary>
        [Description("The magic points gained per level of the champion")]
        [DataMember(Name = "MpUpPerLevel", Order = 8)]
        public decimal MpUpPerLevel { get; set; }

        /// <summary>
        /// The move speed of the champion
        /// </summary>
        [Description("The move speed of the champion")]
        [DataMember(Name = "MoveSpeed", Order = 9)]
        public decimal MoveSpeed { get; set; }

        /// <summary>
        /// The armor of the champion
        /// </summary>
        [Description("The armor of the champion")]
        [DataMember(Name = "Armor", Order = 10)]
        public decimal Armor { get; set; }

        /// <summary>
        /// The armor gained per level of the champion
        /// </summary>
        [Description("The armor gained per level of the champion")]
        [DataMember(Name = "ArmorPerLevel", Order = 11)]
        public decimal ArmorPerLevel { get; set; }

        /// <summary>
        /// The spell blocking power of the champion
        /// </summary>
        [Description("The spell blocking power of the champion")]
        [DataMember(Name = "SpellBlock", Order = 12)]
        public decimal SpellBlock { get; set; }

        /// <summary>
        /// The spell blocking power gained per level of the champion
        /// </summary>
        [Description("The spell blocking power gained per level of the champion")]
        [DataMember(Name = "SpellBlockPerLevel", Order = 13)]
        public decimal SpellBlockPerLevel { get; set; }

        /// <summary>
        /// The attack range of the champion
        /// </summary>
        [Description("The attack range of the champion")]
        [DataMember(Name = "AttackRange", Order = 14)]
        public decimal AttackRange { get; set; }

        /// <summary>
        /// The health regeneration of the champion
        /// </summary>
        [Description("The health regeneration of the champion")]
        [DataMember(Name = "HpRegen", Order = 15)]
        public decimal HpRegen { get; set; }

        /// <summary>
        /// The health regeneration gained per level of the champion
        /// </summary>
        [Description("The health regeneration gained per level of the champion")]
        [DataMember(Name = "HpRegenPerLevel", Order = 16)]
        public decimal HpRegenPerLevel { get; set; }

        /// <summary>
        /// The magic regeneration of the champion
        /// </summary>
        [Description("The magic regeneration of the champion")]
        [DataMember(Name = "MpRegen", Order = 17)]
        public decimal MpRegen { get; set; }

        /// <summary>
        /// The magic regeneration gained per level of the champion
        /// </summary>
        [Description("The magic regeneration gained per level of the champion")]
        [DataMember(Name = "MpRegenPerLevel", Order = 18)]
        public decimal MpRegenPerLevel { get; set; }

        /// <summary>
        /// The attack damage of the champion
        /// </summary>
        [Description("The attack damage of the champion")]
        [DataMember(Name = "AttackDamage", Order = 19)]
        public decimal AttackDamage { get; set; }

        /// <summary>
        /// The attack damage gained per level of the champion
        /// </summary>
        [Description("The attack damage gained per level of the champion")]
        [DataMember(Name = "AttackDamagePerLevel", Order = 20)]
        public decimal AttackDamagePerLevel { get; set; }

        /// <summary>
        /// The attack speed of the champion
        /// </summary>
        [Description("The attack speed of the champion")]
        [DataMember(Name = "AttackSpeedOffset", Order = 21)]
        public decimal AttackSpeedOffset { get; set; }

        /// <summary>
        /// The unique id of the champion
        /// </summary>
        [Description("The unique id of the champion")]
        [DataMember(Name = "ChampionId", Order = 22)]
        public int ChampionId { get; set; }

        /// <summary>
        /// The name of the champion
        /// </summary>
        [Description("The name of the champion")]
        [DataMember(Name = "Name", Order = 23)]
        public string Name { get; set; }

        /// <summary>
        /// The title of the champion
        /// </summary>
        [Description("The title of the champion")]
        [DataMember(Name = "Title", Order = 24)]
        public string Title { get; set; }

    }
}

