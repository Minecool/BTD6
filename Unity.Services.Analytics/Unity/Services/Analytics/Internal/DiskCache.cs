namespace Unity.Services.Analytics.Internal;

internal class DiskCache : IDiskCache
{
	private readonly string k_CacheFilePath; //Field offset: 0x10
	private readonly IFileSystemCalls k_SystemCalls; //Field offset: 0x18
	private readonly long k_CacheFileMaximumSize; //Field offset: 0x20

	internal DiskCache(IFileSystemCalls systemCalls) { }

	public override void Clear() { }

	public override void Write(List<Int32> eventEndIndices, Stream payload) { }

}

