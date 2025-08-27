namespace System.Net.Http;

public class HttpRequestMessage : IDisposable
{
	private HttpRequestHeaders headers; //Field offset: 0x10
	private HttpMethod method; //Field offset: 0x18
	private Version version; //Field offset: 0x20
	private Uri uri; //Field offset: 0x28
	private bool is_used; //Field offset: 0x30
	private bool disposed; //Field offset: 0x31
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; //Field offset: 0x38

	public HttpContent Content
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public HttpRequestHeaders Headers
	{
		 get { } //Length: 148
	}

	public HttpMethod Method
	{
		 get { } //Length: 5
		 set { } //Length: 157
	}

	public Uri RequestUri
	{
		 get { } //Length: 5
		 set { } //Length: 501
	}

	public Version Version
	{
		 get { } //Length: 94
	}

	public HttpRequestMessage(HttpMethod method, string requestUri) { }

	public HttpRequestMessage(HttpMethod method, Uri requestUri) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public HttpContent get_Content() { }

	public HttpRequestHeaders get_Headers() { }

	public HttpMethod get_Method() { }

	public Uri get_RequestUri() { }

	public Version get_Version() { }

	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	[CompilerGenerated]
	public void set_Content(HttpContent value) { }

	public void set_Method(HttpMethod value) { }

	public void set_RequestUri(Uri value) { }

	internal bool SetIsUsed() { }

	public virtual string ToString() { }

}

