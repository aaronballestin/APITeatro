using TeatroApi.Business;
using TeatroApi.Models;
using TeatroApi.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Filters;

var builder = WebApplication.CreateBuilder(args);

//Logger
builder.Services.AddControllers();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Filter.ByExcluding(Matching.FromSource("Microsoft"))
    .WriteTo.File("../logs/errorlogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(dispose: true);

// Add services to the container.
builder.Services.AddScoped<IAsientoService, AsientoService>(); 
builder.Services.AddScoped<ICompraService, CompraService>(); 
builder.Services.AddScoped<IObraService, ObraService>(); 
builder.Services.AddScoped<ISesionService, SesionService>(); 
builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 



var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<TeatroContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IAsientoRepository, AsientoRepository>(); 
builder.Services.AddScoped<ICompraRepository, CompraRepository>(); 
builder.Services.AddScoped<IObraRepository, ObraRepository>(); 
builder.Services.AddScoped<ISesionRepository, SesionRepository>(); 
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 




// builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>(serviceProvider => 
//     new PizzaEFRepository(connectionString));
//     new OrderEFRepository(connectionString);
//     new IngredientEFRepository(connectionString);
//     new UserEFRepository(connectionString);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


// app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5173")
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials();
});

app.MapControllers();

app.Run();
