
namespace Attempt4
{
    partial class Gamespace
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.scoreadd = new System.Windows.Forms.Label();
            this.truescore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playertimer = new System.Windows.Forms.Timer(this.components);
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shooting = new System.Windows.Forms.Timer(this.components);
            this.shoottimer = new System.Windows.Forms.Timer(this.components);
            this.playbtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.helpbtn = new System.Windows.Forms.Button();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Controls.Add(this.helpbtn);
            this.GamePanel.Controls.Add(this.scorelbl);
            this.GamePanel.Controls.Add(this.playbtn);
            this.GamePanel.Controls.Add(this.scoreadd);
            this.GamePanel.Controls.Add(this.truescore);
            this.GamePanel.Controls.Add(this.label1);
            this.GamePanel.Location = new System.Drawing.Point(-6, -1);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(812, 1000);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scoreadd
            // 
            this.scoreadd.AutoSize = true;
            this.scoreadd.BackColor = System.Drawing.Color.Transparent;
            this.scoreadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreadd.Location = new System.Drawing.Point(19, 37);
            this.scoreadd.Name = "scoreadd";
            this.scoreadd.Size = new System.Drawing.Size(35, 13);
            this.scoreadd.TabIndex = 2;
            this.scoreadd.Text = "label3";
            // 
            // truescore
            // 
            this.truescore.AutoSize = true;
            this.truescore.BackColor = System.Drawing.Color.Transparent;
            this.truescore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.truescore.Location = new System.Drawing.Point(19, 14);
            this.truescore.Name = "truescore";
            this.truescore.Size = new System.Drawing.Size(35, 13);
            this.truescore.TabIndex = 1;
            this.truescore.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // playertimer
            // 
            this.playertimer.Enabled = true;
            this.playertimer.Interval = 80;
            this.playertimer.Tick += new System.EventHandler(this.playertimer_Tick);
            // 
            // movetimer
            // 
            this.movetimer.Enabled = true;
            this.movetimer.Interval = 1;
            this.movetimer.Tick += new System.EventHandler(this.movetimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shooting
            // 
            this.shooting.Enabled = true;
            this.shooting.Interval = 8;
            this.shooting.Tick += new System.EventHandler(this.shooting_Tick);
            // 
            // shoottimer
            // 
            this.shoottimer.Enabled = true;
            this.shoottimer.Interval = 10;
            this.shoottimer.Tick += new System.EventHandler(this.shoottimer_Tick);
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.Color.Red;
            this.playbtn.Location = new System.Drawing.Point(251, 214);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(310, 23);
            this.playbtn.TabIndex = 3;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scorelbl.Location = new System.Drawing.Point(248, 187);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(0, 13);
            this.scorelbl.TabIndex = 4;
            // 
            // helpbtn
            // 
            this.helpbtn.BackColor = System.Drawing.Color.Red;
            this.helpbtn.Location = new System.Drawing.Point(251, 243);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(310, 23);
            this.helpbtn.TabIndex = 5;
            this.helpbtn.Text = "Assist Mode (For Disabled Players)";
            this.helpbtn.UseVisualStyleBackColor = false;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // Gamespace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 961);
            this.Controls.Add(this.GamePanel);
            this.KeyPreview = true;
            this.Name = "Gamespace";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamespace_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gamespace_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Timer playertimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer movetimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer shooting;
        private System.Windows.Forms.Timer shoottimer;
        private System.Windows.Forms.Label scoreadd;
        private System.Windows.Forms.Label truescore;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Button helpbtn;
    }
}

