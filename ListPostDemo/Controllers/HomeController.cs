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


//create an mvc application that displays a list of people. On top of the list
//have a link that takes you to a page that allows the user to enter multiple
//people. When that page loads, there should be one row of textboxes (first name,
//lastname and age) with a button on top that says "Add". When Add is clicked,
//another row of textboxes should appear. Beneath those textboxes, there should
//be a submit button, that when clicked, adds all those people to the database
//and then redirects the user back to the home page.