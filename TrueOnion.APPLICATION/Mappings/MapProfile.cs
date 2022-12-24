using AutoMapper;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Mapping
{
    public sealed class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Product Mapping
            CreateMap<Product, ProductVM>()
                    .ForMember(dest => dest.CategoryVM, act => act.MapFrom(src => src.Category))
                    .ForMember(dest => dest.ProductFeatureVM, act => act.MapFrom(src => src.ProductFeature))
                    .ForMember(dest => dest.ProductSupplierVMs, act => act.MapFrom(src => src.ProductSuppliers))
                    .ReverseMap();
            CreateMap<Product, ProductSaveVM>().ReverseMap();
            CreateMap<ProductVM, ProductSaveVM>().ReverseMap();
            #endregion

            #region Category Mapping
            CreateMap<Category, CategorySaveVM>()
                     .ReverseMap();
            CreateMap<Category, CategoryVM>()
                      .ForMember(dest => dest.ProductVMs, act => act.MapFrom(src => src.Products))
                      .ReverseMap();
            #endregion

            #region ProductFeature Mapping
            CreateMap<ProductFeature, ProductFeatureVM>()
                    .ReverseMap();
            CreateMap<ProductFeature, ProductFeatureSaveVM>()
                .ReverseMap();
            #endregion

            #region Supplier Mapping
            CreateMap<Supplier, SupplierVM>()
                     .ReverseMap();
            CreateMap<Supplier, SupplierSaveVM>()
                    .ReverseMap(); ;
            #endregion

            #region ProductSupplier Mapping
            CreateMap<ProductSupplier, ProductSupplierVM>()
                     .ForMember(dest => dest.ProductVM, act => act.MapFrom(src => src.Product))
                     .ForMember(dest => dest.SupplierVM, act => act.MapFrom(src => src.Supplier))
                     .ReverseMap();
            CreateMap<ProductSupplier, ProductSupplierSaveVM>()
                .ReverseMap();
            #endregion



        }
    }
}