using Petshop.BLL.ViewModels.GeneralViewModels;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface IReviewService : IGenericService<Review, CreateReviewViewModel, UpdateReviewViewModel, ReviewViewModel>
    {
    }
}
