namespace Assets.Scripts.Unity.Audio;

public class MusicFader
{
	[CompilerGenerated]
	private bool <IsFading>k__BackingField; //Field offset: 0x10
	private AudioFactory audioFactory; //Field offset: 0x18
	private AudioSource musicSource; //Field offset: 0x20
	private AudioClip queuedAudioClip; //Field offset: 0x28
	private float currentTime; //Field offset: 0x30
	private float startVolume; //Field offset: 0x34
	private bool queueReady; //Field offset: 0x38

	public bool IsFading
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MusicFader(AudioFactory audioFactory, AudioSource source) { }

	public void FadeMusic() { }

	[CompilerGenerated]
	public bool get_IsFading() { }

	public float GetFadeTimeRemaining() { }

	[CompilerGenerated]
	public void set_IsFading(bool value) { }

	public void SetQueuedTrack(AudioClip clip) { }

}

