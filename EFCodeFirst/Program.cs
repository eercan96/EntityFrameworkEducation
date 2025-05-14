using EFCodeFirst.Model;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSqlServer<Deneme2Context>("Server=EMRE\\SQLEXPRESS01;Database=Database2CodeFirst;Integrated Security=true;TrustServerCertificate=True;");


builder.Services.AddDbContext<Deneme2Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DenemeContext"));
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
