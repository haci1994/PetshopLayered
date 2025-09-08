using AutoMapper;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryViewModel>().ReverseMap();
            CreateMap<Category, UpdateCategoryViewModel>().ReverseMap();

            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Product, CreateProductViewModel>().ReverseMap();
            CreateMap<Product, UpdateProductViewModel>().ReverseMap();

            //CreateMap<ProductImage, ProductImageViewModel>().ReverseMap();  
            //CreateMap<ProductImage, CreateProductImageViewModel>().ReverseMap();
            //CreateMap<ProductImage, UpdateProductImageViewModel>().ReverseMap();

            //CreateMap<ProductTag, ProductTagViewModel>().ReverseMap();
            //CreateMap<ProductTag, CreateProductTagViewModel>().ReverseMap();
            //CreateMap<ProductTag, UpdateProductTagViewModel>().ReverseMap();

            CreateMap<Tag, TagViewModel>().ReverseMap();
            CreateMap<Tag, CreateTagViewModel>().ReverseMap();
            CreateMap<Tag, UpdateTagViewModel>().ReverseMap();

            CreateMap<Review, ReviewViewModel>().ReverseMap();
            CreateMap<Review, CreateReviewViewModel>().ReverseMap();
            CreateMap<Review, UpdateReviewViewModel>().ReverseMap();

            CreateMap<SiteInfo, SiteInfoViewModel>()
                .ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.LogoUrl))
                .ReverseMap();
            CreateMap<SiteInfo, CreateSiteInfoViewModel>()
                .ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.LogoUrl))
                .ReverseMap();
            CreateMap<SiteInfo, UpdateSiteInfoViewModel>()
                .ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.LogoUrl))
                .ReverseMap();

            CreateMap<Social, SocialViewModel>().ReverseMap();
            CreateMap<Social, CreateSocialViewModel>().ReverseMap();
            CreateMap<Social, UpdateSocialViewModel>().ReverseMap();

            CreateMap<Slide, SlideViewModel>().ReverseMap();
            CreateMap<Slide, CreateSlideViewModel>().ReverseMap();
            CreateMap<Slide, UpdateSlideViewModel>().ReverseMap();
        }
    }
}
