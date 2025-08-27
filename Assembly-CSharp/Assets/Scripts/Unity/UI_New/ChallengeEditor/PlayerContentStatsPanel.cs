namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class PlayerContentStatsPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <GetContentStats>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerContentStats> <>t__builder; //Field offset: 0x8
		public PlayerContentStatsPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<PlayerContentStats> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentStatsPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<PlayerContentStats> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button closeBtn; //Field offset: 0x20
	public Button closeAreaBtn; //Field offset: 0x28
	public Image loadingSpinner; //Field offset: 0x30
	public ChallengeStatView plays; //Field offset: 0x38
	public ChallengeStatView wins; //Field offset: 0x40
	public ChallengeStatView fails; //Field offset: 0x48
	public ChallengeStatView uniquePlayers; //Field offset: 0x50
	public ChallengeStatView victoriousPlayers; //Field offset: 0x58
	public ChallengeStatPlayerInfo firstWinningPlayerInfo; //Field offset: 0x60
	public ChallengeStatPlayerInfo latestWinningPlayerInfo; //Field offset: 0x68
	private PlayerContent playerContent; //Field offset: 0x70
	private string uniqueDCId; //Field offset: 0x78
	private bool useCache; //Field offset: 0x80
	private bool _isLoading; //Field offset: 0x81

	public private bool IsLoading
	{
		 get { } //Length: 8
		private set { } //Length: 568
	}

	public PlayerContentStatsPanel() { }

	[CompilerGenerated]
	private void <Start>b__17_0() { }

	public void Close() { }

	public bool get_IsLoading() { }

	[AsyncStateMachine(typeof(<GetContentStats>d__22))]
	private Task<PlayerContentStats> GetContentStats() { }

	[AsyncStateMachine(typeof(<Open>d__21))]
	private void Open() { }

	private void set_IsLoading(bool value) { }

	public void SetDailyChallengeId(string uniqueDCId) { }

	public void SetPlayerContent(PlayerContent playerContent, bool useCache = false) { }

	public void Start() { }

	public void Toggle() { }

}

