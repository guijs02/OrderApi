using OrderApi.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.AddDocumentation();

builder.AddDataContexts();

builder.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.ConfigureDevEnvironment();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.ExceptionHandler();

app.Run();
