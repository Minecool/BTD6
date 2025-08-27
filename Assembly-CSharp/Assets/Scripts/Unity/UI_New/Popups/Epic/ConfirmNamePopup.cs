namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class ConfirmNamePopup : BaseEpicAccountPopup
{
	[CompilerGenerated]
	private sealed class <TextWobble>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ConfirmNamePopup <>4__this; //Field offset: 0x20
		private TMP_Text <textComponent>5__2; //Field offset: 0x28
		private Transform <textTransform>5__3; //Field offset: 0x30
		private Vector3 <initialPos>5__4; //Field offset: 0x38
		private Color <initialCol>5__5; //Field offset: 0x44
		private float <startAt>5__6; //Field offset: 0x54
		private float <endAt>5__7; //Field offset: 0x58

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
		public <TextWobble>d__14(int <>1__state) { }

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
	private struct <UpdateDisplayName>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConfirmNamePopup <>4__this; //Field offset: 0x20
		public string intendedDisplayName; //Field offset: 0x28
		private LocalizationManager <locs>5__2; //Field offset: 0x30
		private object <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float wobbleDuration = 0.5; //Field offset: 0x0
	private const float wobbleDistance = 10; //Field offset: 0x0
	private const float wobbleCount = 4; //Field offset: 0x0
	[SerializeField]
	private TMP_InputField nameInput; //Field offset: 0x48
	[SerializeField]
	private GameObject tick; //Field offset: 0x50
	[SerializeField]
	private Button confirmBtn; //Field offset: 0x58
	[SerializeField]
	private Button cancelBtn; //Field offset: 0x60
	private string currentName; //Field offset: 0x68

	public ConfirmNamePopup() { }

	protected virtual void Awake() { }

	private void OnCancel() { }

	private void OnConfirm() { }

	private void OnEnable() { }

	private void QuickValidate(string text) { }

	protected virtual void SetProcessing(bool processing) { }

	[IteratorStateMachine(typeof(<TextWobble>d__14))]
	private IEnumerator TextWobble() { }

	[AsyncStateMachine(typeof(<UpdateDisplayName>d__15))]
	private Task UpdateDisplayName(string intendedDisplayName) { }

}

