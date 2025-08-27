//Type is in global namespace

public class AccoladesDisplayButton : AccoladeStatsDisplay
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Accolade, Boolean> <>9__15_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<AccoladeType, Int32>, Boolean> <>9__19_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<AccoladeType, Int32>, AccoladeType> <>9__19_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <PopAnimations>b__19_0(KeyValuePair<AccoladeType, Int32> x) { }

		internal AccoladeType <PopAnimations>b__19_1(KeyValuePair<AccoladeType, Int32> x) { }

		internal bool <Refresh>b__15_0(Accolade x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public ContentType contentType; //Field offset: 0x10
		public string contentId; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal bool <Refresh>b__1(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <ShowPurchaseAnimations>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesDisplayButton <>4__this; //Field offset: 0x20
		private bool <useAltAnimator>5__2; //Field offset: 0x28
		private Enumerator<AccoladeType, Int32> <>7__wrap2; //Field offset: 0x30
		private Animator <animator>5__4; //Field offset: 0x50
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryOpenStoreAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesDisplayButton <>4__this; //Field offset: 0x28
		private Task<String> <playerNameTask>5__2; //Field offset: 0x30
		private Task<NexusStatusModel> <nexusStatusTask>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button storePopupButton; //Field offset: 0x48
	[SerializeField]
	private Image storeLoadingSpinner; //Field offset: 0x50
	[SerializeField]
	private GameObject noAccoladeIcon; //Field offset: 0x58
	[SerializeField]
	private AccoladeSummaryScreenDisplay accoladesFloatDisplay; //Field offset: 0x60
	[SerializeField]
	private Animator purchasedAnim; //Field offset: 0x68
	[SerializeField]
	private Transform purchasedAnimIconContainer; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI purchasedAnimQuantityTxt; //Field offset: 0x78
	[SerializeField]
	private Animator purchasedAnim2; //Field offset: 0x80
	[SerializeField]
	private Transform purchasedAnimIconContainer2; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI purchasedAnimQuantityTxt2; //Field offset: 0x90
	private GameObject currentIcon; //Field offset: 0x98
	[SerializeField]
	private float purchasedAnimDisplay; //Field offset: 0xA0
	private PlayerContentInfo playerContentInfo; //Field offset: 0xA8
	private readonly Dictionary<AccoladeType, Int32> newAccolades; //Field offset: 0xB0

	public AccoladesDisplayButton() { }

	private void AddAccoladeNewAccoladeData(AccoladeType accoladeType, int quantity) { }

	protected virtual void Awake() { }

	public void Initialize(PlayerContentInfo playerContentinfo) { }

	private void PopAnimations() { }

	private void Refresh(ContentType contentType, string contentId, Accolade[] accolades) { }

	[AsyncStateMachine(typeof(<ShowPurchaseAnimations>d__20))]
	private Task ShowPurchaseAnimations() { }

	[AsyncStateMachine(typeof(<TryOpenStoreAsync>d__16))]
	private void TryOpenStoreAsync() { }

}

