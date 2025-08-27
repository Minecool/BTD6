namespace Assets.Scripts.Unity.UI_New.Main.Home;

public class CoopButtonChecker : MonoBehaviour
{
	[CompilerGenerated]
	private struct <OnClickAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopButtonChecker <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayUnlockEffect>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopButtonChecker <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button coopBtn; //Field offset: 0x20
	public GameObject coopButtonObject; //Field offset: 0x28
	public GameObject coopButtonLockObject; //Field offset: 0x30
	public GameObject coopUnlockEffect; //Field offset: 0x38
	public NK_TextMeshProUGUI unlockText; //Field offset: 0x40
	private bool isDestroyed; //Field offset: 0x48

	public CoopButtonChecker() { }

	public void Awake() { }

	public void OnClick() { }

	[AsyncStateMachine(typeof(<OnClickAsync>d__10))]
	public Task OnClickAsync() { }

	public void OnDestroy() { }

	[AsyncStateMachine(typeof(<PlayUnlockEffect>d__8))]
	public void PlayUnlockEffect() { }

}

