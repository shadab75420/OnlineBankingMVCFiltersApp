using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OnlineBankingMVCFiltersApp.Services;

namespace OnlineBankingMVCFiltersApp.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly LoggingService _loggingService;

        public GlobalExceptionFilter(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnException(ExceptionContext context)
        {
            _loggingService.Log(
                $"Exception: {context.Exception.Message}"
            );

            context.Result = new ViewResult
            {
                ViewName = "Error"
            };

            context.ExceptionHandled = true;
        }
    }
}