
namespace Assignment2Milestone1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TargetWord = new System.Windows.Forms.TextBox();
            this.P1LetterGuess = new System.Windows.Forms.TextBox();
            this.P1Name = new System.Windows.Forms.TextBox();
            this.P1CurrentScore = new System.Windows.Forms.TextBox();
            this.InitializeP1Game = new System.Windows.Forms.Button();
            this.NewWord = new System.Windows.Forms.Button();
            this.PrizeLabel = new System.Windows.Forms.Label();
            this.Prize = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.letterGuess = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.GuessWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Prize)).BeginInit();
            this.SuspendLayout();
            // 
            // TargetWord
            // 
            this.TargetWord.Location = new System.Drawing.Point(338, 62);
            this.TargetWord.Name = "TargetWord";
            this.TargetWord.ReadOnly = true;
            this.TargetWord.Size = new System.Drawing.Size(100, 26);
            this.TargetWord.TabIndex = 0;
            // 
            // P1LetterGuess
            // 
            this.P1LetterGuess.Location = new System.Drawing.Point(141, 173);
            this.P1LetterGuess.Name = "P1LetterGuess";
            this.P1LetterGuess.Size = new System.Drawing.Size(100, 26);
            this.P1LetterGuess.TabIndex = 1;
            this.P1LetterGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1LetterGuess_KeyPress);
            // 
            // P1Name
            // 
            this.P1Name.Location = new System.Drawing.Point(141, 128);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(100, 26);
            this.P1Name.TabIndex = 2;
            // 
            // P1CurrentScore
            // 
            this.P1CurrentScore.Location = new System.Drawing.Point(141, 221);
            this.P1CurrentScore.Name = "P1CurrentScore";
            this.P1CurrentScore.ReadOnly = true;
            this.P1CurrentScore.Size = new System.Drawing.Size(100, 26);
            this.P1CurrentScore.TabIndex = 3;
            // 
            // InitializeP1Game
            // 
            this.InitializeP1Game.Location = new System.Drawing.Point(125, 273);
            this.InitializeP1Game.Name = "InitializeP1Game";
            this.InitializeP1Game.Size = new System.Drawing.Size(134, 43);
            this.InitializeP1Game.TabIndex = 4;
            this.InitializeP1Game.Text = "Initialize Player 1";
            this.InitializeP1Game.UseVisualStyleBackColor = true;
            this.InitializeP1Game.Click += new System.EventHandler(this.InitializeP1Game_Click);
            // 
            // NewWord
            // 
            this.NewWord.Location = new System.Drawing.Point(321, 307);
            this.NewWord.Name = "NewWord";
            this.NewWord.Size = new System.Drawing.Size(128, 77);
            this.NewWord.TabIndex = 5;
            this.NewWord.Text = "Guess New Word";
            this.NewWord.UseVisualStyleBackColor = true;
            this.NewWord.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // PrizeLabel
            // 
            this.PrizeLabel.AutoSize = true;
            this.PrizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrizeLabel.Location = new System.Drawing.Point(337, 284);
            this.PrizeLabel.Name = "PrizeLabel";
            this.PrizeLabel.Size = new System.Drawing.Size(101, 20);
            this.PrizeLabel.TabIndex = 6;
            this.PrizeLabel.Text = "Current Prize";
            // 
            // Prize
            // 
            this.Prize.Image = global::Assignment2Milestone1.Properties.Resources.rock;
            this.Prize.Location = new System.Drawing.Point(321, 109);
            this.Prize.Name = "Prize";
            this.Prize.Size = new System.Drawing.Size(136, 172);
            this.Prize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Prize.TabIndex = 7;
            this.Prize.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.nameLabel.Location = new System.Drawing.Point(-5, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Enter Your Name: ";
            // 
            // letterGuess
            // 
            this.letterGuess.AutoSize = true;
            this.letterGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.letterGuess.Location = new System.Drawing.Point(6, 179);
            this.letterGuess.Name = "letterGuess";
            this.letterGuess.Size = new System.Drawing.Size(121, 20);
            this.letterGuess.TabIndex = 9;
            this.letterGuess.Text = "Guess A Letter:";
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player1Score.Location = new System.Drawing.Point(12, 227);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(115, 20);
            this.Player1Score.TabIndex = 10;
            this.Player1Score.Text = "Player 1 Score:";
            // 
            // GuessWord
            // 
            this.GuessWord.AutoSize = true;
            this.GuessWord.ForeColor = System.Drawing.SystemColors.Menu;
            this.GuessWord.Location = new System.Drawing.Point(326, 20);
            this.GuessWord.Name = "GuessWord";
            this.GuessWord.Size = new System.Drawing.Size(131, 20);
            this.GuessWord.TabIndex = 11;
            this.GuessWord.Text = "Guess This Word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuessWord);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.letterGuess);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Prize);
            this.Controls.Add(this.PrizeLabel);
            this.Controls.Add(this.NewWord);
            this.Controls.Add(this.InitializeP1Game);
            this.Controls.Add(this.P1CurrentScore);
            this.Controls.Add(this.P1Name);
            this.Controls.Add(this.P1LetterGuess);
            this.Controls.Add(this.TargetWord);
            this.Name = "Form1";
            this.Text = "Wheel Of Fortune !";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetWord;
        private System.Windows.Forms.TextBox P1LetterGuess;
        private System.Windows.Forms.TextBox P1CurrentScore;
        private System.Windows.Forms.Button InitializeP1Game;
        private System.Windows.Forms.Button NewWord;
        private System.Windows.Forms.Label PrizeLabel;
        private System.Windows.Forms.PictureBox Prize;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label letterGuess;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label GuessWord;
        public System.Windows.Forms.TextBox P1Name;
    }
}

