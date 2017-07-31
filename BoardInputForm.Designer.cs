namespace SimpleDrawer
{
    partial class BoardInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardInputForm));
            this.widthInputBox = new System.Windows.Forms.TextBox();
            this.heightInputBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.moveToOutputButton = new System.Windows.Forms.Button();
            this.jimmyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthInputBox
            // 
            this.widthInputBox.Location = new System.Drawing.Point(12, 60);
            this.widthInputBox.Name = "widthInputBox";
            this.widthInputBox.Size = new System.Drawing.Size(100, 20);
            this.widthInputBox.TabIndex = 0;
            // 
            // heightInputBox
            // 
            this.heightInputBox.Location = new System.Drawing.Point(172, 60);
            this.heightInputBox.Name = "heightInputBox";
            this.heightInputBox.Size = new System.Drawing.Size(100, 20);
            this.heightInputBox.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 44);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Genişlik";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(169, 44);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(46, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Uzunluk";
            // 
            // moveToOutputButton
            // 
            this.moveToOutputButton.Location = new System.Drawing.Point(172, 224);
            this.moveToOutputButton.Name = "moveToOutputButton";
            this.moveToOutputButton.Size = new System.Drawing.Size(100, 25);
            this.moveToOutputButton.TabIndex = 2;
            this.moveToOutputButton.Text = "Devam";
            this.moveToOutputButton.UseVisualStyleBackColor = true;
            this.moveToOutputButton.Click += new System.EventHandler(this.moveToOutputButton_Click);
            // 
            // jimmyLabel
            // 
            this.jimmyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jimmyLabel.AutoSize = true;
            this.jimmyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jimmyLabel.Location = new System.Drawing.Point(12, 239);
            this.jimmyLabel.Name = "jimmyLabel";
            this.jimmyLabel.Size = new System.Drawing.Size(91, 13);
            this.jimmyLabel.TabIndex = 4;
            this.jimmyLabel.Text = "Berke Bakkaloğlu";
            // 
            // BoardInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.jimmyLabel);
            this.Controls.Add(this.moveToOutputButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightInputBox);
            this.Controls.Add(this.widthInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "BoardInputForm";
            this.Text = "Çizim Kontrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthInputBox;
        private System.Windows.Forms.TextBox heightInputBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button moveToOutputButton;
        private System.Windows.Forms.Label jimmyLabel;
    }
}