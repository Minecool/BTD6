namespace NinjaKiwi.GUTS;

[Extension]
public static class TeamWebRequests
{
	[CompilerGenerated]
	private struct <Team_ContributeTrophies>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ContributionResponse> <>t__builder; //Field offset: 0x0
		public string itemId; //Field offset: 0x0
		public int amount; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<ContributionResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Team_GetItemsContributions>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, TeamStoreItemContributions>> <>t__builder; //Field offset: 0x0
		public TrophyStoreBankData bankData; //Field offset: 0x0
		public string guildId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public int dailyRelicCount; //Field offset: 0x0
		private Dictionary<String, TrophyStoreBankItem> <bankItems>5__2; //Field offset: 0x0
		private Dictionary<String, Int64> <guildWalletCurrencies>5__3; //Field offset: 0x0
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kDefaultEmptyEventId = "NO_EVENT"; //Field offset: 0x0
	[CompilerGenerated]
	private static Func<String, String, Task`1<Dictionary`2<String, Int64>>> <GetBankWalletOverride>k__BackingField; //Field offset: 0x0

	private static Func<String, String, Task`1<Dictionary`2<String, Int64>>> GetBankWalletOverride
	{
		[CompilerGenerated]
		private get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	[CompilerGenerated]
	private static Func<String, String, Task`1<Dictionary`2<String, Int64>>> get_GetBankWalletOverride() { }

	[Extension]
	private static Task<Dictionary`2<String, Int64>> GetBankWallet(Player<T> player, string ownerId, string walletName) { }

	public static void OverrideBankFunction(Func<String, String, Task`1<Dictionary`2<String, Int64>>> getBankFunc) { }

	[CompilerGenerated]
	private static void set_GetBankWalletOverride(Func<String, String, Task`1<Dictionary`2<String, Int64>>> value) { }

	[AsyncStateMachine(typeof(<Team_ContributeTrophies>d__7`1))]
	[Extension]
	public static Task<ContributionResponse> Team_ContributeTrophies(Player<T> player, string itemId, int amount, string eventId) { }

	[AsyncStateMachine(typeof(<Team_GetItemsContributions>d__8`1))]
	[Extension]
	public static Task<Dictionary`2<String, TeamStoreItemContributions>> Team_GetItemsContributions(Player<T> player, string guildId, string eventId, TrophyStoreBankData bankData, int dailyRelicCount) { }

}

