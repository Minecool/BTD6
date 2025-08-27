namespace Assets.Scripts.Unity.UI_New.Twitch;

public class TwitchPollPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PollItem, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<PollItem, UInt32> <>9__10_1; //Field offset: 0x10
		public static Func<PollItem, Boolean> <>9__11_0; //Field offset: 0x18
		public static Func<PollItem, UInt32> <>9__11_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <SetDisplayList>b__10_0(PollItem x) { }

		internal uint <SetDisplayList>b__10_1(PollItem y) { }

		internal bool <SetWinners>b__11_0(PollItem x) { }

		internal uint <SetWinners>b__11_1(PollItem y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public PollItem pollItem; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <SetDisplayList>b__2(TwitchPollPanelOption x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public PollItem pollItem; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <SetWinners>b__2(TwitchPollPanelOption x) { }

	}

	public Button createPollBtn; //Field offset: 0x20
	public Button cancelPollBtn; //Field offset: 0x28
	public NK_TextMeshProUGUI statusTxt; //Field offset: 0x30
	public TwitchPollPanelOption optionTemplate; //Field offset: 0x38
	public Transform contentParent; //Field offset: 0x40
	public GameObject loadingSpinner; //Field offset: 0x48
	public TwitchPollCreationPanel twitchPollCreationPanel; //Field offset: 0x50
	private readonly List<TwitchPollPanelOption> choicePanels; //Field offset: 0x58

	public TwitchPollPanel() { }

	[CompilerGenerated]
	private void <Start>b__8_0() { }

	public void ResetChoices() { }

	public void SetDisplayList(List<PollItem> pollItems) { }

	public void SetWinners(List<PollItem> pollItems) { }

	private void Start() { }

}

