using FFBE_Soft.model;
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
    public partial class FormDeTest : Form
    {

        ResourceManager rm = Resources.ResourceManager;

        public FormDeTest()
        {
            InitializeComponent();
            Unit u = new Unit();

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

            u.Resistance = r;

            this.CreateUnitResTableView(u.Resistance, this.tableRes);
            //this.InitializeResizingListView();
        }

        private ListView resizingListView = new ListView();
        private Button button1 = new Button();

        private void InitializeResizingListView()
        {
            // Set location and text for button.
            button1.Location = new Point(100, 15);
            button1.Text = "Resize";
            button1.Click += new EventHandler(button1_Click);

            // Set the ListView to details view.
            resizingListView.View = View.Details;

            //Set size, location and populate the ListView.
            resizingListView.Size = new Size(200, 100);
            resizingListView.Location = new Point(40, 40);
            resizingListView.Columns.Add("HeaderSize");
            resizingListView.Columns.Add("ColumnContent");
            ListViewItem listItem1 = new ListViewItem("Short");
            ListViewItem listItem2 = new ListViewItem("Tiny");
            listItem1.SubItems.Add(new ListViewItem.ListViewSubItem(
                    listItem1, "Something longer"));
            listItem2.SubItems.Add(new ListViewItem.ListViewSubItem(
                listItem2, "Something even longer"));
            resizingListView.Items.Add(listItem1);
            resizingListView.Items.Add(listItem2);

            // Add the ListView and the Button to the form.
            this.Controls.Add(resizingListView);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resizingListView.AutoResizeColumn(0,
                ColumnHeaderAutoResizeStyle.HeaderSize);
            resizingListView.AutoResizeColumn(1,
                ColumnHeaderAutoResizeStyle.ColumnContent);
        }





        private void CreateUnitResTableView(UnitResistance res, TableLayoutPanel table)
        {
            table.Bounds = new Rectangle(new Point(10, 10), new Size(400, 200));
            table.BackColor = Color.LightGray;

            table.RowCount = 6;
            table.ColumnCount = 8;


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

        private void tableRes_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Control c = this.tableRes.GetControlFromPosition(e.Column, e.Row);



            if (c != null)
            {
                    Graphics g = e.Graphics;
                if (tableRes.GetColumnSpan(c) > 1)
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
                }
                else
                {
                    g.DrawRectangle(
                        Pens.Gray,
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2, e.CellBounds.Height - 2);

                    g.FillRectangle(
                        Brushes.White,
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 1,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);
                }
            }
        }

        /*
        private void tableRes_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
        }*/
    }
}
