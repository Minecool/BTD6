namespace NinjaKiwi.Common;

public class LocAssetHandle_Addressable : LocAssetHandle<T>
{
	[CompilerGenerated]
	private struct <Load>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string address; //Field offset: 0x0
		public LocAssetHandle_Addressable<T> <>4__this; //Field offset: 0x0
		private AsyncOperationHandle<IList`1<IResourceLocation>> <locationReq>5__2; //Field offset: 0x0
		private TaskAwaiter<IList`1<IResourceLocation>> <>u__1; //Field offset: 0x0
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private AsyncOperationHandle<T> handle; //Field offset: 0x0

	public virtual T Asset
	{
		 get { } //Length: 90
	}

	public LocAssetHandle_Addressable`1(string address) { }

	public virtual T get_Asset() { }

	[AsyncStateMachine(typeof(<Load>d__4))]
	protected virtual Task Load(string address) { }

	public virtual void Release() { }

}

