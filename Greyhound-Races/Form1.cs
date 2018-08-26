using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound_Races
{
    public partial class Form1 : Form
    {
        Player Joe = new Player()
        {
            Name = "Joe",
            Bet = new Gamble(),
            Cash = 100,
            Lbl = new Label(),
            RadButt = new RadioButton()
        };


        Player[] players = new Player[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void BetSizeLbl_Click(object sender, EventArgs e)
        {
            this.Text = $"{} wants to bet $";
        }

        private void MinimumBetLbl_Click(object sender, EventArgs e)
        {
            this.Text = "Minimum bet is $1";
        }

        private void JoeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
