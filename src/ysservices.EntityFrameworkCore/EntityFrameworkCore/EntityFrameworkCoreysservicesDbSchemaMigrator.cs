using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ysservices.Data;
using Volo.Abp.DependencyInjection;

namespace ysservices.EntityFrameworkCore;

public class EntityFrameworkCoreysservicesDbSchemaMigrator
    : IysservicesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreysservicesDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ysservicesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ysservicesDbContext>()
            .Database
            .MigrateAsync();
    }
}
