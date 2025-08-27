namespace Assets.Scripts.Unity.Utils.ElasticSearch;

public class ElasticSearchUpdater
{
	[CompilerGenerated]
	private struct <SendRequest>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ElasticSearchUpdateStatus> <>t__builder; //Field offset: 0x8
		public ElasticSearchUpdater <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kLogTag = "ES Updater"; //Field offset: 0x0
	private readonly string esIndex; //Field offset: 0x10
	private readonly string docId; //Field offset: 0x18
	private readonly bool hasValidId; //Field offset: 0x20
	private readonly Dictionary<String, String> modifiers; //Field offset: 0x28
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ElasticSearchUpdateStatus <Status>k__BackingField; //Field offset: 0x38

	public private Exception Exception
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private ElasticSearchUpdateStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ElasticSearchUpdater(string esIndex, string docId) { }

	[CompilerGenerated]
	public Exception get_Exception() { }

	[CompilerGenerated]
	public ElasticSearchUpdateStatus get_Status() { }

	private static bool HasValidId(string esIndex, string docId) { }

	public void IncrementValue(string property, int increment) { }

	public void ModifyValue(string property, string value) { }

	public void ModifyValue(string property, int value) { }

	public void ModifyValue(string property, bool value) { }

	[AsyncStateMachine(typeof(<SendRequest>d__19))]
	public Task<ElasticSearchUpdateStatus> SendRequest() { }

	[CompilerGenerated]
	private void set_Exception(Exception value) { }

	[CompilerGenerated]
	private void set_Status(ElasticSearchUpdateStatus value) { }

}

