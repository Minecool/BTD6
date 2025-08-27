namespace Assets.Scripts.Unity.UI_New.Popups;

public class Popup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CancelClickedAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool muteClickSound; //Field offset: 0x28
		public Popup <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OKClicked>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Popup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum TransitionAnim
	{
		Slide = 0,
		Scale = 1,
		Update = 2,
		AnimIndex = 3,
	}

	public const string slideId = "Slide"; //Field offset: 0x0
	public const string scaleId = "Scale"; //Field offset: 0x0
	public const string updateId = "Update"; //Field offset: 0x0
	public bool disablesHotKeys; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	private string lastTrigger; //Field offset: 0x30
	public GameObject titleObj; //Field offset: 0x38
	public GameObject bodyObj; //Field offset: 0x40
	public GameObject okObj; //Field offset: 0x48
	public GameObject cancelObj; //Field offset: 0x50
	public GameObject cashObj; //Field offset: 0x58
	public GameObject spinnerObj; //Field offset: 0x60
	public GameObject tickObj; //Field offset: 0x68
	public GameObject crossObj; //Field offset: 0x70
	public NK_TextMeshProUGUI title; //Field offset: 0x78
	public NK_TextMeshProUGUI body; //Field offset: 0x80
	public Image image; //Field offset: 0x88
	public NK_TextMeshProUGUI cashText; //Field offset: 0x90
	public NK_TextMeshProUGUI okText; //Field offset: 0x98
	public NK_TextMeshProUGUI cancelText; //Field offset: 0xA0
	public GameObject currentCashInfo; //Field offset: 0xA8
	public NK_TextMeshProUGUI currentCashText; //Field offset: 0xB0
	public AudioClip clickSound; //Field offset: 0xB8
	public AudioClip closeSound; //Field offset: 0xC0
	public float animationDelay; //Field offset: 0xC8
	protected bool instantClose; //Field offset: 0xCC
	protected bool closeIfTowersAreSuspended; //Field offset: 0xCD
	private bool canHide; //Field offset: 0xCE
	protected bool isHidden; //Field offset: 0xCF
	[CompilerGenerated]
	private bool <active>k__BackingField; //Field offset: 0xD0
	[HideInInspector]
	public ReturnCallback confirmCallback; //Field offset: 0xD8
	[HideInInspector]
	public ReturnCallback cancelCallback; //Field offset: 0xE0
	[HideInInspector]
	public AsyncReturnCallback asyncReturnCallback; //Field offset: 0xE8
	[HideInInspector]
	public AsyncReturnCallback asyncCancelCallback; //Field offset: 0xF0
	[HideInInspector]
	public BackGround background; //Field offset: 0xF8
	[CompilerGenerated]
	private bool <OverridesEnterKey>k__BackingField; //Field offset: 0xFC
	private Task awaitAsyncTasksConfirmCallback; //Field offset: 0x100
	private Task awaitAsyncTasksCancelCallback; //Field offset: 0x108
	[CompilerGenerated]
	private Action<Popup> popupHide; //Field offset: 0x110
	[CompilerGenerated]
	private Action<Popup> popupEnd; //Field offset: 0x118
	private TransitionAnim transition; //Field offset: 0x120

	public event Action<Popup> popupEnd
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Popup> popupHide
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	protected private bool active
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected LocalizationManager Locs
	{
		 get { } //Length: 48
	}

	public bool OverridesEnterKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Popup() { }

	[CompilerGenerated]
	public void add_popupEnd(Action<Popup> value) { }

	[CompilerGenerated]
	public void add_popupHide(Action<Popup> value) { }

	private void AnimStateEnd() { }

	public override void CancelClicked() { }

	[AsyncStateMachine(typeof(<CancelClickedAsync>d__64))]
	public void CancelClickedAsync(bool muteClickSound) { }

	[CompilerGenerated]
	protected bool get_active() { }

	protected LocalizationManager get_Locs() { }

	[CompilerGenerated]
	public bool get_OverridesEnterKey() { }

	protected bool HidePopup() { }

	public void Init(ReturnCallback confirmCallback, ReturnCallback cancelCallback, BackGround background, TransitionAnim transition, bool instantClose = false, bool closeIfTowersAreSuspended = false) { }

	public void InitAsyncReturnCallback(AsyncReturnCallback asyncReturnCallback, AsyncReturnCallback asyncCancelCallback, BackGround background, TransitionAnim transition, bool instantClose = false, bool closeIfTowersAreSuspended = false) { }

	public void InitAwaitAsyncTasks(Task awaitAsyncTasksConfirmCallback, Task awaitAsyncTasksCancelCallback, BackGround background, TransitionAnim transition, bool instantClose = false, bool closeIfTowersAreSuspended = false) { }

	public bool IsHidden() { }

	[AsyncStateMachine(typeof(<OKClicked>d__62))]
	public void OKClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnTowersSuspended() { }

	protected void PlayClickSound() { }

	private void PlayCloseSound() { }

	[CompilerGenerated]
	public void remove_popupEnd(Action<Popup> value) { }

	[CompilerGenerated]
	public void remove_popupHide(Action<Popup> value) { }

	[CompilerGenerated]
	private void set_active(bool value) { }

	[CompilerGenerated]
	protected void set_OverridesEnterKey(bool value) { }

	public void SetBody(string body) { }

	public void SetBody(GameObject obj) { }

	public void SetButtonsInteractible(bool interactible) { }

	public void SetCancelButton(string cancelText) { }

	public void SetCancelButtonInteractible(bool interactible) { }

	public void SetCanHide(bool canHide) { }

	public void SetCash(int cash) { }

	public void SetImage(SpriteReference spriteRef) { }

	public void SetImage(Sprite sprite) { }

	public void SetOKButton(string okText) { }

	public void SetOkButtonInteractible(bool interactible) { }

	public void SetPlacement(RectTransform transform) { }

	public void SetTitle(string title) { }

	public void ShowCross(bool show) { }

	public void ShowLoadingSpinner(bool show) { }

	public void ShowPopup() { }

	public void ShowTick(bool show) { }

	public bool TryHidePop() { }

}

