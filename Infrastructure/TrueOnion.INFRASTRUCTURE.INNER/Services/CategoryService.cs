using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.INFRASTRUCTURE.INNER
{
    public class CategoryService : GenericService<CategorySaveVM, CategoryVM, Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, mapper)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryListVM> GetCategories()//redundant
        {
            Result<List<CategoryVM>> categorVMs = await GetActives();
            CategoryListVM categoryListVM = new() { Result = categorVMs };
            return categoryListVM;
        }

        public async Task<CategoryVM> GetCategoriesWithChildren()
        {
            Category category = (await _categoryRepository.GetMainCategoryWithAllChildren());
            foreach (Category child in category.Children)
                await GetChildrensChildren(child);

            CategoryVM categoryVM = _mapper.Map<CategoryVM>(category);

            return categoryVM;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">PARENT ID</param>
        /// <returns></returns>
        public async Task<Category> GetCategoryWithChildren(int id)
        {
            Category category = (await _categoryRepository.GetSpesificCategoryWithChildren(id));
            foreach (Category child in category.Children)
                await GetChildrensChildren(child);


            return category;
        }
        public async Task GetChildrensChildren(Category category)
        {
            category.Children = await _categoryRepository.GetChildrensChildren(category);
            foreach (Category child in category.Children)
                await GetChildrensChildren(child);
        }

    }
}