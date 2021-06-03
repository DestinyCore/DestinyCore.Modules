﻿using DestinyCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyCore.Caching
{
    /// <summary>
    /// 缓存默认模块
    /// </summary>
    public class CachingDefaultModule : AppModule
    {

        public override void ConfigureServices(ConfigureServicesContext context)
        {
            context.Services.AddDistributedMemoryCache();
            context.Services.AddSingleton<ICache, CacheDefault>();
        }
    }
}
