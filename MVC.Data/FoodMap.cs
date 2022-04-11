using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Data
{
    public class FoodMap
    {
        public FoodMap(EntityTypeBuilder<Food> entityBuilder)
        {
            entityBuilder.HasKey(t => t.FoodID);
            entityBuilder.Property(t => t.FoodName).IsRequired();
            
        }
    }
}
