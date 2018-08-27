using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greyhound_Races
{
    public class Gamble
    {
        public int Amount;
        public int Dog;
        public Player Bettor;

        public override string ToString()
        {
            // Return a string that describes the amount of the bet, the dog bet on, and the name of the Player
            return $"{Bettor.Name} bet ${Amount} on Dog #{Dog}.";
        }

        public int Payout(int Winner)
        {
            // The paramater identifies the winning dog.  If Player bet on this dog, then return the amount bet; otherwise,
            // the negative of the amount bet.
        }
    }
}
