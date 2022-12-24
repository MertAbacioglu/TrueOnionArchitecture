using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

namespace TrueOnion.WEB.Middlewares
{
    public static class UseCustomExceptionHandler
    {

        public static void UseCustomException(this IApplicationBuilder app)
        {
            //app.UseExceptionHandler(config =>
            //{

            //    config.Run(async context =>
            //    {
            //        context.Response.ContentType = "application/json";

            //        IExceptionHandlerFeature? exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

            //        int statusCode = exceptionFeature.Error switch
            //        {
            //            ClientSideException => 400,
            //            NotFoundExcepiton => 404,
            //            _ => 500
            //        };
            //        context.Response.StatusCode = statusCode;


            //        object response;
            //        response = CustomResponseDto<NoContentDto>.Fail(statusCode, exceptionFeature.Error.Message);


            //        await context.Response.WriteAsync(JsonSerializer.Serialize(response));

            //    });










            //});





        }
    }
}
