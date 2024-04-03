namespace Pc_Man_Game_MOO_ICT
{
    partial class Form5
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
            this.player = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(305, 324);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(114, 101);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(535, 62);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(101, 86);
            this.enemyThree.TabIndex = 1;
            this.enemyThree.TabStop = false;
            this.enemyThree.Click += new System.EventHandler(this.enemyThree_Click);
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(53, 62);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(101, 86);
            this.enemyOne.TabIndex = 2;
            this.enemyOne.TabStop = false;
            this.enemyOne.Click += new System.EventHandler(this.enemyOne_Click);
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.enemyTwo.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(305, 62);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(101, 86);
            this.enemyTwo.TabIndex = 3;
            this.enemyTwo.TabStop = false;
            this.enemyTwo.Click += new System.EventHandler(this.enemyTwo_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(336, 222);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(35, 38);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "0";
            this.txtScore.Click += new System.EventHandler(this.label2_Click);
            // 
            // bullet
            // 
            this.bullet.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(470, 227);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.TabIndex = 6;
            this.bullet.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pc_Man_Game_MOO_ICT.Properties.Resources.fr_navarre_flight;
            this.ClientSize = new System.Drawing.Size(697, 470);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.player);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Timer gameTimer;
    }
}