namespace NinjaKiwi.LiNK.Client.Caching;

public interface IDataLoader
{
	[CompilerGenerated]
	private struct <Get>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public IDataLoader <>4__this; //Field offset: 0x20
		public string dataKey; //Field offset: 0x28
		private TaskAwaiter<DataAndEtag> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public Task<DataAndEtag> Get(string dataKey, DataAndEtag existing) { }

	[AsyncStateMachine(typeof(<Get>d__1))]
	public Task<Byte[]> Get(string dataKey) { }

}

