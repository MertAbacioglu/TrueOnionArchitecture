using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.APPLICATION.Services
{
    public interface ICategoryService : IGenericService<CategorySaveVM, CategoryVM, Category>
    {
    }
}
