namespace Assets.Scripts.Unity.Menu;

public abstract class GameMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public TaskCompletionSource<Boolean> animCompletedTaskSource; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal void <PlayAnimAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <CheckForAnimEnd>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		public GameMenu <>4__this; //Field offset: 0x28

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
		public <CheckForAnimEnd>d__25(int <>1__state) { }

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

	private const string transitionName = "AnimationIndex"; //Field offset: 0x0
	protected const int openState = 0; //Field offset: 0x0
	protected const int closeState = 1; //Field offset: 0x0
	protected const int reopenState = 2; //Field offset: 0x0
	protected const int recloseState = 3; //Field offset: 0x0
	protected int overrideTransitionAnimatorState; //Field offset: 0x20
	public bool hasReOpenAnimation; //Field offset: 0x24
	public bool hasReCloseAnimation; //Field offset: 0x25
	public bool canInteractWithOtherMenuOpen; //Field offset: 0x26
	public bool isAnimatingWithCallback; //Field offset: 0x27
	public bool isStillLoading; //Field offset: 0x28
	protected Animator anim; //Field offset: 0x30
	protected int transitionId; //Field offset: 0x38
	private CommonPanel commonPanel; //Field offset: 0x40

	protected static LocalizationManager Locs
	{
		 get { } //Length: 48
	}

	protected static Btd6Player Player
	{
		 get { } //Length: 7
	}

	protected GameMenu() { }

	protected override void Awake() { }

	[IteratorStateMachine(typeof(<CheckForAnimEnd>d__25))]
	private IEnumerator CheckForAnimEnd(Action callback) { }

	public override void Close() { }

	protected static LocalizationManager get_Locs() { }

	protected static Btd6Player get_Player() { }

	public override void Open(object data) { }

	public override bool OverrideClose() { }

	private void PlayAnim(int state, Action callback) { }

	public Task PlayAnimAsync(int state) { }

	public void PlayCloseAnimation(Action callback) { }

	public void PlayOpenAnimation(Action callback) { }

	public void PlayReCloseAnimation(Action callback) { }

	public void PlayReOpenAnimation(Action callback) { }

	public override void ReClose() { }

	public override void ReOpen(object data) { }

	public void SetCommon() { }

	public AsyncOperationHandle<GameObject> ShowAsyncReturnCallbackPopup(string titleLocKey, string bodyLocKey, bool showBackground, AsyncReturnCallback onOkAsyncReturnCallback = null, AsyncReturnCallback onCancelAsyncReturnCallback = null) { }

	public AsyncOperationHandle<GameObject> ShowAwaitAsyncTasksPopup(string titleLocKey, string bodyLocKey, bool showBackground, Task onOkCallback = null, Task onCancelCallback = null) { }

	public AsyncOperationHandle<GameObject> ShowOkPopup(string bodyLocKey, ReturnCallback onOkCancelCallback = null) { }

	public AsyncOperationHandle<GameObject> ShowPopup(string titleLocKey, string bodyLocKey, bool showBackground, ReturnCallback onOkCallback = null, ReturnCallback onCancelCallback = null) { }

}

