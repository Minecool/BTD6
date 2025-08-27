namespace NinjaKiwi.LiNK.Client.Caching;

public class CacheEntry
{
	public readonly string key; //Field offset: 0x10
	public readonly DateTime storedTime; //Field offset: 0x18
	public readonly TimeSpan ttl; //Field offset: 0x20
	public readonly string etag; //Field offset: 0x28
	private readonly Byte[] value; //Field offset: 0x30

	public bool Expired
	{
		 get { } //Length: 156
	}

	public TimeSpan TTLRemaining
	{
		 get { } //Length: 246
	}

	public Byte[] Value
	{
		 get { } //Length: 78
	}

	public CacheEntry(string key, Byte[] value, DateTime storedTime, TimeSpan ttl, string etag) { }

	public bool get_Expired() { }

	public TimeSpan get_TTLRemaining() { }

	public Byte[] get_Value() { }

}

