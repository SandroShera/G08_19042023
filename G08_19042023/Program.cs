using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository;

namespace G08_19042023
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer("server=LAPTOP-T4QO4KAH; database=Northwind; integrated security=true; TrustServerCertificate=True;")
				);

            var app = builder.Build();


			app.MapGet("/getcategory/{id}", (HttpContext httpContext, ApplicationDbContext context, int id) =>
			{
				NorthwindCategories northwindCategories = new(context);
				return northwindCategories.GetCategoryById(id).ToString();
			});

			app.Run();
		}
	}
}