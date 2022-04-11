using System;

namespace MVC.Data
{
    public class Food 
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }

        public int CatId { get; set; }
        public Category Category { get; set; }
    }
}
