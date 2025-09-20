using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.GeneralViewModels;

namespace Petshop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();

            return View(categories);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = _categoryService.DeleteAsync(id).Result;

            if (result)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Category");
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CreateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Name is not valid");
            }


            await _categoryService.AddAsync(model);

            return RedirectToAction("Index", "Category");
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            var model = new UpdateCategoryViewModel()
            {
                Name = category.Name
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryViewModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Name is not valid");
            }

            model.Id = id;

            await _categoryService.UpdateAsync(model);

            return RedirectToAction("Index", "Category");
        }
    }
}
