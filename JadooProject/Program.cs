using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Concrete;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Repositories;
using JadooProject.Extensions;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




//builder.Services.AddDbContext<JadooContext>();



builder.Services.AddServiceHandlers();  // extension metodumuz arac�l��� ile t�m handlerlar�m�z� dahil etmi� olduk art�k controllerda handlerlar� kullanabilicez.
//AddMediaR, AddAutoMapper gibi metotlar da asl�nda extension metotlard�r.



builder.Services.AddDbContext<JadooContext>(opt =>  //appsettings'de connection ge�tik
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    opt.UseSqlServer(connectionString);
});




//builder.Services.AddScoped<GetDestinationQueryHandler>();  //b�t�n handler'ar�m�z� burada scope ediyoruz
//builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
//builder.Services.AddScoped<CreateDestinationCommandHandler>();
//builder.Services.AddScoped<RemoveDestinationCommandHandler>();
//builder.Services.AddScoped<UpdateDestinationCommandHandler>();




builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<INewsDal, EfNewsDal>();





builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});



builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // Her s�n�f (T t�r�nde yazaca��m�z her s�n�f '� interface olarak ge�micez) i�in tek tek interface yazmammak i�in direk IRepository �zerinden yapaca��z i�lemlerimizi


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());



builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
