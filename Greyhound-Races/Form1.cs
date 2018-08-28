﻿using System;
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
        };

        Player Bob = new Player()
        {
            Name = "Bob",
        };

        Player Al = new Player()
        {
            Name = "Al",
        };

        Player[] players = new Player[3];
        Greyhound[] greyhounds = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();

            players[0] = new Player()
            {
                Name = "Joe",
                Lbl = JoeLbl,
                RdBtn = JoeBtn,
            };

            players[1] = new Player()
            {
                Name = "Bob",
                Lbl = BobLbl,
                RdBtn = BobBtn
            };
            players[2] = new Player()
            {
                Name = "Al",
                Lbl = AlLbl,
                RdBtn = AlBtn
            };
            
            for (int i = 0; i < players.Length; i++)
            {
                players[i].Bet = new Gamble()
                {
                    Bettor = players[i],
                    Amount = 0,
                    Dog = 0
                };
            }
            for (int i = 0; i < greyhounds.Length; i++)
            {
                greyhounds[i] = new Greyhound();
            }
        }

        private void BetSizeLbl_Click(object sender, EventArgs e)
        {
            //this.Text = $"{this.Name} wants to bet ${this.Bet.Amount}";
        }

        private void MinimumBetLbl_Click(object sender, EventArgs e)
        {
            this.Text = "Minimum bet is $1";
        }

        private void JoeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlaceBetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].RdBtn.Checked)
                {
                    players[i].PlaceBet((int)BetUpDown.Value, (int)DogUpDown.Value);
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            RaceTimer.Enabled = true;
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < length; i++)
            //{

            //}
        }
    }
}
