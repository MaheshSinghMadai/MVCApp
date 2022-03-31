using MVC.Data;
using MVC.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Service
{
    public class CategoryService : ICategoryService
    {
        //create an instance of the CategoryService
        private IRepository<Category> categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public Category GetCategoryById(long id)
        {
            return categoryRepository.GetById(id);
        }

        public void InsertCategory(Category category)
        {
            categoryRepository.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
        }

        public void DeleteCategory(long id)
        {
            Category c = new Category();

            //Get particular category by Id
            categoryRepository.GetById(id);

            ///delete and save changes
            categoryRepository.Remove(c);
            categoryRepository.SaveChanges();
        }
    }
}
