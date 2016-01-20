using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;

namespace ProteinTracker.Controllers
{
    public class LeaderboardController : Controller
    {
        // GET: Leaderboard
        public ActionResult Index()
        {
            using (IRedisClient client = new RedisClient())
            {
                var leaderboard = client.GetAllWithScoresFromSortedSet("urn:leaderboard");
                ViewBag.leaders = leaderboard.OrderByDescending(x => x.Value);
            }

            return View();
        }
    }
}