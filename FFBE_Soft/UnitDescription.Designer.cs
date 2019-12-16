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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabPage_Passives = new System.Windows.Forms.TabPage();
            this.dataGridView_Passives = new System.Windows.Forms.DataGridView();
            this.MinRariryPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IconPassives_Header = new System.Windows.Forms.DataGridViewImageColumn();
            this.NamePassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectPassives_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Magic = new System.Windows.Forms.TabPage();
            this.tabPage_Limit = new System.Windows.Forms.TabPage();
            this.dataGridView_Limit = new System.Windows.Forms.DataGridView();
            this.RarityLB_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLB_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectLB_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HitsLB_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostLB_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_EquipmentExclusives = new System.Windows.Forms.TabPage();
            this.dataGridView_EquipmentExclusive = new System.Windows.Forms.DataGridView();
            this.IconEquipExclu_Header = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameEquipExclu_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEquipExclu_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectEquipExclu_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_RaceUnit = new System.Windows.Forms.Label();
            this.label_GenderUnit = new System.Windows.Forms.Label();
            this.pictureBox_UnitIdle = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_TMR = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_STMR = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Unit.SuspendLayout();
            this.tabPage_UnitStats.SuspendLayout();
            this.tabPage_Abilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).BeginInit();
            this.tabPage_Passives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passives)).BeginInit();
            this.tabPage_Limit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Limit)).BeginInit();
            this.tabPage_EquipmentExclusives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EquipmentExclusive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl_Unit.Controls.Add(this.tabPage_Abilities);
            this.tabControl_Unit.Controls.Add(this.tabPage_Passives);
            this.tabControl_Unit.Controls.Add(this.tabPage_Magic);
            this.tabControl_Unit.Controls.Add(this.tabPage_Limit);
            this.tabControl_Unit.Controls.Add(this.tabPage_EquipmentExclusives);
            this.tabControl_Unit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_Unit.Location = new System.Drawing.Point(298, 0);
            this.tabControl_Unit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl_Unit.Name = "tabControl_Unit";
            this.tabControl_Unit.SelectedIndex = 0;
            this.tabControl_Unit.Size = new System.Drawing.Size(1389, 820);
            this.tabControl_Unit.TabIndex = 2;
            // 
            // tabPage_UnitStats
            // 
            this.tabPage_UnitStats.Controls.Add(this.tableLayoutPanel_Resistance);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitMaxUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStatUp);
            this.tabPage_UnitStats.Controls.Add(this.listView_UnitStats);
            this.tabPage_UnitStats.Location = new System.Drawing.Point(4, 25);
            this.tabPage_UnitStats.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage_UnitStats.Name = "tabPage_UnitStats";
            this.tabPage_UnitStats.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage_UnitStats.Size = new System.Drawing.Size(1381, 791);
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
            this.tableLayoutPanel_Resistance.Location = new System.Drawing.Point(13, 464);
            this.tableLayoutPanel_Resistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_Resistance.Name = "tableLayoutPanel_Resistance";
            this.tableLayoutPanel_Resistance.RowCount = 6;
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Resistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel_Resistance.Size = new System.Drawing.Size(356, 160);
            this.tableLayoutPanel_Resistance.TabIndex = 3;
            // 
            // listView_UnitMaxUp
            // 
            this.listView_UnitMaxUp.HideSelection = false;
            this.listView_UnitMaxUp.Location = new System.Drawing.Point(13, 300);
            this.listView_UnitMaxUp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
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
            this.listView_UnitStatUp.Location = new System.Drawing.Point(13, 153);
            this.listView_UnitStatUp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
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
            this.listView_UnitStats.Location = new System.Drawing.Point(13, 11);
            this.listView_UnitStats.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.listView_UnitStats.Name = "listView_UnitStats";
            this.listView_UnitStats.Size = new System.Drawing.Size(667, 121);
            this.listView_UnitStats.TabIndex = 0;
            this.listView_UnitStats.UseCompatibleStateImageBehavior = false;
            this.listView_UnitStats.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_UnitStats_DrawColumnHeader);
            this.listView_UnitStats.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_UnitStats_DrawSubItem);
            // 
            // tabPage_Abilities
            // 
            this.tabPage_Abilities.Controls.Add(this.dataGridView_Ability);
            this.tabPage_Abilities.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Abilities.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage_Abilities.Name = "tabPage_Abilities";
            this.tabPage_Abilities.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage_Abilities.Size = new System.Drawing.Size(1381, 791);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Ability.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Ability.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_Ability.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Ability.Name = "dataGridView_Ability";
            this.dataGridView_Ability.ReadOnly = true;
            this.dataGridView_Ability.RowHeadersWidth = 30;
            this.dataGridView_Ability.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Ability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Ability.Size = new System.Drawing.Size(1364, 775);
            this.dataGridView_Ability.TabIndex = 0;
            // 
            // MinRariry_Header
            // 
            this.MinRariry_Header.HeaderText = "Min Rarity";
            this.MinRariry_Header.MinimumWidth = 8;
            this.MinRariry_Header.Name = "MinRariry_Header";
            this.MinRariry_Header.ReadOnly = true;
            this.MinRariry_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinRariry_Header.Width = 77;
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
            this.Icon_Header.MinimumWidth = 72;
            this.Icon_Header.Name = "Icon_Header";
            this.Icon_Header.ReadOnly = true;
            this.Icon_Header.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.Hits_Header.Width = 40;
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
            // tabPage_Passives
            // 
            this.tabPage_Passives.Controls.Add(this.dataGridView_Passives);
            this.tabPage_Passives.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Passives.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Passives.Name = "tabPage_Passives";
            this.tabPage_Passives.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Passives.Size = new System.Drawing.Size(1381, 791);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Passives.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Passives.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_Passives.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Passives.Name = "dataGridView_Passives";
            this.dataGridView_Passives.ReadOnly = true;
            this.dataGridView_Passives.RowHeadersWidth = 30;
            this.dataGridView_Passives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Passives.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Passives.Size = new System.Drawing.Size(1364, 775);
            this.dataGridView_Passives.TabIndex = 0;
            // 
            // MinRariryPassives_Header
            // 
            this.MinRariryPassives_Header.HeaderText = "Min Rarity";
            this.MinRariryPassives_Header.MinimumWidth = 8;
            this.MinRariryPassives_Header.Name = "MinRariryPassives_Header";
            this.MinRariryPassives_Header.ReadOnly = true;
            this.MinRariryPassives_Header.Width = 77;
            // 
            // LevelPassives_Header
            // 
            this.LevelPassives_Header.HeaderText = "Level";
            this.LevelPassives_Header.MinimumWidth = 6;
            this.LevelPassives_Header.Name = "LevelPassives_Header";
            this.LevelPassives_Header.ReadOnly = true;
            this.LevelPassives_Header.Width = 60;
            // 
            // IconPassives_Header
            // 
            this.IconPassives_Header.HeaderText = "Icon";
            this.IconPassives_Header.MinimumWidth = 6;
            this.IconPassives_Header.Name = "IconPassives_Header";
            this.IconPassives_Header.ReadOnly = true;
            this.IconPassives_Header.Width = 72;
            // 
            // NamePassives_Header
            // 
            this.NamePassives_Header.HeaderText = "Name";
            this.NamePassives_Header.MinimumWidth = 6;
            this.NamePassives_Header.Name = "NamePassives_Header";
            this.NamePassives_Header.ReadOnly = true;
            this.NamePassives_Header.Width = 150;
            // 
            // EffectPassives_Header
            // 
            this.EffectPassives_Header.HeaderText = "Effect";
            this.EffectPassives_Header.MinimumWidth = 6;
            this.EffectPassives_Header.Name = "EffectPassives_Header";
            this.EffectPassives_Header.ReadOnly = true;
            this.EffectPassives_Header.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EffectPassives_Header.Width = 630;
            // 
            // tabPage_Magic
            // 
            this.tabPage_Magic.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Magic.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Magic.Name = "tabPage_Magic";
            this.tabPage_Magic.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Magic.Size = new System.Drawing.Size(1381, 791);
            this.tabPage_Magic.TabIndex = 3;
            this.tabPage_Magic.Text = "Magies";
            this.tabPage_Magic.UseVisualStyleBackColor = true;
            // 
            // tabPage_Limit
            // 
            this.tabPage_Limit.Controls.Add(this.dataGridView_Limit);
            this.tabPage_Limit.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Limit.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Limit.Name = "tabPage_Limit";
            this.tabPage_Limit.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Limit.Size = new System.Drawing.Size(1381, 791);
            this.tabPage_Limit.TabIndex = 4;
            this.tabPage_Limit.Text = "Limit Burst";
            this.tabPage_Limit.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Limit
            // 
            this.dataGridView_Limit.AllowUserToAddRows = false;
            this.dataGridView_Limit.AllowUserToDeleteRows = false;
            this.dataGridView_Limit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Limit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Limit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RarityLB_Header,
            this.NameLB_Header,
            this.EffectLB_Header,
            this.HitsLB_Header,
            this.CostLB_Header});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Limit.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Limit.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_Limit.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Limit.Name = "dataGridView_Limit";
            this.dataGridView_Limit.ReadOnly = true;
            this.dataGridView_Limit.RowHeadersWidth = 30;
            this.dataGridView_Limit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Limit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Limit.Size = new System.Drawing.Size(1364, 775);
            this.dataGridView_Limit.TabIndex = 0;
            // 
            // RarityLB_Header
            // 
            this.RarityLB_Header.HeaderText = "Rarity";
            this.RarityLB_Header.MinimumWidth = 6;
            this.RarityLB_Header.Name = "RarityLB_Header";
            this.RarityLB_Header.ReadOnly = true;
            this.RarityLB_Header.Width = 50;
            // 
            // NameLB_Header
            // 
            this.NameLB_Header.HeaderText = "Name";
            this.NameLB_Header.MinimumWidth = 6;
            this.NameLB_Header.Name = "NameLB_Header";
            this.NameLB_Header.ReadOnly = true;
            this.NameLB_Header.Width = 150;
            // 
            // EffectLB_Header
            // 
            this.EffectLB_Header.HeaderText = "Effect";
            this.EffectLB_Header.MinimumWidth = 6;
            this.EffectLB_Header.Name = "EffectLB_Header";
            this.EffectLB_Header.ReadOnly = true;
            this.EffectLB_Header.Width = 680;
            // 
            // HitsLB_Header
            // 
            this.HitsLB_Header.HeaderText = "Hits";
            this.HitsLB_Header.MinimumWidth = 6;
            this.HitsLB_Header.Name = "HitsLB_Header";
            this.HitsLB_Header.ReadOnly = true;
            this.HitsLB_Header.Width = 50;
            // 
            // CostLB_Header
            // 
            this.CostLB_Header.HeaderText = "Cost";
            this.CostLB_Header.MinimumWidth = 6;
            this.CostLB_Header.Name = "CostLB_Header";
            this.CostLB_Header.ReadOnly = true;
            this.CostLB_Header.Width = 70;
            // 
            // tabPage_EquipmentExclusives
            // 
            this.tabPage_EquipmentExclusives.Controls.Add(this.dataGridView_EquipmentExclusive);
            this.tabPage_EquipmentExclusives.Location = new System.Drawing.Point(4, 25);
            this.tabPage_EquipmentExclusives.Name = "tabPage_EquipmentExclusives";
            this.tabPage_EquipmentExclusives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EquipmentExclusives.Size = new System.Drawing.Size(1381, 791);
            this.tabPage_EquipmentExclusives.TabIndex = 5;
            this.tabPage_EquipmentExclusives.Text = "Equipements Exclusifs";
            this.tabPage_EquipmentExclusives.UseVisualStyleBackColor = true;
            // 
            // dataGridView_EquipmentExclusive
            // 
            this.dataGridView_EquipmentExclusive.AllowUserToAddRows = false;
            this.dataGridView_EquipmentExclusive.AllowUserToDeleteRows = false;
            this.dataGridView_EquipmentExclusive.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_EquipmentExclusive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EquipmentExclusive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconEquipExclu_Header,
            this.NameEquipExclu_Header,
            this.TypeEquipExclu_Header,
            this.EffectEquipExclu_Header});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_EquipmentExclusive.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_EquipmentExclusive.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_EquipmentExclusive.Name = "dataGridView_EquipmentExclusive";
            this.dataGridView_EquipmentExclusive.ReadOnly = true;
            this.dataGridView_EquipmentExclusive.RowHeadersWidth = 30;
            this.dataGridView_EquipmentExclusive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_EquipmentExclusive.RowTemplate.Height = 24;
            this.dataGridView_EquipmentExclusive.Size = new System.Drawing.Size(1364, 775);
            this.dataGridView_EquipmentExclusive.TabIndex = 0;
            // 
            // IconEquipExclu_Header
            // 
            this.IconEquipExclu_Header.HeaderText = "Icon";
            this.IconEquipExclu_Header.MinimumWidth = 6;
            this.IconEquipExclu_Header.Name = "IconEquipExclu_Header";
            this.IconEquipExclu_Header.ReadOnly = true;
            this.IconEquipExclu_Header.Width = 72;
            // 
            // NameEquipExclu_Header
            // 
            this.NameEquipExclu_Header.HeaderText = "Name";
            this.NameEquipExclu_Header.MinimumWidth = 6;
            this.NameEquipExclu_Header.Name = "NameEquipExclu_Header";
            this.NameEquipExclu_Header.ReadOnly = true;
            this.NameEquipExclu_Header.Width = 150;
            // 
            // TypeEquipExclu_Header
            // 
            this.TypeEquipExclu_Header.HeaderText = "Type";
            this.TypeEquipExclu_Header.MinimumWidth = 6;
            this.TypeEquipExclu_Header.Name = "TypeEquipExclu_Header";
            this.TypeEquipExclu_Header.ReadOnly = true;
            this.TypeEquipExclu_Header.Width = 150;
            // 
            // EffectEquipExclu_Header
            // 
            this.EffectEquipExclu_Header.HeaderText = "Effect";
            this.EffectEquipExclu_Header.MinimumWidth = 6;
            this.EffectEquipExclu_Header.Name = "EffectEquipExclu_Header";
            this.EffectEquipExclu_Header.ReadOnly = true;
            this.EffectEquipExclu_Header.Width = 962;
            // 
            // label_RaceUnit
            // 
            this.label_RaceUnit.AutoSize = true;
            this.label_RaceUnit.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RaceUnit.Location = new System.Drawing.Point(19, 287);
            this.label_RaceUnit.Name = "label_RaceUnit";
            this.label_RaceUnit.Size = new System.Drawing.Size(79, 21);
            this.label_RaceUnit.TabIndex = 3;
            this.label_RaceUnit.Text = "Race : -- --";
            // 
            // label_GenderUnit
            // 
            this.label_GenderUnit.AutoSize = true;
            this.label_GenderUnit.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GenderUnit.Location = new System.Drawing.Point(19, 310);
            this.label_GenderUnit.Name = "label_GenderUnit";
            this.label_GenderUnit.Size = new System.Drawing.Size(95, 21);
            this.label_GenderUnit.TabIndex = 4;
            this.label_GenderUnit.Text = "Gender : -- --";
            // 
            // pictureBox_UnitIdle
            // 
            this.pictureBox_UnitIdle.Location = new System.Drawing.Point(23, 92);
            this.pictureBox_UnitIdle.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox_UnitIdle.Name = "pictureBox_UnitIdle";
            this.pictureBox_UnitIdle.Size = new System.Drawing.Size(196, 183);
            this.pictureBox_UnitIdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_UnitIdle.TabIndex = 1;
            this.pictureBox_UnitIdle.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel_TMR);
            this.groupBox1.Location = new System.Drawing.Point(19, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel_TMR
            // 
            this.tableLayoutPanel_TMR.ColumnCount = 1;
            this.tableLayoutPanel_TMR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TMR.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel_TMR.Name = "tableLayoutPanel_TMR";
            this.tableLayoutPanel_TMR.RowCount = 3;
            this.tableLayoutPanel_TMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel_TMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel_TMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel_TMR.Size = new System.Drawing.Size(208, 161);
            this.tableLayoutPanel_TMR.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel_STMR);
            this.groupBox2.Location = new System.Drawing.Point(19, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel_STMR
            // 
            this.tableLayoutPanel_STMR.ColumnCount = 1;
            this.tableLayoutPanel_STMR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_STMR.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel_STMR.Name = "tableLayoutPanel_STMR";
            this.tableLayoutPanel_STMR.RowCount = 3;
            this.tableLayoutPanel_STMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel_STMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel_STMR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel_STMR.Size = new System.Drawing.Size(208, 161);
            this.tableLayoutPanel_STMR.TabIndex = 0;
            // 
            // UnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_GenderUnit);
            this.Controls.Add(this.label_RaceUnit);
            this.Controls.Add(this.tabControl_Unit);
            this.Controls.Add(this.pictureBox_UnitIdle);
            this.Controls.Add(this.label_UnitName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.Name = "UnitDescription";
            this.Text = "Rien";
            this.tabControl_Unit.ResumeLayout(false);
            this.tabPage_UnitStats.ResumeLayout(false);
            this.tabPage_Abilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ability)).EndInit();
            this.tabPage_Passives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Passives)).EndInit();
            this.tabPage_Limit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Limit)).EndInit();
            this.tabPage_EquipmentExclusives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EquipmentExclusive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnitIdle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage_Passives;
        private System.Windows.Forms.DataGridView dataGridView_Passives;
        private System.Windows.Forms.TabPage tabPage_Magic;
        private System.Windows.Forms.TabPage tabPage_Limit;
        private System.Windows.Forms.DataGridView dataGridView_Limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RarityLB_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLB_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectLB_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn HitsLB_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostLB_Header;
        private System.Windows.Forms.Label label_RaceUnit;
        private System.Windows.Forms.Label label_GenderUnit;
        private System.Windows.Forms.TabPage tabPage_EquipmentExclusives;
        private System.Windows.Forms.DataGridView dataGridView_EquipmentExclusive;
        private System.Windows.Forms.DataGridViewImageColumn IconEquipExclu_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEquipExclu_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEquipExclu_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectEquipExclu_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRariryPassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelPassives_Header;
        private System.Windows.Forms.DataGridViewImageColumn IconPassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePassives_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectPassives_Header;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TMR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_STMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRariry_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level_Header;
        private System.Windows.Forms.DataGridViewImageColumn Icon_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effect_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hits_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Header;
    }
}