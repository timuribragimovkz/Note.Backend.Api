using Note.Backend.Api.StartupExtensions;
using Note.Backend.Application.Features.RecipeAuthor.Create;
using Note.Backend.Application.Features.RecipeIngredient.Create;
using Note.Backend.Application.Features.RecipeNutritionData.Retriever;
using Note.Backend.Infrastructure.SQLServer.AutoMapperProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.RegisterServicesWithScrutor();


//RegisterServicesWithScrutorRecipe

builder.Services.RegisterSQLServerIngredientData(builder.Configuration);
builder.Services.RegisterSQLServerAuthor(builder.Configuration);
builder.Services.RegisterSQLServerNutritionData(builder.Configuration);
builder.Services.RegisterSQLServerRecipe(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<IIngredientDataRepository, IngredientDataRepository>(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(RecipeIngredientProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<IngredientCreatorRequest>());
builder.Services.AddAutoMapper(typeof(RecipeAuthorProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<AuthorCreatorRequest>());
builder.Services.AddAutoMapper(typeof(RecipeNutritionDataProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<RecipeNutritionDataRetrieverRequest>());
builder.Services.AddAutoMapper(typeof(RecipeProfile));
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