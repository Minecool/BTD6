namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class InstaTowerScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__38_0; //Field offset: 0x8
		public static Func<InstaTowerTypeDisplay, Boolean> <>9__42_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__38_0() { }

		internal bool <UpdateTypesCounts>b__42_0(InstaTowerTypeDisplay x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public InstaTowerTypeDisplay itt; //Field offset: 0x10
		public InstaTowerScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass43_0() { }

		internal void <LoadTypes>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Int32[] ftl; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal bool <LoadCollectionView>b__0(InstaTowerModel x) { }

	}

	[CompilerGenerated]
	private sealed class <LoadCollectionView>d__55 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string monkeyType; //Field offset: 0x20
		public InstaTowerScreen <>4__this; //Field offset: 0x28
		private List<InstaTowerModel> <typeInstaList>5__2; //Field offset: 0x30
		private int <count>5__3; //Field offset: 0x38
		private Enumerator<Int32[]> <>7__wrap3; //Field offset: 0x40

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
		public <LoadCollectionView>d__55(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private sealed class <LoadInstaTowers>d__46 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string monkeyType; //Field offset: 0x20
		public InstaTowerScreen <>4__this; //Field offset: 0x28
		private int <count>5__2; //Field offset: 0x30
		private Enumerator<InstaTowerModel> <>7__wrap2; //Field offset: 0x38

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
		public <LoadInstaTowers>d__46(int <>1__state) { }

		private void <>m__Finally1() { }

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

	public NK_TextMeshProUGUI menuTitleTxt; //Field offset: 0x48
	public Button buyInstasBtn; //Field offset: 0x50
	public GameObject instaTypeObject; //Field offset: 0x58
	public Transform instaTypeContainer; //Field offset: 0x60
	public InstaTowerTypeDisplay instaTypePrefab; //Field offset: 0x68
	public Animator subTitleAnimator; //Field offset: 0x70
	private bool typesLoaded; //Field offset: 0x78
	private bool showingInstaCollection; //Field offset: 0x79
	private List<InstaTowerTypeDisplay> typeDisplayList; //Field offset: 0x80
	public GameObject instaCollectionObject; //Field offset: 0x88
	public Transform instaContainer; //Field offset: 0x90
	public ScrollRect instaScrollRect; //Field offset: 0x98
	public InstaTowerDisplay instaPrefab; //Field offset: 0xA0
	public GameObject noInventoryObj; //Field offset: 0xA8
	public NK_TextMeshProUGUI subTitleTxt; //Field offset: 0xB0
	public NK_TextMeshProUGUI subCountTxt; //Field offset: 0xB8
	public Button arrowRightBtn; //Field offset: 0xC0
	public Button arrowLeftBtn; //Field offset: 0xC8
	public GestureSettings gestureSetting; //Field offset: 0xD0
	private TouchGesture touch; //Field offset: 0xD8
	public Toggle collectionViewToggle; //Field offset: 0xE0
	public NK_TextMeshProUGUI collectionViewToggleTxt; //Field offset: 0xE8
	public NK_TextMeshProUGUI collectionViewDescTxt; //Field offset: 0xF0
	public float descTxtFadeTime; //Field offset: 0xF8
	private Color descColor; //Field offset: 0xFC
	public GameObject missingInstaSiloutte; //Field offset: 0x110
	public GameObject DEBUGObject; //Field offset: 0x118
	public Button DEBUGToggleDebugBtn; //Field offset: 0x120
	public Button DEBUGAddAllInstasBtn; //Field offset: 0x128
	public Button DEBUGRemoveAllInstasBtn; //Field offset: 0x130
	public Button DEBUGAddRandomInstasBtn; //Field offset: 0x138
	public Button DEBUGHardClearBtn; //Field offset: 0x140
	public AudioClip returnSound; //Field offset: 0x148
	public AudioClip click1Sound; //Field offset: 0x150
	public int pageIndex; //Field offset: 0x158
	private Coroutine loadViewCR; //Field offset: 0x160
	private Coroutine swipeCR; //Field offset: 0x168
	private bool sorted; //Field offset: 0x170

	public InstaTowerScreen() { }

	[CompilerGenerated]
	private void <Open>b__39_0() { }

	protected virtual void Awake() { }

	public void ClearChildren(Transform tfm) { }

	private void GamepadUpdateCollectionNav() { }

	private void GamepadUpdateSelected() { }

	private List<Int32[]> GenerateFullTierList() { }

	public ValueTuple<Int32, Int32, Int32, Int32> GetHighestTier(Int32[] tiers) { }

	public int GetTotalUpgrades(Int32[] tiers) { }

	public void LeftClicked() { }

	[IteratorStateMachine(typeof(<LoadCollectionView>d__55))]
	public IEnumerator LoadCollectionView(string monkeyType) { }

	[IteratorStateMachine(typeof(<LoadInstaTowers>d__46))]
	public IEnumerator LoadInstaTowers(string monkeyType) { }

	public void LoadTypes() { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	public void RightClicked() { }

	public void ShowCollection(string monkeyType) { }

	public void ShowCollectionFromType(InstaTowerTypeDisplay model) { }

	public int SortByTier(InstaTowerModel a, InstaTowerModel b) { }

	public int SortByTier(Int32[] a, Int32[] b) { }

	public void SwitchFromTypeToCollectionView() { }

	private void ToggleCollectionView(bool collectionView) { }

	private void Update() { }

	public void UpdateTypesCounts() { }

}

