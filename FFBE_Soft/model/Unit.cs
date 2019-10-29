﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFBE_Soft.model
{
    enum Weapon
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

    enum Armor
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



    class Unit
    {
        #region Attributs
        public string Name { get; set; }
        public string ImgURL { get; set; }
        public List<UnitStats> Stats { get; set; }
        public List<UnitStatsMaxUp> StatsMaxUp { get; set; }
        public UnitResistance Resistance { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public bool Accessory { get; set; }
        public byte AbilitySlots { get; set; }
        public UnitMagicAffinity MagicAffinity { get; set; }

        #endregion

        #region Constructeurs
        public Unit() { this.Stats = new List<UnitStats>(); this.StatsMaxUp = new List<UnitStatsMaxUp>(); }
        #endregion

        #region Methods
        public void AddStats(UnitStats s) { Stats.Add(s); }
        public void AddStatsMaxUp(UnitStatsMaxUp s) { StatsMaxUp.Add(s); }

        public static string GetWeaponString(Weapon weapon)
        {
            switch (weapon)
            {
                case Weapon.Dagger:
                    return "Dagger";
                case Weapon.Sword:
                    return "Sword";
                case Weapon.GreatSword:
                    return "GreatSword";
                case Weapon.Katana:
                    return "Katana";
                case Weapon.Staff:
                    return "Staff";
                case Weapon.Rod:
                    return "Rod";
                case Weapon.Bow:
                    return "Bow";
                case Weapon.Axe:
                    return "Axe";
                case Weapon.Hammer:
                    return "Hammer";
                case Weapon.Spear:
                    return "Spear";
                case Weapon.Instrument:
                    return "Instrument";
                case Weapon.Whip:
                    return "Whip";
                case Weapon.ThrowingWeapon:
                    return "ThrowingWeapon";
                case Weapon.Gun:
                    return "Gun";
                case Weapon.Mace:
                    return "Mace";
                case Weapon.Fist:
                    return "Fist";
                default:
                    return "---";
            }
        }
        public static List<string> GetWeaponsString(Weapon weapon)
        {
            List<string> list = new List<string>();

            if ((weapon - Weapon.Fist) >= 0) { list.Add(GetWeaponString(Weapon.Fist)); weapon -= Weapon.Fist; }
            if ((weapon - Weapon.Mace) >= 0) { list.Add(GetWeaponString(Weapon.Mace)); weapon -= Weapon.Mace; }
            if ((weapon - Weapon.Gun) >= 0) { list.Add(GetWeaponString(Weapon.Gun)); weapon -= Weapon.Gun; }
            if ((weapon - Weapon.ThrowingWeapon) >= 0) { list.Add(GetWeaponString(Weapon.ThrowingWeapon)); weapon -= Weapon.ThrowingWeapon; }
                
            if ((weapon - Weapon.Whip) >= 0) { list.Add(GetWeaponString(Weapon.Whip)); weapon -= Weapon.Whip; }
            if ((weapon - Weapon.Instrument) >= 0) { list.Add(GetWeaponString(Weapon.Instrument)); weapon -= Weapon.Instrument; }
            if ((weapon - Weapon.Spear) >= 0) { list.Add(GetWeaponString(Weapon.Spear)); weapon -= Weapon.Spear; }
            if ((weapon - Weapon.Hammer) >= 0) { list.Add(GetWeaponString(Weapon.Hammer)); weapon -= Weapon.Hammer; }
                
            if ((weapon - Weapon.Axe) >= 0) { list.Add(GetWeaponString(Weapon.Axe)); weapon -= Weapon.Axe; }
            if ((weapon - Weapon.Bow) >= 0) { list.Add(GetWeaponString(Weapon.Bow)); weapon -= Weapon.Bow; }
            if ((weapon - Weapon.Rod) >= 0) { list.Add(GetWeaponString(Weapon.Rod)); weapon -= Weapon.Rod; }
            if ((weapon - Weapon.Staff) >= 0) { list.Add(GetWeaponString(Weapon.Staff)); weapon -= Weapon.Staff; }
                
            if ((weapon - Weapon.Katana) >= 0) { list.Add(GetWeaponString(Weapon.Katana)); weapon -= Weapon.Katana; }
            if ((weapon - Weapon.GreatSword) >= 0) { list.Add(GetWeaponString(Weapon.GreatSword)); weapon -= Weapon.GreatSword; }
            if ((weapon - Weapon.Sword) >= 0) { list.Add(GetWeaponString(Weapon.Sword)); weapon -= Weapon.Sword; }
            if ((weapon - Weapon.Dagger) >= 0) { list.Add(GetWeaponString(Weapon.Dagger)); weapon -= Weapon.Dagger; }
                
            return list;
        }

        public static string GetArmorString(Armor armor)
        {
            switch (armor)
            {
                case Armor.LightShield:
                    return "Light Shield";
                case Armor.HeavyShield:
                    return "Heavy Shield";
                case Armor.Hat:
                    return "Hat";
                case Armor.Helm:
                    return "Helm";
                case Armor.Clothe:
                    return "Clothe";
                case Armor.LightArmor:
                    return "Light Armor";
                case Armor.HeavyArmor:
                    return "Heavy Armor";
                case Armor.Robe:
                    return "Robe";
                default:
                    return "---";
            }
        }
        public static List<string> GetArmorsString(Armor armor)
        {
            List<string> list = new List<string>();

            if((armor - Armor.Robe) >= 0) { list.Add(GetArmorString(Armor.Robe)); armor -= Armor.Robe; }
            if((armor - Armor.HeavyArmor) >= 0) { list.Add(GetArmorString(Armor.HeavyArmor)); armor -= Armor.HeavyArmor; }
            if((armor - Armor.LightArmor) >= 0) { list.Add(GetArmorString(Armor.LightArmor)); armor -= Armor.LightArmor; }
            if((armor - Armor.Clothe) >= 0) { list.Add(GetArmorString(Armor.Clothe)); armor -= Armor.Clothe; }

            if((armor - Armor.Helm) >= 0) { list.Add(GetArmorString(Armor.Helm)); armor -= Armor.Helm; }
            if((armor - Armor.Hat) >= 0) { list.Add(GetArmorString(Armor.Hat)); armor -= Armor.Hat; }
            if((armor - Armor.HeavyShield) >= 0) { list.Add(GetArmorString(Armor.HeavyShield)); armor -= Armor.HeavyShield; }
            if((armor - Armor.LightShield) >= 0) { list.Add(GetArmorString(Armor.LightShield)); armor -= Armor.LightShield; }

            return list;
        }
        #endregion
    }
}