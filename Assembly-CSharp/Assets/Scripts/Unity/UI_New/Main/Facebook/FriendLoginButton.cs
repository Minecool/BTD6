namespace Assets.Scripts.Unity.UI_New.Main.Facebook;

[RequireComponent(typeof(Button))]
public class FriendLoginButton : MonoBehaviour
{
	[CompilerGenerated]
	private struct <OnButtonClicked>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public FriendLoginButton <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowFriendsScreenAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FriendLoginButton <>4__this; //Field offset: 0x20
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Button friendsButton; //Field offset: 0x20
	public GameObject newFriendPip; //Field offset: 0x28

	public FriendLoginButton() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<OnButtonClicked>d__5))]
	private void OnButtonClicked() { }

	private void OnDestroy() { }

	private void ShowFriendsScreen() { }

	[AsyncStateMachine(typeof(<ShowFriendsScreenAsync>d__7))]
	private Task ShowFriendsScreenAsync() { }

	private void UpdatePipStatus() { }

}

