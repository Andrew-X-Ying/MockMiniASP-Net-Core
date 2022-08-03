namespace MockMiniASP_Net_Core
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            await new WebHostBuilder()
           .UseHttpListener()
           .Configure(app => app
               .Use(FooMiddleware)
               .Use(BarMiddleware)
               .Use(BazMiddleware))
           .Build()
           .StartAsync();
        }

        public static RequestDelegate FooMiddleware(RequestDelegate next)
        => async context => {
            await context.Response.WriteAsync($"Foo=>{DateTime.Now}");
            await next(context);
        };

        public static RequestDelegate BarMiddleware(RequestDelegate next)
        => async context => {
            await context.Response.WriteAsync("Bar=>");
            await next(context);
        };

        public static RequestDelegate BazMiddleware(RequestDelegate next)
        => context => context.Response.WriteAsync("Baz");
    }
}