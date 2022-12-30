using AutoMapper;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
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
            CreateMap<Product, ProductSaveVM>()
                .ForMember(dest => dest.SupplierIDs, act => act.MapFrom(src => src.ProductSuppliers.Select(x => x.Supplier).Select(x => x.ID)))
                .ForMember(dest => dest.ProductFeatureSaveVM, act => act.MapFrom(src => src.ProductFeature))
                .ReverseMap();
            CreateMap<ProductVM, ProductSaveVM>().ReverseMap();
            #endregion

            #region Category Mapping
            CreateMap<Category, CategorySaveVM>()
                     .ReverseMap();
            CreateMap<Category, CategoryVM>()
                      .ForMember(dest => dest.ProductVMs, act => act.MapFrom(src => src.Products))
                      .ForMember(dest => dest.Childreen, act => act.MapFrom(src => src.Children))
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
                     .ForMember(dest => dest.ProductSupplierVMs, act => act.MapFrom(src => src.ProductSuppliers))
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
            CreateMap<ProductSupplierVM, ProductSupplierSaveVM>()
                .ReverseMap();
            #endregion

        }
    }
}