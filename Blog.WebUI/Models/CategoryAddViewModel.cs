using System.ComponentModel.DataAnnotations;

namespace Blog.WebUI.Models
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        [Display(Name="Ad :")]
        public string Name { get; set; }
    }
}
