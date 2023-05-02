using IntroduccionEntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*Clase creada*/

//builder.Services.AddDbContext<AplicationDbContext>(opciones => opciones.UseSqlServer());Para Sqlserver
//CONECTAMOS A POSTGRES SQL
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");//Obtenemos la cadena de definicion 
builder.Services.AddDbContext<AplicationDbContext>(opciones => opciones.UseNpgsql(connectionString));

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
