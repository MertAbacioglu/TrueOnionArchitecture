using Autofac.Extensions.DependencyInjection;
using Autofac;
using TrueOnion.PERSISTINCE.DependencyResolvers.Autofac;
using TrueOnion.APPLICATION.DependencyResolvers;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Validators;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.WEB.Filters;
using Autofac.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation()
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductSaveVMValidator>());
builder.Services.AddScoped(typeof(NotFoundFilter<,,>));
builder.Host.UseServiceProviderFactory
    (new AutofacServiceProviderFactory());
builder.Services.AddApplicationLayer();
builder.Host.ConfigureServices(x => x.AddAutofac()).UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacPersistanceModule());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
