using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class TagService : GenericService<Tag, CreateTagViewModel, UpdateTagViewModel, TagViewModel>, ITagService
    {
        public TagService(IRepository<Tag> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
