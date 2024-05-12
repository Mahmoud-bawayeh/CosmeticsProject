using CosmeticsProject_Core.Context;
using CosmeticsProject_Core.IRepos;
using CosmeticsProject_Core.IServices;
using CosmeticsProject_Infra.Repos;
using CosmeticsProject_Infra.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CosmeticsOnlineStoreDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn")), ServiceLifetime.Scoped);
builder.Services.AddScoped<IAdminServicesInterface, AdminServices>();
builder.Services.AddScoped<IAdminReposInterface, AdminRepos>();

builder.Services.AddScoped<ISharedServicesInterface, SharedServices>();
builder.Services.AddScoped<ISharedReposInterface, SharedRepos>();

builder.Services.AddScoped<IEmployeeServicesInterface, EmployeeServices>();
builder.Services.AddScoped<IEmployeeReposInterface, EmployeeRepos>();

builder.Services.AddScoped<IClientIServicesnterface, ClintServices>();
builder.Services.AddScoped<IClientReposInterface, ClientRepos>();
builder.Services.AddSwaggerGen(c =>

{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Cosmetics Online Store API", Version = "v1" });
});

var app = builder.Build();

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
