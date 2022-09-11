using Knorooms.WebApi.Infrastructure.Common.Services;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace Infrastructure.Test.Caching;

public class DistributedCacheService : CacheService<Knorooms.WebApi.Infrastructure.Caching.DistributedCacheService>
{
    protected override Knorooms.WebApi.Infrastructure.Caching.DistributedCacheService CreateCacheService() =>
        new(
            new MemoryDistributedCache(Options.Create(new MemoryDistributedCacheOptions())),
            new NewtonSoftService(),
            NullLogger<Knorooms.WebApi.Infrastructure.Caching.DistributedCacheService>.Instance);
}