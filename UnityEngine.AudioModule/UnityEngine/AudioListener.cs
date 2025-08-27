namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioListener : AudioBehaviour
{

	[NativeProperty("ListenerPause")]
	public static bool pause
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public static float volume
	{
		 get { } //Length: 42
		 set { } //Length: 58
	}

	public AudioListener() { }

	public static bool get_pause() { }

	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	private static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self) { }

	public static float get_volume() { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	public static Single[] GetOutputData(int numSamples, int channel) { }

	public static void GetOutputData(Single[] samples, int channel) { }

	[NativeThrows]
	private static void GetOutputDataHelper(out Single[] samples, int channel) { }

	private static void GetOutputDataHelper_Injected(out BlittableArrayWrapper samples, int channel) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	public static Single[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	public static void GetSpectrumData(Single[] samples, int channel, FFTWindow window) { }

	[NativeThrows]
	private static void GetSpectrumDataHelper(out Single[] samples, int channel, FFTWindow window) { }

	private static void GetSpectrumDataHelper_Injected(out BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	public static void set_pause(bool value) { }

	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	private static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value) { }

	public static void set_volume(float value) { }

}

