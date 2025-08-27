namespace Assets.Scripts.Unity.UI_New;

public class RogueMainMenuScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
		public static Func<ValueTuple`2<String, Object>, Boolean> <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Open>b__21_0(ValueTuple<String, Object> x) { }

	}

	[CompilerGenerated]
	private sealed class <GoToRogueMap>d__31 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <GoToRogueMap>d__31(int <>1__state) { }

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
	private struct <Open>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMainMenuScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReOpen>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public RogueMainMenuScreen <>4__this; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button legendsBtn; //Field offset: 0x48
	[SerializeField]
	private Button artifactsBtn; //Field offset: 0x50
	[SerializeField]
	private Button homeBtn; //Field offset: 0x58
	[SerializeField]
	private Button xpShopBtn; //Field offset: 0x60
	[SerializeField]
	private DisplayArtifactsPanel artifactsPanel; //Field offset: 0x68
	[SerializeField]
	private RogueXpShopPanel rogueXpShopPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject xpShopPip; //Field offset: 0x78
	[SerializeField]
	private GameObject newXpObj; //Field offset: 0x80
	[SerializeField]
	private NK_TextMeshProUGUI newXpTxt; //Field offset: 0x88
	[SerializeField]
	private Button newCampaignBtn; //Field offset: 0x90
	[SerializeField]
	private Button trainingModeBtn; //Field offset: 0x98
	[SerializeField]
	private GameObject infoPopup; //Field offset: 0xA0
	[SerializeField]
	private Button infoBtn; //Field offset: 0xA8
	[SerializeField]
	private Button infoCloseBtn; //Field offset: 0xB0
	[SerializeField]
	private Lightbox infoCloseBg; //Field offset: 0xB8
	[SerializeField]
	private float openingAnimDelay; //Field offset: 0xC0

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueMainMenuScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <Awake>b__20_0() { }

	[CompilerGenerated]
	private void <Awake>b__20_1() { }

	protected virtual void Awake() { }

	private void BackClickedLegends() { }

	private void CampaignClicked() { }

	private bool CanAffordXpShopItem() { }

	public virtual void Close() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	[IteratorStateMachine(typeof(<GoToRogueMap>d__31))]
	private IEnumerator GoToRogueMap() { }

	private void HomeClicked() { }

	[AsyncStateMachine(typeof(<Open>d__21))]
	public virtual void Open(object data) { }

	public void OpenArtifactPanel() { }

	public void OpenHeroSelect() { }

	private void OpenXpShop() { }

	public virtual bool OverrideClose() { }

	private void PlayNewXpAnim() { }

	[AsyncStateMachine(typeof(<ReOpen>d__22))]
	public virtual void ReOpen(object data) { }

	private void ShowInfoPopup() { }

	private void ToggleLegendsSelectionPanel() { }

	private void TrainingClicked() { }

}

