namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeStatPlayerInfo : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ChallengeStatPlayerInfo <>4__this; //Field offset: 0x28
		public string playerId; //Field offset: 0x30
		public bool isOldChallenge; //Field offset: 0x38
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x40
		private TaskAwaiter<String> <>u__2; //Field offset: 0x48
		private TaskAwaiter<OnlineProfileModel> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image avatarFrame; //Field offset: 0x20
	public Image avatarFrameOld; //Field offset: 0x28
	public Image playerAvatar; //Field offset: 0x30
	public TMP_Text playerName; //Field offset: 0x38
	public Button playerStatsBtn; //Field offset: 0x40
	public GameObject loadingSpinner; //Field offset: 0x48
	public Image verifiedPlayerIcon; //Field offset: 0x50
	public Image followingPlayerIcon; //Field offset: 0x58
	public GameObject playerBanner; //Field offset: 0x60
	public Image playerBannerImage; //Field offset: 0x68
	private Btd6PlayerStats playerStats; //Field offset: 0x70
	private PlayerContentStatsPanel parentPanel; //Field offset: 0x78

	public ChallengeStatPlayerInfo() { }

	public void Initialize(PlayerContentStatsPanel playerContentStatsPanel) { }

	private void LoadAndShowPlayerStats() { }

	[AsyncStateMachine(typeof(<LoadAsync>d__13))]
	public void LoadAsync(string playerId, bool isOldChallenge = false) { }

	public void SetInteractable(bool value) { }

}

