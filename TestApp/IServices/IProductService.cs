using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.IServices
{
    public interface IProductService
    {
        List<Product> Create(Product product);

        List<Product> GetAll();

        Product GetById(Guid id);
    }
}
