namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioClip : object
{
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		public PCMReaderCallback(object object, IntPtr method) { }

		public override void Invoke(Single[] data) { }

	}

	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		public PCMSetPositionCallback(object object, IntPtr method) { }

		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	private event PCMReaderCallback m_PCMReaderCallback
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event PCMSetPositionCallback m_PCMSetPositionCallback
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public bool ambisonic
	{
		 get { } //Length: 51
	}

	[NativeProperty("ChannelCount")]
	public int channels
	{
		 get { } //Length: 51
	}

	public int frequency
	{
		 get { } //Length: 51
	}

	[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
	public bool isReadyToPlay
	{
		[NativeName("ReadyToPlay")]
		 get { } //Length: 51
	}

	[NativeProperty("LengthSec")]
	public float length
	{
		 get { } //Length: 51
	}

	public bool loadInBackground
	{
		 get { } //Length: 51
	}

	public AudioDataLoadState loadState
	{
		[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public AudioClipLoadType loadType
	{
		 get { } //Length: 51
	}

	public bool preloadAudioData
	{
		 get { } //Length: 51
	}

	[NativeProperty("SampleCount")]
	public int samples
	{
		 get { } //Length: 51
	}

	private AudioClip() { }

	[CompilerGenerated]
	private void add_m_PCMReaderCallback(PCMReaderCallback value) { }

	[CompilerGenerated]
	private void add_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	private static AudioClip Construct_Internal() { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	public bool get_ambisonic() { }

	public int get_channels() { }

	public int get_frequency() { }

	[NativeName("ReadyToPlay")]
	public bool get_isReadyToPlay() { }

	public float get_length() { }

	public bool get_loadInBackground() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	public AudioDataLoadState get_loadState() { }

	public AudioClipLoadType get_loadType() { }

	public bool get_preloadAudioData() { }

	public int get_samples() { }

	private static bool GetData(AudioClip clip, out Single[] data, int numSamples, int samplesOffset) { }

	public bool GetData(Single[] data, int offsetSamples) { }

	private string GetName() { }

	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	public bool LoadAudioData() { }

	[CompilerGenerated]
	private void remove_m_PCMReaderCallback(PCMReaderCallback value) { }

	[CompilerGenerated]
	private void remove_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	private static bool SetData(AudioClip clip, Single[] data, int numsamples, int samplesOffset) { }

	public bool SetData(Single[] data, int offsetSamples) { }

	public bool UnloadAudioData() { }

}

