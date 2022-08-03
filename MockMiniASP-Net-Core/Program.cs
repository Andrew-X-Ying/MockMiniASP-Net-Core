﻿namespace MyApp
{
    using Microsoft.AspNetCore.Http;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
        }

        public static RequestDelegate FooMiddleware(RequestDelegate next)
        => async context => {
            await context.Response.WriteAsync("Foo=>");
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