var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");
var app = builder.Build();

app.MapGet("/", () => {
    return new { mensagem = "api em execução...." };
});

app.MapGet("/saudacao", () => new { mensagem = "Olá, mundo!" });

app.MapGet("/calcula/{soma}/{a:double}/{b:double}", (double a, double b) =>
    {
     return Results.Ok(new { mensagem = "Soma.....", resultado = a + b });
});
app.MapGet("/calcula/{subtracao}/{a:double}/{b:double}", (double a, double b) =>
    {
     return Results.Ok(new { mensagem = "Subtracao.....", resultado = a - b });
});
app.MapGet("/calcula/{soma}/{a:double}/{b:double}", (double a, double b) =>
    {
     return Results.Ok(new { mensagem = "Soma.....", resultado = a * b });
});
app.MapGet("/calcula/{soma}/{a:double}/{b:double}", (double a, double b) =>
    {
     return Results.Ok(new { mensagem = "Soma.....", resultado = a / b });
});
app.Run();