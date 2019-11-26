using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    enum AbilityTarget
    {
        SingleTargetAlly = 0x01,
        SingleTargetEnemy = 0x02,
        AreaOfEffectAllies = 0x04,
        AreaOfEffectEnemies = 0x08,
        AreaOfEffectAlliesExceptCaster = 0x10,
        Caster = 0x20
    }

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
    
    enum ElementDebuffed
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

    public enum TypeMitigation
    {
        Physical = 0x01,
        Magical = 0x02,
        Hydrib = 0x04
    }

    public struct HealHPCoeff
    {
        public int BaseHealHP;
        public short Coefficient;
    }

    public struct HealMPCoeff
    {
        public int BaseHealMP;
        public short Coefficient;
    }

    class AbilityEffect
    {
        /// <summary>
        /// Text of the ability
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


        static public HealHPCoeff GetHealHPObject(int heal, short coeff)
        {
            return new HealHPCoeff
            {
                BaseHealHP = heal,
                Coefficient = coeff
            };
        }

        static public HealMPCoeff GetHealMPObject(int heal, short coeff)
        {
            return new HealMPCoeff
            {
                BaseHealMP = heal,
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
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetDamage { get; set; }

        
        public int Hits { get; set; }
        #endregion
        private AbilityEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, AbilityTarget target, int hits)
        {
            this.IsDamage = isDamage; this.TypeDamage = typeDamage; this.ScalingDamage = scalingDamage; this.ElementDamage = elementDamage;
            this.CoeffDamage = coeffDamage; this.IgnoreDefense = ignoreDefense; this.AbilityTargetDamage = target;
            this.Hits = hits;
        }
        static public AbilityEffect CreateDamageEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, AbilityTarget target, int hits)
        {
            return new AbilityEffect(isDamage, typeDamage, scalingDamage, elementDamage,
            coeffDamage, ignoreDefense, target,  hits);
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
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetLimitGauge { get; set; }
        #endregion
        private AbilityEffect(bool isLimitGaugeUp, byte fixedLimitGauge, byte minLimitGauge, byte maxLimitGauge, 
            AbilityTarget target)
        {
            this.IsLimitGaugeUp = isLimitGaugeUp; this.FixedLimitGauge = fixedLimitGauge; this.MinLimitGauge = minLimitGauge; this.MaxLimitGauge = maxLimitGauge;
            this.AbilityTargetLimitGauge = target;
        }
        static public AbilityEffect CreateLimitGaugeEffect (bool isLimitGaugeUp, byte fixedLimitGauge, byte minLimitGauge, byte maxLimitGauge,
            AbilityTarget target)
        {
            return new AbilityEffect(isLimitGaugeUp, fixedLimitGauge, minLimitGauge, maxLimitGauge,
            target);
        }


        #region Support Ability - Debuff Stats
        /// <summary>
        /// If the ability debuff stats
        /// </summary>
        public bool IsDebuffStats { get; set; }

        /// <summary>
        /// List of StatsDebuffed and coeff by stats debuffed by the abilities
        /// </summary>
        public List<StatDebuffCoef> StatsDebuffed { get; set; }

        /// <summary>
        /// Numbers of Turns for the debuff
        /// </summary>
        public byte DebuffStatsTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetDebuff { get; set; }
        #endregion
        private AbilityEffect(bool isDebuffEnemy, List<StatDebuffCoef> statDebuffed, byte turns, AbilityTarget target)
        {
            this.IsDebuffStats = isDebuffEnemy; this.StatsDebuffed = statDebuffed; this.DebuffStatsTurns = turns; this.AbilityTargetDebuff = target;
        }
        static public AbilityEffect CreateDebuffEnemyEffect(bool isDebuffEnemy, List<StatDebuffCoef> statDebuffed, byte turns, AbilityTarget target)
        {
            return new AbilityEffect(isDebuffEnemy, statDebuffed, turns, target);
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
        private AbilityEffect(bool isCoverAllies, TypeCover typeCover, byte percentChanceCover, byte minDamageMitigation, byte maxDamageMitigation, byte coverTurn, bool isCasterCover, bool isForOneAlly)
        {
            this.IsCoverAllies = isCoverAllies; this.TypeCover = typeCover; this.PercentChanceCover = percentChanceCover;
            this.MinDamageMitigation = minDamageMitigation; this.MaxDamageMitigation = maxDamageMitigation;
            this.CoverTurn = coverTurn; this.IsCasterCover = isCasterCover; this.IsForOneAlly = isForOneAlly;
        }
        static public AbilityEffect CreateCoverEffect(bool isCoverAllies, TypeCover typeCover, byte percentChanceCover, byte minDamageMitigation, byte maxDamageMitigation, byte coverTurn, bool isCasterCover, bool isForOneAlly)
        {
            return new AbilityEffect(isCoverAllies, typeCover, percentChanceCover, minDamageMitigation, maxDamageMitigation, coverTurn, isCasterCover, isForOneAlly);
        }


        #region Support Ability - Taunt
        /// <summary>
        /// If the ability give taunt buff
        /// </summary>
        public bool IsTaunt { get; set; }

        /// <summary>
        /// Chance to be targeted
        /// </summary>
        public byte TauntChance { get; set; }

        /// <summary>
        /// Number of tunrns
        /// </summary>
        public byte TauntTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetTaunt { get; set; }
        #endregion
        private AbilityEffect(bool isTaunt, byte tauntChance, byte tauntTurns, AbilityTarget target)
        {
            this.IsTaunt = isTaunt; this.TauntChance = tauntChance; this.TauntTurns = tauntTurns;
            this.AbilityTargetTaunt = target;
        }
        static public AbilityEffect CreateTauntEffect(bool isTaunt, byte tauntChance, byte tauntTurns, AbilityTarget target)
        {
            return new AbilityEffect(isTaunt, tauntChance, tauntTurns, target);
        }


        #region Support Ability - Mitigation
        /// <summary>
        /// If the ability give damage mitigation
        /// </summary>
        public bool IsMitigation { get; set; }

        /// <summary>
        /// Type of the damage mitigation
        /// </summary>
        public TypeMitigation TypeMitigation { get; set; }

        /// <summary>
        /// Percent of the damage mitigation
        /// </summary>
        public byte PercentMitigation { get; set; }

        /// <summary>
        /// Number of turns
        /// </summary>
        public byte MitigationTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetMitigation { get; set; }
        #endregion
        private AbilityEffect(bool isMitigation, TypeMitigation typeMitigation, byte percentMitigation, byte mitigationTurns, AbilityTarget target)
        {
            this.IsMitigation = isMitigation; this.TypeMitigation = typeMitigation; this.PercentMitigation = percentMitigation; this.MitigationTurns = mitigationTurns;
            this.AbilityTargetMitigation = target;
        }
        static public AbilityEffect CreateMitigationEffect(bool isMitigation, TypeMitigation typeMitigation, byte percentMitigation, byte mitigationTurns, AbilityTarget target)
        {
            return new AbilityEffect(isMitigation, typeMitigation, percentMitigation, mitigationTurns, target);
        }


        #region Support Ability - Buff Stats
        /// <summary>
        /// If the ability buff stats
        /// </summary>
        public bool IsBuffStats { get; set; }

        /// <summary>
        /// List of StatsBuffed and coeff
        /// </summary>
        public List<StatBuffCoef> StatsBuffed { get; set; }

        /// <summary>
        /// Number of turn for the buff
        /// </summary>
        public byte BuffStatsTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetBuffStats { get; set; }
        #endregion
        private AbilityEffect(bool isBuffAlly, List<StatBuffCoef> statBuffCoeff, byte buffTurn, AbilityTarget target)
        {
            this.IsBuffStats = isBuffAlly; this.StatsBuffed = statBuffCoeff; this.BuffStatsTurns = buffTurn; this.AbilityTargetBuffStats = target;
        }
        static public AbilityEffect CreateBuffAlliesEffect(bool isBuffAlly, List<StatBuffCoef> statBuffCoeff, byte buffTurn, AbilityTarget target)
        {
            return new AbilityEffect(isBuffAlly, statBuffCoeff, buffTurn, target);
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
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetElementImbue { get; set; }
        #endregion
        private AbilityEffect(bool isImbueElement, ElementImbue elementImbue, byte imbueTurns, AbilityTarget target)
        {
            this.IsImbueElement = isImbueElement; this.ElementImbue = elementImbue; this.ImbueTurns = imbueTurns;
            this.AbilityTargetElementImbue = target;
        }
        static public AbilityEffect CreateElementImbueEffect (bool isImbueElement, ElementImbue elementImbue, byte imbueTurns, AbilityTarget target)
        {
            return new AbilityEffect(isImbueElement, elementImbue, imbueTurns, target);
        }


        #region Support Ability - Heal HP
        /// <summary>
        /// If the ability heal HP
        /// </summary>
        public bool IsHealHP { get; set; }

        /// <summary>
        /// Number of fixed HP Heal
        /// </summary>
        public int FixedHPHeal { get; set; }

        /// <summary>
        /// Stats to calcul HP Heal
        /// </summary>
        public HealHPCoeff HealHPCoeff { get; set; }

        /// <summary>
        /// Percent of the heal
        /// </summary>
        public byte PercentHealHP { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetHealHP { get; set; }
        #endregion
        private AbilityEffect(bool isHealHP, int fixedHPHeal, HealHPCoeff coeff, byte percentHealHP, AbilityTarget target)
        {
            this.IsHealHP = isHealHP; this.FixedHPHeal = fixedHPHeal; this.HealHPCoeff = coeff; this.PercentHealHP = percentHealHP;
            this.AbilityTargetHealHP = target;
        }
        static public AbilityEffect CreateHealHPEffect(bool isHealHP, int fixedHPHeal, HealHPCoeff coeff, byte percentHealHP, AbilityTarget target)
        {
            return new AbilityEffect(isHealHP, fixedHPHeal, coeff, percentHealHP, target);
        }
        public void AddHealHPToAbility(bool isHealHP, int fixedHPHeal, HealHPCoeff coeff, byte percentHealHP, AbilityTarget target)
        {
            this.IsHealHP = isHealHP; this.FixedHPHeal = fixedHPHeal; this.HealHPCoeff = coeff; this.PercentHealHP = percentHealHP;
            this.AbilityTargetHealHP = target;
        }


        #region Support Ability - Heal MP
        /// <summary>
        /// If the ability heal MP
        /// </summary>
        public bool IsHealMP { get; set; }

        /// <summary>
        /// Number of fixed MP Heal
        /// </summary>
        public int FixedMPHeal { get; set; }

        /// <summary>
        /// Stats to calcul MP Heal
        /// </summary>
        public HealMPCoeff HealMPCoeff { get; set; }

        /// <summary>
        /// Percent of the heal
        /// </summary>
        public byte PercentHealMP { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetHealMP { get; set; }
        #endregion
        private AbilityEffect(bool isHealMP, int fixedMPHeal, HealMPCoeff coeff, byte percentHealMP, AbilityTarget target)
        {
            this.IsHealMP = isHealMP; this.FixedMPHeal = fixedMPHeal; this.HealMPCoeff = coeff; this.PercentHealMP = percentHealMP;
            this.AbilityTargetHealMP = target;
        }
        static public AbilityEffect CreateHealMPEffect (bool isHealMP, int fixedMPHeal, HealMPCoeff coeff, byte percentHealMP, AbilityTarget target)
        {
            return new AbilityEffect(isHealMP, fixedMPHeal, coeff, percentHealMP, target);
        }
        public void AddHealMPToAbility(bool isHealMP, int fixedMPHeal, HealMPCoeff coeff, byte percentHealMP, AbilityTarget target)
        {
            this.IsHealMP = isHealMP; this.FixedMPHeal = fixedMPHeal; this.HealMPCoeff = coeff; this.PercentHealMP = percentHealMP;
            this.AbilityTargetHealMP = target;
        }


        #region Support Ability - Debuff Element
        /// <summary>
        /// If the ability decrease an element
        /// </summary>
        public bool IsDebuffElement { get; set; }

        /// <summary>
        /// The element debuffed
        /// </summary>
        public ElementDebuffed ElementDebuffed { get; set; }
        
        /// <summary>
        /// Percent of the debuffed element
        /// </summary>
        public short PercentElementDebuffed { get; set; }

        /// <summary>
        /// Number of turns
        /// </summary>
        public byte ElementDebuffedTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetDebuffElement { get; set; }
        #endregion
        private AbilityEffect(bool isDebuffElement, ElementDebuffed elementDebuffed, short percentElementDebuffed, byte  elementDebuffedTurns, AbilityTarget target)
        {
            this.IsDebuffElement = isDebuffElement; this.ElementDebuffed = elementDebuffed; this.PercentElementDebuffed = percentElementDebuffed; this.ElementDebuffedTurns = elementDebuffedTurns;
            this.AbilityTargetDebuffElement = target;
        }
        static public AbilityEffect CreateDebuffElementEffect(bool isDebuffElement, ElementDebuffed elementDebuffed, short percentElementDebuffed, byte elementDebuffedTurns, AbilityTarget target)
        {
            return new AbilityEffect(isDebuffElement, elementDebuffed, percentElementDebuffed,  elementDebuffedTurns, target);
        }


        #region Special Ability - Multiple Skill
        /// <summary>
        /// If the ability can cast multiple skills
        /// </summary>
        public bool IsMultipleSkill { get; set; }

        /// <summary>
        /// Number of the multiple
        /// </summary>
        public byte NumberOfMultiple { get; set; }

        /// <summary>
        /// List of they abilities to multiple skill
        /// </summary>
        public List<UnitAbility> AbilitiesMultipleSkill { get; set; }
        #endregion
        private AbilityEffect(bool isMultipleSkill, byte numberOfMultiple, List<UnitAbility> abilitiesMultipleSkill)
        {
            this.IsMultipleSkill = isMultipleSkill; this.NumberOfMultiple = numberOfMultiple; this.AbilitiesMultipleSkill = abilitiesMultipleSkill;
        }
        static public AbilityEffect CreateMultipleSkillEffect(bool isMultipleSkill, byte numberOfMultiple, List<UnitAbility> abilitiesMultipleSkill)
        {
            return new AbilityEffect(isMultipleSkill, numberOfMultiple, abilitiesMultipleSkill);
        }


        #region Special Ability - Ability Coeff Up
        /// <summary>
        /// If the ability buff the coefficient of abilities
        /// </summary>
        public bool IsAbilityCoeffUp { get; set; }

        /// <summary>
        /// The coeff to add to abilities
        /// </summary>
        public short AbilityCoeffUp { get; set; }

        /// <summary>
        /// List of abilities
        /// </summary>
        public List<UnitAbility> AbilitiesUp { get; set; }

        /// <summary>
        /// Numbers of turns
        /// </summary>
        public byte AbilityCoeffUpTurns { get; set; }

        /// <summary>
        /// If the buff can be dispel
        /// </summary>
        public bool AbilityUpCanBeDispel { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetAbilityUp { get; set; }
        #endregion
        private AbilityEffect(bool isAbilityCoeffUp, short abilityCoeffUp, List<UnitAbility> abilites, byte abilityCoeffUpTurns, bool abilityUpCanBeDispel, AbilityTarget target)
        {
            this.IsAbilityCoeffUp = isAbilityCoeffUp; this.AbilityCoeffUp = abilityCoeffUp; this.AbilitiesUp = abilites; this.AbilityCoeffUpTurns = abilityCoeffUpTurns; this.AbilityUpCanBeDispel = abilityUpCanBeDispel;
            this.AbilityTargetAbilityUp = target;
        }
        static public AbilityEffect CreateAbilityCoeffUpEffect(bool isAbilityCoeffUp, short abilityCoeffUp, List<UnitAbility> abilites, byte abilityCoeffUpTurns, bool abilityUpCanBeDispel, AbilityTarget target)
        {
            return new AbilityEffect(isAbilityCoeffUp, abilityCoeffUp, abilites, abilityCoeffUpTurns, abilityUpCanBeDispel, target);
        }


        #region Special Ability - Give Ability
        /// <summary>
        /// If the ability give ability
        /// </summary>
        public bool IsGiveAbility { get; set; }

        /// <summary>
        /// List of abilities given
        /// </summary>
        public List<UnitAbility> NewAbilitiesGiven { get; set; }

        /// <summary>
        /// Number of turns
        /// </summary>
        public byte GiveAbilityTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetGiveAbility { get; set; }
        #endregion
        private AbilityEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, AbilityTarget target)
        {
            this.IsGiveAbility = isGiveAbility; this.NewAbilitiesGiven = newAbilities; this.GiveAbilityTurns = giveAbilityTurns; this.AbilityTargetGiveAbility = target;
        }
        static public AbilityEffect CreateGiveAbilityEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, AbilityTarget target)
        {
            return new AbilityEffect(isGiveAbility, newAbilities, giveAbilityTurns, target);
        }


        #region Special Ability - Cooldown
        /// <summary>
        /// If the ability is a Cooldown ability
        /// </summary>
        public bool IsCooldown { get; set; }

        /// <summary>
        /// Number of turns of the cooldown
        /// </summary>
        public byte CooldownTunrs { get; set; }

        /// <summary>
        /// If the ability is available on turn 1
        /// </summary>
        public bool IsAvailableTurn1 { get; set; }
        #endregion
        private AbilityEffect(bool isCooldown, byte cooldownTurns, bool isAvailableTurn1)
        {
            this.IsCooldown = isCooldown; this.CooldownTunrs = cooldownTurns; this.IsAbilityCoeffUp = isAvailableTurn1;
        }
        static public AbilityEffect CreateCooldownEffect(bool isCooldown, byte cooldownTurns, bool isAvailableTurn1)
        {
            return new AbilityEffect(isCooldown, cooldownTurns, isAvailableTurn1);
        }

    }

}
