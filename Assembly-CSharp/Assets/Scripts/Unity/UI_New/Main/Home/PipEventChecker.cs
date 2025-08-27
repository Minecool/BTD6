namespace Assets.Scripts.Unity.UI_New.Main.Home;

public class PipEventChecker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AccoladeTransaction, Int64> <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <CheckAndEnableAccoladePip>b__23_0(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <CheckAndEnableAccoladePip>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PipEventChecker <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x38
		private TaskAwaiter<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum PipEvent
	{
		PARAGON_UPGRADE_AVAILABLE = 0,
		NEW_POWERS_INSTAS = 1,
		NEW_SOCIAL = 2,
		NEW_MAP_BROWSER = 3,
		NEW_GAME_BROWSER = 4,
		SHOW_PIP_IF_METADATA_TRUE = 5,
		NEW_LEGEND = 6,
	}

	public PipEvent pipEvent; //Field offset: 0x20
	public GameObject notifyPipObj; //Field offset: 0x28
	public bool disableOnEnableCheck; //Field offset: 0x30
	public bool updateConstantly; //Field offset: 0x31
	public int updateInterval; //Field offset: 0x34
	private float timer; //Field offset: 0x38
	private bool showing; //Field offset: 0x3C
	private bool hideOverride; //Field offset: 0x3D
	private object metaData; //Field offset: 0x40
	[CompilerGenerated]
	private bool <HasNewAccolade>k__BackingField; //Field offset: 0x48

	public bool HasNewAccolade
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsPipVisible
	{
		 get { } //Length: 29
	}

	public PipEventChecker() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<CheckAndEnableAccoladePip>d__23))]
	private Task CheckAndEnableAccoladePip() { }

	public void CheckEvent(object metaData) { }

	private static bool CheckEvent(PipEvent pipEvent, object metaData) { }

	[CompilerGenerated]
	public bool get_HasNewAccolade() { }

	public bool get_IsPipVisible() { }

	public void Hide(bool hide) { }

	public void OnAccoladePipSeen() { }

	public void OnEnable() { }

	[CompilerGenerated]
	public void set_HasNewAccolade(bool value) { }

	public void Update() { }

}

