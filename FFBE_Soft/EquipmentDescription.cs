using FFBE_Soft.model;
using FFBE_Soft.model.competence;
using FFBE_Soft.model.equipment;
using FFBE_Soft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFBE_Soft
{
    public partial class EquipmentDescription : Form
    {

        ResourceManager rm = Resources.ResourceManager;

        private readonly Equipment equipment;

        public EquipmentDescription(string nom)
        {
            InitializeComponent();
            CenterToParent();


            // ---- TMR
            if(nom.Equals("Storm Kickers"))
            {
                Equipment S_K = Equipment.CreateEquipment("Storm Kickers", "A pair of sneackers said to have belonged to a warrior of legend. On the right set of feet these stylish shoes are capable of granting its wearer the power to withstand lightning."
                    , "Icon-Storm_Kickers", EquipmentType.Accessory, "TMR Esther");
                S_K.AddFixedStat(StatBuffed.ATK, 45); S_K.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect S_K1_1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP, 20);
                PassiveEffect S_K1_2 = PassiveEffect.CreateLBDamageEffect(true, 15);
                UnitPassive S_K1 = new UnitPassive(0, 0, "Icon-Ability_276", "Inner Limit");
                S_K1.AddPassiveEffect(S_K1_1);
                S_K1.AddPassiveEffect(S_K1_2);
                S_K.AddEquipmentEffectPassive(S_K1);

                PassiveEffect S_K2_1 = PassiveEffect.CreateAbsorbDamageEffect(ElementDamage.Lightning, TypeDamage.Hybrid);
                UnitPassive S_K2 = new UnitPassive(0, 0, "Icon-Ability_280", "Stormborne"); S_K2.UsableWitheList = true; S_K2.AddUnitToWhiteList("Esther");
                S_K2.AddPassiveEffect(S_K2_1);
                S_K.AddEquipmentEffectPassive(S_K2);

                equipment = S_K;
            } else // ---- STMR
            {
                Equipment SBJ = Equipment.CreateEquipment("Storm Bunny Jacket", "A unique jacket with a hood that ressembles rabbit ears. It fills its wearer with the instincts of a swift killer, and adds to their endurance and strength as well. Woven with the finest fabric of a distant world, it was exclusively made for a certain warrior of legend.",
                    "Icon-Storm_Bunny_Jacket", EquipmentType.Clothe, "STM Esther");
                SBJ.AddFixedStat(StatBuffed.HP, 800); SBJ.AddFixedStat(StatBuffed.ATK, 40); SBJ.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect SBJ1_1 = PassiveEffect.CreateMonsterRaceBuffEffect(true, MonsterRace.Machinas | MonsterRace.Stones, TypeDamage.Hybrid, 50);
                UnitPassive SBJ1 = new UnitPassive(0, 0, "Icon-Ability_275", "Killer Instincts");
                SBJ1.AddPassiveEffect(SBJ1_1);
                SBJ.AddEquipmentEffectPassive(SBJ1);

                PassiveEffect SBJ2_1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP, 20);
                PassiveEffect SBJ2_2 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.ATK, 30);
                UnitPassive SBJ2 = new UnitPassive(0, 0, "Icon-Ability_276", "Exquisite Weaving"); SBJ2.UsableWitheList = true; SBJ2.AddUnitToWhiteList("Esther");
                SBJ2.AddPassiveEffect(SBJ2_1);
                SBJ2.AddPassiveEffect(SBJ2_2);
                SBJ.AddEquipmentEffectPassive(SBJ2);

                equipment = SBJ;
            }

            InitializeUpPanel();
            InitializeStatsTab();
            InitializePassiveTab();

            Text = equipment.Name;
        }

        private void InitializeUpPanel()
        {
            pictureBox_Img.Image = (Image)rm.GetObject(equipment.ImgURL);
            label_Name.Text = equipment.Name;
        }

        private void InitializeStatsTab()
        {
            richTextBox_Type.Text = equipment.EquipmentType.ToString();
            richTextBox_Stats.Text = equipment.GetStatsText();
            richTextBox_Element.Text = equipment.GetElementText();
            richTextBox_Resistance.Text = equipment.GetResistanceText();
            richTextBox_Effects.Text = equipment.GetEffectsText();
            textBox_Description.Text = equipment.Description;

            richTextBox_Obtain.Text = equipment.HowToObtain;
        }

        private void InitializePassiveTab()
        {
            TableLayoutPanel table = tableLayoutPanel1;

            TextBox tbHeaderIMG = new TextBox
            {
                Dock = DockStyle.Fill,
                Text = "Icon",
                TextAlign = HorizontalAlignment.Center,
                BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F"),
                Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                ReadOnly = true
            };
            table.Controls.Add(tbHeaderIMG, 0, 0);


            TextBox tbHeaderName = new TextBox
            {
                Dock = DockStyle.Fill,
                Text = "Name",
                TextAlign = HorizontalAlignment.Center,
                BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F"),
                Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                ReadOnly = true
            };
            table.Controls.Add(tbHeaderName, 1, 0);


            TextBox tbHeaderEffect = new TextBox
            {
                Dock = DockStyle.Fill,
                Text = "Effect",
                TextAlign = HorizontalAlignment.Center,
                BackColor = (Color)new ColorConverter().ConvertFromString("#4D627F"),
                Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold),
                ForeColor = Color.GhostWhite,
                ReadOnly = true
            };
            table.Controls.Add(tbHeaderEffect, 2, 0);

            int i = 0;

            foreach (UnitPassive passive in equipment.EquipmentEffectsPassives)
            {
                i++;
                table.RowCount += 1;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
                table.Update();
                Button b = new Button
                {
                    Image = (Image)rm.GetObject(passive.ImgURL),
                    Size = new Size(72, 72),
                    ImageAlign = ContentAlignment.MiddleCenter,
                };
                table.Controls.Add(b, 0, i);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.DarkSlateBlue, 2);

            Point p1 = new Point(120, 70);
            Point p2 = new Point(690, 70);

            e.Graphics.DrawLine(blackPen, p1, p2);
        }
    }
}
