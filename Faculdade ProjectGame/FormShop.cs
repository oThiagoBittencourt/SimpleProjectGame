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
    public partial class FormShop : Form
    {
        PictureBox _player;
        Label _lb_totalCoins;

        public FormShop(ref PictureBox player, ref Label label)
        {
            InitializeComponent();

            _player = player;
            _lb_totalCoins = label;

            ViewMode();
            Start_Update();
        }

        void Start_Update()
        {
            lb_myCoins.Text = $"MY COINS: {Static._coins}";
            ItemsPurchase();
        }

        void ItemsPurchase()
        {
            Button[] buttons = { button1, button2, button3, button4 };

            for (int i = 0; i < buttons.Length; i++)
            {
                if (Static.itemsPurchased[i])
                {
                    if (Static.itemEquiped == i)
                    {
                        foreach (Button button in buttons)
                        {
                            button.Enabled = true;
                        }
                        buttons[i].Enabled = false;
                    }
                    buttons[i].Text = "Equip";
                }
                else
                {
                    buttons[i].Text = "Buy";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyEquipOption(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyEquipOption(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyEquipOption(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyEquipOption(3);
        }

        void BuyEquipOption(int index)
        {
            int[] prices = { 0, 20, 35, 50 };
            PictureBox[] pictureBox = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            if (Static.itemsPurchased[index])
            {
                Static.itemEquiped = index;
                Static._playerColor = _player.BackColor = pictureBox[index].BackColor;
                Start_Update();
            }
            else
            {
                if (Static._coins >= prices[index])
                {
                    Static.itemsPurchased[index] = true;
                    Static._coins -= prices[index];
                    _lb_totalCoins.Text = $"COINS: {Static._coins}";
                    Start_Update();
                }
                else
                {
                    MessageBox.Show("Você não possui moedas sulficientes!", "Moedas Insulficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ViewMode()
        {
            Color grayColor = Color.FromArgb(45, 45, 48);
            Color darkColor = Color.FromArgb(27, 27, 28);

            if (Static._lightMode)
            {
                this.BackColor = SystemColors.Control;
                lb_myCoins.ForeColor = button1.ForeColor = button2.ForeColor = button3.ForeColor = button4.ForeColor = label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = btn_back.ForeColor = SystemColors.ControlText;
                panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = btn_back.BackColor = Color.FromArgb(224, 244, 244);
            }
            else
            {
                this.BackColor = Color.FromArgb(35, 35, 38);
                lb_myCoins.ForeColor = button1.ForeColor = button2.ForeColor = button3.ForeColor = button4.ForeColor = label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = btn_back.ForeColor = Color.White;
                panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = btn_back.BackColor = grayColor;
            }
        }
    }
}
