namespace System.Net.Http;

public class HttpResponseMessage : IDisposable
{
	private HttpResponseHeaders headers; //Field offset: 0x10
	private string reasonPhrase; //Field offset: 0x18
	private HttpStatusCode statusCode; //Field offset: 0x20
	private Version version; //Field offset: 0x28
	private bool disposed; //Field offset: 0x30
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private HttpRequestMessage <RequestMessage>k__BackingField; //Field offset: 0x40

	public HttpContent Content
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public HttpResponseHeaders Headers
	{
		 get { } //Length: 149
	}

	public bool IsSuccessStatusCode
	{
		 get { } //Length: 23
	}

	public string ReasonPhrase
	{
		 get { } //Length: 20
		 set { } //Length: 5
	}

	public HttpRequestMessage RequestMessage
	{
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public HttpStatusCode StatusCode
	{
		 get { } //Length: 4
		 set { } //Length: 82
	}

	public Version Version
	{
		 get { } //Length: 94
	}

	public HttpResponseMessage(HttpStatusCode statusCode) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	public HttpContent get_Content() { }

	public HttpResponseHeaders get_Headers() { }

	public bool get_IsSuccessStatusCode() { }

	public string get_ReasonPhrase() { }

	public HttpStatusCode get_StatusCode() { }

	public Version get_Version() { }

	[CompilerGenerated]
	public void set_Content(HttpContent value) { }

	public void set_ReasonPhrase(string value) { }

	[CompilerGenerated]
	public void set_RequestMessage(HttpRequestMessage value) { }

	public void set_StatusCode(HttpStatusCode value) { }

	public virtual string ToString() { }

}

