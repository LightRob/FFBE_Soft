using FFBE_Soft.model;
using FFBE_Soft.model.competence;
using FFBE_Soft.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.WindowState = FormWindowState.Maximized;

            Unit Esther = this.SetEstherBDD();

            this.label_UnitName.Text = Esther.Name;
            Console.WriteLine("Liste d'armes : " + Unit.GetWeaponsString(Esther.Weapon).Count);
            Console.WriteLine("Liste d'armures : " + Unit.GetArmorsString(Esther.Armor).Count);
            this.pictureBox_UnitIdle = this.SetImgByURL(Esther.ImgURL, this.pictureBox_UnitIdle);

            this.CreateUnitStatListView(Esther.Stats, this.listView_UnitStats);
            this.CreateUnitStatUpListView(Esther.StatsMaxUp, this.listView_UnitStatUp);
            this.CreateUnitStatMaxUpListView(Esther.Stats, Esther.StatsMaxUp, this.listView_UnitMaxUp);
            this.CreateUnitResTableView(Esther.Resistance, this.tableLayoutPanel_Resistance);
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
            CompEffect S_F1 = new CompEffect(true, TypeDamage.Physical, ScalingDamage.ATK, ElementDamage.Neutral, 300, 0, true, false, false, 7);
            CompEffect S_F2 = new CompEffect(true, 0, 4, 6, false, false, true);
            UnitCompActive S_F = new UnitCompActive(5, 5, "", "Shock Flash", 22);

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
    }
}
