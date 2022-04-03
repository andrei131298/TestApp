using TestApp.Contexts;
using TestApp.Interfaces;
using TestApp.Models;

namespace TestApp.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {

        }
    }
}
