using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Product Mapping
            CreateMap<Product, ProductVM>()
                    .ForMember(dest => dest.CategoryVM, act => act.MapFrom(src => src.Category))
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
        }
    }
}
