using FactorialService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Factorial of 6 is " + FactorialService.FactorialService.GetFactorialOf(6));

app.Run();