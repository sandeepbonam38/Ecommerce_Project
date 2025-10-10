using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Adding Services to the Container
builder.Services.AddControllers();

//Adding the DbContext to the Container for connecting to the Database
builder.Services.AddDbContext<StoreContext>(
 options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

//Adding CORS to the Container
builder.Services.AddCors();

var app = builder.Build();


//Configuring the Http Request Pipeline
app.UseCors(opt =>
{
    opt.AllowAnyHeader().
    AllowAnyMethod().
    AllowAnyOrigin();
});
app.MapControllers();

DbInitializer.Initdb(app);

app.Run();

