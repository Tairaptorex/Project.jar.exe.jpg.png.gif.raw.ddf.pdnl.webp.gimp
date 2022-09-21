
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
            this.warninglbl = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.damage = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Button();
            this.titleBX = new System.Windows.Forms.PictureBox();
            this.helpbtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.playbtn = new System.Windows.Forms.Button();
            this.scoreadd = new System.Windows.Forms.Label();
            this.truescore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playertimer = new System.Windows.Forms.Timer(this.components);
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shooting = new System.Windows.Forms.Timer(this.components);
            this.shoottimer = new System.Windows.Forms.Timer(this.components);
            this.deathtmr = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBX)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Black;
            this.GamePanel.Controls.Add(this.warninglbl);
            this.GamePanel.Controls.Add(this.Warning);
            this.GamePanel.Controls.Add(this.exit);
            this.GamePanel.Controls.Add(this.settings);
            this.GamePanel.Controls.Add(this.damage);
            this.GamePanel.Controls.Add(this.instructions);
            this.GamePanel.Controls.Add(this.titleBX);
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
            // warninglbl
            // 
            this.warninglbl.AutoSize = true;
            this.warninglbl.BackColor = System.Drawing.Color.Transparent;
            this.warninglbl.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglbl.ForeColor = System.Drawing.Color.Red;
            this.warninglbl.Location = new System.Drawing.Point(269, 330);
            this.warninglbl.Name = "warninglbl";
            this.warninglbl.Size = new System.Drawing.Size(262, 23);
            this.warninglbl.TabIndex = 12;
            this.warninglbl.Text = "SLIPSTREAM DAMAGE ";
            // 
            // Warning
            // 
            this.Warning.BackColor = System.Drawing.Color.Transparent;
            this.Warning.Image = global::Attempt4.Properties.Resources.Warning;
            this.Warning.Location = new System.Drawing.Point(383, 226);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(22, 101);
            this.Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning.TabIndex = 11;
            this.Warning.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Cursor = System.Windows.Forms.Cursors.Help;
            this.exit.Font = new System.Drawing.Font("OCR A Extended", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(251, 304);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(310, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Black;
            this.settings.Cursor = System.Windows.Forms.Cursors.Help;
            this.settings.Font = new System.Drawing.Font("OCR A Extended", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.settings.Location = new System.Drawing.Point(251, 277);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(310, 23);
            this.settings.TabIndex = 9;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // damage
            // 
            this.damage.AutoSize = true;
            this.damage.BackColor = System.Drawing.Color.Transparent;
            this.damage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.damage.Location = new System.Drawing.Point(712, 10);
            this.damage.Name = "damage";
            this.damage.Size = new System.Drawing.Size(35, 13);
            this.damage.TabIndex = 8;
            this.damage.Text = "label3";
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Black;
            this.instructions.Cursor = System.Windows.Forms.Cursors.Help;
            this.instructions.Font = new System.Drawing.Font("OCR A Extended", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.instructions.Location = new System.Drawing.Point(251, 251);
            this.instructions.Margin = new System.Windows.Forms.Padding(0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(310, 23);
            this.instructions.TabIndex = 7;
            this.instructions.Text = "How To Play";
            this.instructions.UseVisualStyleBackColor = false;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // titleBX
            // 
            this.titleBX.BackColor = System.Drawing.Color.Transparent;
            this.titleBX.Image = global::Attempt4.Properties.Resources.GmeTitle;
            this.titleBX.Location = new System.Drawing.Point(177, 142);
            this.titleBX.Name = "titleBX";
            this.titleBX.Size = new System.Drawing.Size(468, 58);
            this.titleBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleBX.TabIndex = 6;
            this.titleBX.TabStop = false;
            // 
            // helpbtn
            // 
            this.helpbtn.BackColor = System.Drawing.Color.Black;
            this.helpbtn.Cursor = System.Windows.Forms.Cursors.No;
            this.helpbtn.Font = new System.Drawing.Font("OCR A Extended", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpbtn.Location = new System.Drawing.Point(251, 330);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(310, 23);
            this.helpbtn.TabIndex = 5;
            this.helpbtn.Text = "Assist Mode (For Disabled Players)";
            this.helpbtn.UseVisualStyleBackColor = false;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
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
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.Color.Black;
            this.playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbtn.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.playbtn.Location = new System.Drawing.Point(251, 214);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(310, 34);
            this.playbtn.TabIndex = 3;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
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
            // deathtmr
            // 
            this.deathtmr.Enabled = true;
            this.deathtmr.Tick += new System.EventHandler(this.deathtmr_Tick);
            // 
            // Gamespace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 961);
            this.Controls.Add(this.GamePanel);
            this.KeyPreview = true;
            this.Name = "Gamespace";
            this.Text = "Exynoid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamespace_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gamespace_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBX)).EndInit();
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
        private System.Windows.Forms.PictureBox titleBX;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Label damage;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Timer deathtmr;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox Warning;
        private System.Windows.Forms.Label warninglbl;
    }
}

