using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// When a player submits their turn it will hit this endpoint
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="playerId"></param>
        /// <param name="moves"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ReceiveTurn(int gameId, int playerId, List<int[]> moves)
        {
            return Json(true);
        }

        /// <summary>
        /// This will be called when 
        /// </summary>
        public JsonResult FetchGameState(int GameId)
        {
            return null;
        }
    }
}