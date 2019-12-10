using FFBE_Soft.model.equipment;
using System.Collections.Generic;

namespace FFBE_Soft.model.competence
{

    public enum ElementResistance
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

    public enum AilmentResistance
    {
        Poison = 0x01,
        Blind = 0x02,
        Sleep = 0x04,
        Silence = 0x08,
        Paralysis = 0x10,
        Confuse = 0x20,
        Disease = 0x40,
        Petrification = 0x80,
        Stop = 0x100,
        Charm = 0X200
    }

    public enum StatistiquesBuff
    {
        HP = 0x01,
        MP = 0x02,
        ATK = 0x04,
        DEF = 0x08,
        MAG = 0x10,
        PSY = 0x20
    }

    public enum MonsterRace
    {
        Aquatics = 0x01,
        Avians = 0x02,
        Beasts = 0x04,
        Demons = 0x08,

        Dragons = 0x10,
        Fairies = 0x20,
        Humans = 0x40,
        Insects = 0x80,

        Machinas = 0x100,
        Plants = 0x200,
        Reapers = 0x400,
        Stones = 0x800
    }

    public enum UnitRace
    {
        Aquatic = 0x01,
        Beast = 0x02,
        Demon = 0x04,

        Dragon = 0x08,
        Fairy = 0x10,
        Human = 0x20,
        Machina = 0x40,
        Plant = 0x80,

        Reaper = 0x100,
        Stone = 0x200
    }

    public enum CounterType
    {
        Physical,
        Magical
    }

    public enum EquipmentStat
    {
        HP = 0x01,
        MP = 0x02,
        ATK = 0x04,
        DEF = 0x08,
        MAG = 0x10,
        PSY = 0x20
    }

    public enum EquipmentBuffCondition
    {
        DoubleHand,
        TrueDoubleHand,
        DualWield
    }

    public enum EvasionType
    {
        Physical = 0x01,
        Magical = 0x02
    }

    public enum WeaponBuffCondition
    {
        Dagger = 0x0001,
        Sword = 0x0002,
        GreatSword = 0x0004,
        Katana = 0x0008,
        Staff = 0x0010,
        Rod = 0x0020,
        Bow = 0x0040,
        Axe = 0x0080,

        Hammer = 0x0100,
        Spear = 0x0200,
        Instrument = 0x0400,
        Whip = 0x0800,
        ThrowingWeapon = 0x1000,
        Gun = 0x2000,
        Mace = 0x4000,
        Fist = 0x8000
    };

    public enum ArmorBuffCondition
    {
        LightShield = 0x01,
        HeavyShield = 0x02,
        Hat = 0x04,
        Helm = 0x08,
        Clothe = 0x10,
        LightArmor = 0x20,
        HeavyArmor = 0x40,
        Robe = 0x80
    };

    public enum TMRequirementPassive
    {
        TMR,
        STMR,
        Both
    }

    class PassiveEffect
    {
        /// <summary>
        /// Text of the passive effect
        /// </summary>
        public string Text { get; set; }






        #region Support Passive - Element Buff

        #region Propriétés
        /// <summary>
        /// If the passive buff element resistance
        /// </summary>
        public bool IsBuffElementResistance { get; set; }

        /// <summary>
        /// Element resistance
        /// </summary>
        public ElementResistance ElementResistance { get; set; }

