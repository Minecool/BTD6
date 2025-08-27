namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
public sealed class VideoClip : object
{

	public ushort audioTrackCount
	{
		 get { } //Length: 118
	}

	public ulong frameCount
	{
		 get { } //Length: 118
	}

	public double frameRate
	{
		 get { } //Length: 118
	}

	public uint height
	{
		 get { } //Length: 118
	}

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 118
	}

	public string originalPath
	{
		 get { } //Length: 256
	}

	public uint pixelAspectRatioDenominator
	{
		 get { } //Length: 118
	}

	public uint pixelAspectRatioNumerator
	{
		 get { } //Length: 118
	}

	public bool sRGB
	{
		[NativeName("IssRGB")]
		 get { } //Length: 118
	}

	public uint width
	{
		 get { } //Length: 118
	}

	private VideoClip() { }

	public ushort get_audioTrackCount() { }

	private static ushort get_audioTrackCount_Injected(IntPtr _unity_self) { }

	public ulong get_frameCount() { }

	private static ulong get_frameCount_Injected(IntPtr _unity_self) { }

	public double get_frameRate() { }

	private static double get_frameRate_Injected(IntPtr _unity_self) { }

	public uint get_height() { }

	private static uint get_height_Injected(IntPtr _unity_self) { }

	public double get_length() { }

	private static double get_length_Injected(IntPtr _unity_self) { }

	public string get_originalPath() { }

	private static void get_originalPath_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public uint get_pixelAspectRatioDenominator() { }

	private static uint get_pixelAspectRatioDenominator_Injected(IntPtr _unity_self) { }

	public uint get_pixelAspectRatioNumerator() { }

	private static uint get_pixelAspectRatioNumerator_Injected(IntPtr _unity_self) { }

	[NativeName("IssRGB")]
	public bool get_sRGB() { }

	private static bool get_sRGB_Injected(IntPtr _unity_self) { }

	public uint get_width() { }

	private static uint get_width_Injected(IntPtr _unity_self) { }

	public ushort GetAudioChannelCount(ushort audioTrackIdx) { }

	private static ushort GetAudioChannelCount_Injected(IntPtr _unity_self, ushort audioTrackIdx) { }

	public string GetAudioLanguage(ushort audioTrackIdx) { }

	private static void GetAudioLanguage_Injected(IntPtr _unity_self, ushort audioTrackIdx, out ManagedSpanWrapper ret) { }

	public uint GetAudioSampleRate(ushort audioTrackIdx) { }

	private static uint GetAudioSampleRate_Injected(IntPtr _unity_self, ushort audioTrackIdx) { }

}

