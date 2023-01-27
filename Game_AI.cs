using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game_AI
    {
        char[,] board = { { '\0', '\0', '\0' }, { '\0', '\0', '\0' }, { '\0', '\0', '\0' } };
        char Player1Char, Player2Char, emptyChar;
        public Game_AI(char p1, char p2)
        {
            Player1Char = p1;
            Player2Char = p2;
            emptyChar = ' ';
        }
        private void boardNormalize(string inputBoard)
        {
            int count = 0;

            foreach(char boardChr in inputBoard)
            {
                if(boardChr == Player1Char || boardChr == Player2Char)
                {
                    board[(int)(count / 3),count % 3] = boardChr;
                }
                else
                {
                    board[(int)(count / 3), count % 3] = emptyChar;
                }
                count += 1;
            }
        }
        private char check_winner(char[,] boardCopy)
        {
            for(int i = 0; i < 3; i++)
            {
                if(boardCopy[i,0] == boardCopy[i,1] && boardCopy[i,1] == boardCopy[i,2] && boardCopy[i,0] != emptyChar)
                {
                    return boardCopy[i,0];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (boardCopy[0,i] == boardCopy[1,i] && boardCopy[1,i] == boardCopy[2,i] && boardCopy[0,i] != emptyChar)
                {
                    return boardCopy[0,i];
                }
            }
            if (boardCopy[0,0] == boardCopy[1,1] && boardCopy[1,1] == boardCopy[2,2] && boardCopy[0,0] != emptyChar)
            {
                return boardCopy[0,0];
            }
            if (boardCopy[0,2] == boardCopy[1,1] && boardCopy[1,1] == boardCopy[2,0] && boardCopy[0,2] != emptyChar)
            {
                return boardCopy[0,2];
            }
            return '\0';
        }
        private bool isDraw(char[,] boardCopy)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (boardCopy[i,j] != emptyChar)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private int minimax(char[,] boardCopy, char AI_char)
        {
            char winner = check_winner(boardCopy);
            if(winner != '\0')
            {
                if(winner == Player1Char)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            
            if(isDraw(boardCopy))
            {
                return 0;
            }

            int best_score = 0, score = 0;
            char otherPlayerChar = '\0';
            if (AI_char == Player1Char)
            {
                best_score = Int32.MinValue;
                otherPlayerChar = Player2Char;
            }
            else if (AI_char == Player2Char)
            {
                best_score = Int32.MaxValue;
                otherPlayerChar = Player1Char;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (boardCopy[i,j] == emptyChar)
                    {
                        boardCopy[i, j] = AI_char;
                        score = minimax(boardCopy, otherPlayerChar);
                        boardCopy[i, j] = emptyChar;
                        if (AI_char == Player1Char)
                        {
                            best_score = Math.Max(best_score, score);
                        }
                        else
                        {
                            best_score = Math.Min(best_score, score);
                        }
                    }
                }
            }
            return best_score;
        }
        private Tuple<int,int> get_best_move(char AI_char)
        {
            int best_score = 0, score = 0;
            char otherPlayerChar = '\0';
            if(AI_char == Player1Char)
            {
                best_score = Int32.MinValue;
                otherPlayerChar = Player2Char;
            }
            else if(AI_char == Player2Char)
            {
                best_score = Int32.MaxValue;
                otherPlayerChar = Player1Char;
            }

            Tuple<int, int> best_move = null;
            char[,] boardCopy = (char[,])board.Clone();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(boardCopy[i,j] == emptyChar)
                    {
                        boardCopy[i, j] = AI_char;
                        score = minimax(boardCopy, otherPlayerChar);
                        boardCopy[i, j] = emptyChar;
                        if(AI_char == Player1Char)
                        {
                            if(score > best_score)
                            {
                                best_score = score;
                                best_move = new Tuple<int, int>(i, j);
                            }
                        }
                        else
                        {
                            if (score < best_score)
                            {
                                best_score = score;
                                best_move = new Tuple<int, int>(i, j);
                            }
                        }
                    }
                }
            }
            return best_move;
        }
        public int NextMove(string inputBoard, char AI_char)
        {
            boardNormalize(inputBoard);
            Tuple<int, int> best_move = get_best_move(AI_char);
            return (best_move.Item1 * 3) + best_move.Item2;
        }
    }
}