        /// <summary>
        /// Coefficient of the element resistance
        /// </summary>
        public short CoeffElementResistance { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            this.IsBuffElementResistance = isBuffElementResistance; this.ElementResistance = element; this.CoeffElementResistance = coeffElementResistance;

            EditTextForElementBuffPassive();
        }
        static public PassiveEffect CreateElementResistanceEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            return new PassiveEffect(isBuffElementResistance, element, coeffElementResistance);
        }
        private void EditTextForElementBuffPassive()
        {
            // Text initialisation
            this.Text = "Increase ";
            ElementResistance t = ElementResistance;

            List<string> lt = new List<string>();

            if ((t - ElementResistance.Dark) >= 0) { lt.Add(ElementResistance.Dark.ToString().ToLower() + "/"); t -= ElementResistance.Dark; }
            if ((t - ElementResistance.Light) >= 0) { lt.Add(ElementResistance.Light.ToString().ToLower() + "/"); t -= ElementResistance.Light; }
            if ((t - ElementResistance.Earth) >= 0) { lt.Add(ElementResistance.Earth.ToString().ToLower() + "/"); t -= ElementResistance.Earth; }
            if ((t - ElementResistance.Wind) >= 0) { lt.Add(ElementResistance.Wind.ToString().ToLower() + "/"); t -= ElementResistance.Wind; }

            if ((t - ElementResistance.Water) >= 0) { lt.Add(ElementResistance.Water.ToString().ToLower() + "/"); t -= ElementResistance.Water; }
            if ((t - ElementResistance.Lightning) >= 0) { lt.Add(ElementResistance.Lightning.ToString().ToLower() + "/"); t -= ElementResistance.Lightning; }
            if ((t - ElementResistance.Ice) >= 0) { lt.Add(ElementResistance.Ice.ToString().ToLower() + "/"); t -= ElementResistance.Ice; }
            if ((t - ElementResistance.Fire) >= 0) { lt.Add(ElementResistance.Fire.ToString().ToLower() + "/"); t -= ElementResistance.Fire; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " resistance (" + CoeffElementResistance + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - Ailment Buff

        #region Propriétés
        /// <summary>
        /// If the passive buff ailment resistance
        /// </summary>
        public bool IsBuffAilmentResistance { get; set; }

        /// <summary>
        /// Ailment resistance
        /// </summary>
        public AilmentResistance AilmentResistance { get; set; }

        /// <summary>
        /// Coefficient of the ailment resistance
        /// </summary>
        public byte CoeffAilmentResistance { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            this.IsBuffAilmentResistance = isBuffAilmentResistance; this.AilmentResistance = ailment; this.CoeffAilmentResistance = coeffAilmentResistance;

            EditTextForAilmentBuffPassive();
        }
        static public PassiveEffect CreateAilmentResistanceEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            return new PassiveEffect(isBuffAilmentResistance, ailment, coeffAilmentResistance);
        }
        private void EditTextForAilmentBuffPassive()
        {
            // Text initialisation
            this.Text = "Increase resistance to ";
            AilmentResistance t = AilmentResistance;

            List<string> lt = new List<string>();

            if ((t - AilmentResistance.Charm) >= 0) { lt.Add(AilmentResistance.Charm.ToString().ToLower() + "/"); t -= AilmentResistance.Charm; }
            if ((t - AilmentResistance.Stop) >= 0) { lt.Add(AilmentResistance.Stop.ToString().ToLower() + "/"); t -= AilmentResistance.Stop; }

            if ((t - AilmentResistance.Petrification) >= 0) { lt.Add(AilmentResistance.Petrification.ToString().ToLower() + "/"); t -= AilmentResistance.Petrification; }
            if ((t - AilmentResistance.Disease) >= 0) { lt.Add(AilmentResistance.Disease.ToString().ToLower() + "/"); t -= AilmentResistance.Disease; }
            if ((t - AilmentResistance.Confuse) >= 0) { lt.Add(AilmentResistance.Confuse.ToString().ToLower() + "/"); t -= AilmentResistance.Confuse; }
            if ((t - AilmentResistance.Paralysis) >= 0) { lt.Add(AilmentResistance.Paralysis.ToString().ToLower() + "/"); t -= AilmentResistance.Paralysis; }

            if ((t - AilmentResistance.Silence) >= 0) { lt.Add(AilmentResistance.Silence.ToString().ToLower() + "/"); t -= AilmentResistance.Silence; }
            if ((t - AilmentResistance.Sleep) >= 0) { lt.Add(AilmentResistance.Sleep.ToString().ToLower() + "/"); t -= AilmentResistance.Sleep; }
            if ((t - AilmentResistance.Blind) >= 0) { lt.Add(AilmentResistance.Blind.ToString().ToLower() + "/"); t -= AilmentResistance.Blind; }
            if ((t - AilmentResistance.Poison) >= 0) { lt.Add(AilmentResistance.Poison.ToString().ToLower() + "/"); t -= AilmentResistance.Poison; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoeffAilmentResistance + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - Stats Buff

        #region Propriétés
        /// <summary>
        /// If the passive buff statistiques
        /// </summary>
        public bool IsBuffStats { get; set; }

        /// <summary>
        /// Statisiques buffed
        /// </summary>
        public StatistiquesBuff StatistiquesBuff { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoeffStatsBuff { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isBuffStats, StatistiquesBuff statistiques, short coeff)
        {
            this.IsBuffStats = isBuffStats; this.StatistiquesBuff = statistiques; this.CoeffStatsBuff = coeff;

            EditTextForStatistiquesBuffPassive();
        }
        static public PassiveEffect CreateStatistiquesBuffEffect(bool isBuffStats, StatistiquesBuff statistiques, short coeff)
        {
            return new PassiveEffect(isBuffStats, statistiques, coeff);
        }
        private void EditTextForStatistiquesBuffPassive()
        {
            // Text initialisation
            this.Text = "Increase ";
            StatistiquesBuff t = StatistiquesBuff;

            List<string> lt = new List<string>();
            if ((t - StatistiquesBuff.PSY) >= 0) { lt.Add(StatistiquesBuff.PSY.ToString() + "/"); t -= StatistiquesBuff.PSY; }
            if ((t - StatistiquesBuff.MAG) >= 0) { lt.Add(StatistiquesBuff.MAG.ToString() + "/"); t -= StatistiquesBuff.MAG; }
            if ((t - StatistiquesBuff.DEF) >= 0) { lt.Add(StatistiquesBuff.DEF.ToString() + "/"); t -= StatistiquesBuff.DEF; }

            if ((t - StatistiquesBuff.ATK) >= 0) { lt.Add(StatistiquesBuff.ATK.ToString() + "/"); t -= StatistiquesBuff.ATK; }
            if ((t - StatistiquesBuff.MP) >= 0) { lt.Add(StatistiquesBuff.MP.ToString() + "/"); t -= StatistiquesBuff.MP; }
            if ((t - StatistiquesBuff.HP) >= 0) { lt.Add(StatistiquesBuff.HP.ToString() + "/"); t -= StatistiquesBuff.HP; }


            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoeffStatsBuff + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - Race Damage Buff

        #region Propriétés
        /// <summary>
        /// If the ability buff the damage to race enemy
        /// </summary>
        public bool IsBuffRaceDamage { get; set; }

        /// <summary>
        /// Race of the buff
        /// </summary>
        public MonsterRace MonsterRaceBuffDamage { get; set; }

        /// <summary>
        /// Type of damage of the buff
        /// </summary>
        public TypeDamage TypeDamageRaceBuffDamage { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoeffRaceDamageBuff { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isBuffRaceDamage, MonsterRace monsterRace, TypeDamage typeDamage, short coeffRaceDamageBuff)
        {
            this.IsBuffRaceDamage = isBuffRaceDamage; this.MonsterRaceBuffDamage = monsterRace; this.TypeDamageRaceBuffDamage = typeDamage; this.CoeffRaceDamageBuff = coeffRaceDamageBuff;

            EditTextForRaceDamageBuffPassive();
        }
        static public PassiveEffect CreateMonsterRaceBuffEffect(bool isBuffRaceDamage, MonsterRace monsterRace, TypeDamage typeDamage, short coeffRaceDamageBuff)
        {
            return new PassiveEffect(isBuffRaceDamage, monsterRace, typeDamage, coeffRaceDamageBuff);
        }
        private void EditTextForRaceDamageBuffPassive()
        {
            // Text initialisation
            this.Text = "Increase " + this.TypeDamageRaceBuffDamage.ToString().ToLower() + " damage against ";
            MonsterRace t = MonsterRaceBuffDamage;

            List<string> lt = new List<string>();

            if ((t - MonsterRace.Stones) >= 0) { lt.Add(MonsterRace.Stones.ToString().ToLower() + "/"); t -= MonsterRace.Stones; }
            if ((t - MonsterRace.Reapers) >= 0) { lt.Add(MonsterRace.Reapers.ToString().ToLower() + "/"); t -= MonsterRace.Reapers; }
            if ((t - MonsterRace.Plants) >= 0) { lt.Add(MonsterRace.Plants.ToString().ToLower() + "/"); t -= MonsterRace.Plants; }
            if ((t - MonsterRace.Machinas) >= 0) { lt.Add(MonsterRace.Machinas.ToString().ToLower() + "/"); t -= MonsterRace.Machinas; }

            if ((t - MonsterRace.Insects) >= 0) { lt.Add(MonsterRace.Insects.ToString().ToLower() + "/"); t -= MonsterRace.Insects; }
            if ((t - MonsterRace.Humans) >= 0) { lt.Add(MonsterRace.Humans.ToString().ToLower() + "/"); t -= MonsterRace.Humans; }
            if ((t - MonsterRace.Fairies) >= 0) { lt.Add(MonsterRace.Fairies.ToString().ToLower() + "/"); t -= MonsterRace.Fairies; }
            if ((t - MonsterRace.Dragons) >= 0) { lt.Add(MonsterRace.Dragons.ToString().ToLower() + "/"); t -= MonsterRace.Dragons; }


            if ((t - MonsterRace.Demons) >= 0) { lt.Add(MonsterRace.Demons.ToString().ToLower() + "/"); t -= MonsterRace.Demons; }
            if ((t - MonsterRace.Beasts) >= 0) { lt.Add(MonsterRace.Beasts.ToString().ToLower() + "/"); t -= MonsterRace.Beasts; }
            if ((t - MonsterRace.Avians) >= 0) { lt.Add(MonsterRace.Avians.ToString().ToLower() + "/"); t -= MonsterRace.Avians; }
            if ((t - MonsterRace.Aquatics) >= 0) { lt.Add(MonsterRace.Aquatics.ToString().ToLower() + "/"); t -= MonsterRace.Aquatics; }

            for (int i = 0; i <= lt.Count; i++)

            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " monsters (" + CoeffRaceDamageBuff + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - Ignore Fatal Damage

        #region Propriétés
        /// <summary>
        /// If the passive do a ignore fatal damage
        /// </summary>
        public bool IsIgnoreFatalDamage { get; set; }

        /// <summary>
        /// Chance to ignore death
        /// </summary>
        public byte ChanceToIgnoreFatalDamage { get; set; }

        /// <summary>
        /// Percent of HP necessary to active the passif
        /// </summary>
        public byte PercentAboveHPToIgnoreFatalDamage { get; set; }

        /// <summary>
        /// Max time to activate the passif
        /// </summary>
        public byte MaxIgnoreFatalDamage { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isIgnoreFatalDamage, byte chanceToIgnoreFatalDamage, byte percentAboveHPToIgnoreDamage, byte maxIgnoreFatalDamage)
        {
            this.IsIgnoreFatalDamage = isIgnoreFatalDamage; this.ChanceToIgnoreFatalDamage = chanceToIgnoreFatalDamage; this.PercentAboveHPToIgnoreFatalDamage = percentAboveHPToIgnoreDamage; this.MaxIgnoreFatalDamage = maxIgnoreFatalDamage;

            EditTextForIgnoreFatalDamagePassive();
        }
        static public PassiveEffect CreateIgnoreFatalDamageEffect(bool isIgnoreFatalDamage, byte chanceToIgnoreFatalDamage, byte percentAboveHPToIgnoreDamage, byte maxIgnoreFatalDamage)
        {
            return new PassiveEffect(isIgnoreFatalDamage, chanceToIgnoreFatalDamage, percentAboveHPToIgnoreDamage, maxIgnoreFatalDamage);
        }
        private void EditTextForIgnoreFatalDamagePassive()
        {
            this.Text = "Chance to ignore fatal damage (" + this.ChanceToIgnoreFatalDamage + "%) when HP is above " + this.PercentAboveHPToIgnoreFatalDamage + "% (max " + this.MaxIgnoreFatalDamage + " time)";
        }
        #endregion

        #endregion



        #region Spécial Passive - Chance To Counter

        #region Propriétés
        /// <summary>
        /// If the passive give a counter
        /// </summary>
        public bool IsCounterPassive { get; set; }

        /// <summary>
        /// Type of the counter
        /// </summary>
        public CounterType CounterType { get; set; }

        /// <summary>
        /// Chance to counter
        /// </summary>
        public byte ChanceToCounter { get; set; }

        /// <summary>
        /// If the counter is a normal attack
        /// </summary>
        public bool CounterWithBaseAttack { get; set; }

        /// <summary>
        /// The ability of the counter
        /// </summary>
        public UnitAbility AbilityCounter { get; set; }

        /// <summary>
        /// Number of counter in a turn
        /// </summary>
        public byte MaxCounterInATurn { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isCounterPassive, CounterType type, byte chancetoCounter, bool counterWithNormalAttack, byte maxCounter)
        {
            this.IsCounterPassive = IsCounterPassive; CounterType = type; this.ChanceToCounter = chancetoCounter; this.CounterWithBaseAttack = counterWithNormalAttack;
            this.MaxCounterInATurn = maxCounter;

            EditTextForChanceToCounterPassive();
        }
        private PassiveEffect(bool isCounterPassive, CounterType type, byte chancetoCounter, UnitAbility ability, byte maxCounter)
        {
            this.IsCounterPassive = IsCounterPassive; CounterType = type; this.ChanceToCounter = chancetoCounter; this.AbilityCounter = ability;
            this.MaxCounterInATurn = maxCounter;

            EditTextForChanceToCounterPassive();
        }
        static public PassiveEffect CreateChanceToCounterEffect(bool isCounterPassive, CounterType type, byte chancetoCounter, bool counterWithNormalAttack, byte maxCounter)
        {
            return new PassiveEffect(isCounterPassive, type, chancetoCounter, counterWithNormalAttack, maxCounter);
        }
        static public PassiveEffect CreateChanceToCounterEffect(bool isCounterPassive, CounterType type, byte chancetoCounter, UnitAbility ability, byte maxCounter)
        {
            return new PassiveEffect(isCounterPassive, type, chancetoCounter, ability, maxCounter);
        }
        private void EditTextForChanceToCounterPassive()
        {
            Text = "Chance to counter " + CounterType.ToString().ToLower() + " attacks (" + ChanceToCounter + "%) with ";

            if (CounterWithBaseAttack)
                Text += "normal attack ";
            else
            {
                Text += AbilityCounter.Name + " ";
            }
            if (MaxCounterInATurn > 0)
                Text += "(max " + MaxCounterInATurn + "/turn)";
        }
        #endregion

        #endregion



        #region Support Passive - Equipment Stats Buff

        #region Propriétés
        /// <summary>
        /// If the passive increase stats of equipment
        /// </summary>
        public bool IsEquipmentStatsBuff { get; set; }

        /// <summary>
        /// Stats buff of the equipment
        /// </summary>
        public EquipmentStat EquipmentStat { get; set; }

        /// <summary>
        /// Coeff of the buff
        /// </summary>
        public short CoeffEquimentBuff { get; set; }

        /// <summary>
        /// Coeff of accuracy up
        /// </summary>
        public byte CoeffAccuracy { get; set; }

        /// <summary>
        /// Condition of the passive
        /// </summary>
        public EquipmentBuffCondition EquipmentBuffCondition { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isEquipmentBuff, EquipmentStat stats, short coeff, byte accuracy, EquipmentBuffCondition condition)
        {
            this.IsEquipmentStatsBuff = isEquipmentBuff; this.EquipmentStat = stats; this.CoeffEquimentBuff = coeff; this.CoeffAccuracy = accuracy; this.EquipmentBuffCondition = condition;

            EditTextForEquipmentBuffPassive();
        }
        static public PassiveEffect CreateEquipmentBuffEffect(bool isEquipmentBuff, EquipmentStat stats, short coeff, byte accuracy, EquipmentBuffCondition condition)
        {
            return new PassiveEffect(isEquipmentBuff, stats, coeff, accuracy, condition);
        }
        private void EditTextForEquipmentBuffPassive()
        {
            Text = "Increase equipment ";

            EquipmentStat t = EquipmentStat;

            List<string> lt = new List<string>();
            if ((t - EquipmentStat.PSY) >= 0) { lt.Add(EquipmentStat.PSY.ToString() + "/"); t -= EquipmentStat.PSY; }
            if ((t - EquipmentStat.MAG) >= 0) { lt.Add(EquipmentStat.MAG.ToString() + "/"); t -= EquipmentStat.MAG; }
            if ((t - EquipmentStat.DEF) >= 0) { lt.Add(EquipmentStat.DEF.ToString() + "/"); t -= EquipmentStat.DEF; }
                                                                                                 
            if ((t - EquipmentStat.ATK) >= 0) { lt.Add(EquipmentStat.ATK.ToString() + "/"); t -= EquipmentStat.ATK; }
            if ((t - EquipmentStat.MP) >= 0) { lt.Add(EquipmentStat.MP.ToString() + "/"); t -= EquipmentStat.MP; }
            if ((t - EquipmentStat.HP) >= 0) { lt.Add(EquipmentStat.HP.ToString() + "/"); t -= EquipmentStat.HP; }


            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoeffEquimentBuff + "%) when ";

            switch (EquipmentBuffCondition)
            {
                case EquipmentBuffCondition.DoubleHand:
                    Text += "single wielding a one-handed weapon";
                    break;
                case EquipmentBuffCondition.TrueDoubleHand:
                    Text += "single wielding any weapon";
                    break;
                case EquipmentBuffCondition.DualWield:
                    Text += "dual wielding";
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion



        #region Support Passive - Evasion

        #region Propriétés
        /// <summary>
        /// If the passive give evasion
        /// </summary>
        public bool IsEvasionBuff { get; set; }

        /// <summary>
        /// Type of the evasion
        /// </summary>
        public EvasionType EvasionType { get; set; }

        /// <summary>
        /// Coefficient of the evasion
        /// </summary>
        public byte CoeffEvasion { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isEvasion, EvasionType type, byte coeff)
        {
            this.IsEvasionBuff = isEvasion; this.EvasionType = type; this.CoeffEvasion = coeff;

            EditTextForEvasionBuffPassive();
        }
        static public PassiveEffect CreateEvasionEffect(bool isEvasion, EvasionType type, byte coeff)
        {
            return new PassiveEffect(isEvasion, type, coeff);
        }
        private void EditTextForEvasionBuffPassive()
        {
            Text = "Increase ";

            EvasionType t = EvasionType;

            List<string> lt = new List<string>();

            if ((t - EvasionType.Magical) >= 0) { lt.Add(EvasionType.Magical.ToString().ToLower() + "/"); t -= EvasionType.Magical; }
            if ((t - EvasionType.Physical) >= 0) { lt.Add(EvasionType.Physical.ToString().ToLower() + "/"); t -= EvasionType.Physical; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " evasion (" + CoeffEvasion + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - Auto Regen MP

        #region Propriétés
        /// <summary>
        /// If the passive auto regen MP
        /// </summary>
        public bool IsAutoRegenMP { get; set; }

        /// <summary>
        /// Percent of the auto regen
        /// </summary>
        public byte PercentAutoRegenMP { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isAutoRegenMP, byte percent)
        {
            this.IsAutoRegenMP = isAutoRegenMP; this.PercentAutoRegenMP = percent;

            EditTextForAutoRegenMPPassive();
        }
        static public PassiveEffect CreateAutoRegenMPEffect(bool isAutoRegenMP, byte percent)
        {
            return new PassiveEffect(isAutoRegenMP, percent);
        }
        private void EditTextForAutoRegenMPPassive()
        {
            Text = "Recover MP (" + PercentAutoRegenMP + "%) per turn";
        }
        #endregion

        #endregion



        #region Support Passive - Auto Regen HP

        #region Propriétés
        /// <summary>
        /// If the passive regen HP
        /// </summary>
        public bool IsAutoRegenHP { get; set; }

        /// <summary>
        /// Base HP of the auto regen
        /// </summary>
        public short BaseAutoRegenHP { get; set; }

        /// <summary>
        /// Coeffcient of the auto regen
        /// </summary>
        public short CoeffAutoRegenHP { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isAutoRegenHP, short baseHP, short coeff)
        {
            this.IsAutoRegenHP = isAutoRegenHP; this.BaseAutoRegenHP = baseHP; this.CoeffAutoRegenHP = coeff;

            EditTextForAutoRegenHPPassive();
        }
        static public PassiveEffect CreateAutoRegenHPEffect(bool isAutoRegenHP, short baseHP, short coeff)
        {
            return new PassiveEffect(isAutoRegenHP, baseHP, coeff);
        }
        private void EditTextForAutoRegenHPPassive()
        {
            Text = "Auto-heal (" + BaseAutoRegenHP + " HP, " + CoeffAutoRegenHP + "%) per turn";
        }
        #endregion

        #endregion



        #region Spécial Passive - Auto Cast Ability

        #region Propriétés
        /// <summary>
        /// If the passive auto cast an ability
        /// </summary>
        public bool IsAutoCastAbility { get; set; }

        /// <summary>
        /// Ability to auto cast
        /// </summary>
        public UnitAbility AutoCastAbility { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isAutoCastAbility, UnitAbility ability)
        {
            this.IsAutoCastAbility = isAutoCastAbility; this.AutoCastAbility = ability;

            EditTextForAutoCastAbilityPassive();
        }
        static public PassiveEffect CreateAutoCastAbilityEffect(bool isAutoCastAbility, UnitAbility ability)
        {
            return new PassiveEffect(isAutoCastAbility, ability);
        }
        private void EditTextForAutoCastAbilityPassive()
        {
            Text = "Auto-cast " + AutoCastAbility.Name + " every turn";
        }
        #endregion

        #endregion



        #region Support Passive - Statistiques Buff With Equipment Condition

        #region Propriétés
        /// <summary>
        /// If the passive buff statistiques with a equipment condition
        /// </summary>
        public bool IsBuffStatsEquipmentCondition { get; set; }

        /// <summary>
        /// Statistiques buffed
        /// </summary>
        public StatistiquesBuff StatistiquesBuffEquipmentCondition { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoefficientBuffEquipmentCondition { get; set; }

        /// <summary>
        /// Weapon condition to activate the buff
        /// </summary>
        public WeaponBuffCondition WeaponCondition { get; set; }

        /// <summary>
        /// Armor condition to activate the buff
        /// </summary>
        public ArmorBuffCondition ArmorCondition { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, WeaponBuffCondition weapon, ArmorBuffCondition armor)
        {
            this.IsBuffStatsEquipmentCondition = isBuffStatsEquipmentCondition; this.StatistiquesBuffEquipmentCondition = stats;
            this.CoefficientBuffEquipmentCondition = coeff; this.WeaponCondition = weapon; this.ArmorCondition = armor;

            EditTextForStatistiquesBuffEquipmentConditionPassive();
        }
        private PassiveEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, WeaponBuffCondition weapon)
        {
            this.IsBuffStatsEquipmentCondition = isBuffStatsEquipmentCondition; this.StatistiquesBuffEquipmentCondition = stats;
            this.CoefficientBuffEquipmentCondition = coeff; this.WeaponCondition = weapon;

            EditTextForStatistiquesBuffEquipmentConditionPassive();
        }
        private PassiveEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, ArmorBuffCondition armor)
        {
            this.IsBuffStatsEquipmentCondition = isBuffStatsEquipmentCondition; this.StatistiquesBuffEquipmentCondition = stats;
            this.CoefficientBuffEquipmentCondition = coeff; this.ArmorCondition = armor;

            EditTextForStatistiquesBuffEquipmentConditionPassive();
        }

        static public PassiveEffect CreateStatistiquesBuffEquipmentConditionEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, WeaponBuffCondition weapon, ArmorBuffCondition armor)
        {
            return new PassiveEffect(isBuffStatsEquipmentCondition, stats, coeff, weapon, armor);
        }
        static public PassiveEffect CreateStatistiquesBuffWeaponConditionEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, WeaponBuffCondition weapon)
        {
            return new PassiveEffect(isBuffStatsEquipmentCondition, stats, coeff, weapon);
        }
        static public PassiveEffect CreateStatistiquesBuffArmorConditionEffect(bool isBuffStatsEquipmentCondition, StatistiquesBuff stats, short coeff, ArmorBuffCondition armor)
        {
            return new PassiveEffect(isBuffStatsEquipmentCondition, stats, coeff, armor);
        }

        private void EditTextForStatistiquesBuffEquipmentConditionPassive()
        {
            Text = "Increase ";

            {
                StatistiquesBuff t = StatistiquesBuffEquipmentCondition;

                List<string> lt = new List<string>();
                if ((t - StatistiquesBuff.PSY) >= 0) { lt.Add(StatistiquesBuff.PSY.ToString() + "/"); t -= StatistiquesBuff.PSY; }
                if ((t - StatistiquesBuff.MAG) >= 0) { lt.Add(StatistiquesBuff.MAG.ToString() + "/"); t -= StatistiquesBuff.MAG; }
                if ((t - StatistiquesBuff.DEF) >= 0) { lt.Add(StatistiquesBuff.DEF.ToString() + "/"); t -= StatistiquesBuff.DEF; }

                if ((t - StatistiquesBuff.ATK) >= 0) { lt.Add(StatistiquesBuff.ATK.ToString() + "/"); t -= StatistiquesBuff.ATK; }
                if ((t - StatistiquesBuff.MP) >= 0) { lt.Add(StatistiquesBuff.MP.ToString() + "/"); t -= StatistiquesBuff.MP; }
                if ((t - StatistiquesBuff.HP) >= 0) { lt.Add(StatistiquesBuff.HP.ToString() + "/"); t -= StatistiquesBuff.HP; }


                for (int i = 0; i <= lt.Count; i++)
                {
                    string tt;
                    tt = lt[lt.Count - 1];
                    Text += tt;
                    lt.Remove(tt);
                }
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoefficientBuffEquipmentCondition + "%) when equiped with ";

            {
                WeaponBuffCondition t = WeaponCondition;

                List<string> lt = new List<string>();
                if ((t - WeaponBuffCondition.Fist) >= 0) { lt.Add(WeaponBuffCondition.Fist.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Fist; }
                if ((t - WeaponBuffCondition.Mace) >= 0) { lt.Add(WeaponBuffCondition.Mace.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Mace; }
                if ((t - WeaponBuffCondition.Gun) >= 0) { lt.Add(WeaponBuffCondition.Gun.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Gun; }
                if ((t - WeaponBuffCondition.ThrowingWeapon) >= 0) { lt.Add(WeaponBuffCondition.ThrowingWeapon.ToString().ToLower() + "/"); t -= WeaponBuffCondition.ThrowingWeapon; }

                if ((t - WeaponBuffCondition.Whip) >= 0) { lt.Add(WeaponBuffCondition.Whip.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Whip; }
                if ((t - WeaponBuffCondition.Instrument) >= 0) { lt.Add(WeaponBuffCondition.Instrument.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Instrument; }
                if ((t - WeaponBuffCondition.Spear) >= 0) { lt.Add(WeaponBuffCondition.Spear.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Spear; }
                if ((t - WeaponBuffCondition.Hammer) >= 0) { lt.Add(WeaponBuffCondition.Hammer.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Hammer; }

                if ((t - WeaponBuffCondition.Axe) >= 0) { lt.Add(WeaponBuffCondition.Axe.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Axe; }
                if ((t - WeaponBuffCondition.Bow) >= 0) { lt.Add(WeaponBuffCondition.Bow.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Bow; }
                if ((t - WeaponBuffCondition.Rod) >= 0) { lt.Add(WeaponBuffCondition.Rod.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Rod; }
                if ((t - WeaponBuffCondition.Staff) >= 0) { lt.Add(WeaponBuffCondition.Staff.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Staff; }

                if ((t - WeaponBuffCondition.Katana) >= 0) { lt.Add(WeaponBuffCondition.Katana.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Katana; }
                if ((t - WeaponBuffCondition.GreatSword) >= 0) { lt.Add(WeaponBuffCondition.GreatSword.ToString().ToLower() + "/"); t -= WeaponBuffCondition.GreatSword; }
                if ((t - WeaponBuffCondition.Sword) >= 0) { lt.Add(WeaponBuffCondition.Sword.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Sword; }
                if ((t - WeaponBuffCondition.Dagger) >= 0) { lt.Add(WeaponBuffCondition.Dagger.ToString().ToLower() + "/"); t -= WeaponBuffCondition.Dagger; }

                if(lt.Count > 0)
                {
                    for (int i = 0; i <= lt.Count; i++)
                    {
                        string tt;
                        tt = lt[lt.Count - 1];
                        Text += tt;
                        lt.Remove(tt);
                    }
                }
                
            }


            {
                ArmorBuffCondition t = ArmorCondition;

                List<string> lt = new List<string>();
                if ((t - ArmorBuffCondition.Robe) >= 0) { lt.Add(ArmorBuffCondition.Robe.ToString().ToLower() + "/"); t -= ArmorBuffCondition.Robe; }
                if ((t - ArmorBuffCondition.HeavyArmor) >= 0) { lt.Add(ArmorBuffCondition.HeavyArmor.ToString().ToLower() + "/"); t -= ArmorBuffCondition.HeavyArmor; }
                if ((t - ArmorBuffCondition.LightArmor) >= 0) { lt.Add(ArmorBuffCondition.LightArmor.ToString().ToLower() + "/"); t -= ArmorBuffCondition.LightArmor; }
                if ((t - ArmorBuffCondition.Clothe) >= 0) { lt.Add(ArmorBuffCondition.Clothe.ToString().ToLower() + "/"); t -= ArmorBuffCondition.Clothe; }
                         
                if ((t - ArmorBuffCondition.Helm) >= 0) { lt.Add(ArmorBuffCondition.Helm.ToString().ToLower() + "/"); t -= ArmorBuffCondition.Helm; }
                if ((t - ArmorBuffCondition.Hat) >= 0) { lt.Add(ArmorBuffCondition.Hat.ToString().ToLower() + "/"); t -= ArmorBuffCondition.Hat; }
                if ((t - ArmorBuffCondition.HeavyShield) >= 0) { lt.Add(ArmorBuffCondition.HeavyShield.ToString().ToLower() + "/"); t -= ArmorBuffCondition.HeavyShield; }
                if ((t - ArmorBuffCondition.LightShield) >= 0) { lt.Add(ArmorBuffCondition.LightShield.ToString().ToLower() + "/"); t -= ArmorBuffCondition.LightShield; }

                if(lt.Count > 0)
                {
                    for (int i = 0; i <= lt.Count; i++)
                    {
                        string tt;
                        tt = lt[lt.Count - 1];
                        Text += tt;
                        lt.Remove(tt);
                    }
                }
                
            }

            Text = Text.Remove(Text.Length - 1);

        }
        #endregion

        #endregion



        #region Spécial Passive - TM Requirement

        #region Propriétés
        /// <summary>
        /// If is a TM Requirement passive
        /// </summary>
        public bool IsTMRequirement { get; set; }

        /// <summary>
        /// Type of the requirement
        /// </summary>
        public TMRequirementPassive TMRequirementPassive { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isTMRequirement, TMRequirementPassive tm)
        {
            this.IsTMRequirement = isTMRequirement; this.TMRequirementPassive = tm;

            EditTextForTMRequirementPassive();
        }
        static public PassiveEffect CreateTMRequirementEffect(bool isTMRequirement, TMRequirementPassive tm)
        {
            return new PassiveEffect(isTMRequirement, tm);
        }
        private void EditTextForTMRequirementPassive()
        {
            Text = "[Requirement: ";

            switch (TMRequirementPassive)
            {
                case TMRequirementPassive.TMR:
                    Text += "TMR ";
                    break;
                case TMRequirementPassive.STMR:
                    Text += "STMR ";
                    break;
                case TMRequirementPassive.Both:
                    Text += "TMR or STMR ";
                    break;
                default:
                    Text += "nothing :";
                    break;
            }

            Text += "equipped]";
        }
        #endregion

        #endregion



        #region Support Passive - LB Gauge Fill Rate

        #region Propriétés
        /// <summary>
        /// If the ability up the lg fill rate
        /// </summary>
        public bool IsLBGaugeFillRate { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoefficientLBGaugeFillRate { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isLBGaugeFillRate, short coeff)
        {
            this.IsLBGaugeFillRate = isLBGaugeFillRate; this.CoefficientLBGaugeFillRate = coeff;

            EditTextForLBGaugeFillRatePassive();
        }
        static public PassiveEffect CreateLBGaugeFillRateEffect(bool isLBGaugeFillRate, short coeff)
        {
            return new PassiveEffect(isLBGaugeFillRate, coeff);
        }
        private void EditTextForLBGaugeFillRatePassive()
        {
            Text = "Increase LB gauge fill rate (" + CoefficientLBGaugeFillRate + "%)";
        }
        #endregion

        #endregion



        #region Support Passive - LB Damage

        #region Propriétés
        /// <summary>
        /// If the ability increase the damage of the limit
        /// </summary>
        public bool IsLBDamage { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoefficientLBDamage { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(bool isLBDamage, short coeff, bool truc)
        {
            this.IsLBDamage = isLBDamage; this.CoefficientLBDamage = coeff;

            EditTextForLBDamagePassive();
        }
        static public PassiveEffect CreateLBDamageEffect(bool isLBDamage, short coeff)
        {
            return new PassiveEffect(isLBDamage, coeff, true);
        }
        private void EditTextForLBDamagePassive()
        {
            Text = "Increase LB damage (" + CoefficientLBDamage + "%)";
        }
        #endregion

        #endregion



        #region Spécial Passive - LB Upgrade

        #region Propriétés
        /// <summary>
        /// If the passive upgrade the LB
        /// </summary>
        public bool IsLBUpgrade { get; set; }

        //TODO New Limit
        #endregion

        #region Méthodes
        private PassiveEffect(bool isLBUpgrade)
        {
            this.IsLBUpgrade = isLBUpgrade;

            EditTextForLBUpgradePassive();
        }
        static public PassiveEffect CreateLBUpgradeEffect(bool isLBUpgrade)
        {
            return new PassiveEffect(isLBUpgrade);
        }
        private void EditTextForLBUpgradePassive()
        {
            Text = "LB Upgrade";
        }
        #endregion

        #endregion



        #region Spécial Passive - Absorb Element Damage

        #region Propriétés
        /// <summary>
        /// If the passive absord element damage
        /// </summary>
        public bool IsAbsorbDamage { get; set; }

        /// <summary>
        /// Element to absorb
        /// </summary>
        public ElementDamage ElementAbsorb { get; set; }

        /// <summary>
        /// Type of damage to absorb
        /// </summary>
        public TypeDamage TypeDamageAbsorb { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(ElementDamage element, TypeDamage type)
        {
            IsAbsorbDamage = true; ElementAbsorb = element; TypeDamageAbsorb = type;
            EditTextForAbsorbDamagePassive();
        }
        static public PassiveEffect CreateAbsorbDamageEffect(ElementDamage element, TypeDamage type)
        {
            return new PassiveEffect(element, type);
        }
        private void EditTextForAbsorbDamagePassive()
        {
            Text = "Absorb ";
            if (ElementAbsorb != ElementDamage.Neutral)
                Text += ElementAbsorb.ToString().ToLower();
            if (TypeDamageAbsorb != TypeDamage.Hybrid)
                Text += TypeDamageAbsorb.ToString().ToLower();
            Text += " damage taken";
        }
        #endregion

        #endregion



        #region Support Passive - Statistiques Buff With Spécial Condition

        #region Propriétés
        /// <summary>
        /// If the passive buff statistiques with a spécial condition
        /// </summary>
        public bool IsBuffStatsSpecialCondition { get; set; }

        /// <summary>
        /// Statistiques buffed
        /// </summary>
        public StatistiquesBuff StatistiquesBuffSpecialCondition { get; set; }

        /// <summary>
        /// Coefficient of the buff
        /// </summary>
        public short CoefficientBuffSpecialCondition { get; set; }

        /// <summary>
        /// If the passive need a certain equipment to activate
        /// </summary>
        public string EquipmentSpecialCondition { get; set; }
        #endregion

        #region Méthodes
        private PassiveEffect(StatistiquesBuff stat, short coeff, string equipment)
        {
            IsBuffStatsSpecialCondition = true; StatistiquesBuffSpecialCondition = stat; CoefficientBuffSpecialCondition = coeff;
            EquipmentSpecialCondition = equipment;

            EditTextForStatistiquesBuffSpecialConditionPassive();
        }
        public static PassiveEffect CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff stat, short coeff, string equipment)
        {
            return new PassiveEffect(stat, coeff, equipment);
        }
        private void EditTextForStatistiquesBuffSpecialConditionPassive()
        {
            Text = "Increase ";

            {
                StatistiquesBuff t = StatistiquesBuffSpecialCondition;

                List<string> lt = new List<string>();
                if ((t - StatistiquesBuff.PSY) >= 0) { lt.Add(StatistiquesBuff.PSY.ToString() + "/"); t -= StatistiquesBuff.PSY; }
                if ((t - StatistiquesBuff.MAG) >= 0) { lt.Add(StatistiquesBuff.MAG.ToString() + "/"); t -= StatistiquesBuff.MAG; }
                if ((t - StatistiquesBuff.DEF) >= 0) { lt.Add(StatistiquesBuff.DEF.ToString() + "/"); t -= StatistiquesBuff.DEF; }

                if ((t - StatistiquesBuff.ATK) >= 0) { lt.Add(StatistiquesBuff.ATK.ToString() + "/"); t -= StatistiquesBuff.ATK; }
                if ((t - StatistiquesBuff.MP) >= 0) { lt.Add(StatistiquesBuff.MP.ToString() + "/"); t -= StatistiquesBuff.MP; }
                if ((t - StatistiquesBuff.HP) >= 0) { lt.Add(StatistiquesBuff.HP.ToString() + "/"); t -= StatistiquesBuff.HP; }


                for (int i = 0; i <= lt.Count; i++)
                {
                    string tt;
                    tt = lt[lt.Count - 1];
                    Text += tt;
                    lt.Remove(tt);
                }
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoefficientBuffSpecialCondition + "%) when equiped with ";

            if (!EquipmentSpecialCondition.Equals(""))
                Text += EquipmentSpecialCondition;

        }
        #endregion

        #endregion
    }
}
