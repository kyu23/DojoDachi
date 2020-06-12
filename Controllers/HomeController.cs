using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        public static Dojodachi x = new Dojodachi();

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Fullness = x.Fullness;
            ViewBag.Happiness = x.Happiness;
            ViewBag.Meals = x.Meals;
            ViewBag.Energy = x.Energy;
            ViewBag.Photo = x.Photo;
            return View(x);
        }

        [HttpPost("GoDachi")]
        public IActionResult GoDachi(string activity)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine(activity);
            }
            
            if(activity.Equals("Feed"))
            {
                Console.WriteLine("1111111111111");
                x.Feed();
            }

            switch( activity )
            {
                case "Sleep":
                    x.Sleep();
                    break;
                case "Feed":
                    Console.WriteLine("1111111111111");
                    
                    break;
                case "Play":
                    x.Play();
                    break;
                case "Work":
                    x.Work();
                    break;
            }
            return RedirectToAction("Index");
        }

    }
}
