var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    var path = context.Request.Path;
    var fullPath = $"html/{path}";
    var response = context.Response;


    response.Headers.ContentDisposition = "attachment; filename = guuy.jpg";
    response.SendFileAsync("Files/guy.jpg");

});

app.Run();
