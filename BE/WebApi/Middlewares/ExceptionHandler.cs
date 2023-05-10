using Domain.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace WebApi.Middlewares
{
    public class ExceptionHandler : IMiddleware
    {
        private readonly ILogger<ExceptionHandler> _logger;

        public ExceptionHandler(ILogger<ExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (NotFoundException ex)
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.NotFound);
            }
            catch (BadRequestException ex)
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.BadRequest);
            }
            catch (UnauthorizedException ex) 
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.Forbidden);
            } 
            catch (Exception ex)
            {
                _logger.LogError($"Message: {ex.Message},\n StackTrace\n{ex.StackTrace}");
                await HandleExceptionAsync(context, ex, HttpStatusCode.InternalServerError);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)statusCode;

            var responeBody = JsonConvert.SerializeObject(new
            {
                message = exception.Message,
            });


            await response.WriteAsync(responeBody);
        }
    }
}
