namespace NinjaKiwi.LiNK.Client;

internal sealed class PlayerFactory
{
	[CompilerGenerated]
	private struct <CreatePlayer>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerT> <>t__builder; //Field offset: 0x0
		public PlayerFactory<PlayerT, DataT> <>4__this; //Field offset: 0x0
		public AuthenticationProviderToken authenticationProviderToken; //Field offset: 0x0
		public CancellationToken canceller; //Field offset: 0x0
		private File<SavedIdentity> <identityFile>5__2; //Field offset: 0x0
		private File<DataT> <dataFile>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<LiNKAccount> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string IDENTITY_FILE_NAME = "identity"; //Field offset: 0x0
	public readonly Logger logger; //Field offset: 0x0
	public Func<File`1<DataT>, SyncedFile`1<DataT>> syncedFileFactory; //Field offset: 0x0
	private readonly Api liNK; //Field offset: 0x0
	private readonly PlayerOptions playerOptions; //Field offset: 0x0
	private readonly PlayerStoragePaths playerStoragePaths; //Field offset: 0x0

	public PlayerFactory`2(Api liNK, PlayerOptions options) { }

	[AsyncStateMachine(typeof(<CreatePlayer>d__7))]
	public Task<PlayerT> CreatePlayer(CancellationToken canceller, AuthenticationProviderToken authenticationProviderToken = null) { }

	private IStorage GetFileSystemStorage(string fileName, AuthenticationProviderToken authenticationProviderToken) { }

	private File<T> LoadFile(IStorage storage, Nullable<Boolean> ignoreIfNotReadable = null) { }

	public File<DataT> LoadPlayerDataFile(AuthenticationProviderToken authenticationProviderToken = null, Nullable<Boolean> ignoreIfNotReadable = null) { }

	public File<SavedIdentity> LoadPlayerIdentityFile(AuthenticationProviderToken authenticationProviderToken = null, Nullable<Boolean> ignoreIfNotReadable = null) { }

}

