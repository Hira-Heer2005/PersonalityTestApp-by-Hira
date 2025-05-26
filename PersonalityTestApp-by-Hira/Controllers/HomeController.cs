using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalityTestApp_by_Hira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Result(string choice)
        {
            string personality = "";

            switch (choice)
            {
                case "sun":
                    personality = "You are energetic and optimistic!";
                    break;
                case "moon":
                    personality = "You are calm and introspective.";
                    break;
                case "tree":
                    personality = "You are grounded and nurturing.";
                    break;
                case "ocean":
                    personality = "You are deep and imaginative.";
                    break;
                default:
                    personality = "Please select a valid option.";
                    break;
            }

            ViewBag.Result = personality;
            return View();
        }

    }
}