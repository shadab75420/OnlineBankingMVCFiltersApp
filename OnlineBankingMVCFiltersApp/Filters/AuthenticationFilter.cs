using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OnlineBankingMVCFiltersApp.Services;

namespace OnlineBankingMVCFiltersApp.Filters
{
    public class AuthenticationFilter : IActionFilter
    {
        private readonly AuthService _authService;

        public AuthenticationFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!_authService.IsUserLoggedIn())
            {
                context.Result = new ContentResult
                {
                    Content = "User not authenticated"
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}