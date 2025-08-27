namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
public sealed class VideoClip : object
{

	public ushort audioTrackCount
	{
		 get { } //Length: 51
	}

	public ulong frameCount
	{
		 get { } //Length: 51
	}

	public double frameRate
	{
		 get { } //Length: 51
	}

	public uint height
	{
		 get { } //Length: 51
	}

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 51
	}

	public string originalPath
	{
		 get { } //Length: 51
	}

	public uint pixelAspectRatioDenominator
	{
		 get { } //Length: 51
	}

	public uint pixelAspectRatioNumerator
	{
		 get { } //Length: 51
	}

	public bool sRGB
	{
		[NativeName("IssRGB")]
		 get { } //Length: 51
	}

	public uint width
	{
		 get { } //Length: 51
	}

	private VideoClip() { }

	public ushort get_audioTrackCount() { }

	public ulong get_frameCount() { }

	public double get_frameRate() { }

	public uint get_height() { }

	public double get_length() { }

	public string get_originalPath() { }

	public uint get_pixelAspectRatioDenominator() { }

	public uint get_pixelAspectRatioNumerator() { }

	[NativeName("IssRGB")]
	public bool get_sRGB() { }

	public uint get_width() { }

	public ushort GetAudioChannelCount(ushort audioTrackIdx) { }

	public string GetAudioLanguage(ushort audioTrackIdx) { }

	public uint GetAudioSampleRate(ushort audioTrackIdx) { }

}

