using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Assignment 2 Final
/// 23 April 2021
/// contains methods for actual logic in game.
/// Danny Beaudoin
/// </summary>


namespace Assignment2Milestone1
{
    public partial class Form1 : Form
    {
        Player player1;
        Game game1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string generateHidden(int lengthOfWord)
        {   
            string generatedString = "";

            for(int index = 0; index < lengthOfWord; index++)
            {
                generatedString += "-";
            }
            
            return generatedString;
        }

        private void InitializeP1Game_Click(object sender, EventArgs e)
        {
            string name = P1Name.Text;
            

            player1 = new Player(name);
            game1 = new Game();

            int score = player1.PlayerScore;

            int lengthOfWord = game1.TargetWord.Length;

            TargetWord.Text = generateHidden(lengthOfWord);
            P1CurrentScore.Text = score.ToString();
        }

        private void P1LetterGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter;
            int prize = 0;
            letter = e.KeyChar;

            //char[] wordArray = game1.targetWord.ToCharArray();
            char[] wordArray = TargetWord.Text.ToCharArray();
            int length = game1.TargetWord.Length;
            for (int index = 0; index < length; index++)
            {
                if (letter == game1.TargetWord[index])
                {
                    wordArray[index] = letter;
                    player1.PlayerScore += 10;
                }
                else
                {
                    wordArray[index] = wordArray[index];
                }
            }
            P1LetterGuess.Text = "";
            
            TargetWord.Text = new string(wordArray);
            player1.PlayerScore += prize;
            P1CurrentScore.Text = player1.PlayerScore.ToString();
        }

        private void NewWord_Click(object sender, EventArgs e)
        {
            string name = P1Name.Text;
            string word = TargetWord.Text;
            int prize = 0;
           
            for (int index = 0; index < 7; index++)
            {
                if (word == game1.PossibleWords[index])
                {
                    prize = game1.PrizeAmounts[index];
                    break;
                }
            }

            if (word == game1.TargetWord)
            {
                player1.PlayerWins++;
                player1.PlayerScore += prize;
                DialogResult dialogResult = MessageBox.Show("You win! Your current score is: " + 
                    player1.PlayerScore, "Play again?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    player1 = new Player(name);
                    game1 = new Game();
                    int lengthOfWord = game1.TargetWord.Length;

                    TargetWord.Text = generateHidden(lengthOfWord);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Thanks for playing!");
                    System.Windows.Forms.Application.Exit();
                }
            }
            P1CurrentScore.Text = player1.PlayerScore.ToString();

            
        }
    }
}
