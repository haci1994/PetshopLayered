using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class SiteInfoService : GenericService<SiteInfo, CreateSiteInfoViewModel, UpdateSiteInfoViewModel, SiteInfoViewModel>, ISiteInfoService
    {
        public SiteInfoService(IRepository<SiteInfo> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
