﻿using System.Threading.Tasks;
using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryApiService _categoryApiService;
        public CategoryController(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["active"] = "category";
            return View(await _categoryApiService.GetAllAsync());
        }

        public IActionResult Create()
        {
            TempData["active"] = "category";
            return View(new CategoryAddViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddViewModel model)
        {
            TempData["active"] = "category";
            if (ModelState.IsValid)
            {
                await _categoryApiService.AddAsync(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            TempData["active"] = "category";
            var categoryList = await _categoryApiService.GetByIdAsync(id);
            return View(new CategoryUpdateViewModel
            {
                Id=categoryList.Id,
                Name=categoryList.Name
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateViewModel model)
        {
            TempData["active"] = "category";
            if (ModelState.IsValid)
            {
                await _categoryApiService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            TempData["active"] = "category";
            await _categoryApiService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Remove("token");
            return RedirectToAction("Index", "Home",new {area=""});
        }

    }
}