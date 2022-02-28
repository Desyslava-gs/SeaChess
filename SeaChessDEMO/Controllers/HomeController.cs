using Microsoft.AspNetCore.Mvc;
using SeaChessDEMO.Models;

namespace SeaChessDEMO.Controllers
{
    public class HomeController : Controller
    {
        public static SeaChessModel game;

        public ActionResult Index()
        {
            if (game == null)
            {
                game = new SeaChessModel();
            }
            ViewData["Game"] = game;
            return View();
        }
        public ActionResult CellOnClick(int row, int col)
        {
            game.ClickCount = game.ClickCount + 1;
            game.CellAction(row, col);
            ViewData["Game"] = game;
            return View("Index");
        }
       
    }
}
