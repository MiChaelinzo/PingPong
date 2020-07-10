namespace Pingpong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.timer_Moveball = new System.Windows.Forms.Timer(this.components);
            this.timer_Enemy = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Start = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.enemy_4 = new System.Windows.Forms.PictureBox();
            this.enemy_5 = new System.Windows.Forms.PictureBox();
            this.player_5 = new System.Windows.Forms.PictureBox();
            this.player_4 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.player_3 = new System.Windows.Forms.PictureBox();
            this.player_2 = new System.Windows.Forms.PictureBox();
            this.player_1 = new System.Windows.Forms.PictureBox();
            this.pb_Ball = new System.Windows.Forms.PictureBox();
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.WorldFrame.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.White;
            this.WorldFrame.Controls.Add(this.pb_Ball);
            this.WorldFrame.Controls.Add(this.pb_Enemy);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(427, 209);
            this.WorldFrame.TabIndex = 0;
            // 
            // timer_Moveball
            // 
            this.timer_Moveball.Enabled = true;
            this.timer_Moveball.Interval = 1;
            this.timer_Moveball.Tick += new System.EventHandler(this.timer_Moveball_Tick);
            // 
            // timer_Enemy
            // 
            this.timer_Enemy.Enabled = true;
            this.timer_Enemy.Interval = 10;
            this.timer_Enemy.Tick += new System.EventHandler(this.timer_Enemy_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label_Start
            // 
            this.label_Start.AutoSize = true;
            this.label_Start.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Start.Location = new System.Drawing.Point(151, 217);
            this.label_Start.Name = "label_Start";
            this.label_Start.Size = new System.Drawing.Size(127, 13);
            this.label_Start.TabIndex = 14;
            this.label_Start.Text = "Press Space to Start";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(177, 217);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(79, 13);
            this.label_Time.TabIndex = 15;
            this.label_Time.Text = "Time: 00: 00";
            this.label_Time.Visible = false;
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // enemy_4
            // 
            this.enemy_4.BackColor = System.Drawing.Color.Silver;
            this.enemy_4.Location = new System.Drawing.Point(303, 215);
            this.enemy_4.Name = "enemy_4";
            this.enemy_4.Size = new System.Drawing.Size(15, 15);
            this.enemy_4.TabIndex = 12;
            this.enemy_4.TabStop = false;
            // 
            // enemy_5
            // 
            this.enemy_5.BackColor = System.Drawing.Color.Silver;
            this.enemy_5.Location = new System.Drawing.Point(282, 215);
            this.enemy_5.Name = "enemy_5";
            this.enemy_5.Size = new System.Drawing.Size(15, 15);
            this.enemy_5.TabIndex = 11;
            this.enemy_5.TabStop = false;
            // 
            // player_5
            // 
            this.player_5.BackColor = System.Drawing.Color.Silver;
            this.player_5.Location = new System.Drawing.Point(132, 215);
            this.player_5.Name = "player_5";
            this.player_5.Size = new System.Drawing.Size(15, 15);
            this.player_5.TabIndex = 10;
            this.player_5.TabStop = false;
            // 
            // player_4
            // 
            this.player_4.BackColor = System.Drawing.Color.Silver;
            this.player_4.Location = new System.Drawing.Point(111, 215);
            this.player_4.Name = "player_4";
            this.player_4.Size = new System.Drawing.Size(15, 15);
            this.player_4.TabIndex = 9;
            this.player_4.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.Silver;
            this.enemy_1.Location = new System.Drawing.Point(366, 215);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(15, 15);
            this.enemy_1.TabIndex = 8;
            this.enemy_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.Color.Silver;
            this.enemy_2.Location = new System.Drawing.Point(345, 215);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(15, 15);
            this.enemy_2.TabIndex = 7;
            this.enemy_2.TabStop = false;
            // 
            // enemy_3
            // 
            this.enemy_3.BackColor = System.Drawing.Color.Silver;
            this.enemy_3.Location = new System.Drawing.Point(324, 215);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(15, 15);
            this.enemy_3.TabIndex = 6;
            this.enemy_3.TabStop = false;
            // 
            // player_3
            // 
            this.player_3.BackColor = System.Drawing.Color.Silver;
            this.player_3.Location = new System.Drawing.Point(90, 215);
            this.player_3.Name = "player_3";
            this.player_3.Size = new System.Drawing.Size(15, 15);
            this.player_3.TabIndex = 5;
            this.player_3.TabStop = false;
            // 
            // player_2
            // 
            this.player_2.BackColor = System.Drawing.Color.Silver;
            this.player_2.Location = new System.Drawing.Point(69, 215);
            this.player_2.Name = "player_2";
            this.player_2.Size = new System.Drawing.Size(15, 15);
            this.player_2.TabIndex = 4;
            this.player_2.TabStop = false;
            // 
            // player_1
            // 
            this.player_1.BackColor = System.Drawing.Color.Silver;
            this.player_1.Location = new System.Drawing.Point(48, 215);
            this.player_1.Name = "player_1";
            this.player_1.Size = new System.Drawing.Size(15, 15);
            this.player_1.TabIndex = 3;
            this.player_1.TabStop = false;
            // 
            // pb_Ball
            // 
            this.pb_Ball.BackColor = System.Drawing.Color.Black;
            this.pb_Ball.Location = new System.Drawing.Point(208, 90);
            this.pb_Ball.Name = "pb_Ball";
            this.pb_Ball.Size = new System.Drawing.Size(14, 16);
            this.pb_Ball.TabIndex = 2;
            this.pb_Ball.TabStop = false;
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.BackColor = System.Drawing.Color.Red;
            this.pb_Enemy.Location = new System.Drawing.Point(409, 67);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(15, 70);
            this.pb_Enemy.TabIndex = 1;
            this.pb_Enemy.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.SkyBlue;
            this.pb_Player.Location = new System.Drawing.Point(3, 67);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(15, 70);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(427, 241);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Start);
            this.Controls.Add(this.enemy_4);
            this.Controls.Add(this.enemy_5);
            this.Controls.Add(this.player_5);
            this.Controls.Add(this.player_4);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.player_3);
            this.Controls.Add(this.player_2);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ping pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.WorldFrame.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox pb_Ball;
        private System.Windows.Forms.PictureBox pb_Enemy;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer timer_Moveball;
        private System.Windows.Forms.PictureBox player_1;
        private System.Windows.Forms.PictureBox player_2;
        private System.Windows.Forms.PictureBox player_3;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox player_5;
        private System.Windows.Forms.PictureBox player_4;
        private System.Windows.Forms.PictureBox enemy_4;
        private System.Windows.Forms.PictureBox enemy_5;
        private System.Windows.Forms.Timer timer_Enemy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label_Start;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer_Sec;
    }
}

