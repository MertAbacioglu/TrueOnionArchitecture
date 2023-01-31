using AutoMapper;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.INFRASTRUCTURE.INNER.Services
{
    public class ProductService : GenericService<ProductSaveVM, ProductVM, Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductSupplierRepository _productSupplierRepository;
        private readonly IProductSupplierService _productSupplierService;
        private readonly IProductFeatureService _productFeatureService;
        private readonly ICategoryService _categoryService;

        public ProductService(IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository, IProductSupplierService productSupplierService, IProductFeatureService productFeatureService, ISupplierService supplierService, ICategoryService categoryService, IProductSupplierRepository productSupplierRepository) : base(repository, mapper)
        {
            _productRepository = productRepository;
            _productSupplierService = productSupplierService;
            _productFeatureService = productFeatureService;
            _categoryService = categoryService;
            _productSupplierRepository = productSupplierRepository;
        }

        public async Task<ProductListVM> GetProducts()
        {
            List<Product> products = (await _productRepository.GetProducts()).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<ProductVM>>(products);
            Result<List<ProductVM>> result = Result<List<ProductVM>>.Success(productVMs);
            return new ProductListVM { Result = result };
        }

        public override async Task<Result<ProductVM>> AddAsync(ProductSaveVM viewModel)
        {
            Product productToBeAdded = _mapper.Map<Product>(viewModel);


            List<ProductSupplierVM> psuppliersToBeAdded = viewModel.ProductSupplierVMs.Where(x => x.isSelected == true).ToList();
            productToBeAdded.ProductSuppliers = _mapper.Map<List<ProductSupplier>>(psuppliersToBeAdded);
            Product added = await _repository.AddAsync(productToBeAdded);
            return Result<ProductVM>.Success(_mapper.Map<ProductVM>(added));
        }

        public async Task<Result<ProductSaveVM>> GetProduct(int id)
        {
            Product product = await _productRepository.GetProduct(id);
            ProductSaveVM psVM = _mapper.Map<ProductSaveVM>(product);
            return Result<ProductSaveVM>.Success(psVM);
        }

        public override async Task UpdateAsync(ProductSaveVM viewModel)
        {
            Product pro = _mapper.Map<Product>(viewModel); //güncellenecek product
            pro.ProductFeature = _mapper.Map<ProductFeature>(viewModel.ProductFeatureSaveVM);
            pro.ProductFeature.Id = viewModel.Id;
            List<ProductSupplierVM>? toBeDeleted = (await _productSupplierService.Where(x => x.ProductId == viewModel.Id)).Data;

            if (toBeDeleted != null)
                await _productSupplierService.DestroyRangeAsync(toBeDeleted);//cross table kayitlari silindi

            List<ProductSupplierVM> newPSList = viewModel.AllProductSupplierVMs.Where(x => x.isSelected == true).ToList();
            pro.ProductSuppliers = _mapper.Map<List<ProductSupplier>>(newPSList);
            await _productRepository.UpdateAsync(pro);

        }

        public override async Task DeleteAsync(int id)
        {
            Product entityToBeDeleted = await _productRepository.FindAsync(id);

            await _repository.DeleteAsync(entityToBeDeleted);//make product deleted

            ProductFeatureSaveVM? pfToBeDeleted = (await _productFeatureService.FindAsync(entityToBeDeleted.Id)).Data;
            if (pfToBeDeleted != null)
                await _productFeatureService.DeleteAsync(pfToBeDeleted.Id);//make product feature deleted

            List<ProductSupplierVM>? psToBeDeleted = (await _productSupplierService.Where(x => x.ProductId == id)).Data;

            if (psToBeDeleted != null)
                await _productSupplierService.DestroyRangeAsync(psToBeDeleted);//destroy cross table datas related this product

        }

        public async Task<ProductListVM> GetProductsByCount(int count)
        {
            List<Product> products = (await _productRepository.GetProductsByCount(count)).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<ProductVM>>(products);
            Result<List<ProductVM>> result = Result<List<ProductVM>>.Success(productVMs);
            return new ProductListVM { Result = result };


        }
    }
}