namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushNewScoreInfo : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Load>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushNewScoreInfo <>4__this; //Field offset: 0x20
		public int score; //Field offset: 0x28
		public string playerId; //Field offset: 0x30
		public string avatarId; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI scoreTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI playerNameTxt; //Field offset: 0x28
	[SerializeField]
	private Image playerAvatarImg; //Field offset: 0x30

	public BossRushNewScoreInfo() { }

	[AsyncStateMachine(typeof(<Load>d__3))]
	public Task Load(string playerId, string avatarId, int score) { }

}

