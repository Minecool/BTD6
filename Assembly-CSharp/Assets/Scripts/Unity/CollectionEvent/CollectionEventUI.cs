namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventUI : GameMenu
{
	[CompilerGenerated]
	private struct <OnCollectAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CollectionEventUI <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[HideInInspector]
	public static string from; //Field offset: 0x0
	public TMP_Text countdownText; //Field offset: 0x48
	public TMP_Text eventEndsInText; //Field offset: 0x50
	public TMP_Text eventEndedText; //Field offset: 0x58
	public GameObject eventEndsInGameObject; //Field offset: 0x60
	public GameObject[] monkeys; //Field offset: 0x68
	public CollectionEventMilestoneItem[] milestoneItems; //Field offset: 0x70
	public CollectionEventMysteryBox[] crates; //Field offset: 0x78
	public GameObject[] smallerCrateGodrays; //Field offset: 0x80
	public GameObject[] collectBarIconObjects; //Field offset: 0x88
	public GameObject[] titleGameObjects; //Field offset: 0x90
	public GameObject max; //Field offset: 0x98
	public Image collectProgressInnerBarImage; //Field offset: 0xA0
	public TMP_Text collectProgressText; //Field offset: 0xA8
	public TMP_Text collectGoalText; //Field offset: 0xB0
	public Image lastSeenInnerBarImage; //Field offset: 0xB8
	public Image currentInnerBarImage; //Field offset: 0xC0
	public Image completedInnerBarImage; //Field offset: 0xC8
	public Button playButton; //Field offset: 0xD0
	public TMP_Text speedBubbleText; //Field offset: 0xD8
	public Button collectButton; //Field offset: 0xE0
	public float barFillDelay; //Field offset: 0xE8
	public float barFillLerpSpeed; //Field offset: 0xEC
	public CollectionEventFeaturedInstas featuredInstas; //Field offset: 0xF0
	public GameObject debug; //Field offset: 0xF8
	private CollectionEventDataHelper helper; //Field offset: 0x100
	private float timeOpened; //Field offset: 0x108
	private bool isShowing; //Field offset: 0x10C

	public CollectionEventUI() { }

	private void LoadFromData() { }

	public void OnCollect() { }

	[AsyncStateMachine(typeof(<OnCollectAsync>d__38))]
	public Task OnCollectAsync() { }

	public void OnDebugAddLarge() { }

	public void OnDebugAddSmall() { }

	public void OnDebugClear() { }

	public void OnDeselectedFeaturedInsta() { }

	public void OnPlay() { }

	public void OnSelectedFeaturedInsta() { }

	public virtual void Open(object data) { }

	private void SetBarProgress(Image bar, float percent) { }

	private void SetRewardBarProgress(float percent) { }

	public void Update() { }

	private void UpdateCrates() { }

	private void UpdateDebug() { }

	private void UpdateMilestoneBar() { }

	private void UpdateRewardBarProgress() { }

	private void UpdateTheme() { }

}

