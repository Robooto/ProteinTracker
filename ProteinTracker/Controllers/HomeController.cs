using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProteinTracker.Models;
using ServiceStack.Redis;

namespace ProteinTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (IRedisClient client = new RedisClient())
            {
                var userClient = client.As<User>();
                var users = userClient.GetAll();
                var usersSelection = new SelectList(users, "Id", "Name", String.Empty);
                ViewBag.UserId = usersSelection;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}