using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGitExaple.Models;

namespace WebAppGitExaple.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<Player> players = new List<Player>()
            {
                new Player{PId=1,PName="Ravi",PTeam="CSK"},
                new Player{PId=2,PName="Dinesh",PTeam="Mi"},
                new Player{PId=3,PName="Pramod",PTeam="Delhi"}
            };
            return View();
        }
    }
}