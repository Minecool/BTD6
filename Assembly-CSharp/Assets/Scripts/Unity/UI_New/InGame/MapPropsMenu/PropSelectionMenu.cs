namespace Assets.Scripts.Unity.UI_New.InGame.MapPropsMenu;

public class PropSelectionMenu : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public PropSelectionMenu <>4__this; //Field offset: 0x10
		public IEnumerable<String> selectedPropsTags; //Field offset: 0x18
		public List<PropSelectionMenuTag> tagObjectsToShow; //Field offset: 0x20

		public <>c__DisplayClass59_0() { }

		internal bool <CreateTags>b__0(string x) { }

		internal bool <CreateTags>b__1(PropSelectionMenuTag tagObject) { }

		internal bool <CreateTags>b__2(PropSelectionMenuTag tagObject) { }

		internal bool <CreateTags>b__3(string tagString) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_1
	{
		public PropSelectionMenuTag tagObject; //Field offset: 0x10

		public <>c__DisplayClass59_1() { }

		internal bool <CreateTags>b__4(string tagString) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_2
	{
		public string tagString; //Field offset: 0x10

		public <>c__DisplayClass59_2() { }

		internal bool <CreateTags>b__5(PropSelectionMenuTag tagObject) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PropSelectionMenu <>4__this; //Field offset: 0x20

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
		public <Initialise>d__48(int <>1__state) { }

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

	internal sealed class TriggerClosePropSelectionMenu : MulticastDelegate
	{

		public TriggerClosePropSelectionMenu(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static PropSelectionMenu instance; //Field offset: 0x0
	private const int animationStateOpenHardLeft = 4; //Field offset: 0x0
	private const int animationStateOpenHardRight = 3; //Field offset: 0x0
	private const int animationStateOpenRight = 2; //Field offset: 0x0
	public const float DEFAULT_SCALE = 100; //Field offset: 0x0
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpenLeft = 1; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x20
	public NK_TextMeshProUGUI sellText; //Field offset: 0x28
	public Button sellButton; //Field offset: 0x30
	public Button moveButton; //Field offset: 0x38
	public Button copyButton; //Field offset: 0x40
	public AudioClip returnSound; //Field offset: 0x48
	public AudioClip undoSound; //Field offset: 0x50
	public AudioClip clickSound; //Field offset: 0x58
	public Animator animator; //Field offset: 0x60
	public PropSelectionMenuThemeManager themeManager; //Field offset: 0x68
	public GameObject platformIcon; //Field offset: 0x70
	public RectTransform scalar; //Field offset: 0x78
	public float bottomScaleAmount; //Field offset: 0x80
	public Slider scaleSlider; //Field offset: 0x88
	public Slider rotationSlider; //Field offset: 0x90
	public Slider tiltSlider; //Field offset: 0x98
	public Slider yawSlider; //Field offset: 0xA0
	public Slider heightSlider; //Field offset: 0xA8
	public Button scaleSliderDefaultBtn; //Field offset: 0xB0
	public Button rotationSliderDefaultBtn; //Field offset: 0xB8
	public Button tiltSliderDefaultBtn; //Field offset: 0xC0
	public Button yawSliderDefaultBtn; //Field offset: 0xC8
	public Button heightSliderDefaultBtn; //Field offset: 0xD0
	public Toggle animationTgl; //Field offset: 0xD8
	public Toggle blockingTgl; //Field offset: 0xE0
	private PropToSimulation selectedProp; //Field offset: 0xE8
	public Transform labelGroup; //Field offset: 0xF0
	public PropSelectionMenuTag tagPrefab; //Field offset: 0xF8
	public String[] ignoredTags; //Field offset: 0x100
	private List<PropSelectionMenuTag> tagObjects; //Field offset: 0x108

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	public bool IsMapEditorMode
	{
		 get { } //Length: 74
	}

	public bool IsOpenedRight
	{
		 get { } //Length: 3
	}

	public bool IsOwner
	{
		 get { } //Length: 78
	}

	public PropToSimulation SelectedProp
	{
		 get { } //Length: 8
	}

	public PropSelectionMenu() { }

	[CompilerGenerated]
	private void <Initialise>b__48_0() { }

	[CompilerGenerated]
	private void <Initialise>b__48_1() { }

	[CompilerGenerated]
	private void <Initialise>b__48_2() { }

	[CompilerGenerated]
	private void <Initialise>b__48_3() { }

	[CompilerGenerated]
	private void <Initialise>b__48_4() { }

	[CompilerGenerated]
	private void <Initialise>b__48_5() { }

	[CompilerGenerated]
	private void <Initialise>b__48_6() { }

	private void BlockItemPlacement(bool isBlocked) { }

	private void CreateTags(PropModel propModel) { }

	public void DeselectProp() { }

	private void EditorPopoutChanged(bool extended) { }

	public void ExitSelectionMenu() { }

	private UnityToSimulation get_Bridge() { }

	public bool get_IsMapEditorMode() { }

	public bool get_IsOpenedRight() { }

	public bool get_IsOwner() { }

	public PropToSimulation get_SelectedProp() { }

	[IteratorStateMachine(typeof(<Initialise>d__48))]
	public virtual IEnumerator Initialise() { }

	public void OnClose() { }

	public void OnCopyOrMoveProp(bool copyProp = false, bool overrideCursorModeFollowTouch = false) { }

	private void OnDestroy() { }

	public virtual void OnGameEnd() { }

	public virtual void OnGameStart() { }

	public void OnHeightChanged(float value) { }

	public void OnPitchProp(float value) { }

	public void OnRotationChanged(float value) { }

	public void OnScaleChanged(float value) { }

	public void OnSellProp() { }

	public void OnToggleBlockingChanged(bool isOn) { }

	public void OnTogglePropAnimationChanged(bool isOn) { }

	public void OnTsmThemeAction(ObjectId propId, string themeId, string buttonId, TSMInfoModel info) { }

	public virtual void OnUpdate() { }

	public void OnYawChanged(float value) { }

	private void PropDestroyed(PropToSimulation pts) { }

	public void SelectionChanged(Selectable s) { }

	public void SelectProp(PropToSimulation prop) { }

	public void SetRightAnimationPosition(bool extended) { }

	public void Show() { }

	private void UpdateProp() { }

}

