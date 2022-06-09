using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade_ProjectGame
{
    // Game Objects - Methods
    public partial class FormMain
    {
        void Start()
        {
            lb_coins.Text = $"Coins: {Static._coins}";
            player.BackColor = Static._playerColor;
        }

        void PlayMusic(bool stats)
        {
            SoundPlayer music = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "Music.wav");

            if (stats)
            {
                music.PlayLooping();
                Static._musicIsPlaying = true;
            }
            else
            {
                music.Stop();
                Static._musicIsPlaying = false;
            }
        }

        void WalkCheck(KeyEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        Static.Walk(ref player, 0);
                        break;
                    case Keys.A:
                        Static.Walk(ref player, 1);
                        break;
                    case Keys.S:
                        Static.Walk(ref player, 2);
                        break;
                    case Keys.D:
                        Static.Walk(ref player, 3);
                        break;
                }

                if (player.Location == coin.Location)
                    NewCoin(coin);
            }
        }

        void EnemyGenerator()
        {
            PictureBox[] inimigos = { inimigo1, inimigo2, inimigo3, inimigo4, inimigo5 };

            for (int i = 0; i < inimigos.Length; i++)
            {
                Static.Walk(ref inimigos[i], rng.Next(0, 4));
            }

            foreach (PictureBox item in inimigos)
            {
                if (player.Location == item.Location)
                    GameOver();
            }
        }

        void NewCoin(PictureBox objeto)
        {
            coin.Location = new Point((rng.Next(0, 16) * 25), (rng.Next(0, 16) * 25));
            Static._coins++;
            lb_coins.Text = $"COINS: {Static._coins}";
        }

        void NewGame()
        {
            _score = 0;

            PictureBox[] objetos = { player, inimigo1, inimigo2, inimigo3, inimigo4, inimigo5, coin };

            foreach (PictureBox item in objetos)
            {
                item.Location = new Point(rng.Next(0, 16) * 25, rng.Next(0, 16) * 25);
            }

            TimerControl(true);
        }

        void GameOver()
        {
            TimerControl(false);
            Static._bestScore = _score > Static._bestScore ? _score : Static._bestScore;
            Static._gamesPlayed++;
            if (!(MessageBox.Show("GAME OVER!  - Do you want to continue?", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel))
                NewGame();
        }

        void TimerControl(bool stats)
        {
            if (stats)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }
    }
}