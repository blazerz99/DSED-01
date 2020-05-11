namespace Russian_Roulette_Assessment
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblGameMsg = new System.Windows.Forms.Label();
            this.nextlevelButton = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.endscoreLbl = new System.Windows.Forms.Label();
            this.endplayagainButton = new System.Windows.Forms.Button();
            this.endexitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(694, 93);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(223, 56);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(729, 70);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(160, 38);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open Door";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(729, 132);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(160, 38);
            this.skipButton.TabIndex = 4;
            this.skipButton.Text = "Skip Door";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Visible = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(729, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Location = new System.Drawing.Point(15, 354);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 29);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Score:";
            // 
            // lblMessages
            // 
            this.lblMessages.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMessages.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(168, 354);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(432, 126);
            this.lblMessages.TabIndex = 14;
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWin.Location = new System.Drawing.Point(15, 401);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(111, 29);
            this.lblWin.TabIndex = 15;
            this.lblWin.Text = "Win:";
            // 
            // lblLose
            // 
            this.lblLose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLose.Location = new System.Drawing.Point(15, 449);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(111, 29);
            this.lblLose.TabIndex = 16;
            this.lblLose.Text = "Lose:";
            // 
            // lblGameMsg
            // 
            this.lblGameMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGameMsg.Location = new System.Drawing.Point(678, 232);
            this.lblGameMsg.Name = "lblGameMsg";
            this.lblGameMsg.Size = new System.Drawing.Size(249, 100);
            this.lblGameMsg.TabIndex = 17;
            // 
            // nextlevelButton
            // 
            this.nextlevelButton.Location = new System.Drawing.Point(335, 178);
            this.nextlevelButton.Name = "nextlevelButton";
            this.nextlevelButton.Size = new System.Drawing.Size(300, 96);
            this.nextlevelButton.TabIndex = 18;
            this.nextlevelButton.Text = "Advance to Next Floor";
            this.nextlevelButton.UseVisualStyleBackColor = true;
            this.nextlevelButton.Visible = false;
            this.nextlevelButton.Click += new System.EventHandler(this.nextlevelButton_Click);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbMain.Location = new System.Drawing.Point(0, 1);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(636, 332);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // endscoreLbl
            // 
            this.endscoreLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.endscoreLbl.Location = new System.Drawing.Point(412, 128);
            this.endscoreLbl.Name = "endscoreLbl";
            this.endscoreLbl.Size = new System.Drawing.Size(151, 47);
            this.endscoreLbl.TabIndex = 19;
            this.endscoreLbl.Text = "Score:";
            this.endscoreLbl.Visible = false;
            // 
            // endplayagainButton
            // 
            this.endplayagainButton.Location = new System.Drawing.Point(412, 201);
            this.endplayagainButton.Name = "endplayagainButton";
            this.endplayagainButton.Size = new System.Drawing.Size(151, 50);
            this.endplayagainButton.TabIndex = 20;
            this.endplayagainButton.Text = "Play Again";
            this.endplayagainButton.UseVisualStyleBackColor = true;
            this.endplayagainButton.Visible = false;
            this.endplayagainButton.Click += new System.EventHandler(this.endplayagainButton_Click);
            // 
            // endexitButton
            // 
            this.endexitButton.Location = new System.Drawing.Point(412, 267);
            this.endexitButton.Name = "endexitButton";
            this.endexitButton.Size = new System.Drawing.Size(151, 50);
            this.endexitButton.TabIndex = 21;
            this.endexitButton.Text = "Exit";
            this.endexitButton.UseVisualStyleBackColor = true;
            this.endexitButton.Visible = false;
            this.endexitButton.Click += new System.EventHandler(this.endexitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 498);
            this.Controls.Add(this.endexitButton);
            this.Controls.Add(this.endplayagainButton);
            this.Controls.Add(this.endscoreLbl);
            this.Controls.Add(this.nextlevelButton);
            this.Controls.Add(this.lblGameMsg);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblGameMsg;
        private System.Windows.Forms.Button nextlevelButton;
        private System.Windows.Forms.Label endscoreLbl;
        private System.Windows.Forms.Button endplayagainButton;
        private System.Windows.Forms.Button endexitButton;
    }
}

