using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound_Races
{
    public class Player
    {
        public string Name;
        public Gamble Bet;
        public int Cash;
        public int StartingCash = 100;
        public RadioButton RdBtn;
        public Label Lbl;
        string StartLabel = "Has Not Placed A Bet.";
        string NotEnoughMoney = "Does Not Have Enough Money For That Bet.";

        public void UpdateLabels(int amount, bool newGame)
        {
            // Set my label to my bet's description, and the label
            // on my radio button to show my cash.
            if (!newGame)
            {
                if (this.Bet.Amount >= 0)
                {
                    this.Lbl.Text = $"{this.Name} Has Bet ${this.Bet.Amount} On Dog #{this.Bet.Dog}.";
                    this.Cash -= amount;
                }
                else this.Lbl.Text = $"{this.Name} {NotEnoughMoney}";
            }
            else
            {
                this.Lbl.Text = $"{this.Name} {StartLabel}";
                this.Cash = StartingCash;
            }
            this.RdBtn.Text = $"{this.Name} Has ${this.Cash} Available.";
        }


        public void ClearBet()
        {
            // Reset Bet to 0.
            this.Bet.Amount = 0;
        }

        public void PlaceBet(int amount, int dogToWin)
        {
            // Attempt to place a new bet
            // Make appropriate updates
            if (this.Cash >= amount)
            {
                this.Bet.Amount = amount;
                this.Bet.Dog = dogToWin;
            }
            else this.Bet.Amount = 0;
            UpdateLabels(amount, false);
        }

        public void Collect(int Winner)
        {
            // Ask Bet to pay out, clear the bet, and update the labels.
            if (this.Bet.Dog == Winner)
            {
                this.Cash += this.Bet.Amount;
            }
            this.Lbl.Text =
        }
    }
}
