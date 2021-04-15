namespace UIF
{
    partial class itemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemList));
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdToClipboard = new System.Windows.Forms.Button();
            this.ItemStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShakeTextBox = new System.Windows.Forms.TextBox();
            this.ShakeLabel = new System.Windows.Forms.Label();
            this.ItemHealthTextBox = new System.Windows.Forms.TextBox();
            this.ItemHealthLabel = new System.Windows.Forms.Label();
            this.EngineTextBox = new System.Windows.Forms.TextBox();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.RangeTextBox = new System.Windows.Forms.TextBox();
            this.ItemType2TextBox = new System.Windows.Forms.TextBox();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.ItemType2Label = new System.Windows.Forms.Label();
            this.StructureDamageTextBox = new System.Windows.Forms.TextBox();
            this.ItemTypeTextBox = new System.Windows.Forms.TextBox();
            this.BuildingsDamageLabel = new System.Windows.Forms.Label();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.PlayerDamageTextBox = new System.Windows.Forms.TextBox();
            this.DamageHeadTextBox = new System.Windows.Forms.TextBox();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.BodyDamageTextBox = new System.Windows.Forms.TextBox();
            this.ItemCapacityTextBox = new System.Windows.Forms.TextBox();
            this.ProtectionTextBox = new System.Windows.Forms.TextBox();
            this.BodyDamageLabel = new System.Windows.Forms.Label();
            this.HeadDamageLabel = new System.Windows.Forms.Label();
            this.ProtectionLabel = new System.Windows.Forms.Label();
            this.ItemCapacityLabel = new System.Windows.Forms.Label();
            this.SortDamagePlayersBtn = new System.Windows.Forms.Button();
            this.SortCapacityBtn = new System.Windows.Forms.Button();
            this.SortProtectionBtn = new System.Windows.Forms.Button();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.SortByShakeBtn = new System.Windows.Forms.Button();
            this.SortByBuildingHealthBtn = new System.Windows.Forms.Button();
            this.SortBarricadeCapacityBtn = new System.Windows.Forms.Button();
            this.SortVehicleHealthBtn = new System.Windows.Forms.Button();
            this.SortDamageBuildingsBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.InfoGroupBox.SuspendLayout();
            this.ItemStatsGroupBox.SuspendLayout();
            this.SortingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel.Location = new System.Drawing.Point(12, 11);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(177, 20);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Результаты поиска:";
            this.ResultsLabel.Click += new System.EventHandler(this.ResultsLabel_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 16;
            this.ResultsListBox.Location = new System.Drawing.Point(16, 36);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(221, 468);
            this.ResultsListBox.TabIndex = 6;
            this.ResultsListBox.TabStop = false;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.IdTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.IdLabel);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.IdToClipboard);
            this.InfoGroupBox.Location = new System.Drawing.Point(247, 36);
            this.InfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.InfoGroupBox.Size = new System.Drawing.Size(437, 114);
            this.InfoGroupBox.TabIndex = 5;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Инфо";
            this.InfoGroupBox.Enter += new System.EventHandler(this.InfoGroupBox_Enter);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(120, 48);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(307, 22);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(120, 22);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(307, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TabStop = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(8, 46);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(42, 25);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID: ";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(8, 20);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(110, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Название: ";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // IdToClipboard
            // 
            this.IdToClipboard.Location = new System.Drawing.Point(120, 80);
            this.IdToClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.IdToClipboard.Name = "IdToClipboard";
            this.IdToClipboard.Size = new System.Drawing.Size(308, 28);
            this.IdToClipboard.TabIndex = 4;
            this.IdToClipboard.TabStop = false;
            this.IdToClipboard.Text = "Скопировать ID в буфер обмена";
            this.IdToClipboard.UseVisualStyleBackColor = true;
            this.IdToClipboard.Click += new System.EventHandler(this.IdToClipboard_Click);
            // 
            // ItemStatsGroupBox
            // 
            this.ItemStatsGroupBox.Controls.Add(this.ShakeTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ShakeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemHealthTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemHealthLabel);
            this.ItemStatsGroupBox.Controls.Add(this.EngineTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.EngineLabel);
            this.ItemStatsGroupBox.Controls.Add(this.RangeTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemType2TextBox);
            this.ItemStatsGroupBox.Controls.Add(this.RangeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemType2Label);
            this.ItemStatsGroupBox.Controls.Add(this.StructureDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemTypeTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.BuildingsDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemTypeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.PlayerDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.DamageHeadTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.PlayerDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.BodyDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemCapacityTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ProtectionTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.BodyDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.HeadDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ProtectionLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemCapacityLabel);
            this.ItemStatsGroupBox.Location = new System.Drawing.Point(247, 158);
            this.ItemStatsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemStatsGroupBox.Name = "ItemStatsGroupBox";
            this.ItemStatsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ItemStatsGroupBox.Size = new System.Drawing.Size(437, 347);
            this.ItemStatsGroupBox.TabIndex = 4;
            this.ItemStatsGroupBox.TabStop = false;
            this.ItemStatsGroupBox.Text = "Item Stats";
            // 
            // ShakeTextBox
            // 
            this.ShakeTextBox.Location = new System.Drawing.Point(345, 293);
            this.ShakeTextBox.Name = "ShakeTextBox";
            this.ShakeTextBox.ReadOnly = true;
            this.ShakeTextBox.Size = new System.Drawing.Size(81, 22);
            this.ShakeTextBox.TabIndex = 22;
            this.ShakeTextBox.TabStop = false;
            this.ShakeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShakeLabel
            // 
            this.ShakeLabel.AutoSize = true;
            this.ShakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShakeLabel.Location = new System.Drawing.Point(8, 290);
            this.ShakeLabel.Name = "ShakeLabel";
            this.ShakeLabel.Size = new System.Drawing.Size(315, 25);
            this.ShakeLabel.TabIndex = 23;
            this.ShakeLabel.Text = "Множитель разброса на модуль";
            // 
            // ItemHealthTextBox
            // 
            this.ItemHealthTextBox.Location = new System.Drawing.Point(345, 268);
            this.ItemHealthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemHealthTextBox.Name = "ItemHealthTextBox";
            this.ItemHealthTextBox.ReadOnly = true;
            this.ItemHealthTextBox.Size = new System.Drawing.Size(81, 22);
            this.ItemHealthTextBox.TabIndex = 18;
            this.ItemHealthTextBox.TabStop = false;
            this.ItemHealthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemHealthLabel
            // 
            this.ItemHealthLabel.AutoSize = true;
            this.ItemHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemHealthLabel.Location = new System.Drawing.Point(8, 265);
            this.ItemHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemHealthLabel.Name = "ItemHealthLabel";
            this.ItemHealthLabel.Size = new System.Drawing.Size(263, 25);
            this.ItemHealthLabel.TabIndex = 19;
            this.ItemHealthLabel.Text = "Здоровье Баррикад/Машин";
            // 
            // EngineTextBox
            // 
            this.EngineTextBox.Location = new System.Drawing.Point(345, 244);
            this.EngineTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EngineTextBox.Name = "EngineTextBox";
            this.EngineTextBox.ReadOnly = true;
            this.EngineTextBox.Size = new System.Drawing.Size(81, 22);
            this.EngineTextBox.TabIndex = 20;
            this.EngineTextBox.TabStop = false;
            this.EngineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineLabel.Location = new System.Drawing.Point(8, 241);
            this.EngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(119, 25);
            this.EngineLabel.TabIndex = 21;
            this.EngineLabel.Text = "Двигатель:";
            // 
            // RangeTextBox
            // 
            this.RangeTextBox.Location = new System.Drawing.Point(345, 170);
            this.RangeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RangeTextBox.Name = "RangeTextBox";
            this.RangeTextBox.ReadOnly = true;
            this.RangeTextBox.Size = new System.Drawing.Size(81, 22);
            this.RangeTextBox.TabIndex = 0;
            this.RangeTextBox.TabStop = false;
            this.RangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemType2TextBox
            // 
            this.ItemType2TextBox.Location = new System.Drawing.Point(345, 219);
            this.ItemType2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemType2TextBox.Name = "ItemType2TextBox";
            this.ItemType2TextBox.ReadOnly = true;
            this.ItemType2TextBox.Size = new System.Drawing.Size(81, 22);
            this.ItemType2TextBox.TabIndex = 1;
            this.ItemType2TextBox.TabStop = false;
            this.ItemType2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLabel.Location = new System.Drawing.Point(8, 167);
            this.RangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(121, 25);
            this.RangeLabel.TabIndex = 2;
            this.RangeLabel.Text = "Дальность:";
            // 
            // ItemType2Label
            // 
            this.ItemType2Label.AutoSize = true;
            this.ItemType2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemType2Label.Location = new System.Drawing.Point(8, 217);
            this.ItemType2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemType2Label.Name = "ItemType2Label";
            this.ItemType2Label.Size = new System.Drawing.Size(168, 25);
            this.ItemType2Label.TabIndex = 3;
            this.ItemType2Label.Text = "Тип предмета 2:";
            this.ItemType2Label.Click += new System.EventHandler(this.ItemType2Label_Click);
            // 
            // StructureDamageTextBox
            // 
            this.StructureDamageTextBox.Location = new System.Drawing.Point(345, 145);
            this.StructureDamageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StructureDamageTextBox.Name = "StructureDamageTextBox";
            this.StructureDamageTextBox.ReadOnly = true;
            this.StructureDamageTextBox.Size = new System.Drawing.Size(81, 22);
            this.StructureDamageTextBox.TabIndex = 4;
            this.StructureDamageTextBox.TabStop = false;
            this.StructureDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemTypeTextBox
            // 
            this.ItemTypeTextBox.Location = new System.Drawing.Point(345, 194);
            this.ItemTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemTypeTextBox.Name = "ItemTypeTextBox";
            this.ItemTypeTextBox.ReadOnly = true;
            this.ItemTypeTextBox.Size = new System.Drawing.Size(81, 22);
            this.ItemTypeTextBox.TabIndex = 5;
            this.ItemTypeTextBox.TabStop = false;
            this.ItemTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuildingsDamageLabel
            // 
            this.BuildingsDamageLabel.AutoSize = true;
            this.BuildingsDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingsDamageLabel.Location = new System.Drawing.Point(8, 143);
            this.BuildingsDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuildingsDamageLabel.Name = "BuildingsDamageLabel";
            this.BuildingsDamageLabel.Size = new System.Drawing.Size(182, 25);
            this.BuildingsDamageLabel.TabIndex = 6;
            this.BuildingsDamageLabel.Text = "Урон постройкам:";
            this.BuildingsDamageLabel.Click += new System.EventHandler(this.BuildingsDamageLabel_Click);
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemTypeLabel.Location = new System.Drawing.Point(8, 192);
            this.ItemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(152, 25);
            this.ItemTypeLabel.TabIndex = 7;
            this.ItemTypeLabel.Text = "Тип предмета:";
            // 
            // PlayerDamageTextBox
            // 
            this.PlayerDamageTextBox.Location = new System.Drawing.Point(345, 121);
            this.PlayerDamageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerDamageTextBox.Name = "PlayerDamageTextBox";
            this.PlayerDamageTextBox.ReadOnly = true;
            this.PlayerDamageTextBox.Size = new System.Drawing.Size(81, 22);
            this.PlayerDamageTextBox.TabIndex = 8;
            this.PlayerDamageTextBox.TabStop = false;
            this.PlayerDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DamageHeadTextBox
            // 
            this.DamageHeadTextBox.Location = new System.Drawing.Point(345, 71);
            this.DamageHeadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DamageHeadTextBox.Name = "DamageHeadTextBox";
            this.DamageHeadTextBox.ReadOnly = true;
            this.DamageHeadTextBox.Size = new System.Drawing.Size(81, 22);
            this.DamageHeadTextBox.TabIndex = 9;
            this.DamageHeadTextBox.TabStop = false;
            this.DamageHeadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerDamageLabel.Location = new System.Drawing.Point(8, 118);
            this.PlayerDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(129, 25);
            this.PlayerDamageLabel.TabIndex = 10;
            this.PlayerDamageLabel.Text = "Урон игрока:";
            // 
            // BodyDamageTextBox
            // 
            this.BodyDamageTextBox.Location = new System.Drawing.Point(345, 96);
            this.BodyDamageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BodyDamageTextBox.Name = "BodyDamageTextBox";
            this.BodyDamageTextBox.ReadOnly = true;
            this.BodyDamageTextBox.Size = new System.Drawing.Size(81, 22);
            this.BodyDamageTextBox.TabIndex = 11;
            this.BodyDamageTextBox.TabStop = false;
            this.BodyDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemCapacityTextBox
            // 
            this.ItemCapacityTextBox.Location = new System.Drawing.Point(345, 22);
            this.ItemCapacityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCapacityTextBox.Name = "ItemCapacityTextBox";
            this.ItemCapacityTextBox.ReadOnly = true;
            this.ItemCapacityTextBox.Size = new System.Drawing.Size(81, 22);
            this.ItemCapacityTextBox.TabIndex = 12;
            this.ItemCapacityTextBox.TabStop = false;
            this.ItemCapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProtectionTextBox
            // 
            this.ProtectionTextBox.Location = new System.Drawing.Point(345, 47);
            this.ProtectionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProtectionTextBox.Name = "ProtectionTextBox";
            this.ProtectionTextBox.ReadOnly = true;
            this.ProtectionTextBox.Size = new System.Drawing.Size(81, 22);
            this.ProtectionTextBox.TabIndex = 13;
            this.ProtectionTextBox.TabStop = false;
            this.ProtectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BodyDamageLabel
            // 
            this.BodyDamageLabel.AutoSize = true;
            this.BodyDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyDamageLabel.Location = new System.Drawing.Point(8, 94);
            this.BodyDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BodyDamageLabel.Name = "BodyDamageLabel";
            this.BodyDamageLabel.Size = new System.Drawing.Size(128, 25);
            this.BodyDamageLabel.TabIndex = 14;
            this.BodyDamageLabel.Text = "Урон (Тело):";
            this.BodyDamageLabel.Click += new System.EventHandler(this.BodyDamageLabel_Click);
            // 
            // HeadDamageLabel
            // 
            this.HeadDamageLabel.AutoSize = true;
            this.HeadDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadDamageLabel.Location = new System.Drawing.Point(8, 69);
            this.HeadDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadDamageLabel.Name = "HeadDamageLabel";
            this.HeadDamageLabel.Size = new System.Drawing.Size(148, 25);
            this.HeadDamageLabel.TabIndex = 15;
            this.HeadDamageLabel.Text = "Урон (Голова):";
            // 
            // ProtectionLabel
            // 
            this.ProtectionLabel.AutoSize = true;
            this.ProtectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProtectionLabel.Location = new System.Drawing.Point(8, 44);
            this.ProtectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProtectionLabel.Name = "ProtectionLabel";
            this.ProtectionLabel.Size = new System.Drawing.Size(128, 25);
            this.ProtectionLabel.TabIndex = 16;
            this.ProtectionLabel.Text = "Защита (%):";
            // 
            // ItemCapacityLabel
            // 
            this.ItemCapacityLabel.AutoSize = true;
            this.ItemCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCapacityLabel.Location = new System.Drawing.Point(8, 20);
            this.ItemCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCapacityLabel.Name = "ItemCapacityLabel";
            this.ItemCapacityLabel.Size = new System.Drawing.Size(290, 25);
            this.ItemCapacityLabel.TabIndex = 17;
            this.ItemCapacityLabel.Text = "Баррикада / одежда ёмкость:";
            this.ItemCapacityLabel.Click += new System.EventHandler(this.ItemCapacityLabel_Click);
            // 
            // SortDamagePlayersBtn
            // 
            this.SortDamagePlayersBtn.Location = new System.Drawing.Point(13, 95);
            this.SortDamagePlayersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortDamagePlayersBtn.Name = "SortDamagePlayersBtn";
            this.SortDamagePlayersBtn.Size = new System.Drawing.Size(329, 28);
            this.SortDamagePlayersBtn.TabIndex = 4;
            this.SortDamagePlayersBtn.TabStop = false;
            this.SortDamagePlayersBtn.Text = "Сортировка по урону игрокам";
            this.SortDamagePlayersBtn.UseVisualStyleBackColor = true;
            this.SortDamagePlayersBtn.Click += new System.EventHandler(this.SortDamagePlayersBtn_Click);
            // 
            // SortCapacityBtn
            // 
            this.SortCapacityBtn.Location = new System.Drawing.Point(13, 23);
            this.SortCapacityBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortCapacityBtn.Name = "SortCapacityBtn";
            this.SortCapacityBtn.Size = new System.Drawing.Size(329, 28);
            this.SortCapacityBtn.TabIndex = 3;
            this.SortCapacityBtn.TabStop = false;
            this.SortCapacityBtn.Text = "Сортировка по вместимости одежды";
            this.SortCapacityBtn.UseVisualStyleBackColor = true;
            this.SortCapacityBtn.Click += new System.EventHandler(this.SortCapacityBtn_Click);
            // 
            // SortProtectionBtn
            // 
            this.SortProtectionBtn.Location = new System.Drawing.Point(13, 59);
            this.SortProtectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortProtectionBtn.Name = "SortProtectionBtn";
            this.SortProtectionBtn.Size = new System.Drawing.Size(329, 28);
            this.SortProtectionBtn.TabIndex = 2;
            this.SortProtectionBtn.TabStop = false;
            this.SortProtectionBtn.Text = "Сортировка по защите одежды";
            this.SortProtectionBtn.UseVisualStyleBackColor = true;
            this.SortProtectionBtn.Click += new System.EventHandler(this.SortProtectionBtn_Click);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Controls.Add(this.SortByShakeBtn);
            this.SortingGroupBox.Controls.Add(this.SortByBuildingHealthBtn);
            this.SortingGroupBox.Controls.Add(this.SortBarricadeCapacityBtn);
            this.SortingGroupBox.Controls.Add(this.MixBtn);
            this.SortingGroupBox.Controls.Add(this.SortVehicleHealthBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamageBuildingsBtn);
            this.SortingGroupBox.Controls.Add(this.SortProtectionBtn);
            this.SortingGroupBox.Controls.Add(this.SortCapacityBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamagePlayersBtn);
            this.SortingGroupBox.Location = new System.Drawing.Point(692, 158);
            this.SortingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SortingGroupBox.Size = new System.Drawing.Size(351, 347);
            this.SortingGroupBox.TabIndex = 0;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Сортировка";
            // 
            // SortByShakeBtn
            // 
            this.SortByShakeBtn.Location = new System.Drawing.Point(13, 201);
            this.SortByShakeBtn.Name = "SortByShakeBtn";
            this.SortByShakeBtn.Size = new System.Drawing.Size(329, 27);
            this.SortByShakeBtn.TabIndex = 8;
            this.SortByShakeBtn.TabStop = false;
            this.SortByShakeBtn.Text = "Сортировать по множителю разброса модулей";
            this.SortByShakeBtn.UseVisualStyleBackColor = true;
            this.SortByShakeBtn.Click += new System.EventHandler(this.SortByShakeBtn_Click);
            // 
            // SortByBuildingHealthBtn
            // 
            this.SortByBuildingHealthBtn.Location = new System.Drawing.Point(13, 270);
            this.SortByBuildingHealthBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortByBuildingHealthBtn.Name = "SortByBuildingHealthBtn";
            this.SortByBuildingHealthBtn.Size = new System.Drawing.Size(330, 28);
            this.SortByBuildingHealthBtn.TabIndex = 7;
            this.SortByBuildingHealthBtn.TabStop = false;
            this.SortByBuildingHealthBtn.Text = "Сортировать по HP постройки";
            this.SortByBuildingHealthBtn.UseVisualStyleBackColor = true;
            this.SortByBuildingHealthBtn.Click += new System.EventHandler(this.SortByBuildingHealthBtn_Click);
            // 
            // SortBarricadeCapacityBtn
            // 
            this.SortBarricadeCapacityBtn.Location = new System.Drawing.Point(13, 235);
            this.SortBarricadeCapacityBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortBarricadeCapacityBtn.Name = "SortBarricadeCapacityBtn";
            this.SortBarricadeCapacityBtn.Size = new System.Drawing.Size(329, 27);
            this.SortBarricadeCapacityBtn.TabIndex = 6;
            this.SortBarricadeCapacityBtn.TabStop = false;
            this.SortBarricadeCapacityBtn.Text = "Сортировать по вместительности баррикад";
            this.SortBarricadeCapacityBtn.UseVisualStyleBackColor = true;
            this.SortBarricadeCapacityBtn.Click += new System.EventHandler(this.SortBarricadeCapacityBtn_Click);
            // 
            // SortVehicleHealthBtn
            // 
            this.SortVehicleHealthBtn.Location = new System.Drawing.Point(13, 166);
            this.SortVehicleHealthBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortVehicleHealthBtn.Name = "SortVehicleHealthBtn";
            this.SortVehicleHealthBtn.Size = new System.Drawing.Size(329, 28);
            this.SortVehicleHealthBtn.TabIndex = 5;
            this.SortVehicleHealthBtn.TabStop = false;
            this.SortVehicleHealthBtn.Text = "Сортировка по HP автомобиля";
            this.SortVehicleHealthBtn.UseVisualStyleBackColor = true;
            this.SortVehicleHealthBtn.Click += new System.EventHandler(this.SortVehicleHealthBtn_Click);
            // 
            // SortDamageBuildingsBtn
            // 
            this.SortDamageBuildingsBtn.Location = new System.Drawing.Point(13, 130);
            this.SortDamageBuildingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortDamageBuildingsBtn.Name = "SortDamageBuildingsBtn";
            this.SortDamageBuildingsBtn.Size = new System.Drawing.Size(329, 28);
            this.SortDamageBuildingsBtn.TabIndex = 0;
            this.SortDamageBuildingsBtn.TabStop = false;
            this.SortDamageBuildingsBtn.Text = "Сортировка по урону постройкам";
            this.SortDamageBuildingsBtn.UseVisualStyleBackColor = true;
            this.SortDamageBuildingsBtn.Click += new System.EventHandler(this.SortDamageBuildingsBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Location = new System.Drawing.Point(14, 306);
            this.MixBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(329, 28);
            this.MixBtn.TabIndex = 1;
            this.MixBtn.TabStop = false;
            this.MixBtn.Text = "Перемешать";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // itemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 517);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.ItemStatsGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ResultsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "itemList";
            this.Text = "Список предметов";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ItemStatsGroupBox.ResumeLayout(false);
            this.ItemStatsGroupBox.PerformLayout();
            this.SortingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button IdToClipboard;
        private System.Windows.Forms.GroupBox ItemStatsGroupBox;
        private System.Windows.Forms.TextBox DamageHeadTextBox;
        private System.Windows.Forms.TextBox BodyDamageTextBox;
        private System.Windows.Forms.TextBox ItemCapacityTextBox;
        private System.Windows.Forms.TextBox ProtectionTextBox;
        private System.Windows.Forms.Label BodyDamageLabel;
        private System.Windows.Forms.Label HeadDamageLabel;
        private System.Windows.Forms.Label ProtectionLabel;
        private System.Windows.Forms.Label ItemCapacityLabel;
        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.TextBox ItemTypeTextBox;
        private System.Windows.Forms.TextBox ItemType2TextBox;
        private System.Windows.Forms.Label ItemType2Label;
        private System.Windows.Forms.Button SortDamagePlayersBtn;
        private System.Windows.Forms.Button SortCapacityBtn;
        private System.Windows.Forms.Button SortProtectionBtn;
        private System.Windows.Forms.GroupBox SortingGroupBox;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.TextBox RangeTextBox;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.TextBox StructureDamageTextBox;
        private System.Windows.Forms.Label BuildingsDamageLabel;
        private System.Windows.Forms.TextBox PlayerDamageTextBox;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Button SortDamageBuildingsBtn;
        private System.Windows.Forms.TextBox ItemHealthTextBox;
        private System.Windows.Forms.Label ItemHealthLabel;
        private System.Windows.Forms.TextBox EngineTextBox;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Button SortVehicleHealthBtn;
        private System.Windows.Forms.Button SortBarricadeCapacityBtn;
        private System.Windows.Forms.Button SortByBuildingHealthBtn;
        private System.Windows.Forms.Button SortByShakeBtn;
        private System.Windows.Forms.TextBox ShakeTextBox;
        private System.Windows.Forms.Label ShakeLabel;
    }
}