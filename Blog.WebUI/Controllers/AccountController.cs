using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginViewModel model)
        {
            if (await _authApiService.SignIn(model))
            {
                return RedirectToAction("Index","Blog",new {@area="Admin"});
            }
            return View();
        }
    }
}