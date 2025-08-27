namespace Assets.Scripts.Unity.UI_New;

public class SlideshowInfoPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <AutoScroll>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SlideshowInfoPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnPanelViewedEvent : MulticastDelegate
	{

		public OnPanelViewedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject panel, string from, int orderInList, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject panel, string from, int orderInList) { }

	}

	public GameObject[] infoSlides; //Field offset: 0x20
	public Button nextButton; //Field offset: 0x28
	public Button previousButton; //Field offset: 0x30
	public PipPagingPanel pipPagingPanelPrefab; //Field offset: 0x38
	public readonly List<PipPagingPanel> pipPagingPanels; //Field offset: 0x40
	private int slideIndex; //Field offset: 0x48
	private CancellationTokenSource delayCancelToken; //Field offset: 0x50
	public bool looping; //Field offset: 0x58
	public bool autoScoll; //Field offset: 0x59
	public float autoScollDelay; //Field offset: 0x5C
	public bool disableGestureSwiping; //Field offset: 0x60
	public GestureSettings gestureSetting; //Field offset: 0x68
	private OnPanelViewedEvent panelViewedEvent; //Field offset: 0x70
	private IEnumerator swipeCoroutine; //Field offset: 0x78

	public SlideshowInfoPanel() { }

	[CompilerGenerated]
	private void <Awake>b__15_0() { }

	[CompilerGenerated]
	private void <Open>b__16_0() { }

	[CompilerGenerated]
	private void <Open>b__16_1() { }

	[AsyncStateMachine(typeof(<AutoScroll>d__22))]
	public Task AutoScroll() { }

	private void Awake() { }

	public void Close() { }

	private void NextPage(string from = "") { }

	private void OnDestroy() { }

	public void Open(OnPanelViewedEvent viewedEvent = null) { }

	private void PrevPage() { }

	public void SetPanels(GameObject[] panels) { }

	public void ShowSlide(int index, string from) { }

	private void UpdatePips() { }

}

