namespace Assets.Scripts.Unity.Utils;

public class NkLibrary
{
	[CompilerGenerated]
	private struct <FlagDetection>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NkLibrary <>4__this; //Field offset: 0x20
		private IsValidLibraryThread <libCheckThread>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetServerTime>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public TimeSpan timeout; //Field offset: 0x20
		public NkLibrary <>4__this; //Field offset: 0x28
		private TimeSpan <subTaskTimeout>5__2; //Field offset: 0x30
		private Task<DateTime> <remoteTimeTask>5__3; //Field offset: 0x38
		private TimeSpan <startAt>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TimeDetection>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NkLibrary <>4__this; //Field offset: 0x20
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class IsValidLibraryThread
	{
		private readonly string dataPath; //Field offset: 0x10
		private bool runLibCheckThread; //Field offset: 0x18
		private bool isModding; //Field offset: 0x19

		public bool IsFailedDetection
		{
			 get { } //Length: 24
		}

		public IsValidLibraryThread(string dataPath) { }

		public bool get_IsFailedDetection() { }

		public void Stop() { }

		public void ThreadProc() { }

	}

	private class NkLibraryManager : MonoBehaviourSingleton<NkLibraryManager>
	{
		[CompilerGenerated]
		private struct <OnDisable>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public NkLibraryManager <>4__this; //Field offset: 0x28
			private YieldAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private IsValidLibraryThread libCheckThread; //Field offset: 0x20

		public NkLibraryManager() { }

		public void Initialize(ref IsValidLibraryThread libCheckThread) { }

		protected virtual void OnApplicationQuit() { }

		[AsyncStateMachine(typeof(<OnDisable>d__2))]
		private void OnDisable() { }

	}

	private struct Sample
	{
		public TimeSpan localPoint; //Field offset: 0x0
		public DateTime remotePoint; //Field offset: 0x8

	}

	private static NkLibrary _instance; //Field offset: 0x0
	private const byte kMaxSampleFailCount = 5; //Field offset: 0x0
	private const string kLogTag = "<color=#E138CB>[NkLibrary]</color>"; //Field offset: 0x0
	private const string NKLibraryName = "NKHelper"; //Field offset: 0x0
	private const string NKLibraryHash = "hFSw0DVmRNbOoQuYoiNaG8GFh6u1Y45YDd4kxfYFvQE="; //Field offset: 0x0
	private static readonly TimeSpan kSampleInterval; //Field offset: 0x8
	private static readonly TimeSpan kWaitForRaceInterval; //Field offset: 0x10
	private static readonly TimeSpan kRequestTimeout; //Field offset: 0x18
	private static readonly TimeSpan kProcessCheckInterval; //Field offset: 0x20
	private List<Sample> samples; //Field offset: 0x10
	private uint sampleFailCount; //Field offset: 0x18
	private bool isFailedDetection; //Field offset: 0x1C
	private bool isModding; //Field offset: 0x1D
	private readonly Task timeDetectionTask; //Field offset: 0x20
	private readonly Task flagDetectionTask; //Field offset: 0x28

	public static NkLibrary Instance
	{
		 get { } //Length: 492
	}

	private TimeSpan Now
	{
		private get { } //Length: 87
	}

	private bool UseTimeDetection
	{
		private get { } //Length: 72
	}

	private Double[] _Result() { }

	private static NkLibrary() { }

	public NkLibrary() { }

	[AsyncStateMachine(typeof(<FlagDetection>d__31))]
	private Task FlagDetection() { }

	public static NkLibrary get_Instance() { }

	private TimeSpan get_Now() { }

	private bool get_UseTimeDetection() { }

	private Task<DateTime> GetRemoteTimeTask(TimeSpan timeout) { }

	[AsyncStateMachine(typeof(<GetServerTime>d__27))]
	private Task<DateTime> GetServerTime(TimeSpan timeout) { }

	private static bool IsValidLibrary(string dataPath) { }

	private static void LogError(string message) { }

	private static void LogInfo(string message) { }

	private static bool NKFlag() { }

	public static Double[] Result() { }

	[AsyncStateMachine(typeof(<TimeDetection>d__26))]
	private Task TimeDetection() { }

}

