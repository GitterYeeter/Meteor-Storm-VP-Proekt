namespace Meteor_Blaster
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.leftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.rightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.downMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.upMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.moveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.moveEnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.textlabel1 = new System.Windows.Forms.Label();
            this.replayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(347, 492);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(67, 62);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // leftMoveTimer
            // 
            this.leftMoveTimer.Interval = 5;
            this.leftMoveTimer.Tick += new System.EventHandler(this.leftMoveTimer_Tick);
            // 
            // rightMoveTimer
            // 
            this.rightMoveTimer.Interval = 5;
            this.rightMoveTimer.Tick += new System.EventHandler(this.rightMoveTimer_Tick);
            // 
            // downMoveTimer
            // 
            this.downMoveTimer.Interval = 5;
            this.downMoveTimer.Tick += new System.EventHandler(this.downMoveTimer_Tick);
            // 
            // upMoveTimer
            // 
            this.upMoveTimer.Interval = 5;
            this.upMoveTimer.Tick += new System.EventHandler(this.upMoveTimer_Tick);
            // 
            // moveMunitionTimer
            // 
            this.moveMunitionTimer.Enabled = true;
            this.moveMunitionTimer.Interval = 20;
            this.moveMunitionTimer.Tick += new System.EventHandler(this.moveMunitionTimer_Tick);
            // 
            // moveEnemyTimer
            // 
            this.moveEnemyTimer.Enabled = true;
            this.moveEnemyTimer.Tick += new System.EventHandler(this.moveEnemyTimer_Tick);
            // 
            // textlabel1
            // 
            this.textlabel1.AutoSize = true;
            this.textlabel1.Font = new System.Drawing.Font("Sitka Subheading", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textlabel1.Location = new System.Drawing.Point(328, 165);
            this.textlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textlabel1.Name = "textlabel1";
            this.textlabel1.Size = new System.Drawing.Size(144, 62);
            this.textlabel1.TabIndex = 1;
            this.textlabel1.Text = "label1";
            this.textlabel1.Visible = false;
            // 
            // replayBtn
            // 
            this.replayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayBtn.Location = new System.Drawing.Point(305, 241);
            this.replayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(180, 63);
            this.replayBtn.TabIndex = 2;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Visible = false;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(305, 331);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(180, 63);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.Red;
            this.scorelbl.Location = new System.Drawing.Point(95, 5);
            this.scorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(70, 25);
            this.scorelbl.TabIndex = 5;
            this.scorelbl.Text = "label1";
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Red;
            this.levellbl.Location = new System.Drawing.Point(737, 5);
            this.levellbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(36, 25);
            this.levellbl.TabIndex = 6;
            this.levellbl.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(672, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "LEVEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCORE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(275, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRESS SPACE TO PAUSE THE GAME";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(319, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "YOUR SCORE";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(779, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.textlabel1);
            this.Controls.Add(this.Player);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer leftMoveTimer;
        private System.Windows.Forms.Timer rightMoveTimer;
        private System.Windows.Forms.Timer downMoveTimer;
        private System.Windows.Forms.Timer upMoveTimer;
        private System.Windows.Forms.Timer moveMunitionTimer;
        private System.Windows.Forms.Timer moveEnemyTimer;
        private System.Windows.Forms.Label textlabel1;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

