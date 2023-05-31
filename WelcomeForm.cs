using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class WelcomeForm : Form
    {
        public string level;
        public List<Player> players;
        private string name_1;
        private string name_2;
        private string name_3;
        public WelcomeForm()
        {
            InitializeComponent();
            players = new List<Player>();
            level_cb.SelectedIndex = 0;
            player1_tb.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string TryParse(TextBox textBox)
        {
            if (textBox.Text != string.Empty)
            {
                entry_lb.Visible = false;
                return textBox.Text;
            }
            else
            {
                entry_lb.Visible = true;
                entry_lb.Location = new Point(entry_lb.Location.X, textBox.Location.Y + textBox.Height + 5);
                textBox.Focus();
                return string.Empty;
            }
        }
        private void start_bt_Click(object sender, EventArgs e)
        {
            if (name_1 != string.Empty && name_2 != string.Empty && name_3 != string.Empty)
            {
                players.Add(new Player(name_1));
                players.Add(new Player(name_2));
                players.Add(new Player(name_3));
                level = level_cb.Text;
                player1_tb.Clear();
                player2_tb.Clear();
                player3_tb.Clear();
                GameForm gameForm = new GameForm(players, level);
                DialogResult result = gameForm.ShowDialog();
                this.Hide();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
                gameForm.Dispose();
            }
        }

        private void player1_tb_Leave(object sender, EventArgs e)
        {
            name_1 = TryParse(player1_tb);
        }

        private void player2_tb_Leave(object sender, EventArgs e)
        {
            name_2 = TryParse(player2_tb);
        }

        private void player3_tb_Leave(object sender, EventArgs e)
        {
            name_3 = TryParse(player3_tb);
        }
    }
}
