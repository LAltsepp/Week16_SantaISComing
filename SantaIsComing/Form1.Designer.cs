namespace SantaIsComing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 483);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1180, 76);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(47, 249);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(197, 117);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 1;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(1001, 375);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(128, 110);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 2;
            this.house.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(666, 330);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 155);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 3;
            this.tree.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(-1, -1);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(145, 130);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 4;
            this.moon.TabStop = false;
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(792, 38);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(100, 91);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 5;
            this.snowflake.TabStop = false;
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(531, 178);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(136, 112);
            this.playAgain.TabIndex = 6;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(1061, 28);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(45, 15);
            this.score.TabIndex = 7;
            this.score.Text = "Score 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 554);
            this.Controls.Add(this.score);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.house);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
    }
}

