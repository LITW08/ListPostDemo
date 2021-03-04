using System;

namespace ListPostDemo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class HomePageViewModel
    {
        public string Message { get; set; }
    }
    
    public class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CalorieCount { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C} - {CalorieCount}";
        }
    }
}
