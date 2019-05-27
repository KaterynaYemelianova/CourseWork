namespace CourseWork
{
    partial class MainMenu
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
            this.AddObject = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddObject
            // 
            this.AddObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddObject.Location = new System.Drawing.Point(14, 16);
            this.AddObject.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(316, 152);
            this.AddObject.TabIndex = 0;
            this.AddObject.Text = "Добавить объект";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // View
            // 
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View.Location = new System.Drawing.Point(352, 16);
            this.View.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(316, 152);
            this.View.TabIndex = 2;
            this.View.Text = "Просмотр";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 186);
            this.Controls.Add(this.View);
            this.Controls.Add(this.AddObject);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 233);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomer Directory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button View;
    }
}

