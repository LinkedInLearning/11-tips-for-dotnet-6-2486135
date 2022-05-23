var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
  var forecast = Enumerable.Range(1, 5).Select(index =>
     new WeatherForecast
     (
         DateTime.Now.AddDays(index),
         Random.Shared.Next(-20, 55),
         summaries[Random.Shared.Next(summaries.Length)]
     ))
      .ToArray();
  return forecast;
})
.WithName("GetWeatherForecast");


// Get the Version # for the .NET assembly

app.MapGet("/api-version", () =>
{
  var assembly = typeof(Program).Assembly;

  var creationDate = File.GetCreationTime(assembly.Location);
  var versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
  return $" Version: {versionInfo}, Last updated: {creationDate.ToLongDateString()}, timestamp: ({creationDate.ToString("HH:mm")})";
})
.WithName("GetApiVersion");
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary) {
  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}