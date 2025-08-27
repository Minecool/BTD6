namespace NinjaKiwi.LiNK.Client.Caching;

public interface ICache
{

	public void Clear() { }

	public bool Delete(string key) { }

	public Task<Byte[]> Get(string key, float ttlMinutes, IDataLoader dataLoader) { }

	public Task<CacheEntry> GetCacheEntry(string key, float ttlMinutes, IDataLoader dataLoader) { }

}

