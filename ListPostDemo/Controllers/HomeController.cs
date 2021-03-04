using ListPostDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ListPostDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomePageViewModel vm = new HomePageViewModel();
            if (TempData["message"] != null)
            {
                vm.Message = (string) TempData["message"];
            }
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddFood(FoodItem item)
        {
            Console.WriteLine(item);
            return Redirect("/");
        }

        public IActionResult ViewMultipleForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMultipleFoods(List<FoodItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            TempData["message"] = "Food Items (maybe) added successfully!";
            return Redirect("/");
        }

        public IActionResult PostInts(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            TempData["message"] = "Numbers added successfully!";
            return Redirect("/");
        }
    }
}
