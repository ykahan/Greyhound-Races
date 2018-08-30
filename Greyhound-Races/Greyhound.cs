using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound_Races
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox PicBox;
        public int Location = 0;
        public Random Ran;

        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of PicBox like this:
            // PicBox.Left += StartingPosition + Location;
            // Return true if I won the race, false otherwise.

            this.Location = this.Ran.Next(1, 10);
            this.PicBox.Left += this.StartingPosition + this.Location;
            if (this.PicBox.Left >= this.RacetrackLength - this.PicBox.Width) {
               
                return true; }
                
            return false;
        }

        public void TakeStartingPosition()
        {
            // Reset Location to 0 and PicBox to starting position
        }
    }
}
