namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class PlayInteractableAudio : MonoBehaviour
{
	[Header("List clips in order you want them to play")]
	public List<AudioClip> audioClips; //Field offset: 0x20
	[Header("Timing of clips in order you want them to play (in seconds)")]
	public Single[] audioDelays; //Field offset: 0x28
	[Header("If you want more than one sound to play at the same time")]
	public int groupLimit; //Field offset: 0x30
	[Header("Set to true if you want to play sound straight away")]
	public bool playOnStart; //Field offset: 0x34
	[Header("Set to true if you want to always play at the same speed regardless of fast forward state (ie - ignoring Sim)")]
	public bool ignoreFastForward; //Field offset: 0x35

	public PlayInteractableAudio() { }

	public void PlayAudioTrack() { }

	private void Start() { }

}

