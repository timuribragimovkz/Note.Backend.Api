using Note.Backend.Api.StartupExtensions;
using Note.Backend.Application.Features.RecipeIngredient.Create;
using Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.RegisterServicesWithScrutor();
builder.Services.RegisterSQLServer(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<IIngredientDataRepository, IngredientDataRepository>(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(RecipeIngredientProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<IngredientCreatorRequest>());

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