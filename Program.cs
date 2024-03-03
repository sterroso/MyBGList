var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Configuration.GetValue<bool>("UseSwagger"))
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
{
  app.UseDeveloperExceptionPage();
} else {
  app.UseExceptionHandler("/error");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/error", () => Results.Problem());

// Uncomment the next line to test error handling by using the
// "/error/test" endpoint
// app.MapGet("/error/test", () => { throw new Exception("test"); });

app.MapControllers();

app.Run();
