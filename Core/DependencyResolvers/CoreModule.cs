﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceColleciton)
        {
            serviceColleciton.AddMemoryCache(); //IMemoryCache _memoryCache; bunun karşılığı olmuş oluyor.

            serviceColleciton.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceColleciton.AddSingleton<ICacheManager, MemoryCacheManager>();

        }
    }
}
