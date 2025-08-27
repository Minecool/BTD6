namespace UnityEngine;

[NativeHeader("Runtime/Misc/CachingManager.h")]
[StaticAccessor("GetCachingManager()", StaticAccessorType::Dot (0))]
public sealed class Caching
{

	public static int cacheCount
	{
		 get { } //Length: 42
	}

	public static bool compressionEnabled
	{
		 set { } //Length: 51
	}

	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache currentCacheForWriting
	{
		[NativeName("Caching_GetCurrentCacheHandle")]
		 get { } //Length: 59
		[NativeName("Caching_SetCurrentCacheByHandle")]
		[NativeThrows]
		 set { } //Length: 51
	}

	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache defaultCache
	{
		[NativeName("Caching_GetDefaultCacheHandle")]
		 get { } //Length: 59
	}

	public static bool ready
	{
		[NativeName("GetIsReady")]
		 get { } //Length: 42
	}

	[NativeName("AddCachePath")]
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	public static Cache AddCache(string cachePath) { }

	private static void AddCache_Injected(ref ManagedSpanWrapper cachePath, bool isReadonly, out Cache ret) { }

	public static bool ClearAllCachedVersions(string assetBundleName) { }

	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash) { }

	[NativeName("ClearCachedVersion")]
	internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash) { }

	private static bool ClearCachedVersionInternal_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	private static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash, bool keepInputVersion) { }

	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	public static int get_cacheCount() { }

	[NativeName("Caching_GetCurrentCacheHandle")]
	public static Cache get_currentCacheForWriting() { }

	private static void get_currentCacheForWriting_Injected(out Cache ret) { }

	[NativeName("Caching_GetDefaultCacheHandle")]
	public static Cache get_defaultCache() { }

	private static void get_defaultCache_Injected(out Cache ret) { }

	[NativeName("GetIsReady")]
	public static bool get_ready() { }

	public static void GetAllCachePaths(List<String> cachePaths) { }

	[NativeName("Caching_GetCacheHandleAt")]
	[NativeThrows]
	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache GetCacheAt(int cacheIndex) { }

	private static void GetCacheAt_Injected(int cacheIndex, out Cache ret) { }

	[NativeName("Caching_GetCacheHandleByPath")]
	[NativeThrows]
	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache GetCacheByPath(string cachePath) { }

	private static void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret) { }

	public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions) { }

	internal static Hash128[] GetCachedVersions(string assetBundleName) { }

	private static void GetCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, out BlittableArrayWrapper ret) { }

	public static bool IsVersionCached(CachedAssetBundle cachedBundle) { }

	[NativeName("IsCached")]
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	private static bool IsVersionCached_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	public static void set_compressionEnabled(bool value) { }

	[NativeName("Caching_SetCurrentCacheByHandle")]
	[NativeThrows]
	public static void set_currentCacheForWriting(Cache value) { }

	private static void set_currentCacheForWriting_Injected(in Cache value) { }

}

