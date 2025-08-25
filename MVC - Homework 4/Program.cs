var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "AptechStudentDetail",
    pattern: "aptech/student/{id?}",
    defaults: new { controller = "Aptech", action = "StudentDetail" });

app.MapControllerRoute(
    name: "AptechStudent",
    pattern: "aptech/student",
    defaults: new { controller = "Aptech", action = "StudentList" });

app.MapControllerRoute(
    name: "Aptech",
    pattern: "aptech",
    defaults: new { controller = "Aptech", action = "Index" });

app.MapControllerRoute(
    name: "VietnamCities",
    pattern: "Vietnam/cities",
    defaults: new { controller = "Vietnam", action = "Cities" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
