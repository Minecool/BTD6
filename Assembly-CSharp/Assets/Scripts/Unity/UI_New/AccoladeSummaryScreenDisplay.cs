namespace Assets.Scripts.Unity.UI_New;

public class AccoladeSummaryScreenDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AccoladeTransaction, Int32> <>9__11_1; //Field offset: 0x8
		public static Func<AccoladeTransaction, DateTime> <>9__11_2; //Field offset: 0x10
		public static Func<AccoladeTransaction, TopContributor> <>9__11_4; //Field offset: 0x18
		public static Func<TopContributor, Int32> <>9__11_5; //Field offset: 0x20
		public static Func<TopContributor, Boolean> <>9__11_6; //Field offset: 0x28
		public static Func<GameObject, Vector3> <>9__13_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal Vector3 <InstantiateIcons>b__13_0(GameObject x) { }

		internal int <ShowAccolades>b__11_1(AccoladeTransaction x) { }

		internal DateTime <ShowAccolades>b__11_2(AccoladeTransaction x) { }

		internal TopContributor <ShowAccolades>b__11_4(AccoladeTransaction x) { }

		internal int <ShowAccolades>b__11_5(TopContributor x) { }

		internal bool <ShowAccolades>b__11_6(TopContributor x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public PlayerContentInfo playerContentInfo; //Field offset: 0x10
		public AccoladeTransaction playersMostRecentAccoladePurchase; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal bool <ShowAccolades>b__0(AccoladeTransaction x) { }

		internal bool <ShowAccolades>b__3(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <InstantiateIcons>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeSummaryScreenDisplay <>4__this; //Field offset: 0x20
		public bool isMainLoop; //Field offset: 0x28
		public List<TopContributor> topContributors; //Field offset: 0x30
		private Vector3[] <iconScales>5__2; //Field offset: 0x38
		private int <iconDisplayCount>5__3; //Field offset: 0x40
		private int <purchaseAnimRepetitionCount>5__4; //Field offset: 0x44
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private int <index>5__5; //Field offset: 0x4C
		private AccoladeType <accoladeType>5__6; //Field offset: 0x50
		private GameObject <positionSource>5__7; //Field offset: 0x58
		private Vector3 <scale>5__8; //Field offset: 0x60
		private Task<String> <playerNameTask>5__9; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Int32[] animationMsDelays; //Field offset: 0x20
	[SerializeField]
	private int purchaseAnimRepetitions; //Field offset: 0x28
	[SerializeField]
	private int fullLoopMsDelay; //Field offset: 0x2C
	[SerializeField]
	private GameObject[] accoladeFloatPositions; //Field offset: 0x30
	[SerializeField]
	private AccoladeSummaryScreenIcon contributorAccoladeIconTemplate; //Field offset: 0x38
	private PlayerContentInfo playerContentInfo; //Field offset: 0x40
	private bool hasToPauseMainLoop; //Field offset: 0x48
	private bool isMainLoopRunning; //Field offset: 0x49

	private static byte MaxTopContributors
	{
		private get { } //Length: 222
	}

	public AccoladeSummaryScreenDisplay() { }

	private void Awake() { }

	private static byte get_MaxTopContributors() { }

	[AsyncStateMachine(typeof(<InstantiateIcons>d__13))]
	private Task InstantiateIcons(List<TopContributor> topContributors, bool isMainLoop) { }

	public void OnAccoladePurchased(List<AccoladeType> purchasedAccoladeTypes) { }

	public void ShowAccolades(PlayerContentInfo playerContentInfo) { }

}

