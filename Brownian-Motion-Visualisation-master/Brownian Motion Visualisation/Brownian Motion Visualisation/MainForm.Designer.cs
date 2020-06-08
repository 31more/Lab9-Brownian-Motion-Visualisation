namespace Lab9_brownianMotion
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TempLbl = new System.Windows.Forms.Label();
            this.TempBar = new System.Windows.Forms.TrackBar();
            this.NumOfMolecules = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMolecules)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of molecules:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Temperature:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsGroupBox.Controls.Add(this.StopBtn);
            this.SettingsGroupBox.Controls.Add(this.StartBtn);
            this.SettingsGroupBox.Controls.Add(this.TempLbl);
            this.SettingsGroupBox.Controls.Add(this.TempBar);
            this.SettingsGroupBox.Controls.Add(label2);
            this.SettingsGroupBox.Controls.Add(this.NumOfMolecules);
            this.SettingsGroupBox.Controls.Add(label1);
            this.SettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(290, 176);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(146, 131);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(106, 35);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StartBtn.Location = new System.Drawing.Point(25, 131);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(106, 35);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.Location = new System.Drawing.Point(117, 57);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(18, 20);
            this.TempLbl.TabIndex = 4;
            this.TempLbl.Text = "0";
            // 
            // TempBar
            // 
            this.TempBar.BackColor = System.Drawing.SystemColors.Window;
            this.TempBar.LargeChange = 50;
            this.TempBar.Location = new System.Drawing.Point(25, 80);
            this.TempBar.Maximum = 300;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(227, 45);
            this.TempBar.SmallChange = 10;
            this.TempBar.TabIndex = 3;
            this.TempBar.TickFrequency = 100;
            this.TempBar.Scroll += new System.EventHandler(this.TempBar_Scroll);
            // 
            // NumOfMolecules
            // 
            this.NumOfMolecules.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NumOfMolecules.Location = new System.Drawing.Point(175, 24);
            this.NumOfMolecules.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfMolecules.Name = "NumOfMolecules";
            this.NumOfMolecules.Size = new System.Drawing.Size(85, 26);
            this.NumOfMolecules.TabIndex = 1;
            this.NumOfMolecules.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 589);
            this.Controls.Add(this.SettingsGroupBox);
            this.Name = "MainWindow";
            this.Text = "Brownian Motion";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMolecules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.NumericUpDown NumOfMolecules;
        private System.Windows.Forms.Label TempLbl;
        private System.Windows.Forms.TrackBar TempBar;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
    }
}

