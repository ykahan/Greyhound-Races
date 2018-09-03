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
        public int Cash = 100;
        //public int StartingCash = 100;
        public RadioButton RdBtn;
        public Label Lbl;
        string StartLabel = "Has Not Placed A Bet.";
        string NotEnoughMoney = "Does Not Have Enough Money For That Bet.";

        public void UpdateLabels(int amount, bool newRace)
        {
            // Set my label to my bet's description, and the label
            // on my radio button to show my cash.
            if (!newRace)
            {
                if (this.Cash >= amount) this.Lbl.Text = $"{this.Name} Bets ${this.Bet.Amount} On Dog #{this.Bet.Dog + 1}.";
                else this.Lbl.Text = $"{this.Name} {NotEnoughMoney}";
            }
            else this.Lbl.Text = $"{this.Name} {StartLabel}";
            this.RdBtn.Text = $"{this.Name} Has ${this.Cash} Available.";
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
            UpdateLabels(amount, false);
        }

        public void Collect(int Winner)
        {
            // Ask Bet to pay out, clear the bet, and update the labels.
            this.Cash += this.Bet.Payout(Winner);
            this.Bet.ClearBet();
            UpdateLabels(0, true);
        }
    }
}
