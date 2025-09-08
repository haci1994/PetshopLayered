using Microsoft.AspNetCore.Mvc;

namespace Petshop.MVC.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
