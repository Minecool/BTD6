namespace Firebase;

public sealed class FirebaseApp : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CreateDelegate <>9__14_0; //Field offset: 0x8
		public static Func<Boolean> <>9__47_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal FirebaseApp <Create>b__14_0() { }

		internal bool <CreateAndTrack>b__47_0() { }

	}

	private sealed class CreateDelegate : MulticastDelegate
	{

		public CreateDelegate(object object, IntPtr method) { }

		public override FirebaseApp Invoke() { }

	}

	internal class EnableModuleParams
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private string <CppModuleName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private string <CSharpClassName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <AlwaysEnable>k__BackingField; //Field offset: 0x20

		public bool AlwaysEnable
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public string CppModuleName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string CSharpClassName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public EnableModuleParams(string csharp, string cpp, bool always = false) { }

		[CompilerGenerated]
		public bool get_AlwaysEnable() { }

		[CompilerGenerated]
		public string get_CppModuleName() { }

		[CompilerGenerated]
		public string get_CSharpClassName() { }

		[CompilerGenerated]
		public void set_AlwaysEnable(bool value) { }

		[CompilerGenerated]
		public void set_CppModuleName(string value) { }

		[CompilerGenerated]
		public void set_CSharpClassName(string value) { }

	}

	internal static readonly object disposeLock; //Field offset: 0x0
	private static Dictionary<String, FirebaseApp> nameToProxy; //Field offset: 0x8
	private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy; //Field offset: 0x10
	private static bool AppUtilCallbacksInitialized; //Field offset: 0x18
	private static object AppUtilCallbacksLock; //Field offset: 0x20
	private static bool PreventOnAllAppsDestroyed; //Field offset: 0x28
	private static bool crashlyticsInitializationAttempted; //Field offset: 0x29
	private static bool userAgentRegistered; //Field offset: 0x2A
	private static int CheckDependenciesThread; //Field offset: 0x2C
	private static object CheckDependenciesThreadLock; //Field offset: 0x30
	private HandleRef swigCPtr; //Field offset: 0x10
	private bool swigCMemOwn; //Field offset: 0x20
	private string name; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler AppDisposed; //Field offset: 0x30
	private FirebaseAppPlatform appPlatform; //Field offset: 0x38

	public static FirebaseApp DefaultInstance
	{
		 get { } //Length: 479
	}

	public static string DefaultName
	{
		 get { } //Length: 284
	}

	public static LogLevel LogLevel
	{
		 get { } //Length: 150
	}

	public string Name
	{
		 get { } //Length: 130
	}

	internal string NameInternal
	{
		internal get { } //Length: 321
	}

	private static FirebaseApp() { }

	internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn) { }

	private void AddReference() { }

	internal static void AppSetDefaultConfigPath(string path) { }

	public static FirebaseApp Create() { }

	private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	internal static FirebaseApp CreateInternal() { }

	public override void Dispose() { }

	public void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public static FirebaseApp get_DefaultInstance() { }

	public static string get_DefaultName() { }

	public static LogLevel get_LogLevel() { }

	public string get_Name() { }

	internal string get_NameInternal() { }

	internal static HandleRef getCPtr(FirebaseApp obj) { }

	public static FirebaseApp GetInstance(string name) { }

	private static void InitializeAppUtilCallbacks() { }

	private static bool InitializeCrashlyticsIfPresent() { }

	private static bool IsCheckDependenciesRunning() { }

	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	private static void OnAllAppsDestroyed() { }

	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	private void RemoveReference() { }

	private static void ThrowIfCheckDependenciesRunning() { }

	private void ThrowIfNull() { }

	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

}

