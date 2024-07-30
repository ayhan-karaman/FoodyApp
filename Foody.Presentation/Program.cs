using Foody.Business.Abstract;
using Foody.Business.Concrete;
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.EntityFramework;
using Foody.Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<FoodyContext>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManger>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => 
{
    
    endpoints.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapRazorPages();
    endpoints.MapControllers();
});

app.MapRazorPages();

app.Run();
