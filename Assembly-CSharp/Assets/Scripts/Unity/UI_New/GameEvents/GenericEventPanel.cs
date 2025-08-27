namespace Assets.Scripts.Unity.UI_New.GameEvents;

public class GenericEventPanel : GameEventPanel
{
	[CompilerGenerated]
	private struct <BindAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GenericEventPanel <>4__this; //Field offset: 0x28
		public DateTime endTime; //Field offset: 0x30
		public UnityAction onView; //Field offset: 0x38
		public GameEventsScreen parent; //Field offset: 0x40
		public int panelPriority; //Field offset: 0x48
		public UnityAction onClick; //Field offset: 0x50
		public string banner; //Field offset: 0x58
		public Action onBannerLoaded; //Field offset: 0x60
		public bool showTimer; //Field offset: 0x68
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryLoadBanner>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string banner; //Field offset: 0x20
		public GameEventsScreen parent; //Field offset: 0x28
		public GenericEventPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image backgroundImage; //Field offset: 0x60
	public Image iconImage; //Field offset: 0x68
	public TMP_Text nextDate; //Field offset: 0x70
	public GameObject nextDateContainer; //Field offset: 0x78
	public Button button; //Field offset: 0x80
	public GameObject eventEndedObj; //Field offset: 0x88
	public DateTime endTime; //Field offset: 0x90
	public DateTime startTime; //Field offset: 0x98
	private UnityAction onView; //Field offset: 0xA0

	public GenericEventPanel() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<BindAsync>d__11))]
	public void BindAsync(GameEventsScreen parent, DateTime endTime, bool showTimer, string banner, int panelPriority, UnityAction onClick, UnityAction onView, Action onBannerLoaded) { }

	public void BindAsync(GameEventsScreen parent, string banner, int bannerPriority, UnityAction onClick, UnityAction onView, Action onLoadCompleted) { }

	public void LoadCollectionEventVisuals() { }

	private void OnDestroy() { }

	public void PanelViewed() { }

	public virtual void SetUnavailable(Nullable<DateTime> startTime, bool canShowNextEventTimer, string message) { }

	[AsyncStateMachine(typeof(<TryLoadBanner>d__14))]
	private Task<Boolean> TryLoadBanner(string banner, GameEventsScreen parent) { }

	public void Update() { }

}

