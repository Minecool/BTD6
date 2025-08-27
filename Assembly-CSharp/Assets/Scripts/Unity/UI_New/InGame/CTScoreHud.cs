namespace Assets.Scripts.Unity.UI_New.InGame;

public class CTScoreHud : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ShowTeamCosmeticsAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTScoreHud <>4__this; //Field offset: 0x28
		public string guildID; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text displayTxt; //Field offset: 0x20
	public Color positiveTextColor; //Field offset: 0x28
	public Color negativeTextColor; //Field offset: 0x38
	public Animator animator; //Field offset: 0x48
	public Animator warningsAnimator; //Field offset: 0x50
	public Image newScoreTeamColor; //Field offset: 0x58
	public Image newScoreTeamFrame; //Field offset: 0x60
	public Image newScoreTeamIcon; //Field offset: 0x68
	public TMP_Text newScoreTxt; //Field offset: 0x70
	public GameObject noScoreSetObj; //Field offset: 0x78
	protected int amountUsed; //Field offset: 0x80
	protected int currentTarget; //Field offset: 0x84
	protected int lastAmountUsed; //Field offset: 0x88
	private bool scoreExceededFired; //Field offset: 0x8C
	protected bool noTargetSet; //Field offset: 0x8D

	protected UnityToSimulation Bridge
	{
		 get { } //Length: 7
	}

	protected LocalizationManager Locs
	{
		 get { } //Length: 48
	}

	public CTScoreHud() { }

	protected override void AttachEvents() { }

	protected UnityToSimulation get_Bridge() { }

	protected LocalizationManager get_Locs() { }

	protected override int GetAmountUsed() { }

	protected override int GetCurrentTarget() { }

	protected override string GetDisplayText() { }

	private void HideShowOnPlacement(bool hide) { }

	protected override bool NoTargetSet() { }

	private void OnCurrentTileCaptured() { }

	private void OnDestroy() { }

	public override void OnGameEnd() { }

	public override void OnGameStart() { }

	public override void OnRestartGame() { }

	protected override void PerformGameModelMods() { }

	protected override void RemoveEvents() { }

	[AsyncStateMachine(typeof(<ShowTeamCosmeticsAsync>d__30))]
	public void ShowTeamCosmeticsAsync(string guildID) { }

	protected override bool ShowWarning() { }

	protected void UpdateDisplay() { }

}

