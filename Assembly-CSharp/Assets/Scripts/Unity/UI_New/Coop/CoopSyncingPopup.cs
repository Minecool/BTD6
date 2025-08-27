namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopSyncingPopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Init>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public byte culpritPlayerNumber; //Field offset: 0x28
		public CoopSyncingPopup <>4__this; //Field offset: 0x30
		public string playerName; //Field offset: 0x38
		public string bg; //Field offset: 0x40
		public IEnumerable<Task`1<Int32>> countdown; //Field offset: 0x48
		private IEnumerator<Task`1<Int32>> <>7__wrap1; //Field offset: 0x50
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject syncingPopupBackgroundLightBlue; //Field offset: 0x20
	public GameObject syncingPopupBackgroundDarkBlue; //Field offset: 0x28
	public GameObject syncingPopupBackgroundGreen; //Field offset: 0x30
	public Image syncingPopupPlayerIcon; //Field offset: 0x38
	public SpriteReference[] playerIcons; //Field offset: 0x40
	public NK_TextMeshProUGUI playerNameTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI syncingPopupTimerTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI syncingPopupMessageTxt; //Field offset: 0x58

	public CoopSyncingPopup() { }

	public void InGameQuit() { }

	[AsyncStateMachine(typeof(<Init>d__9))]
	public void Init(string bg, IEnumerable<Task`1<Int32>> countdown, byte culpritPlayerNumber = 0, string playerName = null) { }

}

