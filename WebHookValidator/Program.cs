using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});
builder.Services.AddSingleton<IWebHookValidatorFactory, WebHookValidatorFactory>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/hooks", (HttpRequest req, IWebHookValidatorFactory fac) =>
{
    GithubWebhook.GhWebhook g = new(req);
    var v = fac.GetValidator(g.PayloadObject);
    return v.Validate(g);
})
.WithName("hooks"); ;
app.Run();
