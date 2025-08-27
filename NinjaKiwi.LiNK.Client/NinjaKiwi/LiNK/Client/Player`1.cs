namespace NinjaKiwi.LiNK.Client;

public class Player : ILiNKAccountHolder
{
	[CompilerGenerated]
	private struct <ActuallyBackup>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Player<DataT> <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Backup>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Player<DataT> <>4__this; //Field offset: 0x0
		private TaskAwaiter<Task> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckWhetherPlayingOnAnotherDevice>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		public Player<DataT> <>4__this; //Field offset: 0x0
		public Task resolveTask; //Field offset: 0x0
		private TaskAwaiter<SetPlaySessionResponse> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ManualBackup>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Player<DataT> <>4__this; //Field offset: 0x0
		public CancellationToken canceller; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ScheduledCheckAndBackup>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public Player<DataT> <>4__this; //Field offset: 0x0
		public int counter; //Field offset: 0x0
		public bool needToBackup; //Field offset: 0x0
		private TaskCompletionSource<Boolean> <checkTaskCompletionSource>5__2; //Field offset: 0x0
		private bool <forceBackup>5__3; //Field offset: 0x0
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Api <LiNK>k__BackingField; //Field offset: 0x0
	private File<SavedIdentity> identityFile; //Field offset: 0x0
	private SyncedFile<DataT> dataFile; //Field offset: 0x0
	private BackupTimer autoBackupTimer; //Field offset: 0x0
	private PlayerOptions options; //Field offset: 0x0
	internal readonly Logger logger; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Exception> ErrorEvent; //Field offset: 0x0
	private Task backupInProgress; //Field offset: 0x0
	[CompilerGenerated]
	private Action CheckPlaySessionDoneEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action BackupStartedEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action CheckingEtagEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action CheckingPlaySessionEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action<PlaySessionConflict> <PlaySessionConflictAction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private LiNKAccountController <LiNKAccountController>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private LiNKAccount <LiNKAccount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action BackupDoneEvent; //Field offset: 0x0
	private bool deactivated; //Field offset: 0x0

	public event Action BackupDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action BackupStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action CheckingEtagEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action CheckingPlaySessionEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action CheckPlaySessionDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	internal event Action<Exception> ErrorEvent
	{
		[CompilerGenerated]
		internal add { } //Length: 172
		[CompilerGenerated]
		internal remove { } //Length: 172
	}

	public DataT Data
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public Action<DataConflict`1<DataT>> DataConflictAction
	{
		 set { } //Length: 27
	}

	public Action<DataInvalid> DataInvalidAction
	{
		 set { } //Length: 27
	}

	public string ID
	{
		 get { } //Length: 48
	}

	public private Api LiNK
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private LiNKAccount LiNKAccount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private LiNKAccountController LiNKAccountController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public string NoLiNKID
	{
		 get { } //Length: 29
	}

	public private Action<PlaySessionConflict> PlaySessionConflictAction
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Player`1() { }

	[CompilerGenerated]
	private void <Initialise>b__52_0() { }

	[CompilerGenerated]
	private void <Initialise>b__52_1() { }

	[AsyncStateMachine(typeof(<ActuallyBackup>d__58))]
	private Task ActuallyBackup() { }

	[CompilerGenerated]
	public void add_BackupDoneEvent(Action value) { }

	[CompilerGenerated]
	public void add_BackupStartedEvent(Action value) { }

	[CompilerGenerated]
	public void add_CheckingEtagEvent(Action value) { }

	[CompilerGenerated]
	public void add_CheckingPlaySessionEvent(Action value) { }

	[CompilerGenerated]
	public void add_CheckPlaySessionDoneEvent(Action value) { }

	[CompilerGenerated]
	internal void add_ErrorEvent(Action<Exception> value) { }

	[AsyncStateMachine(typeof(<Backup>d__56))]
	public Task Backup() { }

	private Task BackupIfNoneInProgress() { }

	private Task<SetPlaySessionResponse> CheckPlaySession(bool overrideRemote) { }

	[AsyncStateMachine(typeof(<CheckWhetherPlayingOnAnotherDevice>d__62))]
	private Task<Boolean> CheckWhetherPlayingOnAnotherDevice(Task resolveTask) { }

	public void Deactivate() { }

	public DataT get_Data() { }

	public string get_ID() { }

	[CompilerGenerated]
	public Api get_LiNK() { }

	[CompilerGenerated]
	public LiNKAccount get_LiNKAccount() { }

	[CompilerGenerated]
	public LiNKAccountController get_LiNKAccountController() { }

	public string get_NoLiNKID() { }

	[CompilerGenerated]
	private Action<PlaySessionConflict> get_PlaySessionConflictAction() { }

	internal void Initialise(Api liNK, PlayerOptions options, SyncedFile<DataT> dataFile, File<SavedIdentity> identityFile, LiNKAccount liNKAccount) { }

	[AsyncStateMachine(typeof(<ManualBackup>d__57))]
	internal Task ManualBackup(CancellationToken canceller) { }

	private override LiNKAccount NinjaKiwi.LiNK.Client.ILiNKAccountHolder.GetLiNKAccount() { }

	private override Task NinjaKiwi.LiNK.Client.ILiNKAccountHolder.SetLiNKAccount(LiNKAccount newLiNKAccount) { }

	[CompilerGenerated]
	public void remove_BackupDoneEvent(Action value) { }

	[CompilerGenerated]
	public void remove_BackupStartedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_CheckingEtagEvent(Action value) { }

	[CompilerGenerated]
	public void remove_CheckingPlaySessionEvent(Action value) { }

	[CompilerGenerated]
	public void remove_CheckPlaySessionDoneEvent(Action value) { }

	[CompilerGenerated]
	internal void remove_ErrorEvent(Action<Exception> value) { }

	public override void Save() { }

	private void SaveIdentity(LiNKAccount account) { }

	[AsyncStateMachine(typeof(<ScheduledCheckAndBackup>d__59))]
	private void ScheduledCheckAndBackup(bool needToBackup, int counter) { }

	public void set_Data(DataT value) { }

	public void set_DataConflictAction(Action<DataConflict`1<DataT>> value) { }

	public void set_DataInvalidAction(Action<DataInvalid> value) { }

	[CompilerGenerated]
	private void set_LiNK(Api value) { }

	[CompilerGenerated]
	private void set_LiNKAccount(LiNKAccount value) { }

	[CompilerGenerated]
	private void set_LiNKAccountController(LiNKAccountController value) { }

	[CompilerGenerated]
	public void set_PlaySessionConflictAction(Action<PlaySessionConflict> value) { }

	private Task SetPlaySession() { }

	private void ThrowExceptionIfDeactivated() { }

	private void TriggerEvent(Action eventToTrigger) { }

	internal void WipeAndDeactivate() { }

}

