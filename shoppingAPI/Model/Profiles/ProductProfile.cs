using AutoMapper;
using shoppingAPI.Data.Entity;

namespace shoppingAPI.Model.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductModels>()
                .ForMember(p => p.Quantities, x => x.MapFrom(t => t.Quantity.Quantities))
                .ForMember(p => p.Branch, x => x.MapFrom(t => t.Branch.BranchName))
                .ForMember(p => p.Brand, x => x.MapFrom(t => t.Brand.BrandName))
                .ForMember(p => p.Category, x => x.MapFrom(t => t.Branch.Category.CategoryName))
                .ForMember(p => p.Spectification, x => x.MapFrom(t => t.Specification))
                .ForMember(p => p.ProductDescription, x => x.MapFrom(t => t.ProductDescription)).ReverseMap();
        }
    }
}