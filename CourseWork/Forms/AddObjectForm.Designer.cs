namespace CourseWork.Forms
{
    partial class AddObjectForm
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeName = new System.Windows.Forms.ComboBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(39, 46);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(69, 33);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Тип:";
            // 
            // TypeName
            // 
            this.TypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeName.FormattingEnabled = true;
            this.TypeName.Location = new System.Drawing.Point(210, 43);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(225, 39);
            this.TypeName.TabIndex = 4;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(160, 130);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(176, 45);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TypeName);
            this.Controls.Add(this.TypeLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeName;
        private System.Windows.Forms.Button Confirm;
    }
}