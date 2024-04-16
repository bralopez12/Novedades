using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Novedades.BLL.Service;
//using Novedades.DAL.Mongo.DataContext;
//using Novedades.DAL.Mongo.DataContext;
using Novedades.DAL.SqlServer.Adaptador;
//using Novedades.DAL.SqlServer.DataContext;
using Novedades.DAL.SqlServer.Entities;
using Novedades.DAL.SqlServer.Mappers;
using Novedades.Models;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<DbnovedadesContext>(opciones =>
//{
//    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
//});

//builder.Services.AddScoped<IGenericRepository<NovedadModel>, NovedadesRepository>(); //Cuando vaya realizar la implementación de esta interfaz se uti....Cualquier controlador que utilice esta interfaz(IGenericRepository) lo va a trabajar con la capa del modelo(NovedadModel)
//builder.Services.AddScoped<INovedadService,NovedadService>();
//builder.Services.AddAutoMapper(typeof(ProfileSQL));

//builder.Services.AddSingleton<IContext>(provider => new Context("mongodb://localhost:27017/", "NovedadesDB"));
//builder.Services.AddScoped<AdaptadorNovedad>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
