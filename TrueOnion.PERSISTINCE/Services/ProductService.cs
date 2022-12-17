﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.PERSISTINCE.Services
{
    public class ProductService : GenericService<ProductSaveVM, ProductVM, Product>,IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository) : base(repository, mapper)
        {
            _productRepository = productRepository;

        }

        public async Task<Result<List<ProductVM>>> GetProductsWithCategory()
        {
            List<Product> products = (await _productRepository.GetProductsWithCategory()).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<ProductVM>>(products);
            return Result<List<ProductVM>>.Success(StatusCodes.Status200OK, productVMs);
        }
    }
}