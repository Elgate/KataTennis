using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataTennis.Helpers;


namespace KataTennis.Entities
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        void Player1Win()
        {
            Player1.RoundResult(Constants.WinRound, IsDeuce());
            Player2.RoundResult(Constants.LoseRound, IsDeuce());
        }

        void Player2Win()
        {
            Player2.RoundResult(Constants.WinRound, IsDeuce());
            Player1.RoundResult(Constants.LoseRound, IsDeuce());
        }

        public bool IsDeuce()
        {
            if (Player1.Score == Player2.Score && Player1.Score == 40)
                return Constants.IsDeuce;
            return Constants.IsNotDeuce;
        }
    }
}
