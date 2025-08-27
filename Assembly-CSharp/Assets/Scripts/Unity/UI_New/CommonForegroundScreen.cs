namespace Assets.Scripts.Unity.UI_New;

public class CommonForegroundScreen : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CheckMenuDataForDialogueDataTriggered>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public CommonForegroundScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <ShowHideObjectCoroutine>d__52 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool force; //Field offset: 0x20
		public GameObject go; //Field offset: 0x28
		public bool show; //Field offset: 0x30
		private RectTransform <rectTransform>5__2; //Field offset: 0x38
		private Vector2 <pos>5__3; //Field offset: 0x40
		private float <target>5__4; //Field offset: 0x48
		private double <startTime>5__5; //Field offset: 0x50
		private float <start>5__6; //Field offset: 0x58

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
		public <ShowHideObjectCoroutine>d__52(int <>1__state) { }

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
	private struct <TryRunAnimatedDialogueSequence>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CommonForegroundScreen <>4__this; //Field offset: 0x20
		public DialogueData data; //Field offset: 0x28
		public Action cancelledCallback; //Field offset: 0x30
		public Action completedCallback; //Field offset: 0x38
		public Action<String>[] actions; //Field offset: 0x40
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CheckMenuDataForDialogueData : MulticastDelegate
	{

		public CheckMenuDataForDialogueData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(object data) { }

	}

	private const double s = 1.70158; //Field offset: 0x0
	public static CommonForegroundScreen instance; //Field offset: 0x0
	public Animator animator; //Field offset: 0x20
	public GameObject heading; //Field offset: 0x28
	public GameObject monkeyMoney; //Field offset: 0x30
	public GameObject knownledge; //Field offset: 0x38
	public GameObject buyMoreMonkeyMoneyButton; //Field offset: 0x40
	public GameObject buyKnowledgeButton; //Field offset: 0x48
	public CommonForegroundScreenHeroButton changeHeroButton; //Field offset: 0x50
	public Button changeHeroButtonBtn; //Field offset: 0x58
	public CommonForegroundExtraSettings extraSettings; //Field offset: 0x60
	public Button backBtn; //Field offset: 0x68
	public NK_TextMeshProUGUI lblHeading; //Field offset: 0x70
	public NK_TextMeshProUGUI lblKnowledge; //Field offset: 0x78
	public Image loadingImg; //Field offset: 0x80
	private bool backEnabled; //Field offset: 0x88
	private int knowledgePoints; //Field offset: 0x8C
	[CompilerGenerated]
	private List<String> <LimitedHeroSelection>k__BackingField; //Field offset: 0x90
	public GameObject questDialogueContainer; //Field offset: 0x98
	public Action OnClickedInteractiveAnimatedSequence; //Field offset: 0xA0
	public bool dialogSystemOpened; //Field offset: 0xA8
	private QuestDialogueSystem questDialogueSystem; //Field offset: 0xB0

	private bool CanShowHeroButton
	{
		private get { } //Length: 75
	}

	public bool IsBuyMonkeyMoneyButtonEnabled
	{
		 get { } //Length: 122
		 set { } //Length: 130
	}

	public bool IsQuestDialogueBlocking
	{
		 get { } //Length: 8
	}

	public private List<String> LimitedHeroSelection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public CommonForegroundScreen() { }

	[CompilerGenerated]
	private void <TryRunAnimatedDialogueSequence>b__57_0(AsyncOperationHandle<GameObject> h) { }

	private void Awake() { }

	public void BuyKnowledgeClicked() { }

	public void ChangeHeroButtonClicked() { }

	[AsyncStateMachine(typeof(<CheckMenuDataForDialogueDataTriggered>d__55))]
	private void CheckMenuDataForDialogueDataTriggered(object data) { }

	public void ClickedDialogue() { }

	private static double easeInBack(double t) { }

	private static double easeOutBack(double t) { }

	private bool get_CanShowHeroButton() { }

	public bool get_IsBuyMonkeyMoneyButtonEnabled() { }

	public bool get_IsQuestDialogueBlocking() { }

	[CompilerGenerated]
	public List<String> get_LimitedHeroSelection() { }

	public static string GetSelectedHeroSkin() { }

	public void Hide() { }

	public bool IsBackClickable() { }

	public void MoreMonkeyMoneyClicked() { }

	private void OnDestroy() { }

	private void OnDestroyQuestDialogueCallback() { }

	public static void ResetAllowedHeroes() { }

	public void set_IsBuyMonkeyMoneyButtonEnabled(bool value) { }

	[CompilerGenerated]
	private void set_LimitedHeroSelection(List<String> value) { }

	public void SetBackInteractable(bool value) { }

	public static void SetHeroSelection(List<String> limitedHeroSelection) { }

	public void Show(bool showBackButton, string heading, bool showMonkeyMoney, bool enableBuyMonkeyMoney, bool showKnowledge, bool showBuyKnowledge, bool showChangeHeroButton, bool showFriendsButton, bool showExtraSettings) { }

	public static void ShowExtraSettings(bool show) { }

	public static void ShowHideBackButton(bool showBackButton) { }

	public static void ShowHideFriendsButton(bool show) { }

	public static void ShowHideHeading(bool showHeading) { }

	public static void ShowHideHeroButton(bool showHeroButton) { }

	public static void ShowHideKnowledge(bool show, bool force = false) { }

	public static void ShowHideMonkeyMoney(bool show, bool force = false) { }

	[IteratorStateMachine(typeof(<ShowHideObjectCoroutine>d__52))]
	private static IEnumerator ShowHideObjectCoroutine(GameObject go, bool show, bool force = false) { }

	public static void ShowLobbyMessage(bool show) { }

	[AsyncStateMachine(typeof(<TryRunAnimatedDialogueSequence>d__57))]
	public Task<Boolean> TryRunAnimatedDialogueSequence(DialogueData data, Action completedCallback = null, Action cancelledCallback = null, Action<String>[] actions = null) { }

	public void Update() { }

	public static void UpdateHeroSelection(List<String> limitedHeroSelection) { }

}

