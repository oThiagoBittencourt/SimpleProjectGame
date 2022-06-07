using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade_ProjectGame
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            ViewMode();
            ShowStats();
        }

        void ShowStats()
        {
            pictureBox1.BackColor = Static._playerColor;
            lb_bestScore.Text = $"Best Score: {Static._bestScore}";
            lb_gamesPlayed.Text = $"Games Played: {Static._gamesPlayed}";
            lb_coins.Text = $"Coins: {Static._coins}";
        }

        void ViewMode()
        {
            if (Static._lightMode)
            {
                this.BackColor = SystemColors.Control;
            }
            else
            {
                this.BackColor = Color.FromArgb(35, 35, 38);
                lb_bestScore.ForeColor = Color.White;
                lb_gamesPlayed.ForeColor = Color.White;
                lb_coins.ForeColor = Color.White;
                btn_back.ForeColor = Color.White;
                btn_back.BackColor = Color.FromArgb(27, 27, 28);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
