namespace System.Net.Http.Headers;

public sealed class HttpContentHeaders : HttpHeaders
{
	private readonly HttpContent content; //Field offset: 0x20

	public Nullable<Int64> ContentLength
	{
		 get { } //Length: 424
	}

	public MediaTypeHeaderValue ContentType
	{
		 get { } //Length: 76
		 set { } //Length: 100
	}

	internal HttpContentHeaders(HttpContent content) { }

	public Nullable<Int64> get_ContentLength() { }

	public MediaTypeHeaderValue get_ContentType() { }

	public void set_ContentType(MediaTypeHeaderValue value) { }

}

