namespace Assets.Scripts.Unity.UI_New.InGame.EmotesMenu;

public class EmotesManager : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Emote, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<Emote, Boolean> <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Initialise>b__10_0(Emote x) { }

		internal bool <Initialise>b__10_1(Emote x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string name; //Field offset: 0x10
		public EmotesManager <>4__this; //Field offset: 0x18
		public UnityAction <>9__3; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <Initialise>b__2(AsyncOperationHandle<GameObject> h) { }

		internal void <Initialise>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string heroId; //Field offset: 0x10
		public string skinId; //Field offset: 0x18
		public EmotesManager <>4__this; //Field offset: 0x20
		public string emoteKey; //Field offset: 0x28
		public UnityAction <>9__1; //Field offset: 0x30

		public <>c__DisplayClass13_0() { }

		internal void <PlayerJoin>b__0(AsyncOperationHandle<GameObject> h) { }

		internal void <PlayerJoin>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EmotesManager <>4__this; //Field offset: 0x20

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
		public <Initialise>d__10(int <>1__state) { }

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

	public static EmotesManager instance; //Field offset: 0x0
	public GameObject emotesPanel; //Field offset: 0x20
	public EmotePlayerUi[] playersEmoteUi; //Field offset: 0x28
	public GameObject[] freeforallEmotePositions; //Field offset: 0x30
	public GridLayoutGroup emotesGridLayout; //Field offset: 0x38
	[CompilerGenerated]
	private Btd6CoopGame <coopGame>k__BackingField; //Field offset: 0x40
	private Dictionary<String, AsyncOperationHandle`1<GameObject>> emoteGODict; //Field offset: 0x48

	public private Btd6CoopGame coopGame
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public EmotesManager() { }

	public void CloseEmotes() { }

	public virtual void Destroy() { }

	public void EmoteClicked(string emoteID) { }

	public void EnableEmotesQueue(int playerNumber) { }

	public void ForceClearEmotesQueue(int playerNumber) { }

	[CompilerGenerated]
	private Btd6CoopGame get_coopGame() { }

	private List<String> GetAllPurchasedEmotes(bool enabledOnly) { }

	[IteratorStateMachine(typeof(<Initialise>d__10))]
	public virtual IEnumerator Initialise() { }

	public void OnCloseEmotesClicked(PointerEventData eventData) { }

	private void OnDestroy() { }

	public void OnOpenEmotesClicked() { }

	public void PlayerJoin(CoopPlayerInfo coopPlayerInfo) { }

	public void RecieveMessage(int playerId, string emoteId) { }

	[CompilerGenerated]
	public void set_coopGame(Btd6CoopGame value) { }

	public void SetupEmotePositions(Btd6CoopGame coopGame) { }

}

