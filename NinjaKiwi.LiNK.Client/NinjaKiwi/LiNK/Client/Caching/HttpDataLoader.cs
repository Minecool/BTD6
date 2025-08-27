namespace NinjaKiwi.LiNK.Client.Caching;

public class HttpDataLoader : IHttpDataLoader, IDataLoader
{
	[CompilerGenerated]
	private struct <Get>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DataAndEtag> <>t__builder; //Field offset: 0x8
		public DataAndEtag existing; //Field offset: 0x20
		public HttpDataLoader <>4__this; //Field offset: 0x28
		private Byte[] <existingData>5__2; //Field offset: 0x30
		private string <existingEtag>5__3; //Field offset: 0x38
		private TaskAwaiter<HttpResponse> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string url; //Field offset: 0x10
	private readonly HttpRequestFactory httpRequestFactory; //Field offset: 0x18

	public HttpDataLoader(string url) { }

	[AsyncStateMachine(typeof(<Get>d__4))]
	public override Task<DataAndEtag> Get(string _, DataAndEtag existing) { }

	public override void SetUp(ContentEncoding requestEncoding = 0, ContentEncoding responseEncoding = 0, bool responseCompression = true, TimeSpan timeout = null) { }

}

