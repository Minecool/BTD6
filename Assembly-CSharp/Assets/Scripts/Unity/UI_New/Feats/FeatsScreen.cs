namespace Assets.Scripts.Unity.UI_New.Feats;

public class FeatsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LegendsFeatActive, Boolean> <>9__9_0; //Field offset: 0x8
		public static Func<LegendsFeatActive, Boolean> <>9__16_0; //Field offset: 0x10
		public static Func<LegendsFeatActive, Boolean> <>9__16_1; //Field offset: 0x18
		public static Func<LegendsFeatActive, Single> <>9__16_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <GetSortedFeats>b__16_0(LegendsFeatActive x) { }

		internal bool <GetSortedFeats>b__16_1(LegendsFeatActive x) { }

		internal float <GetSortedFeats>b__16_2(LegendsFeatActive x) { }

		internal bool <Open>b__9_0(LegendsFeatActive feat) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public IEnumerable<LegendsFeatActive> feats; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <LoadFeatPanelsAsync>b__0(FeatPanel ap) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_1
	{
		public LegendsFeatActive feat; //Field offset: 0x10

		public <>c__DisplayClass15_1() { }

		internal bool <LoadFeatPanelsAsync>b__1(FeatPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string searchString; //Field offset: 0x10
		public bool canShowHidden; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal bool <FilterFeats>b__0(LegendsFeatActive a) { }

	}

	[CompilerGenerated]
	private struct <DisplayFeatsAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public FeatsScreen <>4__this; //Field offset: 0x28
		public IEnumerable<LegendsFeatActive> feats; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadFeatPanelsAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<LegendsFeatActive> feats; //Field offset: 0x20
		public FeatsScreen <>4__this; //Field offset: 0x28
		private <>c__DisplayClass15_1 <>8__1; //Field offset: 0x30
		private int <displayCount>5__2; //Field offset: 0x38
		private int <count>5__3; //Field offset: 0x3C
		private IEnumerator<LegendsFeatActive> <>7__wrap3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public FeatPanel featPanelPrefab; //Field offset: 0x48
	public RectTransform container; //Field offset: 0x50
	public TMP_InputField searchField; //Field offset: 0x58
	public TMP_Text searchPlaceholder; //Field offset: 0x60
	public NK_TextMeshProUGUI featCountTxt; //Field offset: 0x68
	public GameObject nothingFoundObj; //Field offset: 0x70
	private ContentSizeFitter contentSizeFitter; //Field offset: 0x78
	private readonly List<FeatPanel> featPanels; //Field offset: 0x80
	private CancellationTokenSource loadingToken; //Field offset: 0x88
	private Task featLoadingTask; //Field offset: 0x90
	private bool isClosed; //Field offset: 0x98

	private List<LegendsFeatActive> AllFeats
	{
		private get { } //Length: 92
	}

	public FeatsScreen() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<DisplayFeatsAsync>d__14))]
	private void DisplayFeatsAsync(IEnumerable<LegendsFeatActive> feats) { }

	private void FilterFeats(string searchString) { }

	private List<LegendsFeatActive> get_AllFeats() { }

	private IEnumerable<LegendsFeatActive> GetSortedFeats(IEnumerable<LegendsFeatActive> feats) { }

	[AsyncStateMachine(typeof(<LoadFeatPanelsAsync>d__15))]
	private Task LoadFeatPanelsAsync(IEnumerable<LegendsFeatActive> feats) { }

	public virtual void Open(object data) { }

	public virtual void ReClose() { }

	public virtual void ReOpen(object data) { }

	private void UpdateFeatCounter() { }

}

