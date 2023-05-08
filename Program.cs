using DemoSession1_WebAPI.Converters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new DateConverter());
});
//builder.Services.AddRazorPages();
var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
