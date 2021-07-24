
namespace CopsNRobbers.Project.Forms
{
    partial class Game2Screen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2Screen_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TreasureLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopPictureBox = new System.Windows.Forms.PictureBox();
            this.RobberPictureBox = new System.Windows.Forms.PictureBox();
            this.TreasurePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer1minute = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCop = new System.Windows.Forms.Timer(this.components);
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.MidPanel = new System.Windows.Forms.Panel();
            this.MidExpandPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreasurePictureBox)).BeginInit();
            this.MidPanel.SuspendLayout();
            this.MidExpandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.TreasureLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SecondsLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 84);
            this.panel1.TabIndex = 0;
            // 
            // TreasureLabel
            // 
            this.TreasureLabel.AutoSize = true;
            this.TreasureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TreasureLabel.ForeColor = System.Drawing.Color.White;
            this.TreasureLabel.Location = new System.Drawing.Point(92, 48);
            this.TreasureLabel.Name = "TreasureLabel";
            this.TreasureLabel.Size = new System.Drawing.Size(17, 19);
            this.TreasureLabel.TabIndex = 3;
            this.TreasureLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Treasure:";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecondsLabel.ForeColor = System.Drawing.Color.White;
            this.SecondsLabel.Location = new System.Drawing.Point(73, 15);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(25, 19);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer:";
            // 
            // CopPictureBox
            // 
            this.CopPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CopPictureBox.Image")));
            this.CopPictureBox.Location = new System.Drawing.Point(417, 303);
            this.CopPictureBox.Name = "CopPictureBox";
            this.CopPictureBox.Size = new System.Drawing.Size(105, 125);
            this.CopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CopPictureBox.TabIndex = 1;
            this.CopPictureBox.TabStop = false;
            // 
            // RobberPictureBox
            // 
            this.RobberPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RobberPictureBox.Image = global::CopsNRobbers.Properties.Resources.robberLeft;
            this.RobberPictureBox.Location = new System.Drawing.Point(666, 360);
            this.RobberPictureBox.Name = "RobberPictureBox";
            this.RobberPictureBox.Size = new System.Drawing.Size(112, 135);
            this.RobberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobberPictureBox.TabIndex = 2;
            this.RobberPictureBox.TabStop = false;
            // 
            // TreasurePictureBox
            // 
            this.TreasurePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TreasurePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TreasurePictureBox.Image")));
            this.TreasurePictureBox.Location = new System.Drawing.Point(236, 339);
            this.TreasurePictureBox.Name = "TreasurePictureBox";
            this.TreasurePictureBox.Size = new System.Drawing.Size(120, 100);
            this.TreasurePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TreasurePictureBox.TabIndex = 3;
            this.TreasurePictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(802, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(46, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer1minute
            // 
            this.timer1minute.Interval = 1000;
            this.timer1minute.Tick += new System.EventHandler(this.timer1minute_Tick);
            // 
            // timerRandomCop
            // 
            this.timerRandomCop.Interval = 1000;
            this.timerRandomCop.Tick += new System.EventHandler(this.timerRandomCop_Tick);
            // 
            // timerMove
            // 
            this.timerMove.Interval = 20;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(2)))));
            this.MidPanel.Controls.Add(this.MidExpandPanel);
            this.MidPanel.Location = new System.Drawing.Point(178, 87);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(482, 291);
            this.MidPanel.TabIndex = 5;
            // 
            // MidExpandPanel
            // 
            this.MidExpandPanel.Controls.Add(this.BackButton);
            this.MidExpandPanel.Controls.Add(this.StartButton);
            this.MidExpandPanel.Controls.Add(this.label5);
            this.MidExpandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidExpandPanel.Location = new System.Drawing.Point(0, 0);
            this.MidExpandPanel.Name = "MidExpandPanel";
            this.MidExpandPanel.Size = new System.Drawing.Size(482, 291);
            this.MidExpandPanel.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(272, 216);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(143, 39);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(76, 216);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(143, 39);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 144);
            this.label5.TabIndex = 1;
            this.label5.Text = "Are you ready to start?\r\n\r\nRun as fast as you can to escape from the Cop\r\nYou hav" +
    "e to steal 3 treasures in 1 minute!\r\n\r\nTo run... use the arrow keys.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game2Screen_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TreasurePictureBox);
            this.Controls.Add(this.RobberPictureBox);
            this.Controls.Add(this.CopPictureBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game2Screen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Robber Run";
            this.Load += new System.EventHandler(this.Game2Screen_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2Screen_Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game2Screen_Form_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreasurePictureBox)).EndInit();
            this.MidPanel.ResumeLayout(false);
            this.MidExpandPanel.ResumeLayout(false);
            this.MidExpandPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TreasureLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.PictureBox CopPictureBox;
        private System.Windows.Forms.PictureBox RobberPictureBox;
        private System.Windows.Forms.PictureBox TreasurePictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer1minute;
        private System.Windows.Forms.Timer timerRandomCop;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Panel MidExpandPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label5;
    }
}