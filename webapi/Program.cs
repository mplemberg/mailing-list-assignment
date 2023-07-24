using webapi.Application.AddContact;
using webapi.Application.RetrieveContacts;
using webapi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//inject dependencies
builder.Services.AddScoped<IAddContactCommandHandler, AddContactCommandHandler>();
builder.Services.AddScoped<IRetrieveContactsQueryHandler, RetrieveContactsQueryHandler>();

//Add Repository as signleton so that it acts like a local database
builder.Services.AddSingleton<IContactsRepository, ContactsRepository>();

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
