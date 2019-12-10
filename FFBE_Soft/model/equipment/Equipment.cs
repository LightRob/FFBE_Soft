using FFBE_Soft.model.competence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.equipment
{
    #region Enum
    public enum EquipmentWeapon
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

    public enum EquipmentArmor
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

    public enum EquipmentType
    {
        Dagger,
        Sword,
        GreatSword,
        Katana,
        Staff,
        Rod,
        Bow,
        Axe,

        Hammer,
        Spear,
        Instrument,
        Whip,
        ThrowingWeapon,
        Gun,
        Mace,
        Fist,

        LightShield,
        HeavyShield,
        Hat,
        Helm,
        Clothe,
        LightArmor,
        HeavyArmor,
        Robe,

        Accesory
    }

    public enum StatBuffed
    {
        HP = 0x01,
        MP = 0x02,
        ATK = 0x04,
        DEF = 0x08,
        MAG = 0x10,
        PSY = 0x20
    }

    public enum Element
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

    public enum Ailment
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
    #endregion

    #region Struct
    public struct FixedStatEquipment
    {
        StatBuffed StatBuffed;
        short Coefficient;

        public FixedStatEquipment(StatBuffed s, short c)
        {
            StatBuffed = s;
            Coefficient = c;
        }
        override public string ToString()
        {
            return StatBuffed.ToString() + "+" + Coefficient;
        }
    }

    public struct PercentStatEquipment
    {
        StatBuffed StatBuffed;
        short Coefficient;

        public PercentStatEquipment(StatBuffed s, short c)
        {
            StatBuffed = s;
            Coefficient = c;
        }
        public override string ToString()
        {
            return StatBuffed.ToString() + "+" + Coefficient + "%";
        }
    }

    public struct ElementResistanceEquipment
    {
        Element Element;
        byte Resistance;

        public ElementResistanceEquipment(Element e, byte r)
        {
            Element = e;
            Resistance = r;
        }
        public override string ToString()
        {
            return Element.ToString() + " (+" + Resistance + "%)";
        }
    }

    public struct AilmentResistanceEquipment
    {
        Ailment Ailment;
        byte Resistance;

        public AilmentResistanceEquipment(Ailment a, byte r)
        {
            Ailment = a;
            Resistance = r;
        }
        public override string ToString()
        {
            return Ailment.ToString() + " (+" + Resistance + "%)";
        }
    }
    #endregion


    class Equipment
    {
        #region Propriétés
        /// <summary>
        /// Name of the equipment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the equipment
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Text to string
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// URL of the sprite
        /// </summary>
        public string ImgURL { get; set; }

        /// <summary>
        /// Type of the equipment
        /// </summary>
        public EquipmentType EquipmentType { get; set; }

        /// <summary>
        /// If the weapon is Two-Handed
        /// </summary>
        public bool TwoHandedWeapon { get; set; }

        /// <summary>
        /// Minimum of damage range
        /// </summary>
        public short MinDamageRange { get; set; }

        /// <summary>
        /// Maximum of damage range
        /// </summary>
        public short MaxDamageRange { get; set; }

        /// <summary>
        /// Accuracy of the weapon
        /// </summary>
        public byte Accuracy { get; set; }

        /// <summary>
        /// List of stats fixed type buff
        /// </summary>
        public List<FixedStatEquipment> FixedStatEquipment { get; set; }

        /// <summary>
        /// List of stats percent type buff
        /// </summary>
        public List<PercentStatEquipment> PercentStatEquipment { get; set; }

        /// <summary>
        /// Element of the equipment
        /// </summary>
        public Element ElementDamage { get; set; }

        /// <summary>
        /// Element resistance of the equipment
        /// </summary>
        public List<ElementResistanceEquipment> ElementResistances { get; set; }

        /// <summary>
        /// Ailment resistance of the equipment
        /// </summary>
        public List<AilmentResistanceEquipment> AilmentResistances { get; set; }

        /// <summary>
        /// Passives effect of the equipment
        /// </summary>
        public List<UnitPassive> EquipmentEffectsPassives { get; set; }

        /// <summary>
        /// Abilities effect to the equipment
        /// </summary>
        public List<UnitAbility> EquipmentEffectsAbilities { get; set; }

        /// <summary>
        /// How to obtain this equipment
        /// </summary>
        public string HowToObtain { get; set; }
        #endregion



        #region Méthodes
        static public Equipment CreateEquipment(string name, string descritpion, string url, EquipmentType type, string howToObtain)
        {
            return new Equipment(name, descritpion, url, type, howToObtain);
        }
        private void EditText()
        {
            Text = "";

            ///////////////////////////// ----------------------------------------------------------------- Statistiques Fixe / Percent


            if (FixedStatEquipment.Count > 0 || PercentStatEquipment.Count > 0)
            {
                if (FixedStatEquipment.Count > 0)
                {
                    for (int i = 0; i < FixedStatEquipment.Count; i++)
                        Text += FixedStatEquipment[i].ToString() + ", ";
                }
                if (PercentStatEquipment.Count > 0)
                {
                    for (int i = 0; i < PercentStatEquipment.Count; i++)
                        Text += PercentStatEquipment[i].ToString() + ", ";
                }

                Text = Text.Remove(Text.Length - 2);
            }
                

            ///////////////////////////// ----------------------------------------------------------------- Resistances Element / Ailment
            

            if(ElementDamage != Element.Neutral)
            {
                if (!Text.Equals(""))
                    Text += Environment.NewLine;
                Text += "Element: ";

                Element t = this.ElementDamage;

                List<string> lt = new List<string>();

                if ((t - Element.Dark) >= 0) { lt.Add(Element.Dark.ToString() + "/"); t -= Element.Dark; }
                if ((t - Element.Light) >= 0) { lt.Add(Element.Light.ToString() + "/"); t -= Element.Light; }
                if ((t - Element.Earth) >= 0) { lt.Add(Element.Earth.ToString() + "/"); t -= Element.Earth; }
                if ((t - Element.Wind) >= 0) { lt.Add(Element.Wind.ToString() + "/"); t -= Element.Wind; }
                         
                if ((t - Element.Water) >= 0) { lt.Add(Element.Water.ToString() + "/"); t -= Element.Water; }
                if ((t - Element.Lightning) >= 0) { lt.Add(Element.Lightning.ToString() + "/"); t -= Element.Lightning; }
                if ((t - Element.Ice) >= 0) { lt.Add(Element.Ice.ToString() + "/"); t -= Element.Ice; }
                if ((t - Element.Fire) >= 0) { lt.Add(Element.Fire.ToString()+ "/"); t -= Element.Fire; }

                for (int i = 0; i <= lt.Count; i++)
                {
                    string tt;
                    tt = lt[lt.Count - 1];
                    Text += tt;
                    lt.Remove(tt);
                }

                Text = Text.Remove(Text.Length - 1);
            }

            
            ///////////////////////////// ----------------------------------------------------------------- Resistances Element / Ailment


            if(ElementResistances.Count > 0 || AilmentResistances.Count > 0)
            {
                if (!Text.Equals(""))
                    Text += Environment.NewLine;
                Text += "Resistance: ";

                if(ElementResistances.Count > 0)
                {
                    foreach (ElementResistanceEquipment res in ElementResistances)
                    {
                        Text += res.ToString();
                        Text += ", ";
                    }
                }
                if(AilmentResistances.Count > 0)
                {
                    foreach (AilmentResistanceEquipment res in AilmentResistances)
                    {
                        Text += res.ToString();
                        Text += ", ";
                    }
                }

                Text = Text.Remove(Text.Length - 2);
            }


            ///////////////////////////// ----------------------------------------------------------------- Effect Passive / Ability / Damage Range / Accuracy


            if(EquipmentEffectsPassives.Count > 0 || EquipmentEffectsAbilities.Count > 0 || MinDamageRange > 0 || Accuracy > 0)
            {
                if (!Text.Equals(""))
                    Text += Environment.NewLine;
                Text += "Effect: ";

                if(EquipmentEffectsPassives.Count > 0)
                {
                    foreach (UnitPassive passive in EquipmentEffectsPassives)
                    {
                        Text += passive.Name;
                        if (passive.UsableWitheList)
                            Text += " (" + passive.GetWhiteListString() + " only)";
                        Text += ", ";
                    }
                }
                if(EquipmentEffectsAbilities.Count > 0)
                {
                    foreach (UnitAbility ability in EquipmentEffectsAbilities)
                    {
                        Text += ability.Name;
                        if (ability.UsableWitheList)
                            Text += " (" + ability.GetWhiteListString() + " only)";
                        Text += ", ";
                    }
                }
                if(MinDamageRange > 0)
                {
                    Text += "Damage range " + MinDamageRange + "% - " + MaxDamageRange + "%, ";
                }
                if(Accuracy > 0)
                {
                    Text += "Accuracy +" + Accuracy + "%, ";
                }

                Text = Text.Remove(Text.Length - 2);
            }


            ///////////////////////////// ----------------------------------------------------------------- Two-Handed / Single-Handed Weapon


            if (IsWeaponEquipment(EquipmentType))
            {
                if (!Text.Equals(""))
                    Text += Environment.NewLine;

                if (TwoHandedWeapon)
                    Text += "Two-Handed";
                else
                    Text += "Single-Handed";
                Text += " weapon";
            }

        }
        public void AddFixedStat(StatBuffed stat, short coeff)
        {
            FixedStatEquipment.Add(new FixedStatEquipment(stat, coeff));
            EditText();
        }
        public void AddPercentStat(StatBuffed stat, short coeff)
        {
            PercentStatEquipment.Add(new PercentStatEquipment(stat, coeff));
            EditText();
        }
        public void AddElementResistance(Element element, byte res)
        {
            ElementResistances.Add(new ElementResistanceEquipment(element, res));
            EditText();
        }
        public void AddAilmentResistance(Ailment ailment, byte res)
        {
            AilmentResistances.Add(new AilmentResistanceEquipment(ailment, res));
            EditText();
        }
        public void AddEquipmentEffectPassive(UnitPassive effect)
        {
            EquipmentEffectsPassives.Add(effect);
            EditText();
        }
        public void AddEquipmentEffectAbility(UnitAbility effect)
        {
            EquipmentEffectsAbilities.Add(effect);
            EditText();
        }
        public void AddTwoHandedWeapon(short minRange, short maxRange, byte accuracy)
        {
            TwoHandedWeapon = true; MinDamageRange = minRange; MaxDamageRange = maxRange; Accuracy = accuracy;

            EditText();
        }
        private bool IsWeaponEquipment(EquipmentType type)
        {
            switch (EquipmentType)
            {
                case EquipmentType.LightShield:
                    return false;
                case EquipmentType.HeavyShield:
                    return false;
                case EquipmentType.Hat:
                    return false;
                case EquipmentType.Helm:
                    return false;
                case EquipmentType.Clothe:
                    return false;
                case EquipmentType.LightArmor:
                    return false;
                case EquipmentType.HeavyArmor:
                    return false;
                case EquipmentType.Robe:
                    return false;
                case EquipmentType.Accesory:
                    return false;
                default:
                    return true;
            }
        }
        #endregion



        #region Constructors
        private Equipment(string name, string descritpion, string url, EquipmentType type, string howToObtain)
        {
            Name = name; Description = descritpion; ImgURL = url; EquipmentType = type; HowToObtain = howToObtain; ElementDamage = Element.Neutral;
            FixedStatEquipment = new List<FixedStatEquipment>();
            PercentStatEquipment = new List<PercentStatEquipment>();
            ElementResistances = new List<ElementResistanceEquipment>();
            AilmentResistances = new List<AilmentResistanceEquipment>();
            EquipmentEffectsPassives = new List<UnitPassive>();
            EquipmentEffectsAbilities = new List<UnitAbility>();

            EditText();
        }
        #endregion
    }
}
