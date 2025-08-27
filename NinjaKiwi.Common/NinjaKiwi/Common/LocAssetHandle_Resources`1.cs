namespace NinjaKiwi.Common;

public class LocAssetHandle_Resources : LocAssetHandle<T>
{
	[CompilerGenerated]
	private struct <Load>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string address; //Field offset: 0x0
		public LocAssetHandle_Resources<T> <>4__this; //Field offset: 0x0
		private ResourceRequest <asyncLoad>5__2; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private T asset; //Field offset: 0x0

	public virtual T Asset
	{
		 get { } //Length: 5
	}

	public LocAssetHandle_Resources`1(string address) { }

	public virtual T get_Asset() { }

	[AsyncStateMachine(typeof(<Load>d__4))]
	protected virtual Task Load(string address) { }

}

