namespace Assets.Scripts.Models;

[DataContract]
public class UpdateSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<PlatformUpdateSpecialCase> <>9__21_0; //Field offset: 0x8
		public static Predicate<PlatformUpdateSpecialCase> <>9__21_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <TryGetSpecialCase>b__21_0(PlatformUpdateSpecialCase x) { }

		internal bool <TryGetSpecialCase>b__21_1(PlatformUpdateSpecialCase x) { }

	}

	[CompilerGenerated]
	private struct <DownloadAndParse>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UpdateSettings> <>t__builder; //Field offset: 0x8
		public Environments environments; //Field offset: 0x20
		public int appId; //Field offset: 0x24
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private PlatformUpdateSpecialCase[] <SpecialCases>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, PlatformUpdateSettings> <PlatformOverrides>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private PlatformUpdateSettings <Default>k__BackingField; //Field offset: 0x20

	private static string CurrentStoreName
	{
		private get { } //Length: 81
	}

	private static Version CurrentVersion
	{
		private get { } //Length: 124
	}

	[DataMember]
	private PlatformUpdateSettings Default
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public static Version DefaultMinVersion
	{
		 get { } //Length: 88
	}

	[DataMember]
	private Dictionary<String, PlatformUpdateSettings> PlatformOverrides
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	[DataMember]
	private PlatformUpdateSpecialCase[] SpecialCases
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public UpdateSettings() { }

	[AsyncStateMachine(typeof(<DownloadAndParse>d__24))]
	public static Task<UpdateSettings> DownloadAndParse(int appId, Environments environments) { }

	private static string get_CurrentStoreName() { }

	private static Version get_CurrentVersion() { }

	[CompilerGenerated]
	private PlatformUpdateSettings get_Default() { }

	public static Version get_DefaultMinVersion() { }

	[CompilerGenerated]
	private Dictionary<String, PlatformUpdateSettings> get_PlatformOverrides() { }

	[CompilerGenerated]
	private PlatformUpdateSpecialCase[] get_SpecialCases() { }

	private PlatformUpdateSettings GetPlatformUpdateSettings() { }

	private static string GetStorePlatformName() { }

	public bool IsForceUpdateEnabled() { }

	public bool IsSoftUpdateEnabled() { }

	[CompilerGenerated]
	private void set_Default(PlatformUpdateSettings value) { }

	[CompilerGenerated]
	private void set_PlatformOverrides(Dictionary<String, PlatformUpdateSettings> value) { }

	[CompilerGenerated]
	private void set_SpecialCases(PlatformUpdateSpecialCase[] value) { }

	private bool TryGetPlatformOverride(out PlatformUpdateSettings platformUpdateSettings) { }

	private bool TryGetSpecialCase(out PlatformUpdateSettings platformUpdateSettings) { }

}

