namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static Resolution currentResolution
	{
		 get { } //Length: 60
	}

	public static float dpi
	{
		[NativeName("GetDPI")]
		 get { } //Length: 42
	}

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		 get { } //Length: 42
	}

	public static FullScreenMode fullScreenMode
	{
		[NativeName("GetFullscreenMode")]
		 get { } //Length: 42
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static int msaaSamples
	{
		 get { } //Length: 42
	}

	public static ScreenOrientation orientation
	{
		 get { } //Length: 42
	}

	public static Resolution[] resolutions
	{
		[FreeFunction("ScreenScripting::GetResolutions")]
		 get { } //Length: 210
	}

	public static Rect safeArea
	{
		 get { } //Length: 60
	}

	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static Resolution get_currentResolution() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[NativeName("GetFullscreenMode")]
	public static FullScreenMode get_fullScreenMode() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	public static int get_msaaSamples() { }

	public static ScreenOrientation get_orientation() { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	public static Resolution[] get_resolutions() { }

	private static void get_resolutions_Injected(out BlittableArrayWrapper ret) { }

	public static Rect get_safeArea() { }

	private static void get_safeArea_Injected(out Rect ret) { }

	public static int get_sleepTimeout() { }

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	[NativeName("GetRequestedMSAASamples")]
	private static int GetMSAASamples() { }

	private static ScreenOrientation GetScreenOrientation() { }

	public static void set_sleepTimeout(int value) { }

	[NativeName("SetRequestedMSAASamples")]
	public static void SetMSAASamples(int numSamples) { }

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

}

