using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{

    enum LimitTarget
    {
        SingleTargetAlly = 0x01,
        SingleTargetEnemy = 0x02,
        AreaOfEffectAllies = 0x04,
        AreaOfEffectEnemies = 0x08,
        AreaOfEffectAlliesExceptCaster = 0x10,
        Caster = 0x20
    }


    class LimitEffect
    {
        /// <summary>
        /// Text of the limit effect
        /// </summary>
        public string Text { get; set; }


        #region Damage Limit

        #region Propriétés
        /// <summary>
        /// If the limit does damage
        /// </summary>
        public bool IsDamage { get; set; }

        /// <summary>
        /// Damage type of the limit
        /// <seealso cref="TypeDamage"/>
        /// </summary>
        public TypeDamage TypeDamage { get; set; }

        /// <summary>
        /// Stat for scaling damage
        /// </summary>
        public ScalingDamage ScalingDamage { get; set; }

        /// <summary>
        /// Element(s) of the limit
        /// </summary>
        public ElementDamage ElementDamage { get; set; }

        /// <summary>
        /// Coefficient of the limit, Percent, or Fixed
        /// </summary>
        public int CoeffDamage { get; set; }

        /// <summary>
        /// Percent of ingore defense. 0 if no ignore defense
        /// </summary>
        public byte IgnoreDefense { get; set; }

        /// <summary>
        /// If the limit drain HP to the enemy
        /// </summary>
        public bool IsHPDrain { get; set; }

        /// <summary>
        /// Coefficient of the HP Drain
        /// </summary>
        public byte CoeffHPDrain { get; set; }

        /// <summary>
        /// Max time need to max le limit damage
        /// </summary>
        public byte TimesMaxConsecutive { get; set; }

        /// <summary>
        /// Coeff to ad at each limit
        /// </summary>
        public short CoeffEachConsecutive { get; set; }

        /// <summary>
        /// Max coeff to the limit
        /// </summary>
        public short MaxCoeffConsecutive { get; set; }

        /// <summary>
        /// Target of the limit
        /// </summary>
        public LimitTarget LimitTargetDamage { get; set; }


        public int Hits { get; set; }
        #endregion

        #region Methodes
        private LimitEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, LimitTarget target, int hits)
        {
            this.IsDamage = isDamage; this.TypeDamage = typeDamage; this.ScalingDamage = scalingDamage; this.ElementDamage = elementDamage;
            this.CoeffDamage = coeffDamage; this.IgnoreDefense = ignoreDefense; this.LimitTargetDamage = target;
            this.Hits = hits;

            EditTextForDamageLimit();
        }
        static public LimitEffect CreateDamageEffect(bool isDamage, TypeDamage typeDamage, ScalingDamage scalingDamage, ElementDamage elementDamage,
            int coeffDamage, byte ignoreDefense, LimitTarget target, int hits)
        {
            return new LimitEffect(isDamage, typeDamage, scalingDamage, elementDamage,
            coeffDamage, ignoreDefense, target, hits);
        }
        private void EditTextForDamageLimit()
        {
            // Text initialisation
            if (this.ElementDamage != ElementDamage.Neutral)
                Text = ElementDamage.ToString() + " " + TypeDamage.ToString().ToLower();
            else
                Text = TypeDamage.ToString();

            Text += " damage (" + this.CoeffDamage.ToString() + "%) ";
            if (this.IgnoreDefense > 0)
            {
                Text += "with ignore DEF (" + IgnoreDefense + "%) ";
            }

            if (this.IsHPDrain)
            {
                Text += "as HP drain (" + CoeffHPDrain + "%) ";
            }

            if (TimesMaxConsecutive > 0)
            {
                Text += "with consecutive increase (" + TimesMaxConsecutive + "times, " + CoeffEachConsecutive + " each, " + MaxCoeffConsecutive + " max) ";
            }

            switch (LimitTargetDamage)
            {
                case LimitTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case LimitTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case LimitTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case LimitTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case LimitTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case LimitTarget.Caster:
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

            EditTextForDamageLimit();
        }
        public void AddConsecutive(byte timesMaxConsecutive, short coeffEachConsecutive, short maxCoeffConsecutive)
        {
            this.TimesMaxConsecutive = timesMaxConsecutive; this.CoeffEachConsecutive = coeffEachConsecutive; this.MaxCoeffConsecutive = maxCoeffConsecutive;

            EditTextForDamageLimit();
        }
        #endregion

        #endregion

        #region Special Limit - Give Ability

        #region Propriétés
        /// <summary>
        /// If the limit give ability
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
        /// Target of the limit
        /// </summary>
        public LimitTarget LimitTargetGiveAbility { get; set; }
        #endregion

        #region Méthodes
        private LimitEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, LimitTarget target)
        {
            this.IsGiveAbility = isGiveAbility; this.NewAbilitiesGiven = newAbilities; this.GiveAbilityTurns = giveAbilityTurns; this.LimitTargetGiveAbility = target;

            EditTextForGiveAbility();
        }
        static public LimitEffect CreateGiveAbilityEffect(bool isGiveAbility, List<UnitAbility> newAbilities, byte giveAbilityTurns, LimitTarget target)
        {
            return new LimitEffect(isGiveAbility, newAbilities, giveAbilityTurns, target);
        }
        private void EditTextForGiveAbility()
        {
            // Text initialisation
            Text = "Enable skill for " + GiveAbilityTurns;

            if (GiveAbilityTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (LimitTargetGiveAbility)
            {
                case LimitTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case LimitTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case LimitTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case LimitTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case LimitTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case LimitTarget.Caster:
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


        #region Special Limit - Limit Damage Up

        #region Propriétés
        /// <summary>
        /// If the limit buff the coefficient of the limit
        /// </summary>
        public bool IsLimitDamageUp { get; set; }

        /// <summary>
        /// Percent of the damage buff
        /// </summary>
        public short PercentLimitDamageUp { get; set; }

        /// <summary>
        /// Numbers of turns
        /// </summary>
        public byte LimitDamageUpTurns { get; set; }

        /// <summary>
        /// Target of the limit
        /// </summary>
        public LimitTarget LimitTargetLimitDamageUp { get; set; }
        #endregion

        #region Méthodes
        private LimitEffect(bool isLimitDamageUp, short percent, byte limitDamageUpTurns, LimitTarget target)
        {
            this.IsLimitDamageUp = isLimitDamageUp; this.PercentLimitDamageUp = percent; this.LimitDamageUpTurns = limitDamageUpTurns;
            this.LimitTargetLimitDamageUp = target;

            EditTextForLimitDamageUp();
        }
        static public LimitEffect CreateLimitDamageUpEffect(bool isLimitDamageUp, short percent, byte limitDamageUpTurns, LimitTarget target)
        {
            return new LimitEffect(isLimitDamageUp, percent, limitDamageUpTurns, target);
        }
        private void EditTextForLimitDamageUp()
        {
            // Text initialisation
            Text = "Increase LB damage (" + PercentLimitDamageUp.ToString() + "%) ";

            if (LimitDamageUpTurns == 1)
                Text += " turn ";
            else
                Text += " turns ";

            switch (LimitTargetLimitDamageUp)
            {
                case LimitTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case LimitTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case LimitTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case LimitTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case LimitTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case LimitTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion



        #region Special Limit - Auto-cast Ability

        #region Propriétés
        /// <summary>
        /// If the limit auto cast a ability
        /// </summary>
        public bool IsAutoCastAbility { get; set; }

        /// <summary>
        /// If the auto cast is infinite turns
        /// </summary>
        public bool InfiniteAutoCast { get; set; }

        /// <summary>
        /// Numbers of thurns of auto cast
        /// </summary>
        public byte AutoCastTurns { get; set; }

        /// <summary>
        /// Effects of the ability
        /// </summary>
        public List<AbilityEffect> AutoCastEffects { get; set; }
        #endregion

        #region Méthodes
        private LimitEffect(bool isInfiniteTurns, byte turns, List<AbilityEffect> abilities)
        {
            this.IsAutoCastAbility = true; this.InfiniteAutoCast = isInfiniteTurns; this.AutoCastTurns = turns;
            this.AutoCastEffects = abilities;

            EditTextForAutoCast();
        }
        static public LimitEffect CreateAutoCastEffect(bool isInfiniteTurns, byte turns, List<AbilityEffect> abilities)
        {
            return new LimitEffect(isInfiniteTurns, turns, abilities);
        }
        static public LimitEffect CreateAutoCastEffect(bool isInfiniteTurns, byte turns, AbilityEffect ability)
        {
            List<AbilityEffect> a = new List<AbilityEffect>();
            a.Add(ability);
            return new LimitEffect(isInfiniteTurns, turns, a);
        }
        private void EditTextForAutoCast()
        {
            Text = "Auto-cast ";
            if(!InfiniteAutoCast)
            {
                if (AutoCastTurns > 1)
                    Text += "for " + AutoCastTurns + " turns ";
                else
                    Text += "next turn ";
            }

            Text += ":" + Environment.NewLine;

            foreach (AbilityEffect effect in AutoCastEffects)
            {
                Text += "       " + effect.Text;
            }
        }
        #endregion

        #endregion



        #region Support Ability - Buff Stats

        #region Propriétés
        /// <summary>
        /// If the limit buff stats
        /// </summary>
        public bool IsBuffStats { get; set; }

        /// <summary>
        /// Stats buffed
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
        /// Target of the limit
        /// </summary>
        public LimitTarget LimitTargetBuffStats { get; set; }
        #endregion

        #region Methodes
        private LimitEffect(StatsBuffed statBuffCoeff, short coefficientBuffedStats, byte buffTurn, LimitTarget target)
        {
            this.IsBuffStats = true; this.StatsBuffed = statBuffCoeff; this.CoefficientBuffedStats = coefficientBuffedStats; this.BuffStatsTurns = buffTurn; this.LimitTargetBuffStats = target;

            EditTextForBuffStatsLimit();
        }
        static public LimitEffect CreateBuffAlliesEffect(StatsBuffed statBuffCoeff, short coefficientBuffedStats, byte buffTurn, LimitTarget target)
        {
            return new LimitEffect(statBuffCoeff, coefficientBuffedStats, buffTurn, target);
        }

        private void EditTextForBuffStatsLimit()
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

            switch (LimitTargetBuffStats)
            {
                case LimitTarget.SingleTargetAlly:
                    Text += "to one ally";
                    break;
                case LimitTarget.SingleTargetEnemy:
                    Text += "to one enemy";
                    break;
                case LimitTarget.AreaOfEffectAllies:
                    Text += "to all allies";
                    break;
                case LimitTarget.AreaOfEffectEnemies:
                    Text += "to all enemies";
                    break;
                case LimitTarget.AreaOfEffectAlliesExceptCaster:
                    Text += "to all allies except caster";
                    break;
                case LimitTarget.Caster:
                    Text += "to caster";
                    break;
                default:
                    Text += "to nobody";
                    break;
            }
        }
        #endregion

        #endregion
    }
}
