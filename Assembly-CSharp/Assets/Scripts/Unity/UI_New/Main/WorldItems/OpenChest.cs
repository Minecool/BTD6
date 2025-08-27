namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class OpenChest : InteractableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OpenDailyRewardUIAsync>b__13_0(BaseLoot l) { }

	}

	[CompilerGenerated]
	private struct <OpenDailyRewardUIAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OpenChest <>4__this; //Field offset: 0x20
		private LootSet <loot>5__2; //Field offset: 0x28
		private Btd6Player <player>5__3; //Field offset: 0x30
		private NetworkException <networkException>5__4; //Field offset: 0x38
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private bool isChestReady; //Field offset: 0x20
	public AudioClip openChestSound; //Field offset: 0x28
	public AudioClip clickSound; //Field offset: 0x30
	private Animator animator; //Field offset: 0x38
	public PlayInteractableAudio interactableAudio; //Field offset: 0x40

	public OpenChest() { }

	private void Awake() { }

	public void ChestOpened() { }

	private LootSet GetTodaysDailyReward() { }

	private bool IsChestReady() { }

	private void OnEnable() { }

	public virtual void OnInteract() { }

	private void OpenDailyRewardUI() { }

	[AsyncStateMachine(typeof(<OpenDailyRewardUIAsync>d__13))]
	private Task OpenDailyRewardUIAsync() { }

	private void ShowChest(bool isChestReady) { }

	private void Start() { }

	private void Update() { }

}

