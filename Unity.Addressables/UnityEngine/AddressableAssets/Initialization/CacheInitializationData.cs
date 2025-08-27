namespace UnityEngine.AddressableAssets.Initialization;

public class CacheInitializationData
{
	[FormerlySerializedAs("m_compressionEnabled")]
	[SerializeField]
	private bool m_CompressionEnabled; //Field offset: 0x10
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	[SerializeField]
	private string m_CacheDirectoryOverride; //Field offset: 0x18
	[FormerlySerializedAs("m_expirationDelay")]
	[SerializeField]
	private int m_ExpirationDelay; //Field offset: 0x20
	[FormerlySerializedAs("m_limitCacheSize")]
	[SerializeField]
	private bool m_LimitCacheSize; //Field offset: 0x24
	[FormerlySerializedAs("m_maximumCacheSize")]
	[SerializeField]
	private long m_MaximumCacheSize; //Field offset: 0x28

	public string CacheDirectoryOverride
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public bool CompressionEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[Obsolete("Functionality remains unchanged.  However, due to issues with Caching this property is being marked obsolete.  See Caching API documentation for more details.")]
	public int ExpirationDelay
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool LimitCacheSize
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public long MaximumCacheSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public CacheInitializationData() { }

	public string get_CacheDirectoryOverride() { }

	public bool get_CompressionEnabled() { }

	public int get_ExpirationDelay() { }

	public bool get_LimitCacheSize() { }

	public long get_MaximumCacheSize() { }

	public void set_CacheDirectoryOverride(string value) { }

	public void set_CompressionEnabled(bool value) { }

	public void set_ExpirationDelay(int value) { }

	public void set_LimitCacheSize(bool value) { }

	public void set_MaximumCacheSize(long value) { }

}

