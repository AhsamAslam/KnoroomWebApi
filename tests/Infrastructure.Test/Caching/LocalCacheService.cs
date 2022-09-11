using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging.Abstractions;

namespace Infrastructure.Test.Caching;

public class LocalCacheService : CacheService<Knorooms.WebApi.Infrastructure.Caching.LocalCacheService>
{
    protected override Knorooms.WebApi.Infrastructure.Caching.LocalCacheService CreateCacheService() =>
        new(
            new MemoryCache(new MemoryCacheOptions()),
            NullLogger<Knorooms.WebApi.Infrastructure.Caching.LocalCacheService>.Instance);
}