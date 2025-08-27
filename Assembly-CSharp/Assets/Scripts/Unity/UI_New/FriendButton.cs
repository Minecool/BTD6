namespace Assets.Scripts.Unity.UI_New;

public class FriendButton : Button
{
	[CompilerGenerated]
	private struct <ShowIconAnimation>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject icon; //Field offset: 0x28
		public FriendButton <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject friendImageObj; //Field offset: 0x108
	public GameObject tickImageObj; //Field offset: 0x110
	public GameObject crossImageObj; //Field offset: 0x118
	public GameObject loadingImageObj; //Field offset: 0x120

	public FriendButton() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<ShowIconAnimation>d__6))]
	private void ShowIconAnimation(GameObject icon) { }

	public void UpdateIcon(bool interactable, bool showFriendIcon = false, bool showLoading = false, bool showTick = false, bool showCross = false) { }

}

