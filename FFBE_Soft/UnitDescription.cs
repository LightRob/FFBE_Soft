using FFBE_Soft.model;
using FFBE_Soft.model.competence;
using FFBE_Soft.model.equipment;
using FFBE_Soft.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Documents;
using System.Windows.Forms;

namespace FFBE_Soft
{
    public partial class UnitDescription : Form
    {
        ResourceManager rm = Resources.ResourceManager;

        Unit unit;
        public UnitDescription()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            

            CreateLeftPanel(unit);
            CreateUnitStatListView(unit.Stats, this.listView_UnitStats);
            CreateUnitStatUpListView(unit.StatsMaxUp, this.listView_UnitStatUp);
            CreateUnitStatMaxUpListView(unit.Stats, unit.StatsMaxUp, this.listView_UnitMaxUp);
            CreateUnitResTableView(unit.Resistance, this.tableLayoutPanel_Resistance);
            CreateAbilityGridData(unit.Abilities, this.dataGridView_Ability);
            CreatePassivesGridData(unit.Passives, this.dataGridView_Passives);
            CreateLimitGridData(unit.Limits, this.dataGridView_Limit);
            CreateEquipExcluGridData(unit.ExclusiveEquipments, dataGridView_EquipmentExclusive);
        }

        public UnitDescription(string name)
        {
            //unit = this.SetEstherBDD();
            unit = SetWoLCGIBDD();

            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;



            CreateLeftPanel(unit);
            CreateUnitStatListView(unit.Stats, this.listView_UnitStats);
            CreateUnitStatUpListView(unit.StatsMaxUp, this.listView_UnitStatUp);
            CreateUnitStatMaxUpListView(unit.Stats, unit.StatsMaxUp, this.listView_UnitMaxUp);
            CreateUnitResTableView(unit.Resistance, this.tableLayoutPanel_Resistance);
            CreateAbilityGridData(unit.Abilities, this.dataGridView_Ability);
            CreatePassivesGridData(unit.Passives, this.dataGridView_Passives);
            CreateLimitGridData(unit.Limits, this.dataGridView_Limit);
            CreateEquipExcluGridData(unit.ExclusiveEquipments, dataGridView_EquipmentExclusive);
        }

        private Unit SetWoLCGIBDD()
        {
            Unit u = new Unit();

            #region WoL Stats
            UnitStats s5 = new UnitStats
            {
                Star = 5,
                HP = 2950,
                MP = 127,
                ATK = 99,
                DEF = 124,
                MAG = 89,
                SPR = 117,
                AttackHits = 5,
                LimitDrop = 2,
                ExpPattern = 6
            };
            UnitStats s6 = new UnitStats
            {
                Star = 6,
                HP = 3836,
                MP = 166,
                ATK = 129,
                DEF = 162,
                MAG = 116,
                SPR = 153,
                AttackHits = 5,
                LimitDrop = 3,
                ExpPattern = 6
            };
            UnitStats s7 = new UnitStats
            {
                Star = 7,
                HP = 4987,
                MP = 216,
                ATK = 168,
                DEF = 211,
                MAG = 151,
                SPR = 200,
                AttackHits = 5,
                LimitDrop = 3,
                ExpPattern = 6
            };

            UnitStatsMaxUp su5 = new UnitStatsMaxUp
            {
                Star = 5,
                HP = 240,
                MP = 40,
                ATK = 16,
                DEF = 24,
                MAG = 16,
                SPR = 16
            };
            UnitStatsMaxUp su6 = new UnitStatsMaxUp
            {
                Star = 6,
                HP = 390,
                MP = 65,
                ATK = 26,
                DEF = 34,
                MAG = 26,
                SPR = 26
            };
            UnitStatsMaxUp su7 = new UnitStatsMaxUp
            {
                Star = 7,
                HP = 540,
                MP = 90,
                ATK = 40,
                DEF = 65,
                MAG = 40,
                SPR = 40
            };

            UnitResistance r = new UnitResistance()
            {
                Fire = 0,
                Ice = 0,
                Lightning = 0,
                Water = 0,
                Wind = 0,
                Earth = 0,
                Light = 100,
                Dark = 0,

                Poison = 0,
                Blind = 0,
                Sleep = 0,
                Silence = 0,
                Paralysis = 0,
                Confuse = 0,
                Disease = 0,
                Petrification = 0,
            };

            UnitMagicAffinity ma = new UnitMagicAffinity()
            {
                WhiteMagicLvl = 8,
                BlackMagicLvl = 0,
                GreenMagicLvl = 0,
                BlueMagicLvl = 0
            };
            // -------------------------------------------------------------

            u.Name = "Awakened Warrior of Light";
            u.ImgURL = "WoL_Img";
            u.Gender = Gender.Male;
            u.Race = UnitRace.Human;
            u.AddStats(s5);
            u.AddStats(s6);
            u.AddStats(s7);
            u.AddStatsMaxUp(su5);
            u.AddStatsMaxUp(su6);
            u.AddStatsMaxUp(su7);
            u.Resistance = r;
            u.Weapon = Weapon.Dagger | Weapon.Sword | Weapon.GreatSword | Weapon.Katana | Weapon.Staff | Weapon.Rod | Weapon.Bow | Weapon.Axe | Weapon.Hammer | Weapon.Spear | Weapon.Mace | Weapon.Fist;
            u.Armor = Armor.LightShield | Armor.HeavyShield | Armor.Hat | Armor.Helm | Armor.Clothe | Armor.LightArmor | Armor.HeavyArmor | Armor.Robe;
            u.Accessory = true;
            u.AbilitySlots = 4;
            u.MagicAffinity = ma;

            // TMR
            {
                Equipment S_L = Equipment.CreateEquipment("Sword of Light", "A sword that came from a faraway world.The center of the sword's guard is inlaid with a beautiful jewel. It is said that a legendary warrior journeyed all across the world with this sword in order to restore the Crystal's light."
                    , "Icon-Sword_of_Light", EquipmentType.Sword, "Awakened Warrior of Light TMR");
                S_L.AddFixedStat(StatBuffed.ATK, 72); S_L.AddFixedStat(StatBuffed.DEF, 46); S_L.AddPercentStat(StatBuffed.DEF, 20);

                PassiveEffect GL_1_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 20);
                PassiveEffect GL_1_2 = PassiveEffect.CreateAutoRegenMPEffect(5);
                UnitPassive GL_1 = new UnitPassive(0, 0, "Icon-Ability_77", "Guiding Light"); GL_1.UsableWitheList = true; GL_1.AddUnitToWhiteList("Warrior of Light"); GL_1.AddUnitToWhiteList("Awakened Warrior of Light");
                GL_1.AddPassiveEffect(GL_1_1);
                GL_1.AddPassiveEffect(GL_1_2);

                S_L.AddEquipmentEffectPassive(GL_1);

                u.AddTMR(S_L);
            }

            // STMR
            {
                Equipment S_L = Equipment.CreateEquipment("Shield of Light", "A heavy shield that came from a faraway world. Although it has a relatively simple and subdued design, its hidden potential makes it exceed that of many shields. It is said that a legendary warrior who attempted to fight against entities that tried to plunge the world into darkness once wielded this shield."
                    , "Icon-Shield_of_Light", EquipmentType.HeavyShield, "Awakened Warrior of Light STMR");
                S_L.AddFixedStat(StatBuffed.DEF, 108); S_L.AddFixedStat(StatBuffed.PSY, 52);
                S_L.AddElementResistance(Element.Water, 30);
                S_L.AddElementResistance(Element.Wind, 30);
                S_L.AddElementResistance(Element.Earth, 30);
                S_L.AddElementResistance(Element.Dark, 30);

                AbilityEffect S1_1 = AbilityEffect.CreateMitigationEffect(TypeMitigation.Physical, 10, 1, AbilityTarget.Caster);
                UnitAbility S1 = new UnitAbility(0, 0, "Icon-Ability_43", "Sentinel", 0);

                PassiveEffect S_L1_1 = PassiveEffect.CreateAutoCastAbilityEffect(S1);
                UnitPassive S_L1 = new UnitPassive(0, 0, "Icon-Ability_43", "Sentinel");
                S_L1.AddPassiveEffect(S_L1_1);

                S_L.AddEquipmentEffectPassive(S_L1);

                u.AddSTMR(S_L);
            }
            #endregion

            #region WoL Abilities

