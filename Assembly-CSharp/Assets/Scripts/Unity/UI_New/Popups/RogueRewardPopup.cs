namespace Assets.Scripts.Unity.UI_New.Popups;

public class RogueRewardPopup : Popup
{
	[CompilerGenerated]
	private struct <CloseAfterDelay>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueRewardPopup <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private AudioClip rewardSound; //Field offset: 0x128
	[SerializeField]
	private Lightbox close; //Field offset: 0x130
	[SerializeField]
	private float closeDelay; //Field offset: 0x138
	[SerializeField]
	private GameObject banner; //Field offset: 0x140
	[SerializeField]
	private GameObject stackCountObj; //Field offset: 0x148
	[SerializeField]
	private NK_TextMeshProUGUI stackCountTxt; //Field offset: 0x150
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x158
	[SerializeField]
	private RogueLootChoiceButton rewardLootDisplay; //Field offset: 0x160

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	public RogueRewardPopup() { }

	public void Awake() { }

	public void Bind(RogueLoot loot, bool closeAfterDelay, int stackCount) { }

	[AsyncStateMachine(typeof(<CloseAfterDelay>d__12))]
	private Task CloseAfterDelay() { }

	private LegendsDataModel get_LegendsData() { }

	private SpriteReference GetPowerIcon(string baseId) { }

}

