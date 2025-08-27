namespace Unity.Services.Core;

internal static class UnityThreadUtils
{
	private static int s_UnityThreadId; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; //Field offset: 0x8

	public static bool IsRunningOnUnityThread
	{
		 get { } //Length: 83
	}

	private static TaskScheduler UnityThreadScheduler
	{
		[CompilerGenerated]
		private set { } //Length: 61
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void CaptureUnityThreadInfo() { }

	public static bool get_IsRunningOnUnityThread() { }

	[CompilerGenerated]
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

}

