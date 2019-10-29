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
            this.WindowState = FormWindowState.Maximized;
            this.button2.Click += new System.EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Bite";
            new UnitDescription().Show();
        }
    }
}
