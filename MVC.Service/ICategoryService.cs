using MVC.Data;
using System;
using System.Collections.Generic;

namespace MVC.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(long id);

        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(long id);

    }
}
