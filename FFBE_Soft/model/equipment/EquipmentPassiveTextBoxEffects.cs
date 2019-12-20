using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFBE_Soft.model.equipment
{
    public partial class EquipmentPassiveTextBoxEffects : UserControl
    {
        public string Text
        {
            get
            {
                return richTextBox.Text;
            }
            set
            {
                richTextBox.Text = value;
            }
        }

        public EquipmentPassiveTextBoxEffects()
        {
            InitializeComponent();
            richTextBox.BorderStyle = BorderStyle.Fixed3D;
            BorderStyle = BorderStyle.FixedSingle;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void richTextBox_Resize(object sender, EventArgs e)
        {
            richTextBox.Left = 0;
            richTextBox.Top = (this.Height - richTextBox.Height) / 2;
            richTextBox.Width = Width;
        }
    }
}
