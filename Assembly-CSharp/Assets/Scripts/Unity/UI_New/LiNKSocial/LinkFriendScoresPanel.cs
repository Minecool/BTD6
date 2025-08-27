namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LinkFriendScoresPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadFriendScoresAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendScoresPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<List`1<TopScore>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public int rank; //Field offset: 0x20
	public Image icon; //Field offset: 0x28
	public Image difficulty; //Field offset: 0x30
	public TMP_Text bestRound; //Field offset: 0x38
	public DifficultySpritesAsset difficultySpritesAsset; //Field offset: 0x40
	public TMP_Text username; //Field offset: 0x48
	private string mapName; //Field offset: 0x50
	private CancellationTokenSource canceller; //Field offset: 0x58

	public LinkFriendScoresPanel() { }

	public void Init(string mapName) { }

	[AsyncStateMachine(typeof(<LoadFriendScoresAsync>d__10))]
	private void LoadFriendScoresAsync() { }

	private void OnDestroy() { }

	public void SetScore(TopScore score, string displayName) { }

}

