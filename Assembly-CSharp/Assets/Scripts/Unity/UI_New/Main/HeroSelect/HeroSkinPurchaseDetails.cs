namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroSkinPurchaseDetails : GameMenu
{
	[CompilerGenerated]
	private struct <StartBackgroundColourSwap>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HeroSkinPurchaseDetails <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Animator menuAnimator; //Field offset: 0x48
	public NK_TextMeshProUGUI titleName; //Field offset: 0x50
	public NK_TextMeshProUGUI heroDescription; //Field offset: 0x58
	public Image titleBanner; //Field offset: 0x60
	public Image portraitMain; //Field offset: 0x68
	public Image portraitLvl3; //Field offset: 0x70
	public Image portraitLvl10; //Field offset: 0x78
	public Image portraitLvl20; //Field offset: 0x80
	public NK_TextMeshProUGUI txtLvl3; //Field offset: 0x88
	public NK_TextMeshProUGUI txtLvl10; //Field offset: 0x90
	public NK_TextMeshProUGUI txtLvl20; //Field offset: 0x98
	public Button btnBuy; //Field offset: 0xA0
	public NK_TextMeshProUGUI txtCost; //Field offset: 0xA8
	public NK_TextMeshProUGUI txtUnlockFor; //Field offset: 0xB0
	public GameObject salesBannerObj; //Field offset: 0xB8
	public NK_TextMeshProUGUI txtOrigionalCost; //Field offset: 0xC0
	private SkinData skinData; //Field offset: 0xC8
	[SerializeField]
	private GameObject rogueLoadoutObj; //Field offset: 0xD0
	[SerializeField]
	private RogueArtifactDisplayIcon startingArtifactIcon; //Field offset: 0xD8
	[SerializeField]
	private InstaTowerDisplay[] startingInstasIcons; //Field offset: 0xE0

	private bool CanBuyMonkeyMoney
	{
		private get { } //Length: 7
	}

	public HeroSkinPurchaseDetails() { }

	private void DisplayRogueStarterKit() { }

	private bool get_CanBuyMonkeyMoney() { }

	public void OnClickedBuyButton() { }

	public virtual void Open(object menuData) { }

	public void PurchaseAnimationFinished() { }

	[AsyncStateMachine(typeof(<StartBackgroundColourSwap>d__24))]
	private void StartBackgroundColourSwap() { }

	public void UpdateData() { }

}

