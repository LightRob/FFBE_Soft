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

    class AbilityEffect
    {
        /// <summary>
        /// Text of the ability
        /// </summary>
        public string Text { get; set; }



        #region Damage Ability 

        #region Propriétés
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
        /// Max time need to max le ability damage
        /// </summary>
        public byte TimesMaxConsecutive { get; set; }

        /// <summary>
        /// Coeff to ad at each ability
        /// </summary>
        public short CoeffEachConsecutive { get; set; }

        /// <summary>
        /// Max coeff to the ability
        /// </summary>
        public short MaxCoeffConsecutive { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetDamage { get; set; }


        public int Hits { get; set; }
        #endregion

        #region Methodes
        private AbilityEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, AbilityTarget target, int hits)
        {
            this.IsDamage = isDamage; this.TypeDamage = typeDamage; this.ScalingDamage = scalingDamage; this.ElementDamage = elementDamage;
            this.CoeffDamage = coeffDamage; this.IgnoreDefense = ignoreDefense; this.AbilityTargetDamage = target;
            this.Hits = hits;

            EditTextForDamageAbility();
        }
        static public AbilityEffect CreateDamageEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, AbilityTarget target, int hits)
        {
            return new AbilityEffect(isDamage, typeDamage, scalingDamage, elementDamage,
            coeffDamage, ignoreDefense, target, hits);
        }
        private void EditTextForDamageAbility()
        {
            // Text initialisation
            if (this.ElementDamage != ElementDamage.Neutral)
                Text = ElementDamage.ToString() + " " + TypeDamage.ToString().ToLower();
            else
                Text = TypeDamage.ToString();

            Text += " damage (" + this.CoeffDamage.ToString();

            if (TypeDamage == TypeDamage.Fixed)
            {
                Text += ") ";
            }
            else
                Text += "%) ";

            if (this.IgnoreDefense > 0)
            {
                Text += "with ignore DEF (" + IgnoreDefense + "%) ";
            }

            if (this.IsHPDrain)
            {
                Text += "as HP drain (" + CoeffHPDrain + "%) ";
            }

            if(TimesMaxConsecutive > 0)
            {
                Text += "with consecutive increase (" + TimesMaxConsecutive + "times, " + CoeffEachConsecutive + " each, " + MaxCoeffConsecutive + " max) ";
            }

            switch (AbilityTargetDamage)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        public void AddHPDrain(byte coeff)
        {
            this.IsHPDrain = true;
            this.CoeffHPDrain = coeff;

            EditTextForDamageAbility();
        }
        public void AddConsecutive(byte timesMaxConsecutive, short coeffEachConsecutive, short maxCoeffConsecutive)
        {
            this.TimesMaxConsecutive = timesMaxConsecutive; this.CoeffEachConsecutive = coeffEachConsecutive; this.MaxCoeffConsecutive = maxCoeffConsecutive;

            EditTextForDamageAbility();
        }
        #endregion

        #endregion



        #region Support Ability - Limit

        #region Propriétés
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

        #region Methodes

        private AbilityEffect(bool isLimitGaugeUp, byte fixedLimitGauge, byte minLimitGauge, byte maxLimitGauge, 
            AbilityTarget target)
        {
            this.IsLimitGaugeUp = isLimitGaugeUp; this.FixedLimitGauge = fixedLimitGauge; this.MinLimitGauge = minLimitGauge; this.MaxLimitGauge = maxLimitGauge;
            this.AbilityTargetLimitGauge = target;

            EditTextForLimitAbility();
        }
        static public AbilityEffect CreateLimitGaugeEffect (bool isLimitGaugeUp, byte fixedLimitGauge, byte minLimitGauge, byte maxLimitGauge,
            AbilityTarget target)
        {
            return new AbilityEffect(isLimitGaugeUp, fixedLimitGauge, minLimitGauge, maxLimitGauge,
            target);
        }

        private void EditTextForLimitAbility()
        {
            // Text initialisation
            Text = "Increse LB gauge ";
            if (FixedLimitGauge > 0)
                Text += "(" + FixedLimitGauge + ") ";
            else
                Text += "(" + MinLimitGauge + " - " + MaxLimitGauge + ") ";

            switch (AbilityTargetLimitGauge)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }

        #endregion

        #endregion



        #region Support Ability - Debuff Stats

        #region Proriétés
        /// <summary>
        /// If the ability debuff stats
        /// </summary>
        public bool IsDebuffStats { get; set; }

        /// <summary>
        /// List of StatsDebuffed and coeff by stats debuffed by the abilities
        /// </summary>
        public StatsDebuffed StatsDebuffed { get; set; }

        /// <summary>
        /// Coefficient of debuff
        /// </summary>
        public byte CoefficientDebuffedStats { get; set; }

        /// <summary>
        /// Numbers of Turns for the debuff
        /// </summary>
        public byte DebuffStatsTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetDebuff { get; set; }

        #endregion

        #region Methodes
        private AbilityEffect(bool isDebuffEnemy, StatsDebuffed statDebuffed, byte coeff, byte turns, AbilityTarget target)
        {
            this.IsDebuffStats = isDebuffEnemy; this.StatsDebuffed = statDebuffed; this.CoefficientDebuffedStats = coeff; this.DebuffStatsTurns = turns; this.AbilityTargetDebuff = target;
            EditTextForDebuffStatsAbility();
        }
        static public AbilityEffect CreateDebuffEnemyEffect(bool isDebuffEnemy, StatsDebuffed statDebuffed, byte coeff, byte turns, AbilityTarget target)
        {
            return new AbilityEffect(isDebuffEnemy, statDebuffed, coeff, turns, target);
        }
        private void EditTextForDebuffStatsAbility()
        {
            // Text initialisation
            Text = "Decrease ";

            StatsDebuffed t = this.StatsDebuffed;

            List<string> lt = new List<string>();

            if ((t - StatsDebuffed.PSY) >= 0) { lt.Add(StatsDebuffed.PSY.ToString() + "/"); t -= StatsDebuffed.PSY; }
            if ((t - StatsDebuffed.MAG) >= 0) { lt.Add(StatsDebuffed.MAG.ToString() + "/"); t -= StatsDebuffed.MAG; }
            if ((t - StatsDebuffed.DEF) >= 0) { lt.Add(StatsDebuffed.DEF.ToString() + "/"); t -= StatsDebuffed.DEF; }
            if ((t - StatsDebuffed.ATK) >= 0) { lt.Add(StatsDebuffed.ATK.ToString() + "/"); t -= StatsDebuffed.ATK; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1);

            Text += " (" + CoefficientDebuffedStats + "%) for " + DebuffStatsTurns;
            if (DebuffStatsTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetDebuff)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Cover

        #region Propriétés
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
        /// Percent of damage mitigation
        /// </summary>
        public byte FixedDamageMitigation { get; set; }

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
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetCover { get; set; }
        #endregion

        #region Methodes
        private AbilityEffect(bool isCoverAllies, TypeCover typeCover, byte percentChanceCover, byte percentDamageMitigation, byte minDamageMitigation, byte maxDamageMitigation, byte coverTurn, AbilityTarget target)
        {
            this.IsCoverAllies = isCoverAllies; this.TypeCover = typeCover; this.PercentChanceCover = percentChanceCover;
            this.FixedDamageMitigation = percentDamageMitigation; this.MinDamageMitigation = minDamageMitigation; this.MaxDamageMitigation = maxDamageMitigation;
            this.CoverTurn = coverTurn; this.AbilityTargetCover = target;

            EditTextForCoverAbility();
        }

        static public AbilityEffect CreateCoverEffect(bool isCoverAllies, TypeCover typeCover, byte percentChanceCover, byte percentDamageMitigation, byte minDamageMitigation, byte maxDamageMitigation, byte coverTurn, AbilityTarget target)
        {
            return new AbilityEffect(isCoverAllies, typeCover, percentChanceCover, percentDamageMitigation, minDamageMitigation, maxDamageMitigation, coverTurn, target);
        }

        private void EditTextForCoverAbility()
        {
            // Text initialisation
            Text = "Chance to protect all allies form " + TypeCover.ToString().ToLower() + " damage (" + PercentChanceCover + "%) with damage mitigation ";
            if (FixedDamageMitigation > 0)
                Text += "(" + FixedDamageMitigation + "%) ";
            else
                Text += "(" + MinDamageMitigation + " - " + MaxDamageMitigation + "%) ";
            Text += "for " + CoverTurn;

            if (CoverTurn == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetCover)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Taunt

        #region Propriétés
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

        #region Methodes
        private AbilityEffect(bool isTaunt, byte tauntChance, byte tauntTurns, AbilityTarget target)
        {
            this.IsTaunt = isTaunt; this.TauntChance = tauntChance; this.TauntTurns = tauntTurns;
            this.AbilityTargetTaunt = target;

            EditTextForTauntAbility();
        }
        static public AbilityEffect CreateTauntEffect(bool isTaunt, byte tauntChance, byte tauntTurns, AbilityTarget target)
        {
            return new AbilityEffect(isTaunt, tauntChance, tauntTurns, target);
        }

        private void EditTextForTauntAbility()
        {
            // Text initialisation
            Text = "Increase chance of being targeted (" + TauntChance + "%) ";

            Text += "for " + TauntTurns;

            if (TauntTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetTaunt)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Mitigation

        #region Propriétés
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

        #region Methodes
        private AbilityEffect(bool isMitigation, TypeMitigation typeMitigation, byte percentMitigation, byte mitigationTurns, AbilityTarget target)
        {
            this.IsMitigation = isMitigation; this.TypeMitigation = typeMitigation; this.PercentMitigation = percentMitigation; this.MitigationTurns = mitigationTurns;
            this.AbilityTargetMitigation = target;

            EditTextForMitigationAbility();
        }
        static public AbilityEffect CreateMitigationEffect(bool isMitigation, TypeMitigation typeMitigation, byte percentMitigation, byte mitigationTurns, AbilityTarget target)
        {
            return new AbilityEffect(isMitigation, typeMitigation, percentMitigation, mitigationTurns, target);
        }

        private void EditTextForMitigationAbility()
        {
            // Text initialisation
            Text = "Mitigate " + TypeMitigation.ToString().ToLower() + " damage taken (" + PercentMitigation + "%) ";

            Text += "for " + MitigationTurns;

            if (MitigationTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetMitigation)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Buff Stats

        #region Propriétés
        /// <summary>
        /// If the ability buff stats
        /// </summary>
        public bool IsBuffStats { get; set; }

        /// <summary>
        /// List of StatsBuffed and coeff
        /// </summary>
        public StatsBuffed StatsBuffed { get; set; }

        /// <summary>
        /// Coefficient of the buffs
        /// </summary>
        public short CoefficientBuffedStats { get; set; }

        /// <summary>
        /// Number of turn for the buff
        /// </summary>
        public byte BuffStatsTurns { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetBuffStats { get; set; }
        #endregion

        #region Methodes
        private AbilityEffect(bool isBuffAlly, StatsBuffed statBuffCoeff, short coefficientBuffedStats, byte buffTurn, AbilityTarget target)
        {
            this.IsBuffStats = isBuffAlly; this.StatsBuffed = statBuffCoeff; this.CoefficientBuffedStats = coefficientBuffedStats; this.BuffStatsTurns = buffTurn; this.AbilityTargetBuffStats = target;

            EditTextForBuffStatsAbility();
        }
        static public AbilityEffect CreateBuffAlliesEffect(bool isBuffAlly, StatsBuffed statBuffCoeff, short coefficientBuffedStats, byte buffTurn, AbilityTarget target)
        {
            return new AbilityEffect(isBuffAlly, statBuffCoeff, coefficientBuffedStats, buffTurn, target);
        }

        private void EditTextForBuffStatsAbility()
        {
            // Text initialisation
            Text = "Increase ";

            StatsBuffed t = this.StatsBuffed;

            List<string> lt = new List<string>();

            if ((t - StatsBuffed.PSY) >= 0) { lt.Add(StatsBuffed.PSY.ToString() + "/"); t -= StatsBuffed.PSY; }
            if ((t - StatsBuffed.MAG) >= 0) { lt.Add(StatsBuffed.MAG.ToString() + "/"); t -= StatsBuffed.MAG; }
            if ((t - StatsBuffed.DEF) >= 0) { lt.Add(StatsBuffed.DEF.ToString() + "/"); t -= StatsBuffed.DEF; }
            if ((t - StatsBuffed.ATK) >= 0) { lt.Add(StatsBuffed.ATK.ToString() + "/"); t -= StatsBuffed.ATK; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1);

            Text += " (" + CoefficientBuffedStats + "%) for " + BuffStatsTurns;
            if (BuffStatsTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetBuffStats)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion




        #region Support Ability - Element Imbue

        #region Propriétés
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

        #region Methodes
        private AbilityEffect(bool isImbueElement, ElementImbue elementImbue, byte imbueTurns, AbilityTarget target)
        {
            this.IsImbueElement = isImbueElement; this.ElementImbue = elementImbue; this.ImbueTurns = imbueTurns;
            this.AbilityTargetElementImbue = target;

            EditTextForElementImbueAbility();
        }
        static public AbilityEffect CreateElementImbueEffect(bool isImbueElement, ElementImbue elementImbue, byte imbueTurns, AbilityTarget target)
        {
            return new AbilityEffect(isImbueElement, elementImbue, imbueTurns, target);
        }
        private void EditTextForElementImbueAbility()
        {
            // Text initialisation
            Text = "Add " + ElementImbue.ToString().ToLower() + " element to physical attacks ";

            Text += "for " + ImbueTurns;

            if (ImbueTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetElementImbue)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Heal HP

        #region Propriétés
        /// <summary>
        /// If the ability heal HP
        /// </summary>
        public bool IsHealHP { get; set; }

        /// <summary>
        /// Number of fixed HP Heal
        /// </summary>
        public int FixedHPHeal { get; set; }

        /// <summary>
        /// Base to calcul HP Heal
        /// </summary>
        public int BaseHPHeal { get; set; }

        /// <summary>
        /// Coefficient of the heal
        /// </summary>
        public short CoeffHPHeal { get; set; }

        /// <summary>
        /// Percent of the heal
        /// </summary>
        public byte PercentHealHP { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetHealHP { get; set; }
        #endregion

        #region Methodes
        private AbilityEffect(bool isHealHP, int fixedHPHeal, int baseHPHeal, short coeff, byte percentHealHP, AbilityTarget target)
        {
            this.IsHealHP = isHealHP; this.FixedHPHeal = fixedHPHeal; this.BaseHPHeal = baseHPHeal;  this.CoeffHPHeal = coeff; this.PercentHealHP = percentHealHP;
            this.AbilityTargetHealHP = target;

            EditTextForHealHPAbility();
        }
        static public AbilityEffect CreateHealHPEffect(bool isHealHP, int fixedHPHeal, int baseHPHeal, short coeff, byte percentHealHP, AbilityTarget target)
        {
            return new AbilityEffect(isHealHP, fixedHPHeal, baseHPHeal, coeff, percentHealHP, target);
        }
        private void EditTextForHealHPAbility()
        {
            // Text initialisation
            Text = "Restore HP (";

            if(FixedHPHeal > 0)
            {
                Text += FixedHPHeal.ToString() + ") ";
            }
            if(CoeffHPHeal > 0)
            {
                Text += BaseHPHeal + " HP, " + CoeffHPHeal + "%) ";
            }
            if(PercentHealHP > 0)
            {
                Text += PercentHealHP + "%) ";
            }

            switch (AbilityTargetHealHP)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        public void AddHealHPToAbility(bool isHealHP, int fixedHPHeal, int baseHPHeal, short coeff, byte percentHealHP, AbilityTarget target)
        {
            this.IsHealHP = isHealHP; this.FixedHPHeal = fixedHPHeal; this.BaseHPHeal = baseHPHeal; this.CoeffHPHeal = coeff; this.PercentHealHP = percentHealHP;
            this.AbilityTargetHealHP = target;

            EditTextForHealHPMPAbility();
        }
        #endregion

        #endregion


        private void EditTextForHealHPMPAbility()
        {
            // Text initialisation
            Text = "Restore HP (";

            if (FixedHPHeal > 0)
            {
                Text += FixedHPHeal.ToString() + ") ";
            }
            if (CoeffHPHeal > 0)
            {
                Text += BaseHPHeal + " HP, " + CoeffHPHeal + "%) ";
            }
            if (PercentHealHP > 0)
            {
                Text += PercentHealHP + "%) ";
            }

            Text += "and MP (";

            if (FixedMPHeal > 0)
            {
                Text += FixedMPHeal.ToString() + ") ";
            }
            if (CoeffMPHeal > 0)
            {
                Text += BaseMPHeal + " MP, " + CoeffMPHeal + "%) ";
            }
            if (PercentHealMP > 0)
            {
                Text += PercentHealMP + "%) ";
            }

            switch (AbilityTargetHealHP)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }


        #region Support Ability - Heal MP

        #region Propriétés
        /// <summary>
        /// If the ability heal MP
        /// </summary>
        public bool IsHealMP { get; set; }

        /// <summary>
        /// Number of fixed MP Heal
        /// </summary>
        public int FixedMPHeal { get; set; }

        /// <summary>
        /// Base to calcul MP Heal
        /// </summary>
        public int BaseMPHeal { get; set; }

        /// <summary>
        /// Coefficient of the heal
        /// </summary>
        public short CoeffMPHeal { get; set; }

        /// <summary>
        /// Percent of the heal
        /// </summary>
        public byte PercentHealMP { get; set; }

        /// <summary>
        /// Target of the ability
        /// </summary>
        public AbilityTarget AbilityTargetHealMP { get; set; }
        #endregion

        #region Méthodes
        private AbilityEffect(bool isHealMP, int fixedMPHeal, int baseMPHeal, short coeff, byte percentHealMP, AbilityTarget target, bool mp)
        {
            this.IsHealMP = isHealMP; this.FixedMPHeal = fixedMPHeal; BaseMPHeal = baseMPHeal; this.CoeffMPHeal = coeff; this.PercentHealMP = percentHealMP;
            this.AbilityTargetHealMP = target;

            EditTextForHealMPAbility();
        }
        static public AbilityEffect CreateHealMPEffect(bool isHealMP, int fixedMPHeal, int baseMPHeal, short coeff, byte percentHealMP, AbilityTarget target)
        {
            return new AbilityEffect(isHealMP, fixedMPHeal, baseMPHeal, coeff, percentHealMP, target, true);
        }
        public void AddHealMPToAbility(bool isHealMP, int fixedMPHeal, int baseMPHeal, short coeff, byte percentHealMP, AbilityTarget target)
        {
            this.IsHealMP = isHealMP; this.FixedMPHeal = fixedMPHeal; BaseMPHeal = baseMPHeal; this.CoeffMPHeal = coeff; this.PercentHealMP = percentHealMP;
            this.AbilityTargetHealMP = target;

            EditTextForHealHPMPAbility();
        }
        private void EditTextForHealMPAbility()
        {
            // Text initialisation
            Text = "Restore MP (";

            if (FixedMPHeal > 0)
            {
                Text += FixedMPHeal.ToString() + ") ";
            }
            if (CoeffMPHeal > 0)
            {
                Text += BaseMPHeal + " MP, " + CoeffMPHeal + "%) ";
            }
            if (PercentHealMP > 0)
            {
                Text += PercentHealMP + "%) ";
            }

            switch (AbilityTargetHealMP)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Debuff Element

        #region Propriétés
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

        #region Méthodes
        private AbilityEffect(bool isDebuffElement, ElementDebuffed elementDebuffed, short percentElementDebuffed, byte elementDebuffedTurns, AbilityTarget target)
        {
            this.IsDebuffElement = isDebuffElement; this.ElementDebuffed = elementDebuffed; this.PercentElementDebuffed = percentElementDebuffed; this.ElementDebuffedTurns = elementDebuffedTurns;
            this.AbilityTargetDebuffElement = target;

            EditTextForDebuffElementAbility();
        }
        static public AbilityEffect CreateDebuffElementEffect(bool isDebuffElement, ElementDebuffed elementDebuffed, short percentElementDebuffed, byte elementDebuffedTurns, AbilityTarget target)
        {
            return new AbilityEffect(isDebuffElement, elementDebuffed, percentElementDebuffed, elementDebuffedTurns, target);

        }
        private void EditTextForDebuffElementAbility()
        {
            // Text initialisation
            Text = "Decrease ";


            ElementDebuffed t = this.ElementDebuffed;

            List<string> lt = new List<string>();

            if ((t - ElementDebuffed.Dark) >= 0) { lt.Add(ElementDebuffed.Dark.ToString().ToLower() + "/"); t -= ElementDebuffed.Dark; }
            if ((t - ElementDebuffed.Light) >= 0) { lt.Add(ElementDebuffed.Light.ToString().ToLower() + "/"); t -= ElementDebuffed.Light; }
            if ((t - ElementDebuffed.Earth) >= 0) { lt.Add(ElementDebuffed.Earth.ToString().ToLower() + "/"); t -= ElementDebuffed.Earth; }
            if ((t - ElementDebuffed.Wind) >= 0) { lt.Add(ElementDebuffed.Wind.ToString().ToLower() + "/"); t -= ElementDebuffed.Wind; }

            if ((t - ElementDebuffed.Water) >= 0) { lt.Add(ElementDebuffed.Water.ToString().ToLower() + "/"); t -= ElementDebuffed.Water; }
            if ((t - ElementDebuffed.Lightning) >= 0) { lt.Add(ElementDebuffed.Lightning.ToString().ToLower() + "/"); t -= ElementDebuffed.Lightning; }
            if ((t - ElementDebuffed.Ice) >= 0) { lt.Add(ElementDebuffed.Ice.ToString().ToLower() + "/"); t -= ElementDebuffed.Ice; }
            if ((t - ElementDebuffed.Fire) >= 0) { lt.Add(ElementDebuffed.Fire.ToString().ToLower() + "/"); t -= ElementDebuffed.Fire; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1);

            Text += " resistance (" + PercentElementDebuffed.ToString() + "%) ";

            Text += "for " + ElementDebuffedTurns;

            if (ElementDebuffedTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetDebuffElement)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Special Ability - Multiple Skill

        #region Propriétés
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

        #region Méthodes
        private AbilityEffect(bool isMultipleSkill, byte numberOfMultiple, List<UnitAbility> abilitiesMultipleSkill)
        {
            this.IsMultipleSkill = isMultipleSkill; this.NumberOfMultiple = numberOfMultiple; this.AbilitiesMultipleSkill = abilitiesMultipleSkill;

            EditTextForMultipleSkillAbility();
        }
        static public AbilityEffect CreateMultipleSkillEffect(bool isMultipleSkill, byte numberOfMultiple, List<UnitAbility> abilitiesMultipleSkill)
        {
            return new AbilityEffect(isMultipleSkill, numberOfMultiple, abilitiesMultipleSkill);
        }
        private void EditTextForMultipleSkillAbility()
        {
            // Text initialisation
            Text = "Use";

            foreach (UnitAbility ability in AbilitiesMultipleSkill)
            {
                Text += " " + ability.Name + ",";
            }

            Text = Text.Remove(Text.Length - 1);

            Text += " " + NumberOfMultiple + " in one turn";
        }
        #endregion

        #endregion



        #region Special Ability - Ability Coeff Up

        #region Propriétés
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

        #region Méthodes
        private AbilityEffect(bool isAbilityCoeffUp, short abilityCoeffUp, List<UnitAbility> abilites, byte abilityCoeffUpTurns, bool abilityUpCanBeDispel, AbilityTarget target)
        {
            this.IsAbilityCoeffUp = isAbilityCoeffUp; this.AbilityCoeffUp = abilityCoeffUp; this.AbilitiesUp = abilites; this.AbilityCoeffUpTurns = abilityCoeffUpTurns; this.AbilityUpCanBeDispel = abilityUpCanBeDispel;
            this.AbilityTargetAbilityUp = target;

            EditTextForCoeffUpAbility();
        }
        static public AbilityEffect CreateAbilityCoeffUpEffect(bool isAbilityCoeffUp, short abilityCoeffUp, List<UnitAbility> abilites, byte abilityCoeffUpTurns, bool abilityUpCanBeDispel, AbilityTarget target)
        {
            return new AbilityEffect(isAbilityCoeffUp, abilityCoeffUp, abilites, abilityCoeffUpTurns, abilityUpCanBeDispel, target);
        }
        private void EditTextForCoeffUpAbility()
        {
            // Text initialisation
            Text = "Increase modifier (" + AbilityCoeffUp.ToString() + "%) ";

            Text += "for " + AbilityCoeffUpTurns;

            if (AbilityCoeffUpTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetAbilityUp)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }

            if(AbilityUpCanBeDispel == false)
            {
                Text += " (can't be dispelled)";
            }

            Text += " :";

            foreach (UnitAbility ability in AbilitiesUp)
            {
                Text += " " + ability.Name + ",";
            }

            Text = Text.Remove(Text.Length - 1);
        }
        #endregion

        #endregion



        #region Special Ability - Give Ability

        #region Propriétés
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

        #region Méthodes
        private AbilityEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, AbilityTarget target)
        {
            this.IsGiveAbility = isGiveAbility; this.NewAbilitiesGiven = newAbilities; this.GiveAbilityTurns = giveAbilityTurns; this.AbilityTargetGiveAbility = target;

            EditTextForGiveAbility();
        }
        static public AbilityEffect CreateGiveAbilityEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, AbilityTarget target)
        {
            return new AbilityEffect(isGiveAbility, newAbilities, giveAbilityTurns, target);
        }
        private void EditTextForGiveAbility()
        {
            // Text initialisation
            Text = "Enable skill for " + GiveAbilityTurns;

            if (GiveAbilityTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (AbilityTargetGiveAbility)
            {
                case AbilityTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case AbilityTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case AbilityTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case AbilityTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case AbilityTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case AbilityTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }

            Text += " :";

            foreach (UnitAbility ability in NewAbilitiesGiven)
            {
                Text += " " + ability.Name + ",";
            }

            Text = Text.Remove(Text.Length - 1);
        }
        #endregion

        #endregion



        #region Special Ability - Cooldown

        #region Propriétés
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

        #region Méthodes
        private AbilityEffect(bool isCooldown, byte cooldownTurns, bool isAvailableTurn1)
        {
            this.IsCooldown = isCooldown; this.CooldownTunrs = cooldownTurns; this.IsAbilityCoeffUp = isAvailableTurn1;

            EditTextForCooldownAbility();
        }
        static public AbilityEffect CreateCooldownEffect(bool isCooldown, byte cooldownTurns, bool isAvailableTurn1)
        {
            return new AbilityEffect(isCooldown, cooldownTurns, isAvailableTurn1);
        }
        private void EditTextForCooldownAbility()
        {
            // Text initialisation
            Text = "[" + CooldownTunrs + " turns cooldown, ";

            if (IsAvailableTurn1)
                Text += "available on turn 1";
            else
                Text += "available on turn " + CooldownTunrs;

            Text += "]";
        }
        #endregion

        #endregion


    }

}
