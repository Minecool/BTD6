namespace NinjaKiwi.LiNK.Endpoints;

public class Squad_Poll : Endpoint<Response>
{
	[CompilerGenerated]
	private struct <Call>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SquadModel> <>t__builder; //Field offset: 0x8
		public Squad_Poll <>4__this; //Field offset: 0x20
		private TaskAwaiter<Response> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CallImmediate>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SquadModel> <>t__builder; //Field offset: 0x8
		public Squad_Poll <>4__this; //Field offset: 0x20
		private TaskAwaiter<Response> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class Poller : IDisposable
	{
		[CompilerGenerated]
		private struct <Delay>d__9 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TimeSpan delayTime; //Field offset: 0x20
			private DateTime <delayEnd>5__2; //Field offset: 0x28
			private YieldAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Poll>d__7 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Poller <>4__this; //Field offset: 0x20
			private int <>7__wrap1; //Field offset: 0x28
			private TaskAwaiter<Response> <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <RunAsyncVoid>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public Task task; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <RunPoll>d__6 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public Poller <>4__this; //Field offset: 0x28
			private TaskAwaiter<Task> <>u__1; //Field offset: 0x30
			private YieldAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly Squad_Poll endpoint; //Field offset: 0x10
		private Action<SquadModel> pollAction; //Field offset: 0x18
		private string updateKey; //Field offset: 0x20

		internal Poller(Squad_Poll endpoint, Action<SquadModel> pollAction) { }

		public void Cancel() { }

		[AsyncStateMachine(typeof(<Delay>d__9))]
		private static Task Delay(TimeSpan delayTime) { }

		public override void Dispose() { }

		[AsyncStateMachine(typeof(<Poll>d__7))]
		private Task Poll() { }

		[AsyncStateMachine(typeof(<RunAsyncVoid>d__8))]
		private static void RunAsyncVoid(Task task) { }

		[AsyncStateMachine(typeof(<RunPoll>d__6))]
		private void RunPoll() { }

	}

	[DataContract]
	internal class Response
	{
		[DataMember(Name = "party")]
		public SquadModel squad; //Field offset: 0x10
		[DataMember(Name = "updateKey")]
		public string updateKey; //Field offset: 0x18
		[DataMember(Name = "joinedParty")]
		internal bool joinedSquad; //Field offset: 0x20

		public Response() { }

		[OnDeserialized]
		internal void OnDeserialized(StreamingContext streamingContext) { }

	}

	private static readonly TimeSpan longPollDefaultTimeout; //Field offset: 0x0
	private string updateKey; //Field offset: 0x38
	private Poller poller; //Field offset: 0x40

	public TimeSpan LongPollTimeout
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	private static Squad_Poll() { }

	internal Squad_Poll(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__3))]
	public Task<SquadModel> Call() { }

	public Task<Response> CallBasic(string updateKey) { }

	[AsyncStateMachine(typeof(<CallImmediate>d__2))]
	public Task<SquadModel> CallImmediate() { }

	public TimeSpan get_LongPollTimeout() { }

	public Poller GetPoller(Action<SquadModel> pollAction) { }

	public void set_LongPollTimeout(TimeSpan value) { }

	public void StartPolling(Action<SquadModel> pollAction) { }

	public void StopPolling() { }

}

