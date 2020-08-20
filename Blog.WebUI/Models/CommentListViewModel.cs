using System;
using System.Collections.Generic;

namespace Blog.WebUI.Models
{
    public class CommentListViewModel
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; }
        public int? ParentCommentId { get; set; }
        public List<CommentListViewModel> SubComments { get; set; }
        public int BlogId { get; set; }
    }
}
