namespace NinjaKiwi.GUTS.Utils;

public static class AccoladeTransactionStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AccoladeTransaction, Int64> <>9__6_0; //Field offset: 0x8
		public static Func<AccoladeTransaction, Int64> <>9__7_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal long <Add>b__7_0(AccoladeTransaction x) { }

		internal long <GetLastAccoladeTransactionId>b__6_0(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <Add>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccoladeTransaction[]> <>t__builder; //Field offset: 0x8
		public string userId; //Field offset: 0x20
		public AccoladeTransaction[] newAccoladeTransactions; //Field offset: 0x28
		private AccoladeTransaction[] <accoladeTransactions>5__2; //Field offset: 0x30
		private TaskAwaiter<AccoladeTransaction[]> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCachedTransactions>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccoladeTransaction[]> <>t__builder; //Field offset: 0x8
		public string userId; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLastAccoladeTransactionId>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x8
		public string userId; //Field offset: 0x20
		private TaskAwaiter<AccoladeTransaction[]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static DateTime <LastCacheTime>k__BackingField; //Field offset: 0x0
	internal static Nullable<Int64> _lastAccoladeTransactionId; //Field offset: 0x8

	internal static DateTime LastCacheTime
	{
		[CompilerGenerated]
		internal get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	[AsyncStateMachine(typeof(<Add>d__7))]
	internal static Task<AccoladeTransaction[]> Add(AccoladeTransaction[] newAccoladeTransactions, string userId) { }

	[CompilerGenerated]
	internal static DateTime get_LastCacheTime() { }

	[AsyncStateMachine(typeof(<GetCachedTransactions>d__8))]
	public static Task<AccoladeTransaction[]> GetCachedTransactions(string userId) { }

	private static string GetCacheFilePath(string userId) { }

	[AsyncStateMachine(typeof(<GetLastAccoladeTransactionId>d__6))]
	internal static Task<Int64> GetLastAccoladeTransactionId(string userId) { }

	[CompilerGenerated]
	private static void set_LastCacheTime(DateTime value) { }

}

