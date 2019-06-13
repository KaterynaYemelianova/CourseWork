namespace CourseWork.Forms
{
    partial class InputDataStars
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
            this.ObjName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.AsterismLabel = new System.Windows.Forms.Label();
            this.AsterismSelect = new System.Windows.Forms.ComboBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.MassLabel = new System.Windows.Forms.Label();
            this.TMaxLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorChoice = new System.Windows.Forms.ColorDialog();
            this.VisColor = new System.Windows.Forms.Button();
            this.TMinLabel = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.Mass = new System.Windows.Forms.NumericUpDown();
            this.TMin = new System.Windows.Forms.NumericUpDown();
            this.TMax = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.NumericUpDown();
            this.ObjectDiscoverer = new System.Windows.Forms.ComboBox();
            this.SubstanceCountLabel = new System.Windows.Forms.Label();
            this.SubstanceCount = new System.Windows.Forms.NumericUpDown();
            this.DateKnown = new System.Windows.Forms.CheckBox();
            this.MassKnown = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjName
            // 
            this.ObjName.Location = new System.Drawing.Point(400, 27);
            this.ObjName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ObjName.Name = "ObjName";
            this.ObjName.Size = new System.Drawing.Size(193, 40);
            this.ObjName.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 30);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(128, 33);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(23, 88);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(179, 33);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Год открытия:";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Location = new System.Drawing.Point(23, 138);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(241, 33);
            this.DeveloperLabel.TabIndex = 5;
            this.DeveloperLabel.Text = "Первооткрыватель:";
            // 
            // AsterismLabel
            // 
            this.AsterismLabel.AutoSize = true;
            this.AsterismLabel.Location = new System.Drawing.Point(23, 191);
            this.AsterismLabel.Name = "AsterismLabel";
            this.AsterismLabel.Size = new System.Drawing.Size(139, 33);
            this.AsterismLabel.TabIndex = 7;
            this.AsterismLabel.Text = "Созвездие:";
            // 
            // AsterismSelect
            // 
            this.AsterismSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsterismSelect.FormattingEnabled = true;
            this.AsterismSelect.Location = new System.Drawing.Point(400, 188);
            this.AsterismSelect.Name = "AsterismSelect";
            this.AsterismSelect.Size = new System.Drawing.Size(193, 39);
            this.AsterismSelect.TabIndex = 8;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(23, 244);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(240, 33);
            this.DistanceLabel.TabIndex = 9;
            this.DistanceLabel.Text = "Расстояние, св. лет:";
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(23, 298);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(197, 33);
            this.MassLabel.TabIndex = 11;
            this.MassLabel.Text = "Масса, солн. м.:";
            // 
            // TMaxLabel
            // 
            this.TMaxLabel.AutoSize = true;
            this.TMaxLabel.Location = new System.Drawing.Point(23, 406);
            this.TMaxLabel.Name = "TMaxLabel";
            this.TMaxLabel.Size = new System.Drawing.Size(370, 33);
            this.TMaxLabel.TabIndex = 15;
            this.TMaxLabel.Text = "Максимальная температура, К:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(23, 462);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(77, 33);
            this.ColorLabel.TabIndex = 17;
            this.ColorLabel.Text = "Цвет:";
            // 
            // VisColor
            // 
            this.VisColor.Location = new System.Drawing.Point(400, 457);
            this.VisColor.Name = "VisColor";
            this.VisColor.Size = new System.Drawing.Size(193, 40);
            this.VisColor.TabIndex = 18;
            this.VisColor.Text = "Выберите цвет";
            this.VisColor.UseVisualStyleBackColor = true;
            this.VisColor.Click += new System.EventHandler(this.VisColor_Click);
            // 
            // TMinLabel
            // 
            this.TMinLabel.AutoSize = true;
            this.TMinLabel.Location = new System.Drawing.Point(23, 352);
            this.TMinLabel.Name = "TMinLabel";
            this.TMinLabel.Size = new System.Drawing.Size(362, 33);
            this.TMinLabel.TabIndex = 19;
            this.TMinLabel.Text = "Минимальная температура, К:";
            // 
            // Distance
            // 
            this.Distance.DecimalPlaces = 6;
            this.Distance.Location = new System.Drawing.Point(400, 241);
            this.Distance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(193, 40);
            this.Distance.TabIndex = 20;
            // 
            // Mass
            // 
            this.Mass.DecimalPlaces = 4;
            this.Mass.Location = new System.Drawing.Point(400, 296);
            this.Mass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(193, 40);
            this.Mass.TabIndex = 21;
            // 
            // TMin
            // 
            this.TMin.DecimalPlaces = 2;
            this.TMin.Location = new System.Drawing.Point(400, 350);
            this.TMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TMin.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.TMin.Name = "TMin";
            this.TMin.Size = new System.Drawing.Size(193, 40);
            this.TMin.TabIndex = 22;
            // 
            // TMax
            // 
            this.TMax.DecimalPlaces = 2;
            this.TMax.Location = new System.Drawing.Point(400, 404);
            this.TMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TMax.Minimum = new decimal(new int[] {
            273,
            0,
            0,
            -2147483648});
            this.TMax.Name = "TMax";
            this.TMax.Size = new System.Drawing.Size(193, 40);
            this.TMax.TabIndex = 23;
            // 
            // Confirm
            // 
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm.Location = new System.Drawing.Point(207, 564);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(224, 40);
            this.Confirm.TabIndex = 24;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(400, 81);
            this.Date.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Date.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(193, 40);
            this.Date.TabIndex = 25;
            this.Date.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // ObjectDiscoverer
            // 
            this.ObjectDiscoverer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectDiscoverer.FormattingEnabled = true;
            this.ObjectDiscoverer.Location = new System.Drawing.Point(400, 135);
            this.ObjectDiscoverer.Name = "ObjectDiscoverer";
            this.ObjectDiscoverer.Size = new System.Drawing.Size(193, 39);
            this.ObjectDiscoverer.TabIndex = 26;
            // 
            // SubstanceCountLabel
            // 
            this.SubstanceCountLabel.AutoSize = true;
            this.SubstanceCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubstanceCountLabel.Location = new System.Drawing.Point(23, 520);
            this.SubstanceCountLabel.Name = "SubstanceCountLabel";
            this.SubstanceCountLabel.Size = new System.Drawing.Size(321, 33);
            this.SubstanceCountLabel.TabIndex = 27;
            this.SubstanceCountLabel.Text = " Кол-во веществ в составе:";
            // 
            // SubstanceCount
            // 
            this.SubstanceCount.Location = new System.Drawing.Point(400, 518);
            this.SubstanceCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SubstanceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SubstanceCount.Name = "SubstanceCount";
            this.SubstanceCount.Size = new System.Drawing.Size(193, 40);
            this.SubstanceCount.TabIndex = 28;
            this.SubstanceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SubstanceCount.ValueChanged += new System.EventHandler(this.SubstanceCount_ValueChanged);
            // 
            // DateKnown
            // 
            this.DateKnown.AutoSize = true;
            this.DateKnown.Location = new System.Drawing.Point(376, 91);
            this.DateKnown.Name = "DateKnown";
            this.DateKnown.Size = new System.Drawing.Size(18, 17);
            this.DateKnown.TabIndex = 29;
            this.DateKnown.UseVisualStyleBackColor = true;
            // 
            // MassKnown
            // 
            this.MassKnown.AutoSize = true;
            this.MassKnown.Location = new System.Drawing.Point(376, 306);
            this.MassKnown.Name = "MassKnown";
            this.MassKnown.Size = new System.Drawing.Size(18, 17);
            this.MassKnown.TabIndex = 30;
            this.MassKnown.UseVisualStyleBackColor = true;
            // 
            // InputDataStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 611);
            this.Controls.Add(this.MassKnown);
            this.Controls.Add(this.DateKnown);
            this.Controls.Add(this.SubstanceCount);
            this.Controls.Add(this.SubstanceCountLabel);
            this.Controls.Add(this.ObjectDiscoverer);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TMax);
            this.Controls.Add(this.TMin);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.TMinLabel);
            this.Controls.Add(this.VisColor);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.TMaxLabel);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.AsterismSelect);
            this.Controls.Add(this.AsterismLabel);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ObjName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(642, 658);
            this.Name = "InputDataStars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звезда";
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ObjName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.Label AsterismLabel;
        private System.Windows.Forms.ComboBox AsterismSelect;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label TMaxLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ColorDialog ColorChoice;
        private System.Windows.Forms.Button VisColor;
        private System.Windows.Forms.Label TMinLabel;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.NumericUpDown Mass;
        private System.Windows.Forms.NumericUpDown TMin;
        private System.Windows.Forms.NumericUpDown TMax;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.NumericUpDown Date;
        private System.Windows.Forms.ComboBox ObjectDiscoverer;
        private System.Windows.Forms.Label SubstanceCountLabel;
        private System.Windows.Forms.NumericUpDown SubstanceCount;
        private System.Windows.Forms.CheckBox DateKnown;
        private System.Windows.Forms.CheckBox MassKnown;
    }
}