namespace Assets.Scripts.Unity.UI_New.Popups;

public class AccoladesStorePopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__42_3; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__42_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public AccoladesStorePopup <>4__this; //Field offset: 0x10
		public AccoladeType accoladeType; //Field offset: 0x18
		public int quantityIndex; //Field offset: 0x1C
		public bool isDebug; //Field offset: 0x20

		public <>c__DisplayClass46_0() { }

		internal void <PurchaseButtonClicked>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public AccoladeType enabledAccoladeType; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal bool <SortAccoladeIcons>b__0(AccoladePurchaseIcon x) { }

	}

	[CompilerGenerated]
	private struct <ApplyAccoladesAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesStorePopup <>4__this; //Field offset: 0x20
		public AccoladeType accoladeType; //Field offset: 0x28
		public int quantityIndex; //Field offset: 0x2C
		public bool isDebug; //Field offset: 0x30
		private bool <canRun>5__2; //Field offset: 0x31
		private ContentTypeSaveData <contentTypeData>5__3; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x40
		private TaskAwaiter<AccoladePurchaseRequestResponse> <>u__2; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListenToIapValidationExceptions>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesStorePopup <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private Purchaser <purchaser>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class PurchaseSuccessCallback : MulticastDelegate
	{

		public PurchaseSuccessCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AccoladeType accoladeType, int quantity, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(AccoladeType accoladeType, int quantity) { }

	}

	[CompilerGenerated]
	private static PlayerContentInfo <PlayerContentInfo>k__BackingField; //Field offset: 0x0
	private AccoladePurchaseIcon selectedIcon; //Field offset: 0x128
	private AccoladePurchaseIcon[] accoladeIcons; //Field offset: 0x130
	private bool _isPurchaseInProgress; //Field offset: 0x138
	[SerializeField]
	private AccoladePurchaseIcon iconPrefab; //Field offset: 0x140
	[SerializeField]
	private Transform iconsContainer; //Field offset: 0x148
	[SerializeField]
	private TextMeshProUGUI descriptionText; //Field offset: 0x150
	[SerializeField]
	private Button purchase1Btn; //Field offset: 0x158
	[SerializeField]
	private Button purchase5Btn; //Field offset: 0x160
	[SerializeField]
	private Button purchase20Btn; //Field offset: 0x168
	[SerializeField]
	private Button infoPanelOpenBtn; //Field offset: 0x170
	[SerializeField]
	private Button closeBtn; //Field offset: 0x178
	[SerializeField]
	private Button infoPanelOkBtn; //Field offset: 0x180
	[SerializeField]
	private GameObject infoPanel; //Field offset: 0x188
	[SerializeField]
	private GameObject loadingSpinner; //Field offset: 0x190
	[SerializeField]
	private Animator purchaseAnim; //Field offset: 0x198
	[SerializeField]
	private TextMeshProUGUI envelopePlayerName; //Field offset: 0x1A0
	[SerializeField]
	private TextMeshProUGUI lootText; //Field offset: 0x1A8
	[SerializeField]
	private Transform iconContainer; //Field offset: 0x1B0
	[SerializeField]
	private GameObject supportCreatorInfoGo; //Field offset: 0x1B8
	[SerializeField]
	private GameObject supportCreatorDisclaimerGo; //Field offset: 0x1C0
	[SerializeField]
	private NK_TextMeshProUGUI supportCreatorDisclaimerText; //Field offset: 0x1C8
	[SerializeField]
	private NK_TextMeshProUGUI percentageInfoText; //Field offset: 0x1D0
	[SerializeField]
	private NK_TextMeshProUGUI termsInfoText; //Field offset: 0x1D8
	[SerializeField]
	private Button termsInfoButton; //Field offset: 0x1E0
	[SerializeField]
	private NK_TextMeshProUGUI gift1AccoladeTxt; //Field offset: 0x1E8
	[SerializeField]
	private NK_TextMeshProUGUI gift5AccoladesTxt; //Field offset: 0x1F0
	[SerializeField]
	private NK_TextMeshProUGUI gift20AccoladesTxt; //Field offset: 0x1F8
	[SerializeField]
	private NK_TextMeshProUGUI purchase1PriceTxt; //Field offset: 0x200
	[SerializeField]
	private NK_TextMeshProUGUI purchase5PriceTxt; //Field offset: 0x208
	[SerializeField]
	private NK_TextMeshProUGUI purchase20PriceTxt; //Field offset: 0x210
	private GameObject animIcon; //Field offset: 0x218
	private PurchaseSuccessCallback purchaseSuccessCallback; //Field offset: 0x220
	private string playerName; //Field offset: 0x228
	private bool canUseNexus; //Field offset: 0x230
	private CancellationTokenSource validationListenerCanceller; //Field offset: 0x238

	private bool IsPurchaseInProgress
	{
		private get { } //Length: 8
		private set { } //Length: 58
	}

	public private static PlayerContentInfo PlayerContentInfo
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public AccoladesStorePopup() { }

	[CompilerGenerated]
	private void <Awake>b__42_0() { }

	[CompilerGenerated]
	private void <Awake>b__42_1() { }

	[CompilerGenerated]
	private void <Awake>b__42_2() { }

	[CompilerGenerated]
	private void <CreateAnimIcon>b__54_0(AsyncOperationHandle<GameObject> handle) { }

	public void AccoladeSelected(AccoladePurchaseIcon selectedAccolade) { }

	[AsyncStateMachine(typeof(<ApplyAccoladesAsync>d__49))]
	private Task ApplyAccoladesAsync(AccoladeType accoladeType, int quantityIndex, bool isDebug) { }

	private void Awake() { }

	public virtual void CancelClicked() { }

	private AsyncOperationHandle<GameObject> CreateAnimIcon(PrefabReference prefab) { }

	private bool get_IsPurchaseInProgress() { }

	[CompilerGenerated]
	public static PlayerContentInfo get_PlayerContentInfo() { }

	public void Initialize(PlayerContentInfo playerContentInfo, PurchaseSuccessCallback purchaseSuccessCallback, string playerName, bool canUseNexus) { }

	[AsyncStateMachine(typeof(<ListenToIapValidationExceptions>d__48))]
	private Task ListenToIapValidationExceptions(CancellationToken cancellationToken) { }

	private void OnDestroy() { }

	private void PurchaseButtonClicked(int quantityIndex, string iapId, bool isDebug = false) { }

	private void PurchaseFailed() { }

	private void set_IsPurchaseInProgress(bool value) { }

	[CompilerGenerated]
	private static void set_PlayerContentInfo(PlayerContentInfo value) { }

	private void SortAccoladeIcons() { }

	public void ToggleButtonsInteractable(bool isOn) { }

	private void ToggleInfoPanel() { }

	public void Update() { }

}

