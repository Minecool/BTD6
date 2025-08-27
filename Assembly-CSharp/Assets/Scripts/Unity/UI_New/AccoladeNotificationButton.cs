namespace Assets.Scripts.Unity.UI_New;

public class AccoladeNotificationButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AccoladeTransaction, Int64> <>9__9_0; //Field offset: 0x8
		public static Func<AccoladeTransaction, Int32> <>9__9_1; //Field offset: 0x10
		public static Func<AccoladeTransaction, Boolean> <>9__9_2; //Field offset: 0x18
		public static Func<AccoladeTransaction, Int32> <>9__9_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal long <RefreshAccoladePips>b__9_0(AccoladeTransaction x) { }

		internal int <RefreshAccoladePips>b__9_1(AccoladeTransaction x) { }

		internal bool <RefreshAccoladePips>b__9_2(AccoladeTransaction x) { }

		internal int <RefreshAccoladePips>b__9_3(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <RefreshAccoladePips>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeNotificationButton <>4__this; //Field offset: 0x20
		private AccoladeTransaction[] <accoladeTransactions>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>u__2; //Field offset: 0x38
		private TaskAwaiter<AccoladeTransaction[]> <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private AccoladeDisplay accoladeDisplay; //Field offset: 0x20
	[SerializeField]
	private GameObject newAccoladesObj; //Field offset: 0x28
	[SerializeField]
	private GameObject pipObj; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI newAccoladesCountTxt; //Field offset: 0x38
	[SerializeField]
	private PipEventChecker pipEventChecker; //Field offset: 0x40
	public Button notifPanelBtn; //Field offset: 0x48
	public Button nexusBtn; //Field offset: 0x50

	public AccoladeNotificationButton() { }

	private void AccoladesSeen() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<RefreshAccoladePips>d__9))]
	public Task RefreshAccoladePips() { }

}

