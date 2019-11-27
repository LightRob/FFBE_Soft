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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_UnitName = new System.Windows.Forms.Label();
            this.tabControl_Unit = new System.Windows.Forms.TabControl();
            this.tabPage_UnitStats = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Resistance = new System.Windows.Forms.TableLayoutPanel();
            this.listView_UnitMaxUp = new System.Windows.Forms.ListView();
            this.listView_UnitStatUp = new System.Windows.Forms.ListView();
            this.listView_UnitStats = new System.Windows.Forms.ListView();
            this.tabPage_Abilities = new System.Windows.Forms.TabPage();
            this.dataGridView_Ability = new System.Windows.Forms.DataGridView();
            this.MinRariry_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon_Header = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effect_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hits_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_UnitIdle = new System.Windows.Forms.PictureBox();
            this.tabPage_Passives = new System.Windows.Forms.TabPage();
            this.dataGridView_Passives = new System.Windows.Forms.DataGridView();
            this.MinRariryPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IconPassives_Header = new System.Windows.Forms.DataGridViewImageColumn();
            this.NamePassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_Unit.SuspendLayout();
            this.tabPage_UnitStats.SuspendLayout();
            this.tabPage_Abilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).BeginInit();
            this.tabPage_Passives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passives)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UnitName
            // 
            this.label_UnitName.AutoSize = true;
            this.label_UnitName.Font = new System.Drawing.Font("Franklin Gothic Medium", 32F);
            this.label_UnitName.Location = new System.Drawing.Point(8, 6);
            this.label_UnitName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UnitName.Name = "label_UnitName";
            this.label_UnitName.Size = new System.Drawing.Size(110, 50);
            this.label_UnitName.TabIndex = 0;
            this.label_UnitName.Text = "Nom";
            // 
            // tabControl_Unit
            // 
            this.tabControl_Unit.Controls.Add(this.tabPage_UnitStats);
            this.tabControl_Unit.Controls.Add(this.tabPage_Abilities);
            this.tabControl_Unit.Controls.Add(this.tabPage_Passives);
            this.tabControl_Unit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_Unit.Location = new System.Drawing.Point(223, 0);
            this.tabControl_Unit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl_Unit.Name = "tabControl_Unit";
            this.tabControl_Unit.SelectedIndex = 0;
            this.tabControl_Unit.Size = new System.Drawing.Size(1042, 666);
            this.tabControl_Unit.TabIndex = 2;
            // 
            // tabPage_UnitStats
            // 
            this.tabPage_UnitStats.Controls.Add(this.tableLayoutPanel_Resistance);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitMaxUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStatUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStats);
            this.tabPage_UnitStats.Location = new System.Drawing.Point(4, 22);
            this.tabPage_UnitStats.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage_UnitStats.Name = "tabPage_UnitStats";
            this.tabPage_UnitStats.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage_UnitStats.Size = new System.Drawing.Size(1034, 640);
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
            this.tableLayoutPanel_Resistance.Location = new System.Drawing.Point(10, 377);
            this.tableLayoutPanel_Resistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_Resistance.Name = "tableLayoutPanel_Resistance";
            this.tableLayoutPanel_Resistance.RowCount = 6;
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resistance.Size = new System.Drawing.Size(267, 130);
            this.tableLayoutPanel_Resistance.TabIndex = 3;
            this.tableLayoutPanel_Resistance.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableRes_CellPaint);
            // 
            // listView_UnitMaxUp
            // 
            this.listView_UnitMaxUp.HideSelection = false;
            this.listView_UnitMaxUp.Location = new System.Drawing.Point(10, 244);
            this.listView_UnitMaxUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView_UnitMaxUp.Name = "listView_UnitMaxUp";
            this.listView_UnitMaxUp.Size = new System.Drawing.Size(501, 99);
            this.listView_UnitMaxUp.TabIndex = 2;
            this.listView_UnitMaxUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitMaxUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitMaxUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStatUp
            // 
            this.listView_UnitStatUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_UnitStatUp.HideSelection = false;
            this.listView_UnitStatUp.Location = new System.Drawing.Point(10, 124);
            this.listView_UnitStatUp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView_UnitStatUp.Name = "listView_UnitStatUp";
            this.listView_UnitStatUp.Size = new System.Drawing.Size(301, 99);
            this.listView_UnitStatUp.TabIndex = 1;
            this.listView_UnitStatUp.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStatUp.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStatUp.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // listView_UnitStats
            // 
            this.listView_UnitStats.HideSelection = false;
            this.listView_UnitStats.Location = new System.Drawing.Point(10, 9);
            this.listView_UnitStats.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView_UnitStats.Name = "listView_UnitStats";
            this.listView_UnitStats.Size = new System.Drawing.Size(501, 99);
            this.listView_UnitStats.TabIndex = 0;
            this.listView_UnitStats.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStats.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStats.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            this.listView_UnitStats.SelectedIndexChanged += new System.EventHandler(this.listView_UnitStats_SelectedIndexChanged);
            // 
            // tabPage_Abilities
            // 
            this.tabPage_Abilities.Controls.Add(this.dataGridView_Ability);
            this.tabPage_Abilities.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Abilities.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage_Abilities.Name = "tabPage_Abilities";
            this.tabPage_Abilities.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage_Abilities.Size = new System.Drawing.Size(1034, 640);
            this.tabPage_Abilities.TabIndex = 1;
            this.tabPage_Abilities.Text = "Compétences Actives";
            this.tabPage_Abilities.UseVisualStyleBackColor = true;
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
            this.dataGridView_Ability.Location = new System.Drawing.Point(5, 4);
            this.dataGridView_Ability.Name = "dataGridView_Ability";
            this.dataGridView_Ability.ReadOnly = true;
            this.dataGridView_Ability.RowHeadersWidth = 62;
            this.dataGridView_Ability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Ability.Size = new System.Drawing.Size(1021, 638);
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
            this.pictureBox_UnitIdle.Location = new System.Drawing.Point(17, 75);
            this.pictureBox_UnitIdle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox_UnitIdle.Name = "pictureBox_UnitIdle";
            this.pictureBox_UnitIdle.Size = new System.Drawing.Size(147, 149);
            this.pictureBox_UnitIdle.TabIndex = 1;
            this.pictureBox_UnitIdle.TabStop = false;
            // 
            // tabPage_Passives
            // 
            this.tabPage_Passives.Controls.Add(this.dataGridView_Passives);
            this.tabPage_Passives.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Passives.Name = "tabPage_Passives";
            this.tabPage_Passives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Passives.Size = new System.Drawing.Size(1034, 640);
            this.tabPage_Passives.TabIndex = 2;
            this.tabPage_Passives.Text = "Compétences Passives";
            this.tabPage_Passives.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Passives
            // 
            this.dataGridView_Passives.AllowUserToAddRows = false;
            this.dataGridView_Passives.AllowUserToDeleteRows = false;
            this.dataGridView_Passives.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Passives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Passives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinRariryPassives_Header,
            this.LevelPassives_Header,
            this.IconPassives_Header,
            this.NamePassives_Header,
            this.EffectPassives_Header});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Passives.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Passives.Location = new System.Drawing.Point(7, 7);
            this.dataGridView_Passives.Name = "dataGridView_Passives";
            this.dataGridView_Passives.ReadOnly = true;
            this.dataGridView_Passives.Size = new System.Drawing.Size(1019, 625);
            this.dataGridView_Passives.TabIndex = 0;
            // 
            // MinRariryPassives_Header
            // 
            this.MinRariryPassives_Header.HeaderText = "Min Rarity";
            this.MinRariryPassives_Header.Name = "MinRariryPassives_Header";
            this.MinRariryPassives_Header.ReadOnly = true;
            this.MinRariryPassives_Header.Width = 50;
            // 
            // LevelPassives_Header
            // 
            this.LevelPassives_Header.HeaderText = "Level";
            this.LevelPassives_Header.Name = "LevelPassives_Header";
            this.LevelPassives_Header.ReadOnly = true;
            this.LevelPassives_Header.Width = 60;
            // 
            // IconPassives_Header
            // 
            this.IconPassives_Header.HeaderText = "Icon";
            this.IconPassives_Header.Name = "IconPassives_Header";
            this.IconPassives_Header.ReadOnly = true;
            this.IconPassives_Header.Width = 72;
            // 
            // NamePassives_Header
            // 
            this.NamePassives_Header.HeaderText = "Name";
            this.NamePassives_Header.Name = "NamePassives_Header";
            this.NamePassives_Header.ReadOnly = true;
            this.NamePassives_Header.Width = 150;
            // 
            // EffectPassives_Header
            // 
            this.EffectPassives_Header.HeaderText = "Effect";
            this.EffectPassives_Header.Name = "EffectPassives_Header";
            this.EffectPassives_Header.ReadOnly = true;
            this.EffectPassives_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EffectPassives_Header.Width = 650;
            // 
            // UnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.tabControl_Unit);
            this.Controls.Add(this.pictureBox_UnitIdle);
            this.Controls.Add(this.label_UnitName);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UnitDescription";
            this.Text = "UnitDescriptionEr";
            this.tabControl_Unit.ResumeLayout(false);
            this.tabPage_UnitStats.ResumeLayout(false);
            this.tabPage_Abilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).EndInit();
            this.tabPage_Passives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UnitName;
        private System.Windows.Forms.PictureBox pictureBox_UnitIdle;
        private System.Windows.Forms.TabControl tabControl_Unit;
        private System.Windows.Forms.TabPage tabPage_UnitStats;
        private System.Windows.Forms.TabPage tabPage_Abilities;
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
        private System.Windows.Forms.TabPage tabPage_Passives;
        private System.Windows.Forms.DataGridView dataGridView_Passives;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRariryPassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelPassives_Header;
        private System.Windows.Forms.DataGridViewImageColumn IconPassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectPassives_Header;
    }
}