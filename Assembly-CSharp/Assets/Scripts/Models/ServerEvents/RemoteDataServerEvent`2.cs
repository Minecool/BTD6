namespace Assets.Scripts.Models.ServerEvents;

public class RemoteDataServerEvent : ServerEvent<T>
{
	[CompilerGenerated]
	private struct <GetData>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T2> <>t__builder; //Field offset: 0x0
		public RemoteDataServerEvent<T, T2> <>4__this; //Field offset: 0x0
		private TaskAwaiter<T2> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Dictionary<Type, String> dataFolders; //Field offset: 0x0
	[JsonProperty("name")]
	public string dataId; //Field offset: 0x0
	private Task<T2> eventDataTask; //Field offset: 0x0
	private T2 eventData; //Field offset: 0x0

	public T2 CachedEventData
	{
		 get { } //Length: 5
	}

	public bool HasCachedEventData
	{
		 get { } //Length: 9
	}

	private static RemoteDataServerEvent`2() { }

	public RemoteDataServerEvent`2() { }

	public T2 get_CachedEventData() { }

	public bool get_HasCachedEventData() { }

	[AsyncStateMachine(typeof(<GetData>d__8))]
	public Task<T2> GetData() { }

	protected override T2 ValidateData(T2 eventData) { }

}

