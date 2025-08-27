namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : object, ISubAssetNotDuplicatable
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 51
	}

	internal AudioMixerGroup() { }

	public AudioMixer get_audioMixer() { }

}

