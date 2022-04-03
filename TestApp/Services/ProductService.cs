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
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            
        }

        public List<Product> Create(Product product)
        {
            _productRepository.Create(product);
            _productRepository.SaveChanges();
            return _productRepository.GetAll();
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();

        }

        public Product GetById(Guid id)
        {
            return _productRepository.FindById(id);
        }
    }
}
