using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.IServices
{
    public interface ICategoryService
    {
        List<Category> Create(Category category);

    }
}
