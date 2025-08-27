namespace Assets.Scripts.Unity.UI_New.InGame.EmotesMenu.Emotes;

public class EmotePlayerUi : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public bool isHero; //Field offset: 0x10
		public string emoteId; //Field offset: 0x18
		public Emote emoteData; //Field offset: 0x20
		public EmotePlayerUi <>4__this; //Field offset: 0x28

		public <>c__DisplayClass8_0() { }

		internal void <ShowEmote>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <ShowEmote>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string emoteId; //Field offset: 0x28
		public EmotePlayerUi <>4__this; //Field offset: 0x30
		public int playerId; //Field offset: 0x38
		private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitTimer>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public float time; //Field offset: 0x28
		public EmotePlayerUi <>4__this; //Field offset: 0x30
		public AsyncOperationHandle<GameObject> handle; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject emotePosition; //Field offset: 0x20
	public GameObject emotePlayerIcon; //Field offset: 0x28
	private Transform worldEmoteLayer; //Field offset: 0x30
	private Vector3 worldPos; //Field offset: 0x38
	private bool showingEmote; //Field offset: 0x44
	private bool forceClearEmotesQueue; //Field offset: 0x45

	public EmotePlayerUi() { }

	public void Disable() { }

	public void EnableEmotesQueue() { }

	public void ForceClearMotesQueue() { }

	public void Initialise(Vector2 position, Transform worldEmoteLayer, Vector3 worldPos) { }

	[AsyncStateMachine(typeof(<ShowEmote>d__8))]
	public void ShowEmote(string emoteId, int playerId) { }

	[AsyncStateMachine(typeof(<WaitTimer>d__9))]
	private void WaitTimer(float time, AsyncOperationHandle<GameObject> handle) { }

}

