namespace FFBE_Soft
{
    partial class UnitDescription
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
            this.label_UnitName = new System.Windows.Forms.Label();
            this.pictureBox_UnitIdle = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UnitName
            // 
            this.label_UnitName.AutoSize = true;
            this.label_UnitName.Font = new System.Drawing.Font("Franklin Gothic Medium", 32F);
            this.label_UnitName.Location = new System.Drawing.Point(12, 9);
            this.label_UnitName.Name = "label_UnitName";
            this.label_UnitName.Size = new System.Drawing.Size(167, 81);
            this.label_UnitName.TabIndex = 0;
            this.label_UnitName.Text = "Nom";
            // 
            // pictureBox_UnitIdle
            // 
            this.pictureBox_UnitIdle.Location = new System.Drawing.Point(26, 116);
            this.pictureBox_UnitIdle.Name = "pictureBox_UnitIdle";
            this.pictureBox_UnitIdle.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_UnitIdle.TabIndex = 1;
            this.pictureBox_UnitIdle.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(384, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1502, 1000);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1494, 967);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1494, 967);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 229);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox_UnitIdle);
            this.Controls.Add(this.label_UnitName);
            this.Name = "UnitDescription";
            this.Text = "UnitDescription";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UnitName;
        private System.Windows.Forms.PictureBox pictureBox_UnitIdle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
    }
}