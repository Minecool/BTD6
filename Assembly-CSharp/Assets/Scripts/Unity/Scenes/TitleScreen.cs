namespace Assets.Scripts.Unity.Scenes;

public class TitleScreen : GenericAnimatedScene
{
	[CompilerGenerated]
	private sealed class <AuthenticateGameCenter>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <AuthenticateGameCenter>d__23(int <>1__state) { }

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
	private struct <OnIvePlayedBeforeButtonClicked>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TitleScreen <>4__this; //Field offset: 0x28
		private PlayerService <playerService>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPlayButtonClicked>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TitleScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <WaitForPlayButtonClick>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TitleScreen <>4__this; //Field offset: 0x20

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
		public <WaitForPlayButtonClick>d__29(int <>1__state) { }

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

	[SerializeField]
	private AudioClip titleMusic; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI buildInfo; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI playerId; //Field offset: 0x38
	public AudioClip buttonClickSound; //Field offset: 0x40
	public AudioClip buttonClick2Sound; //Field offset: 0x48
	[SerializeField]
	private GameObject loadingSpinner; //Field offset: 0x50
	[SerializeField]
	private Button startButton; //Field offset: 0x58
	[SerializeField]
	private Animator UiAnimator; //Field offset: 0x60
	[SerializeField]
	private Animator BgAnimator; //Field offset: 0x68
	[SerializeField]
	private GameObject PlayerInfo; //Field offset: 0x70
	[SerializeField]
	private TMP_Text PlayerName; //Field offset: 0x78
	[SerializeField]
	private GameObject IvePlayedBeforeButton; //Field offset: 0x80
	[SerializeField]
	private GameObject arcadePlus; //Field offset: 0x88
	[SerializeField]
	private GameObject iCloudStatus; //Field offset: 0x90
	[SerializeField]
	private TMP_Text iCloudStatusText; //Field offset: 0x98
	[SerializeField]
	private GameObject iCloudEnabled; //Field offset: 0xA0
	[SerializeField]
	private GameObject iCloudDisabled; //Field offset: 0xA8
	[SerializeField]
	private RuntimeAnimatorController visionOSAnimationSwap; //Field offset: 0xB0
	[SerializeField]
	private GameObject visionOS3DContent; //Field offset: 0xB8
	private bool playButtonClicked; //Field offset: 0xC0
	private bool isSignedInToLiNK; //Field offset: 0xC1

	private bool IsAuthenticated
	{
		private get { } //Length: 3
	}

	public TitleScreen() { }

	[CompilerGenerated]
	private void <OnIvePlayedBeforeButtonClicked>b__34_0(LiNKAccount newAccount) { }

	[CompilerGenerated]
	private bool <WaitForPlayButtonClick>b__29_0() { }

	[IteratorStateMachine(typeof(<AuthenticateGameCenter>d__23))]
	private IEnumerator AuthenticateGameCenter() { }

	private void Awake() { }

	private void FadeOutTitleMusic() { }

	private bool get_IsAuthenticated() { }

	public void OnICloudButtonClicked() { }

	[AsyncStateMachine(typeof(<OnIvePlayedBeforeButtonClicked>d__34))]
	public void OnIvePlayedBeforeButtonClicked() { }

	[AsyncStateMachine(typeof(<OnPlayButtonClicked>d__27))]
	public void OnPlayButtonClicked() { }

	private void PlayTitleMusic() { }

	private void SetICloudStatus() { }

	private void SetPlayerInfo(bool canLogin) { }

	public void SkipTitleAnimClicked() { }

	public void Start() { }

	public virtual IEnumerator StartCloseAnimation() { }

	private void TransitionToMainMenu() { }

	public void Update() { }

	[IteratorStateMachine(typeof(<WaitForPlayButtonClick>d__29))]
	public IEnumerator WaitForPlayButtonClick() { }

}

