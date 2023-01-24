var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SupportNonNullableReferenceTypes();
    o.UseInlineDefinitionsForEnums();
    o.UseAllOfForInheritance();
    // o.UseOneOfForPolymorphism(); // <-- uncomment this line on step 3
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(o =>
{
    o.EnableTryItOutByDefault();
    o.DisplayRequestDuration();
    o.DefaultModelsExpandDepth(2);
    o.DefaultModelExpandDepth(2);
});

app.MapControllers();

app.Run();
