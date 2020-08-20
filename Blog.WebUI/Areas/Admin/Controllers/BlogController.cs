using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Filters;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogApiService _blogApiService;
        public BlogController(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        [JwtAuthorize]
        public async Task<IActionResult> Index()
        {
            TempData["active"] = "blog";
            return View(await _blogApiService.GetAllAsync());
        }

        public IActionResult Create()
        {
            TempData["active"] = "blog";
            return View(new BlogAddViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogAddViewModel model)
        {
            TempData["active"] = "blog";

            if (ModelState.IsValid)
            {
                await _blogApiService.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            TempData["active"] = "blog";
            var blogList = await _blogApiService.GetByIdAsync(id);

            return View(new BlogUpdateViewModel
            {
                Id = blogList.Id,
                Title = blogList.Title,
                ShortDescription = blogList.ShortDescription,
                Description = blogList.Description
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(BlogUpdateViewModel model)
        {
            TempData["active"] = "blog";
            if (ModelState.IsValid)
            {
                await _blogApiService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            TempData["active"] = "blog";
            await _blogApiService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AssignCategory(int id, [FromServices]ICategoryApiService categoryApiService)
        {
            TempData["active"] = "blog";
            var categories = await categoryApiService.GetAllAsync();
            var blogCategories = await _blogApiService.GetCategoriesAsync(id);

            TempData["blogId"] = id;

            List<AssignCategoryViewModel> list = new List<AssignCategoryViewModel>();

            foreach (var category in categories)
            {
                AssignCategoryViewModel model = new AssignCategoryViewModel();

                model.CategoryId = category.Id;
                model.CategoryName = category.Name;
                model.Exists = blogCategories.Contains(category);

                list.Add(model);
            }

            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> AssignCategory(List<AssignCategoryViewModel> list)
        {
            TempData["active"] = "blog";
            int id = (int)TempData["blogId"];
            foreach (var item in list)
            {
                if (item.Exists)
                {
                    CategoryBlogViewModel model = new CategoryBlogViewModel();
                    model.BlogId = id;
                    model.CategoryId = item.CategoryId;
                    await _blogApiService.AddToCategoryAsync(model);
                }
                else
                {
                    CategoryBlogViewModel model = new CategoryBlogViewModel();
                    model.BlogId = id;
                    model.CategoryId = item.CategoryId;
                    await _blogApiService.RemoveFromCategoryAsync(model);
                }
            }

            return RedirectToAction("Index");
        }
    }
}