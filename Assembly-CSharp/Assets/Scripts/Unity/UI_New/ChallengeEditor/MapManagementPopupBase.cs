namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class MapManagementPopupBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Toggle toggle; //Field offset: 0x10
		public MapManagementPopupBase <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Awake>b__0(bool isOn) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmClickedAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MapManagementPopupBase <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	protected Button confirmButton; //Field offset: 0x20
	[SerializeField]
	private Selectable[] closeButtons; //Field offset: 0x28
	[SerializeField]
	protected List<Toggle> toggles; //Field offset: 0x30
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x38
	private RejectionReason rejectionReasonFlags; //Field offset: 0x40
	private Func<RejectionReason, Task> onPopupConfirmed; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsRunningConfirmation>k__BackingField; //Field offset: 0x50

	public private bool IsRunningConfirmation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public MapManagementPopupBase() { }

	protected override void Awake() { }

	[CompilerGenerated]
	public bool get_IsRunningConfirmation() { }

	public RejectionReason GetRejectionReason(Toggle toggle) { }

	private void OnCloseButtonClicked() { }

	[AsyncStateMachine(typeof(<OnConfirmClickedAsync>d__15))]
	protected override void OnConfirmClickedAsync() { }

	protected override void OnEnable() { }

	[CompilerGenerated]
	private void set_IsRunningConfirmation(bool value) { }

	public void SetConfirmationCallback(Func<RejectionReason, Task> onPopupConfirmed) { }

	protected override void SetReason(bool isOn, RejectionReason rejectionReason) { }

}

