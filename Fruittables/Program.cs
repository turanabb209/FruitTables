using Fruittables.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("server=SAMA;database=Fruittables;trusted_connection=true;integrated security=true;TrustServerCertificate=true;");

});



var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    
    "default",
    "{controller=home}/{action=index}/{id?}"  
    
    );

app.Run();
