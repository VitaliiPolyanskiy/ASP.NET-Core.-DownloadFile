var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/download", () =>
{
    var filePath = Path.Combine(app.Environment.ContentRootPath, "Capri.jpg");

    // Використовуємо універсальний Results.File
    return Results.File(
        path: filePath,
        contentType: "image/jpeg",
        fileDownloadName: "Острів Капрі.jpg"
    );
});

app.Run();