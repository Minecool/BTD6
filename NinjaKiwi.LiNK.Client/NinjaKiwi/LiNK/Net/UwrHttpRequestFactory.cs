namespace NinjaKiwi.LiNK.Net;

public class UwrHttpRequestFactory : HttpRequestFactory
{
	[CompilerGenerated]
	private struct <Send>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponse> <>t__builder; //Field offset: 0x8
		public UnityWebRequest request; //Field offset: 0x20
		public UwrHttpRequestFactory <>4__this; //Field offset: 0x28
		private DateTime <timeoutEnd>5__2; //Field offset: 0x30
		private Exception <ex>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAndMonitor>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponse> <>t__builder; //Field offset: 0x8
		public UnityWebRequest request; //Field offset: 0x20
		public UwrHttpRequestFactory <>4__this; //Field offset: 0x28
		private UnityWebRequest <>7__wrap1; //Field offset: 0x30
		private NetworkException <exception>5__3; //Field offset: 0x38
		private TaskAwaiter<HttpResponse> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public UwrHttpRequestFactory() { }

	public virtual Task<HttpResponse> Get(string url, string etag) { }

	public virtual Task<HttpResponse> Head(string url, string etag) { }

	public virtual Task<HttpResponse> Post(string url, Byte[] data) { }

	[AsyncStateMachine(typeof(<Send>d__8))]
	private Task<HttpResponse> Send(UnityWebRequest request) { }

	[AsyncStateMachine(typeof(<SendAndMonitor>d__7))]
	private Task<HttpResponse> SendAndMonitor(UnityWebRequest request) { }

	private void SetRequestEtagHeader(string etag, UnityWebRequest request) { }

	private void SetRequestInfoHeaders(UnityWebRequest request) { }

	private void SetResponseInfoHeaders(UnityWebRequest request) { }

	private void SetUserAgentHeader(UnityWebRequest request) { }

}

