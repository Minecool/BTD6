namespace Assets.Scripts.Unity.UI_New.Utils;

public class ToggleWithSyncingState : Toggle
{
	[CompilerGenerated]
	private struct <AnimateObject>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject objectToAdminate; //Field offset: 0x28
		public int seconds; //Field offset: 0x30
		public ToggleWithSyncingState <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject loadingImg; //Field offset: 0x128
	public GameObject tickImg; //Field offset: 0x130
	public GameObject crossImg; //Field offset: 0x138
	public NK_TextMeshProUGUI popupPanelTxt; //Field offset: 0x140

	public ToggleWithSyncingState() { }

	[AsyncStateMachine(typeof(<AnimateObject>d__7))]
	private void AnimateObject(GameObject objectToAdminate, int seconds = 1) { }

	public void OnSyncStateBegin() { }

	public void OnSyncStateCompleted(bool successful) { }

	public void SetPopupText(string localisedPopupText) { }

}

