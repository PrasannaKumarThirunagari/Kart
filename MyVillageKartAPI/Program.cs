//using MyVillageKartAPI.MyVillageKartDataAccess;
//using MyVillageKartAPI.MyVillageKartDataManager;

using MyVillageKartAPI.DataInterface;
using MyVillageKartAPI.DataManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductsDataManager, ProductsDataManager>();
builder.Services.AddScoped<IUserDataManager, UserDataManager>();
builder.Services.AddScoped<ICategoriesDataManager, CategoriesDataManager>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//builder.Services.AddScoped<IUserDataAccess, UserDataAccess>();
//builder.Services.AddScoped<IUserManager, UserManager>();
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
