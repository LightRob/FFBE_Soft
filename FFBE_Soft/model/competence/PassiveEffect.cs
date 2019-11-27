using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class PassiveEffect
    {
        /// <summary>
        /// Text of the passive effect
        /// </summary>
        public string Text { get; set; }


        #region Support Passive - Element Buff
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
        private PassiveEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            this.IsBuffElementResistance = isBuffElementResistance; this.ElementResistance = element; this.CoeffElementResistance = coeffElementResistance;

            // Text initialisation
            this.Text = "Increase ";
            ElementResistance t = element;

            List<string> lt = new List<string>();

            if ((t - ElementResistance.Dark) >= 0) { lt.Add( ElementResistance.Dark.ToString().ToLower() + "/" ); t -= ElementResistance.Dark; }
            if ((t - ElementResistance.Light) >= 0) { lt.Add( ElementResistance.Light.ToString().ToLower() + "/" ); t -= ElementResistance.Light; }
            if ((t - ElementResistance.Earth) >= 0) { lt.Add( ElementResistance.Earth.ToString().ToLower() + "/" ); t -= ElementResistance.Earth; }
            if ((t - ElementResistance.Wind) >= 0) { lt.Add( ElementResistance.Wind.ToString().ToLower() + "/" ); t -= ElementResistance.Wind; }

            if ((t - ElementResistance.Water) >= 0) { lt.Add( ElementResistance.Water.ToString().ToLower() + "/" ); t -= ElementResistance.Water; }
            if ((t - ElementResistance.Lightning) >= 0) { lt.Add( ElementResistance.Lightning.ToString().ToLower() + "/" ); t -= ElementResistance.Lightning; }
            if ((t - ElementResistance.Ice) >= 0) { lt.Add( ElementResistance.Ice.ToString().ToLower() + "/" ); t -= ElementResistance.Ice; }
            if ((t - ElementResistance.Fire) >= 0) { lt.Add( ElementResistance.Fire.ToString().ToLower() + "/" ); t -= ElementResistance.Fire; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " resistance (" + CoeffElementResistance + "%)";
        }
        static public PassiveEffect CreateElementResistanceEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            return new PassiveEffect(isBuffElementResistance, element, coeffElementResistance);
        }


        #region Support Passive - Ailment Buff
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
        private PassiveEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            this.IsBuffAilmentResistance = isBuffAilmentResistance; this.AilmentResistance = ailment; this.CoeffAilmentResistance = coeffAilmentResistance;

            // Text initialisation
            this.Text = "Increase resistance to ";
            AilmentResistance t = ailment;

            List<string> lt = new List<string>();

            if ((t - AilmentResistance.Charm) >= 0) { lt.Add( AilmentResistance.Charm.ToString().ToLower() + "/" ); t -= AilmentResistance.Charm; }
            if ((t - AilmentResistance.Stop) >= 0) { lt.Add( AilmentResistance.Stop.ToString().ToLower() + "/"); t -= AilmentResistance.Stop; }

            if ((t - AilmentResistance.Petrification) >= 0) { lt.Add( AilmentResistance.Petrification.ToString().ToLower() + "/"); t -= AilmentResistance.Petrification; }
            if ((t - AilmentResistance.Disease) >= 0) { lt.Add( AilmentResistance.Disease.ToString().ToLower() + "/"); t -= AilmentResistance.Disease; }
            if ((t - AilmentResistance.Confuse) >= 0) { lt.Add( AilmentResistance.Confuse.ToString().ToLower() + "/"); t -= AilmentResistance.Confuse; }
            if ((t - AilmentResistance.Paralysis) >= 0) { lt.Add( AilmentResistance.Paralysis.ToString().ToLower() + "/"); t -= AilmentResistance.Paralysis; }

            if ((t - AilmentResistance.Silence) >= 0) { lt.Add( AilmentResistance.Silence.ToString().ToLower() + "/"); t -= AilmentResistance.Silence; }
            if ((t - AilmentResistance.Sleep) >= 0) { lt.Add( AilmentResistance.Sleep.ToString().ToLower() + "/"); t -= AilmentResistance.Sleep; }
            if ((t - AilmentResistance.Blind) >= 0) { lt.Add( AilmentResistance.Blind.ToString().ToLower() + "/"); t -= AilmentResistance.Blind; }
            if ((t - AilmentResistance.Poison) >= 0) { lt.Add( AilmentResistance.Poison.ToString().ToLower() + "/"); t -= AilmentResistance.Poison; }

            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoeffAilmentResistance + "%)";
        }
        static public PassiveEffect CreateAilmentResistanceEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            return new PassiveEffect(isBuffAilmentResistance, ailment, coeffAilmentResistance);
        }


        #region Support Passive - Stats Buff
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
        private PassiveEffect(bool isBuffStats, StatistiquesBuff statistiques, short coeff)
        {
            this.IsBuffStats = isBuffStats; this.StatistiquesBuff = statistiques; this.CoeffStatsBuff = coeff;

            // Text initialisation
            this.Text = "Increase ";
            StatistiquesBuff t = statistiques;

            List<string> lt = new List<string>();
            if ((t - StatistiquesBuff.PSY) >= 0) { lt.Add( StatistiquesBuff.PSY.ToString() + "/" ); t -= StatistiquesBuff.PSY; }
            if ((t - StatistiquesBuff.MAG) >= 0) { lt.Add( StatistiquesBuff.MAG.ToString() + "/" ); t -= StatistiquesBuff.MAG; }
            if ((t - StatistiquesBuff.DEF) >= 0) { lt.Add( StatistiquesBuff.DEF.ToString() + "/" ); t -= StatistiquesBuff.DEF; }

            if ((t - StatistiquesBuff.ATK) >= 0) { lt.Add( StatistiquesBuff.ATK.ToString() + "/" ); t -= StatistiquesBuff.ATK; }
            if ((t - StatistiquesBuff.MP) >= 0) { lt.Add( StatistiquesBuff.MP.ToString() + "/" ); t -= StatistiquesBuff.MP; }
            if ((t - StatistiquesBuff.HP) >= 0) { lt.Add( StatistiquesBuff.HP.ToString() + "/" ); t -= StatistiquesBuff.HP; }


            for (int i = 0; i <= lt.Count; i++)
            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " (" + CoeffStatsBuff + "%)";
        }
        static public PassiveEffect CreateStatistiquesBuffEffect(bool isBuffStats, StatistiquesBuff statistiques, short coeff)
        {
            return new PassiveEffect(isBuffStats, statistiques, coeff);
        }


        #region Support Passive - Race Damage Buff
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
        private PassiveEffect(bool isBuffRaceDamage, MonsterRace monsterRace, TypeDamage typeDamage, short coeffRaceDamageBuff)
        {
            this.IsBuffRaceDamage = isBuffRaceDamage; this.MonsterRaceBuffDamage = monsterRace; this.TypeDamageRaceBuffDamage = typeDamage; this.CoeffRaceDamageBuff = coeffRaceDamageBuff;

            // Text initialisation
            this.Text = "Increase " + this.TypeDamageRaceBuffDamage.ToString().ToLower() + " damage against ";
            MonsterRace t = monsterRace;

            List<string> lt = new List<string>();

            if ((t - MonsterRace.Stones) >= 0) { lt.Add( MonsterRace.Stones.ToString().ToLower() + "/" ); t -= MonsterRace.Stones; }
            if ((t - MonsterRace.Reapers) >= 0) { lt.Add( MonsterRace.Reapers.ToString().ToLower() + "/" ); t -= MonsterRace.Reapers; }
            if ((t - MonsterRace.Plants) >= 0) { lt.Add( MonsterRace.Plants.ToString().ToLower() + "/" ); t -= MonsterRace.Plants; }
            if ((t - MonsterRace.Machinas) >= 0) { lt.Add( MonsterRace.Machinas.ToString().ToLower() + "/" ); t -= MonsterRace.Machinas; }

            if ((t - MonsterRace.Insects) >= 0) { lt.Add(  MonsterRace.Insects.ToString().ToLower() + "/" ); t -= MonsterRace.Insects; } 
            if ((t - MonsterRace.Humans) >= 0) { lt.Add( MonsterRace.Humans.ToString().ToLower() + "/" ); t -= MonsterRace.Humans; }
            if ((t - MonsterRace.Fairies) >= 0) { lt.Add(  MonsterRace.Fairies.ToString().ToLower() + "/" ); t -= MonsterRace.Fairies; }
            if ((t - MonsterRace.Dragons) >= 0) { lt.Add( MonsterRace.Dragons.ToString().ToLower() + "/" ); t -= MonsterRace.Dragons; }


            if ((t - MonsterRace.Demons) >= 0) { lt.Add( MonsterRace.Demons.ToString().ToLower() + "/" ); t -= MonsterRace.Demons; }
            if ((t - MonsterRace.Beasts) >= 0) { lt.Add( MonsterRace.Beasts.ToString().ToLower() + "/" ); t -= MonsterRace.Beasts; }
            if ((t - MonsterRace.Avians) >= 0) { lt.Add( MonsterRace.Avians.ToString().ToLower() + "/" ); t -= MonsterRace.Avians; }
            if ((t - MonsterRace.Aquatics) >= 0) { lt.Add( MonsterRace.Aquatics.ToString().ToLower() + "/" ); t -= MonsterRace.Aquatics; }
                                                                                     




            for (int i = 0; i <= lt.Count; i++)

            {
                string tt;
                tt = lt[lt.Count - 1];
                Text += tt;
                lt.Remove(tt);
            }

            Text = Text.Remove(Text.Length - 1) + " monsters (" + CoeffRaceDamageBuff + "%)";
        }
        static public PassiveEffect CreateMonsterRaceBuffEffect(bool isBuffRaceDamage, MonsterRace monsterRace, TypeDamage typeDamage, short coeffRaceDamageBuff)
        {
            return new PassiveEffect(isBuffRaceDamage, monsterRace, typeDamage, coeffRaceDamageBuff);
        }


        #region Support Passive - Ignore Fatal Damage
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
        private PassiveEffect(bool isIgnoreFatalDamage, byte chanceToIgnoreFatalDamage, byte percentAboveHPToIgnoreDamage, byte maxIgnoreFatalDamage)
        {
            this.IsIgnoreFatalDamage = isIgnoreFatalDamage; this.ChanceToIgnoreFatalDamage = chanceToIgnoreFatalDamage; this.PercentAboveHPToIgnoreFatalDamage = percentAboveHPToIgnoreDamage; this.MaxIgnoreFatalDamage = maxIgnoreFatalDamage;

            this.Text = "Chance to ignore fatal damage (" + this.ChanceToIgnoreFatalDamage + "%) when HP is above " + this.PercentAboveHPToIgnoreFatalDamage + "% (max " + this.MaxIgnoreFatalDamage + " time)";
        }
        static public PassiveEffect CreateIgnoreFatalDamageEffect(bool isIgnoreFatalDamage, byte chanceToIgnoreFatalDamage, byte percentAboveHPToIgnoreDamage, byte maxIgnoreFatalDamage)
        {
            return new PassiveEffect(isIgnoreFatalDamage, chanceToIgnoreFatalDamage, percentAboveHPToIgnoreDamage, maxIgnoreFatalDamage);
        }
    }
}
