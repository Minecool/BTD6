namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 42
	}

	public static int antiAliasing
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static bool billboardsFaceCameraPosition
	{
		 get { } //Length: 42
	}

	public static ColorSpace desiredColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 42
	}

	public static bool enableLODCrossFade
	{
		 set { } //Length: 51
	}

	public static int pixelLightCount
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	[NativeProperty("ShadowmaskMode")]
	public static ShadowmaskMode shadowmaskMode
	{
		 get { } //Length: 42
	}

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_activeColorSpace() { }

	public static int get_antiAliasing() { }

	public static bool get_billboardsFaceCameraPosition() { }

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_desiredColorSpace() { }

	public static int get_pixelLightCount() { }

	public static ShadowmaskMode get_shadowmaskMode() { }

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	public static void set_antiAliasing(int value) { }

	public static void set_enableLODCrossFade(bool value) { }

	public static void set_pixelLightCount(int value) { }

}

