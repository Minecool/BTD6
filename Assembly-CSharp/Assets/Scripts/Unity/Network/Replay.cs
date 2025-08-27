namespace Assets.Scripts.Unity.Network;

public abstract class Replay
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public uint elapsed; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <TrimActionsNewerThan>b__0(GameplayAction action) { }

	}

	[CompilerGenerated]
	private struct <Upload>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string replayId; //Field offset: 0x20
		public Replay <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected static readonly int LatestVersion; //Field offset: 0x0
	protected const int kBufferSize = 2048; //Field offset: 0x0
	private const char kDataPrefix = '\u52'; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <randomSeed>k__BackingField; //Field offset: 0x10
	protected List<GameplayAction> actions; //Field offset: 0x18
	[CompilerGenerated]
	private string <CachedSerializedData>k__BackingField; //Field offset: 0x20

	public IReadOnlyList<GameplayAction> Actions
	{
		 get { } //Length: 5
	}

	public string CachedSerializedData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int randomSeed
	{
		[CompilerGenerated]
		 get { } //Length: 94
	}

	private static Replay() { }

	protected Replay(int randomSeed) { }

	public void AddAction(GameplayAction action) { }

	public void Clear() { }

	public static CoopReplay DeserializeMP(Byte[] data) { }

	public static SinglePlayerReplay DeserializeSP(Byte[] data) { }

	public IReadOnlyList<GameplayAction> get_Actions() { }

	[CompilerGenerated]
	public string get_CachedSerializedData() { }

	[CompilerGenerated]
	public int get_randomSeed() { }

	public abstract string Serialize() { }

	[CompilerGenerated]
	public void set_CachedSerializedData(string value) { }

	private void SetDirty() { }

	public void TrimActionsNewerThan(uint elapsed) { }

	[AsyncStateMachine(typeof(<Upload>d__18))]
	public Task Upload(string replayId) { }

}

