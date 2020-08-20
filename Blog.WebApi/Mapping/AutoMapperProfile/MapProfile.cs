using AutoMapper;
using Blog.DTO.DTOs.BlogDtos;
using Blog.DTO.DTOs.CategoryDtos;
using Blog.DTO.DTOs.CommentDtos;
using Blog.Entities.Concrete;
using Blog.WebApi.Models;

namespace Blog.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog.Entities.Concrete.Blog>();
            CreateMap<Blog.Entities.Concrete.Blog, BlogListDto>();

            CreateMap<BlogUpdateModel, Blog.Entities.Concrete.Blog>();
            CreateMap<Blog.Entities.Concrete.Blog, BlogUpdateModel>();

            CreateMap<BlogAddModel, Blog.Entities.Concrete.Blog>();
            CreateMap<Blog.Entities.Concrete.Blog, BlogAddModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();


            CreateMap<Comment, CommentListDto>();
            CreateMap<CommentListDto, Comment>();

            CreateMap<Comment, CommentAddDto>();
            CreateMap<CommentAddDto, Comment>();
        }
    }
}
