using TeatroApi.Business;
using TeatroApi.Models;
using TeatroApi.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAsientoService, AsientoServices>(); 
builder.Services.AddScoped<ICategoriaService, CategoriaService>(); 
builder.Services.AddScoped<ICompraService, CompraService>(); 
builder.Services.AddScoped<IObraServices, ObraServices>(); 
builder.Services.AddScoped<ISesionServices, SesionServices>(); 
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>(); 



var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<PizzaContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IAsientoRepository, AsientoRepository>(); 
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>(); 
builder.Services.AddScoped<ICompraRepository, CompraEFRepository>(); 
builder.Services.AddScoped<IObraRepository, ObraRepository>(); 
builder.Services.AddScoped<ISesionRepository, SesionRepository>(); 



  
// builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>(serviceProvider => 
//     new PizzaEFRepository(connectionString));
//     new OrderEFRepository(connectionString);
//     new IngredientEFRepository(connectionString);
//     new UserEFRepository(connectionString);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
