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
using KataTennis.Helpers;

namespace KataTennis
{
    public partial class TennisForm : Form
    {
        public Game CurrentGame { get; set; }

        BindingSource gameBindingSource = new BindingSource();
        BindingSource player1BindingSource = new BindingSource();
        BindingSource player2BindingSource = new BindingSource();

        public TennisForm(Game game)
        {

            this.CurrentGame = game;
            InitializeComponent();
            gameBindingSource.DataSource = CurrentGame;
            player1BindingSource.DataSource = CurrentGame.Player1;
            player2BindingSource.DataSource = CurrentGame.Player2;


            //Binding player1
            groupBoxPlayer1.DataBindings.Add("Text", player1BindingSource, "Name");
            labelDisplayScorePlayer1.DataBindings.Add("Text", player1BindingSource, "Score");
            labelDisplayAdvantagePlayer1.DataBindings.Add("Text", player1BindingSource, "Advantage");


            //Binding player2
            groupBoxPlayer2.DataBindings.Add("Text", player2BindingSource, "Name");
            labelDisplayScorePlayer2.DataBindings.Add("Text", player2BindingSource, "Score");
            labelDisplayAdvantagePlayer2.DataBindings.Add("Text", player2BindingSource, "Advantage");
        }

        // On click: Player 1 win this round
        private void buttonPlayer1Win_Click(object sender, EventArgs e)
        {
            player1WinRound();
        }


        // On click: Player 2 win this round
        private void buttonPlayer2Win_Click(object sender, EventArgs e)
        {
            player2WinRound();
        }


        // On click: a random player win the round
        private void buttonPlayerRandomWin_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (rand.Next(101) > 50)
                player1WinRound();
            else
                player2WinRound();
        }


        // Actions upons player 1 win
        private void player1WinRound() {
            int gameResult = 0;
            gameResult = CurrentGame.Player1.RoundResult(Constants.WinRound, CurrentGame.IsDeuce());
            CurrentGame.Player2.RoundResult(Constants.LoseRound, CurrentGame.IsDeuce());
            gameBindingSource.ResetBindings(false);
            player1BindingSource.ResetBindings(false);
            player2BindingSource.ResetBindings(false);
            // If player 1 win the match, end game
            if (gameResult == Constants.WinMatch)
                endGame(CurrentGame.Player1.Name);
        }


        // Actions upons player 2 win
        private void player2WinRound()
        {
            int gameResult = 0;
            gameResult = CurrentGame.Player2.RoundResult(Constants.WinRound, CurrentGame.IsDeuce());
            CurrentGame.Player1.RoundResult(Constants.LoseRound, CurrentGame.IsDeuce());
            gameBindingSource.ResetBindings(false);
            player1BindingSource.ResetBindings(false);
            player2BindingSource.ResetBindings(false);
            // If player 2 win the match, end game
            if (gameResult == Constants.WinMatch)
                endGame(CurrentGame.Player2.Name);
        }

        //Display winner and ask for replay
        private void endGame(string winner)
        {
            string message = winner + " win the game. Play again?";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                SetNameForm setNameForm = new SetNameForm();
                setNameForm.ShowDialog();
                
            }

            this.Close();
        }
    }
}
