using FFBE_Soft.model;
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

            Unit u = new Unit();

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

            UnitStatsMaxUp su5 = new UnitStatsMaxUp {
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

            UnitResistance r = new UnitResistance() { 
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
                BlueMagicLvl  = 0
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

            this.label_UnitName.Text = u.Name;
            Console.WriteLine("Liste d'armes : " + Unit.GetWeaponsString(u.Weapon).Count);
            Console.WriteLine("Liste d'armures : " + Unit.GetArmorsString(u.Armor).Count);
            this.pictureBox_UnitIdle = this.SetImgByURL(u.ImgURL, this.pictureBox_UnitIdle);

            this.CreateUnitStatListView(u.Stats, this.listView_UnitStats);
            this.CreateUnitStatUpListView(u.StatsMaxUp, this.listView_UnitStatUp);
            this.CreateUnitStatMaxUpListView(u.Stats, u.StatsMaxUp, this.listView_UnitMaxUp);
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
                star.SubItems.Add(stats[index].HP.ToString());
                star.SubItems.Add(stats[index].MP.ToString());
                star.SubItems.Add(stats[index].ATK.ToString());
                star.SubItems.Add(stats[index].DEF.ToString());
                star.SubItems.Add(stats[index].MAG.ToString());
                star.SubItems.Add(stats[index].SPR.ToString());
                star.SubItems.Add(stats[index].AttackHits.ToString());
                star.SubItems.Add(stats[index].LimitDrop.ToString());
                star.SubItems.Add(stats[index].ExpPattern.ToString());

                index++;
                l.Add(star);
            }

            listView.Columns.Add("Rareté", -2, HorizontalAlignment.Center);
            listView.Columns.Add("HP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("ATK", -2, HorizontalAlignment.Center);
            listView.Columns.Add("DEF", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MAG", -2, HorizontalAlignment.Center);
            listView.Columns.Add("SPR", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Attack Hits", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Limit Drops", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Exp. Pattern", -2, HorizontalAlignment.Center);
            

            listView.Items.AddRange(l.ToArray());
        }

        private void CreateUnitStatUpListView(List<UnitStatsMaxUp> stats, ListView listView)
        {
            listView.Bounds = new Rectangle(new Point(10, 125), new Size(300, 100));
            listView.View = View.Details;
            listView.OwnerDraw = true;
            listView.GridLines = true;

            List<ListViewItem> l = new List<ListViewItem>();

            int index = 0;
            foreach (UnitStatsMaxUp s in stats)
            {
                ListViewItem star = new ListViewItem(s.Star.ToString());
                star.SubItems.Add(stats[index].HP.ToString());
                star.SubItems.Add(stats[index].MP.ToString());
                star.SubItems.Add(stats[index].ATK.ToString());
                star.SubItems.Add(stats[index].DEF.ToString());
                star.SubItems.Add(stats[index].MAG.ToString());
                star.SubItems.Add(stats[index].SPR.ToString());

                index++;
                l.Add(star);
            }

            listView.Columns.Add("Rareté", -2, HorizontalAlignment.Center);
            listView.Columns.Add("HP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("ATK", -2, HorizontalAlignment.Center);
            listView.Columns.Add("DEF", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MAG", -2, HorizontalAlignment.Center);
            listView.Columns.Add("SPR", -2, HorizontalAlignment.Center);


            listView.Items.AddRange(l.ToArray());
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
                star.SubItems.Add(stats[index].HP.ToString());
                star.SubItems.Add(stats[index].MP.ToString());
                star.SubItems.Add(stats[index].ATK.ToString());
                star.SubItems.Add(stats[index].DEF.ToString());
                star.SubItems.Add(stats[index].MAG.ToString());
                star.SubItems.Add(stats[index].SPR.ToString());
                star.SubItems.Add(stats[index].AttackHits.ToString());
                star.SubItems.Add(stats[index].LimitDrop.ToString());
                star.SubItems.Add(stats[index].ExpPattern.ToString());

                index++;
                l.Add(star);
            }

            listView.Columns.Add("Rareté", -2, HorizontalAlignment.Center);
            listView.Columns.Add("HP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MP", -2, HorizontalAlignment.Center);
            listView.Columns.Add("ATK", -2, HorizontalAlignment.Center);
            listView.Columns.Add("DEF", -2, HorizontalAlignment.Center);
            listView.Columns.Add("MAG", -2, HorizontalAlignment.Center);
            listView.Columns.Add("SPR", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Attack Hits", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Limit Drops", -2, HorizontalAlignment.Center);
            listView.Columns.Add("Exp. Pattern", -2, HorizontalAlignment.Center);


            listView.Items.AddRange(l.ToArray());
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
