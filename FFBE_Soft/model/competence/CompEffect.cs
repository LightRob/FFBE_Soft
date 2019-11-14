using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    /// <summary>
    /// Damage type
    /// </summary>
    enum TypeDamage
    {
        /// <summary>
        /// Physical damage
        /// </summary>
        Physical,
        /// <summary>
        /// Magical damage
        /// </summary>
        Magical,
        /// <summary>
        /// Hybrid damage (Physical and Magical)
        /// </summary>
        Hybrid,
        /// <summary>
        /// Fixed damage
        /// </summary>
        Fixed,
        /// <summary>
        /// Fixed damage with percent
        /// </summary>
        PercentFixed
    }

    enum ScalingDamage
    {
        HP,
        MP,
        ATK,
        DEF,
        MAG,
        PSY
    }


    enum ElementDamage
    {
        Fire = 0x01,
        Ice = 0x02,
        Lightning = 0x04,
        Water = 0x08,
        Wind = 0x10,
        Earth = 0x20,
        Light = 0x40,
        Dark = 0x80
    }

    enum StatsDebuffed
    {
        ATK = 0x01,
        DEF = 0x02,
        MAG = 0x04,
        PSY = 0x08
    }

    struct StatDebuffCoef
    {
        StatsDebuffed StatsDebuffed;
        byte Coefficient;
    }

    class CompEffect
    {
        /// <summary>
        /// Text of the capacity, one string object for one ligne
        /// </summary>
        public List<string> Text { get; set; }

        #region Damage Ability
        /// <summary>
        /// If the Ability does damage
        /// </summary>
        public bool IsDamage { get; set; }

        /// <summary>
        /// Damage type of the ability
        /// <seealso cref="TypeDamage"/>
        /// </summary>
        public TypeDamage TypeDamage { get; set; }

        /// <summary>
        /// Stat for scaling damage
        /// </summary>
        public ScalingDamage ScalingDamage { get; set; }

        /// <summary>
        /// Element(s) of the ability
        /// </summary>
        public ElementDamage ElementDamage { get; set; }

        /// <summary>
        /// Coefficient of the ability, Percent, or Fixed
        /// </summary>
        public int CoeffDamage { get; set; }

        /// <summary>
        /// Percent of ingore defense. 0 if no ignore defense
        /// </summary>
        public byte IgnoreDefense { get; set; }

        /// <summary>
        /// If the ability is SingleTarget
        /// </summary>
        public bool IsSingleTargetDamage { get; set; }

        /// <summary>
        /// If the ability is AreaOfEffect
        /// </summary>
        public bool IsAreaOfEffectDamage { get; set; }

        /// <summary>
        /// If the ability target the caster
        /// </summary>
        public bool IsCasterDamage { get; set; }
        #endregion

        #region Support Ability - Limit
        /// <summary>
        /// If the ability filled the Limit gauge
        /// </summary>
        public bool IsLimitGaugeUp { get; set; }

        /// <summary>
        /// Fixed number of limit crystal
        /// </summary>
        public byte FixedLimitGauge { get; set; }

        /// <summary>
        /// Minimal number of limit crystal
        /// </summary>
        public byte MinLimitGauge { get; set; }

        /// <summary>
        /// Maximal number of limit crystal
        /// </summary>
        public byte MaxLimitGauge { get; set; }

        /// <summary>
        /// If the ability is SingleTarget
        /// </summary>
        public byte IsSingleTargetLimitGauge { get; set; }

        /// <summary>
        /// If the ability is AreaOfEffect
        /// </summary>
        public byte IsAreaOfEffectLimitGauge { get; set; }

        /// <summary>
        /// If the ability target the caster
        /// </summary>
        public byte IsCasterLimitGauge { get; set; }
        #endregion

        #region Support Ability - Debuff Enemy
        /// <summary>
        /// If the ability debuff enemies
        /// </summary>
        public bool IsDebuffEnemy { get; set; }

        /// <summary>
        /// List of StatsDebuffed and coeff by stats debuffed by the abilities
        /// </summary>
        public List<StatDebuffCoef> StatsDebuffed { get; set; }

        /// <summary>
        /// Numbers of Turns for the debuff
        /// </summary>
        public byte Turns { get; set; }

        /// <summary>
        /// If the ability is SingleTarget
        /// </summary>
        public bool IsSingleTargetDebuff { get; set; }

        /// <summary>
        /// If the ability is AreaOfEffect
        /// </summary>
        public bool IsAreaOfEffectDebuff { get; set; }
        #endregion
    }
}
