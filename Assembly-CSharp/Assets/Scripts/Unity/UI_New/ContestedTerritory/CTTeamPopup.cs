namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTTeamPopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ShowTeamCosmeticsAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTTeamPopup <>4__this; //Field offset: 0x28
		public string guildId; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image teamIconImg; //Field offset: 0x20
	public Image teamFrameImg; //Field offset: 0x28
	public Image bannerImg; //Field offset: 0x30
	public TMP_Text ownerTxt; //Field offset: 0x38
	public TMP_Text positionTxt; //Field offset: 0x40
	public TMP_Text scoreTxt; //Field offset: 0x48
	public Button infoBtn; //Field offset: 0x50
	public Button bgBtn; //Field offset: 0x58
	public Action OnCloseClicked; //Field offset: 0x60
	private GuildModel guildModel; //Field offset: 0x68

	public CTTeamPopup() { }

	protected void Awake() { }

	private void CloseClicked() { }

	private void InfoClicked() { }

	public void Init(string guildId, int position, long score) { }

	[AsyncStateMachine(typeof(<ShowTeamCosmeticsAsync>d__12))]
	public void ShowTeamCosmeticsAsync(string guildId) { }

}

