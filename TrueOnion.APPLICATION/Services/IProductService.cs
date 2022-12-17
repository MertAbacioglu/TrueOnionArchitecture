using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.APPLICATION.Services
{
    public interface IProductService : IGenericService<ProductSaveVM, ProductVM, Product>
    {
        public Task<Result<List<ProductVM>>> GetProductsWithCategory();
    }
}
