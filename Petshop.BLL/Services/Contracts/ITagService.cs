using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface ITagService : IGenericService<Tag, CreateTagViewModel, UpdateTagViewModel, TagViewModel>
    {
    }
}
