using Ecommerce.MongoDB.Context;
using NswagDemo.Controllers;
using NswagDemo.Interface;
using NswagDemo.Repository;
using NswagDemo.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("MongoDBConnection");
var databaseName = builder.Configuration["MongoDB:DatabaseName"];
builder.Services.AddSingleton(new MongoDBContext(connectionString, databaseName));


builder.Services.AddSingleton<ICustomerController, CustomerImplController>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRespository>();


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
