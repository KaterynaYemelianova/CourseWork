namespace CourseWork.Forms
{
    partial class AddSubstance
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
            this.Confirm = new System.Windows.Forms.Button();
            this.FormulaLabel = new System.Windows.Forms.Label();
            this.SubName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Formula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(145, 164);
            this.Confirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(193, 40);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // FormulaLabel
            // 
            this.FormulaLabel.AutoSize = true;
            this.FormulaLabel.Location = new System.Drawing.Point(23, 96);
            this.FormulaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FormulaLabel.Name = "FormulaLabel";
            this.FormulaLabel.Size = new System.Drawing.Size(123, 33);
            this.FormulaLabel.TabIndex = 7;
            this.FormulaLabel.Text = "Формула:";
            // 
            // SubName
            // 
            this.SubName.Location = new System.Drawing.Point(260, 35);
            this.SubName.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.SubName.Name = "SubName";
            this.SubName.Size = new System.Drawing.Size(193, 40);
            this.SubName.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(23, 38);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(128, 33);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название:";
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(260, 93);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(193, 40);
            this.Formula.TabIndex = 10;
            // 
            // AddSubstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 230);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.FormulaLabel);
            this.Controls.Add(this.SubName);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddSubstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubstance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label FormulaLabel;
        private System.Windows.Forms.TextBox SubName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Formula;
    }
}