using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Concrate
{
    public class ImageApiManager : IimageApiService
    {
        private readonly HttpClient _httpClient;
        public ImageApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60837/api/images/");
        }

        public async Task<string> GetBlogImageByIdAsync(int id)
        {
            //GetBlogImageById

            BlogAddViewModel model = new BlogAddViewModel();
            var responseMessage = await _httpClient.GetAsync($"GetBlogImageById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();       

                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }

    }
}
