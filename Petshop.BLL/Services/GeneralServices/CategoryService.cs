using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class CategoryService : GenericService<Category, CreateCategoryViewModel, UpdateCategoryViewModel, CategoryViewModel>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
