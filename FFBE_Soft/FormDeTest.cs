using FFBE_Soft.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFBE_Soft
{
    public partial class FormDeTest : Form
    {
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
        }

        private void CreateUnitResTableView(UnitResistance res, TableLayoutPanel table)
        {
            table.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            table.BackColor = Color.LightGray;

            table.RowCount = 2;
            table.ColumnCount = 8;

            table.Controls.Add(new Label() { Text = "Element Resistance" });
            table.Controls.Add(new Label() { Text = "Statut Ailment Resistance" });
            table.SetColumnSpan(new Label() { Text = "Bite" }, 8);
        }

        private void tableRes_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
        }
    }
}
