namespace NinjaKiwi.LiNK.Client.SyncedFiles;

public class LiNKSyncedFile : SyncedFile<T>
{
	[CompilerGenerated]
	private struct <FindSyncOutcome>d__8 : IAsyncStateMachine
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
	private struct <GetRemoteDeviceID>d__13 : IAsyncStateMachine
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
	private struct <ResolveSyncConflict>d__9 : IAsyncStateMachine
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
	private struct <SendToRemote>d__10 : IAsyncStateMachine
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
	private struct <Sync>d__6 : IAsyncStateMachine
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

	[CompilerGenerated]
	private LiNKAccount <LiNKAccount>k__BackingField; //Field offset: 0x0
	private readonly Guid ADMIN_GUID; //Field offset: 0x0

	public private LiNKAccount LiNKAccount
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LiNKSyncedFile`1(File<T> baseFile) { }

	[AsyncStateMachine(typeof(<FindSyncOutcome>d__8))]
	private Task<SyncOutcome<T>> FindSyncOutcome(bool firstSync) { }

	[CompilerGenerated]
	private LiNKAccount get_LiNKAccount() { }

	[AsyncStateMachine(typeof(<GetRemoteDeviceID>d__13))]
	private Task<Nullable`1<Guid>> GetRemoteDeviceID() { }

	private Task<StorageModel> LoadFromRemote() { }

	[AsyncStateMachine(typeof(<ResolveSyncConflict>d__9))]
	private Task<Boolean> ResolveSyncConflict(StorageModel remoteStorageModel, SyncContext<T> syncContext) { }

	private void SaveToLocal(StorageModel storageModel) { }

	[AsyncStateMachine(typeof(<SendToRemote>d__10))]
	private Task SendToRemote() { }

	[CompilerGenerated]
	public void set_LiNKAccount(LiNKAccount value) { }

	[AsyncStateMachine(typeof(<Sync>d__6))]
	protected virtual Task Sync(SyncContext<T> syncContext) { }

}

