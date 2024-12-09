using MacWebApi.Data;
using MacWebApi.Mapping;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MacWebApi.Services.Prduct;
using MacWebApi.Services.Role;
using MacWebApi.Services.User;
using MacWebApi.Repositories.Product;
using MacWebApi.Repositories.Role;
using MacWebApi.Repositories.User;
using MacWebApi.Services.CategoryServices;
using MacWebApi.Repositories.CityRepository;
using MacWebApi.Repositories.CategoryRepositories;
using MacWebApi.Services.CityServices;
using MacWebApi.Repositories.OrderCategories;
using MacWebApi.Services.OrderServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();  
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();    
builder.Services.AddScoped<IOrderService, OrderService>();  
builder.Services.AddScoped<IProductRepository, ProductRepository>();    
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();  
builder.Services.AddScoped<IRoleService, RoleSevice>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<Seed>();


var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
