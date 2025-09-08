using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class SocialService : GenericService<Social, CreateSocialViewModel, UpdateSocialViewModel, SocialViewModel>, ISocialService
    {
        public SocialService(IRepository<Social> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
