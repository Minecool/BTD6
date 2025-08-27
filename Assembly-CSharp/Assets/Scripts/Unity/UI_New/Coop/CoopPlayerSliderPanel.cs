namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopPlayerSliderPanel : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public bool connected; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal void <SetPeerConnectedStatus>b__0(CoopInGamePlayerPanel panel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal void <OnPeerDisconnected>b__0(CoopInGamePlayerPanel panel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass37_0() { }

		internal void <OnPeerRejoined>b__0(CoopInGamePlayerPanel panel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal void <OnPeerRemoved>b__0(CoopInGamePlayerPanel panel) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoopPlayerSliderPanel <>4__this; //Field offset: 0x20

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
		public <Initialise>d__30(int <>1__state) { }

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
	private sealed class <MoneyReminderPlayAnimation>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CoopPlayerSliderPanel <>4__this; //Field offset: 0x20

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
		public <MoneyReminderPlayAnimation>d__57(int <>1__state) { }

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
	private sealed class <MoneyReminderTimer>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int time; //Field offset: 0x20
		public CoopPlayerSliderPanel <>4__this; //Field offset: 0x28

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
		public <MoneyReminderTimer>d__56(int <>1__state) { }

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
	private struct <ShowNetworkWarningForSelfAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopPlayerSliderPanel <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static CoopPlayerSliderPanel instance; //Field offset: 0x0
	public static string animatorLabel; //Field offset: 0x8
	public static int animateIn; //Field offset: 0x10
	public static int animateOut; //Field offset: 0x14
	public GameObject container; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	public Button requestButton; //Field offset: 0x30
	public Button closeMenuButton; //Field offset: 0x38
	public Image notificationIcon; //Field offset: 0x40
	public Image notificationGlow; //Field offset: 0x48
	public CoopInGamePlayerPanel[] coopPlayerPanels; //Field offset: 0x50
	public GameObject playerSliderPanel; //Field offset: 0x58
	public GameObject emotesPanel; //Field offset: 0x60
	public GameObject connectivityLowIconSelf; //Field offset: 0x68
	public GameObject connectivityLowIconOtherPlayers; //Field offset: 0x70
	public GameObject moneyReminderIcon; //Field offset: 0x78
	public Button cashTransferButton; //Field offset: 0x80
	public GameObject cashTransferPanelActive; //Field offset: 0x88
	public GameObject cashTransferPanelInactive; //Field offset: 0x90
	public Button emotesButton; //Field offset: 0x98
	public GameObject emotesPanelActive; //Field offset: 0xA0
	public GameObject emotesPanelInactive; //Field offset: 0xA8
	public AudioClip cashReceivedSound; //Field offset: 0xB0
	public AudioClip alertSound; //Field offset: 0xB8
	[CompilerGenerated]
	private Btd6CoopGame <coopGame>k__BackingField; //Field offset: 0xC0
	public bool isVisible; //Field offset: 0xC8
	private bool showingCashTransferPanel; //Field offset: 0xC9
	private Coroutine moneyTimerCoroutine; //Field offset: 0xD0
	private bool moneyTimerActive; //Field offset: 0xD8
	private DateTime connectivityIconHideTime; //Field offset: 0xE0

	public private Btd6CoopGame coopGame
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static CoopPlayerSliderPanel() { }

	public CoopPlayerSliderPanel() { }

	private void AnimateIn() { }

	private void AnimateOut() { }

	private void Awake() { }

	public void CloseMenu() { }

	public virtual void Destroy() { }

	private void FindPlayerPanel(byte playerNumber, Action<CoopInGamePlayerPanel> action) { }

	[CompilerGenerated]
	private Btd6CoopGame get_coopGame() { }

	[IteratorStateMachine(typeof(<Initialise>d__30))]
	public virtual IEnumerator Initialise() { }

	public void LostFocusTap() { }

	private void MoneyReminderDisable() { }

	[IteratorStateMachine(typeof(<MoneyReminderPlayAnimation>d__57))]
	private IEnumerator MoneyReminderPlayAnimation() { }

	[IteratorStateMachine(typeof(<MoneyReminderTimer>d__56))]
	private IEnumerator MoneyReminderTimer(int time) { }

	public void OnCashTransferButtonClicked() { }

	public void OnCloseButtonClicked() { }

	public void OnCoopButtonClicked() { }

	private void OnDestroy() { }

	public void OnEmotesButtonClicked() { }

	public void OnPeerDisconnected(byte playerNumber) { }

	public void OnPeerRejoined(byte playerNumber) { }

	public void OnPeerRemoved(byte playerNumber) { }

	public void OnRequestActionClicked() { }

	public void OnRequestButtonClicked() { }

	public void OpenMenu() { }

	public virtual void PostInitialised() { }

	public void RecievedCash(int playerIndex, double cashAmount) { }

	public void RecievedNotification(int from) { }

	[CompilerGenerated]
	public void set_coopGame(Btd6CoopGame value) { }

	public void SetAuthority(byte playerNumber) { }

	public void SetPeerConnectedStatus(byte playerNumber, bool connected) { }

	[AsyncStateMachine(typeof(<ShowNetworkWarningForSelfAsync>d__59))]
	public void ShowNetworkWarningForSelfAsync() { }

	private void SwitchPanels(bool showCashTransferPanel) { }

}

