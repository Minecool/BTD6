namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache; //Field offset: 0x10
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18
	private RequestCachePolicy m_Policy; //Field offset: 0x20

	internal RequestCache Cache
	{
		internal get { } //Length: 5
	}

	internal RequestCachePolicy Policy
	{
		internal get { } //Length: 5
	}

	internal RequestCacheValidator Validator
	{
		internal get { } //Length: 5
	}

	internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) { }

	internal RequestCache get_Cache() { }

	internal RequestCachePolicy get_Policy() { }

	internal RequestCacheValidator get_Validator() { }

}

