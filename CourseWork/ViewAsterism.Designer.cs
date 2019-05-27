namespace CourseWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SquareUpperLabel = new System.Windows.Forms.Label();
            this.SquareLowerLabel = new System.Windows.Forms.Label();
            this.SquareFilterChecker = new System.Windows.Forms.CheckBox();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.SquareLower = new System.Windows.Forms.NumericUpDown();
            this.SquareUpper = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AsterismGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareUpper)).BeginInit();
            this.SuspendLayout();
            // 
            // AsterismGrid
            // 
            this.AsterismGrid.AllowUserToAddRows = false;
            this.AsterismGrid.AllowUserToDeleteRows = false;
            this.AsterismGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsterismGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.AsterismGrid.Location = new System.Drawing.Point(0, 0);
            this.AsterismGrid.MultiSelect = false;
            this.AsterismGrid.Name = "AsterismGrid";
            this.AsterismGrid.ReadOnly = true;
            this.AsterismGrid.RowHeadersVisible = false;
            this.AsterismGrid.RowTemplate.Height = 24;
            this.AsterismGrid.Size = new System.Drawing.Size(874, 262);
            this.AsterismGrid.TabIndex = 0;
            this.AsterismGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsterismGrid_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SquareUpper);
            this.panel1.Controls.Add(this.SquareLower);
            this.panel1.Controls.Add(this.SquareUpperLabel);
            this.panel1.Controls.Add(this.SquareLowerLabel);
            this.panel1.Controls.Add(this.SquareFilterChecker);
            this.panel1.Controls.Add(this.DeleteSelected);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 100);
            this.panel1.TabIndex = 1;
            // 
            // SquareUpperLabel
            // 
            this.SquareUpperLabel.AutoSize = true;
            this.SquareUpperLabel.Location = new System.Drawing.Point(108, 52);
            this.SquareUpperLabel.Name = "SquareUpperLabel";
            this.SquareUpperLabel.Size = new System.Drawing.Size(28, 17);
            this.SquareUpperLabel.TabIndex = 8;
            this.SquareUpperLabel.Text = "до:";
            // 
            // SquareLowerLabel
            // 
            this.SquareLowerLabel.AutoSize = true;
            this.SquareLowerLabel.Location = new System.Drawing.Point(108, 13);
            this.SquareLowerLabel.Name = "SquareLowerLabel";
            this.SquareLowerLabel.Size = new System.Drawing.Size(27, 17);
            this.SquareLowerLabel.TabIndex = 7;
            this.SquareLowerLabel.Text = "от:";
            // 
            // SquareFilterChecker
            // 
            this.SquareFilterChecker.AutoSize = true;
            this.SquareFilterChecker.Location = new System.Drawing.Point(11, 31);
            this.SquareFilterChecker.Name = "SquareFilterChecker";
            this.SquareFilterChecker.Size = new System.Drawing.Size(90, 21);
            this.SquareFilterChecker.TabIndex = 6;
            this.SquareFilterChecker.Text = "Площадь";
            this.SquareFilterChecker.UseVisualStyleBackColor = true;
            this.SquareFilterChecker.CheckedChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(684, 35);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(178, 53);
            this.DeleteSelected.TabIndex = 5;
            this.DeleteSelected.Text = "Удалить выделенную запись";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            // 
            // SquareLower
            // 
            this.SquareLower.DecimalPlaces = 2;
            this.SquareLower.Location = new System.Drawing.Point(155, 13);
            this.SquareLower.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SquareLower.Name = "SquareLower";
            this.SquareLower.Size = new System.Drawing.Size(120, 22);
            this.SquareLower.TabIndex = 9;
            this.SquareLower.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SquareUpper
            // 
            this.SquareUpper.DecimalPlaces = 2;
            this.SquareUpper.Location = new System.Drawing.Point(155, 52);
            this.SquareUpper.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SquareUpper.Name = "SquareUpper";
            this.SquareUpper.Size = new System.Drawing.Size(120, 22);
            this.SquareUpper.TabIndex = 10;
            this.SquareUpper.ValueChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // ViewAsterism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AsterismGrid);
            this.Name = "ViewAsterism";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAsterism";
            ((System.ComponentModel.ISupportInitialize)(this.AsterismGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareUpper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AsterismGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown SquareUpper;
        private System.Windows.Forms.NumericUpDown SquareLower;
        private System.Windows.Forms.Label SquareUpperLabel;
        private System.Windows.Forms.Label SquareLowerLabel;
        private System.Windows.Forms.CheckBox SquareFilterChecker;
        private System.Windows.Forms.Button DeleteSelected;
    }
}