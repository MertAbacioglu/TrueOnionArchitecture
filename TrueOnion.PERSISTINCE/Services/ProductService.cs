using AutoMapper;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Services
{
    public class ProductService : GenericService<ProductSaveVM, ProductVM, Product>,IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductSupplierService _productSupplierService;
        private readonly IProductFeatureService _productFeatureService;

        public ProductService(IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository, IProductSupplierService productSupplierService, IProductFeatureService productFeatureService, ISupplierService supplierService) : base(repository, mapper)
        {
            _productRepository = productRepository;
            _productSupplierService = productSupplierService;
            _productFeatureService = productFeatureService;
        }

        public async Task<Result<List<ProductVM>>> GetProducts()
        {
            List<Product> products = (await _productRepository.GetProducts()).ToList();
            List<ICollection<ProductSupplier>> a = products.Select(x => x.ProductSuppliers).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<ProductVM>>(products);
            return Result<List<ProductVM>>.Success(productVMs);
        }

        public async Task<Result<List<ProductVM>>> GetProductsByPriceRange(decimal min, decimal max)
        {
            List<Product> products = (await _productRepository.GetProductsByPriceRange(min, max)).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<ProductVM>>(products);
            return Result<List<ProductVM>>.Success(productVMs);

        }

        public override async Task<Result<ProductVM>> AddAsync(ProductSaveVM viewModel)
        {
            Product productToBeAdded = new();//product to be added

            ProductFeature productFeature = _mapper.Map<ProductFeature>(viewModel.ProductFeatureSaveVM);//product feature to be added


            Product added = await _repository.AddAsync(productToBeAdded);

            List<SupplierVM> suppliersToBeAdded = viewModel.SupplierVMs.Where(x => x.isSelected == true).ToList(); // supplierId's to be added

            
            List<ProductSupplierSaveVM> psToBeAdded = new(); //suppliers to be added to Product
            
            foreach (var item in suppliersToBeAdded)
                psToBeAdded.Add(new ProductSupplierSaveVM { SupplierID = item.ID, ProductID = added.ID });

            await _productSupplierService.AddRangeAsync(psToBeAdded);
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
            Product toBeUpdated = _productRepository.FindAsync(viewModel.ID).Result; //güncellenecek product

            List<ProductSupplierVM>? toBeDeleted = (await _productSupplierService.Where(x=>x.ProductID==viewModel.ID)).Data.ToList();//silinecek cross table kayitlari
            if(toBeDeleted!=null)
                await _productSupplierService.DestroyRangeAsync(toBeDeleted);//cross table kayitlari silindi

            if (viewModel.SupplierVMs!=null)
            {
                List<int> newSupplierIDs = viewModel.SupplierVMs.Where(x => x.isSelected == true).Select(x => x.ID).ToList();//eklenecek yeni supplier'larin ID listesi
                List<ProductSupplierSaveVM> psToBeAdded = new();
                List<ProductSupplierSaveVM> productsSuppliersToBeAdded = newSupplierIDs.Select(x => new ProductSupplierSaveVM { ProductID = viewModel.ID, SupplierID = x }).ToList();//eklenecek yeni supplier'larin ProductSupplierSaveVM listesi
                await _productSupplierService.AddRangeAsync(productsSuppliersToBeAdded);
            }


        }

        public override async Task DeleteAsync(int id)
        {
            Product entityToBeDeleted = await _productRepository.FindAsync(id);
            
            await _repository.DeleteAsync(entityToBeDeleted);//make product deleted
            
            ProductFeatureSaveVM? pfToBeDeleted = (await _productFeatureService.FindAsync(entityToBeDeleted.ID)).Data;
            if (pfToBeDeleted != null)
                await _productFeatureService.DeleteAsync(pfToBeDeleted.ID);//make product feature deleted
            
            List<ProductSupplierVM>? psToBeDeleted = (await _productSupplierService.Where(x => x.ProductID == id)).Data;
            
            if (psToBeDeleted != null)
                await _productSupplierService.DestroyRangeAsync(psToBeDeleted);//destroy cross table datas related this product

        }
    }
}