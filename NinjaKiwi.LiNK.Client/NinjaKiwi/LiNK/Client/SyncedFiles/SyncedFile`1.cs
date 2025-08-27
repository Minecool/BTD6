namespace NinjaKiwi.LiNK.Client.SyncedFiles;

public abstract class SyncedFile
{
	[CompilerGenerated]
	private struct <Sync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public SyncedFile<T> <>4__this; //Field offset: 0x0
		private TaskCompletionSource<Boolean> <syncTcs>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class Flag
	{
		[CompilerGenerated]
		private string <CurrentID>k__BackingField; //Field offset: 0x0

		public private string CurrentID
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public Flag() { }

		public void ClearIfIdMatches(string id) { }

		[CompilerGenerated]
		public string get_CurrentID() { }

		public static bool op_Implicit(Flag<T> flag) { }

		public void Set() { }

		[CompilerGenerated]
		private void set_CurrentID(string value) { }

	}

	internal class SyncContext
	{
		public readonly bool isFirstSync; //Field offset: 0x0
		private readonly SyncedFile<T> syncedFile; //Field offset: 0x0
		private readonly Task resolveTask; //Field offset: 0x0

		public SyncContext(SyncedFile<T> syncedFile, bool isFirstSync, Task resolveTask) { }

		public Task<Boolean> EmitDataConflict(T localData, T remoteData, Exception remoteDataError) { }

		public Task EmitDataInvalid() { }

	}

	[CompilerGenerated]
	private Action<DataConflict`1<T>> <OnDataConflict>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action<DataInvalid> <OnDataInvalid>k__BackingField; //Field offset: 0x0
	public readonly string name; //Field offset: 0x0
	protected readonly File<T> file; //Field offset: 0x0
	protected readonly Flag<T> modifiedSinceSync; //Field offset: 0x0
	protected private readonly Logger logger; //Field offset: 0x0
	private bool isFirstSync; //Field offset: 0x0
	[CompilerGenerated]
	private Action CheckingEtagEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action SyncingDataEvent; //Field offset: 0x0

	public event Action CheckingEtagEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action SyncingDataEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public T Content
	{
		 get { } //Length: 27
		 set { } //Length: 27
	}

	public private Action<DataConflict`1<T>> OnDataConflict
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public private Action<DataInvalid> OnDataInvalid
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	protected SyncedFile`1(File<T> baseFile) { }

	[CompilerGenerated]
	public void add_CheckingEtagEvent(Action value) { }

	[CompilerGenerated]
	public void add_SyncingDataEvent(Action value) { }

	public void Deactivate() { }

	private Task<Boolean> EmitDataConflict(T localData, T remoteData, bool isFirstSync, Exception remoteDataError, Task resolveTask) { }

	private Task EmitDataInvalid(Task resolveTask) { }

	public T get_Content() { }

	[CompilerGenerated]
	private Action<DataConflict`1<T>> get_OnDataConflict() { }

	[CompilerGenerated]
	private Action<DataInvalid> get_OnDataInvalid() { }

	public string GetBinary() { }

	protected void OnBeginCheckingEtag() { }

	protected void OnBeginSyncingData() { }

	[CompilerGenerated]
	public void remove_CheckingEtagEvent(Action value) { }

	[CompilerGenerated]
	public void remove_SyncingDataEvent(Action value) { }

	public void Save() { }

	public void set_Content(T value) { }

	[CompilerGenerated]
	public void set_OnDataConflict(Action<DataConflict`1<T>> value) { }

	[CompilerGenerated]
	public void set_OnDataInvalid(Action<DataInvalid> value) { }

	public void SetContentAndSave(T newContent) { }

	protected abstract Task Sync(SyncContext<T> syncContext) { }

	[AsyncStateMachine(typeof(<Sync>d__14))]
	public Task Sync() { }

	public void WipeLocalStorage() { }

}

