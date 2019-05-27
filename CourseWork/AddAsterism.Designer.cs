namespace CourseWork
{
    partial class AddAsterism
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.AsterName = new System.Windows.Forms.TextBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(23, 38);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(128, 33);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название:";
            // 
            // AsterName
            // 
            this.AsterName.Location = new System.Drawing.Point(338, 31);
            this.AsterName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AsterName.Name = "AsterName";
            this.AsterName.Size = new System.Drawing.Size(193, 40);
            this.AsterName.TabIndex = 1;
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(23, 91);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(283, 33);
            this.SquareLabel.TabIndex = 2;
            this.SquareLabel.Text = "Площадь, кв. градусов:";
            // 
            // Square
            // 
            this.Square.DecimalPlaces = 2;
            this.Square.Location = new System.Drawing.Point(338, 89);
            this.Square.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(193, 40);
            this.Square.TabIndex = 3;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(184, 167);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(193, 40);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // AddAsterism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 233);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.AsterName);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddAsterism";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAsterism";
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox AsterName;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.NumericUpDown Square;
        private System.Windows.Forms.Button Confirm;
    }
}