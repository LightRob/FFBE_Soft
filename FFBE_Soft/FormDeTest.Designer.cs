namespace FFBE_Soft
{
    partial class FormDeTest
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
            this.panelLeftInfo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxUnit = new System.Windows.Forms.PictureBox();
            this.statsTestUserControl1 = new FFBE_Soft.StatsTestUserControl();
            this.panelLeftInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // panelLeftInfo
            // 
            this.panelLeftInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLeftInfo.Controls.Add(this.label1);
            this.panelLeftInfo.Controls.Add(this.pictureBoxUnit);
            this.panelLeftInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftInfo.Location = new System.Drawing.Point(0, 0);
            this.panelLeftInfo.Name = "panelLeftInfo";
            this.panelLeftInfo.Size = new System.Drawing.Size(284, 871);
            this.panelLeftInfo.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.button3);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(284, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1446, 126);
            this.panelHeader.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 130);
            this.button2.TabIndex = 0;
            this.button2.Text = "Statistiques";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F);
            this.label1.Location = new System.Drawing.Point(88, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Esther";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(319, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 130);
            this.button3.TabIndex = 1;
            this.button3.Text = "Capacités Passives";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBoxUnit
            // 
            this.pictureBoxUnit.BackColor = System.Drawing.Color.White;
            this.pictureBoxUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxUnit.Image = global::FFBE_Soft.Properties.Resources.Esther_Idle;
            this.pictureBoxUnit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUnit.Name = "pictureBoxUnit";
            this.pictureBoxUnit.Size = new System.Drawing.Size(284, 210);
            this.pictureBoxUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnit.TabIndex = 5;
            this.pictureBoxUnit.TabStop = false;
            // 
            // statsTestUserControl1
            // 
            this.statsTestUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statsTestUserControl1.Location = new System.Drawing.Point(284, 125);
            this.statsTestUserControl1.Name = "statsTestUserControl1";
            this.statsTestUserControl1.Size = new System.Drawing.Size(1446, 746);
            this.statsTestUserControl1.TabIndex = 5;
            // 
            // FormDeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 871);
            this.Controls.Add(this.statsTestUserControl1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeftInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeTest";
            this.Text = "FormDeTest";
            this.panelLeftInfo.ResumeLayout(false);
            this.panelLeftInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeftInfo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private StatsTestUserControl statsTestUserControl1;
    }
}