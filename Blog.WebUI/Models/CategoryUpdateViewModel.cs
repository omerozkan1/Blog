using System.ComponentModel.DataAnnotations;

namespace Blog.WebUI.Models
{
    public class CategoryUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        [Display(Name="Ad :")]
        public string Name { get; set; }
    }
}
