namespace UnityEngine.ResourceManagement.ResourceProviders;

public class AssetBundleRequestOptions : ILocationSizeData
{
	[FormerlySerializedAs("m_hash")]
	[SerializeField]
	private string m_Hash; //Field offset: 0x10
	[FormerlySerializedAs("m_crc")]
	[SerializeField]
	private uint m_Crc; //Field offset: 0x18
	[FormerlySerializedAs("m_timeout")]
	[SerializeField]
	private int m_Timeout; //Field offset: 0x1C
	[FormerlySerializedAs("m_chunkedTransfer")]
	[SerializeField]
	private bool m_ChunkedTransfer; //Field offset: 0x20
	[FormerlySerializedAs("m_redirectLimit")]
	[SerializeField]
	private int m_RedirectLimit; //Field offset: 0x24
	[FormerlySerializedAs("m_retryCount")]
	[SerializeField]
	private int m_RetryCount; //Field offset: 0x28
	[SerializeField]
	private string m_BundleName; //Field offset: 0x30
	[SerializeField]
	private AssetLoadMode m_AssetLoadMode; //Field offset: 0x38
	[SerializeField]
	private long m_BundleSize; //Field offset: 0x40
	[SerializeField]
	private bool m_UseCrcForCachedBundles; //Field offset: 0x48
	[SerializeField]
	private bool m_UseUWRForLocalBundles; //Field offset: 0x49
	[SerializeField]
	private bool m_ClearOtherCachedVersionsWhenLoaded; //Field offset: 0x4A

	public AssetLoadMode AssetLoadMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string BundleName
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public long BundleSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public bool ChunkedTransfer
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool ClearOtherCachedVersionsWhenLoaded
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public uint Crc
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string Hash
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public int RedirectLimit
	{
		 get { } //Length: 14
		 set { } //Length: 4
	}

	public int RetryCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int Timeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool UseCrcForCachedBundle
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool UseUnityWebRequestForLocalBundles
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public AssetBundleRequestOptions() { }

	public override long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	public AssetLoadMode get_AssetLoadMode() { }

	public string get_BundleName() { }

	public long get_BundleSize() { }

	public bool get_ChunkedTransfer() { }

	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	public uint get_Crc() { }

	public string get_Hash() { }

	public int get_RedirectLimit() { }

	public int get_RetryCount() { }

	public int get_Timeout() { }

	public bool get_UseCrcForCachedBundle() { }

	public bool get_UseUnityWebRequestForLocalBundles() { }

	public void set_AssetLoadMode(AssetLoadMode value) { }

	public void set_BundleName(string value) { }

	public void set_BundleSize(long value) { }

	public void set_ChunkedTransfer(bool value) { }

	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	public void set_Crc(uint value) { }

	public void set_Hash(string value) { }

	public void set_RedirectLimit(int value) { }

	public void set_RetryCount(int value) { }

	public void set_Timeout(int value) { }

	public void set_UseCrcForCachedBundle(bool value) { }

	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

}

