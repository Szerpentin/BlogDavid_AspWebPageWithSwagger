var builder = WebApplication.CreateBuilder(args);
// Telling ASP that we want to use the controller feature
builder.Services.AddControllers();
// Adding swagger code generator (and it's dependencies) to the services
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Mapping the endpoints in the controllers to serve them
app.MapControllers();
// Registering swagger middleware
app.UseSwagger();
// Registering the UI service
app.UseSwaggerUI();
// Starting the website
app.Run();
