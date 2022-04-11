using System;
using System.Collections.Generic;

namespace MVC.Data
{
    public class Category
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }    
        public ICollection<Food> Food { get; set; }
    }
}
