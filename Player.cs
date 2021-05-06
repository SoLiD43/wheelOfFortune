using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Milestone1
{
    /// <summary>
    /// Assignment 2 Final
    /// Players class holds all of the players info, including current score
    /// and wins / losses
    /// </summary>
    public class Player
    {
        private string playerName;
        private int playerScore;
        private int playerWins;
        private int playerLosses;

        public string PlayerName { get; set; }
        public int PlayerScore
        {
            get
            {
                return playerScore;
            }
            set
            {
                playerScore = value;
            }
        }

        public int PlayerWins
        {
            get
            {
                return playerWins;
            }
            set
            {
                playerWins = value;
            }
        }

        public int PlayerLosses
        {
            get
            {
                return playerLosses;
            }
            set
            {
                playerLosses = value;
            }
        }

        public Player(string playerName)
        {
            playerScore = 0;
            playerWins = 0;
            playerLosses = 0;
        }
    }
}
