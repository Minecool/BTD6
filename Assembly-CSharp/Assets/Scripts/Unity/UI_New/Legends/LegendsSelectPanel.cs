namespace Assets.Scripts.Unity.UI_New.Legends;

public class LegendsSelectPanel : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public LegendsSelectPanel <>4__this; //Field offset: 0x10
		public string iapId; //Field offset: 0x18

		public <>c__DisplayClass50_0() { }

		internal bool <UpdateDisplayPrice>b__1(IapEvent x) { }

		internal void <UpdateDisplayPrice>g__updateSaleEndTimer|0() { }

	}

	[CompilerGenerated]
	private sealed class <LoadLegendsMainMenu>d__43 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LegendsType legendsType; //Field offset: 0x20
		private string <previousMenuName>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadLegendsMainMenu>d__43(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class OnSteamDlcPurchased : MulticastDelegate
	{

		public OnSteamDlcPurchased(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OpenSteamStoreOverlay : MulticastDelegate
	{

		public OpenSteamStoreOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint dlcId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(uint dlcId) { }

	}

	[SerializeField]
	private Button goToLegendsBtn; //Field offset: 0x48
	[SerializeField]
	private Button goToHomeBtn; //Field offset: 0x50
	[SerializeField]
	private Button infoButton; //Field offset: 0x58
	[SerializeField]
	private Button infoClose; //Field offset: 0x60
	[SerializeField]
	private Button tryBtn; //Field offset: 0x68
	[SerializeField]
	private Button purchaseBtn; //Field offset: 0x70
	[SerializeField]
	private GameObject homePanel; //Field offset: 0x78
	[SerializeField]
	private GameObject infoPanel; //Field offset: 0x80
	[SerializeField]
	private GameObject comingSoonPanel; //Field offset: 0x88
	[SerializeField]
	private GameObject youAreHereMainMenu; //Field offset: 0x90
	[SerializeField]
	private GameObject youAreHereRogue; //Field offset: 0x98
	[SerializeField]
	private SlideshowInfoPanel slidePanel; //Field offset: 0xA0
	[SerializeField]
	private AudioClip purchasedItemSound; //Field offset: 0xA8
	[SerializeField]
	private NK_TextMeshProUGUI purchasePrice; //Field offset: 0xB0
	[SerializeField]
	private NK_TextMeshProUGUI purchaseOriginalPrice; //Field offset: 0xB8
	[SerializeField]
	private NK_TextMeshProUGUI saleEndTimeTxt; //Field offset: 0xC0
	[SerializeField]
	private GameObject[] saleObjects; //Field offset: 0xC8
	[Header("Rogue Specific")]
	[SerializeField]
	private GameObject roguePurchasePanel; //Field offset: 0xD0
	[SerializeField]
	private GameObject roguePanel; //Field offset: 0xD8
	private bool hasOpened; //Field offset: 0xE0
	[CompilerGenerated]
	private LegendsSelectPanelData <MenuData>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Nullable<DateTime> <SaleEndTime>k__BackingField; //Field offset: 0xF0
	private Nullable<Boolean> isDisplayingOnSale; //Field offset: 0x100

	private LegendsType LegendsType
	{
		private get { } //Length: 29
	}

	private GameObject MainPanel
	{
		private get { } //Length: 106
	}

	private LegendsSelectPanelData MenuData
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private GameObject PurchasePanel
	{
		private get { } //Length: 106
	}

	private Nullable<DateTime> SaleEndTime
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public LegendsSelectPanel() { }

	[CompilerGenerated]
	private void <Awake>b__36_0() { }

	protected virtual void Awake() { }

	private void CloseInfoPanel() { }

	private LegendsType get_LegendsType() { }

	private GameObject get_MainPanel() { }

	[CompilerGenerated]
	private LegendsSelectPanelData get_MenuData() { }

	private GameObject get_PurchasePanel() { }

	[CompilerGenerated]
	private Nullable<DateTime> get_SaleEndTime() { }

	private void GoToLegendsMainMenu(LegendsType legendsType) { }

	private void GoToMainMenu() { }

	[IteratorStateMachine(typeof(<LoadLegendsMainMenu>d__43))]
	private IEnumerator LoadLegendsMainMenu(LegendsType legendsType) { }

	private void OnPurchaseComplete() { }

	public virtual void Open(object data) { }

	private void PurchaseLegends() { }

	private void ReloadUi() { }

	[CompilerGenerated]
	private void set_MenuData(LegendsSelectPanelData value) { }

	[CompilerGenerated]
	private void set_SaleEndTime(Nullable<DateTime> value) { }

	private void ToggleInfoPanel() { }

	private void TryRogueLegends() { }

	private void Update() { }

	private void UpdateDisplayPrice() { }

	private void UpdateSeenLegends(LegendsType legendsType) { }

}

