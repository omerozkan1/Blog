using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Enums;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Blog.WebUI.TagHelpers
{
    [HtmlTargetElement("getblogimage")]
    public class ImageTagHelper : TagHelper
    {
        private readonly IimageApiService _imageApiService;
        public ImageTagHelper(IimageApiService imageApiService)
        {
            _imageApiService = imageApiService;
        }
        public int Id { get; set; }
        public BlogImageType BlogImageType { get; set; } = BlogImageType.BlogHome;
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {            
            var blob = await _imageApiService.GetBlogImageByIdAsync(Id);
            string html;
            if (BlogImageType == BlogImageType.BlogHome)
            {
                html = $"<img src='{blob}' class='card-img-top'/>";
            }
            else
            {
                html = $"<img src='{blob}' class='img-fluid rounded'/>";
            }

            output.Content.SetHtmlContent(html);
        }
    }
}
