namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LinkFriendsScoresPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TopScore, String> <>9__6_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <LoadFriendPanelsAsync>b__6_1(TopScore x) { }

	}

	[CompilerGenerated]
	private struct <LoadFriendPanelsAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScoresPanel <>4__this; //Field offset: 0x28
		private List<TopScore> <topScores>5__2; //Field offset: 0x30
		private TaskAwaiter<List`1<TopScore>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Dictionary`2<String, String>> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public List<LinkFriendScoresPanel> friendPanels; //Field offset: 0x20
	private CancellationTokenSource canceller; //Field offset: 0x28

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	public LinkFriendsScoresPanel() { }

	[CompilerGenerated]
	private bool <LoadFriendPanelsAsync>b__6_0(TopScore x) { }

	private Btd6Player get_Player() { }

	[AsyncStateMachine(typeof(<LoadFriendPanelsAsync>d__6))]
	private void LoadFriendPanelsAsync() { }

	private void OnDestroy() { }

	public void Refresh() { }

	private void SetScorePanels(List<TopScore> topScores, Dictionary<String, String> displayNames) { }

}

