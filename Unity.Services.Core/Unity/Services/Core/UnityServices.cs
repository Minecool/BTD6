namespace Unity.Services.Core;

public static class UnityServices
{
	[CompilerGenerated]
	private struct <InitializeAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitializationOptions options; //Field offset: 0x20
		private TaskAwaiter<Object> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<Object> <InstantiationCompletion>k__BackingField; //Field offset: 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; //Field offset: 0x10
	[CompilerGenerated]
	private static readonly Dictionary<String, IUnityServices> <s_Services>k__BackingField; //Field offset: 0x18

	public static string ExternalUserId
	{
		 get { } //Length: 93
		 set { } //Length: 128
	}

	public static IUnityServices Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 84
	}

	internal static TaskCompletionSource<Object> InstantiationCompletion
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		internal set { } //Length: 85
	}

	private static Dictionary<String, IUnityServices> s_Services
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	public static ServicesInitializationState State
	{
		 get { } //Length: 656
	}

	private static UnityServices() { }

	internal static void ClearServices() { }

	public static string get_ExternalUserId() { }

	[CompilerGenerated]
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	internal static TaskCompletionSource<Object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	private static Dictionary<String, IUnityServices> get_s_Services() { }

	public static ServicesInitializationState get_State() { }

	[AsyncStateMachine(typeof(<InitializeAsync>d__26))]
	public static Task InitializeAsync(InitializationOptions options) { }

	public static void set_ExternalUserId(string value) { }

	[CompilerGenerated]
	public static void set_Instance(IUnityServices value) { }

	[CompilerGenerated]
	internal static void set_InstantiationCompletion(TaskCompletionSource<Object> value) { }

}

