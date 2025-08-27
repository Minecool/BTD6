namespace NinjaKiwi.LiNK;

internal class OnlineUtility
{
	[CompilerGenerated]
	private struct <IsOnline>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public OnlineUtility <>4__this; //Field offset: 0x20
		public TimeSpan checkIfNotCheckedWithin; //Field offset: 0x28
		public Func<Task> testRequestFunc; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class RequestStatus
	{
		public readonly bool success; //Field offset: 0x10
		public readonly NetworkException exception; //Field offset: 0x18
		public readonly DateTime startTimeUtc; //Field offset: 0x20

		public TimeSpan Age
		{
			 get { } //Length: 85
		}

		public RequestStatus(NetworkException exception) { }

		public TimeSpan get_Age() { }

		public bool IsOlderThan(TimeSpan threshold) { }

	}

	[CompilerGenerated]
	private Action BackOnlineEvent; //Field offset: 0x10
	private readonly Func<Task> defaultRequestFunc; //Field offset: 0x18
	private RequestStatus lastRequestStatus; //Field offset: 0x20
	private RequestStatus lastSuccessfulRequestStatus; //Field offset: 0x28

	public event Action BackOnlineEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Nullable<TimeSpan> TimeSinceOnline
	{
		 get { } //Length: 194
	}

	public OnlineUtility(Func<Task> defaultRequestFunc) { }

	[CompilerGenerated]
	public void add_BackOnlineEvent(Action value) { }

	public Nullable<TimeSpan> get_TimeSinceOnline() { }

	[AsyncStateMachine(typeof(<IsOnline>d__8))]
	public Task<Boolean> IsOnline(TimeSpan checkIfNotCheckedWithin, Func<Task> testRequestFunc = null) { }

	[CompilerGenerated]
	public void remove_BackOnlineEvent(Action value) { }

	public void UpdateRequestStatus(NetworkException exception) { }

}

