﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CheckerApi.Context;
using CheckerApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CheckerApi.Controllers
{
    public class BaseController: Controller
    {
        public BaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
            var config = ServiceProvider.GetService<IConfiguration>();
            Password = config.GetValue<string>("Api:Password");
            Context = serviceProvider.GetService<ApiContext>();
        }

        public IServiceProvider ServiceProvider { get; }
        public ApiContext Context { get; }
        public string Password { get; }
    }
}
