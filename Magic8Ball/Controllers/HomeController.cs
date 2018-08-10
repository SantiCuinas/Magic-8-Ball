using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Magic8Ball.Models;

namespace Magic8Ball.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] answers = new string[5];
            answers[0] = "Yes";
            answers[1] = "No";
            answers[2] = "Maybe";
            answers[3] = "I don't know";
            answers[4] = "Ask later";



            Random random = new Random();
            int num = random.Next(0, 5);
            ViewData["Answer"] = answers[num];

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
