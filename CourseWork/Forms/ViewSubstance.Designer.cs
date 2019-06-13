namespace CourseWork.Forms
{
    partial class ViewSubstance
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
            this.SubstanceGrid = new System.Windows.Forms.DataGridView();
            this.ChangeSelected = new System.Windows.Forms.Button();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SubstanceGrid
            // 
            this.SubstanceGrid.AllowUserToAddRows = false;
            this.SubstanceGrid.AllowUserToDeleteRows = false;
            this.SubstanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubstanceGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubstanceGrid.Location = new System.Drawing.Point(0, 0);
            this.SubstanceGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SubstanceGrid.MultiSelect = false;
            this.SubstanceGrid.Name = "SubstanceGrid";
            this.SubstanceGrid.ReadOnly = true;
            this.SubstanceGrid.RowHeadersVisible = false;
            this.SubstanceGrid.RowTemplate.Height = 24;
            this.SubstanceGrid.Size = new System.Drawing.Size(610, 427);
            this.SubstanceGrid.TabIndex = 0;
            // 
            // ChangeSelected
            // 
            this.ChangeSelected.Location = new System.Drawing.Point(325, 435);
            this.ChangeSelected.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSelected.Name = "ChangeSelected";
            this.ChangeSelected.Size = new System.Drawing.Size(272, 48);
            this.ChangeSelected.TabIndex = 15;
            this.ChangeSelected.Text = "Изменить выделенную запись";
            this.ChangeSelected.UseVisualStyleBackColor = true;
            this.ChangeSelected.Click += new System.EventHandler(this.ChangeSelected_Click);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(325, 491);
            this.DeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(272, 48);
            this.DeleteSelected.TabIndex = 14;
            this.DeleteSelected.Text = "Удалить выделенную запись";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(84, 469);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 31);
            this.Search.TabIndex = 18;
            this.Search.TextChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 472);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(63, 24);
            this.SearchLabel.TabIndex = 17;
            this.SearchLabel.Text = "Поиск";
            // 
            // ViewSubstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 552);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ChangeSelected);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.SubstanceGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewSubstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все вещества";
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubstanceGrid;
        private System.Windows.Forms.Button ChangeSelected;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label SearchLabel;
    }
}