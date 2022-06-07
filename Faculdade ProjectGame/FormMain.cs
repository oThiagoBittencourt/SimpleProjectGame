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
    // Main Code
    public partial class FormMain : Form
    {
        Random rng = new Random();
        int _score = 0;

        public FormMain()
        {
            InitializeComponent();

            Save.Read();
            Start();
            ViewMode();
            toolStripComboBox1.Text = Static._lightMode ? "Light Mode" : "Dark Mode";
            Static._playerColor = player.BackColor;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            PlayMusic(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            WalkCheck(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EnemyGenerator();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lb_score.Text = $"SCORE: {_score += 9}";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Static._lightMode = true;
                ViewMode();
            }
            else
            {
                Static._lightMode = false;
                ViewMode();
            }
        }

        private void soundOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicOnOffToolStripMenuItem.Checked)
            {
                PlayMusic(false);
                musicOnOffToolStripMenuItem.Checked = false;
            }
            else
            {
                PlayMusic(true);
                musicOnOffToolStripMenuItem.Checked = true;
            }
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerControl(false);
            FormShop shop = new FormShop(ref player, ref lb_coins);
            shop.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerControl(false);
            FormProfile profile = new FormProfile();
            profile.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                TimerControl(false);
                MessageBox.Show("Seu objetivo é coletar o máximo de moedas sem ser pego pelos inimigos vermelhos!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TimerControl(true);
            }
            else
                MessageBox.Show("Seu objetivo é coletar o máximo de moedas sem ser pego pelos inimigos vermelhos!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._bestScore = _score > Static._bestScore ? _score : Static._bestScore;
            Static._gamesPlayed++;
            Save.Write();
        }
    }
}