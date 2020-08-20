using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Models
{
    public class CategoryListViewModel : IEquatable<CategoryListViewModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals([AllowNull] CategoryListViewModel other)
        {
            return this.Id == other.Id && this.Name == other.Name;
        }
    }
}
