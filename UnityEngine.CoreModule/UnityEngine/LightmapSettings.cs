namespace UnityEngine;

[NativeHeader("Runtime/Graphics/LightmapSettings.h")]
[StaticAccessor("GetLightmapSettings()")]
public sealed class LightmapSettings : object
{

	[Obsolete("Use QualitySettings.desiredColorSpace instead.", False)]
	public static ColorSpace bakedColorSpace
	{
		 get { } //Length: 42
		 set { } //Length: 3
	}

	public static LightmapData[] lightmaps
	{
		[FreeFunction]
		 get { } //Length: 42
		[FreeFunction(ThrowsException = True)]
		 set { } //Length: 51
	}

	public static LightmapsMode lightmapsMode
	{
		 get { } //Length: 42
		[FreeFunction(ThrowsException = True)]
		 set { } //Length: 49
	}

	[Obsolete("Use lightmapsMode instead.", False)]
	public static LightmapsModeLegacy lightmapsModeLegacy
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public static LightProbes lightProbes
	{
		 get { } //Length: 84
		[FreeFunction]
		[NativeName("SetLightProbes")]
		 set { } //Length: 107
	}

	private LightmapSettings() { }

	public static ColorSpace get_bakedColorSpace() { }

	[FreeFunction]
	public static LightmapData[] get_lightmaps() { }

	public static LightmapsMode get_lightmapsMode() { }

	public static LightmapsModeLegacy get_lightmapsModeLegacy() { }

	public static LightProbes get_lightProbes() { }

	private static IntPtr get_lightProbes_Injected() { }

	[NativeName("ResetAndAwakeFromLoad")]
	internal static void Reset() { }

	public static void set_bakedColorSpace(ColorSpace value) { }

	[FreeFunction(ThrowsException = True)]
	public static void set_lightmaps(LightmapData[] value) { }

	[FreeFunction(ThrowsException = True)]
	public static void set_lightmapsMode(LightmapsMode value) { }

	public static void set_lightmapsModeLegacy(LightmapsModeLegacy value) { }

	[FreeFunction]
	[NativeName("SetLightProbes")]
	public static void set_lightProbes(LightProbes value) { }

	private static void set_lightProbes_Injected(IntPtr value) { }

}

