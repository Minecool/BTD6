//Type is in global namespace

public class AnimationEventAudio : ScriptableObject
{
	public List<AudioClip> audioClips; //Field offset: 0x18
	public string groupId; //Field offset: 0x20
	public int groupLimit; //Field offset: 0x28
	public float volume; //Field offset: 0x2C
	public float delay; //Field offset: 0x30

	public AnimationEventAudio() { }

}

