namespace NinjaKiwi.LiNK.Client;

public class PlayerService : PlayerServiceComponent
{
	[CompilerGenerated]
	private sealed class <CheckForNewPlayer>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public PlayerService<PlayerT, DataT> <>4__this; //Field offset: 0x0
		private PlayerT <oldPlayer>5__2; //Field offset: 0x0

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CheckForNewPlayer>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadInternal>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerT> <>t__builder; //Field offset: 0x0
		public PlayerService<PlayerT, DataT> <>4__this; //Field offset: 0x0
		public AuthenticationProviderToken authToken; //Field offset: 0x0
		private CancellationTokenSource <loadCanceller>5__2; //Field offset: 0x0
		private PlayerT <newPlayer>5__3; //Field offset: 0x0
		private CancellationToken <canceller>5__4; //Field offset: 0x0
		private TaskAwaiter<PlayerT> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LogInAndSync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public PlayerT player; //Field offset: 0x0
		public AuthenticationProviderToken token; //Field offset: 0x0
		public CancellationToken canceller; //Field offset: 0x0
		public PlayerService<PlayerT, DataT> <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private PlayerT <Player>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action<PlayerT> NewPlayerEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Exception> ErrorEvent; //Field offset: 0x0
	private PlayerFactory<PlayerT, DataT> playerFactory; //Field offset: 0x0
	private Action cancelAction; //Field offset: 0x0
	private Action<PlaySessionConflict> onPlaySessionConflict; //Field offset: 0x0
	private Action<DataConflict`1<DataT>> onDataConflict; //Field offset: 0x0
	private Action<DataInvalid> onDataInvalid; //Field offset: 0x0

	public event Action<Exception> ErrorEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<PlayerT> NewPlayerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 192
		[CompilerGenerated]
		 remove { } //Length: 192
	}

	public Action<DataConflict`1<DataT>> DataConflictAction
	{
		 set { } //Length: 43
	}

	public Action<DataInvalid> DataInvalidAction
	{
		 set { } //Length: 43
	}

	public private PlayerT Player
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Action<PlaySessionConflict> PlaySessionConflictAction
	{
		 set { } //Length: 21
	}

	protected Func<File`1<DataT>, SyncedFile`1<DataT>> SyncedFileFactory
	{
		 set { } //Length: 27
	}

	public PlayerService`2() { }

	[CompilerGenerated]
	private void <AttachPlayerEvents>b__19_0(Exception error) { }

	[CompilerGenerated]
	public void add_ErrorEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void add_NewPlayerEvent(Action<PlayerT> value) { }

	private void AttachPlayerEvents(PlayerT player) { }

	protected virtual void Awake() { }

	[IteratorStateMachine(typeof(<CheckForNewPlayer>d__34))]
	private IEnumerator CheckForNewPlayer() { }

	private void DeactivateCurrentOrLoadingPlayer() { }

	[CompilerGenerated]
	public PlayerT get_Player() { }

	[Obsolete("This is an ancient auth flow. Instead, call Load() without the token and then log in.")]
	public Task<PlayerT> Load(AuthenticationProviderToken authToken) { }

	public Task<PlayerT> Load() { }

	[AsyncStateMachine(typeof(<LoadInternal>d__17))]
	private Task<PlayerT> LoadInternal(AuthenticationProviderToken authToken = null) { }

	public File<DataT> LoadPlayerDataFile(AuthenticationProviderToken authenticationProviderToken = null) { }

	public File<SavedIdentity> LoadPlayerIdentityFile(AuthenticationProviderToken authenticationProviderToken = null) { }

	[AsyncStateMachine(typeof(<LogInAndSync>d__20))]
	private Task LogInAndSync(PlayerT player, AuthenticationProviderToken token, CancellationToken canceller) { }

	protected override void OnDestroy() { }

	[CompilerGenerated]
	public void remove_ErrorEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void remove_NewPlayerEvent(Action<PlayerT> value) { }

	public void RemoveCurrentPlayer() { }

	public void set_DataConflictAction(Action<DataConflict`1<DataT>> value) { }

	public void set_DataInvalidAction(Action<DataInvalid> value) { }

	[CompilerGenerated]
	private void set_Player(PlayerT value) { }

	public void set_PlaySessionConflictAction(Action<PlaySessionConflict> value) { }

	protected void set_SyncedFileFactory(Func<File`1<DataT>, SyncedFile`1<DataT>> value) { }

	public void Unload() { }

}

