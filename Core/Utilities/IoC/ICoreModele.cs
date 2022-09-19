using Autofac.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection)
        {

            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }

    }
}
