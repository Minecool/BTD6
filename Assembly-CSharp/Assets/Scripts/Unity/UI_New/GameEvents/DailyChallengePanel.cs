namespace Assets.Scripts.Unity.UI_New.GameEvents;

public class DailyChallengePanel : GameEventPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public OnClick onClick; //Field offset: 0x10
		public DailyChallengePanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Bind>b__0() { }

	}

	internal sealed class OnClick : MulticastDelegate
	{

		public OnClick(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DailyChallengeModel dcm, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(DailyChallengeModel dcm) { }

	}

	public Button panelBtn; //Field offset: 0x60
	public LootPanel lootPanel; //Field offset: 0x68
	public GameObject claimedPanel; //Field offset: 0x70
	public Button showChalIDBtn; //Field offset: 0x78
	public InputField showChalIDTxt; //Field offset: 0x80
	private DailyChallengeModel dcm; //Field offset: 0x88

	public DailyChallengePanel() { }

	public void Bind(DailyChallengeModel dailyChallenge, int panelPriority, OnClick onClick) { }

	public void Start() { }

	public void Update() { }

}

