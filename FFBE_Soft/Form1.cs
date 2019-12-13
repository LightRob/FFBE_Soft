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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            this.CenterToParent();

            RichTextBox b = new RichTextBox
            {
                //Location = new Point(157, 25),
                //Size = new Size(135, 50)
            };
            b.SelectionStart = b.TextLength;
            b.SelectionColor = Color.Yellow;
            b.AppendText("Texte en jaune");
            b.SelectionLength = b.TextLength;

            b.SelectionStart = b.TextLength;
            b.SelectionColor = Color.Red;
            b.AppendText("Texte en rouge");
            b.SelectionLength = b.TextLength;

            //Controls.Add(b);

            tableLayoutPanel1.Controls.Add(b, 0, 0);
            tableLayoutPanel1.Controls.Add(b, 0, 1);
            tableLayoutPanel1.Controls.Add(b, 1, 0);
            tableLayoutPanel1.Controls.Add(b, 1, 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UnitDescription().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormDeTest().Show();
        }
    }
}
