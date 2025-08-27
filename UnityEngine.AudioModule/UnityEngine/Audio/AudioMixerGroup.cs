namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : object, ISubAssetNotDuplicatable
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 144
	}

	internal AudioMixerGroup() { }

	public AudioMixer get_audioMixer() { }

	private static IntPtr get_audioMixer_Injected(IntPtr _unity_self) { }

}

