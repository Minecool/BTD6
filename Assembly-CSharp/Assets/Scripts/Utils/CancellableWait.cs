namespace Assets.Scripts.Utils;

public class CancellableWait
{
	[CompilerGenerated]
	private struct <MonitorTaskAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellableWait <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly TimeSpan waitTime; //Field offset: 0x10
	private readonly object cancellerLock; //Field offset: 0x18
	private CancellationTokenSource canceller; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsCancelled>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	private bool <IsCompletedSuccessfully>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; //Field offset: 0x30
	private Task _task; //Field offset: 0x38

	public private Exception Exception
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool IsCancelled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsCompletedSuccessfully
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Task Task
	{
		 get { } //Length: 102
	}

	public CancellableWait(TimeSpan waitTime, bool autoStart) { }

	public void Cancel() { }

	[CompilerGenerated]
	public Exception get_Exception() { }

	[CompilerGenerated]
	public bool get_IsCancelled() { }

	[CompilerGenerated]
	public bool get_IsCompletedSuccessfully() { }

	[CompilerGenerated]
	public bool get_IsRunning() { }

	public Task get_Task() { }

	private void LockCancelAndDispose() { }

	[AsyncStateMachine(typeof(<MonitorTaskAsync>d__25))]
	private void MonitorTaskAsync() { }

	[CompilerGenerated]
	private void set_Exception(Exception value) { }

	[CompilerGenerated]
	private void set_IsCancelled(bool value) { }

	[CompilerGenerated]
	private void set_IsCompletedSuccessfully(bool value) { }

	[CompilerGenerated]
	private void set_IsRunning(bool value) { }

	public void Start() { }

}

