using Microsoft.EntityFrameworkCore;
using MyContacts.Business.Repository;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IContactDetailRepository, ContactDetailRepository>();

builder.Services.AddCors(o => o.AddPolicy("MyContacts", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("MyContacts");

//app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
