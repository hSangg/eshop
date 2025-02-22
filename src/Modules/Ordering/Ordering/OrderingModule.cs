﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}