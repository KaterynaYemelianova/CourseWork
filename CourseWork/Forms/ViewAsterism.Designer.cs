namespace CourseWork.Forms
{
    partial class ViewAsterism
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
            this.AsterismGrid = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ChangeSelected = new System.Windows.Forms.Button();
            this.SquareMax = new System.Windows.Forms.NumericUpDown();
            this.SquareMin = new System.Windows.Forms.NumericUpDown();
            this.SquareUpperLabel = new System.Windows.Forms.Label();
            this.SquareLowerLabel = new System.Windows.Forms.Label();
            this.SquareFilterChecker = new System.Windows.Forms.CheckBox();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AsterismGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsterismGrid
            // 
            this.AsterismGrid.AllowUserToAddRows = false;
            this.AsterismGrid.AllowUserToDeleteRows = false;
            this.AsterismGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsterismGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.AsterismGrid.Location = new System.Drawing.Point(0, 0);
            this.AsterismGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AsterismGrid.MultiSelect = false;
            this.AsterismGrid.Name = "AsterismGrid";
            this.AsterismGrid.ReadOnly = true;
            this.AsterismGrid.RowHeadersVisible = false;
            this.AsterismGrid.RowTemplate.Height = 24;
            this.AsterismGrid.Size = new System.Drawing.Size(1031, 393);
            this.AsterismGrid.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(172, 454);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 31);
            this.Search.TabIndex = 18;
            this.Search.TextChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 458);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(174, 24);
            this.SearchLabel.TabIndex = 17;
            this.SearchLabel.Text = "Поиск по названию";
            // 
            // ChangeSelected
            // 
            this.ChangeSelected.Location = new System.Drawing.Point(746, 476);
            this.ChangeSelected.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSelected.Name = "ChangeSelected";
            this.ChangeSelected.Size = new System.Drawing.Size(272, 48);
            this.ChangeSelected.TabIndex = 11;
            this.ChangeSelected.Text = "Изменить выделенную запись";
            this.ChangeSelected.UseVisualStyleBackColor = true;
            this.ChangeSelected.Click += new System.EventHandler(this.ChangeSelected_Click);
            // 
            // SquareMax
            // 
            this.SquareMax.DecimalPlaces = 2;
            this.SquareMax.Location = new System.Drawing.Point(198, 84);
            this.SquareMax.Margin = new System.Windows.Forms.Padding(4);
            this.SquareMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SquareMax.Name = "SquareMax";
            this.SquareMax.Size = new System.Drawing.Size(150, 31);
            this.SquareMax.TabIndex = 10;
            this.SquareMax.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SquareMin
            // 
            this.SquareMin.DecimalPlaces = 2;
            this.SquareMin.Location = new System.Drawing.Point(198, 29);
            this.SquareMin.Margin = new System.Windows.Forms.Padding(4);
            this.SquareMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SquareMin.Name = "SquareMin";
            this.SquareMin.Size = new System.Drawing.Size(150, 31);
            this.SquareMin.TabIndex = 9;
            this.SquareMin.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SquareUpperLabel
            // 
            this.SquareUpperLabel.AutoSize = true;
            this.SquareUpperLabel.Location = new System.Drawing.Point(146, 87);
            this.SquareUpperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareUpperLabel.Name = "SquareUpperLabel";
            this.SquareUpperLabel.Size = new System.Drawing.Size(35, 24);
            this.SquareUpperLabel.TabIndex = 8;
            this.SquareUpperLabel.Text = "до:";
            // 
            // SquareLowerLabel
            // 
            this.SquareLowerLabel.AutoSize = true;
            this.SquareLowerLabel.Location = new System.Drawing.Point(146, 29);
            this.SquareLowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareLowerLabel.Name = "SquareLowerLabel";
            this.SquareLowerLabel.Size = new System.Drawing.Size(33, 24);
            this.SquareLowerLabel.TabIndex = 7;
            this.SquareLowerLabel.Text = "от:";
            // 
            // SquareFilterChecker
            // 
            this.SquareFilterChecker.AutoSize = true;
            this.SquareFilterChecker.Location = new System.Drawing.Point(28, 53);
            this.SquareFilterChecker.Margin = new System.Windows.Forms.Padding(4);
            this.SquareFilterChecker.Name = "SquareFilterChecker";
            this.SquareFilterChecker.Size = new System.Drawing.Size(108, 28);
            this.SquareFilterChecker.TabIndex = 6;
            this.SquareFilterChecker.Text = "Площадь";
            this.SquareFilterChecker.UseVisualStyleBackColor = true;
            this.SquareFilterChecker.CheckedChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(746, 409);
            this.DeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(272, 48);
            this.DeleteSelected.TabIndex = 5;
            this.DeleteSelected.Text = "Удалить выделенную запись";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SquareMax);
            this.groupBox1.Controls.Add(this.SquareUpperLabel);
            this.groupBox1.Controls.Add(this.SquareMin);
            this.groupBox1.Controls.Add(this.SquareLowerLabel);
            this.groupBox1.Controls.Add(this.SquareFilterChecker);
            this.groupBox1.Location = new System.Drawing.Point(332, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 122);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фильтрам";
            // 
            // ViewAsterism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeSelected);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.AsterismGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAsterism";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все созвездия";
            ((System.ComponentModel.ISupportInitialize)(this.AsterismGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AsterismGrid;
        private System.Windows.Forms.NumericUpDown SquareMax;
        private System.Windows.Forms.NumericUpDown SquareMin;
        private System.Windows.Forms.Label SquareUpperLabel;
        private System.Windows.Forms.Label SquareLowerLabel;
        private System.Windows.Forms.CheckBox SquareFilterChecker;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button ChangeSelected;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}