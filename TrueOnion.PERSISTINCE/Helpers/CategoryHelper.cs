using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Services;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Helpers
{
    public  class CategoryHelper
    {
        private readonly ICategoryService _categoryService;

        public CategoryHelper(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


    }
}