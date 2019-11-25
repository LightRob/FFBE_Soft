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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_UnitName = new System.Windows.Forms.Label();
            this.tabControl_Unit = new System.Windows.Forms.TabControl();
            this.tabPage_UnitStats = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Resistance = new System.Windows.Forms.TableLayoutPanel();
            this.listView_UnitMaxUp = new System.Windows.Forms.ListView();
            this.listView_UnitStatUp = new System.Windows.Forms.ListView();
            this.listView_UnitStats = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Ability = new System.Windows.Forms.DataGridView();
            this.MinRariry_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon_Header = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effect_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hits_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_UnitIdle = new System.Windows.Forms.PictureBox();
            this.tabControl_Unit.SuspendLayout();
            this.tabPage_UnitStats.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UnitName
            // 
            this.label_UnitName.AutoSize = true;
            this.label_UnitName.Font = new System.Drawing.Font("Franklin Gothic Medium", 32F);
            this.label_UnitName.Location = new System.Drawing.Point(12, 9);
            this.label_UnitName.Name = "label_UnitName";
            this.label_UnitName.Size = new System.Drawing.Size(110, 50);
            this.label_UnitName.TabIndex = 0;
            this.label_UnitName.Text = "Nom";
            // 
            // tabControl_Unit
            // 
            this.tabControl_Unit.Controls.Add(this.tabPage_UnitStats);
            this.tabControl_Unit.Controls.Add(this.tabPage2);
            this.tabControl_Unit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_Unit.Location = new System.Drawing.Point(335, 0);
            this.tabControl_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Unit.Name = "tabControl_Unit";
            this.tabControl_Unit.SelectedIndex = 0;
            this.tabControl_Unit.Size = new System.Drawing.Size(1563, 1025);
            this.tabControl_Unit.TabIndex = 2;
            // 
            // tabPage_UnitStats
            // 
            this.tabPage_UnitStats.Controls.Add(this.tableLayoutPanel_Resistance);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitMaxUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStatUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStats);
            this.tabPage_UnitStats.Location = new System.Drawing.Point(4, 29);
            this.tabPage_UnitStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_UnitStats.Name = "tabPage_UnitStats";
            this.tabPage_UnitStats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_UnitStats.Size = new System.Drawing.Size(1555, 992);
            this.tabPage_UnitStats.TabIndex = 0;
            this.tabPage_UnitStats.Text = "Statistiques";
            this.tabPage_UnitStats.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Resistance
            // 
            this.tableLayoutPanel_Resistance.ColumnCount = 8;
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel_Resistance.Location = new System.Drawing.Point(15, 580);
            this.tableLayoutPanel_Resistance.Name = "tableLayoutPanel_Resistance";
            this.tableLayoutPanel_Resistance.RowCount = 6;
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.Size = new System.Drawing.Size(400, 200);
            this.tableLayoutPanel_Resistance.TabIndex = 3;
            this.tableLayoutPanel_Resistance.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableRes_CellPaint);
            // 
            // listView_UnitMaxUp
            // 
            this.listView_UnitMaxUp.HideSelection = false;
            this.listView_UnitMaxUp.Location = new System.Drawing.Point(15, 375);
            this.listView_UnitMaxUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitMaxUp.Name = "listView_UnitMaxUp";
            this.listView_UnitMaxUp.Size = new System.Drawing.Size(750, 150);
            this.listView_UnitMaxUp.TabIndex = 2;
            this.listView_UnitMaxUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitMaxUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitMaxUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStatUp
            // 
            this.listView_UnitStatUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_UnitStatUp.HideSelection = false;
            this.listView_UnitStatUp.Location = new System.Drawing.Point(15, 191);
            this.listView_UnitStatUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitStatUp.Name = "listView_UnitStatUp";
            this.listView_UnitStatUp.Size = new System.Drawing.Size(450, 150);
            this.listView_UnitStatUp.TabIndex = 1;
            this.listView_UnitStatUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStatUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStatUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStats
            // 
            this.listView_UnitStats.HideSelection = false;
            this.listView_UnitStats.Location = new System.Drawing.Point(15, 14);
            this.listView_UnitStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_UnitStats.Name = "listView_UnitStats";
            this.listView_UnitStats.Size = new System.Drawing.Size(750, 150);
            this.listView_UnitStats.TabIndex = 0;
            this.listView_UnitStats.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStats.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStats.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            this.listView_UnitStats.SelectedIndexChanged += new System.EventHandler(this.listView_UnitStats_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Ability);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1555, 992);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compétences Actives";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Ability
            // 
            this.dataGridView_Ability.AllowUserToAddRows = false;
            this.dataGridView_Ability.AllowUserToDeleteRows = false;
            this.dataGridView_Ability.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Ability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinRariry_Header,
            this.Level_Header,
            this.Icon_Header,
            this.Name_Header,
            this.Effect_Header,
            this.Hits_Header,
            this.Cost_Header});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Ability.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Ability.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_Ability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Ability.Name = "dataGridView_Ability";
            this.dataGridView_Ability.ReadOnly = true;
            this.dataGridView_Ability.RowHeadersWidth = 62;
            this.dataGridView_Ability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Ability.Size = new System.Drawing.Size(1532, 981);
            this.dataGridView_Ability.TabIndex = 0;
            // 
            // MinRariry_Header
            // 
            this.MinRariry_Header.HeaderText = "Min Rarity";
            this.MinRariry_Header.MinimumWidth = 8;
            this.MinRariry_Header.Name = "MinRariry_Header";
            this.MinRariry_Header.ReadOnly = true;
            this.MinRariry_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinRariry_Header.Width = 50;
            // 
            // Level_Header
            // 
            this.Level_Header.HeaderText = "Level";
            this.Level_Header.MinimumWidth = 8;
            this.Level_Header.Name = "Level_Header";
            this.Level_Header.ReadOnly = true;
            this.Level_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Level_Header.Width = 60;
            // 
            // Icon_Header
            // 
            this.Icon_Header.HeaderText = "Icon";
            this.Icon_Header.MinimumWidth = 8;
            this.Icon_Header.Name = "Icon_Header";
            this.Icon_Header.ReadOnly = true;
            this.Icon_Header.Width = 72;
            // 
            // Name_Header
            // 
            this.Name_Header.HeaderText = "Name";
            this.Name_Header.MinimumWidth = 8;
            this.Name_Header.Name = "Name_Header";
            this.Name_Header.ReadOnly = true;
            this.Name_Header.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name_Header.Width = 150;
            // 
            // Effect_Header
            // 
            this.Effect_Header.HeaderText = "Effect";
            this.Effect_Header.MinimumWidth = 8;
            this.Effect_Header.Name = "Effect_Header";
            this.Effect_Header.ReadOnly = true;
            this.Effect_Header.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Effect_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Effect_Header.Width = 528;
            // 
            // Hits_Header
            // 
            this.Hits_Header.HeaderText = "Hits";
            this.Hits_Header.MinimumWidth = 8;
            this.Hits_Header.Name = "Hits_Header";
            this.Hits_Header.ReadOnly = true;
            this.Hits_Header.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hits_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hits_Header.Width = 50;
            // 
            // Cost_Header
            // 
            this.Cost_Header.HeaderText = "Cost";
            this.Cost_Header.MinimumWidth = 8;
            this.Cost_Header.Name = "Cost_Header";
            this.Cost_Header.ReadOnly = true;
            this.Cost_Header.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cost_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cost_Header.Width = 70;
            // 
            // pictureBox_UnitIdle
            // 
            this.pictureBox_UnitIdle.Location = new System.Drawing.Point(26, 115);
            this.pictureBox_UnitIdle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_UnitIdle.Name = "pictureBox_UnitIdle";
            this.pictureBox_UnitIdle.Size = new System.Drawing.Size(220, 229);
            this.pictureBox_UnitIdle.TabIndex = 1;
            this.pictureBox_UnitIdle.TabStop = false;
            // 
            // UnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1025);
            this.Controls.Add(this.tabControl_Unit);
            this.Controls.Add(this.pictureBox_UnitIdle);
            this.Controls.Add(this.label_UnitName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UnitDescription";
            this.Text = "UnitDescriptionEr";
            this.tabControl_Unit.ResumeLayout(false);
            this.tabPage_UnitStats.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Resistance;
        private System.Windows.Forms.DataGridView dataGridView_Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRariry_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level_Header;
        private System.Windows.Forms.DataGridViewImageColumn Icon_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effect_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hits_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Header;
    }
}