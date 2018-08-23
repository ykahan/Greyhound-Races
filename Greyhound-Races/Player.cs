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
        public RadioButton RadButt;
        public Label Lbl;

        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label
            // on my radio button to show my cash.
        }

        public void ClearBet()
        {
            // Reset Bet to 0.
        }

        public bool PlaceBet(int amount, int dogToWin)
        {
            // Attempt to place a new bet
            // Return true if the bet is possible (the guy has enough money to place it and it is 
            // within game guidelines), false otherwise)
            return true;
        }

        public void Collect(int Winner)
        {
            // Ask Bet to pay out, clear the best, and update the labels.
        }
    }
}
