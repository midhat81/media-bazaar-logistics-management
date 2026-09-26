using Microsoft.AspNetCore.Authentication.Cookies;
using MediaBazaar.Classes;
using BusinessLogicLayer;
using MediaBazaar;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRestockRequestDAL, RestockRequestDAL>(); 
builder.Services.AddScoped<IRestockRequestManager, RestockRequestManager>(); 
builder.Services.AddScoped<EmployeeManager>();
builder.Services.AddScoped<EmergencyContactManager>();
builder.Services.AddScoped<EmployeeWorksheetManager>();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Login";
	});

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/");
    options.Conventions.AllowAnonymousToPage("/Login");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();