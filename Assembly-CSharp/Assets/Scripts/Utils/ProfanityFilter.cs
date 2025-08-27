namespace Assets.Scripts.Utils;

public class ProfanityFilter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string text; //Field offset: 0x10
		public ProfanityFilter <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal bool <MatchesAreWhitelisted>b__0(Match m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public string word; //Field offset: 0x10
		public <>c__DisplayClass10_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass10_1() { }

		internal bool <MatchesAreWhitelisted>b__1(Regex r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ProfanityFilter <>4__this; //Field offset: 0x10
		public string text; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <contains>b__0(Regex r) { }

	}

	[CompilerGenerated]
	private struct <Contains>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string text; //Field offset: 0x20
		private TaskAwaiter<ProfanityFilter> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ProfanityFilter> <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20
		private int <>7__wrap1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadOfflineFile>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfanityFilter <>4__this; //Field offset: 0x20
		private AsyncOperationHandle<TextAsset> <loadOp>5__2; //Field offset: 0x28
		private TaskAwaiter<TextAsset> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadOnlineFile>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfanityFilter <>4__this; //Field offset: 0x20
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static ProfanityFilter instance; //Field offset: 0x0
	private List<Regex> blackList; //Field offset: 0x10
	private List<Regex> whiteList; //Field offset: 0x18

	public ProfanityFilter() { }

	private bool contains(string text) { }

	[AsyncStateMachine(typeof(<Contains>d__8))]
	public static Task<Boolean> Contains(string text) { }

	private void CreateListsFromString(string fileStr) { }

	private List<Regex> CreateRegexListFromArray(String[] strings) { }

	[AsyncStateMachine(typeof(<Init>d__3))]
	public static Task<ProfanityFilter> Init() { }

	private bool IsExactMatch(Regex regex, string str) { }

	[AsyncStateMachine(typeof(<LoadOfflineFile>d__5))]
	private Task LoadOfflineFile() { }

	[AsyncStateMachine(typeof(<LoadOnlineFile>d__4))]
	private Task LoadOnlineFile() { }

	private bool MatchesAreWhitelisted(MatchCollection matches, string text) { }

	private static string WordAtIndex(int index, string text) { }

}

