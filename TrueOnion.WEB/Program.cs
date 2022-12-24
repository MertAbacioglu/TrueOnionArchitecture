using Autofac.Extensions.DependencyInjection;
using Autofac;
using TrueOnion.PERSISTINCE.DependencyResolvers.Autofac;
using TrueOnion.APPLICATION.DependencyResolvers;
using TrueOnion.WEB.DependencyResolvers;
using Microsoft.AspNetCore.Mvc;
using Autofac.Core;
using FluentValidation.AspNetCore;
using TrueOnion.APPLICATION.Validators;
using TrueOnion.WEB.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddWebLayerInjections();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddApplicationLayerInjections();

builder.Host.ConfigureServices(x => x.AddAutofac()).UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacPersistanceModule());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Products/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Products/Error";
        await next();
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
