namespace SimpleDrawer
{
    partial class OutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputForm));
            this.testButton = new System.Windows.Forms.Button();
            this.addHoleButton = new System.Windows.Forms.Button();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBoardButton = new System.Windows.Forms.Button();
            this.minimumSpaceLabel = new System.Windows.Forms.Label();
            this.minimumSpaceBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.massInputBox = new System.Windows.Forms.TextBox();
            this.massInputLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.xEscapeBox = new System.Windows.Forms.TextBox();
            this.xEscapeLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.yEscapeBox = new System.Windows.Forms.TextBox();
            this.yEscapeLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.progressLabel = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testButton.Location = new System.Drawing.Point(0, 90);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(119, 33);
            this.testButton.TabIndex = 8;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // addHoleButton
            // 
            this.addHoleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addHoleButton.Location = new System.Drawing.Point(0, 355);
            this.addHoleButton.Name = "addHoleButton";
            this.addHoleButton.Size = new System.Drawing.Size(119, 23);
            this.addHoleButton.TabIndex = 4;
            this.addHoleButton.Text = "Ekle";
            this.addHoleButton.UseVisualStyleBackColor = true;
            this.addHoleButton.Click += new System.EventHandler(this.addHoleButton_Click);
            // 
            // radiusBox
            // 
            this.radiusBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.radiusBox.Location = new System.Drawing.Point(0, 13);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(113, 20);
            this.radiusBox.TabIndex = 2;
            this.radiusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radiusLabel
            // 
            this.radiusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radiusLabel.Location = new System.Drawing.Point(0, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(113, 13);
            this.radiusLabel.TabIndex = 4;
            this.radiusLabel.Text = "Çap";
            this.radiusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.71519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.28481F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlsPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 675);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.controlsPanel.Controls.Add(this.tableLayoutPanel2);
            this.controlsPanel.Controls.Add(this.progressLabel);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(1136, 3);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(125, 675);
            this.controlsPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(125, 675);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newBoardButton);
            this.panel1.Controls.Add(this.minimumSpaceLabel);
            this.panel1.Controls.Add(this.minimumSpaceBox);
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 123);
            this.panel1.TabIndex = 0;
            // 
            // newBoardButton
            // 
            this.newBoardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newBoardButton.Location = new System.Drawing.Point(0, 0);
            this.newBoardButton.Name = "newBoardButton";
            this.newBoardButton.Size = new System.Drawing.Size(119, 33);
            this.newBoardButton.TabIndex = 6;
            this.newBoardButton.Text = "Yeni Kart";
            this.newBoardButton.UseVisualStyleBackColor = true;
            this.newBoardButton.Click += new System.EventHandler(this.newBoardButton_Click);
            // 
            // minimumSpaceLabel
            // 
            this.minimumSpaceLabel.AutoEllipsis = true;
            this.minimumSpaceLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minimumSpaceLabel.Location = new System.Drawing.Point(0, 44);
            this.minimumSpaceLabel.Name = "minimumSpaceLabel";
            this.minimumSpaceLabel.Size = new System.Drawing.Size(119, 26);
            this.minimumSpaceLabel.TabIndex = 15;
            this.minimumSpaceLabel.Text = "Delikler Arası Minimum Boşluk";
            this.minimumSpaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimumSpaceBox
            // 
            this.minimumSpaceBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.minimumSpaceBox.Location = new System.Drawing.Point(0, 70);
            this.minimumSpaceBox.Name = "minimumSpaceBox";
            this.minimumSpaceBox.Size = new System.Drawing.Size(119, 20);
            this.minimumSpaceBox.TabIndex = 7;
            this.minimumSpaceBox.Text = "1.04";
            this.minimumSpaceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.zoomLabel);
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.zoomTrackBar);
            this.panel3.Controls.Add(this.addHoleButton);
            this.panel3.Controls.Add(this.massInputBox);
            this.panel3.Controls.Add(this.massInputLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 449);
            this.panel3.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearButton.Location = new System.Drawing.Point(0, 378);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.AutoSize = false;
            this.zoomTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zoomTrackBar.Location = new System.Drawing.Point(0, 425);
            this.zoomTrackBar.Maximum = 5000000;
            this.zoomTrackBar.Minimum = 1000000;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(119, 24);
            this.zoomTrackBar.TabIndex = 16;
            this.zoomTrackBar.TabStop = false;
            this.zoomTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomTrackBar.Value = 1000000;
            this.zoomTrackBar.Scroll += new System.EventHandler(this.zoomTrackBar_Scroll);
            // 
            // massInputBox
            // 
            this.massInputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.massInputBox.Location = new System.Drawing.Point(0, 13);
            this.massInputBox.Multiline = true;
            this.massInputBox.Name = "massInputBox";
            this.massInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.massInputBox.Size = new System.Drawing.Size(119, 342);
            this.massInputBox.TabIndex = 3;
            // 
            // massInputLabel
            // 
            this.massInputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.massInputLabel.Location = new System.Drawing.Point(0, 0);
            this.massInputLabel.Name = "massInputLabel";
            this.massInputLabel.Size = new System.Drawing.Size(119, 13);
            this.massInputLabel.TabIndex = 8;
            this.massInputLabel.Text = "Koordinatlar";
            this.massInputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.50877F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.49123F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(119, 85);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(113, 39);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.xEscapeBox);
            this.panel4.Controls.Add(this.xEscapeLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 33);
            this.panel4.TabIndex = 0;
            // 
            // xEscapeBox
            // 
            this.xEscapeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.xEscapeBox.Location = new System.Drawing.Point(0, 13);
            this.xEscapeBox.Name = "xEscapeBox";
            this.xEscapeBox.Size = new System.Drawing.Size(50, 20);
            this.xEscapeBox.TabIndex = 0;
            this.xEscapeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xEscapeLabel
            // 
            this.xEscapeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.xEscapeLabel.Location = new System.Drawing.Point(0, 0);
            this.xEscapeLabel.Name = "xEscapeLabel";
            this.xEscapeLabel.Size = new System.Drawing.Size(50, 13);
            this.xEscapeLabel.TabIndex = 12;
            this.xEscapeLabel.Text = "X Kaçma";
            this.xEscapeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.yEscapeBox);
            this.panel5.Controls.Add(this.yEscapeLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(59, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(51, 33);
            this.panel5.TabIndex = 1;
            // 
            // yEscapeBox
            // 
            this.yEscapeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.yEscapeBox.Location = new System.Drawing.Point(0, 13);
            this.yEscapeBox.Name = "yEscapeBox";
            this.yEscapeBox.Size = new System.Drawing.Size(51, 20);
            this.yEscapeBox.TabIndex = 1;
            this.yEscapeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yEscapeLabel
            // 
            this.yEscapeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.yEscapeLabel.Location = new System.Drawing.Point(0, 0);
            this.yEscapeLabel.Name = "yEscapeLabel";
            this.yEscapeLabel.Size = new System.Drawing.Size(51, 13);
            this.yEscapeLabel.TabIndex = 13;
            this.yEscapeLabel.Text = "Y Kaçma";
            this.yEscapeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radiusBox);
            this.panel6.Controls.Add(this.radiusLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(113, 34);
            this.panel6.TabIndex = 1;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressLabel.Location = new System.Drawing.Point(56, 593);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(48, 13);
            this.progressLabel.TabIndex = 18;
            this.progressLabel.Text = "Test Bitti";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zoomLabel.Location = new System.Drawing.Point(0, 412);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(34, 13);
            this.zoomLabel.TabIndex = 17;
            this.zoomLabel.Text = "Zoom";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleDrawer.Properties.Resources.vestel;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OutputForm";
            this.Text = "Çizim Kontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutputForm_FormClosing);
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button addHoleButton;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox massInputBox;
        private System.Windows.Forms.Label massInputLabel;
        private System.Windows.Forms.Label yEscapeLabel;
        private System.Windows.Forms.Label xEscapeLabel;
        private System.Windows.Forms.TextBox xEscapeBox;
        private System.Windows.Forms.TextBox yEscapeBox;
        private System.Windows.Forms.Label minimumSpaceLabel;
        private System.Windows.Forms.TextBox minimumSpaceBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button newBoardButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label zoomLabel;
    }
}