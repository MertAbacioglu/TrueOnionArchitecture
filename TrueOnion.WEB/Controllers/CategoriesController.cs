﻿using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            Result<List<CategoryVM>> categorVMs = (await _categoryService.GetActives());
            CategoryListVM categoryListVM = new() { Result = categorVMs };

            return View(categoryListVM);
            
        }
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategorySaveVM viewModel)
        {
            await _categoryService.AddAsync(viewModel);
            return RedirectToAction("Index");
        }
        
        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Update(int id)
        {
            CategorySaveVM? categorySaveVM = (await _categoryService.FindAsync(id)).Data;
            return View(categorySaveVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategorySaveVM viewModel)
        {
            await _categoryService.UpdateAsync(viewModel);
            return RedirectToAction("Index");
        }
        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Remove(int id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}