namespace Assets.Scripts.Unity.UI_New.Utils;

public class ButtonWithSyncingState : Button
{
	[CompilerGenerated]
	private struct <AnimateObject>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ButtonWithSyncingState <>4__this; //Field offset: 0x28
		public GameObject objectToAdminate; //Field offset: 0x30
		public int seconds; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button nonInteractableButton; //Field offset: 0x108
	public GameObject loadingImg; //Field offset: 0x110
	public GameObject tickImg; //Field offset: 0x118
	public GameObject crossImg; //Field offset: 0x120
	public GameObject popupPanel; //Field offset: 0x128
	public NK_TextMeshProUGUI popupPanelTxt; //Field offset: 0x130
	private Task animateTask; //Field offset: 0x138

	public ButtonWithSyncingState() { }

	[AsyncStateMachine(typeof(<AnimateObject>d__14))]
	private void AnimateObject(GameObject objectToAdminate, int seconds = 1) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void OnSyncStateBegin() { }

	public void OnSyncStateCompleted(bool successful, string successfulLoc, string unsuccessfulLoc) { }

	public void SetInteractableState(bool interactable) { }

	public void SetText(string locsKey) { }

	public void ShowPopup() { }

}

