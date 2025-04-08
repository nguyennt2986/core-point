using CorePoint.Application.Services;
using CorePoint.Infrastructure;
using CorePoint.Infrastructure.Configuration;
using CorePoint.Infrastructure.Helper;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
builder.Services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));

builder.Services.AddSingleton(sp =>
{
    var options = sp.GetRequiredService<IOptions<SnowflakeConfiguration>>().Value;
    return new SnowflakeIdGenerator(options.WorkerId, options.DatacenterId);
});


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
