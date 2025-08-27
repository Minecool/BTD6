namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : object, ISubAssetNotDuplicatable
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 51
	}

	internal AudioMixerSnapshot() { }

	public AudioMixer get_audioMixer() { }

}

