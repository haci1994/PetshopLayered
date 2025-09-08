using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class ProductService : GenericService<Product, CreateProductViewModel, UpdateProductViewModel, ProductViewModel>, IProductService
    {
        public ProductService(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
