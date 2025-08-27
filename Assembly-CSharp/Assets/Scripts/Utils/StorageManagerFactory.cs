namespace Assets.Scripts.Utils;

public static class StorageManagerFactory
{
	[CompilerGenerated]
	private struct <PurgeUserStorages>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private List<Exception> <exceptions>5__2; //Field offset: 0x20
		private StoragePath[] <>7__wrap2; //Field offset: 0x28
		private int <>7__wrap3; //Field offset: 0x30
		private StoragePath <userStoragePath>5__5; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly StoragePath[] userStoragePaths; //Field offset: 0x0
	private static readonly StoragePath[] persistantStoragePaths; //Field offset: 0x8
	private static readonly Dictionary<StoragePath, StorageManager> createdStorageManagers; //Field offset: 0x10

	private static StorageManagerFactory() { }

	private static StorageManager Create(StoragePath storagePath, Func<Byte[], String> decode, Func<String, Byte[]> encode, JsonSerializerSettings serializerSettings) { }

	public static StorageManager CreateStorageManager(StoragePath storagePath, Func<Byte[], String> decode = null, Func<String, Byte[]> encode = null, JsonSerializerSettings serializerSettings = null, bool purgeOnCreation = false) { }

	[AsyncStateMachine(typeof(<PurgeUserStorages>d__5))]
	public static Task PurgeUserStorages() { }

}

