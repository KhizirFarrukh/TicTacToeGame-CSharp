using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        List<Button> GameBtnsList = new List<Button>();
        Game game = new Game("X", "O");
        Game_AI AI = new Game_AI('X', 'O');
        bool AI_play_first = false;
        public Form1()
        {
            InitializeComponent();
            addBtnsToList();
            playerTurnSet();
            GameBtnsFixing();
        }
        private void addBtnsToList()
        {
            GameBtnsList.Add(this.BtnLoc1);
            GameBtnsList.Add(this.BtnLoc2);
            GameBtnsList.Add(this.BtnLoc3);
            GameBtnsList.Add(this.BtnLoc4);
            GameBtnsList.Add(this.BtnLoc5);
            GameBtnsList.Add(this.BtnLoc6);
            GameBtnsList.Add(this.BtnLoc7);
            GameBtnsList.Add(this.BtnLoc8);
            GameBtnsList.Add(this.BtnLoc9);
        }
        private void GameBtnsFixing()
        {
            foreach(Button btn in GameBtnsList)
            {
                btn.FlatAppearance.BorderSize = 0;
            }
        }
        private void BtnLoc1_Click(object sender, EventArgs e)
        {
            BtnLoc1.Enabled = false;
            BtnLoc1.Text = game.currentPlayer;
            game.makeMove(0);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[0] = BtnLoc1.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc2_Click(object sender, EventArgs e)
        {
            BtnLoc2.Enabled = false;
            BtnLoc2.Text = game.currentPlayer;
            game.makeMove(1);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[1] = BtnLoc2.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc3_Click(object sender, EventArgs e)
        {
            BtnLoc3.Enabled = false;
            BtnLoc3.Text = game.currentPlayer;
            game.makeMove(2);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[2] = BtnLoc3.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc4_Click(object sender, EventArgs e)
        {
            BtnLoc4.Enabled = false;
            BtnLoc4.Text = game.currentPlayer;
            game.makeMove(3);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[3] = BtnLoc4.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc5_Click(object sender, EventArgs e)
        {
            BtnLoc5.Enabled = false;
            BtnLoc5.Text = game.currentPlayer;
            game.makeMove(4);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[4] = BtnLoc5.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc6_Click(object sender, EventArgs e)
        {
            BtnLoc6.Enabled = false;
            BtnLoc6.Text = game.currentPlayer;
            game.makeMove(5);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[5] = BtnLoc6.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc7_Click(object sender, EventArgs e)
        {
            BtnLoc7.Enabled = false;
            BtnLoc7.Text = game.currentPlayer;
            game.makeMove(6);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[6] = BtnLoc7.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc8_Click(object sender, EventArgs e)
        {
            BtnLoc8.Enabled = false;
            BtnLoc8.Text = game.currentPlayer;
            game.makeMove(7);

            string tempBoard = game.getGameBoard();
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[7] = BtnLoc8.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if (PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }

        private void BtnLoc9_Click(object sender, EventArgs e)
        {
            BtnLoc9.Enabled = false;
            BtnLoc9.Text = game.currentPlayer;
            game.makeMove(8);

            string tempBoard = game.getGameBoard();
            Console.WriteLine(tempBoard);
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[8] = BtnLoc9.Text[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck())
            {
                playerTurnSet();
                if(PlayWithAI.Checked == true)
                {
                    AI_Turn(tempBoard);
                }
            }
        }
        private void AI_Turn(string board)
        {
            Console.WriteLine("board for AI : " + board);
            List<int> AvailableBoardLocations = new List<int>();

            for (int i = 0; i < GameBtnsList.Count; i++)
            {
                if (GameBtnsList[i].Text == "")
                {
                    AvailableBoardLocations.Add(i);
                }
                GameBtnsList[i].Enabled = false;
            }

            string AI_Playing_Character = game.currentPlayer;

            int predicted_move = -1;
            if (board == "000000000")
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(AvailableBoardLocations.Count);
                predicted_move = AvailableBoardLocations[randomIndex];
            }
            else
            {
                predicted_move = AI.NextMove(board, AI_Playing_Character[0]);
            }

            GameBtnsList[predicted_move].Enabled = false;
            GameBtnsList[predicted_move].Text = AI_Playing_Character;
            game.makeMove(predicted_move);

            foreach (int i in AvailableBoardLocations)
            {
                if(i != predicted_move) { GameBtnsList[i].Enabled = true; }
            }

            string tempBoard = game.getGameBoard();
            Console.WriteLine(tempBoard);
            char[] modifiedString = tempBoard.ToCharArray();
            modifiedString[8] = AI_Playing_Character.ToLower()[0];
            tempBoard = new string(modifiedString);

            if (!gameWinCheck()) { playerTurnSet(); }
        }
        private void resetGame()
        {
            foreach (Button btn in GameBtnsList)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            WinnerText.Text = "Winner:";
            game.currentPlayer = "X";
            playerTurnSet();
            game.clearBoard();
            if (PlayWithAI.Checked)
            {
                AI_play_first = !AI_play_first;
            }
            else
            {
                AI_play_first = false;
            }
            
            if (AI_play_first)
            {
                string init_board = "000000000";
                AI_Turn(init_board);
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        private bool gameWinCheck()
        {
            string winner;
            winner = game.GetGameWinner();
            if (winner == "X" || winner == "O" || winner == "Draw")
            {
                WinnerText.Text = "Winner: " + winner;
                TurnText.Text = "Turn: ";
                foreach (Button btn in GameBtnsList)
                {
                    btn.Enabled = false;
                }
                
                return true;
            }
            else
            {
                return false;
            }

        }
        private void playerTurnSet()
        {
            TurnText.Text = "Turn: " + game.currentPlayer;
        }

        private void PlayWithAI_CheckedChanged(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
