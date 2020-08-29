using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Concrate
{
    public class NewsApiManager : INewsApiService
    {
        private readonly HttpClient _httpClient;
        public NewsApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RemoteNewsApiModel> GetNews()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("apikey", "apikey 5luZQLwOOVK7EecN1UIoSM:1lZPUAppEkPwyciRpuhJLa");

             var responseMessage = await _httpClient.GetAsync("https://api.collectapi.com/news/getNews?country=tr&tag=general");

            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RemoteNewsApiModel>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }
    }
}
