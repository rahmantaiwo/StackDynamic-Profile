using Microsoft.OpenApi.Models;
using StackDynamiProfile.Models;
using StackDynamiProfile.Services.IServices;
using StackDynamiProfile.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "StackDynamicProfile API", Version = "v1" });
});

// ✅ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// ✅ HttpClient
builder.Services.Configure<CatFactApiSettings>(
    builder.Configuration.GetSection("CatFactApi"));

builder.Services.AddHttpClient<CatFactService>();
builder.Services.AddScoped<IProfileService, ProfileService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI(); // ✅ will now be recognized
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