            // ---- Guardian's Wall of Light
            {
                AbilityEffect GWL_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.DEF, ElementDamage.Neutral, 380, 0, AbilityTarget.SingleTargetEnemy, 7);
                AbilityEffect GWL_2 = AbilityEffect.CreateHPBarrierEffect(1000, 3, AbilityTarget.AreaOfEffectAllies);
                UnitAbility GWL = new UnitAbility(5, 1, "Icon-Ability_54", "Guardian's Wall of Light", 48);
                GWL.AddCompEffect(GWL_1);
                GWL.AddCompEffect(GWL_2);
                u.AddAbility(GWL);
            }

            // ---- Vanguard Glaive
            {
                AbilityEffect VG_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.DEF, ElementDamage.Neutral, 150, 0, AbilityTarget.SingleTargetEnemy, 2);
                AbilityEffect VG_2 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.DEF, ElementDamage.Neutral, 150, 0, AbilityTarget.SingleTargetEnemy, 3);
                AbilityEffect VG_3 = AbilityEffect.CreateTauntEffect(100, 3, AbilityTarget.Caster);
                AbilityEffect VG_4 = AbilityEffect.CreateLBGaugeFillRateEffect(150, 3, AbilityTarget.Caster);
                UnitAbility VG = new UnitAbility(5, 11, "Icon-Ability_54", "Vanguard Glaive", 24);
                VG.AddCompEffect(VG_1);
                VG.AddCompEffect(VG_2);
                VG.AddCompEffect(VG_3);
                VG.AddCompEffect(VG_4);
                u.AddAbility(VG);
            }

            #endregion

            return u;
        }

        private Unit SetEstherBDD()
        {
            Unit u = new Unit();

            #region Esther Stats

            

            UnitStats s5 = new UnitStats
            {
                Star = 5,
                HP = 2874,
                MP = 126,
                ATK = 123,
                DEF = 114,
                MAG = 96,
                SPR = 108,
                AttackHits = 7,
                LimitDrop = 1,
                ExpPattern = 6
            };

            UnitStats s6 = new UnitStats
            {
                Star = 6,
                HP = 3736,
                MP = 163,
                ATK = 159,
                DEF = 148,
                MAG = 124,
                SPR = 140,
                AttackHits = 7,
                LimitDrop = 2,
                ExpPattern = 6
            };

            UnitStats s7 = new UnitStats
            {
                Star = 7,
                HP = 4856,
                MP = 211,
                ATK = 206,
                DEF = 192,
                MAG = 161,
                SPR = 182,
                AttackHits = 7,
                LimitDrop = 2,
                ExpPattern = 6
            };

            UnitStatsMaxUp su5 = new UnitStatsMaxUp
            {
                Star = 5,
                HP = 240,
                MP = 40,
                ATK = 24,
                DEF = 16,
                MAG = 16,
                SPR = 16
            };

            UnitStatsMaxUp su6 = new UnitStatsMaxUp
            {
                Star = 6,
                HP = 390,
                MP = 65,
                ATK = 34,
                DEF = 26,
                MAG = 26,
                SPR = 26
            };

            UnitStatsMaxUp su7 = new UnitStatsMaxUp
            {
                Star = 7,
                HP = 540,
                MP = 90,
                ATK = 65,
                DEF = 40,
                MAG = 40,
                SPR = 40
            };

            UnitResistance r = new UnitResistance()
            {
                Fire = 0,
                Ice = 0,
                Lightning = 0,
                Water = 0,
                Wind = 0,
                Earth = 0,
                Light = 0,
                Dark = 0,

                Poison = 0,
                Blind = 0,
                Sleep = 0,
                Silence = 0,
                Paralysis = 0,
                Confuse = 0,
                Disease = 0,
                Petrification = 0,
            };

            UnitMagicAffinity ma = new UnitMagicAffinity()
            {
                WhiteMagicLvl = 0,
                BlackMagicLvl = 0,
                GreenMagicLvl = 0,
                BlueMagicLvl = 0
            };
            // -------------------------------------------------------

            u.Name = "Esther";
            u.ImgURL = "Esther_Idle";
            u.Gender = Gender.Female;
            u.Race = UnitRace.Human;
            u.AddStats(s5);
            u.AddStats(s6);
            u.AddStats(s7);
            u.AddStatsMaxUp(su5);
            u.AddStatsMaxUp(su6);
            u.AddStatsMaxUp(su7);
            u.Resistance = r;
            u.Weapon = Weapon.Dagger | Weapon.Sword | Weapon.GreatSword | Weapon.Katana | Weapon.Axe | Weapon.Hammer | Weapon.Spear | Weapon.Mace | Weapon.Fist;
            u.Armor = Armor.Hat | Armor.Helm | Armor.Clothe | Armor.LightArmor | Armor.Robe;
            u.Accessory = true;
            u.AbilitySlots = 4;
            u.MagicAffinity = ma;

            // ---- TMR
            {
                Equipment S_K = Equipment.CreateEquipment("Storm Kickers", "A pair of sneackers said to have belonged to a warrior of legend. On the right set of feet these stylish shoes are capable of granting its wearer the power to withstand lightning."
                    , "Icon-Storm_Kickers", EquipmentType.Accessory, "TMR Esther");
                S_K.AddFixedStat(StatBuffed.ATK, 45); S_K.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect S_K1_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 20);
                PassiveEffect S_K1_2 = PassiveEffect.CreateLBDamageEffect(15);
                UnitPassive S_K1 = new UnitPassive(0, 0, "Icon-Ability_276", "Inner Limit");
                S_K1.AddPassiveEffect(S_K1_1);
                S_K1.AddPassiveEffect(S_K1_2);
                S_K.AddEquipmentEffectPassive(S_K1);

                PassiveEffect S_K2_1 = PassiveEffect.CreateAbsorbDamageEffect(ElementDamage.Lightning, TypeDamage.Hybrid);
                UnitPassive S_K2 = new UnitPassive(0, 0, "Icon-Ability_280", "Stormborne"); S_K2.UsableWitheList = true; S_K2.AddUnitToWhiteList("Esther");
                S_K2.AddPassiveEffect(S_K2_1);
                S_K.AddEquipmentEffectPassive(S_K2);

                u.AddTMR(S_K);
            }

            // ---- STMR
            {
                Equipment SBJ = Equipment.CreateEquipment("Storm Bunny Jacket", "A unique jacket with a hood that ressembles rabbit ears. It fills its wearer with the instincts of a swift killer, and adds to their endurance and strength as well. Woven with the finest fabric of a distant world, it was exclusively made for a certain warrior of legend.",
                    "Icon-Storm_Bunny_Jacket", EquipmentType.Clothe, "STMR Esther");
                SBJ.AddFixedStat(StatBuffed.HP, 800); SBJ.AddFixedStat(StatBuffed.ATK, 40); SBJ.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect SBJ1_1 = PassiveEffect.CreateMonsterRaceBuffEffect(MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Hybrid, 50);
                UnitPassive SBJ1 = new UnitPassive(0, 0, "Icon-Ability_275", "Killer Instincts");
                SBJ1.AddPassiveEffect(SBJ1_1);
                SBJ.AddEquipmentEffectPassive(SBJ1);

                PassiveEffect SBJ2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 20);
                PassiveEffect SBJ2_2 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 30);
                UnitPassive SBJ2 = new UnitPassive(0, 0, "Icon-Ability_276", "Exquisite Weaving"); SBJ2.UsableWitheList = true; SBJ2.AddUnitToWhiteList("Esther");
                SBJ2.AddPassiveEffect(SBJ2_1);
                SBJ2.AddPassiveEffect(SBJ2_2);
                SBJ.AddEquipmentEffectPassive(SBJ2);

                u.AddSTMR(SBJ);
            }

            #endregion


            #region Ability

            // ---- Shock Flash
            {
                AbilityEffect S_F1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 300, 0, AbilityTarget.SingleTargetEnemy, 7);
                AbilityEffect S_F2 = AbilityEffect.CreateLimitGaugeEffect(0, 4, 6, AbilityTarget.Caster);
                UnitAbility S_F = new UnitAbility(5, 5, "Icon-Ability_272", "Shock Flash", 22);
                S_F.AddCompEffect(S_F1);
                S_F.AddCompEffect(S_F2);
                u.AddAbility(S_F);
            }

            // ---- Shatter Arms
            {
                AbilityEffect S_A1 = AbilityEffect.CreateDebuffEnemyEffect(StatsDebuffed.ATK | StatsDebuffed.MAG, 50, 5, AbilityTarget.SingleTargetEnemy);
                AbilityEffect S_A2 = AbilityEffect.CreateLimitGaugeEffect(0, 6, 8, AbilityTarget.Caster);
                UnitAbility S_A = new UnitAbility(5, 38, "Icon-Ability_278", "Shatter Arms", 38);
                S_A.AddCompEffect(S_A1);
                S_A.AddCompEffect(S_A2);
                u.AddAbility(S_A);
            }

            // ---- Shatter Guard
            { 
                AbilityEffect S_G1 = AbilityEffect.CreateDebuffEnemyEffect(StatsDebuffed.DEF | StatsDebuffed.PSY, 50, 5, AbilityTarget.SingleTargetEnemy);
                AbilityEffect S_G2 = AbilityEffect.CreateLimitGaugeEffect(0, 6, 8, AbilityTarget.Caster);
                UnitAbility S_G = new UnitAbility(5, 38, "Icon-Ability_278", "Shatter Guard", 38);
                S_G.AddCompEffect(S_G1);
                S_G.AddCompEffect(S_G2);
                u.AddAbility(S_G);
            }

            // ---- Shock Reflex
            {
                AbilityEffect S_R1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 80, 0, AbilityTarget.SingleTargetEnemy, 7); S_R1.AddHPDrain(50);
                AbilityEffect S_R2 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 160, 50, AbilityTarget.SingleTargetEnemy, 7);
                UnitAbility S_R = new UnitAbility(5, 55, "Icon-Ability_274", "Shock Reflex", 45);
                S_R.AddCompEffect(S_R1);
                S_R.AddCompEffect(S_R2);
                u.AddAbility(S_R);
            }

            // ---- Charged Protection
            {
                AbilityEffect C_P1 = AbilityEffect.CreateCoverEffect(TypeCover.Physical, 50, 0, 50, 70, 1, AbilityTarget.Caster);
                AbilityEffect C_P2 = AbilityEffect.CreateBuffAlliesEffect(StatsBuffed.DEF, 150, 1, AbilityTarget.Caster);
                UnitAbility C_P = new UnitAbility(5, 80, "Icon-Ability_69", "Charged Protection", 32);
                C_P.AddCompEffect(C_P1);
                C_P.AddCompEffect(C_P2);
                u.AddAbility(C_P);
            }

            // ---- Storm Brand
            {
                AbilityEffect S_B1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 280, 50, AbilityTarget.SingleTargetEnemy, 9);
                AbilityEffect S_B2 = AbilityEffect.CreateElementImbueEffect(ElementImbue.Lightning, 5, AbilityTarget.Caster);
                AbilityEffect S_B3 = AbilityEffect.CreateLimitGaugeEffect(15, 0, 0, AbilityTarget.Caster);
                UnitAbility S_B = new UnitAbility(6, 16, "Icon-Ability_271", "Storm Brand", 35);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);
                S_B.AddCompEffect(S_B3);
                u.AddAbility(S_B);
            }

            // ---- Storm Calling
            {
                AbilityEffect S_C1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 430, 0, AbilityTarget.SingleTargetEnemy, 8);
                AbilityEffect S_C2 = AbilityEffect.CreateHealHPEffect(2500, 0, 0, 0, AbilityTarget.Caster);
                S_C2.AddHealMPToAbility(65, 0, 0, 0, AbilityTarget.Caster);
                AbilityEffect S_C3 = AbilityEffect.CreateLimitGaugeEffect(10, 0, 0, AbilityTarget.Caster);
                UnitAbility S_C = new UnitAbility(6, 42, "Icon-Ability_272", "Storm Calling", 40);
                S_C.AddCompEffect(S_C1);
                S_C.AddCompEffect(S_C2);
                S_C.AddCompEffect(S_C3);
                u.AddAbility(S_C);
            }

            // ---- Stasis Bound
            {
                AbilityEffect S_B1 = AbilityEffect.CreateTauntEffect(100, 2, AbilityTarget.Caster);
                AbilityEffect S_B2 = AbilityEffect.CreateMitigationEffect(TypeMitigation.Physical, 20, 2, AbilityTarget.Caster);
                UnitAbility S_B = new UnitAbility(6, 65, "Icon-Ability_94", "Stasis Bound", 30);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);
                u.AddAbility(S_B);
            }

            // ---- Demagnetizing Strike
            {
                AbilityEffect D_S1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 350, 50, AbilityTarget.SingleTargetEnemy, 9);
                AbilityEffect D_S2 = AbilityEffect.CreateDebuffElementEffect(ElementDebuffed.Lightning, 75, 3, AbilityTarget.SingleTargetEnemy);
                AbilityEffect D_S3 = AbilityEffect.CreateLimitGaugeEffect(15, 0, 0, AbilityTarget.Caster);
                UnitAbility D_S = new UnitAbility(6, 74, "Icon-Ability_271", "Demagnetizing Strike", 38);
                D_S.AddCompEffect(D_S1);
                D_S.AddCompEffect(D_S2);
                D_S.AddCompEffect(D_S3);
                u.AddAbility(D_S);
            }

            // ---- Electric Charge
            {
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect E_C1 = AbilityEffect.CreateMultipleSkillEffect(2, abilities);
                UnitAbility E_C = new UnitAbility(6, 100, "Icon-Ability_8", "Electric Charge", 0);
                E_C.AddCompEffect(E_C1);
                u.AddAbility(E_C);
            }

            // ---- Combat Overdrive
            {
                AbilityEffect C_O1 = AbilityEffect.CreateBuffAlliesEffect(StatsBuffed.ATK, 200, 3, AbilityTarget.Caster);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect C_O2 = AbilityEffect.CreateAbilityCoeffUpEffect(150, abilities, 4, false, AbilityTarget.Caster);
                List<UnitAbility> abilities2 = new List<UnitAbility>();
                AbilityEffect C_O3 = AbilityEffect.CreateGiveAbilityEffect(abilities2, 2, AbilityTarget.Caster);
                UnitAbility C_O = new UnitAbility(6, 100, "Icon-Ability_63", "Combat Overdrive", 48);
                C_O.AddCompEffect(C_O1);
                C_O.AddCompEffect(C_O2);
                C_O.AddCompEffect(C_O3);
                u.AddAbility(C_O);
            }

            // ---- Shock Embrace
            {
                AbilityEffect S_E1 = AbilityEffect.CreateCooldownEffect(5, true);
                AbilityEffect S_E2 = AbilityEffect.CreateDebuffElementEffect(ElementDebuffed.Lightning, 100, 5, AbilityTarget.AreaOfEffectEnemies);
                AbilityEffect S_E3 = AbilityEffect.CreateElementImbueEffect(ElementImbue.Lightning, 5, AbilityTarget.Caster);
                AbilityEffect S_E4 = AbilityEffect.CreateLimitGaugeEffect(20, 0, 0, AbilityTarget.Caster);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect S_E5 = AbilityEffect.CreateGiveAbilityEffect(abilities, 4, AbilityTarget.Caster);
                UnitAbility S_E = new UnitAbility(7, 105, "Icon-Ability_105", "Shock Embrace", 100);
                S_E.AddCompEffect(S_E1);
                S_E.AddCompEffect(S_E2);
                S_E.AddCompEffect(S_E3);
                S_E.AddCompEffect(S_E4);
                S_E.AddCompEffect(S_E5);
                u.AddAbility(S_E);
            }

            // ---- Storm Clouds
            {
                AbilityEffect S_C1 = AbilityEffect.CreateCooldownEffect(4, false);
                AbilityEffect S_C2 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1100, 0, AbilityTarget.SingleTargetEnemy, 8);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect S_C3 = AbilityEffect.CreateAbilityCoeffUpEffect(300, abilities, 2, false, AbilityTarget.Caster);
                AbilityEffect S_C4 = AbilityEffect.CreateLimitGaugeEffect(30, 0, 0, AbilityTarget.Caster);
                UnitAbility S_C = new UnitAbility(7, 105, "Icon-Ability_105", "Storm Clouds", 88);
                S_C.AddCompEffect(S_C1);
                S_C.AddCompEffect(S_C2);
                S_C.AddCompEffect(S_C3);
                S_C.AddCompEffect(S_C4);
                u.AddAbility(S_C);
            }

            // ---- Bolting Strike
            {
                AbilityEffect B_S1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 400, 50, AbilityTarget.AreaOfEffectEnemies, 9);
                AbilityEffect B_S2 = AbilityEffect.CreateDebuffEnemyEffect(StatsDebuffed.DEF, 60, 5, AbilityTarget.AreaOfEffectEnemies);
                AbilityEffect B_S3 = AbilityEffect.CreateLimitGaugeEffect(20, 0, 0, AbilityTarget.Caster);
                UnitAbility B_S = new UnitAbility(7, 110, "Icon-Ability_271", "Bolting Strike", 42);
                B_S.AddCompEffect(B_S1);
                B_S.AddCompEffect(B_S2);
                B_S.AddCompEffect(B_S3);
                u.AddAbility(B_S);
            }
            #endregion


            #region Passive

            // ---- Unstoppable Fervor
            {
                PassiveEffect U_F1 = PassiveEffect.CreateElementResistanceEffect(ElementResistance.Earth, 50);
                PassiveEffect U_F2 = PassiveEffect.CreateAilmentResistanceEffect(AilmentResistance.Paralysis | AilmentResistance.Petrification, 100);
                PassiveEffect U_F3 = PassiveEffect.CreateAilmentResistanceEffect(AilmentResistance.Stop | AilmentResistance.Charm, 100);
                UnitPassive U_F = new UnitPassive(5, 26, "Icon-Ability_19", "Unstoppable Fervor");
                U_F.AddPassiveEffect(U_F1);
                U_F.AddPassiveEffect(U_F2);
                U_F.AddPassiveEffect(U_F3);
                u.AddPassive(U_F);
            }

            // ---- Terra Resonance
            {
                PassiveEffect T_R1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP | StatistiquesBuff.DEF, 20);
                PassiveEffect T_R2 = PassiveEffect.CreateMonsterRaceBuffEffect(MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Physical, 100);
                UnitPassive T_R = new UnitPassive(5, 42, "Icon-Ability_275", "Terra Resonance");
                T_R.AddPassiveEffect(T_R1);
                T_R.AddPassiveEffect(T_R2);
                u.AddPassive(T_R);
            }

            // ---- Ionized Fragment
            {
                PassiveEffect I_F1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 30);
                UnitPassive I_F = new UnitPassive(5, 64, "Icon-Ability_276", "Ionized Fragment");
                I_F.AddPassiveEffect(I_F1);
                u.AddPassive(I_F);
            }

            // ---- Overcharge
            {
                PassiveEffect O1 = PassiveEffect.CreateIgnoreFatalDamageEffect(80, 10, 1);
                UnitPassive O = new UnitPassive(6, 1, "Icon-Ability_277", "Overcharge");
                O.AddPassiveEffect(O1);
                u.AddPassive(O);
            }

            // ---- Reverse Polarity
            {
                AbilityEffect S_B1 = AbilityEffect.CreateDamageEffect(TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 250, 0, AbilityTarget.SingleTargetEnemy, 7);
                S_B1.AddConsecutive(4, 50, 450);
                AbilityEffect S_B2 = AbilityEffect.CreateDebuffEnemyEffect(StatsDebuffed.ATK | StatsDebuffed.DEF | StatsDebuffed.MAG | StatsDebuffed.PSY, 50, 1, AbilityTarget.SingleTargetEnemy);
                UnitAbility S_B = new UnitAbility(0, 0, "icon", "Static Barrage", 0);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);

                PassiveEffect R_P1 = PassiveEffect.CreateChanceToCounterEffect(CounterType.Physical, 40, S_B, 4);
                PassiveEffect R_P2 = PassiveEffect.CreateChanceToCounterEffect(CounterType.Magical, 40, S_B, 4);
                UnitPassive R_P = new UnitPassive(6, 24, "Icon-Ability_279", "Reverse Polarity");
                R_P.AddPassiveEffect(R_P1);
                R_P.AddPassiveEffect(R_P2);
                u.AddPassive(R_P);
            }

            // ---- Magnetic Grip
            {
                PassiveEffect M_G1 = PassiveEffect.CreateEquipmentBuffEffect(EquipmentStat.ATK, 100, 25, EquipmentBuffCondition.TrueDoubleHand);
                UnitPassive M_G = new UnitPassive(6, 38, "Icon-Ability_76", "Magnetic Grip");
                M_G.AddPassiveEffect(M_G1);
                u.AddPassive(M_G);
            }

            // ---- Phase Shift
            {
                PassiveEffect P_S1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP | StatistiquesBuff.MP | StatistiquesBuff.ATK | StatistiquesBuff.DEF, 20);
                PassiveEffect P_S2 = PassiveEffect.CreateEvasionEffect(EvasionType.Physical, 30);
                PassiveEffect P_S3 = PassiveEffect.CreateAutoRegenMPEffect(7);

                AbilityEffect S_S1 = AbilityEffect.CreateDamageEffect(TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 500, 0, AbilityTarget.Caster, 1);
                UnitAbility S_S = new UnitAbility(0, 0, "icon", "Static Shift", 0);
                S_S.AddCompEffect(S_S1);

                PassiveEffect P_S4 = PassiveEffect.CreateAutoCastAbilityEffect(S_S);
                UnitPassive P_S = new UnitPassive(6, 56, "Icon-Ability_273", "Phase Shift");
                P_S.AddPassiveEffect(P_S1);
                P_S.AddPassiveEffect(P_S2);
                P_S.AddPassiveEffect(P_S3);
                P_S.AddPassiveEffect(P_S4);
                u.AddPassive(P_S);
            }

            // ---- Stasis Field
            {
                PassiveEffect S_F1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 20);
                PassiveEffect S_F2 = PassiveEffect.CreateStatistiquesBuffArmorConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.DEF, 40, ArmorBuffCondition.Clothe);

                UnitPassive S_F = new UnitPassive(6, 86, "Icon-Ability_276", "Stasis Field");
                S_F.AddPassiveEffect(S_F1);
                S_F.AddPassiveEffect(S_F2);
                u.AddPassive(S_F);
            }

            // ---- Ancient Figure
            {
                PassiveEffect A_F1 = PassiveEffect.CreateTMRequirementEffect(TMRequirementPassive.Both);
                PassiveEffect A_F2 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK | StatistiquesBuff.HP, 30);
                PassiveEffect A_F3 = PassiveEffect.CreateLBGaugeFillRateEffect(100);
                PassiveEffect A_F4 = PassiveEffect.CreateLBDamageEffect(30);
                PassiveEffect A_F5 = PassiveEffect.CreateEquipmentBuffEffect(EquipmentStat.ATK, 100, 25, EquipmentBuffCondition.DoubleHand);

                UnitPassive A_F = new UnitPassive(7, 101, "Icon-Ability_280", "Ancient Figure");
                A_F.AddPassiveEffect(A_F1);
                A_F.AddPassiveEffect(A_F2);
                A_F.AddPassiveEffect(A_F3);
                A_F.AddPassiveEffect(A_F4);
                A_F.AddPassiveEffect(A_F5);
                u.AddPassive(A_F);
            }

            // ---- MP +20%
            {
                PassiveEffect MP1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.MP, 20);

                UnitPassive MP = new UnitPassive(7, 115, "Icon-Ability_77", "MP +20%");
                MP.AddPassiveEffect(MP1);
                u.AddPassive(MP);
            }

            // ---- Precursor of the Storm
            {
                PassiveEffect P_S1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP | StatistiquesBuff.ATK, 30);
                PassiveEffect P_S2 = PassiveEffect.CreateStatistiquesBuffWeaponConditionEffect(StatistiquesBuff.ATK, 60, WeaponBuffCondition.GreatSword);
                PassiveEffect P_S3 = PassiveEffect.CreateLBUpgradeEffect();
                PassiveEffect P_S4 = PassiveEffect.CreateEquipmentBuffEffect(EquipmentStat.ATK, 50, 25, EquipmentBuffCondition.TrueDoubleHand);
                PassiveEffect P_S5 = PassiveEffect.CreateMonsterRaceBuffEffect(MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Physical, 50);

                UnitPassive P_S = new UnitPassive(7, 120, "Icon-Ability_275", "Precursor of the Storm");
                P_S.AddPassiveEffect(P_S1);
                P_S.AddPassiveEffect(P_S2);
                P_S.AddPassiveEffect(P_S3);
                P_S.AddPassiveEffect(P_S4);
                P_S.AddPassiveEffect(P_S5);
                u.AddPassive(P_S);
            }

            #endregion


            #region Limit

            // ---- Raikiri 5*
            {
                LimitEffect R_B1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 650, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_B2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_B3 = LimitEffect.CreateLimitDamageUpEffect(true, 15, 3, LimitTarget.Caster);
                AbilityEffect R_B4_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 500, 0, AbilityTarget.Caster, 1);
                LimitEffect R_B4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_B = new UnitLimit(5, "Raikiri", 20);
                R_B.AddLimitEffect(R_B1);
                R_B.AddLimitEffect(R_B2);
                R_B.AddLimitEffect(R_B3);
                R_B.AddLimitEffect(R_B4);
                u.AddLimit(R_B);

                ///////////

                LimitEffect R_M1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 850, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_M2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_M3 = LimitEffect.CreateLimitDamageUpEffect(true, 15, 3, LimitTarget.Caster);
                LimitEffect R_M4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_M = new UnitLimit(5, "Raikiri", 20);
                R_M.AddLimitEffect(R_M1);
                R_M.AddLimitEffect(R_M2);
                R_M.AddLimitEffect(R_M3);
                R_M.AddLimitEffect(R_M4);
                u.AddLimit(R_M);
            }

            // ---- Raikiri 6*
            {
                LimitEffect R_B1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 850, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_B2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_B3 = LimitEffect.CreateLimitDamageUpEffect(true, 20, 3, LimitTarget.Caster);
                AbilityEffect R_B4_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 1000, 0, AbilityTarget.Caster, 1);
                LimitEffect R_B4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_B = new UnitLimit(6, "Raikiri", 40);
                R_B.AddLimitEffect(R_B1);
                R_B.AddLimitEffect(R_B2);
                R_B.AddLimitEffect(R_B3);
                R_B.AddLimitEffect(R_B4);
                u.AddLimit(R_B);

                ///////////

                LimitEffect R_M1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1100, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_M2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_M3 = LimitEffect.CreateLimitDamageUpEffect(true, 20, 3, LimitTarget.Caster);
                LimitEffect R_M4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_M = new UnitLimit(6, "Raikiri", 40);
                R_M.AddLimitEffect(R_M1);
                R_M.AddLimitEffect(R_M2);
                R_M.AddLimitEffect(R_M3);
                R_M.AddLimitEffect(R_M4);
                u.AddLimit(R_M);
            }

            // ---- Raikiri 7*
            {
                LimitEffect R_B1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1100, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_B2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_B3 = LimitEffect.CreateLimitDamageUpEffect(true, 25, 3, LimitTarget.Caster);
                AbilityEffect R_B4_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 1500, 0, AbilityTarget.Caster, 1);
                LimitEffect R_B4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_B = new UnitLimit(7, "Raikiri", 60);
                R_B.AddLimitEffect(R_B1);
                R_B.AddLimitEffect(R_B2);
                R_B.AddLimitEffect(R_B3);
                R_B.AddLimitEffect(R_B4);
                u.AddLimit(R_B);

                ///////////

                LimitEffect R_M1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1400, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_M2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_M3 = LimitEffect.CreateLimitDamageUpEffect(true, 25, 3, LimitTarget.Caster);
                LimitEffect R_M4 = LimitEffect.CreateAutoCastEffect(false, 1, R_B4_1);

                UnitLimit R_M = new UnitLimit(7, "Raikiri", 60);
                R_M.AddLimitEffect(R_M1);
                R_M.AddLimitEffect(R_M2);
                R_M.AddLimitEffect(R_M3);
                R_M.AddLimitEffect(R_M4);
                u.AddLimit(R_M);
            }

            // ---- Raikiri 7* Upgraded
            {
                LimitEffect R_B1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1100, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_B2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_B3 = LimitEffect.CreateLimitDamageUpEffect(true, 35, 3, LimitTarget.Caster);
                LimitEffect R_B4 = LimitEffect.CreateBuffAlliesEffect(StatsBuffed.ATK, 100, 3, LimitTarget.Caster);
                AbilityEffect R_B5_1 = AbilityEffect.CreateDamageEffect(TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 1500, 0, AbilityTarget.Caster, 1);
                LimitEffect R_B5 = LimitEffect.CreateAutoCastEffect(false, 1, R_B5_1);

                UnitLimit R_B = new UnitLimit(7, "Abolute Raikiri (Upgraded)", 60);
                R_B.AddLimitEffect(R_B1);
                R_B.AddLimitEffect(R_B2);
                R_B.AddLimitEffect(R_B3);
                R_B.AddLimitEffect(R_B4);
                R_B.AddLimitEffect(R_B5);
                u.AddLimit(R_B);

                ///////////

                LimitEffect R_M1 = LimitEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1400, 50, LimitTarget.AreaOfEffectEnemies, 30);
                LimitEffect R_M2 = LimitEffect.CreateGiveAbilityEffect(true, new List<UnitAbility>(), 3, LimitTarget.Caster);
                LimitEffect R_M3 = LimitEffect.CreateLimitDamageUpEffect(true, 35, 3, LimitTarget.Caster);
                LimitEffect R_M4 = LimitEffect.CreateBuffAlliesEffect(StatsBuffed.ATK, 250, 3, LimitTarget.Caster);
                LimitEffect R_M5 = LimitEffect.CreateAutoCastEffect(false, 1, R_B5_1);

                UnitLimit R_M = new UnitLimit(7, "Abolute Raikiri (Upgraded)", 60);
                R_M.AddLimitEffect(R_M1);
                R_M.AddLimitEffect(R_M2);
                R_M.AddLimitEffect(R_M3);
                R_M.AddLimitEffect(R_M4);
                R_M.AddLimitEffect(R_M5);
                u.AddLimit(R_M);
            }

            #endregion


            #region Equipment Exclusive
            // ---- Storm Kickers
            {
                Equipment S_K = Equipment.CreateEquipment("Storm Kickers", "A pair of sneackers said to have belonged to a warrior of legend. On the right set of feet these stylish shoes are capable of granting its wearer the power to withstand lightning."
                    , "Icon-Storm_Kickers", EquipmentType.Accessory, "TMR Esther");
                S_K.AddFixedStat(StatBuffed.ATK, 45); S_K.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect S_K1_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 20);
                PassiveEffect S_K1_2 = PassiveEffect.CreateLBDamageEffect(15);
                UnitPassive S_K1 = new UnitPassive(0, 0, "Icon-Ability_276", "Inner Limit");
                S_K1.AddPassiveEffect(S_K1_1);
                S_K1.AddPassiveEffect(S_K1_2);
                S_K.AddEquipmentEffectPassive(S_K1);

                PassiveEffect S_K2_1 = PassiveEffect.CreateAbsorbDamageEffect(ElementDamage.Lightning, TypeDamage.Hybrid);
                UnitPassive S_K2 = new UnitPassive(0, 0, "Icon-Ability_280", "Stormborne"); S_K2.UsableWitheList = true; S_K2.AddUnitToWhiteList("Esther");
                S_K2.AddPassiveEffect(S_K2_1);
                S_K.AddEquipmentEffectPassive(S_K2);

                u.AddExclusiveEquipment(S_K);
            }

            // ---- Storm Bunny Jacket
            {
                Equipment SBJ = Equipment.CreateEquipment("Storm Bunny Jacket", "A unique jacket with a hood that ressembles rabbit ears. It fills its wearer with the instincts of a swift killer, and adds to their endurance and strength as well. Woven with the finest fabric of a distant world, it was exclusively made for a certain warrior of legend.",
                    "Icon-Storm_Bunny_Jacket", EquipmentType.Clothe, "STM Esther");
                SBJ.AddFixedStat(StatBuffed.HP, 800); SBJ.AddFixedStat(StatBuffed.ATK, 40); SBJ.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect SBJ1_1 = PassiveEffect.CreateMonsterRaceBuffEffect(MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Hybrid, 50);
                UnitPassive SBJ1 = new UnitPassive(0, 0, "Icon-Ability_275", "Killer Instincts");
                SBJ1.AddPassiveEffect(SBJ1_1);
                SBJ.AddEquipmentEffectPassive(SBJ1);

                PassiveEffect SBJ2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 20);
                PassiveEffect SBJ2_2 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 30);
                UnitPassive SBJ2 = new UnitPassive(0, 0, "Icon-Ability_276", "Exquisite Weaving"); SBJ2.UsableWitheList = true; SBJ2.AddUnitToWhiteList("Esther");
                SBJ2.AddPassiveEffect(SBJ2_1);
                SBJ2.AddPassiveEffect(SBJ2_2);
                SBJ.AddEquipmentEffectPassive(SBJ2);

                u.AddExclusiveEquipment(SBJ);
            }

            // ---- Stone Crown
            {
                Equipment S_C = Equipment.CreateEquipment("Stone Crown", "A crown made of stone. It is rumored to have been made by legendary blacksmith seeking for methods to make armor lighter regardless of the equipment's material. Apparently, it is a prototype for something far stronger.",
                    "Icon-Stone_Crown", EquipmentType.Hat, "Recipe Event");
                S_C.AddFixedStat(StatBuffed.ATK, 5); S_C.AddFixedStat(StatBuffed.DEF, 10); S_C.AddFixedStat(StatBuffed.PSY, 5); S_C.AddElementResistance(Element.Earth, 10);

                PassiveEffect S_C1_1 = PassiveEffect.CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 10, "Stone Vest");
                UnitPassive S_C1 = new UnitPassive(0, 0, "Icon-Ability_77", "Stone Set");
                S_C1.AddPassiveEffect(S_C1_1);
                S_C.AddEquipmentEffectPassive(S_C1);

                PassiveEffect S_C2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 10);
                UnitPassive S_C2 = new UnitPassive(0, 0, "Icon-Ability_77", "Liveliness"); S_C2.UsableWitheList = true; S_C2.AddUnitToWhiteList("Esther");
                S_C2.AddPassiveEffect(S_C2_1);
                S_C.AddEquipmentEffectPassive(S_C2);

                PassiveEffect S_C3_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 10);
                UnitPassive S_C3 = new UnitPassive(0, 0, "Icon-Ability_77", "Cheerfulness"); S_C3.UsableWitheList = true; S_C3.AddUnitToWhiteList("Sylvie");
                S_C3.AddPassiveEffect(S_C3_1);
                S_C.AddEquipmentEffectPassive(S_C3);

                u.AddExclusiveEquipment(S_C);
            }

            // ---- Stone Vest
            {
                Equipment S_V = Equipment.CreateEquipment("Stone Vest", "A vest made of stone. It is one of many pieces of armor made by a legendary blacksmith who sought methods to make armor lighter regardless of the equipment's material. Apparently, it is a prototype for something far stronger.",
                    "Icon-Stone_Vest", EquipmentType.LightArmor, "Recipe Event");
                S_V.AddFixedStat(StatBuffed.ATK, 5); S_V.AddFixedStat(StatBuffed.DEF, 10); S_V.AddFixedStat(StatBuffed.PSY, 5); S_V.AddElementResistance(Element.Earth, 10);

                PassiveEffect S_V1_1 = PassiveEffect.CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 10, "Stone Bracer");
                UnitPassive S_V1 = new UnitPassive(0, 0, "Icon-Ability_77", "Stone Set");
                S_V1.AddPassiveEffect(S_V1_1);
                S_V.AddEquipmentEffectPassive(S_V1);

                PassiveEffect S_V2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 10);
                UnitPassive S_V2 = new UnitPassive(0, 0, "Icon-Ability_77", "Liveliness"); S_V2.UsableWitheList = true; S_V2.AddUnitToWhiteList("Esther");
                S_V2.AddPassiveEffect(S_V2_1);
                S_V.AddEquipmentEffectPassive(S_V2);

                PassiveEffect S_V3_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 10);
                UnitPassive S_V3 = new UnitPassive(0, 0, "Icon-Ability_77", "Cheerfulness"); S_V3.UsableWitheList = true; S_V3.AddUnitToWhiteList("Sylvie");
                S_V3.AddPassiveEffect(S_V3_1);
                S_V.AddEquipmentEffectPassive(S_V3);

                u.AddExclusiveEquipment(S_V);
            }

            // ---- Tectonic Bracer
            {
                Equipment T_B = Equipment.CreateEquipment("Tectonic Bracer", "A bracer made of stone. For being made from such a hefty material, it is actually surprisingly light. It is rummored to have been made by a legendary blacksmith who made a number of curious and durable pieces out of stone. This is usually considered his most well-known piece.",
                    "Icon-Tectonic_Bracer", EquipmentType.Accessory, "Recipe Event");
                T_B.AddFixedStat(StatBuffed.ATK, 5); T_B.AddFixedStat(StatBuffed.DEF, 15); T_B.AddPercentStat(StatBuffed.HP, 5); T_B.AddElementResistance(Element.Earth, 10);

                PassiveEffect T_B1_1 = PassiveEffect.CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 10, "Tectonic Crown");
                UnitPassive T_B1 = new UnitPassive(0, 0, "Icon-Ability_77", "Tectonic Set");
                T_B1.AddPassiveEffect(T_B1_1);
                T_B.AddEquipmentEffectPassive(T_B1);

                PassiveEffect T_B2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 10);
                UnitPassive T_B2 = new UnitPassive(0, 0, "Icon-Ability_77", "Liveliness"); T_B2.UsableWitheList = true; T_B2.AddUnitToWhiteList("Esther");
                T_B2.AddPassiveEffect(T_B2_1);
                T_B.AddEquipmentEffectPassive(T_B2);

                PassiveEffect T_B3_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 10);
                UnitPassive T_B3 = new UnitPassive(0, 0, "Icon-Ability_77", "Cheerfulness"); T_B3.UsableWitheList = true; T_B3.AddUnitToWhiteList("Sylvie");
                T_B3.AddPassiveEffect(T_B3_1);
                T_B.AddEquipmentEffectPassive(T_B3);

                u.AddExclusiveEquipment(T_B);
            }

            // ---- Tectonic Crown
            {
                Equipment T_C = Equipment.CreateEquipment("Tectonic Crown", "A crown made of magical earth gems. It is rumored to have been made by a legendary blacksmith seeking for methods to make armor lighter regardless of the equipment's material. This is usually considered his most beautiful piece.",
                    "Icon-Tectonic_Crown", EquipmentType.Hat, "Recipe Event");
                T_C.AddFixedStat(StatBuffed.ATK, 10); T_C.AddFixedStat(StatBuffed.DEF, 20); T_C.AddFixedStat(StatBuffed.PSY, 10); T_C.AddPercentStat(StatBuffed.HP, 10); T_C.AddElementResistance(Element.Earth, 20); T_C.AddAilmentResistance(Ailment.Petrification, 50);

                PassiveEffect T_C1_1 = PassiveEffect.CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 15, "Tectonic Vest");
                UnitPassive T_C1 = new UnitPassive(0, 0, "Icon-Ability_77", "Tectonic Set");
                T_C1.AddPassiveEffect(T_C1_1);
                T_C.AddEquipmentEffectPassive(T_C1);

                PassiveEffect T_C2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 10);
                UnitPassive T_C2 = new UnitPassive(0, 0, "Icon-Ability_77", "Liveliness"); T_C2.UsableWitheList = true; T_C2.AddUnitToWhiteList("Esther");
                T_C2.AddPassiveEffect(T_C2_1);
                T_C.AddEquipmentEffectPassive(T_C2);

                PassiveEffect T_C3_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 10);
                UnitPassive T_C3 = new UnitPassive(0, 0, "Icon-Ability_77", "Cheerfulness"); T_C3.UsableWitheList = true; T_C3.AddUnitToWhiteList("Sylvie");
                T_C3.AddPassiveEffect(T_C3_1);
                T_C.AddEquipmentEffectPassive(T_C3);

                u.AddExclusiveEquipment(T_C);
            }

            // ---- Tectonic Vest
            {
                Equipment T_V = Equipment.CreateEquipment("Tectonic Vest", "A vest made of rocks gathered from a magical realm. It is one of many pieces of armor made by a legendary blacksmith who sought methods to make armor lighter regardless of the equipment's material. This is usually considered his strongest piece.",
                    "Icon-Tectonic_Vest", EquipmentType.LightArmor, "Recipe Event");
                T_V.AddFixedStat(StatBuffed.ATK, 10); T_V.AddFixedStat(StatBuffed.DEF, 25); T_V.AddFixedStat(StatBuffed.PSY, 10); T_V.AddPercentStat(StatBuffed.HP, 10); T_V.AddElementResistance(Element.Earth, 20); T_V.AddAilmentResistance(Ailment.Petrification, 50);

                PassiveEffect T_V1_1 = PassiveEffect.CreateStatistiquesBuffSpecialConditionEffect(StatistiquesBuff.ATK | StatistiquesBuff.PSY, 15, "Tectonic Bracer");
                UnitPassive T_V1 = new UnitPassive(0, 0, "Icon-Ability_77", "Tectonic Set");
                T_V1.AddPassiveEffect(T_V1_1);
                T_V.AddEquipmentEffectPassive(T_V1);

                PassiveEffect T_V2_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.ATK, 10);
                UnitPassive T_V2 = new UnitPassive(0, 0, "Icon-Ability_77", "Liveliness"); T_V2.UsableWitheList = true; T_V2.AddUnitToWhiteList("Esther");
                T_V2.AddPassiveEffect(T_V2_1);
                T_V.AddEquipmentEffectPassive(T_V2);

                PassiveEffect T_V3_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 10);
                UnitPassive T_V3 = new UnitPassive(0, 0, "Icon-Ability_77", "Cheerfulness"); T_V3.UsableWitheList = true; T_V3.AddUnitToWhiteList("Sylvie");
                T_V3.AddPassiveEffect(T_V3_1);
                T_V.AddEquipmentEffectPassive(T_V3);

                u.AddExclusiveEquipment(T_V);
            }

            // ---- Asterisk
            {
                Equipment A = Equipment.CreateEquipment("Asterisk", "A large blade favored by Esther. It was forged by a legendary blacksmith known for his mastery of rare techniques that could make the heaviest equipment lighter. It is imbued with the power of lightning, and it electrocutes any foes upon contact.",
                    "Icon-Asterisk", EquipmentType.GreatSword, "Reward Event");
                A.AddFixedStat(StatBuffed.ATK, 125); A.ElementDamage = Element.Lightning;

                PassiveEffect A1_1 = PassiveEffect.CreateStatistiquesBuffEffect(StatistiquesBuff.HP, 15);
                UnitPassive A1 = new UnitPassive(0, 0, "Icon-Ability_77", "Static Body"); A1.UsableWitheList = true; A1.AddUnitToWhiteList("Esther");
                A1.AddPassiveEffect(A1_1);
                A.AddEquipmentEffectPassive(A1);

                A.AddTwoHandedWeapon(100, 160, 50);

                u.AddExclusiveEquipment(A);
            }
            #endregion

            return u;
        }

        public PictureBox SetImgByURL(string url, PictureBox pictureBox)
        {
            pictureBox.Image = (Image)rm.GetObject(url);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            return pictureBox;
        }

        private void CreateLeftPanel(Unit u)
        {
            label_UnitName.Text = u.Name;
            pictureBox_UnitIdle = SetImgByURL(u.ImgURL, pictureBox_UnitIdle);
            label_GenderUnit.Text = "Gender : " + u.Gender.ToString();
            label_RaceUnit.Text = "Race : " + u.Race.ToString();

            TableLayoutPanel tableTMR = tableLayoutPanel_TMR;

            TextBox tbTMTitle = new TextBox
            {
                Dock = DockStyle.Fill,
                Text = "Trust Master",
                TextAlign = HorizontalAlignment.Center,
                BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F"),
                Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                ReadOnly = true
            };
            tableTMR.Controls.Add(tbTMTitle, 0, 0);
            tableTMR.Controls.Add(new TextBox() { Text = u.GetTMRName(), TextAlign = HorizontalAlignment.Center, ReadOnly = true, Dock = DockStyle.Fill }, 0, 1);

            Button btnTM = new Button() 
            { 
                Name = "TMR_Button",
                Image = (Image)rm.GetObject(u.GetTMRImgUrl()), 
                Dock = DockStyle.Fill
            };
            btnTM.Click += ShowTMRPage;
            tableTMR.Controls.Add(btnTM, 0, 2);


            TableLayoutPanel tableSTMR = tableLayoutPanel_STMR;

            TextBox tbSTMRTitle = new TextBox
            {
                Dock = DockStyle.Fill,
                Text = "Super Trust Master",
                TextAlign = HorizontalAlignment.Center,
                BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F"),
                Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                ReadOnly = true
            };
            tableSTMR.Controls.Add(tbSTMRTitle, 0, 0);
            tableSTMR.Controls.Add(new TextBox() { Text = u.GetSTMRName(), TextAlign = HorizontalAlignment.Center, ReadOnly = true, Dock = DockStyle.Fill }, 0, 1);
            Button btnSTM = new Button() 
            {
                Name = "STMR_Button", 
                Image = (Image)rm.GetObject(u.GetSTMRImgUrl()), 
                Dock = DockStyle.Fill
            };
            btnSTM.Click += ShowSTMRPage;
            tableSTMR.Controls.Add(btnSTM, 0, 2);
        }

        private void CreateUnitStatListView(List<UnitStats> stats, ListView listView)
        {
            listView.Bounds = new Rectangle(new Point(10, 10), new Size(500, 100));
            listView.View = View.Details;
            listView.OwnerDraw = true;
            listView.GridLines = true;

            List<ListViewItem> l = new List<ListViewItem>();

            int index = 0;
            foreach (UnitStats s in stats)
            {
                ListViewItem star = new ListViewItem(s.Star.ToString());
                star.SubItems.Add(" " + stats[index].HP.ToString() + " ");
                star.SubItems.Add(" " + stats[index].MP.ToString() + " ");
                star.SubItems.Add(" " + stats[index].ATK.ToString() + " ");
                star.SubItems.Add(" " + stats[index].DEF.ToString() + " ");
                star.SubItems.Add(" " + stats[index].MAG.ToString() + " ");
                star.SubItems.Add(" " + stats[index].SPR.ToString() + " ");
                star.SubItems.Add(" " + stats[index].AttackHits.ToString() + " ");
                star.SubItems.Add(" " + stats[index].LimitDrop.ToString() + " ");
                star.SubItems.Add(" " + stats[index].ExpPattern.ToString() + " ");

                index++;
                l.Add(star);
            }

            listView.Columns.Add(" Rareté ", -2, HorizontalAlignment.Center);

            listView.Columns.Add(" HP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" ATK ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" DEF ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MAG ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" SPR ", -2, HorizontalAlignment.Center);

            listView.Columns.Add(" Attack Hits ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" Limit Drops ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" Exp. Pattern ", -2, HorizontalAlignment.Center);


            listView.Items.AddRange(l.ToArray());


            listView.BeginUpdate();
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize); // Rarity
            listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent); // HP
            listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent); // MP
            listView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent); // ATK
            listView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent); // DEF
            listView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent); // MAG
            listView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent); // PSY
            listView.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize); // Attack Hits
            listView.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.HeaderSize); // Limit Drop
            listView.AutoResizeColumn(9, ColumnHeaderAutoResizeStyle.HeaderSize); // Exp Pattern
            listView.EndUpdate();
        }

        private void CreateUnitStatUpListView(List<UnitStatsMaxUp> stats, ListView listView)
        {
            listView.Bounds = new Rectangle(new Point(10, 125), new Size(290, 100));
            listView.View = View.Details;
            listView.OwnerDraw = true;
            listView.GridLines = true;

            List<ListViewItem> l = new List<ListViewItem>();

            int index = 0;
            foreach (UnitStatsMaxUp s in stats)
            {
                ListViewItem star = new ListViewItem(s.Star.ToString());
                star.SubItems.Add(" " + stats[index].HP.ToString() + " ");
                star.SubItems.Add(" " + stats[index].MP.ToString() + " ");
                star.SubItems.Add(" " + stats[index].ATK.ToString() + " ");
                star.SubItems.Add(" " + stats[index].DEF.ToString() + " ");
                star.SubItems.Add(" " + stats[index].MAG.ToString() + " ");
                star.SubItems.Add(" " + stats[index].SPR.ToString() + " ");

                index++;
                l.Add(star);
            }

            listView.Columns.Add(" Rareté ", -2, HorizontalAlignment.Center);

            listView.Columns.Add(" HP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" ATK ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" DEF ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MAG ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" SPR ", -2, HorizontalAlignment.Center);


            listView.Items.AddRange(l.ToArray());

            listView.BeginUpdate();
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize); // Rarity
            listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent); // HP
            listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent); // MP
            listView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize); // ATK
            listView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize); // DEF
            listView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize); // MAG
            listView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize); // PSY
            listView.EndUpdate();
        }

        private void CreateUnitStatMaxUpListView(List<UnitStats> stats, List<UnitStatsMaxUp> up, ListView listView)
        {
            listView.Bounds = new Rectangle(new Point(10, 250), new Size(500, 100));
            listView.View = View.Details;
            listView.OwnerDraw = true;
            listView.GridLines = true;
            

            List<ListViewItem> l = new List<ListViewItem>();

            int index = 0;
            foreach (UnitStats s in stats)
            {
                ListViewItem star = new ListViewItem(s.Star.ToString());
                star.SubItems.Add(" " + (stats[index].HP + up[index].HP).ToString() + " ");
                star.SubItems.Add(" " + (stats[index].MP + up[index].MP).ToString() + " ");
                star.SubItems.Add(" " + (stats[index].ATK + up[index].ATK).ToString() + " ");
                star.SubItems.Add(" " + (stats[index].DEF + up[index].DEF).ToString() + " ");
                star.SubItems.Add(" " + (stats[index].MAG + up[index].MAG).ToString() + " ");
                star.SubItems.Add(" " + (stats[index].SPR + up[index].SPR).ToString() + " ");
                star.SubItems.Add(" " + stats[index].AttackHits.ToString() + " ");
                star.SubItems.Add(" " + stats[index].LimitDrop.ToString() + " ");
                star.SubItems.Add(" " + stats[index].ExpPattern.ToString() + " ");

                index++;
                l.Add(star);
            }

            listView.Columns.Add(" Rareté ", -2, HorizontalAlignment.Center);

            listView.Columns.Add(" HP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MP ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" ATK ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" DEF ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" MAG ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" SPR ", -2, HorizontalAlignment.Center);

            listView.Columns.Add(" Attack Hits ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" Limit Drops ", -2, HorizontalAlignment.Center);
            listView.Columns.Add(" Exp. Pattern ", -2, HorizontalAlignment.Center);


            listView.Items.AddRange(l.ToArray());

            listView.BeginUpdate();
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize); // Rarity
            listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent); // HP
            listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent); // MP
            listView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent); // ATK
            listView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent); // DEF
            listView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent); // MAG
            listView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent); // PSY
            listView.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize); // Attack Hits
            listView.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.HeaderSize); // Limit Drop
            listView.AutoResizeColumn(9, ColumnHeaderAutoResizeStyle.HeaderSize); // Exp Pattern
            listView.EndUpdate();
        }



        private void CreateAbilityGridData(List<UnitAbility> unitComps, DataGridView gridView)
        {
            foreach (UnitAbility unitComp in unitComps)
            {
                gridView.Rows.Add(); // On créée une nouvelle ligne vide
                DataGridViewRow row = (DataGridViewRow)gridView.Rows[gridView.Rows.GetLastRow(DataGridViewElementStates.Visible)]; // On récupère la dernière ligne
                row.Cells[0].Value = unitComp.Star;
                row.Cells[1].Value = unitComp.Level;
                //row.Cells[2].Value = (Image)rm.GetObject(unitComp.ImgURL);
                if(!unitComp.ImgURL.Equals("icon")) { 
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        Image image = (Image)rm.GetObject(unitComp.ImgURL);
                        image.Save(ms, image.RawFormat);
                        byte[] img = ms.ToArray();
                        row.Cells[2].Value = img;
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                row.Cells[2].Value = (Image)rm.GetObject(unitComp.ImgURL);

                row.Cells[3].Value = unitComp.Name;
                row.Cells[4].Value = unitComp.GetEffectsToString();

                /*
                RichTextBox b = new RichTextBox
                {
                    Location = new Point(157, 25),
                    Size = new Size(135, 50)
                };
                b.SelectionStart = b.TextLength;
                b.SelectionColor = Color.Yellow;
                b.AppendText("Texte en jaune");
                b.SelectionLength = b.TextLength;

                b.SelectionStart = b.TextLength;
                b.SelectionColor = Color.Red;
                b.AppendText("Texte en rouge");
                b.SelectionLength = b.TextLength;

                Controls.Add(b);
                */

                //row.Con = b.Text;
                row.Cells[5].Value = unitComp.GetHitsToString();
                row.Cells[6].Value = unitComp.MPCost;
            }

        }

        private void CreatePassivesGridData(List<UnitPassive> unitPassives, DataGridView gridView)
        {
            foreach (UnitPassive unitPassive in unitPassives)
            {
                gridView.Rows.Add(); // On créée une nouvelle ligne vide
                DataGridViewRow row = (DataGridViewRow)gridView.Rows[gridView.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                row.Cells[0].Value = unitPassive.Star;
                row.Cells[1].Value = unitPassive.Level;
                if(!unitPassive.ImgURL.Equals("icon"))
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        Image image = (Image)rm.GetObject(unitPassive.ImgURL);
                        image.Save(ms, image.RawFormat);
                        byte[] img = ms.ToArray();
                        row.Cells[2].Value = img;
                    } catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                row.Cells[3].Value = unitPassive.Name;
                row.Cells[4].Value = unitPassive.GetEffectsToString();
            }
        }

        private void CreateLimitGridData(List<UnitLimit> unitLimits, DataGridView gridView)
        {
            foreach (UnitLimit unitLimit in unitLimits)
            {
                gridView.Rows.Add(); // On créée une nouvelle ligne vide
                DataGridViewRow row = (DataGridViewRow)gridView.Rows[gridView.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                row.Cells[0].Value = unitLimit.Star;
                row.Cells[1].Value = unitLimit.Name;
                row.Cells[2].Value = unitLimit.GetEffectsToString();
                row.Cells[3].Value = unitLimit.GetHitsToString();
                row.Cells[4].Value = unitLimit.LBCost;
            }
        }

        private void CreateEquipExcluGridData(List<Equipment> equipments, DataGridView gridView)
        {
            foreach (Equipment equipment in equipments)
            {
                gridView.Rows.Add(); // On créée une nouvelle ligne vide
                DataGridViewRow row = (DataGridViewRow)gridView.Rows[gridView.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                if (!equipment.ImgURL.Equals("icon"))
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        Image image = (Image)rm.GetObject(equipment.ImgURL);
                        image.Save(ms, image.RawFormat);
                        byte[] img = ms.ToArray();
                        row.Cells[0].Value = img;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                row.Cells[1].Value = equipment.Name;
                row.Cells[2].Value = equipment.EquipmentType;
                row.Cells[3].Value = equipment.Text;
            }
        }



        private void CreateUnitResTableView(UnitResistance res, TableLayoutPanel table)
        {
            table.Bounds = new Rectangle(new Point(table.Bounds.X, table.Bounds.Y), new Size(400, 200));

            table.RowCount = 6;
            table.ColumnCount = 8;
            table.Update();


            TextBox tbElement = new TextBox();
            tbElement.Multiline = true;
            tbElement.Dock = DockStyle.Fill;
            tbElement.Text = "Element Resistance";
            tbElement.TextAlign = HorizontalAlignment.Center;
            tbElement.BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F");
            tbElement.Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold);
            tbElement.ForeColor = Color.GhostWhite;
            tbElement.ReadOnly = true;
            table.Controls.Add(tbElement, 0, 0);
            table.SetColumnSpan(tbElement, 8);



            TextBox tbAilment = new TextBox();
            tbAilment.Multiline = true;
            tbAilment.Dock = DockStyle.Fill;
            tbAilment.Text = "Element Resistance";
            tbAilment.TextAlign = HorizontalAlignment.Center;
            tbAilment.BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F");
            tbAilment.Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold);
            tbAilment.ForeColor = Color.GhostWhite;
            tbAilment.ReadOnly = true;
            table.Controls.Add(tbAilment, 0, 3);
            table.SetColumnSpan(tbAilment, 8);



            // Element
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Fire_Resistance") }, 0, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Ice_Resistance") }, 1, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Lightning_Resistance") }, 2, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Water_Resistance") }, 3, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Wind_Resistance") }, 4, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Earth_Resistance") }, 5, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Light_Resistance") }, 6, 1);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Dark_Resistance") }, 7, 1);

            // Number
            table.Controls.Add(new TextBox() { Text = res.Fire.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 0, 2);
            table.Controls.Add(new TextBox() { Text = res.Ice.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 1, 2);
            table.Controls.Add(new TextBox() { Text = res.Lightning.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 2, 2);
            table.Controls.Add(new TextBox() { Text = res.Water.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 3, 2);
            table.Controls.Add(new TextBox() { Text = res.Wind.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 4, 2);
            table.Controls.Add(new TextBox() { Text = res.Earth.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 5, 2);
            table.Controls.Add(new TextBox() { Text = res.Light.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 6, 2);
            table.Controls.Add(new TextBox() { Text = res.Dark.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 7, 2);



            // Ailment
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Poison_Resistance") }, 0, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Blind_Resistance") }, 1, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Sleep_Resistance") }, 2, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Silence_Resistance") }, 3, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Paralysis_Resistance") }, 4, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Confuse_Resistance") }, 5, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Disease_Resistance") }, 6, 4);
            table.Controls.Add(new PictureBox() { Image = (Image)rm.GetObject("Icon-Petrification_Resistance") }, 7, 4);
            // Number
            table.Controls.Add(new TextBox() { Text = res.Poison.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 0, 5);
            table.Controls.Add(new TextBox() { Text = res.Blind.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 1, 5);
            table.Controls.Add(new TextBox() { Text = res.Sleep.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 2, 5);
            table.Controls.Add(new TextBox() { Text = res.Silence.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 3, 5);
            table.Controls.Add(new TextBox() { Text = res.Paralysis.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 4, 5);
            table.Controls.Add(new TextBox() { Text = res.Confuse.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 5, 5);
            table.Controls.Add(new TextBox() { Text = res.Disease.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 6, 5);
            table.Controls.Add(new TextBox() { Text = res.Petrification.ToString(), TextAlign = HorizontalAlignment.Center, ReadOnly = true }, 7, 5);


        }

        private void listView_UnitStats_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush((Color)new ColorConverter().ConvertFromString("#4D627F")), e.Bounds); // first we fill the header with our color.
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White), 1), e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2); //then we draw an outline
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(e.Header.Text, new Font("Franklin Gothic Medium", 10, FontStyle.Bold), new SolidBrush(Color.GhostWhite), e.Bounds, sf); // then we draw the text, this bit could use some improvement, if you cant figure out, let me know and ill knock some more code together
            
        }

        private void tableRes_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            /*
            Control c = this.tableLayoutPanel_Resistance.GetControlFromPosition(e.Column, e.Row);
            if (c != null)
            {
                Graphics g = e.Graphics;
                if (tableLayoutPanel_Resistance.GetColumnSpan(c) > 1) // CellPaint pour les titres
                {
                    Pen p = new Pen(new SolidBrush((Color)new ColorConverter().ConvertFromString("#4D627F")));
                    g.DrawRectangle(
                        p,
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);

                    g.FillRectangle(
                        new SolidBrush((Color)new ColorConverter().ConvertFromString("#4D627F")),
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(c.Text, new Font("Franklin Gothic Medium", 10, FontStyle.Bold), new SolidBrush(Color.Black), c.DisplayRectangle, sf);
                }
                else // CellPaint pour les items
                {
                    Rectangle rectangle = new Rectangle(e.CellBounds.Location.X + 1, e.CellBounds.Location.Y + 1, e.CellBounds.Width - 2, e.CellBounds.Height - 2);
                    Pen p = new Pen(new SolidBrush((Color)new ColorConverter().ConvertFromString("#4D627F")));
                    g.DrawRectangle(
                        p,
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2, e.CellBounds.Height - 2);

                    g.FillRectangle(
                        new SolidBrush((Color)new ColorConverter().ConvertFromString("#FFFFFF")),
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(c.Text, new Font("Franklin Gothic Medium", 10, FontStyle.Bold), new SolidBrush(Color.Black), rectangle, sf);
                }
            }
            */
        }

        private void listView_UnitStats_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush((Color)new ColorConverter().ConvertFromString("#FFFFFF")), e.Bounds); // first we fill the header with our color.
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White), 1), e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2); //then we draw an outline
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(e.SubItem.Text, new Font("Franklin Gothic Medium", 10), new SolidBrush((Color)new ColorConverter().ConvertFromString("#1F3656")), e.Bounds, sf); // then we draw the text, this bit could use some improvement, if you cant figure out, let me know and ill knock some more code together

        }


        #region ButtonClick Event
        public void ShowTMRPage(object sender, EventArgs e)
        {
            if(unit.TMRIsEquipment)
            {
                EquipmentDescription dialogTest = new EquipmentDescription(unit.TMREquipment.Name);

                dialogTest.Show();
            }
            
        }
        public void ShowSTMRPage(object sender, EventArgs e)
        {
            if (unit.STMRIsEquipment)
            {
                EquipmentDescription dialogTest = new EquipmentDescription(unit.STMREquipment.Name);

                dialogTest.Show();
            }

        }
        #endregion
    }
}
