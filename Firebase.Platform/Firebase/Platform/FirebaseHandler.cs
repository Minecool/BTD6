namespace Firebase.Platform;

internal sealed class FirebaseHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__19_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <StopMonoBehaviour>b__19_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public IFirebaseAppUtils appUtils; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal void <CreatePartialOnMainThread>b__0() { }

	}

	public class ApplicationFocusChangedEventArgs : EventArgs
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <HasFocus>k__BackingField; //Field offset: 0x10

		public bool HasFocus
		{
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public ApplicationFocusChangedEventArgs() { }

		[CompilerGenerated]
		public void set_HasFocus(bool value) { }

	}

	private static FirebaseMonoBehaviour firebaseMonoBehaviour; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static IFirebaseAppUtils <AppUtils>k__BackingField; //Field offset: 0x8
	private static int tickCount; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Dispatcher <ThreadDispatcher>k__BackingField; //Field offset: 0x18
	private static FirebaseHandler firebaseHandler; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsPlayMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler<EventArgs> Updated; //Field offset: 0x18
	internal Action UpdatedEventWrapper; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler<ApplicationFocusChangedEventArgs> ApplicationFocusChanged; //Field offset: 0x28

	public private static IFirebaseAppUtils AppUtils
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static FirebaseHandler DefaultInstance
	{
		internal get { } //Length: 79
	}

	public bool IsPlayMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static Dispatcher ThreadDispatcher
	{
		[CompilerGenerated]
		private get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static int TickCount
	{
		 get { } //Length: 78
	}

	private static FirebaseHandler() { }

	private FirebaseHandler() { }

	[CompilerGenerated]
	private void <Update>b__36_0() { }

	internal static void Create(IFirebaseAppUtils appUtils) { }

	internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	[CompilerGenerated]
	public static IFirebaseAppUtils get_AppUtils() { }

	internal static FirebaseHandler get_DefaultInstance() { }

	[CompilerGenerated]
	public bool get_IsPlayMode() { }

	[CompilerGenerated]
	private static Dispatcher get_ThreadDispatcher() { }

	public static int get_TickCount() { }

	internal void OnApplicationFocus(bool hasFocus) { }

	internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	public static TResult RunOnMainThread(Func<TResult> f) { }

	public static Task<TResult> RunOnMainThreadAsync(Func<TResult> f) { }

	[CompilerGenerated]
	private static void set_AppUtils(IFirebaseAppUtils value) { }

	[CompilerGenerated]
	public void set_IsPlayMode(bool value) { }

	[CompilerGenerated]
	private static void set_ThreadDispatcher(Dispatcher value) { }

	internal void StartMonoBehaviour() { }

	internal void StopMonoBehaviour() { }

	internal void Update() { }

}

