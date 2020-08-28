using Blog.Business.Concrete;
using Blog.Business.Interfaces;
using Blog.Business.Tools.FacadeTool;
using Blog.Business.Tools.JWTTool;
using Blog.Business.Tools.LogTool;
using Blog.Business.ValidationRules.FluentValidation;
using Blog.Concrete;
using Blog.DataAccess.Concrete.EntityFrameworkCore.Context;
using Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Blog.DataAccess.Interfaces;
using Blog.DTO.DTOs.AppUserDtos;
using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.DTO.DTOs.CategoryDtos;
using Blog.DTO.DTOs.CommentDtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UdemyBlogContext>(opt=> 
            {
                opt.UseSqlServer(configuration.GetConnectionString("db1"), conf=> {
                    conf.MigrationsAssembly("Blog.WebApi");
                });
            });

            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();
            services.AddScoped<IFacade, Facade>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();


        }
    }
}
