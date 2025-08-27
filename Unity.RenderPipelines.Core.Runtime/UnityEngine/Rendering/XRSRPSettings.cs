namespace UnityEngine.Rendering;

public class XRSRPSettings
{

	public static bool enabled
	{
		 get { } //Length: 3
	}

	public static RenderTextureDescriptor eyeTextureDesc
	{
		 get { } //Length: 50
	}

	public static int eyeTextureHeight
	{
		 get { } //Length: 3
	}

	public static int eyeTextureWidth
	{
		 get { } //Length: 3
	}

	public static bool isDeviceActive
	{
		 get { } //Length: 3
	}

	public static string loadedDeviceName
	{
		 get { } //Length: 44
	}

	public static int mirrorViewMode
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public static float occlusionMeshScale
	{
		 get { } //Length: 4
		 set { } //Length: 3
	}

	public static String[] supportedDevices
	{
		 get { } //Length: 9410
	}

	public XRSRPSettings() { }

	public static bool get_enabled() { }

	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	public static int get_eyeTextureHeight() { }

	public static int get_eyeTextureWidth() { }

	public static bool get_isDeviceActive() { }

	public static string get_loadedDeviceName() { }

	public static int get_mirrorViewMode() { }

	public static float get_occlusionMeshScale() { }

	public static String[] get_supportedDevices() { }

	public static void set_mirrorViewMode(int value) { }

	public static void set_occlusionMeshScale(float value) { }

}

