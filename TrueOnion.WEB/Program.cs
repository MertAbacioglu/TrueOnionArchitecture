using Autofac.Extensions.DependencyInjection;
using Autofac;
using TrueOnion.PERSISTINCE.DependencyResolvers.Autofac;
using TrueOnion.APPLICATION.DependencyResolvers;
using TrueOnion.WEB.DependencyResolvers;
using TrueOnion.PERSISTINCE.DependencyResolvers;
using System.Runtime.Intrinsics.Arm;
using TrueOnion.INFRASTRUCTURE.OUTER.Services;
using TrueOnion.INFRASTRUCTURE.INNER.DependencyResolvers.Autofac;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddWebLayerInjections();
builder.Services.AddSession();
builder.Services.AddIdentityService();
builder.Services.AddApplicationLayerInjections();
builder.Services.AddInfrastructureLayerInjections(builder.Configuration);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureServices(x => x.AddAutofac()).UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacPersistanceModule());
    builder.RegisterModule(new AutofacInnerInfrastructureModule());
});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Products/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.Use(async (context, next) =>
//{
//    await next();
//    if (context.Response.StatusCode == 404)
//    {
//        context.Request.Path = "/Products/Error";
//        await next();
//    }
//});

app.UseStatusCodePagesWithRedirects("~/Error?httpStatusCode={0}")
        .UseExceptionHandler("/Error");

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();//TODO
app.UseAuthorization();

app.MapControllerRoute(name: "Area", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapDefaultControllerRoute();

app.Run();