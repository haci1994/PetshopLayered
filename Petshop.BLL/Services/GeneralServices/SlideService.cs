using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class SlideService : GenericService<Slide, CreateSlideViewModel, UpdateSlideViewModel, SlideViewModel>, ISlideService
    {
        public SlideService(IRepository<Slide> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
