namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : object, ISubAssetNotDuplicatable
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 144
	}

	public AudioMixer get_audioMixer() { }

	private static IntPtr get_audioMixer_Injected(IntPtr _unity_self) { }

}

