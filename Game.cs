using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private string GameBoard;
        private string player1Char;
        private string player2Char;
        public string currentPlayer;
        public Game(string GameBoard, string player1Char, string player2Char)
        {
            this.GameBoard = GameBoard;
            this.player1Char = player1Char;
            this.player2Char = player2Char;
            currentPlayer = this.player1Char;
        }
        public string getGameBoard() { return GameBoard; }
        public void makeMove(int pos)
        {
            char[] modifiedString = GameBoard.ToCharArray();
            modifiedString[pos] = currentPlayer[0];
            GameBoard = new string(modifiedString);
            if (currentPlayer == player1Char) { currentPlayer = player2Char; }
            else { currentPlayer = player1Char; }
        }
        public string GetGameWinner()
        {
            Console.WriteLine(GameBoard);
            // Check rows
            for (int i = 0; i < 9; i += 3)
            {
                if (GameBoard[i] == GameBoard[i + 1] && GameBoard[i + 1] == GameBoard[i + 2] && GameBoard[i] != '0')
                {
                    Console.WriteLine("The winner is " + GameBoard[i]);
                    return GameBoard[i].ToString();
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (GameBoard[i] == GameBoard[i + 3] && GameBoard[i + 3] == GameBoard[i + 6] && GameBoard[i] != '0')
                {
                    Console.WriteLine("The winner is " + GameBoard[i]);
                    return GameBoard[i].ToString();
                }
            }

            // Check diagonals
            if (GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8] && GameBoard[0] != '0')
            {
                Console.WriteLine("The winner is " + GameBoard[0]);
                return GameBoard[0].ToString();
            }
            if (GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6] && GameBoard[2] != '0')
            {
                Console.WriteLine("The winner is " + GameBoard[2]);
                return GameBoard[2].ToString();
            }
            bool isDraw = true;
            foreach(char c in GameBoard)
            {
                if(c == '0') { isDraw = false; break; }
            }
            if(isDraw) { return "Draw"; }
            return "";
        }
        public void resetGame(string GameBoard)
        {
            this.GameBoard = GameBoard;
            currentPlayer = this.player1Char;
        }
    };
}
