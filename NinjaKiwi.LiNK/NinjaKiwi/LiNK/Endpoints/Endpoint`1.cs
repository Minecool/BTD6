namespace NinjaKiwi.LiNK.Endpoints;

public abstract class Endpoint : EndpointBase
{
	[CompilerGenerated]
	private struct <SendRequest>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Endpoint<T> <>4__this; //Field offset: 0x0
		public string endpoint; //Field offset: 0x0
		public object data; //Field offset: 0x0
		private TaskAwaiter<String> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal Endpoint`1(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	protected override T Receive(string json) { }

	[AsyncStateMachine(typeof(<SendRequest>d__1))]
	protected Task<T> SendRequest(string endpoint, object data = null) { }

}

