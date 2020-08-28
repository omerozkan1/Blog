using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Extensions;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Concrate
{
    public class BlogApiManager : IBlogApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BlogApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:60837/api/blogs/");
        }
        public async Task<List<BlogListViewModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var blogList = JsonConvert.DeserializeObject<List<BlogListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
                return blogList;
            }
            return null;
        }

        public async Task<BlogListViewModel> GetByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<BlogListViewModel>(await responseMessage.Content.ReadAsStringAsync()); //gelen string-json datayı bloglistviewmodele çevirir.
            }
            return null;
        }

        public async Task<List<BlogListViewModel>> GetAllByCategoryIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"GetAllByCategoryId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task AddAsync(BlogAddViewModel model)
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Image != null)
            {
                //var bytes = await File.ReadAllBytesAsync(model.Image.FileName);
                var stream = new MemoryStream();
                await model.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent, nameof(BlogAddViewModel.Image), model.Image.FileName);
            }

            var user = _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId = user.Id;

            formData.Add(new StringContent(model.AppUserId.ToString()), nameof(BlogAddViewModel.AppUserId));

            formData.Add(new StringContent(model.ShortDescription), nameof(BlogAddViewModel.ShortDescription));

            formData.Add(new StringContent(model.Description), nameof(BlogAddViewModel.Description));

            formData.Add(new StringContent(model.Title), nameof(BlogAddViewModel.Title));

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PostAsync("", formData);
        }

        public async Task UpdateAsync(BlogUpdateViewModel model)
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Image != null)
            {
                //var bytes = await File.ReadAllBytesAsync(model.Image.FileName);

                var stream = new MemoryStream();
                await model.Image.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent, nameof(BlogAddViewModel.Image), model.Image.FileName);
            }

            var user = _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId = user.Id;

            formData.Add(new StringContent(model.Id.ToString()), nameof(BlogUpdateViewModel.Id));

            formData.Add(new StringContent(model.AppUserId.ToString()), nameof(BlogAddViewModel.AppUserId));

            formData.Add(new StringContent(model.ShortDescription), nameof(BlogAddViewModel.ShortDescription));

            formData.Add(new StringContent(model.Description), nameof(BlogAddViewModel.Description));

            formData.Add(new StringContent(model.Title), nameof(BlogAddViewModel.Title));

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PutAsync($"{model.Id}", formData);
        }

        public async Task DeleteAsync(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));
            await _httpClient.DeleteAsync($"{id}");
        }

        public async Task<List<CommentListViewModel>> GetCommentsAsync(int blogId, int? parentCommentId)
        {
            var responseMessage = await _httpClient.GetAsync($"{blogId}/GetComments?parentCommentId={parentCommentId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CommentListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task AddToComment(CommentAddViewModel model)
        {
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("AddComment", content);
        }

        public async Task<List<CategoryListViewModel>> GetCategoriesAsync(int blogId)
        {
            var responseMessage = await _httpClient.GetAsync($"{blogId}/GetCategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
     
        public async Task<List<BlogListViewModel>> GetLastFiveAsync()
        {
            var responseMessage = await _httpClient.GetAsync("GetLastFive");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
            
        }

        public async Task<List<BlogListViewModel>> SearchAsync(string s)
        {
            var responseMessage = await _httpClient.GetAsync($"Search?s={s}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListViewModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task AddToCategoryAsync(CategoryBlogViewModel model)
        {
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("AddToCategory", content);
        }

        public async Task RemoveFromCategoryAsync(CategoryBlogViewModel model)
        {
            await _httpClient.DeleteAsync($"RemoveFromCategory?{nameof(CategoryBlogViewModel.CategoryId)}={model.CategoryId}&{nameof(CategoryBlogViewModel.BlogId)}={model.BlogId}");
        }
    }
}
