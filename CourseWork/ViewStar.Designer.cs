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
            ((System.ComponentModel.ISupportInitialize)(this.StarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StarGrid
            // 
            this.StarGrid.AllowUserToAddRows = false;
            this.StarGrid.AllowUserToDeleteRows = false;
            this.StarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StarGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.StarGrid.Location = new System.Drawing.Point(0, 0);
            this.StarGrid.MultiSelect = false;
            this.StarGrid.Name = "StarGrid";
            this.StarGrid.ReadOnly = true;
            this.StarGrid.RowHeadersVisible = false;
            this.StarGrid.RowTemplate.Height = 24;
            this.StarGrid.Size = new System.Drawing.Size(851, 278);
            this.StarGrid.TabIndex = 0;
            // 
            // ViewStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 421);
            this.Controls.Add(this.StarGrid);
            this.Name = "ViewStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStar";
            ((System.ComponentModel.ISupportInitialize)(this.StarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StarGrid;
    }
}