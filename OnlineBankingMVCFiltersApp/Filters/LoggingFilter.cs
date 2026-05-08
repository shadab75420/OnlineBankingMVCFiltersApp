using Microsoft.AspNetCore.Mvc.Filters;
using OnlineBankingMVCFiltersApp.Services;

namespace OnlineBankingMVCFiltersApp.Filters
{
    public class LoggingFilter : IActionFilter
    {
        private readonly LoggingService _loggingService;

        public LoggingFilter(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;

            _loggingService.Log(
                $"User Request: {request.Method} {request.Path}"
            );
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var response = context.HttpContext.Response;

            _loggingService.Log(
                $"Response Status Code: {response.StatusCode}"
            );
        }
    }
}