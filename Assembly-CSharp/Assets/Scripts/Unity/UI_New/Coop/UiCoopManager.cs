namespace Assets.Scripts.Unity.UI_New.Coop;

public class UiCoopManager : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UiCoopManager <>4__this; //Field offset: 0x20

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
		public <Initialise>d__25(int <>1__state) { }

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
	private sealed class <PlaceTowerHere>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UiCoopManager <>4__this; //Field offset: 0x20

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
		public <PlaceTowerHere>d__37(int <>1__state) { }

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

	public static UiCoopManager instance; //Field offset: 0x0
	public EmotesManager emotesManager; //Field offset: 0x20
	public CoopPlayerSliderPanel coopPlayerSliderPanel; //Field offset: 0x28
	public CoopAreaIndicators coopAreaIndicators; //Field offset: 0x30
	public Animator animator; //Field offset: 0x38
	public Animator buttonAnimator; //Field offset: 0x40
	public GameObject messageBoardContainer; //Field offset: 0x48
	public Image messageBoardPlayerIcon; //Field offset: 0x50
	public NK_TextMeshProUGUI messageBoardTxt; //Field offset: 0x58
	public GameObject prefabCoopCashRecievedDisplay; //Field offset: 0x60
	public GameObject prefabCoopIndicator; //Field offset: 0x68
	public GameObject CoopButton; //Field offset: 0x70
	public Button openMenuButton; //Field offset: 0x78
	public AudioClip disconnectedSound; //Field offset: 0x80
	public Sprite playerIconFFA; //Field offset: 0x88
	public Sprite[] playerIcons; //Field offset: 0x90
	public bool simulationInitailised; //Field offset: 0x98
	[CompilerGenerated]
	private Action RunOnCoopInitialised; //Field offset: 0xA0
	private Btd6CoopGame coopGame; //Field offset: 0xA8
	private Coroutine placeTowersHereRoutine; //Field offset: 0xB0

	public event Action RunOnCoopInitialised
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 431
	}

	public bool IsCoop
	{
		 get { } //Length: 12
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public UiCoopManager() { }

	[CompilerGenerated]
	public void add_RunOnCoopInitialised(Action value) { }

	public void CashManagersInitialised() { }

	private void CoopOkayCallback() { }

	public void CusorDown() { }

	public virtual void Destroy() { }

	public bool get_IsCoop() { }

	private LocalizationManager get_Locs() { }

	public Sprite GetSpriteForPlayerNumber(int playerNum) { }

	public void HidePlaceTowersHereContiner() { }

	[IteratorStateMachine(typeof(<Initialise>d__25))]
	public virtual IEnumerator Initialise() { }

	public void OnCoopButtonClicked() { }

	private void OnDestroy() { }

	private void OnEnterTowerPlacementMode() { }

	private void OnExitTowerPlacementMode() { }

	public virtual void OnUpdate() { }

	[IteratorStateMachine(typeof(<PlaceTowerHere>d__37))]
	private IEnumerator PlaceTowerHere() { }

	public void PlayerLeftGame(int playerIndex) { }

	public void PlayerRejoinedGame(int playerIndex) { }

	public void PlayerRemovedFromGame(int playerIndex) { }

	public virtual void PostInitialised() { }

	public void Quit() { }

	public void RecievedDisplayMessage(int playerIndex, string message) { }

	[CompilerGenerated]
	public void remove_RunOnCoopInitialised(Action value) { }

	public void SetCoopGame(Btd6CoopGame coopGame) { }

	public void ShowYourAreaOnLoadPopup() { }

}

