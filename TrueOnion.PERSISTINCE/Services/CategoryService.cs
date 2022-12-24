using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Services
{
    public class CategoryService : GenericService<CategorySaveVM, CategoryVM, Category>, ICategoryService
    {
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
