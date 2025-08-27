namespace Assets.Scripts.Unity.UI_New.Coop;

public class LocalCoopPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Setup>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalCoopPanel <>4__this; //Field offset: 0x20
		public CoopJoinMatchScreen coopJoinMatchScreen; //Field offset: 0x28
		public LocalNetworkLobby lobby; //Field offset: 0x30
		public Btd6LobbyParameters lobbyParamaters; //Field offset: 0x38
		private string <creatorId>5__2; //Field offset: 0x40
		private bool <creatorHasLinkAccount>5__3; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50
		private Btd6PlayerStats <playerStats>5__4; //Field offset: 0x58
		private TaskAwaiter<Btd6PlayerStats> <>u__2; //Field offset: 0x60
		private YieldAwaiter <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI txtPlayerName; //Field offset: 0x20
	public GameObject bannerContainer; //Field offset: 0x28
	public Image bannerImg; //Field offset: 0x30
	public Image avatarImg; //Field offset: 0x38
	public Button goBtn; //Field offset: 0x40
	private CoopJoinMatchScreen coopJoinMatchScreen; //Field offset: 0x48
	private string lobbyId; //Field offset: 0x50

	public LocalCoopPanel() { }

	private void OnGoClicked() { }

	[AsyncStateMachine(typeof(<Setup>d__7))]
	public Task Setup(CoopJoinMatchScreen coopJoinMatchScreen, LocalNetworkLobby lobby, Btd6LobbyParameters lobbyParamaters) { }

}

