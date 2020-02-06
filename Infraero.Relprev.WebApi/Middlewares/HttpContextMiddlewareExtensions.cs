using Microsoft.AspNetCore.Builder;

namespace Infraero.Relprev.WebApi.Middlewares
{
    public static class HttpContextMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpContextMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextMiddleware>();
        }
    }
}
