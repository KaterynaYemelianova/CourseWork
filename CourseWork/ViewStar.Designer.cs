namespace CourseWork
{
    partial class ViewStar
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
            this.StarGrid = new System.Windows.Forms.DataGridView();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.ChangeSelected = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MassMax = new System.Windows.Forms.NumericUpDown();
            this.MassMin = new System.Windows.Forms.NumericUpDown();
            this.SquareUpperLabel = new System.Windows.Forms.Label();
            this.SquareLowerLabel = new System.Windows.Forms.Label();
            this.MassFilterChecker = new System.Windows.Forms.CheckBox();
            this.TemperatureMax = new System.Windows.Forms.NumericUpDown();
            this.TemperatureMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TemperatureFilterChecker = new System.Windows.Forms.CheckBox();
            this.DistanceMax = new System.Windows.Forms.NumericUpDown();
            this.DistanceMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DistanceFilterChecker = new System.Windows.Forms.CheckBox();
            this.AsterismChoice = new System.Windows.Forms.ComboBox();
            this.DiscovererChoice = new System.Windows.Forms.ComboBox();
            this.AsterismChecker = new System.Windows.Forms.CheckBox();
            this.DiscovererCheker = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StarGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StarGrid
            // 
            this.StarGrid.AllowUserToAddRows = false;
            this.StarGrid.AllowUserToDeleteRows = false;
            this.StarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StarGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.StarGrid.Location = new System.Drawing.Point(0, 0);
            this.StarGrid.Margin = new System.Windows.Forms.Padding(4);
            this.StarGrid.MultiSelect = false;
            this.StarGrid.Name = "StarGrid";
            this.StarGrid.ReadOnly = true;
            this.StarGrid.RowHeadersVisible = false;
            this.StarGrid.RowTemplate.Height = 24;
            this.StarGrid.Size = new System.Drawing.Size(1152, 502);
            this.StarGrid.TabIndex = 0;
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(36, 674);
            this.DeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(272, 48);
            this.DeleteSelected.TabIndex = 1;
            this.DeleteSelected.Text = "Удалить выделенную запись";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // ChangeSelected
            // 
            this.ChangeSelected.Location = new System.Drawing.Point(36, 609);
            this.ChangeSelected.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSelected.Name = "ChangeSelected";
            this.ChangeSelected.Size = new System.Drawing.Size(272, 48);
            this.ChangeSelected.TabIndex = 13;
            this.ChangeSelected.Text = "Изменить выделенную запись";
            this.ChangeSelected.UseVisualStyleBackColor = true;
            this.ChangeSelected.Click += new System.EventHandler(this.ChangeSelected_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(140, 550);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 31);
            this.Search.TabIndex = 16;
            this.Search.Click += new System.EventHandler(this.FiltersUpdateHandler);
            this.Search.TextChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(32, 554);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(63, 24);
            this.SearchLabel.TabIndex = 15;
            this.SearchLabel.Text = "Поиск";
            // 
            // MassMax
            // 
            this.MassMax.DecimalPlaces = 2;
            this.MassMax.Location = new System.Drawing.Point(224, 66);
            this.MassMax.Margin = new System.Windows.Forms.Padding(4);
            this.MassMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MassMax.Name = "MassMax";
            this.MassMax.Size = new System.Drawing.Size(150, 31);
            this.MassMax.TabIndex = 21;
            this.MassMax.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // MassMin
            // 
            this.MassMin.DecimalPlaces = 2;
            this.MassMin.Location = new System.Drawing.Point(224, 27);
            this.MassMin.Margin = new System.Windows.Forms.Padding(4);
            this.MassMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MassMin.Name = "MassMin";
            this.MassMin.Size = new System.Drawing.Size(150, 31);
            this.MassMin.TabIndex = 20;
            this.MassMin.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SquareUpperLabel
            // 
            this.SquareUpperLabel.AutoSize = true;
            this.SquareUpperLabel.Location = new System.Drawing.Point(181, 73);
            this.SquareUpperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareUpperLabel.Name = "SquareUpperLabel";
            this.SquareUpperLabel.Size = new System.Drawing.Size(35, 24);
            this.SquareUpperLabel.TabIndex = 19;
            this.SquareUpperLabel.Text = "до:";
            // 
            // SquareLowerLabel
            // 
            this.SquareLowerLabel.AutoSize = true;
            this.SquareLowerLabel.Location = new System.Drawing.Point(183, 30);
            this.SquareLowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareLowerLabel.Name = "SquareLowerLabel";
            this.SquareLowerLabel.Size = new System.Drawing.Size(33, 24);
            this.SquareLowerLabel.TabIndex = 18;
            this.SquareLowerLabel.Text = "от:";
            // 
            // MassFilterChecker
            // 
            this.MassFilterChecker.AutoSize = true;
            this.MassFilterChecker.Location = new System.Drawing.Point(33, 50);
            this.MassFilterChecker.Margin = new System.Windows.Forms.Padding(4);
            this.MassFilterChecker.Name = "MassFilterChecker";
            this.MassFilterChecker.Size = new System.Drawing.Size(83, 28);
            this.MassFilterChecker.TabIndex = 17;
            this.MassFilterChecker.Text = "Масса";
            this.MassFilterChecker.UseVisualStyleBackColor = true;
            this.MassFilterChecker.CheckedChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // TemperatureMax
            // 
            this.TemperatureMax.DecimalPlaces = 2;
            this.TemperatureMax.Location = new System.Drawing.Point(224, 181);
            this.TemperatureMax.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TemperatureMax.Name = "TemperatureMax";
            this.TemperatureMax.Size = new System.Drawing.Size(150, 31);
            this.TemperatureMax.TabIndex = 26;
            this.TemperatureMax.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // TemperatureMin
            // 
            this.TemperatureMin.DecimalPlaces = 2;
            this.TemperatureMin.Location = new System.Drawing.Point(224, 142);
            this.TemperatureMin.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TemperatureMin.Name = "TemperatureMin";
            this.TemperatureMin.Size = new System.Drawing.Size(150, 31);
            this.TemperatureMin.TabIndex = 25;
            this.TemperatureMin.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "до:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "от:";
            // 
            // TemperatureFilterChecker
            // 
            this.TemperatureFilterChecker.AutoSize = true;
            this.TemperatureFilterChecker.Location = new System.Drawing.Point(33, 164);
            this.TemperatureFilterChecker.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureFilterChecker.Name = "TemperatureFilterChecker";
            this.TemperatureFilterChecker.Size = new System.Drawing.Size(140, 28);
            this.TemperatureFilterChecker.TabIndex = 22;
            this.TemperatureFilterChecker.Text = "Температура";
            this.TemperatureFilterChecker.UseVisualStyleBackColor = true;
            this.TemperatureFilterChecker.CheckedChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // DistanceMax
            // 
            this.DistanceMax.DecimalPlaces = 2;
            this.DistanceMax.Location = new System.Drawing.Point(639, 62);
            this.DistanceMax.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DistanceMax.Name = "DistanceMax";
            this.DistanceMax.Size = new System.Drawing.Size(150, 31);
            this.DistanceMax.TabIndex = 31;
            this.DistanceMax.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // DistanceMin
            // 
            this.DistanceMin.DecimalPlaces = 2;
            this.DistanceMin.Location = new System.Drawing.Point(639, 23);
            this.DistanceMin.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DistanceMin.Name = "DistanceMin";
            this.DistanceMin.Size = new System.Drawing.Size(150, 31);
            this.DistanceMin.TabIndex = 30;
            this.DistanceMin.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "до:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "от:";
            // 
            // DistanceFilterChecker
            // 
            this.DistanceFilterChecker.AutoSize = true;
            this.DistanceFilterChecker.Location = new System.Drawing.Point(434, 46);
            this.DistanceFilterChecker.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceFilterChecker.Name = "DistanceFilterChecker";
            this.DistanceFilterChecker.Size = new System.Drawing.Size(126, 28);
            this.DistanceFilterChecker.TabIndex = 27;
            this.DistanceFilterChecker.Text = "Расстояние";
            this.DistanceFilterChecker.UseVisualStyleBackColor = true;
            this.DistanceFilterChecker.CheckedChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // AsterismChoice
            // 
            this.AsterismChoice.FormattingEnabled = true;
            this.AsterismChoice.Location = new System.Drawing.Point(639, 124);
            this.AsterismChoice.Margin = new System.Windows.Forms.Padding(4);
            this.AsterismChoice.Name = "AsterismChoice";
            this.AsterismChoice.Size = new System.Drawing.Size(150, 32);
            this.AsterismChoice.TabIndex = 34;
            this.AsterismChoice.SelectedIndexChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // DiscovererChoice
            // 
            this.DiscovererChoice.FormattingEnabled = true;
            this.DiscovererChoice.Location = new System.Drawing.Point(639, 181);
            this.DiscovererChoice.Margin = new System.Windows.Forms.Padding(4);
            this.DiscovererChoice.Name = "DiscovererChoice";
            this.DiscovererChoice.Size = new System.Drawing.Size(150, 32);
            this.DiscovererChoice.TabIndex = 35;
            this.DiscovererChoice.SelectedIndexChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // AsterismChecker
            // 
            this.AsterismChecker.AutoSize = true;
            this.AsterismChecker.Location = new System.Drawing.Point(434, 126);
            this.AsterismChecker.Margin = new System.Windows.Forms.Padding(4);
            this.AsterismChecker.Name = "AsterismChecker";
            this.AsterismChecker.Size = new System.Drawing.Size(116, 28);
            this.AsterismChecker.TabIndex = 36;
            this.AsterismChecker.Text = "Созвездие";
            this.AsterismChecker.UseVisualStyleBackColor = true;
            // 
            // DiscovererCheker
            // 
            this.DiscovererCheker.AutoSize = true;
            this.DiscovererCheker.Location = new System.Drawing.Point(434, 181);
            this.DiscovererCheker.Margin = new System.Windows.Forms.Padding(4);
            this.DiscovererCheker.Name = "DiscovererCheker";
            this.DiscovererCheker.Size = new System.Drawing.Size(188, 28);
            this.DiscovererCheker.TabIndex = 37;
            this.DiscovererCheker.Text = "Первооткрыватель";
            this.DiscovererCheker.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AsterismChecker);
            this.groupBox1.Controls.Add(this.DistanceFilterChecker);
            this.groupBox1.Controls.Add(this.DiscovererCheker);
            this.groupBox1.Controls.Add(this.TemperatureMax);
            this.groupBox1.Controls.Add(this.MassFilterChecker);
            this.groupBox1.Controls.Add(this.TemperatureMin);
            this.groupBox1.Controls.Add(this.SquareLowerLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DiscovererChoice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SquareUpperLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AsterismChoice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MassMin);
            this.groupBox1.Controls.Add(this.TemperatureFilterChecker);
            this.groupBox1.Controls.Add(this.DistanceMax);
            this.groupBox1.Controls.Add(this.DistanceMin);
            this.groupBox1.Controls.Add(this.MassMax);
            this.groupBox1.Location = new System.Drawing.Point(339, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 221);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фильтрам";
            // 
            // ViewStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ChangeSelected);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.StarGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStar";
            ((System.ComponentModel.ISupportInitialize)(this.StarGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StarGrid;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button ChangeSelected;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.NumericUpDown MassMax;
        private System.Windows.Forms.NumericUpDown MassMin;
        private System.Windows.Forms.Label SquareUpperLabel;
        private System.Windows.Forms.Label SquareLowerLabel;
        private System.Windows.Forms.CheckBox MassFilterChecker;
        private System.Windows.Forms.NumericUpDown TemperatureMax;
        private System.Windows.Forms.NumericUpDown TemperatureMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TemperatureFilterChecker;
        private System.Windows.Forms.NumericUpDown DistanceMax;
        private System.Windows.Forms.NumericUpDown DistanceMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DistanceFilterChecker;
        private System.Windows.Forms.ComboBox AsterismChoice;
        private System.Windows.Forms.ComboBox DiscovererChoice;
        private System.Windows.Forms.CheckBox AsterismChecker;
        private System.Windows.Forms.CheckBox DiscovererCheker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}