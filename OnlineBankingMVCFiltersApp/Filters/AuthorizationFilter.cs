using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OnlineBankingMVCFiltersApp.Services;

namespace OnlineBankingMVCFiltersApp.Filters
{
    public class AuthorizationFilter : IActionFilter
    {
        private readonly AuthService _authService;

        public AuthorizationFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!_authService.IsAdmin())
            {
                context.Result = new ContentResult
                {
                    Content = "Access Denied"
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}