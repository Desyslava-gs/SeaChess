using static SeaChessDEMO.Models.Constants;
namespace SeaChessDEMO.Models
{
    public class SeaChessModel
    {
        public string[,] GameMatrix { get; set; }
        public string Player { get; set; } 
        public string PlayerWin { get; set; }
        public int ClickCount { get; set; } = 0;

        public SeaChessModel()
        {
            GameMatrix = new string[3, 3];
        }

        public void ClearGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameMatrix[i, j] = string.Empty;
                }
            }
            ClickCount = 0;
            Player = o;
        }

        public void CellAction(int i, int j)
        {
            if (CellIsEmpty(i, j) == false)
            {
                return;
            }
            if (ClickCount % 2 == 0)
            {
                GameMatrix[i, j] = x;
                Player = o;
                IsWinner();
            }
            else
            {
                GameMatrix[i, j] = o;
                Player = x;
                IsWinner();
            }
        }
        private bool CellIsEmpty(int row, int col)
        {
            if (string.IsNullOrEmpty(GameMatrix[row, col]))
            {
                return true;
            }
            return false;
        }
        private bool IsWinner()
        {
            bool gameFinished = false;
           
            if (IsWinner(x))
            {
                PlayerWin = x;
                gameFinished = true;
            }
            else if (IsWinner(o))
            {
                PlayerWin = o;
                gameFinished = true;
            }
            else if (CellsIsFull())
            {
                gameFinished = true;
            }
            else
            {
                PlayerWin = "";
            }
            if (gameFinished)
            {
                ClearGame();
                return true;
            }
            return false;
        }
        private bool CellsIsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(GameMatrix[i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool IsWinner(string player)
        {
            //row
            if ((GameMatrix[0, 0] == player) && (GameMatrix[0, 1] == player) && (GameMatrix[0, 2] == player))
            {
                return true;
            }
            if ((GameMatrix[1, 0] == player) && (GameMatrix[1, 1] == player) && (GameMatrix[1, 2] == player))
            {
                return true;
            }
            if ((GameMatrix[2, 0] == player) && (GameMatrix[2, 1] == player) && (GameMatrix[2, 2] == player))
            {
                return true;
            }
            // col
            if ((GameMatrix[0, 0] == player) && (GameMatrix[1, 0] == player) && (GameMatrix[2, 0] == player))
            {
                return true;
            }
            if ((GameMatrix[0, 1] == player) && (GameMatrix[1, 1] == player) && (GameMatrix[2, 1] == player))
            {
                return true;
            }
            if ((GameMatrix[0, 2] == player) && (GameMatrix[1, 2] == player) && (GameMatrix[2, 2] == player))
            {
                return true;
            }
            // diagonal
            if ((GameMatrix[0, 0] == player) && (GameMatrix[1, 1] == player) && (GameMatrix[2, 2] == player))
            {
                return true;
            }
            if ((GameMatrix[0, 2] == player) && (GameMatrix[1, 1] == player) && (GameMatrix[2, 0] == player))
            {
                return true;
            }

            return false;
        }
    }
}
