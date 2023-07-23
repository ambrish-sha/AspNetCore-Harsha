using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareExample.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AmbCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public AmbCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AmbCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseAmbCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AmbCustomMiddleware>();
        }
    }
}
