using FiveToSevenEndpoints.Services.MadLib;
using FiveToSevenEndpoints.Services.OddOrEven;
using FiveToSevenEndpoints.Services.ReverseItAlpha;
using FiveToSevenEndpoints.Services.ReverseItNumber;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphaService, ReverseItAlphaService>();
builder.Services.AddScoped<IReverseItNumberService, ReverseItNumberService>();

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
