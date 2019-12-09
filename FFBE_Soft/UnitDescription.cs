using FFBE_Soft.model;
using FFBE_Soft.model.competence;
using FFBE_Soft.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace FFBE_Soft
{
    public partial class UnitDescription : Form
    {
        ResourceManager rm = Resources.ResourceManager;
        public UnitDescription()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            Unit Esther = this.SetEstherBDD();

            this.label_UnitName.Text = Esther.Name;
            Console.WriteLine("Liste d'armes : " + Unit.GetWeaponsString(Esther.Weapon).Count);
            Console.WriteLine("Liste d'armures : " + Unit.GetArmorsString(Esther.Armor).Count);
            this.pictureBox_UnitIdle = this.SetImgByURL(Esther.ImgURL, this.pictureBox_UnitIdle);

            this.CreateUnitStatListView(Esther.Stats, this.listView_UnitStats);
            this.CreateUnitStatUpListView(Esther.StatsMaxUp, this.listView_UnitStatUp);
            this.CreateUnitStatMaxUpListView(Esther.Stats, Esther.StatsMaxUp, this.listView_UnitMaxUp);
            this.CreateUnitResTableView(Esther.Resistance, this.tableLayoutPanel_Resistance);
            this.CreateAbilityGridData(Esther.Abilities, this.dataGridView_Ability);
            this.CreatePassivesGridData(Esther.Passives, this.dataGridView_Passives);
            this.CreateLimitGridData(Esther.Limits, this.dataGridView_Limit);
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

            #endregion


            #region Ability

            // ---- Shock Flash
            {
                AbilityEffect S_F1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 300, 0, AbilityTarget.SingleTargetEnemy, 7);
                AbilityEffect S_F2 = AbilityEffect.CreateLimitGaugeEffect(true, 0, 4, 6, AbilityTarget.Caster);
                UnitAbility S_F = new UnitAbility(5, 5, "Icon-Ability_272", "Shock Flash", 22);
                S_F.AddCompEffect(S_F1);
                S_F.AddCompEffect(S_F2);
                u.AddAbility(S_F);
            }


            // ---- Shatter Arms
            {
                AbilityEffect S_A1 = AbilityEffect.CreateDebuffEnemyEffect(true, StatsDebuffed.ATK | StatsDebuffed.MAG, 50, 5, AbilityTarget.SingleTargetEnemy);
                AbilityEffect S_A2 = AbilityEffect.CreateLimitGaugeEffect(true, 0, 6, 8, AbilityTarget.Caster);
                UnitAbility S_A = new UnitAbility(5, 38, "Icon-Ability_278", "Shatter Arms", 38);
                S_A.AddCompEffect(S_A1);
                S_A.AddCompEffect(S_A2);
                u.AddAbility(S_A);
            }

            // ---- Shatter Guard
            { 
                AbilityEffect S_G1 = AbilityEffect.CreateDebuffEnemyEffect(true, StatsDebuffed.DEF | StatsDebuffed.PSY, 50, 5, AbilityTarget.SingleTargetEnemy);
                AbilityEffect S_G2 = AbilityEffect.CreateLimitGaugeEffect(true, 0, 6, 8, AbilityTarget.Caster);
                UnitAbility S_G = new UnitAbility(5, 38, "Icon-Ability_278", "Shatter Guard", 38);
                S_G.AddCompEffect(S_G1);
                S_G.AddCompEffect(S_G2);
                u.AddAbility(S_G);
            }

            // ---- Shock Reflex
            {
                AbilityEffect S_R1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 80, 0, AbilityTarget.SingleTargetEnemy, 7); S_R1.AddHPDrain(50);
                AbilityEffect S_R2 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 160, 50, AbilityTarget.SingleTargetEnemy, 7);
                UnitAbility S_R = new UnitAbility(5, 55, "Icon-Ability_274", "Shock Reflex", 45);
                S_R.AddCompEffect(S_R1);
                S_R.AddCompEffect(S_R2);
                u.AddAbility(S_R);
            }

            // ---- Charged Protection
            {
                AbilityEffect C_P1 = AbilityEffect.CreateCoverEffect(true, TypeCover.Physical, 50, 0, 50, 70, 1, AbilityTarget.Caster);
                AbilityEffect C_P2 = AbilityEffect.CreateBuffAlliesEffect(true, StatsBuffed.DEF, 150, 1, AbilityTarget.Caster);
                UnitAbility C_P = new UnitAbility(5, 80, "Icon-Ability_69", "Charged Protection", 32);
                C_P.AddCompEffect(C_P1);
                C_P.AddCompEffect(C_P2);
                u.AddAbility(C_P);
            }

            // ---- Storm Brand
            {
                AbilityEffect S_B1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Lightning, 280, 50, AbilityTarget.SingleTargetEnemy, 9);
                AbilityEffect S_B2 = AbilityEffect.CreateElementImbueEffect(true, ElementImbue.Lightning, 5, AbilityTarget.Caster);
                AbilityEffect S_B3 = AbilityEffect.CreateLimitGaugeEffect(true, 15, 0, 0, AbilityTarget.Caster);
                UnitAbility S_B = new UnitAbility(6, 16, "Icon-Ability_271", "Storm Brand", 35);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);
                S_B.AddCompEffect(S_B3);
                u.AddAbility(S_B);
            }

            // ---- Storm Calling
            {
                AbilityEffect S_C1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 430, 0, AbilityTarget.SingleTargetEnemy, 8);
                AbilityEffect S_C2 = AbilityEffect.CreateHealHPEffect(true, 2500, 0, 0, 0, AbilityTarget.Caster);
                S_C2.AddHealMPToAbility(true, 65, 0, 0, 0, AbilityTarget.Caster);
                AbilityEffect S_C3 = AbilityEffect.CreateLimitGaugeEffect(true, 10, 0, 0, AbilityTarget.Caster);
                UnitAbility S_C = new UnitAbility(6, 42, "Icon-Ability_272", "Storm Calling", 40);
                S_C.AddCompEffect(S_C1);
                S_C.AddCompEffect(S_C2);
                S_C.AddCompEffect(S_C3);
                u.AddAbility(S_C);
            }

            // ---- Stasis Bound
            {
                AbilityEffect S_B1 = AbilityEffect.CreateTauntEffect(true, 100, 2, AbilityTarget.Caster);
                AbilityEffect S_B2 = AbilityEffect.CreateMitigationEffect(true, TypeMitigation.Physical, 20, 2, AbilityTarget.Caster);
                UnitAbility S_B = new UnitAbility(6, 65, "Icon-Ability_94", "Stasis Bound", 30);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);
                u.AddAbility(S_B);
            }

            // ---- Demagnetizing Strike
            {
                AbilityEffect D_S1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 350, 50, AbilityTarget.SingleTargetEnemy, 9);
                AbilityEffect D_S2 = AbilityEffect.CreateDebuffElementEffect(true, ElementDebuffed.Lightning, 75, 3, AbilityTarget.SingleTargetEnemy);
                AbilityEffect D_S3 = AbilityEffect.CreateLimitGaugeEffect(true, 15, 0, 0, AbilityTarget.Caster);
                UnitAbility D_S = new UnitAbility(6, 74, "Icon-Ability_271", "Demagnetizing Strike", 38);
                D_S.AddCompEffect(D_S1);
                D_S.AddCompEffect(D_S2);
                D_S.AddCompEffect(D_S3);
                u.AddAbility(D_S);
            }

            // ---- Electric Charge
            {
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect E_C1 = AbilityEffect.CreateMultipleSkillEffect(true, 2, abilities);
                UnitAbility E_C = new UnitAbility(6, 100, "Icon-Ability_8", "Electric Charge", 0);
                E_C.AddCompEffect(E_C1);
                u.AddAbility(E_C);
            }

            // ---- Combat Overdrive
            {
                AbilityEffect C_O1 = AbilityEffect.CreateBuffAlliesEffect(true, StatsBuffed.ATK, 200, 3, AbilityTarget.Caster);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect C_O2 = AbilityEffect.CreateAbilityCoeffUpEffect(true, 150, abilities, 4, false, AbilityTarget.Caster);
                List<UnitAbility> abilities2 = new List<UnitAbility>();
                AbilityEffect C_O3 = AbilityEffect.CreateGiveAbilityEffect(true, abilities2, 2, AbilityTarget.Caster);
                UnitAbility C_O = new UnitAbility(6, 100, "Icon-Ability_63", "Combat Overdrive", 48);
                C_O.AddCompEffect(C_O1);
                C_O.AddCompEffect(C_O2);
                C_O.AddCompEffect(C_O3);
                u.AddAbility(C_O);
            }

            // ---- Shock Embrace
            {
                AbilityEffect S_E1 = AbilityEffect.CreateCooldownEffect(true, 5, true);
                AbilityEffect S_E2 = AbilityEffect.CreateDebuffElementEffect(true, ElementDebuffed.Lightning, 100, 5, AbilityTarget.AreaOfEffectEnemies);
                AbilityEffect S_E3 = AbilityEffect.CreateElementImbueEffect(true, ElementImbue.Lightning, 5, AbilityTarget.Caster);
                AbilityEffect S_E4 = AbilityEffect.CreateLimitGaugeEffect(true, 20, 0, 0, AbilityTarget.Caster);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect S_E5 = AbilityEffect.CreateGiveAbilityEffect(true, abilities, 4, AbilityTarget.Caster);
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
                AbilityEffect S_C1 = AbilityEffect.CreateCooldownEffect(true, 4, false);
                AbilityEffect S_C2 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 1100, 0, AbilityTarget.SingleTargetEnemy, 8);
                List<UnitAbility> abilities = new List<UnitAbility>();
                AbilityEffect S_C3 = AbilityEffect.CreateAbilityCoeffUpEffect(true, 300, abilities, 2, false, AbilityTarget.Caster);
                AbilityEffect S_C4 = AbilityEffect.CreateLimitGaugeEffect(true, 30, 0, 0, AbilityTarget.Caster);
                UnitAbility S_C = new UnitAbility(7, 105, "Icon-Ability_105", "Storm Clouds", 88);
                S_C.AddCompEffect(S_C1);
                S_C.AddCompEffect(S_C2);
                S_C.AddCompEffect(S_C3);
                S_C.AddCompEffect(S_C4);
                u.AddAbility(S_C);
            }

            // ---- Bolting Strike
            {
                AbilityEffect B_S1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 400, 50, AbilityTarget.AreaOfEffectEnemies, 9);
                AbilityEffect B_S2 = AbilityEffect.CreateDebuffEnemyEffect(true, StatsDebuffed.DEF, 60, 5, AbilityTarget.AreaOfEffectEnemies);
                AbilityEffect B_S3 = AbilityEffect.CreateLimitGaugeEffect(true, 20, 0, 0, AbilityTarget.Caster);
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
                PassiveEffect U_F1 = PassiveEffect.CreateElementResistanceEffect(true, ElementResistance.Earth, 50);
                PassiveEffect U_F2 = PassiveEffect.CreateAilmentResistanceEffect(true, AilmentResistance.Paralysis | AilmentResistance.Petrification, 100);
                PassiveEffect U_F3 = PassiveEffect.CreateAilmentResistanceEffect(true, AilmentResistance.Stop | AilmentResistance.Charm, 100);
                UnitPassive U_F = new UnitPassive(5, 26, "Icon-Ability_19", "Unstoppable Fervor");
                U_F.AddPassiveEffect(U_F1);
                U_F.AddPassiveEffect(U_F2);
                U_F.AddPassiveEffect(U_F3);
                u.AddPassive(U_F);
            }

            // ---- Terra Resonance
            {
                PassiveEffect T_R1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP | StatistiquesBuff.DEF, 20);
                PassiveEffect T_R2 = PassiveEffect.CreateMonsterRaceBuffEffect(true, MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Physical, 100);
                UnitPassive T_R = new UnitPassive(5, 42, "Icon-Ability_275", "Terra Resonance");
                T_R.AddPassiveEffect(T_R1);
                T_R.AddPassiveEffect(T_R2);
                u.AddPassive(T_R);
            }

            // ---- Ionized Fragment
            {
                PassiveEffect I_F1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.ATK | StatistiquesBuff.PSY, 30);
                UnitPassive I_F = new UnitPassive(5, 64, "Icon-Ability_276", "Ionized Fragment");
                I_F.AddPassiveEffect(I_F1);
                u.AddPassive(I_F);
            }

            // ---- Overcharge
            {
                PassiveEffect O1 = PassiveEffect.CreateIgnoreFatalDamageEffect(true, 80, 10, 1);
                UnitPassive O = new UnitPassive(6, 1, "Icon-Ability_277", "Overcharge");
                O.AddPassiveEffect(O1);
                u.AddPassive(O);
            }

            // ---- Reverse Polarity
            {
                AbilityEffect S_B1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 250, 0, AbilityTarget.SingleTargetEnemy, 7);
                S_B1.AddConsecutive(4, 50, 450);
                AbilityEffect S_B2 = AbilityEffect.CreateDebuffEnemyEffect(true, StatsDebuffed.ATK | StatsDebuffed.DEF | StatsDebuffed.MAG | StatsDebuffed.PSY, 50, 1, AbilityTarget.SingleTargetEnemy);
                UnitAbility S_B = new UnitAbility(0, 0, "icon", "Static Barrage", 0);
                S_B.AddCompEffect(S_B1);
                S_B.AddCompEffect(S_B2);

                PassiveEffect R_P1 = PassiveEffect.CreateChanceToCounterEffect(true, CounterType.Physical, 40, S_B, 4);
                PassiveEffect R_P2 = PassiveEffect.CreateChanceToCounterEffect(true, CounterType.Magical, 40, S_B, 4);
                UnitPassive R_P = new UnitPassive(6, 24, "Icon-Ability_279", "Reverse Polarity");
                R_P.AddPassiveEffect(R_P1);
                R_P.AddPassiveEffect(R_P2);
                u.AddPassive(R_P);
            }

            // ---- Magnetic Grip
            {
                PassiveEffect M_G1 = PassiveEffect.CreateEquipmentBuffEffect(true, EquipmentStat.ATK, 100, 25, EquipmentBuffCondition.TrueDoubleHand);
                UnitPassive M_G = new UnitPassive(6, 38, "Icon-Ability_76", "Magnetic Grip");
                M_G.AddPassiveEffect(M_G1);
                u.AddPassive(M_G);
            }

            // ---- Phase Shift
            {
                PassiveEffect P_S1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP | StatistiquesBuff.MP | StatistiquesBuff.ATK | StatistiquesBuff.DEF, 20);
                PassiveEffect P_S2 = PassiveEffect.CreateEvasionEffect(true, EvasionType.Physical, 30);
                PassiveEffect P_S3 = PassiveEffect.CreateAutoRegenMPEffect(true, 7);

                AbilityEffect S_S1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 500, 0, AbilityTarget.Caster, 1);
                UnitAbility S_S = new UnitAbility(0, 0, "icon", "Static Shift", 0);
                S_S.AddCompEffect(S_S1);

                PassiveEffect P_S4 = PassiveEffect.CreateAutoCastAbilityEffect(true, S_S);
                UnitPassive P_S = new UnitPassive(6, 56, "Icon-Ability_273", "Phase Shift");
                P_S.AddPassiveEffect(P_S1);
                P_S.AddPassiveEffect(P_S2);
                P_S.AddPassiveEffect(P_S3);
                P_S.AddPassiveEffect(P_S4);
                u.AddPassive(P_S);
            }

            // ---- Stasis Field
            {
                PassiveEffect S_F1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.ATK, 20);
                PassiveEffect S_F2 = PassiveEffect.CreateStatistiquesBuffArmorConditionEffect(true, StatistiquesBuff.ATK | StatistiquesBuff.DEF, 40, ArmorBuffCondition.Clothe);

                UnitPassive S_F = new UnitPassive(6, 86, "Icon-Ability_276", "Stasis Field");
                S_F.AddPassiveEffect(S_F1);
                S_F.AddPassiveEffect(S_F2);
                u.AddPassive(S_F);
            }

            // ---- Ancient Figure
            {
                PassiveEffect A_F1 = PassiveEffect.CreateTMRequirementEffect(true, TMRequirementPassive.Both);
                PassiveEffect A_F2 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.ATK | StatistiquesBuff.HP, 30);
                PassiveEffect A_F3 = PassiveEffect.CreateLBGaugeFillRateEffect(true, 100);
                PassiveEffect A_F4 = PassiveEffect.CreateLBDamageEffect(true, 30);
                PassiveEffect A_F5 = PassiveEffect.CreateEquipmentBuffEffect(true, EquipmentStat.ATK, 100, 25, EquipmentBuffCondition.DoubleHand);

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
                PassiveEffect MP1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.MP, 20);

                UnitPassive MP = new UnitPassive(7, 115, "Icon-Ability_77", "MP +20%");
                MP.AddPassiveEffect(MP1);
                u.AddPassive(MP);
            }

            // ---- Precursor of the Storm
            {
                PassiveEffect P_S1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP | StatistiquesBuff.ATK, 30);
                PassiveEffect P_S2 = PassiveEffect.CreateStatistiquesBuffWeaponConditionEffect(true, StatistiquesBuff.ATK, 60, WeaponBuffCondition.GreatSword);
                PassiveEffect P_S3 = PassiveEffect.CreateLBUpgradeEffect(true);
                PassiveEffect P_S4 = PassiveEffect.CreateEquipmentBuffEffect(true, EquipmentStat.ATK, 50, 25, EquipmentBuffCondition.TrueDoubleHand);
                PassiveEffect P_S5 = PassiveEffect.CreateMonsterRaceBuffEffect(true, MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Physical, 50);

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
                AbilityEffect R_B4_1 = AbilityEffect.CreateDamageEffect(true, TypeDamage.Fixed, ScalingDamage.ATK, ElementDamage.Lightning, 500, 0, AbilityTarget.Caster, 1);
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

            #endregion

            return u;
        }

        public PictureBox SetImgByURL(string url, PictureBox pictureBox)
        {
            pictureBox.Image = (Image)rm.GetObject(url);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            return pictureBox;
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


        private void CreateUnitResTableView(UnitResistance res, TableLayoutPanel table)
        {
            table.Bounds = new Rectangle(new Point(table.Bounds.X, table.Bounds.Y), new Size(400, 200));

            table.RowCount = 6;
            table.ColumnCount = 8;
            table.Update();


            table.Controls.Add(new Label() { Text = "Element Resistance" }, 0, 0);
            table.SetColumnSpan(table.GetControlFromPosition(0, 0), 8);
            table.SetRowSpan(table.GetControlFromPosition(0, 0), 1);

            table.Controls.Add(new Label() { Text = "Statut Ailment Resistance" }, 0, 3);
            table.SetColumnSpan(table.GetControlFromPosition(0, 3), 8);
            table.SetRowSpan(table.GetControlFromPosition(0, 3), 1);

            // Element
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Fire_Resistance") }, 0, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Ice_Resistance") }, 1, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Lightning_Resistance") }, 2, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Water_Resistance") }, 3, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Wind_Resistance") }, 4, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Earth_Resistance") }, 5, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Light_Resistance") }, 6, 1);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Dark_Resistance") }, 7, 1);
            // Number
            table.Controls.Add(new Label() { Text = res.Fire.ToString() }, 0, 2);
            table.Controls.Add(new Label() { Text = res.Ice.ToString() }, 1, 2);
            table.Controls.Add(new Label() { Text = res.Lightning.ToString() }, 2, 2);
            table.Controls.Add(new Label() { Text = res.Water.ToString() }, 3, 2);
            table.Controls.Add(new Label() { Text = res.Wind.ToString() }, 4, 2);
            table.Controls.Add(new Label() { Text = res.Earth.ToString() }, 5, 2);
            table.Controls.Add(new Label() { Text = res.Light.ToString() }, 6, 2);
            table.Controls.Add(new Label() { Text = res.Dark.ToString() }, 7, 2);



            // Ailment
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Poison_Resistance") }, 0, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Blind_Resistance") }, 1, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Sleep_Resistance") }, 2, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Silence_Resistance") }, 3, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Paralysis_Resistance") }, 4, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Confuse_Resistance") }, 5, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Disease_Resistance") }, 6, 4);
            table.Controls.Add(new Label() { Image = (Image)rm.GetObject("Icon-Petrification_Resistance") }, 7, 4);
            // Number
            table.Controls.Add(new Label() { Text = res.Poison.ToString() }, 0, 5);
            table.Controls.Add(new Label() { Text = res.Blind.ToString() }, 1, 5);
            table.Controls.Add(new Label() { Text = res.Sleep.ToString() }, 2, 5);
            table.Controls.Add(new Label() { Text = res.Silence.ToString() }, 3, 5);
            table.Controls.Add(new Label() { Text = res.Paralysis.ToString() }, 4, 5);
            table.Controls.Add(new Label() { Text = res.Confuse.ToString() }, 5, 5);
            table.Controls.Add(new Label() { Text = res.Disease.ToString() }, 6, 5);
            table.Controls.Add(new Label() { Text = res.Petrification.ToString() }, 7, 5);


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

        private void listView_UnitStats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
