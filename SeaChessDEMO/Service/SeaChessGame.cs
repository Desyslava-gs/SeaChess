//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Media;
//using System.Threading.Tasks;
//using SeaChessDEMO.Models;

//namespace SeaChessDEMO.Service
//{
//    public class SeaChessGame : ISeaChessGame
//    {
//        private readonly SeaChessModel game;

//          public SeaChessGame(SeaChessModel game)
//          {
//             this.game = game;
//          }
        
//          public void ClearGame()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    game.GameMatrix[i, j] = "";
//                }
//            }

//            game.ClickCount = 0;
//            game.Player = game.PlayerO;
//        }

//        public void CellSelectedAction(int i, int j)
//        {
//            // if cell selected NO action 
//            if (isCellEmpty(i, j) == false)
//            {
//                return;
//            }
//            // if cell empty, get value Player
//            if (game.ClickCount % 2 == 0)
//            {
//                game.GameMatrix[i, j] = game.PlayerX;
//                game.Player = game.PlayerO;
//                checkForWinner();
//            }
//            else
//            {
//               game.GameMatrix[i, j] = game.PlayerO;
//                game.Player = game.PlayerX;
//                checkForWinner();
//            }
//        }

//        public bool GameIsFinished()
//        {
//            if (IsWinner(game.PlayerX))
//            {
//                return true;
//            }
//            else if (IsWinner(game.PlayerO))
//            {
//                return true;
//            }
//            else if (CellsIsFull())
//            {
//                return true;
//            }
//            return false;
//        }

//        public bool isCellEmpty(int row, int col)
//        {
//            if (string.IsNullOrEmpty(game.GameMatrix[row, col]))
//            {
//                return true;
//            }
//            return false;
//        }

//        public bool checkForWinner()
//        {
//            bool gameFinished = false;
           
//            if (IsWinner(game.PlayerX))
//            {
//                game.PlayerWin = game.PlayerX;
//                gameFinished = true;
//            }
//            else if (IsWinner(game.PlayerO))
//            {
//                game.PlayerWin = game.PlayerO;
//                gameFinished = true;
//            }
//            else if (CellsIsFull())
//            {
//                gameFinished = true;
//            }
//            if (gameFinished)
//            {
//                ClearGame();
//                return true;
//            }
//            return false;
//        }

//        public bool CellsIsFull()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (string.IsNullOrEmpty(game.GameMatrix[i, j]))
//                    {
//                        return false;
//                    }
//                }
//            }
//            return true;
//        }

//        public bool IsWinner(string player)
//        {
//            //row
//            if ((game.GameMatrix[0, 0] == player) && (game.GameMatrix[0, 1] == player) && (game.GameMatrix[0, 2] == player))
//            {
//                return true;
//            }
//            if ((game.GameMatrix[1, 0] == player) && (game.GameMatrix[1, 1] == player) && (game.GameMatrix[1, 2] == player))
//            {
//                return true;
//            }
//            if ((game.GameMatrix[2, 0] == player) && (game.GameMatrix[2, 1] == player) && (game.GameMatrix[2, 2] == player))
//            {
//                return true;
//            }

//            // col
//            if ((game.GameMatrix[0, 0] == player) && (game.GameMatrix[1, 0] == player) && (game.GameMatrix[2, 0] == player))
//            {
//                return true;
//            }
//            if ((game.GameMatrix[0, 1] == player) && (game.GameMatrix[1, 1] == player) && (game.GameMatrix[2, 1] == player))
//            {
//                return true;
//            }
//            if ((game.GameMatrix[0, 2] == player) && (game.GameMatrix[1, 2] == player) && (game.GameMatrix[2, 2] == player))
//            {
//                return true;
//            }
            
//            // diagonal
//            if ((game.GameMatrix[0, 0] == player) && (game.GameMatrix[1, 1] == player) && (game.GameMatrix[2, 2] == player))
//            {
//                return true;
//            }
//            if ((game.GameMatrix[0, 2] == player) && (game.GameMatrix[1, 1] == player) && (game.GameMatrix[2, 0] == player))
//            {
//                return true;
//            }
          
//            return false;
//        }

//        public int ClickCount()
//        {
//            return game.ClickCount;
//        }
//    }
//}
