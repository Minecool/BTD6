namespace Assets.Scripts.Unity.Bridge;

public class AudioTask
{
	public AudioClipReference audioClipRef; //Field offset: 0x10
	public AudioClip audioClip; //Field offset: 0x18
	public bool play; //Field offset: 0x20
	public bool unique; //Field offset: 0x21
	public bool stop; //Field offset: 0x22
	public bool loop; //Field offset: 0x23
	public bool pause; //Field offset: 0x24
	public string uniqueId; //Field offset: 0x28
	public float volume; //Field offset: 0x30
	public float pitch; //Field offset: 0x34
	public float delay; //Field offset: 0x38
	public string groupId; //Field offset: 0x40
	public int groupLimit; //Field offset: 0x48
	public AudioType audioType; //Field offset: 0x4C
	public bool pauseState; //Field offset: 0x50

	public AudioTask() { }

}

