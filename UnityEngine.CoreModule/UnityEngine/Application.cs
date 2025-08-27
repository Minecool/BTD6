namespace UnityEngine;

[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		public LogCallback(object object, IntPtr method) { }

		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		public LowMemoryCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String> deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action unloading; //Field offset: 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	public static event Action<String> deepLinkActivated
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	public static event Action<Boolean> focusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 255
		 remove { } //Length: 220
	}

	public static event LowMemoryCallback lowMemory
	{
		[CompilerGenerated]
		 add { } //Length: 238
		[CompilerGenerated]
		 remove { } //Length: 238
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		 add { } //Length: 242
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static string cloudProjectId
	{
		[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
		 get { } //Length: 222
	}

	public static string dataPath
	{
		[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
		 get { } //Length: 222
	}

	public static string identifier
	{
		[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
		 get { } //Length: 222
	}

	public static NetworkReachability internetReachability
	{
		[FreeFunction("GetInternetReachability")]
		 get { } //Length: 42
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		 get { } //Length: 42
	}

	public static bool isConsolePlatform
	{
		 get { } //Length: 131
	}

	public static bool isEditor
	{
		 get { } //Length: 5
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		 get { } //Length: 42
	}

	public static bool isMobilePlatform
	{
		 get { } //Length: 146
	}

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		 get { } //Length: 42
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		 get { } //Length: 222
	}

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static string productName
	{
		[FreeFunction("GetPlayerSettings().GetProductName")]
		 get { } //Length: 222
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		 get { } //Length: 42
	}

	public static string streamingAssetsPath
	{
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		 get { } //Length: 222
	}

	public static SystemLanguage systemLanguage
	{
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		 get { } //Length: 42
	}

	public static int targetFrameRate
	{
		[FreeFunction("GetTargetFrameRate")]
		 get { } //Length: 42
		[FreeFunction("SetTargetFrameRate")]
		 set { } //Length: 49
	}

	public static string temporaryCachePath
	{
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		 get { } //Length: 222
	}

	public static string unityVersion
	{
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
		 get { } //Length: 222
	}

	public static string version
	{
		[FreeFunction("GetApplicationInfo().GetVersion")]
		 get { } //Length: 222
	}

	private static Application() { }

	[CompilerGenerated]
	public static void add_deepLinkActivated(Action<String> value) { }

	[CompilerGenerated]
	public static void add_focusChanged(Action<Boolean> value) { }

	public static void add_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void add_lowMemory(LowMemoryCallback value) { }

	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
	public static string get_cloudProjectId() { }

	private static void get_cloudProjectId_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	public static string get_dataPath() { }

	private static void get_dataPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
	public static string get_identifier() { }

	private static void get_identifier_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetInternetReachability")]
	public static NetworkReachability get_internetReachability() { }

	[FreeFunction("::IsBatchmode")]
	public static bool get_isBatchMode() { }

	public static bool get_isConsolePlatform() { }

	public static bool get_isEditor() { }

	[FreeFunction("IsPlayerFocused")]
	public static bool get_isFocused() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunction("IsWorldPlaying")]
	public static bool get_isPlaying() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	public static string get_persistentDataPath() { }

	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	public static RuntimePlatform get_platform() { }

	[FreeFunction("GetPlayerSettings().GetProductName")]
	public static string get_productName() { }

	private static void get_productName_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	public static bool get_runInBackground() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	public static string get_streamingAssetsPath() { }

	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunction("GetTargetFrameRate")]
	public static int get_targetFrameRate() { }

	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	public static string get_temporaryCachePath() { }

	private static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	public static string get_unityVersion() { }

	private static void get_unityVersion_Injected(out ManagedSpanWrapper ret) { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	public static string get_version() { }

	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	[RequiredByNativeCode]
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	private static void Internal_InitializeExitCancellationToken() { }

	[RequiredByNativeCode]
	private static void Internal_RaiseExitCancellationToken() { }

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url) { }

	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }

	public static void Quit() { }

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode) { }

	[CompilerGenerated]
	public static void remove_deepLinkActivated(Action<String> value) { }

	[CompilerGenerated]
	public static void remove_focusChanged(Action<Boolean> value) { }

	public static void remove_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void remove_lowMemory(LowMemoryCallback value) { }

	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[FreeFunction("SetTargetFrameRate")]
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined) { }

}

