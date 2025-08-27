namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class MainAccountPopup : BaseEpicAccountPopup
{
	[CompilerGenerated]
	private sealed class <EpicLogin>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MainAccountPopup <>4__this; //Field offset: 0x20
		private UnityWebRequest <www>5__2; //Field offset: 0x28

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
		public <EpicLogin>d__5(int <>1__state) { }

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
	private struct <LoginWithLiNKCode>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainAccountPopup <>4__this; //Field offset: 0x20
		private PlayerService <playerService>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button loginEpicBtn; //Field offset: 0x48
	public Button linkBtn; //Field offset: 0x50
	public TMP_InputField codeInput; //Field offset: 0x58

	public MainAccountPopup() { }

	[CompilerGenerated]
	private void <Awake>b__3_0() { }

	[CompilerGenerated]
	private void <Awake>b__3_1() { }

	[CompilerGenerated]
	private void <Awake>b__3_2(string x) { }

	protected virtual void Awake() { }

	[IteratorStateMachine(typeof(<EpicLogin>d__5))]
	private IEnumerator EpicLogin() { }

	[AsyncStateMachine(typeof(<LoginWithLiNKCode>d__7))]
	private Task LoginWithLiNKCode() { }

	protected virtual void SetProcessing(bool processing) { }

	private void ValidateLinkBtn() { }

}

