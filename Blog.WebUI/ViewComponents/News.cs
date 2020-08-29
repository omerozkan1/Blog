using Blog.WebUI.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.ViewComponents
{
    public class News : ViewComponent
    {
        private readonly INewsApiService _newsApiService;
        public News(INewsApiService newsApiService)
        {
            _newsApiService = newsApiService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_newsApiService.GetNews().Result);
        }
    }
}
