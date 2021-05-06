using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Milestone1
{
    /// <summary>
    /// Assignment 2 Final
    /// Game class holds all possible words for the game as well
    /// as associated scores for guessing them correctly
    /// </summary>
    public class Game
    {
        private string[] possibleWords = { "guess", "word", "zulu", "sharp", "program", "winner", "loser" };
        private int[] prizeAmounts = { 100, 200, 500, 1000, 640, 999, 10000 };
        private string targetWord;
        Random randomNumber;

        public string[] PossibleWords
        {
            get
            {
                return possibleWords;
            }
            set
            {
                possibleWords = value;
            }
        }

        public int[] PrizeAmounts
        {
            get
            {
                return prizeAmounts;
            }
            set
            {
                prizeAmounts = value;
            }
        }

        public string TargetWord
        {
            get
            {
                return targetWord;
            }
            set
            {
                targetWord = value;
            }
        }

        public Game()
        {
            randomNumber = new Random();
            targetWord = assignValue();
        }

        public string assignValue()
        {
            targetWord = possibleWords[randomNumber.Next(0, possibleWords.Length)];
           
            return targetWord;
        }
    }
}
