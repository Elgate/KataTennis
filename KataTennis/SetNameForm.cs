using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KataTennis.Entities;

namespace KataTennis
{
    public partial class SetNameForm : Form
    {
        public SetNameForm()
        {
            InitializeComponent();

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamePlayer1.Text) || string.IsNullOrWhiteSpace(textBoxNamePlayer2.Text))
            {
                MessageBox.Show("Enter a name for each player");
                return;
            }
            Player player1 = new Player(textBoxNamePlayer1.Text);
            Player player2 = new Player(textBoxNamePlayer2.Text);
            Game game = new Game(player1, player2);
            MessageBox.Show(game.Player1.Name + " VS " + game.Player2.Name);
            this.Hide();
            TennisForm tennisForm = new TennisForm(game);
            tennisForm.ShowDialog();
            this.Close();
        }
    }
}
