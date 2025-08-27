namespace Assets.Twitch;

public class Polls
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SubPoll, Boolean> <>9__29_0; //Field offset: 0x8
		public static Func<SubPoll, Boolean> <>9__30_0; //Field offset: 0x10
		public static Func<PollItem, Boolean> <>9__30_1; //Field offset: 0x18
		public static Func<PollItem, String> <>9__30_2; //Field offset: 0x20
		public static Func<SubPoll, Boolean> <>9__30_3; //Field offset: 0x28
		public static Func<PollItem, String> <>9__32_0; //Field offset: 0x30
		public static Func<SubPoll, IEnumerable`1<PollItem>> <>9__34_0; //Field offset: 0x38
		public static Func<PollItem, UInt32> <>9__34_1; //Field offset: 0x40
		public static Func<PollItem, Boolean> <>9__34_3; //Field offset: 0x48
		public static Func<PollItem, Boolean> <>9__34_4; //Field offset: 0x50
		public static Func<PollItem, Boolean> <>9__35_0; //Field offset: 0x58
		public static Func<String, ChoiceBase> <>9__37_0; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <CancelPoll>b__29_0(SubPoll x) { }

		internal ChoiceBase <CreatePoll>b__37_0(string choiceTitle) { }

		internal string <GetPollRequestTask>b__32_0(PollItem x) { }

		internal bool <GetPollTask>b__30_0(SubPoll x) { }

		internal bool <GetPollTask>b__30_1(PollItem x) { }

		internal string <GetPollTask>b__30_2(PollItem x) { }

		internal bool <GetPollTask>b__30_3(SubPoll x) { }

		internal bool <SelectRandomWinners>b__35_0(PollItem x) { }

		internal IEnumerable<PollItem> <SelectWinners>b__34_0(SubPoll subPoll) { }

		internal uint <SelectWinners>b__34_1(PollItem x) { }

		internal bool <SelectWinners>b__34_3(PollItem x) { }

		internal bool <SelectWinners>b__34_4(PollItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public Choice choice; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal bool <RefreshPoll>b__0(PollItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public PollItem pollItem; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <SelectWinners>b__2(PollItem x) { }

	}

	[CompilerGenerated]
	private struct <CancelPoll>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Polls <>4__this; //Field offset: 0x20
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x28
		private TaskAwaiter<List`1<Poll>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreatePoll>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Poll> <>t__builder; //Field offset: 0x8
		public Polls <>4__this; //Field offset: 0x20
		public IEnumerable<String> choiceTitles; //Field offset: 0x28
		public string name; //Field offset: 0x30
		public TimeSpan duration; //Field offset: 0x38
		public bool canBitVote; //Field offset: 0x40
		public uint bitVotePrice; //Field offset: 0x44
		public bool canPointVote; //Field offset: 0x48
		public uint pointVotePrice; //Field offset: 0x4C
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x50
		private TaskAwaiter<List`1<Poll>> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPoll>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Poll> <>t__builder; //Field offset: 0x8
		public Polls <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x30
		private TaskAwaiter<List`1<Poll>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPollTask>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Polls <>4__this; //Field offset: 0x20
		public string name; //Field offset: 0x28
		public TimeSpan duration; //Field offset: 0x30
		public bool canBitVote; //Field offset: 0x38
		public uint bitVotePrice; //Field offset: 0x3C
		public bool canPointVote; //Field offset: 0x40
		public uint pointVotePrice; //Field offset: 0x44
		public int maxWinners; //Field offset: 0x48
		private Enumerator<SubPoll> <>7__wrap1; //Field offset: 0x50
		private SubPoll <subPoll>5__3; //Field offset: 0x68
		private int <attemptCount>5__4; //Field offset: 0x70
		private bool <isLastRetry>5__5; //Field offset: 0x74
		private object <>7__wrap5; //Field offset: 0x78
		private int <>7__wrap6; //Field offset: 0x80
		private SubPoll <>7__wrap7; //Field offset: 0x88
		private TaskAwaiter<Poll> <>u__1; //Field offset: 0x90
		private TaskAwaiter <>u__2; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshPoll>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SubPoll subPoll; //Field offset: 0x20
		public Polls <>4__this; //Field offset: 0x28
		private Poll <twitchPoll>5__2; //Field offset: 0x30
		private TaskAwaiter<Poll> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPoll>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Polls <>4__this; //Field offset: 0x20
		public List<PollItem> pollItems; //Field offset: 0x28
		public int maxWinners; //Field offset: 0x30
		public string name; //Field offset: 0x38
		public TimeSpan duration; //Field offset: 0x40
		public bool canBitVote; //Field offset: 0x48
		public uint bitVotePrice; //Field offset: 0x4C
		public bool canPointVote; //Field offset: 0x50
		public uint pointVotePrice; //Field offset: 0x54
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int kMaxChoicesPerPoll = 5; //Field offset: 0x0
	public Action<SubPoll> OnSubPollStarted; //Field offset: 0x10
	public Action<List`1<String>> OnPollsFinished; //Field offset: 0x18
	public Action<Exception> OnPollsFailed; //Field offset: 0x20
	public Action OnPollRefreshed; //Field offset: 0x28
	public Action OnPollRefreshFailed; //Field offset: 0x30
	private readonly Client twitchClient; //Field offset: 0x38
	private Task pollRunner; //Field offset: 0x40
	private CancellationTokenSource pollRunnerCanceller; //Field offset: 0x48
	[CompilerGenerated]
	private List<PollItem> <PollItems>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private List<SubPoll> <SubPolls>k__BackingField; //Field offset: 0x58

	public Exception Exception
	{
		 get { } //Length: 19
	}

	public bool IsActive
	{
		 get { } //Length: 9
	}

	public bool IsFaulted
	{
		 get { } //Length: 44
	}

	public bool IsFinished
	{
		 get { } //Length: 19
	}

	public private List<PollItem> PollItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<SubPoll> SubPolls
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Polls(Client twitchClient) { }

	[AsyncStateMachine(typeof(<CancelPoll>d__29))]
	public Task CancelPoll() { }

	[AsyncStateMachine(typeof(<CreatePoll>d__37))]
	private Task<Poll> CreatePoll(string name, IEnumerable<String> choiceTitles, TimeSpan duration, bool canBitVote = false, uint bitVotePrice = 0, bool canPointVote = false, uint pointVotePrice = 0) { }

	public Exception get_Exception() { }

	public bool get_IsActive() { }

	public bool get_IsFaulted() { }

	public bool get_IsFinished() { }

	[CompilerGenerated]
	public List<PollItem> get_PollItems() { }

	[CompilerGenerated]
	public List<SubPoll> get_SubPolls() { }

	private int GetChoicesPerPoll(int count) { }

	[AsyncStateMachine(typeof(<GetPoll>d__38))]
	private Task<Poll> GetPoll(string id) { }

	private Task<Poll> GetPollRequestTask(string name, SubPoll subPoll, TimeSpan duration, bool canBitVote, uint bitVotePrice, bool canPointVote, uint pointVotePrice) { }

	[AsyncStateMachine(typeof(<GetPollTask>d__30))]
	private Task GetPollTask(int maxWinners, string name, TimeSpan duration, bool canBitVote, uint bitVotePrice, bool canPointVote, uint pointVotePrice) { }

	private List<SubPoll> GetSubPolls() { }

	[AsyncStateMachine(typeof(<RefreshPoll>d__33))]
	private Task RefreshPoll(SubPoll subPoll) { }

	public void ResetCurrentPoll() { }

	private void SelectRandomWinners(List<PollItem> pollItems, int maxWinners) { }

	private List<PollItem> SelectWinners(int maxWinners) { }

	[CompilerGenerated]
	private void set_PollItems(List<PollItem> value) { }

	[CompilerGenerated]
	private void set_SubPolls(List<SubPoll> value) { }

	private void SetRandomWinner(List<PollItem> pollItems) { }

	public Task StartPoll(List<PollItem> pollItems, int maxWinners, string name, TimeSpan duration) { }

	[AsyncStateMachine(typeof(<StartPoll>d__28))]
	public Task StartPoll(List<PollItem> pollItems, int maxWinners, string name, TimeSpan duration, bool canBitVote, uint bitVotePrice, bool canPointVote, uint pointVotePrice) { }

}

