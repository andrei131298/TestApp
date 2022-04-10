using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Interfaces;
using TestApp.IServices;
using TestApp.Models;
using TestApp.Repositories;

namespace TestApp.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository productRepository)
        {
            _categoryRepository = productRepository;

        }

        public List<Category> GetAll(){
           return _categoryRepository.GetAll();
        }


        public List<Category> Create(Category category)
        {
            _categoryRepository.Create(category);
            _categoryRepository.SaveChanges();
            return _categoryRepository.GetAll();
        }
    }
}
