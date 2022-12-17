using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.ResponseViewModels;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.WEB.Filters
{
    public class NotFoundFilter<SaveViewModel, ViewModel, Entity> : IAsyncActionFilter
        where SaveViewModel : ISaveVM
        where ViewModel : IBaseVM
        where Entity : BaseEntity

    {
        private readonly IGenericService<SaveViewModel, ViewModel, Entity> _genericService;

        public NotFoundFilter(IGenericService<SaveViewModel, ViewModel, Entity> genericService)
        {
            _genericService = genericService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            object? idValue = context.ActionArguments.Values.FirstOrDefault();
            if (idValue == null)
            {
                await next.Invoke();
                return;
            }

            int id = (int)idValue;
            SaveViewModel result = (await _genericService.FindAsync(id)).Data;
            if (result != null)
            {
                await next.Invoke();
                return;
            }

            ErrorVM errorVM = new ErrorVM();
            errorVM.Errors.Add($"{typeof(Entity).Name} with id {id} not found");
            context.Result = new RedirectToActionResult("Error", "Home", errorVM);


        }


    }
}
