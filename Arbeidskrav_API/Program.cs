using Arbeidskrav_API.Data;
using Arbeidskrav_API.Features.Books;
using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;
using Arbeidskrav_API.Features.Books.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .AddScoped<IBookService, BookService>()
    .AddScoped<IBookRepository, BookRepository>()
    .AddScoped<IBookMapper, BookMapper>()
    .AddScoped<IBookRegistrationMapper, BookRegistrationMapper>();

builder.Services.AddDbContext<ArbeidskravAPIDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 33))));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

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