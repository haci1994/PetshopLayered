using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.DataContext.Repositories.Contracts;

namespace Petshop.BLL.Services.GeneralServices
{
    public class ReviewService : GenericService<Review, CreateReviewViewModel, UpdateReviewViewModel, ReviewViewModel>, IReviewService
    {
        public ReviewService(IRepository<Review> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
