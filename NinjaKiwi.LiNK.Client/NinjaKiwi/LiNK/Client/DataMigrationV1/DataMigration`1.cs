namespace NinjaKiwi.LiNK.Client.DataMigrationV1;

internal static class DataMigration
{
	[CompilerGenerated]
	private struct <MigrateIfNeeded>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public PlayerOptions playerOptions; //Field offset: 0x0
		public Api liNK; //Field offset: 0x0
		public AuthenticationProviderToken authenticationProviderToken; //Field offset: 0x0
		public CancellationToken canceller; //Field offset: 0x0
		public File<T> newDataFile; //Field offset: 0x0
		public File<SavedIdentity> newIdentityFile; //Field offset: 0x0
		private string <commonRootPath>5__2; //Field offset: 0x0
		private PlayerIndex <oldPlayerIndex>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<LiNKAccountModel> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string IDENTITY_FILENAME = "identity"; //Field offset: 0x0
	private const string MIGRATION_COMPLETE_FLAG_FILENAME = "migrated.v1"; //Field offset: 0x0

	[AsyncStateMachine(typeof(<MigrateIfNeeded>d__2))]
	public static Task MigrateIfNeeded(File<T> newDataFile, File<SavedIdentity> newIdentityFile, Api liNK, PlayerOptions playerOptions, CancellationToken canceller, AuthenticationProviderToken authenticationProviderToken = null) { }

}

