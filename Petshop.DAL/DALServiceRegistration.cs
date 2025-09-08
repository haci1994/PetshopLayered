using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Repositories;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.DAL
{
    //public static class DALServiceRegistration
    //{
    //    public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
    //    {
    //        services.AddDbContext<AppDbContext>(options =>
    //            options.UseSqlServer(configuration.GetConnectionString("Default"), options =>
    //            {
    //                options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
    //            }));

    //        services.AddScoped<DataInitializer>();

    //        services.AddScoped(typeof(IRepository<>),typeof(EfCoreRepository<>));

    //        services.AddScoped<ICategoryRepository, CategoryRepository>();
    //        services.AddScoped<IProductRepository, ProductRepository>();
    //        services.AddScoped<ITagRepository, TagRepository>();
    //        services.AddScoped<IProductTagRepository, ProductTagRepository>();
    //        services.AddScoped<IProductImageRepository, ProductImageRepository>();
    //        services.AddScoped<IReviewRepository, ReviewRepository>();
    //        services.AddScoped<ISiteInfoRepository, SiteInfoRepository>();
    //        services.AddScoped<ISocialRepository, SocialRepository>();
    //        services.AddScoped<ISlideRepository, SlideRepository>();

    //        return services;
    //    }
    //}
}
