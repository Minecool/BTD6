namespace Assets.Scripts.Unity.UI_New.InGame.BloonMenu;

public class BloonMenu : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BloonModel, Single> <>9__49_0; //Field offset: 0x8
		public static Func<BloonModel, Boolean> <>9__49_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <SortBloons>b__49_0(BloonModel x) { }

		internal bool <SortBloons>b__49_1(BloonModel x) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BloonMenu <>4__this; //Field offset: 0x20

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
		public <Initialise>d__30(int <>1__state) { }

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

	internal sealed class OnForceCloseSandboxMenuEvent : MulticastDelegate
	{

		public OnForceCloseSandboxMenuEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnToggleVisibleEvent : MulticastDelegate
	{

		public OnToggleVisibleEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool hide, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool hide) { }

	}

	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationState4_3Open = 2; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	public BloonMenu instance; //Field offset: 0x20
	public GameObject spawnBloonButtonPrefab; //Field offset: 0x28
	public GameObject bloonButtonContainer; //Field offset: 0x30
	public GameObject destroyBloonsButton; //Field offset: 0x38
	public GameObject destroyTowersButton; //Field offset: 0x40
	public TMP_InputField bloonCount; //Field offset: 0x48
	public TMP_InputField bloonRate; //Field offset: 0x50
	public TMP_InputField roundDetails; //Field offset: 0x58
	private bool camo; //Field offset: 0x60
	private bool regen; //Field offset: 0x61
	private bool fortified; //Field offset: 0x62
	public float buttonDelay; //Field offset: 0x64
	private bool showing; //Field offset: 0x68
	public Animator animator; //Field offset: 0x70
	private readonly string visibleStateLabel; //Field offset: 0x78
	private bool sort; //Field offset: 0x80
	private int integerToSet; //Field offset: 0x84
	private List<SpawnBloonButton> bloonButtons; //Field offset: 0x88
	public Button btnDestroyBloons; //Field offset: 0x90
	public Button btnDestroyMonkeys; //Field offset: 0x98
	public Button btnResetAbilityCooldowns; //Field offset: 0xA0
	public Button btnResetDamage; //Field offset: 0xA8
	public Button btnPlaceCrosspaths; //Field offset: 0xB0
	public AudioClip clickSound; //Field offset: 0xB8
	private bool hideExternal; //Field offset: 0xC0
	private bool showInternal; //Field offset: 0xC1

	public BloonMenu() { }

	[CompilerGenerated]
	private void <Initialise>b__30_0() { }

	public void Awake() { }

	public void CheatSpawnRound() { }

	public void ClearButtons() { }

	public void CreateBloonButtons(List<BloonModel> sortedBloons) { }

	public void Disable() { }

	public void Enable() { }

	public void ForceCloseSandboxMenu() { }

	public SpawnBloonButton GetNextButton() { }

	public void Hide() { }

	[IteratorStateMachine(typeof(<Initialise>d__30))]
	public virtual IEnumerator Initialise() { }

	public bool IsShowing() { }

	public void OnBloonValueChanged(string newValue) { }

	private void OnClickedDestroyBloons() { }

	private void OnClickedDestroyMonkeys() { }

	private void OnClickedResetAbilityCooldowns() { }

	private void OnClickedResetDamage() { }

	public void OnDeselect() { }

	public void OnRoundValueChanged(string newValue) { }

	public void OnSelect() { }

	public void OnSpacingValueChanged(string newValue) { }

	public void SetRoundText(int roundCount) { }

	public void Show() { }

	private void ShowHideExternal(bool hide) { }

	public void SortBloons() { }

	public void Toggle() { }

	public void ToggleCamo(bool on) { }

	public void ToggleFortified(bool on) { }

	public void ToggleRegen(bool on) { }

	public void Update() { }

}

