using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface IProductService : IGenericService<Product, CreateProductViewModel, UpdateProductViewModel, ProductViewModel>
    {
    }
}
