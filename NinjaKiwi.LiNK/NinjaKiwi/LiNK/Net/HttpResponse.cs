namespace NinjaKiwi.LiNK.Net;

public class HttpResponse
{
	public readonly int statusCode; //Field offset: 0x10
	public readonly string etag; //Field offset: 0x18
	public readonly Byte[] data; //Field offset: 0x20

	public HttpResponse(int statusCode, string etag, Byte[] data) { }

}

