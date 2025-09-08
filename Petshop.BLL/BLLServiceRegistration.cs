using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.Services.GeneralServices;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Repositories;
using Petshop.DAL.DataContext.Repositories.Contracts;
using AutoMapper;
using Petshop.BLL.Mapping;
using Petshop.BLL.Services.WebsiteServices;

namespace Petshop.BLL
{
    public static class BLLServiceRegistration
    {
        public static IServiceCollection BllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
               opt.UseSqlServer(
                   configuration.GetConnectionString("Default"),
                   sql => sql.MigrationsAssembly("Petshop.DAL"))); // aydın yazılış

            services.AddScoped<DataInitializer>();            

            services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));

            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            services.AddScoped(typeof(IGenericService<,,,>), typeof(GenericService<,,,>));

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ITagService, TagService>();
            //services.AddScoped<IProductTagService, ProductTagService>();
            //services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ISiteInfoService, SiteInfoService>();
            services.AddScoped<ISocialService, SocialService>();
            services.AddScoped<ISlideService, SlideService>();
            services.AddScoped<HomeService>();

            return services;
        }
    }
}
