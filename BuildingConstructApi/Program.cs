
using Application.System.BuilderPosts;
using Application.System.ContractorPosts;
using Application.System.MaterialStores;
using Constants;
using Data.DataContext;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Constants.Constants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BuildingConstructDbContext>(options => options.
           UseSqlServer(builder.Configuration.GetConnectionString(SystemsConstant.MainConnectionString)));
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<BuildingConstructDbContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IContractorPostService, ContractorPostService>();
builder.Services.AddScoped<IBuilderPostService, BuilderPostServices>();
builder.Services.AddScoped<IMaterialStoreService, MaterialStoreService>();

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
