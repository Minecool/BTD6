namespace Assets.Scripts.Utils;

public static class BankCache
{
	[CompilerGenerated]
	private struct <DownloadAndUpdateWalletCache>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Int64>> <>t__builder; //Field offset: 0x8
		public WalletId walletId; //Field offset: 0x20
		public WalletCache walletCache; //Field offset: 0x38
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBankWallet>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Int64>> <>t__builder; //Field offset: 0x8
		public string ownerId; //Field offset: 0x20
		public string walletName; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class WalletCache
	{
		[CompilerGenerated]
		private Dictionary<String, Int64> <Currencies>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private TimeSpan <CreationTime>k__BackingField; //Field offset: 0x18

		public private TimeSpan CreationTime
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private Dictionary<String, Int64> Currencies
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public WalletCache(Dictionary<String, Int64> currencies, string walletName) { }

		[CompilerGenerated]
		public TimeSpan get_CreationTime() { }

		[CompilerGenerated]
		public Dictionary<String, Int64> get_Currencies() { }

		private static TimeSpan GetCacheLife(string walletName) { }

		public bool IsRecent(TimeSpan now, string walletName) { }

		[CompilerGenerated]
		private void set_CreationTime(TimeSpan value) { }

		[CompilerGenerated]
		private void set_Currencies(Dictionary<String, Int64> value) { }

		public void Update(Dictionary<String, Int64> currencies) { }

	}

	private struct WalletId : IEquatable<WalletId>
	{
		[CompilerGenerated]
		private readonly string <OwnerId>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly string <Name>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly string <OwnerIdName>k__BackingField; //Field offset: 0x10

		public string Name
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 291
		}

		public string OwnerId
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public string OwnerIdName
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
		}

		public WalletId(string ownerId, string name) { }

		public override bool Equals(WalletId other) { }

		public virtual bool Equals(object obj) { }

		[CompilerGenerated]
		[IsReadOnly]
		public string get_Name() { }

		[CompilerGenerated]
		[IsReadOnly]
		public string get_OwnerId() { }

		[CompilerGenerated]
		[IsReadOnly]
		public string get_OwnerIdName() { }

		public virtual int GetHashCode() { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private static readonly Dictionary<WalletId, WalletCache> <WalletCaches>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly Dictionary<WalletId, Task`1<Dictionary`2<String, Int64>>> <WalletDownloadTasks>k__BackingField; //Field offset: 0x8

	private static Api Link
	{
		private get { } //Length: 58
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private static Dictionary<WalletId, WalletCache> WalletCaches
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static Dictionary<WalletId, Task`1<Dictionary`2<String, Int64>>> WalletDownloadTasks
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	private static BankCache() { }

	public static void ClearWalletCache(string ownerId, string walletName) { }

	[AsyncStateMachine(typeof(<DownloadAndUpdateWalletCache>d__12))]
	private static Task<Dictionary`2<String, Int64>> DownloadAndUpdateWalletCache(WalletId walletId, WalletCache walletCache) { }

	private static Api get_Link() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	private static Dictionary<WalletId, WalletCache> get_WalletCaches() { }

	[CompilerGenerated]
	private static Dictionary<WalletId, Task`1<Dictionary`2<String, Int64>>> get_WalletDownloadTasks() { }

	[AsyncStateMachine(typeof(<GetBankWallet>d__11))]
	public static Task<Dictionary`2<String, Int64>> GetBankWallet(string ownerId, string walletName) { }

}

