using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<Category> GetMainCategoryWithAllChildren();        
        public Task<Category> GetSpesificCategoryWithChildren(int id);
        public Task<List<Category>> GetChildrensChildren(Category category);

    }
}