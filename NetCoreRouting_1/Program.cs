var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Eger Custom Route olusturacak iseniz spesifik olan (Custom route'unuz her zaman default route'tan önce yazılmalı

//Home

app.MapControllerRoute(
    name: "Deneme",
    pattern:"Test/{action}/{id?}", //Eger burada action yerine yine düz bir şey verip yer tutucu kullanmasaydık o zaman direkt o yazıyı yine yazmak zorunda kalırdık
    defaults: new {Controller="Simulation",Action = "SimulationIndex"}

    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
