using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaChessDEMO.Service
{
   public interface ISeaChessGame
   {
       public void CellSelectedAction(int i, int j);
       public void ClearGame(); 
       public bool GameIsFinished();
       public bool isCellEmpty(int row, int col);
       public bool checkForWinner();
       public bool CellsIsFull();
       public bool IsWinner(string player);
       public int ClickCount ();
   }
}
