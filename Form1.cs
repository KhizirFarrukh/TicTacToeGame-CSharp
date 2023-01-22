using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        List<Button> GameBtnsList = new List<Button>();
        Game game = new Game("000000000", "X", "O");
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
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc2_Click(object sender, EventArgs e)
        {
            BtnLoc2.Enabled = false;
            BtnLoc2.Text = game.currentPlayer;
            game.makeMove(1);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc3_Click(object sender, EventArgs e)
        {
            BtnLoc3.Enabled = false;
            BtnLoc3.Text = game.currentPlayer;
            game.makeMove(2);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc4_Click(object sender, EventArgs e)
        {
            BtnLoc4.Enabled = false;
            BtnLoc4.Text = game.currentPlayer;
            game.makeMove(3);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc5_Click(object sender, EventArgs e)
        {
            BtnLoc5.Enabled = false;
            BtnLoc5.Text = game.currentPlayer;
            game.makeMove(4);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc6_Click(object sender, EventArgs e)
        {
            BtnLoc6.Enabled = false;
            BtnLoc6.Text = game.currentPlayer;
            game.makeMove(5);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc7_Click(object sender, EventArgs e)
        {
            BtnLoc7.Enabled = false;
            BtnLoc7.Text = game.currentPlayer;
            game.makeMove(6);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc8_Click(object sender, EventArgs e)
        {
            BtnLoc8.Enabled = false;
            BtnLoc8.Text = game.currentPlayer;
            game.makeMove(7);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void BtnLoc9_Click(object sender, EventArgs e)
        {
            BtnLoc9.Enabled = false;
            BtnLoc9.Text = game.currentPlayer;
            game.makeMove(8);
             
            if (!gameWinCheck()) { playerTurnSet(); }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            foreach(Button btn in GameBtnsList)
            {
                btn.Text = "";
                btn.Enabled = true;
                btn.ForeColor = Color.Black;
            }
            TurnText.Text = "Turn:";
            WinnerText.Text = "Winner:";
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
    }
}
