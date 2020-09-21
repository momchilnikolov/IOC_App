using IOC_App.Domain.Interfaces;
using IOC_App.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC_App.DependencyInjection
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<Palindrome, PalindromeService>();
        }
    }
}
