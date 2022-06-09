
namespace Faculdade_ProjectGame
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.lb_bestScore = new System.Windows.Forms.Label();
            this.lb_gamesPlayed = new System.Windows.Forms.Label();
            this.lb_coins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_bestScore
            // 
            this.lb_bestScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bestScore.Location = new System.Drawing.Point(8, 107);
            this.lb_bestScore.Margin = new System.Windows.Forms.Padding(5);
            this.lb_bestScore.Name = "lb_bestScore";
            this.lb_bestScore.Size = new System.Drawing.Size(314, 23);
            this.lb_bestScore.TabIndex = 1;
            this.lb_bestScore.Text = "Best Score: 0";
            // 
            // lb_gamesPlayed
            // 
            this.lb_gamesPlayed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gamesPlayed.Location = new System.Drawing.Point(8, 140);
            this.lb_gamesPlayed.Margin = new System.Windows.Forms.Padding(5);
            this.lb_gamesPlayed.Name = "lb_gamesPlayed";
            this.lb_gamesPlayed.Size = new System.Drawing.Size(314, 23);
            this.lb_gamesPlayed.TabIndex = 2;
            this.lb_gamesPlayed.Text = "Games Played: 0";
            // 
            // lb_coins
            // 
            this.lb_coins.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coins.Location = new System.Drawing.Point(8, 173);
            this.lb_coins.Margin = new System.Windows.Forms.Padding(5);
            this.lb_coins.Name = "lb_coins";
            this.lb_coins.Size = new System.Drawing.Size(314, 23);
            this.lb_coins.TabIndex = 3;
            this.lb_coins.Text = "Coins: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(14)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(252, 209);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 25);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 246);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_coins);
            this.Controls.Add(this.lb_gamesPlayed);
            this.Controls.Add(this.lb_bestScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_bestScore;
        private System.Windows.Forms.Label lb_gamesPlayed;
        private System.Windows.Forms.Label lb_coins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
    }
}