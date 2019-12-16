namespace FFBE_Soft
{
    partial class EquipmentDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_Equipment = new System.Windows.Forms.TabControl();
            this.tabPage_Stats = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Type = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Stats = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Element = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Resistance = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Effects = new System.Windows.Forms.RichTextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_Obtain = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl_Equipment.SuspendLayout();
            this.tabPage_Stats.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.pictureBox_Img);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 185);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(183, 12);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(156, 61);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "label1";
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(119, 119);
            this.pictureBox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Img.TabIndex = 0;
            this.pictureBox_Img.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl_Equipment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 353);
            this.panel2.TabIndex = 1;
            // 
            // tabControl_Equipment
            // 
            this.tabControl_Equipment.Controls.Add(this.tabPage_Stats);
            this.tabControl_Equipment.Controls.Add(this.tabPage2);
            this.tabControl_Equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Equipment.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Equipment.Name = "tabControl_Equipment";
            this.tabControl_Equipment.SelectedIndex = 0;
            this.tabControl_Equipment.Size = new System.Drawing.Size(948, 353);
            this.tabControl_Equipment.TabIndex = 0;
            // 
            // tabPage_Stats
            // 
            this.tabPage_Stats.Controls.Add(this.richTextBox_Obtain);
            this.tabPage_Stats.Controls.Add(this.label6);
            this.tabPage_Stats.Controls.Add(this.richTextBox_Effects);
            this.tabPage_Stats.Controls.Add(this.richTextBox_Resistance);
            this.tabPage_Stats.Controls.Add(this.richTextBox_Element);
            this.tabPage_Stats.Controls.Add(this.richTextBox_Stats);
            this.tabPage_Stats.Controls.Add(this.richTextBox_Type);
            this.tabPage_Stats.Controls.Add(this.label5);
            this.tabPage_Stats.Controls.Add(this.label4);
            this.tabPage_Stats.Controls.Add(this.label3);
            this.tabPage_Stats.Controls.Add(this.label2);
            this.tabPage_Stats.Controls.Add(this.label1);
            this.tabPage_Stats.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Stats.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Stats.Name = "tabPage_Stats";
            this.tabPage_Stats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Stats.Size = new System.Drawing.Size(940, 324);
            this.tabPage_Stats.TabIndex = 0;
            this.tabPage_Stats.Text = "Statistics";
            this.tabPage_Stats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stats :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Element :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resistance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Additional effect :";
            // 
            // richTextBox_Type
            // 
            this.richTextBox_Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Type.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Type.Location = new System.Drawing.Point(100, 20);
            this.richTextBox_Type.Name = "richTextBox_Type";
            this.richTextBox_Type.ReadOnly = true;
            this.richTextBox_Type.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Type.Size = new System.Drawing.Size(825, 25);
            this.richTextBox_Type.TabIndex = 5;
            this.richTextBox_Type.Text = " --- ---";
            this.richTextBox_Type.WordWrap = false;
            // 
            // richTextBox_Stats
            // 
            this.richTextBox_Stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Stats.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Stats.Location = new System.Drawing.Point(100, 60);
            this.richTextBox_Stats.Name = "richTextBox_Stats";
            this.richTextBox_Stats.ReadOnly = true;
            this.richTextBox_Stats.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Stats.Size = new System.Drawing.Size(825, 25);
            this.richTextBox_Stats.TabIndex = 6;
            this.richTextBox_Stats.Text = " --- ---";
            this.richTextBox_Stats.WordWrap = false;
            // 
            // richTextBox_Element
            // 
            this.richTextBox_Element.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Element.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Element.Location = new System.Drawing.Point(125, 100);
            this.richTextBox_Element.Name = "richTextBox_Element";
            this.richTextBox_Element.ReadOnly = true;
            this.richTextBox_Element.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Element.Size = new System.Drawing.Size(800, 25);
            this.richTextBox_Element.TabIndex = 7;
            this.richTextBox_Element.Text = " --- ---";
            this.richTextBox_Element.WordWrap = false;
            // 
            // richTextBox_Resistance
            // 
            this.richTextBox_Resistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Resistance.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Resistance.Location = new System.Drawing.Point(150, 140);
            this.richTextBox_Resistance.Name = "richTextBox_Resistance";
            this.richTextBox_Resistance.ReadOnly = true;
            this.richTextBox_Resistance.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Resistance.Size = new System.Drawing.Size(775, 25);
            this.richTextBox_Resistance.TabIndex = 8;
            this.richTextBox_Resistance.Text = " --- ---";
            this.richTextBox_Resistance.WordWrap = false;
            // 
            // richTextBox_Effects
            // 
            this.richTextBox_Effects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Effects.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Effects.Location = new System.Drawing.Point(200, 180);
            this.richTextBox_Effects.Name = "richTextBox_Effects";
            this.richTextBox_Effects.ReadOnly = true;
            this.richTextBox_Effects.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Effects.Size = new System.Drawing.Size(725, 25);
            this.richTextBox_Effects.TabIndex = 9;
            this.richTextBox_Effects.Text = " --- ---";
            this.richTextBox_Effects.WordWrap = false;
            // 
            // textBox_Description
            // 
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.textBox_Description.HideSelection = false;
            this.textBox_Description.Location = new System.Drawing.Point(154, 109);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ReadOnly = true;
            this.textBox_Description.Size = new System.Drawing.Size(782, 60);
            this.textBox_Description.TabIndex = 0;
            this.textBox_Description.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "How to obtain :";
            // 
            // richTextBox_Obtain
            // 
            this.richTextBox_Obtain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Obtain.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Obtain.Location = new System.Drawing.Point(175, 260);
            this.richTextBox_Obtain.Name = "richTextBox_Obtain";
            this.richTextBox_Obtain.ReadOnly = true;
            this.richTextBox_Obtain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Obtain.Size = new System.Drawing.Size(750, 25);
            this.richTextBox_Obtain.TabIndex = 11;
            this.richTextBox_Obtain.Text = " --- ---";
            this.richTextBox_Obtain.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EquipmentDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EquipmentDescription";
            this.Text = "EquipmentDescription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl_Equipment.ResumeLayout(false);
            this.tabPage_Stats.ResumeLayout(false);
            this.tabPage_Stats.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox_Img;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl_Equipment;
        private System.Windows.Forms.TabPage tabPage_Stats;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Effects;
        private System.Windows.Forms.RichTextBox richTextBox_Resistance;
        private System.Windows.Forms.RichTextBox richTextBox_Element;
        private System.Windows.Forms.RichTextBox richTextBox_Stats;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.RichTextBox richTextBox_Obtain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}