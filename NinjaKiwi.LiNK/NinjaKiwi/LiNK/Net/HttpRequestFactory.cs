namespace NinjaKiwi.LiNK.Net;

public abstract class HttpRequestFactory
{
	protected private Action<NetworkException> OnRequestStatusUpdate; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsDisabled>k__BackingField; //Field offset: 0x18
	protected ContentEncoding requestEncoding; //Field offset: 0x1C
	protected ContentEncoding responseEncoding; //Field offset: 0x20
	protected bool responseCompression; //Field offset: 0x24
	private TimeSpan defaultTimeout; //Field offset: 0x28
	private Nullable<TimeSpan> customTimeout; //Field offset: 0x30

	public bool IsDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TimeSpan TimeoutForNextRequest
	{
		 get { } //Length: 81
		 set { } //Length: 92
	}

	protected HttpRequestFactory() { }

	public abstract Task<HttpResponse> Get(string url, string etag) { }

	[CompilerGenerated]
	protected bool get_IsDisabled() { }

	public TimeSpan get_TimeoutForNextRequest() { }

	protected TimeSpan GetNextTimeoutAndClearCustomValue() { }

	public abstract Task<HttpResponse> Head(string url, string etag) { }

	public abstract Task<HttpResponse> Post(string url, Byte[] data) { }

	[CompilerGenerated]
	public void set_IsDisabled(bool value) { }

	public void set_TimeoutForNextRequest(TimeSpan value) { }

	public HttpRequestFactory SetUp(ContentEncoding requestEncoding = 0, ContentEncoding responseEncoding = 0, bool responseCompression = true, TimeSpan timeout = null) { }

}

