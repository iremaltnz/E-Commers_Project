﻿using Business.Aspects.Cache;
using Business.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,
            ICoreModule[] modules)
        {


            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }



            return ServiceTool.Create(serviceCollection);
        }
    }
}
