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
            Bet = new Gamble()
        };

        Player Bob = new Player()
        {
            Name = "Bob",
            Bet = new Gamble()
        };

        Player Al = new Player()
        {
            Name = "Al",
            Bet = new Gamble()
        };

        Player[] players = new Player[3];


        public Form1()
        {
            InitializeComponent();
            Joe.Lbl = JoeLbl;
            Joe.RdBtn = JoeBtn;
            Bob.Lbl = BobLbl;
            Bob.RdBtn = BobBtn;
            Al.Lbl = AlLbl;
            Al.RdBtn = AlBtn;
            players[0] = Joe;
            players[1] = Bob;
            players[2] = Al;
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
