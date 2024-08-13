var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/postures")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        string[] languages = form["languages"];
        string langList = string.Join(", ", languages);
        await context.Response.WriteAsync($"<div><p>Name: {name}</p>" +
            $"<p>Age: {age}</p>" +
            $"<div>Languages:{langList}</div></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});

app.Run();
