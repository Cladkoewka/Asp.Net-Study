using MetanitExperiments.Services;

namespace MetanitExperiments.Middlewares
{
    public class CounterMiddleware
    {
        private RequestDelegate _next;
        private int i = 0;
        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;   
        }

        public async Task InvokeAsync(HttpContext httpContext, ICounter counter, CounterService counterService)
        {
            i++;
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Request {i}; Counter: {counter.Value}; Service: {counterService.Counter.Value}");
        }
    }
}
