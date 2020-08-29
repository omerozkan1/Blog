using System.Collections.Generic;

namespace Blog.WebUI.Models
{
    public class RemoteNewsApiModel
    {
        public bool Success { get; set; }
        public List<NewsModel> Result { get; set; }
    }
}
