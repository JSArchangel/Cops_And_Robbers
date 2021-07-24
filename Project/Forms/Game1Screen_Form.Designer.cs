
namespace CopsNRobbers.Project.Forms
{
    partial class Game1Screen_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1Screen_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CitizenPictureBox = new System.Windows.Forms.PictureBox();
            this.RobberPictureBox = new System.Windows.Forms.PictureBox();
            this.PolicePictureBox = new System.Windows.Forms.PictureBox();
            this.PoliceTalk = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.MidExpandPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1minute = new System.Windows.Forms.Timer(this.components);
            this.timerRandomRobber = new System.Windows.Forms.Timer(this.components);
            this.timerCitizens = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitizenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolicePictureBox)).BeginInit();
            this.MidPanel.SuspendLayout();
            this.MidExpandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.SecondsLabel);
            this.panel1.Controls.Add(this.CountLabel);
            this.panel1.Controls.Add(this.LevelLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 122);
            this.panel1.TabIndex = 0;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(72, 88);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(25, 19);
            this.SecondsLabel.TabIndex = 5;
            this.SecondsLabel.Text = "60";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(72, 51);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(17, 19);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(72, 14);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(17, 19);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // CitizenPictureBox
            // 
            this.CitizenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CitizenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CitizenPictureBox.Image")));
            this.CitizenPictureBox.Location = new System.Drawing.Point(79, 291);
            this.CitizenPictureBox.Name = "CitizenPictureBox";
            this.CitizenPictureBox.Size = new System.Drawing.Size(166, 188);
            this.CitizenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CitizenPictureBox.TabIndex = 1;
            this.CitizenPictureBox.TabStop = false;
            this.CitizenPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CitizenPictureBox_MouseClick);
            // 
            // RobberPictureBox
            // 
            this.RobberPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RobberPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RobberPictureBox.Image")));
            this.RobberPictureBox.Location = new System.Drawing.Point(433, 211);
            this.RobberPictureBox.Name = "RobberPictureBox";
            this.RobberPictureBox.Size = new System.Drawing.Size(131, 167);
            this.RobberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobberPictureBox.TabIndex = 2;
            this.RobberPictureBox.TabStop = false;
            this.RobberPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RobberPictureBox_MouseClick);
            // 
            // PolicePictureBox
            // 
            this.PolicePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PolicePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PolicePictureBox.Image")));
            this.PolicePictureBox.Location = new System.Drawing.Point(674, 307);
            this.PolicePictureBox.Name = "PolicePictureBox";
            this.PolicePictureBox.Size = new System.Drawing.Size(231, 219);
            this.PolicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PolicePictureBox.TabIndex = 3;
            this.PolicePictureBox.TabStop = false;
            // 
            // PoliceTalk
            // 
            this.PoliceTalk.AutoSize = true;
            this.PoliceTalk.BackColor = System.Drawing.Color.White;
            this.PoliceTalk.ForeColor = System.Drawing.Color.Black;
            this.PoliceTalk.Location = new System.Drawing.Point(710, 340);
            this.PoliceTalk.Name = "PoliceTalk";
            this.PoliceTalk.Size = new System.Drawing.Size(48, 38);
            this.PoliceTalk.TabIndex = 4;
            this.PoliceTalk.Text = "Hit or\r\nMiss?";
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_Button.BackgroundImage")));
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Location = new System.Drawing.Point(879, 10);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(42, 36);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.Color.Black;
            this.MidPanel.Controls.Add(this.MidExpandPanel);
            this.MidPanel.Location = new System.Drawing.Point(173, 101);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(601, 350);
            this.MidPanel.TabIndex = 6;
            // 
            // MidExpandPanel
            // 
            this.MidExpandPanel.Controls.Add(this.StartButton);
            this.MidExpandPanel.Controls.Add(this.BackButton);
            this.MidExpandPanel.Controls.Add(this.label8);
            this.MidExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.MidExpandPanel.Name = "MidExpandPanel";
            this.MidExpandPanel.Size = new System.Drawing.Size(601, 350);
            this.MidExpandPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(66, 248);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(193, 41);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(348, 248);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(193, 41);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 168);
            this.label8.TabIndex = 1;
            this.label8.Text = "Are you ready to start?\r\n\r\nYou have to catch 10 robbers\r\nin 1 minute! Use the mou" +
    "se\r\nto click on the robbers....\r\nand DON\'T catch the citizens!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1minute
            // 
            this.timer1minute.Interval = 1000;
            this.timer1minute.Tick += new System.EventHandler(this.timer1minute_Tick);
            // 
            // timerRandomRobber
            // 
            this.timerRandomRobber.Interval = 1000;
            this.timerRandomRobber.Tick += new System.EventHandler(this.timerRandomRobber_Tick);
            // 
            // timerCitizens
            // 
            this.timerCitizens.Interval = 2000;
            this.timerCitizens.Tick += new System.EventHandler(this.timerCitizens_Tick);
            // 
            // Game1Screen_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 557);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.PoliceTalk);
            this.Controls.Add(this.PolicePictureBox);
            this.Controls.Add(this.RobberPictureBox);
            this.Controls.Add(this.CitizenPictureBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game1Screen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch the Robber Game";
            this.Load += new System.EventHandler(this.Game1Screen_Form_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game1Screen_Form_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitizenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolicePictureBox)).EndInit();
            this.MidPanel.ResumeLayout(false);
            this.MidExpandPanel.ResumeLayout(false);
            this.MidExpandPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CitizenPictureBox;
        private System.Windows.Forms.PictureBox RobberPictureBox;
        private System.Windows.Forms.PictureBox PolicePictureBox;
        private System.Windows.Forms.Label PoliceTalk;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Panel MidExpandPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1minute;
        private System.Windows.Forms.Timer timerRandomRobber;
        private System.Windows.Forms.Timer timerCitizens;
    }
}