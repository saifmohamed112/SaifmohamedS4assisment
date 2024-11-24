using Microsoft.EntityFrameworkCore;
using SaifmohamedS4assisment.data;
using SaifmohamedS4assisment.Repo;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<ICinemaRepo, CinemaRepo>();
builder.Services.AddScoped<IMovieRepo, MovieRepo>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
