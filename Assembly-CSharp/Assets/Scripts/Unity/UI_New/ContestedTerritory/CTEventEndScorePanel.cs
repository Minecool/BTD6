namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTEventEndScorePanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ShowTeamCosmeticsAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTEventEndScorePanel <>4__this; //Field offset: 0x28
		public string guildId; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject yourTeamObj; //Field offset: 0x20
	public Image colorBackgroundImg; //Field offset: 0x28
	public Color yourTeamColor; //Field offset: 0x30
	public Color opponentTeamColor; //Field offset: 0x40
	public Image badgeImg; //Field offset: 0x50
	public Image bannerImg; //Field offset: 0x58
	public Image teamIconImg; //Field offset: 0x60
	public Image teamFrameImg; //Field offset: 0x68
	public TMP_Text positionTxt; //Field offset: 0x70
	public TMP_Text nameTxt; //Field offset: 0x78
	public TMP_Text scoreTxt; //Field offset: 0x80

	public CTEventEndScorePanel() { }

	public void Init(string guildId, int position, long score, string playersGuildId) { }

	[AsyncStateMachine(typeof(<ShowTeamCosmeticsAsync>d__12))]
	public void ShowTeamCosmeticsAsync(string guildId) { }

}

