using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;

namespace TrueOnion.WEB.Controllers
{
    public class ErrorController : Controller
    {


        public async Task<IActionResult> Index(int httpStatusCode)
        {
            IExceptionHandlerFeature? exHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();

            Exception exception = exHandlerFeature != null
                ? exHandlerFeature.Error
                : new Exception("UnhandledException");
            HttpContext.Response.StatusCode = httpStatusCode;
            ErrorVM error = new();
            error.StatusCode = httpStatusCode;
            error.Errors.Add(exception.Message);
            return View("~/Views/Error/Index.cshtml",error);
        }


    }
}
