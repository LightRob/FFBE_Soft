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
        Dark = 0x80,
        Neutral = 0x100
    }

    enum ElementImbue
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

    public enum StatsDebuffed
    {
        ATK = 0x01,
        DEF = 0x02,
        MAG = 0x04,
        PSY = 0x08
    }

    public enum StatsBuffed
    {
        ATK = 0x01,
        DEF = 0x02,
        MAG = 0x04,
        PSY = 0x08
    }

    public struct StatDebuffCoef
    {
        public StatsDebuffed StatsDebuffed;
        public byte Coefficient;
    }

    public struct StatBuffCoef
    {
        public StatsBuffed StatsBuffed;
        public short Coefficient;
    }

    public enum TypeCover
    {
        Physical,
        Magical,
        Hybrid
    }

    class CompEffect
    {
        /// <summary>
        /// Text of the capacity, one string object for one ligne
        /// </summary>
        public string Text { get; set; }


        static public StatDebuffCoef GetDebuffObject(StatsDebuffed stats, byte coeff)
        {
            StatDebuffCoef statDebuffCoef = new StatDebuffCoef
            {
                StatsDebuffed = stats,
                Coefficient = coeff
            };

            return statDebuffCoef;
        }


        static public StatBuffCoef GetBuffObject(StatsBuffed stats, short coeff)
        {
            return new StatBuffCoef
            {
                StatsBuffed = stats,
                Coefficient = coeff
            };
        }

        public void AddHPDrain(byte coeff)
        {
            this.IsHPDrain = true;
            this.CoeffHPDrain = coeff;
        }

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
        /// If the ability drain HP to the enemy
        /// </summary>
        public bool IsHPDrain { get; set; }

        /// <summary>
        /// Coefficient of the HP Drain
        /// </summary>
        public byte CoeffHPDrain { get; set; }

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

        
        public int Hits { get; set; }
        #endregion
        public CompEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, bool isSingleTargetDamage, bool isAreaOfEffectDamage, bool isCasterDamage, int hits)
        {
            this.IsDamage = isDamage; this.TypeDamage = typeDamage; this.ScalingDamage = scalingDamage; this.ElementDamage = elementDamage;
            this.CoeffDamage = coeffDamage; this.IgnoreDefense = ignoreDefense; this.IsSingleTargetDamage = isSingleTargetDamage; this.IsAreaOfEffectDamage = isAreaOfEffectDamage; this.IsCasterDamage = isCasterDamage;
            this.Hits = hits;
        }

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
        public bool IsSingleTargetLimitGauge { get; set; }

        /// <summary>
        /// If the ability is AreaOfEffect
        /// </summary>
        public bool IsAreaOfEffectLimitGauge { get; set; }

        /// <summary>
        /// If the ability target the caster
        /// </summary>
        public bool IsCasterLimitGauge { get; set; }
        #endregion
        public CompEffect(bool isLimitGaugeUp, byte fixedLimitGauge, byte minLimitGauge, byte maxLimitGauge, 
            bool isSingleTargetLimitGauge, bool isAreaOfEffectLimitGauge, bool isCasterLimitGauge)
        {
            this.IsLimitGaugeUp = isLimitGaugeUp; this.FixedLimitGauge = fixedLimitGauge; this.MinLimitGauge = minLimitGauge; this.MaxLimitGauge = maxLimitGauge;
            this.IsSingleTargetLimitGauge = isSingleTargetLimitGauge; this.IsAreaOfEffectLimitGauge = isAreaOfEffectLimitGauge; this.IsCasterLimitGauge = isCasterLimitGauge;
        }

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
        public byte DebuffTurns { get; set; }

        /// <summary>
        /// If the ability is SingleTarget
        /// </summary>
        public bool IsSingleTargetDebuff { get; set; }

        /// <summary>
        /// If the ability is AreaOfEffect
        /// </summary>
        public bool IsAreaOfEffectDebuff { get; set; }
        #endregion
        public CompEffect(bool isDebuffEnemy, List<StatDebuffCoef> statDebuffed, byte turns, bool isSingleTargetDebuff, bool isAreaOfEffectDebuff)
        {
            this.IsDebuffEnemy = isDebuffEnemy; this.StatsDebuffed = statDebuffed; this.DebuffTurns = turns; this.IsSingleTargetDebuff = isSingleTargetDebuff; this.IsAreaOfEffectDebuff = isAreaOfEffectDebuff;
        }

        #region Support Ability - Cover
        /// <summary>
        /// If the ability cover allies
        /// </summary>
        public bool IsCoverAllies { get; set; }

        /// <summary>
        /// Type of the cover
        /// </summary>
        public TypeCover TypeCover { get; set; }

        /// <summary>
        /// Chance to proc the cover
        /// </summary>
        public byte PercentChanceCover { get; set; }

        /// <summary>
        /// Minimum of Damage Mitigation
        /// </summary>
        public byte MinDamageMitigation { get; set; }

        /// <summary>
        /// Maximum of Damage Mitigation
        /// </summary>
        public byte MaxDamageMitigation { get; set; }

        /// <summary>
        /// Number of turns
        /// </summary>
        public byte CoverTurn { get; set; }

        /// <summary>
        /// If the cover is for the caster
        /// </summary>
        public bool IsCasterCover { get; set; }

        /// <summary>
        /// If the cover is for one ally
        /// </summary>
        public bool IsForOneAlly { get; set; }
        #endregion
        public CompEffect(bool isCoverAllies, TypeCover typeCover, byte percentChanceCover, byte minDamageMitigation, byte maxDamageMitigation, byte coverTurn, bool isCasterCover, bool isForOneAlly)
        {
            this.IsCoverAllies = isCoverAllies; this.TypeCover = typeCover; this.PercentChanceCover = percentChanceCover;
            this.MinDamageMitigation = minDamageMitigation; this.MaxDamageMitigation = maxDamageMitigation;
            this.CoverTurn = coverTurn; this.IsCasterCover = isCasterCover; this.IsForOneAlly = isForOneAlly;
        }

        #region Support Ability - Buff Allies
        /// <summary>
        /// If the ability buff allies
        /// </summary>
        public bool IsBuffAlly { get; set; }

        /// <summary>
        /// List of StatsBuffed and coeff
        /// </summary>
        public List<StatBuffCoef> StatsBuffed { get; set; }

        /// <summary>
        /// Number of turn for the buff
        /// </summary>
        public byte BuffTurn { get; set; }

        /// <summary>
        /// If the ability is single target
        /// </summary>
        public bool IsSingleTargetBuff { get; set; }

        /// <summary>
        /// If the ability is area of effect
        /// </summary>
        public bool IsAreaOfEffectBuff { get; set; }

        /// <summary>
        /// If the ability is for the caster
        /// </summary>
        public bool IsCasterBuff { get; set; }
        #endregion
        public CompEffect(bool isBuffAlly, List<StatBuffCoef> statBuffCoeff, byte buffTurn, bool isSingleTargetBuff, bool isAreaOfEffectBuff, bool isCasterBuff)
        {
            this.IsBuffAlly = isBuffAlly; this.StatsBuffed = statBuffCoeff; this.BuffTurn = buffTurn; this.IsSingleTargetBuff = isSingleTargetBuff;
            this.IsAreaOfEffectBuff = isAreaOfEffectBuff; this.IsCasterBuff = isCasterBuff;
        }

        #region Support Ability - Element Imbue
        /// <summary>
        /// If the ability add element to attacks
        /// </summary>
        public bool IsImbueElement { get; set; }

        /// <summary>
        /// Element to imbue
        /// </summary>
        public ElementImbue ElementImbue { get; set; }

        /// <summary>
        /// Number of turns of the imbue
        /// </summary>
        public byte ImbueTurns { get; set; }

        /// <summary>
        /// If the ability is single target
        /// </summary>
        public bool IsSingleTargetImbue { get; set; }

        /// <summary>
        /// If the ability is Area of Effect
        /// </summary>
        public bool IsAreaOfEffectImbue { get; set; }

        /// <summary>
        /// If the ability is for the caster
        /// </summary>
        public bool IsCasterImbue { get; set; }
        #endregion
        public CompEffect(bool isImbueElement, ElementImbue elementImbue, byte imbueTurns, bool isSingleTargetImbue, bool isAreaOfEffectImbue, bool isCasterImbue)
        {
            this.IsImbueElement = isImbueElement; this.ElementImbue = elementImbue; this.ImbueTurns = imbueTurns;
            this.IsSingleTargetImbue = isSingleTargetImbue; this.IsAreaOfEffectImbue = isAreaOfEffectImbue; this.IsCasterImbue = isCasterImbue;
        }
    }
}
