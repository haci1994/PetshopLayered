using Petshop.BLL.ViewModels.GeneralViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.BLL.ViewModels.WebsiteViewModels
{
    public class BlogsPageViewModel
    {
        public List<BlogViewModel> Blogs { get; set; } = [];
    }
}
