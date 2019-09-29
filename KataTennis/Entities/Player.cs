using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataTennis.Helpers;

namespace KataTennis.Entities
{
    public class Player
    {
        //Player store name, Score and the advantage of the player. Deuce is outside the scope of the player and inside the scope of the game.
        public string Name { get; set; }
        public int Score { get; set; }
        public bool Advantage { get; set; }

        //Default constructor
        public Player(string name, int score, bool advantage)
        {
            this.Name = name;
            this.Score = score;
            this.Advantage = advantage;
        }

        //Minimal constructor
        public Player(string name) : this(name, 0, false) { }

   

        public int RoundResult(bool result, bool deuce)
        {
            //I flayer win round
            if (result == Constants.WinRound)
            {
                // If score is below 40: Increase score and Next round
                if (Score < 40)
                {
                    ScoreIncrease();
                    return Constants.NextRound;
                }
                    
                // If score is above 40 and no Deuce: Win the match
                else if (deuce == Constants.IsNotDeuce)
                {
                    return Constants.WinMatch;
                }

                // If score is above 40, it is Deuce and player has advantage: Win match
                else if (Advantage == Constants.HasAdvantage)
                    return Constants.WinMatch;

                // If score is above 40, it is Deuce and player doesn't have advantage: Get advantage and next round
                else
                {
                    Advantage = Constants.HasAdvantage;
                    return Constants.NextRound;
                }

            // If player lose round, remove advantage (or doesn't change it if he doesn't have it) and next round
            }else
            {
                this.Advantage = Constants.HasNoAdvantage;
                return Constants.NextRound;
            }
        }

        //Update score based on precedent score
        public void ScoreIncrease()
        {
            switch (Score)
            {
                case 0:
                    this.Score = 15;
                    break;
                case 15:
                    this.Score = 30;
                    break;
                case 30:
                    this.Score = 40;
                    break;
                default:
                    throw new System.ArgumentException("Score is outside scope of the game");
            }
        }
    }
}
