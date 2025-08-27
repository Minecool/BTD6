namespace NinjaKiwi.LiNK.Client.SyncedFiles;

public class LiNKSyncedFile : SyncedFile<T>
{
	[CompilerGenerated]
	private struct <FindSyncOutcome>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SyncOutcome<T>> <>t__builder; //Field offset: 0x0
		public LiNKSyncedFile<T> <>4__this; //Field offset: 0x0
		public bool firstSync; //Field offset: 0x0
		private TaskAwaiter<Nullable`1<Guid>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRemoteDeviceID>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Nullable`1<Guid>> <>t__builder; //Field offset: 0x0
		public LiNKSyncedFile<T> <>4__this; //Field offset: 0x0
		private TaskAwaiter<StorageModel> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResolveSyncConflict>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		public LiNKSyncedFile<T> <>4__this; //Field offset: 0x0
		public StorageModel remoteStorageModel; //Field offset: 0x0
		public SyncContext<T> syncContext; //Field offset: 0x0
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendToRemote>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public LiNKSyncedFile<T> <>4__this; //Field offset: 0x0
		private string <modifiedStateBeforeUpload>5__2; //Field offset: 0x0
		private TaskAwaiter<StorageModel> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Sync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public LiNKSyncedFile<T> <>4__this; //Field offset: 0x0
		public SyncContext<T> syncContext; //Field offset: 0x0
		private TaskAwaiter<SyncOutcome<T>> <>u__1; //Field offset: 0x0
		private StorageModel <remoteData>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter<StorageModel> <>u__3; //Field offset: 0x0
		private TaskAwaiter<Boolean> <>u__4; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum SyncOutcome
	{
		NOTHING = 0,
		UPLOAD = 1,
		DOWNLOAD = 2,
		OVERWRITE = 3,
		CONFLICT = 4,
	}

	private readonly Guid ADMIN_GUID; //Field offset: 0x0

	public LiNKSyncedFile`1(File<T> baseFile) { }

	[AsyncStateMachine(typeof(<FindSyncOutcome>d__4))]
	private Task<SyncOutcome<T>> FindSyncOutcome(bool firstSync) { }

	[AsyncStateMachine(typeof(<GetRemoteDeviceID>d__9))]
	private Task<Nullable`1<Guid>> GetRemoteDeviceID() { }

	private Task<StorageModel> LoadFromRemote() { }

	[AsyncStateMachine(typeof(<ResolveSyncConflict>d__5))]
	private Task<Boolean> ResolveSyncConflict(StorageModel remoteStorageModel, SyncContext<T> syncContext) { }

	private void SaveToLocal(StorageModel storageModel) { }

	[AsyncStateMachine(typeof(<SendToRemote>d__6))]
	private Task SendToRemote() { }

	[AsyncStateMachine(typeof(<Sync>d__2))]
	protected virtual Task Sync(SyncContext<T> syncContext) { }

}

