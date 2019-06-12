namespace CourseWork.Forms
{
    partial class ViewDiscoverer
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
            this.DiscovererGrid = new System.Windows.Forms.DataGridView();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.ChangeSelected = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiscovererGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscovererGrid
            // 
            this.DiscovererGrid.AllowUserToAddRows = false;
            this.DiscovererGrid.AllowUserToDeleteRows = false;
            this.DiscovererGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscovererGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscovererGrid.Location = new System.Drawing.Point(0, 0);
            this.DiscovererGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DiscovererGrid.MultiSelect = false;
            this.DiscovererGrid.Name = "DiscovererGrid";
            this.DiscovererGrid.ReadOnly = true;
            this.DiscovererGrid.RowHeadersVisible = false;
            this.DiscovererGrid.RowTemplate.Height = 24;
            this.DiscovererGrid.Size = new System.Drawing.Size(610, 427);
            this.DiscovererGrid.TabIndex = 0;
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(325, 491);
            this.DeleteSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(272, 48);
            this.DeleteSelected.TabIndex = 6;
            this.DeleteSelected.Text = "Удалить выделенную запись";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // ChangeSelected
            // 
            this.ChangeSelected.Location = new System.Drawing.Point(325, 435);
            this.ChangeSelected.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSelected.Name = "ChangeSelected";
            this.ChangeSelected.Size = new System.Drawing.Size(272, 48);
            this.ChangeSelected.TabIndex = 12;
            this.ChangeSelected.Text = "Изменить выделенную запись";
            this.ChangeSelected.UseVisualStyleBackColor = true;
            this.ChangeSelected.Click += new System.EventHandler(this.ChangeSelected_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 472);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(63, 24);
            this.SearchLabel.TabIndex = 13;
            this.SearchLabel.Text = "Поиск";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(84, 469);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 31);
            this.Search.TabIndex = 14;
            this.Search.TextChanged += new System.EventHandler(this.FiltersUpdateHandler);
            // 
            // ViewDiscoverer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 552);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ChangeSelected);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.DiscovererGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewDiscoverer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDiscoverer";
            ((System.ComponentModel.ISupportInitialize)(this.DiscovererGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DiscovererGrid;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button ChangeSelected;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox Search;
    }
}