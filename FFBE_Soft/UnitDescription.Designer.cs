﻿namespace FFBE_Soft
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
            this.tabControl_Unit = new System.Windows.Forms.TabControl();
            this.tabPage_UnitStats = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView_UnitMaxUp = new System.Windows.Forms.ListView();
            this.listView_UnitStatUp = new System.Windows.Forms.ListView();
            this.listView_UnitStats = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox_UnitIdle = new System.Windows.Forms.PictureBox();
            this.tabControl_Unit.SuspendLayout();
            this.tabPage_UnitStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UnitName
            // 
            this.label_UnitName.AutoSize = true;
            this.label_UnitName.Font = new System.Drawing.Font("Franklin Gothic Medium", 32F);
            this.label_UnitName.Location = new System.Drawing.Point(11, 7);
            this.label_UnitName.Name = "label_UnitName";
            this.label_UnitName.Size = new System.Drawing.Size(140, 68);
            this.label_UnitName.TabIndex = 0;
            this.label_UnitName.Text = "Nom";
            // 
            // tabControl_Unit
            // 
            this.tabControl_Unit.Controls.Add(this.tabPage_UnitStats);
            this.tabControl_Unit.Controls.Add(this.tabPage2);
            this.tabControl_Unit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_Unit.Location = new System.Drawing.Point(461, 0);
            this.tabControl_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Unit.Name = "tabControl_Unit";
            this.tabControl_Unit.SelectedIndex = 0;
            this.tabControl_Unit.Size = new System.Drawing.Size(1226, 820);
            this.tabControl_Unit.TabIndex = 2;
            // 
            // tabPage_UnitStats
            // 
            this.tabPage_UnitStats.Controls.Add(this.listView1);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitMaxUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStatUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStats);
            this.tabPage_UnitStats.Location = new System.Drawing.Point(4, 25);
            this.tabPage_UnitStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_UnitStats.Name = "tabPage_UnitStats";
            this.tabPage_UnitStats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_UnitStats.Size = new System.Drawing.Size(1218, 791);
            this.tabPage_UnitStats.TabIndex = 0;
            this.tabPage_UnitStats.Text = "Statistiques";
            this.tabPage_UnitStats.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(727, 12);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 121);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView_UnitMaxUp
            // 
            this.listView_UnitMaxUp.HideSelection = false;
            this.listView_UnitMaxUp.Location = new System.Drawing.Point(13, 300);
            this.listView_UnitMaxUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitMaxUp.Name = "listView_UnitMaxUp";
            this.listView_UnitMaxUp.Size = new System.Drawing.Size(667, 121);
            this.listView_UnitMaxUp.TabIndex = 2;
            this.listView_UnitMaxUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitMaxUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitMaxUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStatUp
            // 
            this.listView_UnitStatUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_UnitStatUp.HideSelection = false;
            this.listView_UnitStatUp.Location = new System.Drawing.Point(13, 150);
            this.listView_UnitStatUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitStatUp.Name = "listView_UnitStatUp";
            this.listView_UnitStatUp.Size = new System.Drawing.Size(400, 121);
            this.listView_UnitStatUp.TabIndex = 1;
            this.listView_UnitStatUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStatUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStatUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStats
            // 
            this.listView_UnitStats.HideSelection = false;
            this.listView_UnitStats.Location = new System.Drawing.Point(13, 12);
            this.listView_UnitStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitStats.Name = "listView_UnitStats";
            this.listView_UnitStats.Size = new System.Drawing.Size(667, 121);
            this.listView_UnitStats.TabIndex = 0;
            this.listView_UnitStats.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStats.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStats.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1218, 791);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_UnitIdle
            // 
            this.pictureBox_UnitIdle.Location = new System.Drawing.Point(23, 92);
            this.pictureBox_UnitIdle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_UnitIdle.Name = "pictureBox_UnitIdle";
            this.pictureBox_UnitIdle.Size = new System.Drawing.Size(196, 183);
            this.pictureBox_UnitIdle.TabIndex = 1;
            this.pictureBox_UnitIdle.TabStop = false;
            // 
            // UnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 820);
            this.Controls.Add(this.tabControl_Unit);
            this.Controls.Add(this.pictureBox_UnitIdle);
            this.Controls.Add(this.label_UnitName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UnitDescription";
            this.Text = "UnitDescription";
            this.tabControl_Unit.ResumeLayout(false);
            this.tabPage_UnitStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UnitName;
        private System.Windows.Forms.PictureBox pictureBox_UnitIdle;
        private System.Windows.Forms.TabControl tabControl_Unit;
        private System.Windows.Forms.TabPage tabPage_UnitStats;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_UnitStats;
        private System.Windows.Forms.ListView listView_UnitMaxUp;
        private System.Windows.Forms.ListView listView_UnitStatUp;
        private System.Windows.Forms.ListView listView1;
    }
}